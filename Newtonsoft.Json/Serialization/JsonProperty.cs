using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonProperty
	{
		internal Newtonsoft.Json.Required? _required;

		public JsonConverter Converter
		{
			get;
			set;
		}

		public Type DeclaringType
		{
			get;
			set;
		}

		public object DefaultValue
		{
			get;
			set;
		}

		public Newtonsoft.Json.DefaultValueHandling? DefaultValueHandling
		{
			get;
			set;
		}

		public Predicate<object> GetIsSpecified
		{
			get;
			set;
		}

		public bool Ignored
		{
			get;
			set;
		}

		public bool? IsReference
		{
			get;
			set;
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

		public Newtonsoft.Json.ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.TypeNameHandling? ItemTypeNameHandling
		{
			get;
			set;
		}

		public JsonConverter MemberConverter
		{
			get;
			set;
		}

		public Newtonsoft.Json.NullValueHandling? NullValueHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.ObjectCreationHandling? ObjectCreationHandling
		{
			get;
			set;
		}

		public int? Order
		{
			get;
			set;
		}

		internal JsonContract PropertyContract
		{
			get;
			set;
		}

		public string PropertyName
		{
			get;
			set;
		}

		public Type PropertyType
		{
			get;
			set;
		}

		public bool Readable
		{
			get;
			set;
		}

		public Newtonsoft.Json.ReferenceLoopHandling? ReferenceLoopHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.Required Required
		{
			get
			{
				Newtonsoft.Json.Required? nullable = this._required;
				if (!nullable.HasValue)
				{
					return Newtonsoft.Json.Required.Default;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._required = new Newtonsoft.Json.Required?(value);
			}
		}

		public Action<object, object> SetIsSpecified
		{
			get;
			set;
		}

		public Predicate<object> ShouldSerialize
		{
			get;
			set;
		}

		public Newtonsoft.Json.TypeNameHandling? TypeNameHandling
		{
			get;
			set;
		}

		public string UnderlyingName
		{
			get;
			set;
		}

		public IValueProvider ValueProvider
		{
			get;
			set;
		}

		public bool Writable
		{
			get;
			set;
		}

		public JsonProperty()
		{
		}

		public override string ToString()
		{
			return this.PropertyName;
		}
	}
}