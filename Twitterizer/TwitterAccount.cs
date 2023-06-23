using System;
using System.IO;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public static class TwitterAccount
	{
		public static TwitterResponse<TwitterUser> UpdateProfile(OAuthTokens tokens, UpdateProfileOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new UpdateProfileCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUser> UpdateProfileBackgroundImage(OAuthTokens tokens, byte[] imageData = null, UpdateProfileBackgroundImageOptions options = null)
		{
			if ((imageData != null ? false : options == null))
			{
				throw new ArgumentNullException("imageData", "You must provide image data or indicate you wish to not use any image in the options argument.");
			}
			return CommandPerformer.PerformAction<TwitterUser>(new UpdateProfileBackgroundImageCommand(tokens, imageData, options));
		}

		public static TwitterResponse<TwitterUser> UpdateProfileBackgroundImage(OAuthTokens tokens, string imageLocation, UpdateProfileBackgroundImageOptions options = null)
		{
			TwitterResponse<TwitterUser> twitterResponse = TwitterAccount.UpdateProfileBackgroundImage(tokens, File.ReadAllBytes(imageLocation), options);
			return twitterResponse;
		}

		public static TwitterResponse<TwitterUser> UpdateProfileColors(OAuthTokens tokens, UpdateProfileColorsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new UpdateProfileColorsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUser> UpdateProfileImage(OAuthTokens tokens, byte[] imageData, OptionalProperties options = null)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new UpdateProfileImageCommand(tokens, imageData, options));
		}

		public static TwitterResponse<TwitterUser> UpdateProfileImage(OAuthTokens tokens, string imageLocation, OptionalProperties options = null)
		{
			TwitterResponse<TwitterUser> twitterResponse = TwitterAccount.UpdateProfileImage(tokens, File.ReadAllBytes(imageLocation), options);
			return twitterResponse;
		}

		public static TwitterResponse<TwitterUser> VerifyCredentials(OAuthTokens tokens, VerifyCredentialsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUser>(new VerifyCredentialsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUser> VerifyCredentials(OAuthTokens tokens)
		{
			return TwitterAccount.VerifyCredentials(tokens, null);
		}
	}
}