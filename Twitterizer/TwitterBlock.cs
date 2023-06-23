using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public static class TwitterBlock
	{
		public static TwitterResponse<TwitterIdCollection> BlockingIds(OAuthTokens tokens, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterIdCollection>(new BlockingIdsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterIdCollection> BlockingIds(OAuthTokens tokens)
		{
			return TwitterBlock.BlockingIds(tokens, null);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, decimal userId, OptionalProperties options)
		{
			CreateBlockCommand createBlockCommand = new CreateBlockCommand(tokens, string.Empty, userId, options);
			return CommandPerformer.PerformAction<TwitterUser>(createBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, decimal userId)
		{
			return TwitterBlock.Create(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, string screenName, OptionalProperties options)
		{
			CreateBlockCommand createBlockCommand = new CreateBlockCommand(tokens, screenName, new decimal(-1), options);
			return CommandPerformer.PerformAction<TwitterUser>(createBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Create(OAuthTokens tokens, string screenName)
		{
			return TwitterBlock.Create(tokens, screenName, null);
		}

		public static TwitterResponse<TwitterUser> Destroy(OAuthTokens tokens, decimal userId, OptionalProperties options)
		{
			DestroyBlockCommand destroyBlockCommand = new DestroyBlockCommand(tokens, string.Empty, userId, options);
			return CommandPerformer.PerformAction<TwitterUser>(destroyBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Destroy(OAuthTokens tokens, decimal userId)
		{
			return TwitterBlock.Destroy(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> Destroy(OAuthTokens tokens, string screenName, OptionalProperties options)
		{
			DestroyBlockCommand destroyBlockCommand = new DestroyBlockCommand(tokens, screenName, new decimal(-1), options);
			return CommandPerformer.PerformAction<TwitterUser>(destroyBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Destroy(OAuthTokens tokens, string screenName)
		{
			return TwitterBlock.Destroy(tokens, screenName, null);
		}

		public static TwitterResponse<TwitterUser> Exists(OAuthTokens tokens, decimal userId, OptionalProperties options)
		{
			ExistsBlockCommand existsBlockCommand = new ExistsBlockCommand(tokens, string.Empty, userId, options);
			return CommandPerformer.PerformAction<TwitterUser>(existsBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Exists(OAuthTokens tokens, decimal userId)
		{
			return TwitterBlock.Exists(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> Exists(OAuthTokens tokens, string screenName, OptionalProperties options)
		{
			ExistsBlockCommand existsBlockCommand = new ExistsBlockCommand(tokens, screenName, new decimal(-1), options);
			return CommandPerformer.PerformAction<TwitterUser>(existsBlockCommand);
		}

		public static TwitterResponse<TwitterUser> Exists(OAuthTokens tokens, string screenName)
		{
			return TwitterBlock.Exists(tokens, screenName, null);
		}
	}
}