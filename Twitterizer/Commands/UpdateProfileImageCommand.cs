using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal class UpdateProfileImageCommand : TwitterCommand<TwitterUser>
	{
		private readonly byte[] imageData;

		public UpdateProfileImageCommand(OAuthTokens tokens, byte[] image, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "account/update_profile_image.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if ((image == null ? true : (int)image.Length == 0))
			{
				throw new ArithmeticException("Image data cannot be null or zero length.");
			}
			if ((int)image.Length > 0xaf000)
			{
				throw new ArithmeticException("Image cannot exceed 700Kb in size.");
			}
			this.imageData = image;
			base.Multipart = true;
		}

		public override void Init()
		{
			base.RequestParameters.Add("image", this.imageData);
			base.RequestParameters.Add("include_entities", "true");
		}
	}
}