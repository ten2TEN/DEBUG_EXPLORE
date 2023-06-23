using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Linq
{
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		private readonly JToken _root;

		private JToken _parent;

		private JToken _current;

		private bool IsEndElement
		{
			get
			{
				return this._current == this._parent;
			}
		}

		int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				if (base.CurrentState == JsonReader.State.Start)
				{
					return 0;
				}
				if (this.IsEndElement)
				{
					jsonLineInfo = null;
				}
				else
				{
					jsonLineInfo = this._current;
				}
				IJsonLineInfo jsonLineInfo1 = jsonLineInfo;
				if (jsonLineInfo1 == null)
				{
					return 0;
				}
				return jsonLineInfo1.LineNumber;
			}
		}

		int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				if (base.CurrentState == JsonReader.State.Start)
				{
					return 0;
				}
				if (this.IsEndElement)
				{
					jsonLineInfo = null;
				}
				else
				{
					jsonLineInfo = this._current;
				}
				IJsonLineInfo jsonLineInfo1 = jsonLineInfo;
				if (jsonLineInfo1 == null)
				{
					return 0;
				}
				return jsonLineInfo1.LinePosition;
			}
		}

		public JTokenReader(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			this._root = token;
			this._current = token;
		}

		private JsonToken? GetEndToken(JContainer c)
		{
			switch (c.Type)
			{
				case JTokenType.Object:
				{
					return new JsonToken?(JsonToken.EndObject);
				}
				case JTokenType.Array:
				{
					return new JsonToken?(JsonToken.EndArray);
				}
				case JTokenType.Constructor:
				{
					return new JsonToken?(JsonToken.EndConstructor);
				}
				case JTokenType.Property:
				{
					return null;
				}
			}
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", c.Type, "Unexpected JContainer type.");
		}

		bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo;
			if (base.CurrentState == JsonReader.State.Start)
			{
				return false;
			}
			if (this.IsEndElement)
			{
				jsonLineInfo = null;
			}
			else
			{
				jsonLineInfo = this._current;
			}
			IJsonLineInfo jsonLineInfo1 = jsonLineInfo;
			if (jsonLineInfo1 == null)
			{
				return false;
			}
			return jsonLineInfo1.HasLineInfo();
		}

		public override bool Read()
		{
			this._readType = ReadType.Read;
			return this.ReadInternal();
		}

		public override byte[] ReadAsBytes()
		{
			return base.ReadAsBytesInternal();
		}

		public override DateTime? ReadAsDateTime()
		{
			return base.ReadAsDateTimeInternal();
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return base.ReadAsDateTimeOffsetInternal();
		}

		public override decimal? ReadAsDecimal()
		{
			return base.ReadAsDecimalInternal();
		}

		public override int? ReadAsInt32()
		{
			return base.ReadAsInt32Internal();
		}

		public override string ReadAsString()
		{
			return base.ReadAsStringInternal();
		}

		internal override bool ReadInternal()
		{
			if (base.CurrentState == JsonReader.State.Start)
			{
				this.SetToken(this._current);
				return true;
			}
			JContainer jContainers = this._current as JContainer;
			if (jContainers != null && this._parent != jContainers)
			{
				return this.ReadInto(jContainers);
			}
			return this.ReadOver(this._current);
		}

		private bool ReadInto(JContainer c)
		{
			JToken first = c.First;
			if (first == null)
			{
				return this.SetEnd(c);
			}
			this.SetToken(first);
			this._current = first;
			this._parent = c;
			return true;
		}

		private bool ReadOver(JToken t)
		{
			if (t == this._root)
			{
				return this.ReadToEnd();
			}
			JToken next = t.Next;
			if (next != null && next != t && t != t.Parent.Last)
			{
				this._current = next;
				this.SetToken(this._current);
				return true;
			}
			if (t.Parent == null)
			{
				return this.ReadToEnd();
			}
			return this.SetEnd(t.Parent);
		}

		private bool ReadToEnd()
		{
			base.SetToken(JsonToken.None);
			return false;
		}

		private string SafeToString(object value)
		{
			if (value == null)
			{
				return null;
			}
			return value.ToString();
		}

		private bool SetEnd(JContainer c)
		{
			JsonToken? endToken = this.GetEndToken(c);
			if (!endToken.HasValue)
			{
				return this.ReadOver(c);
			}
			base.SetToken(endToken.Value);
			this._current = c;
			this._parent = c;
			return true;
		}

		private void SetToken(JToken token)
		{
			switch (token.Type)
			{
				case JTokenType.Object:
				{
					base.SetToken(JsonToken.StartObject);
					return;
				}
				case JTokenType.Array:
				{
					base.SetToken(JsonToken.StartArray);
					return;
				}
				case JTokenType.Constructor:
				{
					base.SetToken(JsonToken.StartConstructor);
					return;
				}
				case JTokenType.Property:
				{
					base.SetToken(JsonToken.PropertyName, ((JProperty)token).Name);
					return;
				}
				case JTokenType.Comment:
				{
					base.SetToken(JsonToken.Comment, ((JValue)token).Value);
					return;
				}
				case JTokenType.Integer:
				{
					base.SetToken(JsonToken.Integer, ((JValue)token).Value);
					return;
				}
				case JTokenType.Float:
				{
					base.SetToken(JsonToken.Float, ((JValue)token).Value);
					return;
				}
				case JTokenType.String:
				{
					base.SetToken(JsonToken.String, ((JValue)token).Value);
					return;
				}
				case JTokenType.Boolean:
				{
					base.SetToken(JsonToken.Boolean, ((JValue)token).Value);
					return;
				}
				case JTokenType.Null:
				{
					base.SetToken(JsonToken.Null, ((JValue)token).Value);
					return;
				}
				case JTokenType.Undefined:
				{
					base.SetToken(JsonToken.Undefined, ((JValue)token).Value);
					return;
				}
				case JTokenType.Date:
				{
					base.SetToken(JsonToken.Date, ((JValue)token).Value);
					return;
				}
				case JTokenType.Raw:
				{
					base.SetToken(JsonToken.Raw, ((JValue)token).Value);
					return;
				}
				case JTokenType.Bytes:
				{
					base.SetToken(JsonToken.Bytes, ((JValue)token).Value);
					return;
				}
				case JTokenType.Guid:
				{
					base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
					return;
				}
				case JTokenType.Uri:
				{
					base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
					return;
				}
				case JTokenType.TimeSpan:
				{
					base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
					return;
				}
			}
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", token.Type, "Unexpected JTokenType.");
		}
	}
}