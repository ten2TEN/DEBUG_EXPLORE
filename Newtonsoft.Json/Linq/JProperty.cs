using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Newtonsoft.Json.Linq
{
	public class JProperty : JContainer
	{
		private readonly List<JToken> _content = new List<JToken>();

		private readonly string _name;

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._content;
			}
		}

		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return this._name;
			}
		}

		public override JTokenType Type
		{
			[DebuggerStepThrough]
			get
			{
				return JTokenType.Property;
			}
		}

		public JToken Value
		{
			[DebuggerStepThrough]
			get
			{
				if (this.ChildrenTokens.Count <= 0)
				{
					return null;
				}
				return this.ChildrenTokens[0];
			}
			set
			{
				base.CheckReentrancy();
				object jValue = value;
				if (jValue == null)
				{
					jValue = new JValue(null);
				}
				JToken jTokens = (JToken)jValue;
				if (this.ChildrenTokens.Count != 0)
				{
					this.SetItem(0, jTokens);
					return;
				}
				this.InsertItem(0, jTokens, false);
			}
		}

		public JProperty(JProperty other) : base(other)
		{
			this._name = other.Name;
		}

		internal JProperty(string name)
		{
			ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
		}

		public JProperty(string name, params object[] content) : this(name, (object)content)
		{
		}

		public JProperty(string name, object content)
		{
			JToken jArrays;
			ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
			if (base.IsMultiContent(content))
			{
				jArrays = new JArray(content);
			}
			else
			{
				jArrays = base.CreateFromContent(content);
			}
			this.Value = jArrays;
		}

		internal override void ClearItems()
		{
			throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		internal override JToken CloneToken()
		{
			return new JProperty(this);
		}

		internal override bool ContainsItem(JToken item)
		{
			return this.Value == item;
		}

		internal override bool DeepEquals(JToken node)
		{
			JProperty jProperty = node as JProperty;
			if (jProperty == null || !(this._name == jProperty.Name))
			{
				return false;
			}
			return base.ContentsEqual(jProperty);
		}

		internal override int GetDeepHashCode()
		{
			return this._name.GetHashCode() ^ (this.Value != null ? this.Value.GetDeepHashCode() : 0);
		}

		internal override JToken GetItem(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.Value;
		}

		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (this.Value != null)
			{
				throw new JsonException("{0} cannot have multiple values.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
			}
			base.InsertItem(0, item, false);
		}

		public static new JProperty Load(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader.");
			}
			if (reader.TokenType != JsonToken.PropertyName)
			{
				throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JProperty jProperty = new JProperty((string)reader.Value);
			jProperty.SetLineInfo(reader as IJsonLineInfo);
			jProperty.ReadTokenFrom(reader);
			return jProperty;
		}

		internal override bool RemoveItem(JToken item)
		{
			throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		internal override void RemoveItemAt(int index)
		{
			throw new JsonException("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		internal override void SetItem(int index, JToken item)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (JContainer.IsTokenUnchanged(this.Value, item))
			{
				return;
			}
			if (base.Parent != null)
			{
				((JObject)base.Parent).InternalPropertyChanging(this);
			}
			base.SetItem(0, item);
			if (base.Parent != null)
			{
				((JObject)base.Parent).InternalPropertyChanged(this);
			}
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WritePropertyName(this._name);
			this.Value.WriteTo(writer, converters);
		}
	}
}