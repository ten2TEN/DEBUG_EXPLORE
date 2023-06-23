using Facebook.Reflection;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Facebook
{
	[GeneratedCode("simple-json", "1.0.0")]
	internal class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		internal readonly static Type[] EmptyTypes;

		internal readonly static Type[] ArrayConstructorParameterTypes;

		private readonly static string[] Iso8601Format;

		static PocoJsonSerializerStrategy()
		{
			PocoJsonSerializerStrategy.EmptyTypes = new Type[0];
			PocoJsonSerializerStrategy.ArrayConstructorParameterTypes = new Type[] { typeof(int) };
			PocoJsonSerializerStrategy.Iso8601Format = new string[] { "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z", "yyyy-MM-dd\\THH:mm:ss\\Z", "yyyy-MM-dd\\THH:mm:ssK" };
		}

		public PocoJsonSerializerStrategy()
		{
			PocoJsonSerializerStrategy pocoJsonSerializerStrategy = this;
			this.ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<Type, ReflectionUtils.ConstructorDelegate>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, ReflectionUtils.ConstructorDelegate>(pocoJsonSerializerStrategy.ContructorDelegateFactory));
			PocoJsonSerializerStrategy pocoJsonSerializerStrategy1 = this;
			this.GetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(pocoJsonSerializerStrategy1.GetterValueFactory));
			PocoJsonSerializerStrategy pocoJsonSerializerStrategy2 = this;
			this.SetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(pocoJsonSerializerStrategy2.SetterValueFactory));
		}

		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return ReflectionUtils.GetContructor(key, (key.IsArray ? PocoJsonSerializerStrategy.ArrayConstructorParameterTypes : PocoJsonSerializerStrategy.EmptyTypes));
		}

		public virtual object DeserializeObject(object value, Type type)
		{
			Uri uri;
			object obj;
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string str = value as string;
			if (type == typeof(Guid) && string.IsNullOrEmpty(str))
			{
				return new Guid();
			}
			if (value == null)
			{
				return null;
			}
			object item = null;
			if (str != null)
			{
				if (str.Length != 0)
				{
					if (type == typeof(DateTime) || ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTime))
					{
						return DateTime.ParseExact(str, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(DateTimeOffset) || ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTimeOffset))
					{
						return DateTimeOffset.ParseExact(str, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(Guid) || ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
					{
						return new Guid(str);
					}
					if (type != typeof(Uri))
					{
						if (type == typeof(string))
						{
							return str;
						}
						return Convert.ChangeType(str, type, CultureInfo.InvariantCulture);
					}
					if (Uri.IsWellFormedUriString(str, UriKind.RelativeOrAbsolute) && Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out uri))
					{
						return uri;
					}
					return null;
				}
				if (type == typeof(Guid))
				{
					item = new Guid();
				}
				else if (!ReflectionUtils.IsNullableType(type) || !(Nullable.GetUnderlyingType(type) == typeof(Guid)))
				{
					item = str;
				}
				else
				{
					item = null;
				}
				if (!ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
				{
					return str;
				}
			}
			else if (value is bool)
			{
				return value;
			}
			bool flag = value is long;
			bool flag1 = value is double;
			if (flag && type == typeof(long) || flag1 && type == typeof(double))
			{
				return value;
			}
			if (flag1 && type != typeof(double) || flag && type != typeof(long))
			{
				item = (type == typeof(int) || type == typeof(long) || type == typeof(double) || type == typeof(float) || type == typeof(bool) || type == typeof(decimal) || type == typeof(byte) || type == typeof(short) ? Convert.ChangeType(value, type, CultureInfo.InvariantCulture) : value);
				if (!ReflectionUtils.IsNullableType(type))
				{
					return item;
				}
				return ReflectionUtils.ToNullableType(item, type);
			}
			IDictionary<string, object> strs = value as IDictionary<string, object>;
			if (strs == null)
			{
				IList<object> objs = value as IList<object>;
				if (objs != null)
				{
					IList<object> objs1 = objs;
					IList lists = null;
					if (type.IsArray)
					{
						ReflectionUtils.ConstructorDelegate constructorDelegate = this.ConstructorCache[type];
						object[] count = new object[] { objs1.Count };
						lists = (IList)constructorDelegate(count);
						int num = 0;
						foreach (object obj1 in objs1)
						{
							int num1 = num;
							num = num1 + 1;
							lists[num1] = this.DeserializeObject(obj1, type.GetElementType());
						}
					}
					else if (ReflectionUtils.IsTypeGenericeCollectionInterface(type) || ReflectionUtils.IsAssignableFrom(typeof(IList), type))
					{
						Type genericListElementType = ReflectionUtils.GetGenericListElementType(type);
						ReflectionUtils.ConstructorDelegate item1 = this.ConstructorCache[type];
						if (item1 == null)
						{
							IDictionary<Type, ReflectionUtils.ConstructorDelegate> constructorCache = this.ConstructorCache;
							Type type1 = typeof(List<>);
							Type[] typeArray = new Type[] { genericListElementType };
							item1 = constructorCache[type1.MakeGenericType(typeArray)];
						}
						object[] objArray = new object[] { objs1.Count };
						lists = (IList)item1(objArray);
						foreach (object obj2 in objs1)
						{
							lists.Add(this.DeserializeObject(obj2, genericListElementType));
						}
					}
					item = lists;
				}
			}
			else
			{
				IDictionary<string, object> strs1 = strs;
				if (ReflectionUtils.IsTypeDictionary(type))
				{
					Type[] genericTypeArguments = ReflectionUtils.GetGenericTypeArguments(type);
					Type type2 = genericTypeArguments[0];
					Type type3 = genericTypeArguments[1];
					Type type4 = typeof(Dictionary<,>);
					Type[] typeArray1 = new Type[] { type2, type3 };
					Type type5 = type4.MakeGenericType(typeArray1);
					IDictionary dictionaries = (IDictionary)this.ConstructorCache[type5](new object[0]);
					foreach (KeyValuePair<string, object> keyValuePair in strs1)
					{
						dictionaries.Add(keyValuePair.Key, this.DeserializeObject(keyValuePair.Value, type3));
					}
					item = dictionaries;
				}
				else if (type != typeof(object))
				{
					item = this.ConstructorCache[type](new object[0]);
					foreach (KeyValuePair<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> keyValuePair1 in this.SetCache[type])
					{
						if (!strs1.TryGetValue(keyValuePair1.Key, out obj))
						{
							continue;
						}
						obj = this.DeserializeObject(obj, keyValuePair1.Value.Key);
						keyValuePair1.Value.Value(item, obj);
					}
				}
				else
				{
					item = value;
				}
			}
			return item;
		}

		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			IDictionary<string, ReflectionUtils.GetDelegate> strs = new Dictionary<string, ReflectionUtils.GetDelegate>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (!property.CanRead)
				{
					continue;
				}
				MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(property);
				if (getterMethodInfo.IsStatic || !getterMethodInfo.IsPublic)
				{
					continue;
				}
				strs[this.MapClrMemberNameToJsonFieldName(property.Name)] = ReflectionUtils.GetGetMethod(property);
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (field.IsStatic || !field.IsPublic)
				{
					continue;
				}
				strs[this.MapClrMemberNameToJsonFieldName(field.Name)] = ReflectionUtils.GetGetMethod(field);
			}
			return strs;
		}

		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return clrPropertyName;
		}

		protected virtual object SerializeEnum(Enum p)
		{
			return Convert.ToDouble(p, CultureInfo.InvariantCulture);
		}

		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> strs = new Dictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (!property.CanWrite)
				{
					continue;
				}
				MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(property);
				if (setterMethodInfo.IsStatic || !setterMethodInfo.IsPublic)
				{
					continue;
				}
				strs[this.MapClrMemberNameToJsonFieldName(property.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(property.PropertyType, ReflectionUtils.GetSetMethod(property));
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (field.IsInitOnly || field.IsStatic || !field.IsPublic)
				{
					continue;
				}
				strs[this.MapClrMemberNameToJsonFieldName(field.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(field.FieldType, ReflectionUtils.GetSetMethod(field));
			}
			return strs;
		}

		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			bool flag = true;
			if (input is DateTime)
			{
				DateTime universalTime = ((DateTime)input).ToUniversalTime();
				output = universalTime.ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset = ((DateTimeOffset)input).ToUniversalTime();
				output = dateTimeOffset.ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is Guid)
			{
				output = ((Guid)input).ToString("D");
			}
			else if (!(input is Uri))
			{
				Enum @enum = input as Enum;
				if (@enum == null)
				{
					flag = false;
					output = null;
				}
				else
				{
					output = this.SerializeEnum(@enum);
				}
			}
			else
			{
				output = input.ToString();
			}
			return flag;
		}

		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			if (this.TrySerializeKnownTypes(input, out output))
			{
				return true;
			}
			return this.TrySerializeUnknownTypes(input, out output);
		}

		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			output = null;
			Type type = input.GetType();
			if (type.FullName == null)
			{
				return false;
			}
			IDictionary<string, object> jsonObjects = new JsonObject();
			foreach (KeyValuePair<string, ReflectionUtils.GetDelegate> item in this.GetCache[type])
			{
				if (item.Value == null)
				{
					continue;
				}
				jsonObjects.Add(this.MapClrMemberNameToJsonFieldName(item.Key), item.Value(input));
			}
			output = jsonObjects;
			return true;
		}
	}
}