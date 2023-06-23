using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class FriendsTimelineCommand : PagedTimelineCommand
	{
		public FriendsTimelineCommand(OAuthTokens tokens, TimelineOptions options) : base(HTTPVerb.GET, "statuses/friends_timeline.json", tokens, options)
		{
		}

		public override void Init()
		{
			TimelineOptions optionalProperties = base.OptionalProperties as TimelineOptions;
			if (optionalProperties == null)
			{
				optionalProperties = new TimelineOptions();
			}
			TimelineOptions.Init<TwitterStatusCollection>(this, optionalProperties);
		}
	}
}