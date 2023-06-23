using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;

namespace Newtonsoft.Json.Utilities
{
	internal class DynamicReflectionDelegateFactory : ReflectionDelegateFactory
	{
		public static DynamicReflectionDelegateFactory Instance;

		static DynamicReflectionDelegateFactory()
		{
			DynamicReflectionDelegateFactory.Instance = new DynamicReflectionDelegateFactory();
		}

		public DynamicReflectionDelegateFactory()
		{
		}

		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(string.Concat("Create", type.FullName), typeof(T), ReflectionUtils.EmptyTypes, type);
			dynamicMethod.InitLocals = true;
			this.GenerateCreateDefaultConstructorIL(type, dynamicMethod.GetILGenerator());
			return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
		}

		private static DynamicMethod CreateDynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner)
		{
			return (!owner.IsInterface() ? new DynamicMethod(name, returnType, parameterTypes, owner, true) : new DynamicMethod(name, returnType, parameterTypes, owner.Module, true));
		}

		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			string str = string.Concat("Get", propertyInfo.Name);
			Type type = typeof(T);
			Type[] typeArray = new Type[] { typeof(object) };
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(str, type, typeArray, propertyInfo.DeclaringType);
			this.GenerateCreateGetPropertyIL(propertyInfo, dynamicMethod.GetILGenerator());
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			string str = string.Concat("Get", fieldInfo.Name);
			Type type = typeof(T);
			Type[] typeArray = new Type[] { typeof(object) };
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(str, type, typeArray, fieldInfo.DeclaringType);
			this.GenerateCreateGetFieldIL(fieldInfo, dynamicMethod.GetILGenerator());
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			string str = method.ToString();
			Type type = typeof(object);
			Type[] typeArray = new Type[] { typeof(object), typeof(object[]) };
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(str, type, typeArray, method.DeclaringType);
			this.GenerateCreateMethodCallIL(method, dynamicMethod.GetILGenerator());
			return (MethodCall<T, object>)dynamicMethod.CreateDelegate(typeof(MethodCall<T, object>));
		}

		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			string str = string.Concat("Set", fieldInfo.Name);
			Type[] typeArray = new Type[] { typeof(T), typeof(object) };
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(str, null, typeArray, fieldInfo.DeclaringType);
			DynamicReflectionDelegateFactory.GenerateCreateSetFieldIL(fieldInfo, dynamicMethod.GetILGenerator());
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			string str = string.Concat("Set", propertyInfo.Name);
			Type[] typeArray = new Type[] { typeof(T), typeof(object) };
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.CreateDynamicMethod(str, null, typeArray, propertyInfo.DeclaringType);
			DynamicReflectionDelegateFactory.GenerateCreateSetPropertyIL(propertyInfo, dynamicMethod.GetILGenerator());
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		private void GenerateCreateDefaultConstructorIL(Type type, ILGenerator generator)
		{
			if (!type.IsValueType())
			{
				ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ReflectionUtils.EmptyTypes, null);
				if (constructor == null)
				{
					throw new ArgumentException("Could not get constructor for {0}.".FormatWith(CultureInfo.InvariantCulture, type));
				}
				generator.Emit(OpCodes.Newobj, constructor);
			}
			else
			{
				generator.DeclareLocal(type);
				generator.Emit(OpCodes.Ldloc_0);
				generator.Emit(OpCodes.Box, type);
			}
			generator.Return();
		}

		private void GenerateCreateGetFieldIL(FieldInfo fieldInfo, ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				generator.PushInstance(fieldInfo.DeclaringType);
			}
			generator.Emit(OpCodes.Ldfld, fieldInfo);
			generator.BoxIfNeeded(fieldInfo.FieldType);
			generator.Return();
		}

		private void GenerateCreateGetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator)
		{
			MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException("Property '{0}' does not have a getter.".FormatWith(CultureInfo.InvariantCulture, propertyInfo.Name));
			}
			if (!getMethod.IsStatic)
			{
				generator.PushInstance(propertyInfo.DeclaringType);
			}
			generator.CallMethod(getMethod);
			generator.BoxIfNeeded(propertyInfo.PropertyType);
			generator.Return();
		}

		private void GenerateCreateMethodCallIL(MethodBase method, ILGenerator generator)
		{
			ParameterInfo[] parameters = method.GetParameters();
			Label label = generator.DefineLabel();
			generator.Emit(OpCodes.Ldarg_1);
			generator.Emit(OpCodes.Ldlen);
			generator.Emit(OpCodes.Ldc_I4, (int)parameters.Length);
			generator.Emit(OpCodes.Beq, label);
			generator.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(ReflectionUtils.EmptyTypes));
			generator.Emit(OpCodes.Throw);
			generator.MarkLabel(label);
			if (!method.IsConstructor && !method.IsStatic)
			{
				generator.PushInstance(method.DeclaringType);
			}
			for (int i = 0; i < (int)parameters.Length; i++)
			{
				generator.Emit(OpCodes.Ldarg_1);
				generator.Emit(OpCodes.Ldc_I4, i);
				generator.Emit(OpCodes.Ldelem_Ref);
				generator.UnboxIfNeeded(parameters[i].ParameterType);
			}
			if (method.IsConstructor)
			{
				generator.Emit(OpCodes.Newobj, (ConstructorInfo)method);
			}
			else if (method.IsFinal || !method.IsVirtual)
			{
				generator.CallMethod((MethodInfo)method);
			}
			Type type = (method.IsConstructor ? method.DeclaringType : ((MethodInfo)method).ReturnType);
			if (type == typeof(void))
			{
				generator.Emit(OpCodes.Ldnull);
			}
			else
			{
				generator.BoxIfNeeded(type);
			}
			generator.Return();
		}

		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				generator.PushInstance(fieldInfo.DeclaringType);
			}
			generator.Emit(OpCodes.Ldarg_1);
			generator.UnboxIfNeeded(fieldInfo.FieldType);
			generator.Emit(OpCodes.Stfld, fieldInfo);
			generator.Return();
		}

		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator)
		{
			MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (!setMethod.IsStatic)
			{
				generator.PushInstance(propertyInfo.DeclaringType);
			}
			generator.Emit(OpCodes.Ldarg_1);
			generator.UnboxIfNeeded(propertyInfo.PropertyType);
			generator.CallMethod(setMethod);
			generator.Return();
		}
	}
}