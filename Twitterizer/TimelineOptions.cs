using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TimelineOptions : OptionalProperties
	{
		public int Count
		{
			get;
			set;
		}

		public bool IncludeRetweets
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

		public bool SkipUser
		{
			get;
			set;
		}

		public TimelineOptions()
		{
			this.Page = 1;
		}

		internal static void Init<T>(TwitterCommand<T> command, TimelineOptions options)
		where T : ITwitterObject
		{
			decimal maxStatusId;
			command.RequestParameters.Add("include_entities", "true");
			if (options == null)
			{
				options = new TimelineOptions();
			}
			if (options.Count > 0)
			{
				command.RequestParameters.Add("count", options.Count.ToString());
			}
			if (options.IncludeRetweets)
			{
				command.RequestParameters.Add("include_rts", "true");
			}
			if (options.MaxStatusId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = command.RequestParameters;
				maxStatusId = options.MaxStatusId;
				requestParameters.Add("max_id", maxStatusId.ToString());
			}
			command.RequestParameters.Add("page", (options.Page > 0 ? options.Page.ToString() : "1"));
			if (options.SinceStatusId > new decimal(0))
			{
				Dictionary<string, object> strs = command.RequestParameters;
				maxStatusId = options.SinceStatusId;
				strs.Add("since_id", maxStatusId.ToString());
			}
			if (options.SkipUser)
			{
				command.RequestParameters.Add("trim_user", "true");
			}
		}
	}
}