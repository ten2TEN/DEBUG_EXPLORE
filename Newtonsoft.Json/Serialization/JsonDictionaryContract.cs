using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDictionaryContract : JsonContainerContract
	{
		private readonly bool _isDictionaryValueTypeNullableType;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private MethodCall<object, object> _genericWrapperCreator;

		public Type DictionaryKeyType
		{
			get;
			private set;
		}

		public Type DictionaryValueType
		{
			get;
			private set;
		}

		internal JsonContract KeyContract
		{
			get;
			set;
		}

		public Func<string, string> PropertyNameResolver
		{
			get;
			set;
		}

		public JsonDictionaryContract(Type underlyingType) : base(underlyingType)
		{
			Type genericArguments;
			Type type;
			this.ContractType = JsonContractType.Dictionary;
			if (!ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(IDictionary<,>), out this._genericCollectionDefinitionType))
			{
				ReflectionUtils.GetDictionaryKeyValueTypes(base.UnderlyingType, out genericArguments, out type);
			}
			else
			{
				genericArguments = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				type = this._genericCollectionDefinitionType.GetGenericArguments()[1];
			}
			this.DictionaryKeyType = genericArguments;
			this.DictionaryValueType = type;
			if (this.DictionaryValueType != null)
			{
				this._isDictionaryValueTypeNullableType = ReflectionUtils.IsNullableType(this.DictionaryValueType);
			}
			if (!this.IsTypeGenericDictionaryInterface(base.UnderlyingType))
			{
				if (base.UnderlyingType == typeof(IDictionary))
				{
					base.CreatedType = typeof(Dictionary<object, object>);
				}
				return;
			}
			Type type1 = typeof(Dictionary<,>);
			Type[] typeArray = new Type[] { genericArguments, type };
			base.CreatedType = ReflectionUtils.MakeGenericType(type1, typeArray);
		}

		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			if (dictionary is IDictionary && (this.DictionaryValueType == null || !this._isDictionaryValueTypeNullableType))
			{
				return new DictionaryWrapper<object, object>((IDictionary)dictionary);
			}
			if (this._genericWrapperCreator == null)
			{
				Type type = typeof(DictionaryWrapper<,>);
				Type[] dictionaryKeyType = new Type[] { this.DictionaryKeyType, this.DictionaryValueType };
				this._genericWrapperType = ReflectionUtils.MakeGenericType(type, dictionaryKeyType);
				Type type1 = this._genericWrapperType;
				Type[] typeArray = new Type[] { this._genericCollectionDefinitionType };
				ConstructorInfo constructor = type1.GetConstructor(typeArray);
				this._genericWrapperCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(constructor);
			}
			return (IWrappedDictionary)this._genericWrapperCreator(null, new object[] { dictionary });
		}

		private bool IsTypeGenericDictionaryInterface(Type type)
		{
			if (!type.IsGenericType())
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(IDictionary<,>);
		}
	}
}