using System;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Utilities
{
	internal class EnumValues<T> : KeyedCollection<string, EnumValue<T>>
	where T : struct
	{
		public EnumValues()
		{
		}

		protected override string GetKeyForItem(EnumValue<T> item)
		{
			return item.Name;
		}
	}
}