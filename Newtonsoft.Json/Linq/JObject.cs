using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Linq
{
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		private readonly JPropertyKeyedCollection _properties = new JPropertyKeyedCollection();

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._properties;
			}
		}

		public override JToken this[object key]
		{
			get
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				string str = key as string;
				if (str == null)
				{
					throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this[str];
			}
			set
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				string str = key as string;
				if (str == null)
				{
					throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this[str] = value;
			}
		}

		public JToken this[string propertyName]
		{
			get
			{
				ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
				JProperty jProperty = this.Property(propertyName);
				if (jProperty == null)
				{
					return null;
				}
				return jProperty.Value;
			}
			set
			{
				JProperty jProperty = this.Property(propertyName);
				if (jProperty != null)
				{
					jProperty.Value = value;
					return;
				}
				this.OnPropertyChanging(propertyName);
				this.Add(new JProperty(propertyName, value));
				this.OnPropertyChanged(propertyName);
			}
		}

		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
		{
			get
			{
				return this._properties.Keys;
			}
		}

		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override JTokenType Type
		{
			get
			{
				return JTokenType.Object;
			}
		}

		public JObject()
		{
		}

		public JObject(JObject other) : base(other)
		{
		}

		public JObject(params object[] content) : this((object)content)
		{
		}

		public JObject(object content)
		{
			this.Add(content);
		}

		public void Add(string propertyName, JToken value)
		{
			this.Add(new JProperty(propertyName, value));
		}

		internal override JToken CloneToken()
		{
			return new JObject(this);
		}

		internal override bool DeepEquals(JToken node)
		{
			JObject jObjects = node as JObject;
			if (jObjects == null)
			{
				return false;
			}
			return this._properties.Compare(jObjects._properties);
		}

		public static new JObject FromObject(object o)
		{
			return JObject.FromObject(o, new JsonSerializer());
		}

		public static new JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jTokens = JToken.FromObjectInternal(o, jsonSerializer);
			if (jTokens != null && jTokens.Type != JTokenType.Object)
			{
				throw new ArgumentException("Object serialized to {0}. JObject instance expected.".FormatWith(CultureInfo.InvariantCulture, jTokens.Type));
			}
			return (JObject)jTokens;
		}

		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			foreach (JProperty childrenToken in this.ChildrenTokens)
			{
				yield return new KeyValuePair<string, JToken>(childrenToken.Name, childrenToken.Value);
			}
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JObject>(parameter, this, new JObject.JObjectDynamicProxy(), true);
		}

		private static System.Type GetTokenPropertyType(JToken token)
		{
			if (!(token is JValue))
			{
				return token.GetType();
			}
			JValue jValue = (JValue)token;
			if (jValue.Value == null)
			{
				return typeof(object);
			}
			return jValue.Value.GetType();
		}

		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (item != null && item.Type == JTokenType.Comment)
			{
				return;
			}
			base.InsertItem(index, item, skipParentCheck);
		}

		internal void InternalPropertyChanged(JProperty childProperty)
		{
			this.OnPropertyChanged(childProperty.Name);
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, base.IndexOfItem(childProperty)));
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, (IList)childProperty, (IList)childProperty, base.IndexOfItem(childProperty)));
		}

		internal void InternalPropertyChanging(JProperty childProperty)
		{
			this.OnPropertyChanging(childProperty.Name);
		}

		public static new JObject Load(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JObject from JsonReader.");
			}
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(reader, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JObject jObjects = new JObject();
			jObjects.SetLineInfo(reader as IJsonLineInfo);
			jObjects.ReadTokenFrom(reader);
			return jObjects;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		protected virtual void OnPropertyChanging(string propertyName)
		{
			if (this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}

		public static new JObject Parse(string json)
		{
			JsonReader jsonTextReader = new JsonTextReader(new StringReader(json));
			JObject jObjects = JObject.Load(jsonTextReader);
			if (jsonTextReader.Read() && jsonTextReader.TokenType != JsonToken.Comment)
			{
				throw JsonReaderException.Create(jsonTextReader, "Additional text found in JSON string after parsing content.");
			}
			return jObjects;
		}

		public IEnumerable<JProperty> Properties()
		{
			return this.ChildrenTokens.Cast<JProperty>();
		}

		public JProperty Property(string name)
		{
			JToken jTokens;
			if (name == null)
			{
				return null;
			}
			this._properties.TryGetValue(name, out jTokens);
			return (JProperty)jTokens;
		}

		public JEnumerable<JToken> PropertyValues()
		{
			return new JEnumerable<JToken>(
				from p in this.Properties()
				select p.Value);
		}

		public bool Remove(string propertyName)
		{
			JProperty jProperty = this.Property(propertyName);
			if (jProperty == null)
			{
				return false;
			}
			jProperty.Remove();
			return true;
		}

		void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item)
		{
			this.Add(new JProperty(item.Key, item.Value));
		}

		void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear()
		{
			base.RemoveAll();
		}

		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			JProperty jProperty = this.Property(item.Key);
			if (jProperty == null)
			{
				return false;
			}
			return jProperty.Value == item.Value;
		}

		void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= (int)array.Length)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (base.Count > (int)array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (JProperty childrenToken in this.ChildrenTokens)
			{
				array[arrayIndex + num] = new KeyValuePair<string, JToken>(childrenToken.Name, childrenToken.Value);
				num++;
			}
		}

		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			if (!((ICollection<KeyValuePair<string, JToken>>)this).Contains(item))
			{
				return false;
			}
			((IDictionary<string, JToken>)this).Remove(item.Key);
			return true;
		}

		bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key)
		{
			return this._properties.Contains(key);
		}

		AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
		{
			return new TypeConverter();
		}

		EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType)
		{
			return null;
		}

		EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return EventDescriptorCollection.Empty;
		}

		EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection propertyDescriptorCollections = new PropertyDescriptorCollection(null);
			foreach (KeyValuePair<string, JToken> keyValuePair in this)
			{
				propertyDescriptorCollections.Add(new JPropertyDescriptor(keyValuePair.Key, JObject.GetTokenPropertyType(keyValuePair.Value)));
			}
			return propertyDescriptorCollections;
		}

		object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		public bool TryGetValue(string propertyName, out JToken value)
		{
			JProperty jProperty = this.Property(propertyName);
			if (jProperty == null)
			{
				value = null;
				return false;
			}
			value = jProperty.Value;
			return true;
		}

		internal override void ValidateToken(JToken o, JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type != JTokenType.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
			JProperty jProperty = (JProperty)o;
			if (existing != null)
			{
				JProperty jProperty1 = (JProperty)existing;
				if (jProperty.Name == jProperty1.Name)
				{
					return;
				}
			}
			if (this._properties.TryGetValue(jProperty.Name, out existing))
			{
				throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".FormatWith(CultureInfo.InvariantCulture, jProperty.Name, base.GetType()));
			}
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartObject();
			foreach (JProperty childrenToken in this.ChildrenTokens)
			{
				childrenToken.WriteTo(writer, converters);
			}
			writer.WriteEndObject();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public event PropertyChangingEventHandler PropertyChanging;

		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			public JObjectDynamicProxy()
			{
			}

			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return 
					from p in instance.Properties()
					select p.Name;
			}

			public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object result)
			{
				result = instance[binder.Name];
				return true;
			}

			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				JToken jValue = value as JToken;
				if (jValue == null)
				{
					jValue = new JValue(value);
				}
				instance[binder.Name] = jValue;
				return true;
			}
		}
	}
}