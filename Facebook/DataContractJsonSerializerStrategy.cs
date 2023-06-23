using Facebook.Reflection;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Facebook
{
	[GeneratedCode("simple-json", "1.0.0")]
	internal class DataContractJsonSerializerStrategy : PocoJsonSerializerStrategy
	{
		public DataContractJsonSerializerStrategy()
		{
			DataContractJsonSerializerStrategy dataContractJsonSerializerStrategy = this;
			this.GetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(dataContractJsonSerializerStrategy.GetterValueFactory));
			DataContractJsonSerializerStrategy dataContractJsonSerializerStrategy1 = this;
			this.SetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(dataContractJsonSerializerStrategy1.SetterValueFactory));
		}

		private static bool CanAdd(MemberInfo info, out string jsonKey)
		{
			jsonKey = null;
			if (ReflectionUtils.GetAttribute(info, typeof(IgnoreDataMemberAttribute)) != null)
			{
				return false;
			}
			DataMemberAttribute attribute = (DataMemberAttribute)ReflectionUtils.GetAttribute(info, typeof(DataMemberAttribute));
			if (attribute == null)
			{
				return false;
			}
			jsonKey = (string.IsNullOrEmpty(attribute.Name) ? info.Name : attribute.Name);
			return true;
		}

		internal override IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			string str;
			if (ReflectionUtils.GetAttribute(type, typeof(DataContractAttribute)) == null)
			{
				return base.GetterValueFactory(type);
			}
			IDictionary<string, ReflectionUtils.GetDelegate> strs = new Dictionary<string, ReflectionUtils.GetDelegate>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (!property.CanRead || ReflectionUtils.GetGetterMethodInfo(property).IsStatic || !DataContractJsonSerializerStrategy.CanAdd(property, out str))
				{
					continue;
				}
				strs[str] = ReflectionUtils.GetGetMethod(property);
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (field.IsStatic || !DataContractJsonSerializerStrategy.CanAdd(field, out str))
				{
					continue;
				}
				strs[str] = ReflectionUtils.GetGetMethod(field);
			}
			return strs;
		}

		internal override IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			string str;
			if (ReflectionUtils.GetAttribute(type, typeof(DataContractAttribute)) == null)
			{
				return base.SetterValueFactory(type);
			}
			IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> strs = new Dictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (!property.CanWrite || ReflectionUtils.GetSetterMethodInfo(property).IsStatic || !DataContractJsonSerializerStrategy.CanAdd(property, out str))
				{
					continue;
				}
				strs[str] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(property.PropertyType, ReflectionUtils.GetSetMethod(property));
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (field.IsInitOnly || field.IsStatic || !DataContractJsonSerializerStrategy.CanAdd(field, out str))
				{
					continue;
				}
				strs[str] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(field.FieldType, ReflectionUtils.GetSetMethod(field));
			}
			return strs;
		}
	}
}