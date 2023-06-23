using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class ListFavoritesOptions : OptionalProperties
	{
		public int Count
		{
			get;
			set;
		}

		public decimal MaxStatusId
		{
			get;
			set;
		}

		public int Page
		{
			get;
			set;
		}

		public decimal SinceStatusId
		{
			get;
			set;
		}

		public string UserNameOrId
		{
			get;
			set;
		}

		public ListFavoritesOptions()
		{
		}
	}
}