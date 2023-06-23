using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class UpdateProfileBackgroundImageCommand : TwitterCommand<TwitterUser>
	{
		private readonly byte[] imageData;

		public UpdateProfileBackgroundImageCommand(OAuthTokens tokens, byte[] image, UpdateProfileBackgroundImageOptions options) : base(HTTPVerb.POST, "", tokens, options)
		{
			bool flag;
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (options != null || image != null && (int)image.Length != 0)
			{
				flag = (options == null ? true : options.UseImage);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new ArgumentException("Image data cannot be null or zero length.");
			}
			if ((image == null ? false : (int)image.Length > 0x19000))
			{
				throw new ArgumentException("Image cannot exceed 800Kb in size.");
			}
			this.imageData = image;
			base.Multipart = true;
		}

		public override void Init()
		{
			base.RequestParameters.Add("image", this.imageData);
			base.RequestParameters.Add("include_entities", "true");
			UpdateProfileBackgroundImageOptions optionalProperties = base.OptionalProperties as UpdateProfileBackgroundImageOptions;
			if (optionalProperties != null)
			{
				base.RequestParameters.Add("use", (optionalProperties.UseImage ? "1" : "0"));
				if (optionalProperties.Tiled.HasValue)
				{
					base.RequestParameters.Add("tiled", (optionalProperties.Tiled.Value ? "1" : "0"));
				}
			}
		}
	}
}