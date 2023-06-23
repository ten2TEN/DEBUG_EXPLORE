using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Newtonsoft.Json.Serialization
{
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		private readonly Type _type;

		public JsonPropertyCollection(Type type) : base(StringComparer.Ordinal)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			this._type = type;
		}

		public void AddProperty(JsonProperty property)
		{
			if (base.Contains(property.PropertyName))
			{
				if (property.Ignored)
				{
					return;
				}
				JsonProperty item = base[property.PropertyName];
				bool flag = true;
				if (item.Ignored)
				{
					base.Remove(item);
					flag = false;
				}
				if (property.DeclaringType != null && item.DeclaringType != null)
				{
					if (property.DeclaringType.IsSubclassOf(item.DeclaringType))
					{
						base.Remove(item);
						flag = false;
					}
					if (item.DeclaringType.IsSubclassOf(property.DeclaringType))
					{
						return;
					}
				}
				if (flag)
				{
					throw new JsonSerializationException("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".FormatWith(CultureInfo.InvariantCulture, property.PropertyName, this._type));
				}
			}
			base.Add(property);
		}

		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			JsonProperty property = this.GetProperty(propertyName, StringComparison.Ordinal) ?? this.GetProperty(propertyName, StringComparison.OrdinalIgnoreCase);
			return property;
		}

		protected override string GetKeyForItem(JsonProperty item)
		{
			return item.PropertyName;
		}

		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			JsonProperty jsonProperty;
			JsonProperty jsonProperty1;
			if (comparisonType == StringComparison.Ordinal)
			{
				if (this.TryGetValue(propertyName, out jsonProperty))
				{
					return jsonProperty;
				}
				return null;
			}
			using (IEnumerator<JsonProperty> enumerator = base.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					JsonProperty current = enumerator.Current;
					if (!string.Equals(propertyName, current.PropertyName, comparisonType))
					{
						continue;
					}
					jsonProperty1 = current;
					return jsonProperty1;
				}
				return null;
			}
			return jsonProperty1;
		}

		private bool TryGetValue(string key, out JsonProperty item)
		{
			if (base.Dictionary == null)
			{
				item = null;
				return false;
			}
			return base.Dictionary.TryGetValue(key, out item);
		}
	}
}