using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class HomeTimelineCommand : PagedTimelineCommand
	{
		public HomeTimelineCommand(OAuthTokens tokens, TimelineOptions optionalProperties) : base(HTTPVerb.GET, "statuses/home_timeline.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
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