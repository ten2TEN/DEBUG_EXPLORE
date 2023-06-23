using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;

namespace Newtonsoft.Json.Utilities
{
	internal static class DynamicWrapper
	{
		private readonly static object _lock;

		private readonly static WrapperDictionary _wrapperDictionary;

		private static System.Reflection.Emit.ModuleBuilder _moduleBuilder;

		private static System.Reflection.Emit.ModuleBuilder ModuleBuilder
		{
			get
			{
				DynamicWrapper.Init();
				return DynamicWrapper._moduleBuilder;
			}
		}

		static DynamicWrapper()
		{
			DynamicWrapper._lock = new object();
			DynamicWrapper._wrapperDictionary = new WrapperDictionary();
		}

		public static T CreateWrapper<T>(object realObject)
		where T : class
		{
			Type wrapper = DynamicWrapper.GetWrapper(typeof(T), realObject.GetType());
			DynamicWrapperBase dynamicWrapperBase = (DynamicWrapperBase)Activator.CreateInstance(wrapper);
			dynamicWrapperBase.UnderlyingObject = realObject;
			return (T)(dynamicWrapperBase as T);
		}

		private static Type GenerateWrapperType(Type interfaceType, Type underlyingType)
		{
			System.Reflection.Emit.ModuleBuilder moduleBuilder = DynamicWrapper.ModuleBuilder;
			string str = "{0}_{1}_Wrapper".FormatWith(CultureInfo.InvariantCulture, interfaceType.Name, underlyingType.Name);
			Type type = typeof(DynamicWrapperBase);
			Type[] typeArray = new Type[] { interfaceType };
			TypeBuilder typeBuilder = moduleBuilder.DefineType(str, TypeAttributes.Sealed, type, typeArray);
			WrapperMethodBuilder wrapperMethodBuilder = new WrapperMethodBuilder(underlyingType, typeBuilder);
			foreach (MethodInfo allMethod in interfaceType.GetAllMethods())
			{
				wrapperMethodBuilder.Generate(allMethod);
			}
			return typeBuilder.CreateType();
		}

		private static byte[] GetStrongKey()
		{
			byte[] numArray;
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Newtonsoft.Json.Dynamic.snk"))
			{
				if (manifestResourceStream == null)
				{
					throw new MissingManifestResourceException("Should have Newtonsoft.Json.Dynamic.snk as an embedded resource.");
				}
				int length = (int)manifestResourceStream.Length;
				byte[] numArray1 = new byte[length];
				manifestResourceStream.Read(numArray1, 0, length);
				numArray = numArray1;
			}
			return numArray;
		}

		public static object GetUnderlyingObject(object wrapper)
		{
			DynamicWrapperBase dynamicWrapperBase = wrapper as DynamicWrapperBase;
			if (dynamicWrapperBase == null)
			{
				throw new ArgumentException("Object is not a wrapper.", "wrapper");
			}
			return dynamicWrapperBase.UnderlyingObject;
		}

		public static Type GetWrapper(Type interfaceType, Type realObjectType)
		{
			Type type = DynamicWrapper._wrapperDictionary.GetType(interfaceType, realObjectType);
			if (type == null)
			{
				lock (DynamicWrapper._lock)
				{
					type = DynamicWrapper._wrapperDictionary.GetType(interfaceType, realObjectType);
					if (type == null)
					{
						type = DynamicWrapper.GenerateWrapperType(interfaceType, realObjectType);
						DynamicWrapper._wrapperDictionary.SetType(interfaceType, realObjectType, type);
					}
				}
			}
			return type;
		}

		private static void Init()
		{
			if (DynamicWrapper._moduleBuilder == null)
			{
				lock (DynamicWrapper._lock)
				{
					if (DynamicWrapper._moduleBuilder == null)
					{
						AssemblyName assemblyName = new AssemblyName("Newtonsoft.Json.Dynamic")
						{
							KeyPair = new StrongNameKeyPair(DynamicWrapper.GetStrongKey())
						};
						AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
						DynamicWrapper._moduleBuilder = assemblyBuilder.DefineDynamicModule("Newtonsoft.Json.DynamicModule", false);
					}
				}
			}
		}
	}
}