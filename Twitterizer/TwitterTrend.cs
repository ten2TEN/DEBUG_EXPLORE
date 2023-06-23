using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class TwitterTrend : TwitterObject
	{
		[DataMember]
		public string Address
		{
			get;
			set;
		}

		[DataMember]
		public string Events
		{
			get;
			set;
		}

		[DataMember]
		public string Name
		{
			get;
			set;
		}

		[DataMember]
		public string PromotedContent
		{
			get;
			set;
		}

		[DataMember]
		public string SearchQuery
		{
			get;
			set;
		}

		public TwitterTrend()
		{
		}

		public static TwitterResponse<TwitterTrendLocationCollection> Available(OAuthTokens tokens, AvailableTrendsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterTrendLocationCollection>(new AvailableTrendsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterTrendLocationCollection> Available(AvailableTrendsOptions options)
		{
			return TwitterTrend.Available(null, options);
		}

		public static TwitterResponse<TwitterTrendLocationCollection> Available()
		{
			return TwitterTrend.Available(null, null);
		}

		public static TwitterResponse<TwitterTrendCollection> Trends(OAuthTokens tokens, int WoeID, LocalTrendsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterTrendCollection>(new TrendsCommand(tokens, WoeID, options));
		}

		public static TwitterResponse<TwitterTrendCollection> Trends(OAuthTokens tokens, int WoeID)
		{
			return TwitterTrend.Trends(tokens, WoeID, null);
		}

		public static TwitterResponse<TwitterTrendCollection> Trends(int WoeID, LocalTrendsOptions options)
		{
			return TwitterTrend.Trends(null, WoeID, options);
		}

		public static TwitterResponse<TwitterTrendCollection> Trends(int WoeID)
		{
			return TwitterTrend.Trends(null, WoeID, null);
		}
	}
}