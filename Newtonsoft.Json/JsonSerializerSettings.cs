using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json
{
	public class JsonSerializerSettings
	{
		internal const Newtonsoft.Json.ReferenceLoopHandling DefaultReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Error;

		internal const Newtonsoft.Json.MissingMemberHandling DefaultMissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;

		internal const Newtonsoft.Json.NullValueHandling DefaultNullValueHandling = Newtonsoft.Json.NullValueHandling.Include;

		internal const Newtonsoft.Json.DefaultValueHandling DefaultDefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;

		internal const Newtonsoft.Json.ObjectCreationHandling DefaultObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Auto;

		internal const Newtonsoft.Json.PreserveReferencesHandling DefaultPreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;

		internal const Newtonsoft.Json.ConstructorHandling DefaultConstructorHandling = Newtonsoft.Json.ConstructorHandling.Default;

		internal const Newtonsoft.Json.TypeNameHandling DefaultTypeNameHandling = Newtonsoft.Json.TypeNameHandling.None;

		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		internal const Newtonsoft.Json.Formatting DefaultFormatting = Newtonsoft.Json.Formatting.None;

		internal const Newtonsoft.Json.DateFormatHandling DefaultDateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;

		internal const Newtonsoft.Json.DateTimeZoneHandling DefaultDateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;

		internal const Newtonsoft.Json.DateParseHandling DefaultDateParseHandling = Newtonsoft.Json.DateParseHandling.DateTime;

		internal const bool DefaultCheckAdditionalContent = false;

		internal readonly static StreamingContext DefaultContext;

		internal readonly static CultureInfo DefaultCulture;

		internal Newtonsoft.Json.Formatting? _formatting;

		internal Newtonsoft.Json.DateFormatHandling? _dateFormatHandling;

		internal Newtonsoft.Json.DateTimeZoneHandling? _dateTimeZoneHandling;

		internal Newtonsoft.Json.DateParseHandling? _dateParseHandling;

		internal CultureInfo _culture;

		internal bool? _checkAdditionalContent;

		internal int? _maxDepth;

		internal bool _maxDepthSet;

		public SerializationBinder Binder
		{
			get;
			set;
		}

		public bool CheckAdditionalContent
		{
			get
			{
				bool? nullable = this._checkAdditionalContent;
				if (!nullable.HasValue)
				{
					return false;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._checkAdditionalContent = new bool?(value);
			}
		}

		public Newtonsoft.Json.ConstructorHandling ConstructorHandling
		{
			get;
			set;
		}

		public StreamingContext Context
		{
			get;
			set;
		}

		public IContractResolver ContractResolver
		{
			get;
			set;
		}

		public IList<JsonConverter> Converters
		{
			get;
			set;
		}

		public CultureInfo Culture
		{
			get
			{
				return this._culture ?? JsonSerializerSettings.DefaultCulture;
			}
			set
			{
				this._culture = value;
			}
		}

		public Newtonsoft.Json.DateFormatHandling DateFormatHandling
		{
			get
			{
				Newtonsoft.Json.DateFormatHandling? nullable = this._dateFormatHandling;
				if (!nullable.HasValue)
				{
					return Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._dateFormatHandling = new Newtonsoft.Json.DateFormatHandling?(value);
			}
		}

		public Newtonsoft.Json.DateParseHandling DateParseHandling
		{
			get
			{
				Newtonsoft.Json.DateParseHandling? nullable = this._dateParseHandling;
				if (!nullable.HasValue)
				{
					return Newtonsoft.Json.DateParseHandling.DateTime;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._dateParseHandling = new Newtonsoft.Json.DateParseHandling?(value);
			}
		}

		public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				Newtonsoft.Json.DateTimeZoneHandling? nullable = this._dateTimeZoneHandling;
				if (!nullable.HasValue)
				{
					return Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._dateTimeZoneHandling = new Newtonsoft.Json.DateTimeZoneHandling?(value);
			}
		}

		public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling
		{
			get;
			set;
		}

		public EventHandler<ErrorEventArgs> Error
		{
			get;
			set;
		}

		public Newtonsoft.Json.Formatting Formatting
		{
			get
			{
				Newtonsoft.Json.Formatting? nullable = this._formatting;
				if (!nullable.HasValue)
				{
					return Newtonsoft.Json.Formatting.None;
				}
				return nullable.GetValueOrDefault();
			}
			set
			{
				this._formatting = new Newtonsoft.Json.Formatting?(value);
			}
		}

		public int? MaxDepth
		{
			get
			{
				return this._maxDepth;
			}
			set
			{
				int? nullable = value;
				if ((nullable.GetValueOrDefault() > 0 ? false : nullable.HasValue))
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this._maxDepth = value;
				this._maxDepthSet = true;
			}
		}

		public Newtonsoft.Json.MissingMemberHandling MissingMemberHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.NullValueHandling NullValueHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling
		{
			get;
			set;
		}

		public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling
		{
			get;
			set;
		}

		public IReferenceResolver ReferenceResolver
		{
			get;
			set;
		}

		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get;
			set;
		}

		public Newtonsoft.Json.TypeNameHandling TypeNameHandling
		{
			get;
			set;
		}

		static JsonSerializerSettings()
		{
			JsonSerializerSettings.DefaultContext = new StreamingContext();
			JsonSerializerSettings.DefaultCulture = CultureInfo.InvariantCulture;
		}

		public JsonSerializerSettings()
		{
			this.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Error;
			this.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
			this.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Auto;
			this.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
			this.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
			this.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
			this.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.None;
			this.TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;
			this.Context = JsonSerializerSettings.DefaultContext;
			this.Converters = new List<JsonConverter>();
		}
	}
}