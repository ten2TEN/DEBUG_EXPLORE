using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonArrayContract : JsonContainerContract
	{
		private readonly bool _isCollectionItemTypeNullableType;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private MethodCall<object, object> _genericWrapperCreator;

		public Type CollectionItemType
		{
			get;
			private set;
		}

		public JsonArrayContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Array;
			if (ReflectionUtils.ImplementsGenericDefinition(underlyingType, typeof(ICollection<>), out this._genericCollectionDefinitionType))
			{
				this.CollectionItemType = this._genericCollectionDefinitionType.GetGenericArguments()[0];
			}
			else if (!underlyingType.IsGenericType() || !(underlyingType.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
			{
				this.CollectionItemType = ReflectionUtils.GetCollectionItemType(base.UnderlyingType);
			}
			else
			{
				this._genericCollectionDefinitionType = typeof(IEnumerable<>);
				this.CollectionItemType = underlyingType.GetGenericArguments()[0];
			}
			if (this.CollectionItemType != null)
			{
				this._isCollectionItemTypeNullableType = ReflectionUtils.IsNullableType(this.CollectionItemType);
			}
			if (this.IsTypeGenericCollectionInterface(base.UnderlyingType))
			{
				Type type = typeof(List<>);
				Type[] collectionItemType = new Type[] { this.CollectionItemType };
				base.CreatedType = ReflectionUtils.MakeGenericType(type, collectionItemType);
			}
		}

		internal IWrappedCollection CreateWrapper(object list)
		{
			if (list is IList && (this.CollectionItemType == null || !this._isCollectionItemTypeNullableType) || base.UnderlyingType.IsArray)
			{
				return new CollectionWrapper<object>((IList)list);
			}
			if (this._genericCollectionDefinitionType != null)
			{
				this.EnsureGenericWrapperCreator();
				return (IWrappedCollection)this._genericWrapperCreator(null, new object[] { list });
			}
			IList lists = ((IEnumerable)list).Cast<object>().ToList<object>();
			if (this.CollectionItemType != null)
			{
				Array arrays = Array.CreateInstance(this.CollectionItemType, lists.Count);
				for (int i = 0; i < lists.Count; i++)
				{
					arrays.SetValue(lists[i], i);
				}
				lists = arrays;
			}
			return new CollectionWrapper<object>(lists);
		}

		private void EnsureGenericWrapperCreator()
		{
			Type type;
			if (this._genericWrapperCreator == null)
			{
				Type type1 = typeof(CollectionWrapper<>);
				Type[] collectionItemType = new Type[] { this.CollectionItemType };
				this._genericWrapperType = ReflectionUtils.MakeGenericType(type1, collectionItemType);
				if (ReflectionUtils.InheritsGenericDefinition(this._genericCollectionDefinitionType, typeof(List<>)) || this._genericCollectionDefinitionType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					Type type2 = typeof(ICollection<>);
					Type[] typeArray = new Type[] { this.CollectionItemType };
					type = ReflectionUtils.MakeGenericType(type2, typeArray);
				}
				else
				{
					type = this._genericCollectionDefinitionType;
				}
				ConstructorInfo constructor = this._genericWrapperType.GetConstructor(new Type[] { type });
				this._genericWrapperCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(constructor);
			}
		}

		private bool IsTypeGenericCollectionInterface(Type type)
		{
			if (!type.IsGenericType())
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			if (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>))
			{
				return true;
			}
			return genericTypeDefinition == typeof(IEnumerable<>);
		}
	}
}