using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class SearchOptions : OptionalProperties
	{
		public string GeoCode
		{
			get;
			set;
		}

		public bool IncludeEntities
		{
			get;
			set;
		}

		public string Language
		{
			get;
			set;
		}

		public string Locale
		{
			get;
			set;
		}

		public decimal MaxId
		{
			get;
			set;
		}

		public int NumberPerPage
		{
			get;
			set;
		}

		public int PageNumber
		{
			get;
			set;
		}

		public bool PrefixUsername
		{
			get;
			set;
		}

		public SearchOptionsResultType ResultType
		{
			get;
			set;
		}

		public DateTime SinceDate
		{
			get;
			set;
		}

		public decimal SinceId
		{
			get;
			set;
		}

		public DateTime UntilDate
		{
			get;
			set;
		}

		public bool WithTwitterUserID
		{
			get;
			set;
		}

		public SearchOptions()
		{
			base.APIBaseAddress = "https://api.twitter.com/1.1/search/";
		}
	}
}