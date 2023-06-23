using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	internal class JsonSchemaBuilder
	{
		private JsonReader _reader;

		private readonly IList<JsonSchema> _stack;

		private readonly JsonSchemaResolver _resolver;

		private JsonSchema _currentSchema;

		private JsonSchema CurrentSchema
		{
			get
			{
				return this._currentSchema;
			}
		}

		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
			this._stack = new List<JsonSchema>();
			this._resolver = resolver;
		}

		private JsonSchema BuildSchema()
		{
			if (this._reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(this._reader, "Expected StartObject while parsing schema object, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
			}
			this._reader.Read();
			if (this._reader.TokenType == JsonToken.EndObject)
			{
				this.Push(new JsonSchema());
				return this.Pop();
			}
			string str = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
			this._reader.Read();
			if (str != "$ref")
			{
				this.Push(new JsonSchema());
				this.ProcessSchemaProperty(str);
				while (this._reader.Read() && this._reader.TokenType != JsonToken.EndObject)
				{
					str = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
					this._reader.Read();
					this.ProcessSchemaProperty(str);
				}
				return this.Pop();
			}
			string value = (string)this._reader.Value;
			while (this._reader.Read() && this._reader.TokenType != JsonToken.EndObject)
			{
				if (this._reader.TokenType != JsonToken.StartObject)
				{
					continue;
				}
				throw JsonReaderException.Create(this._reader, "Found StartObject within the schema reference with the Id '{0}'".FormatWith(CultureInfo.InvariantCulture, value));
			}
			JsonSchema schema = this._resolver.GetSchema(value);
			if (schema == null)
			{
				throw new JsonException("Could not resolve schema reference for Id '{0}'.".FormatWith(CultureInfo.InvariantCulture, value));
			}
			return schema;
		}

		internal static JsonSchemaType MapType(string type)
		{
			JsonSchemaType jsonSchemaType;
			if (!JsonSchemaConstants.JsonSchemaTypeMapping.TryGetValue(type, out jsonSchemaType))
			{
				throw new JsonException("Invalid JSON schema type: {0}".FormatWith(CultureInfo.InvariantCulture, type));
			}
			return jsonSchemaType;
		}

		internal static string MapType(JsonSchemaType type)
		{
			KeyValuePair<string, JsonSchemaType> keyValuePair = JsonSchemaConstants.JsonSchemaTypeMapping.Single<KeyValuePair<string, JsonSchemaType>>((KeyValuePair<string, JsonSchemaType> kv) => kv.Value == type);
			return keyValuePair.Key;
		}

		internal JsonSchema Parse(JsonReader reader)
		{
			this._reader = reader;
			if (reader.TokenType == JsonToken.None)
			{
				this._reader.Read();
			}
			return this.BuildSchema();
		}

		private JsonSchema Pop()
		{
			JsonSchema jsonSchema = this._currentSchema;
			this._stack.RemoveAt(this._stack.Count - 1);
			this._currentSchema = this._stack.LastOrDefault<JsonSchema>();
			return jsonSchema;
		}

		private void ProcessAdditionalProperties()
		{
			if (this._reader.TokenType != JsonToken.Boolean)
			{
				this.CurrentSchema.AdditionalProperties = this.BuildSchema();
				return;
			}
			this.CurrentSchema.AllowAdditionalProperties = (bool)this._reader.Value;
		}

		private void ProcessDefault()
		{
			this.CurrentSchema.Default = JToken.ReadFrom(this._reader);
		}

		private void ProcessEnum()
		{
			if (this._reader.TokenType != JsonToken.StartArray)
			{
				throw JsonReaderException.Create(this._reader, "Expected StartArray token while parsing enum values, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
			}
			this.CurrentSchema.Enum = new List<JToken>();
			while (this._reader.Read() && this._reader.TokenType != JsonToken.EndArray)
			{
				JToken jTokens = JToken.ReadFrom(this._reader);
				this.CurrentSchema.Enum.Add(jTokens);
			}
		}

		private void ProcessExtends()
		{
			this.CurrentSchema.Extends = this.BuildSchema();
		}

		private void ProcessIdentity()
		{
			this.CurrentSchema.Identity = new List<string>();
			JsonToken tokenType = this._reader.TokenType;
			if (tokenType != JsonToken.StartArray)
			{
				if (tokenType != JsonToken.String)
				{
					throw JsonReaderException.Create(this._reader, "Expected array or JSON property name string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
				}
				this.CurrentSchema.Identity.Add(this._reader.Value.ToString());
				return;
			}
			while (this._reader.Read())
			{
				if (this._reader.TokenType == JsonToken.EndArray)
				{
					return;
				}
				if (this._reader.TokenType != JsonToken.String)
				{
					throw JsonReaderException.Create(this._reader, "Exception JSON property name string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
				}
				this.CurrentSchema.Identity.Add(this._reader.Value.ToString());
			}
		}

		private void ProcessItems()
		{
			this.CurrentSchema.Items = new List<JsonSchema>();
			switch (this._reader.TokenType)
			{
				case JsonToken.StartObject:
				{
					this.CurrentSchema.Items.Add(this.BuildSchema());
					return;
				}
				case JsonToken.StartArray:
				{
					while (this._reader.Read())
					{
						if (this._reader.TokenType == JsonToken.EndArray)
						{
							return;
						}
						this.CurrentSchema.Items.Add(this.BuildSchema());
					}
					return;
				}
			}
			throw JsonReaderException.Create(this._reader, "Expected array or JSON schema object token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
		}

		private void ProcessOptions()
		{
			string str;
			this.CurrentSchema.Options = new Dictionary<JToken, string>(new JTokenEqualityComparer());
			if (this._reader.TokenType != JsonToken.StartArray)
			{
				throw JsonReaderException.Create(this._reader, "Expected array token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
			}
		Label0:
			while (this._reader.Read())
			{
				if (this._reader.TokenType == JsonToken.EndArray)
				{
					return;
				}
				if (this._reader.TokenType != JsonToken.StartObject)
				{
					throw JsonReaderException.Create(this._reader, "Expect object token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
				}
				string value = null;
				JToken jTokens = null;
				while (true)
				{
					if (!this._reader.Read() || this._reader.TokenType == JsonToken.EndObject)
					{
						if (jTokens == null)
						{
							throw new JsonException("No value specified for JSON schema option.");
						}
						if (this.CurrentSchema.Options.ContainsKey(jTokens))
						{
							throw new JsonException("Duplicate value in JSON schema option collection: {0}".FormatWith(CultureInfo.InvariantCulture, jTokens));
						}
						this.CurrentSchema.Options.Add(jTokens, value);
						goto Label0;
					}
					else
					{
						str = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
						this._reader.Read();
						string str1 = str;
						string str2 = str1;
						if (str1 == null)
						{
							break;
						}
						if (str2 == "value")
						{
							jTokens = JToken.ReadFrom(this._reader);
						}
						else if (str2 == "label")
						{
							value = (string)this._reader.Value;
						}
						else
						{
							break;
						}
					}
				}
				throw JsonReaderException.Create(this._reader, "Unexpected property in JSON schema option: {0}.".FormatWith(CultureInfo.InvariantCulture, str));
			}
		}

		private void ProcessPatternProperties()
		{
			Dictionary<string, JsonSchema> strs = new Dictionary<string, JsonSchema>();
			if (this._reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(this._reader, "Expected StartObject token.");
			}
			while (this._reader.Read() && this._reader.TokenType != JsonToken.EndObject)
			{
				string str = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
				this._reader.Read();
				if (strs.ContainsKey(str))
				{
					throw new JsonException("Property {0} has already been defined in schema.".FormatWith(CultureInfo.InvariantCulture, str));
				}
				strs.Add(str, this.BuildSchema());
			}
			this.CurrentSchema.PatternProperties = strs;
		}

		private void ProcessProperties()
		{
			IDictionary<string, JsonSchema> strs = new Dictionary<string, JsonSchema>();
			if (this._reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(this._reader, "Expected StartObject token while parsing schema properties, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
			}
			while (this._reader.Read() && this._reader.TokenType != JsonToken.EndObject)
			{
				string str = Convert.ToString(this._reader.Value, CultureInfo.InvariantCulture);
				this._reader.Read();
				if (strs.ContainsKey(str))
				{
					throw new JsonException("Property {0} has already been defined in schema.".FormatWith(CultureInfo.InvariantCulture, str));
				}
				strs.Add(str, this.BuildSchema());
			}
			this.CurrentSchema.Properties = strs;
		}

		private void ProcessSchemaProperty(string propertyName)
		{
			string str = propertyName;
			string str1 = str;
			if (str != null)
			{
				switch (str1)
				{
					case "type":
					{
						this.CurrentSchema.Type = this.ProcessType();
						return;
					}
					case "id":
					{
						this.CurrentSchema.Id = (string)this._reader.Value;
						return;
					}
					case "title":
					{
						this.CurrentSchema.Title = (string)this._reader.Value;
						return;
					}
					case "description":
					{
						this.CurrentSchema.Description = (string)this._reader.Value;
						return;
					}
					case "properties":
					{
						this.ProcessProperties();
						return;
					}
					case "items":
					{
						this.ProcessItems();
						return;
					}
					case "additionalProperties":
					{
						this.ProcessAdditionalProperties();
						return;
					}
					case "patternProperties":
					{
						this.ProcessPatternProperties();
						return;
					}
					case "required":
					{
						this.CurrentSchema.Required = new bool?((bool)this._reader.Value);
						return;
					}
					case "requires":
					{
						this.CurrentSchema.Requires = (string)this._reader.Value;
						return;
					}
					case "identity":
					{
						this.ProcessIdentity();
						return;
					}
					case "minimum":
					{
						this.CurrentSchema.Minimum = new double?(Convert.ToDouble(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "maximum":
					{
						this.CurrentSchema.Maximum = new double?(Convert.ToDouble(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "exclusiveMinimum":
					{
						this.CurrentSchema.ExclusiveMinimum = new bool?((bool)this._reader.Value);
						return;
					}
					case "exclusiveMaximum":
					{
						this.CurrentSchema.ExclusiveMaximum = new bool?((bool)this._reader.Value);
						return;
					}
					case "maxLength":
					{
						this.CurrentSchema.MaximumLength = new int?(Convert.ToInt32(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "minLength":
					{
						this.CurrentSchema.MinimumLength = new int?(Convert.ToInt32(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "maxItems":
					{
						this.CurrentSchema.MaximumItems = new int?(Convert.ToInt32(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "minItems":
					{
						this.CurrentSchema.MinimumItems = new int?(Convert.ToInt32(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "divisibleBy":
					{
						this.CurrentSchema.DivisibleBy = new double?(Convert.ToDouble(this._reader.Value, CultureInfo.InvariantCulture));
						return;
					}
					case "disallow":
					{
						this.CurrentSchema.Disallow = this.ProcessType();
						return;
					}
					case "default":
					{
						this.ProcessDefault();
						return;
					}
					case "hidden":
					{
						this.CurrentSchema.Hidden = new bool?((bool)this._reader.Value);
						return;
					}
					case "readonly":
					{
						this.CurrentSchema.ReadOnly = new bool?((bool)this._reader.Value);
						return;
					}
					case "format":
					{
						this.CurrentSchema.Format = (string)this._reader.Value;
						return;
					}
					case "pattern":
					{
						this.CurrentSchema.Pattern = (string)this._reader.Value;
						return;
					}
					case "options":
					{
						this.ProcessOptions();
						return;
					}
					case "enum":
					{
						this.ProcessEnum();
						return;
					}
					case "extends":
					{
						this.ProcessExtends();
						return;
					}
				}
			}
			this._reader.Skip();
		}

		private JsonSchemaType? ProcessType()
		{
			JsonSchemaType? nullable;
			JsonToken tokenType = this._reader.TokenType;
			if (tokenType != JsonToken.StartArray)
			{
				if (tokenType != JsonToken.String)
				{
					throw JsonReaderException.Create(this._reader, "Expected array or JSON schema type string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
				}
				return new JsonSchemaType?(JsonSchemaBuilder.MapType(this._reader.Value.ToString()));
			}
			JsonSchemaType? nullable1 = new JsonSchemaType?(JsonSchemaType.None);
			while (this._reader.Read() && this._reader.TokenType != JsonToken.EndArray)
			{
				if (this._reader.TokenType != JsonToken.String)
				{
					throw JsonReaderException.Create(this._reader, "Exception JSON schema type string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._reader.TokenType));
				}
				JsonSchemaType? nullable2 = nullable1;
				JsonSchemaType jsonSchemaType = JsonSchemaBuilder.MapType(this._reader.Value.ToString());
				if (nullable2.HasValue)
				{
					nullable = new JsonSchemaType?(nullable2.GetValueOrDefault() | jsonSchemaType);
				}
				else
				{
					nullable = null;
				}
				nullable1 = nullable;
			}
			return nullable1;
		}

		private void Push(JsonSchema value)
		{
			this._currentSchema = value;
			this._stack.Add(value);
			this._resolver.LoadedSchemas.Add(value);
		}
	}
}