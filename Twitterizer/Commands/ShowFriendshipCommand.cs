using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class ShowFriendshipCommand : TwitterCommand<TwitterRelationship>
	{
		private const string Path = "friendships/show.json";

		public decimal SourceId
		{
			get;
			set;
		}

		public string SourceScreenName
		{
			get;
			set;
		}

		public decimal TargetId
		{
			get;
			set;
		}

		public string TargetScreenName
		{
			get;
			set;
		}

		public ShowFriendshipCommand(OAuthTokens tokens, decimal sourceUserId, string sourceUserName, decimal targetUserId, string targetScreenName, Twitterizer.OptionalProperties optionalProperties) : base(HTTPVerb.GET, "friendships/show.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				if ((sourceUserId > new decimal(0) ? false : string.IsNullOrEmpty(sourceUserName)))
				{
					throw new ArgumentException("For unauthorized show friendship requests, a source and target are required.");
				}
			}
			if ((targetUserId > new decimal(0) ? false : string.IsNullOrEmpty(targetScreenName)))
			{
				throw new ArgumentException("A target user id or screen name is required.");
			}
			this.SourceId = sourceUserId;
			this.SourceScreenName = sourceUserName;
			this.TargetId = targetUserId;
			this.TargetScreenName = targetScreenName;
		}

		public override void Init()
		{
			decimal sourceId;
			if (this.SourceId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				sourceId = this.SourceId;
				requestParameters.Add("source_id", sourceId.ToString(CultureInfo.InvariantCulture));
			}
			else if (!string.IsNullOrEmpty(this.SourceScreenName))
			{
				base.RequestParameters.Add("source_screen_name", this.SourceScreenName);
			}
			if (this.TargetId > new decimal(0))
			{
				Dictionary<string, object> strs = base.RequestParameters;
				sourceId = this.TargetId;
				strs.Add("target_id", sourceId.ToString(CultureInfo.InvariantCulture));
			}
			else if (!string.IsNullOrEmpty(this.TargetScreenName))
			{
				base.RequestParameters.Add("target_screen_name", this.TargetScreenName);
			}
		}
	}
}