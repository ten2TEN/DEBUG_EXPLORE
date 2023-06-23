using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class ThreadSafeStore<TKey, TValue>
	{
		private readonly object _lock;

		private Dictionary<TKey, TValue> _store;

		private readonly Func<TKey, TValue> _creator;

		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			if (creator == null)
			{
				throw new ArgumentNullException("creator");
			}
			this._creator = creator;
		}

		private TValue AddValue(TKey key)
		{
			TValue tValue;
			TValue tValue1;
			TValue tValue2 = this._creator(key);
			lock (this._lock)
			{
				if (this._store == null)
				{
					this._store = new Dictionary<TKey, TValue>();
					this._store[key] = tValue2;
				}
				else if (!this._store.TryGetValue(key, out tValue))
				{
					Dictionary<TKey, TValue> tKeys = new Dictionary<TKey, TValue>(this._store);
					tKeys[key] = tValue2;
					this._store = tKeys;
				}
				else
				{
					tValue1 = tValue;
					return tValue1;
				}
				tValue1 = tValue2;
			}
			return tValue1;
		}

		public TValue Get(TKey key)
		{
			TValue tValue;
			if (this._store == null)
			{
				return this.AddValue(key);
			}
			if (this._store.TryGetValue(key, out tValue))
			{
				return tValue;
			}
			return this.AddValue(key);
		}
	}
}