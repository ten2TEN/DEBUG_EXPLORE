using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonContainerContract : JsonContract
	{
		private JsonContract _itemContract;

		private JsonContract _finalItemContract;

		internal JsonContract FinalItemContract
		{
			get
			{
				return this._finalItemContract;
			}
		}

		internal JsonContract ItemContract
		{
			get
			{
				return this._itemContract;
			}
			set
			{
				JsonContract jsonContract;
				this._itemContract = value;
				if (this._itemContract == null)
				{
					this._finalItemContract = null;
					return;
				}
				if (this._itemContract.UnderlyingType.IsSealed())
				{
					jsonContract = this._itemContract;
				}
				else
				{
					jsonContract = null;
				}
				this._finalItemContract = jsonContract;
			}
		}

		public JsonConverter ItemConverter
		{
			get;
			set;
		}

		public bool? ItemIsReference
		{
			get;
			set;
		}

		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			get;
			set;
		}

		public TypeNameHandling? ItemTypeNameHandling
		{
			get;
			set;
		}

		internal JsonContainerContract(Type underlyingType) : base(underlyingType)
		{
			JsonContainerAttribute jsonContainerAttribute = JsonTypeReflector.GetJsonContainerAttribute(underlyingType);
			if (jsonContainerAttribute != null)
			{
				if (jsonContainerAttribute.ItemConverterType != null)
				{
					this.ItemConverter = JsonConverterAttribute.CreateJsonConverterInstance(jsonContainerAttribute.ItemConverterType);
				}
				this.ItemIsReference = jsonContainerAttribute._itemIsReference;
				this.ItemReferenceLoopHandling = jsonContainerAttribute._itemReferenceLoopHandling;
				this.ItemTypeNameHandling = jsonContainerAttribute._itemTypeNameHandling;
			}
		}
	}
}