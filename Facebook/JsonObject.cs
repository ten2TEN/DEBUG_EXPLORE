using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Facebook
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("simple-json", "1.0.0")]
	public class JsonObject : DynamicObject, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private readonly Dictionary<string, object> _members;

		public int Count
		{
			get
			{
				return this._members.Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public object this[int index]
		{
			get
			{
				return JsonObject.GetAtIndex(this._members, index);
			}
		}

		public object this[string key]
		{
			get
			{
				return this._members[key];
			}
			set
			{
				this._members[key] = value;
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				return this._members.Keys;
			}
		}

		public ICollection<object> Values
		{
			get
			{
				return this._members.Values;
			}
		}

		public JsonObject()
		{
			this._members = new Dictionary<string, object>();
		}

		public JsonObject(IEqualityComparer<string> comparer)
		{
			this._members = new Dictionary<string, object>(comparer);
		}

		public void Add(string key, object value)
		{
			this._members.Add(key, value);
		}

		public void Add(KeyValuePair<string, object> item)
		{
			this._members.Add(item.Key, item.Value);
		}

		public void Clear()
		{
			this._members.Clear();
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			if (!this._members.ContainsKey(item.Key))
			{
				return false;
			}
			return this._members[item.Key] == item.Value;
		}

		public bool ContainsKey(string key)
		{
			return this._members.ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int count = this.Count;
			foreach (KeyValuePair<string, object> keyValuePair in this)
			{
				int num = arrayIndex;
				arrayIndex = num + 1;
				array[num] = keyValuePair;
				int num1 = count - 1;
				count = num1;
				if (num1 > 0)
				{
					continue;
				}
				return;
			}
		}

		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			object value;
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (index >= obj.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			using (IEnumerator<KeyValuePair<string, object>> enumerator = obj.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, object> current = enumerator.Current;
					int num1 = num;
					num = num1 + 1;
					if (num1 != index)
					{
						continue;
					}
					value = current.Value;
					return value;
				}
				return null;
			}
			return value;
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			foreach (string str in this.Keys)
			{
				yield return str;
			}
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		public bool Remove(string key)
		{
			return this._members.Remove(key);
		}

		public bool Remove(KeyValuePair<string, object> item)
		{
			return this._members.Remove(item.Key);
		}

		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		public override string ToString()
		{
			return SimpleJson.SerializeObject(this);
		}

		public override bool TryConvert(ConvertBinder binder, out object result)
		{
			if (binder == null)
			{
				throw new ArgumentNullException("binder");
			}
			Type type = binder.Type;
			if (!(type == typeof(IEnumerable)) && !(type == typeof(IEnumerable<KeyValuePair<string, object>>)) && !(type == typeof(IDictionary<string, object>)) && !(type == typeof(IDictionary)))
			{
				return base.TryConvert(binder, out result);
			}
			result = this;
			return true;
		}

		public override bool TryDeleteMember(DeleteMemberBinder binder)
		{
			if (binder == null)
			{
				throw new ArgumentNullException("binder");
			}
			return this._members.Remove(binder.Name);
		}

		public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
		{
			if (indexes == null)
			{
				throw new ArgumentNullException("indexes");
			}
			if ((int)indexes.Length != 1)
			{
				result = null;
				return true;
			}
			result = ((IDictionary<string, object>)this)[(string)indexes[0]];
			return true;
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			object obj;
			if (this._members.TryGetValue(binder.Name, out obj))
			{
				result = obj;
				return true;
			}
			result = null;
			return true;
		}

		public bool TryGetValue(string key, out object value)
		{
			return this._members.TryGetValue(key, out value);
		}

		public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
		{
			if (indexes == null)
			{
				throw new ArgumentNullException("indexes");
			}
			if ((int)indexes.Length != 1)
			{
				return base.TrySetIndex(binder, indexes, value);
			}
			((IDictionary<string, object>)this)[(string)indexes[0]] = value;
			return true;
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			if (binder == null)
			{
				throw new ArgumentNullException("binder");
			}
			this._members[binder.Name] = value;
			return true;
		}
	}
}