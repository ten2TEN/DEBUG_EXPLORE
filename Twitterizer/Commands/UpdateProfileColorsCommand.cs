using System;
using System.Collections.Generic;
using System.Drawing;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal class UpdateProfileColorsCommand : TwitterCommand<TwitterUser>
	{
		public UpdateProfileColorsCommand(OAuthTokens tokens, UpdateProfileColorsOptions options) : base(HTTPVerb.POST, "account/update_profile_colors.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
		}

		public override void Init()
		{
			UpdateProfileColorsOptions optionalProperties = (UpdateProfileColorsOptions)base.OptionalProperties;
			if (optionalProperties.BackgroundColor != Color.Empty)
			{
				base.RequestParameters.Add("profile_background_color", ColorTranslator.ToHtml(optionalProperties.BackgroundColor));
			}
			if (optionalProperties.TextColor != Color.Empty)
			{
				base.RequestParameters.Add("profile_text_color", ColorTranslator.ToHtml(optionalProperties.TextColor));
			}
			if (optionalProperties.LinkColor != Color.Empty)
			{
				base.RequestParameters.Add("profile_link_color", ColorTranslator.ToHtml(optionalProperties.LinkColor));
			}
			if (optionalProperties.SidebarFillColor != Color.Empty)
			{
				base.RequestParameters.Add("profile_sidebar_fill_color", ColorTranslator.ToHtml(optionalProperties.SidebarFillColor));
			}
			if (optionalProperties.SidebarBorderColor != Color.Empty)
			{
				base.RequestParameters.Add("profile_sidebar_border_color", ColorTranslator.ToHtml(optionalProperties.SidebarBorderColor));
			}
		}
	}
}