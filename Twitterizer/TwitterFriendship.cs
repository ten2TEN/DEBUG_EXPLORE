using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public static class TwitterFriendship
	{
		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, decimal userId)
		{
			return TwitterFriendship.Create(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, decimal userId, CreateFriendshipOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new CreateFriendshipCommand(tokens, userId, options));
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, string userName)
		{
			return TwitterFriendship.Create(tokens, userName, null);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, string userName, CreateFriendshipOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new CreateFriendshipCommand(tokens, userName, options));
		}

		public static TwitterResponse<TwitterUser> Delete(OAuthTokens tokens, decimal userId)
		{
			return TwitterFriendship.Delete(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> Delete(OAuthTokens tokens, decimal userId, OptionalProperties options)
		{
			DeleteFriendshipCommand deleteFriendshipCommand = new DeleteFriendshipCommand(tokens, userId, string.Empty, options);
			return CommandPerformer.PerformAction<TwitterUser>(deleteFriendshipCommand);
		}

		public static TwitterResponse<TwitterUser> Delete(OAuthTokens tokens, string userName)
		{
			return TwitterFriendship.Delete(tokens, userName, null);
		}

		public static TwitterResponse<TwitterUser> Delete(OAuthTokens tokens, string userName, OptionalProperties options)
		{
			DeleteFriendshipCommand deleteFriendshipCommand = new DeleteFriendshipCommand(tokens, new decimal(0), userName, options);
			return CommandPerformer.PerformAction<TwitterUser>(deleteFriendshipCommand);
		}

		public static TwitterResponse<TwitterUserCollection> Followers(OAuthTokens tokens, FollowersOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUserCollection>(new FollowersCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUserCollection> Followers(OAuthTokens tokens)
		{
			return TwitterFriendship.Followers(tokens, null);
		}

		public static TwitterResponse<TwitterUserCollection> Followers(FollowersOptions options)
		{
			return TwitterFriendship.Followers(null, options);
		}

		public static TwitterResponse<UserIdCollection> FollowersIds(OAuthTokens tokens, UsersIdsOptions options)
		{
			return CommandPerformer.PerformAction<UserIdCollection>(new FollowersIdsCommand(tokens, options));
		}

		public static TwitterResponse<UserIdCollection> FollowersIds(OAuthTokens tokens)
		{
			return TwitterFriendship.FollowersIds(tokens, null);
		}

		[Obsolete("This method is deprecated as it will only return information about users who have Tweeted recently. It is not a functional way to retrieve all of a users friends. Instead of using this method use a combination of friends/ids and users/lookup.")]
		public static TwitterResponse<TwitterUserCollection> Friends(OAuthTokens tokens, FriendsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUserCollection>(new FriendsCommand(tokens, options));
		}

		[Obsolete("This method is deprecated as it will only return information about users who have Tweeted recently. It is not a functional way to retrieve all of a users friends. Instead of using this method use a combination of friends/ids and users/lookup.")]
		public static TwitterResponse<TwitterUserCollection> Friends(OAuthTokens tokens)
		{
			return TwitterFriendship.Friends(tokens, null);
		}

		[Obsolete("This method is deprecated as it will only return information about users who have Tweeted recently. It is not a functional way to retrieve all of a users friends. Instead of using this method use a combination of friends/ids and users/lookup.")]
		public static TwitterResponse<TwitterUserCollection> Friends(FriendsOptions options)
		{
			return TwitterFriendship.Friends(null, options);
		}

		public static TwitterResponse<UserIdCollection> FriendsIds(OAuthTokens tokens, UsersIdsOptions options)
		{
			return CommandPerformer.PerformAction<UserIdCollection>(new FriendsIdsCommand(tokens, options));
		}

		public static TwitterResponse<UserIdCollection> FriendsIds(OAuthTokens tokens)
		{
			return TwitterFriendship.FriendsIds(tokens, null);
		}

		public static TwitterResponse<TwitterCursorPagedIdCollection> IncomingRequests(OAuthTokens tokens, IncomingFriendshipsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterCursorPagedIdCollection>(new IncomingFriendshipsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterCursorPagedIdCollection> IncomingRequests(OAuthTokens tokens)
		{
			return TwitterFriendship.IncomingRequests(tokens, null);
		}

		public static TwitterResponse<TwitterCursorPagedIdCollection> OutgoingRequests(OAuthTokens tokens, OutgoingFriendshipsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterCursorPagedIdCollection>(new OutgoingFriendshipsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterCursorPagedIdCollection> OutgoingRequests(OAuthTokens tokens)
		{
			return TwitterFriendship.OutgoingRequests(tokens, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, decimal targetUserId)
		{
			return TwitterFriendship.Show(tokens, targetUserId, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, decimal targetUserId, OptionalProperties options)
		{
			TwitterResponse<TwitterRelationship> twitterResponse = TwitterFriendship.Show(tokens, new decimal(0), targetUserId, options);
			return twitterResponse;
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, decimal sourceUseId, decimal targetUserId)
		{
			return TwitterFriendship.Show(tokens, sourceUseId, targetUserId, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, decimal sourceUseId, decimal targetUserId, OptionalProperties options)
		{
			ShowFriendshipCommand showFriendshipCommand = new ShowFriendshipCommand(tokens, sourceUseId, string.Empty, targetUserId, string.Empty, options);
			return CommandPerformer.PerformAction<TwitterRelationship>(showFriendshipCommand);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, string targetUserName)
		{
			return TwitterFriendship.Show(tokens, string.Empty, targetUserName, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, string targetUserName, OptionalProperties options)
		{
			return TwitterFriendship.Show(tokens, string.Empty, targetUserName, options);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, string sourceUserName, string targetUserName)
		{
			return TwitterFriendship.Show(tokens, sourceUserName, targetUserName, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(OAuthTokens tokens, string sourceUserName, string targetUserName, OptionalProperties options)
		{
			ShowFriendshipCommand showFriendshipCommand = new ShowFriendshipCommand(tokens, new decimal(0), sourceUserName, new decimal(0), targetUserName, options);
			return CommandPerformer.PerformAction<TwitterRelationship>(showFriendshipCommand);
		}

		public static TwitterResponse<TwitterRelationship> Show(decimal sourceUseId, decimal targetUserId)
		{
			return TwitterFriendship.Show(null, sourceUseId, targetUserId, null);
		}

		public static TwitterResponse<TwitterRelationship> Show(string sourceUserName, string targetUserName)
		{
			return TwitterFriendship.Show(null, sourceUserName, targetUserName, null);
		}

		public static TwitterResponse<TwitterRelationship> Update(OAuthTokens tokens, decimal userid, UpdateFriendshipOptions options)
		{
			return CommandPerformer.PerformAction<TwitterRelationship>(new UpdateFriendshipCommand(tokens, userid, options));
		}

		public static TwitterResponse<TwitterRelationship> Update(OAuthTokens tokens, decimal userid)
		{
			return TwitterFriendship.Update(tokens, userid, null);
		}

		public static TwitterResponse<TwitterRelationship> Update(OAuthTokens tokens, string screenname, UpdateFriendshipOptions options)
		{
			return CommandPerformer.PerformAction<TwitterRelationship>(new UpdateFriendshipCommand(tokens, screenname, options));
		}

		public static TwitterResponse<TwitterRelationship> Update(OAuthTokens tokens, string screenname)
		{
			return TwitterFriendship.Update(tokens, screenname, null);
		}
	}
}