using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class MentionsCommand : PagedTimelineCommand
	{
		public MentionsCommand(OAuthTokens tokens, TimelineOptions options) : base(HTTPVerb.GET, "statuses/mentions_timeline.json", tokens, options)
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