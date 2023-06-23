using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultSerializationBinder : SerializationBinder
	{
		internal readonly static DefaultSerializationBinder Instance;

		private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache = new ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type>(new Func<DefaultSerializationBinder.TypeNameKey, Type>(DefaultSerializationBinder.GetTypeFromTypeNameKey));

		static DefaultSerializationBinder()
		{
			DefaultSerializationBinder.Instance = new DefaultSerializationBinder();
		}

		public DefaultSerializationBinder()
		{
		}

		public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = serializedType.Assembly.FullName;
			typeName = serializedType.FullName;
		}

		public override Type BindToType(string assemblyName, string typeName)
		{
			return this._typeCache.Get(new DefaultSerializationBinder.TypeNameKey(assemblyName, typeName));
		}

		private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey)
		{
			string assemblyName = typeNameKey.AssemblyName;
			string typeName = typeNameKey.TypeName;
			if (assemblyName == null)
			{
				return Type.GetType(typeName);
			}
			Assembly assembly = Assembly.LoadWithPartialName(assemblyName);
			if (assembly == null)
			{
				throw new JsonSerializationException("Could not load assembly '{0}'.".FormatWith(CultureInfo.InvariantCulture, assemblyName));
			}
			Type type = assembly.GetType(typeName);
			if (type == null)
			{
				throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".FormatWith(CultureInfo.InvariantCulture, typeName, assembly.FullName));
			}
			return type;
		}

		internal struct TypeNameKey : IEquatable<DefaultSerializationBinder.TypeNameKey>
		{
			internal readonly string AssemblyName;

			internal readonly string TypeName;

			public TypeNameKey(string assemblyName, string typeName)
			{
				this.AssemblyName = assemblyName;
				this.TypeName = typeName;
			}

			public override bool Equals(object obj)
			{
				if (!(obj is DefaultSerializationBinder.TypeNameKey))
				{
					return false;
				}
				return this.Equals((DefaultSerializationBinder.TypeNameKey)obj);
			}

			public bool Equals(DefaultSerializationBinder.TypeNameKey other)
			{
				if (this.AssemblyName != other.AssemblyName)
				{
					return false;
				}
				return this.TypeName == other.TypeName;
			}

			public override int GetHashCode()
			{
				return (this.AssemblyName != null ? this.AssemblyName.GetHashCode() : 0) ^ (this.TypeName != null ? this.TypeName.GetHashCode() : 0);
			}
		}
	}
}