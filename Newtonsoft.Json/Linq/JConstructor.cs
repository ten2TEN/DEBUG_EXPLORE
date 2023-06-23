using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	public class JConstructor : JContainer
	{
		private string _name;

		private readonly IList<JToken> _values = new List<JToken>();

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._values;
			}
		}

		public override JToken this[object key]
		{
			get
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this.GetItem((int)key);
			}
			set
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this.SetItem((int)key, value);
			}
		}

		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		public override JTokenType Type
		{
			get
			{
				return JTokenType.Constructor;
			}
		}

		public JConstructor()
		{
		}

		public JConstructor(JConstructor other) : base(other)
		{
			this._name = other.Name;
		}

		public JConstructor(string name, params object[] content) : this(name, (object)content)
		{
		}

		public JConstructor(string name, object content) : this(name)
		{
			this.Add(content);
		}

		public JConstructor(string name)
		{
			ValidationUtils.ArgumentNotNullOrEmpty(name, "name");
			this._name = name;
		}

		internal override JToken CloneToken()
		{
			return new JConstructor(this);
		}

		internal override bool DeepEquals(JToken node)
		{
			JConstructor jConstructor = node as JConstructor;
			if (jConstructor == null || !(this._name == jConstructor.Name))
			{
				return false;
			}
			return base.ContentsEqual(jConstructor);
		}

		internal override int GetDeepHashCode()
		{
			return this._name.GetHashCode() ^ base.ContentsHashCode();
		}

		public static new JConstructor Load(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader.");
			}
			if (reader.TokenType != JsonToken.StartConstructor)
			{
				throw JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JConstructor jConstructor = new JConstructor((string)reader.Value);
			jConstructor.SetLineInfo(reader as IJsonLineInfo);
			jConstructor.ReadTokenFrom(reader);
			return jConstructor;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartConstructor(this._name);
			foreach (JToken jTokens in this.Children())
			{
				jTokens.WriteTo(writer, converters);
			}
			writer.WriteEndConstructor();
		}
	}
}