using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public static class TwitterTimeline
	{
		[Obsolete("This method is deprecated and has been replaced by the HomeTimeline method.")]
		public static TwitterResponse<TwitterStatusCollection> FriendTimeline(OAuthTokens tokens)
		{
			return TwitterTimeline.FriendTimeline(tokens, null);
		}

		[Obsolete("This method is deprecated and has been replaced by the HomeTimeline method.")]
		public static TwitterResponse<TwitterStatusCollection> FriendTimeline(OAuthTokens tokens, TimelineOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new FriendsTimelineCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> HomeTimeline(OAuthTokens tokens, TimelineOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new HomeTimelineCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> HomeTimeline(OAuthTokens tokens)
		{
			return TwitterTimeline.HomeTimeline(tokens, null);
		}

		public static TwitterResponse<TwitterStatusCollection> HomeTimeline(TimelineOptions options)
		{
			return TwitterTimeline.HomeTimeline(null, options);
		}

		public static TwitterResponse<TwitterStatusCollection> Mentions(OAuthTokens tokens, TimelineOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new MentionsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> Mentions(OAuthTokens tokens)
		{
			return TwitterTimeline.Mentions(tokens, null);
		}

		public static TwitterResponse<TwitterStatusCollection> PublicTimeline()
		{
			return TwitterTimeline.PublicTimeline((OAuthTokens)null);
		}

		public static TwitterResponse<TwitterStatusCollection> PublicTimeline(OAuthTokens tokens)
		{
			return TwitterTimeline.PublicTimeline(tokens, null);
		}

		public static TwitterResponse<TwitterStatusCollection> PublicTimeline(OptionalProperties options)
		{
			return TwitterTimeline.PublicTimeline(null, options);
		}

		public static TwitterResponse<TwitterStatusCollection> PublicTimeline(OAuthTokens tokens, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new PublicTimelineCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> UserTimeline(OAuthTokens tokens, UserTimelineOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new UserTimelineCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> UserTimeline(OAuthTokens tokens)
		{
			return TwitterTimeline.UserTimeline(tokens, null);
		}

		public static TwitterResponse<TwitterStatusCollection> UserTimeline(UserTimelineOptions options)
		{
			return TwitterTimeline.UserTimeline(null, options);
		}
	}
}