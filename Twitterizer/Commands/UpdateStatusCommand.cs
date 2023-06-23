using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class UpdateStatusCommand : TwitterCommand<TwitterStatus>
	{
		public string Text
		{
			get;
			set;
		}

		public UpdateStatusCommand(OAuthTokens tokens, string text, StatusUpdateOptions optionalProperties) : base(HTTPVerb.POST, "statuses/update.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException("text");
			}
			this.Text = text;
		}

		public override void Init()
		{
			double latitude;
			base.RequestParameters.Add("status", this.Text);
			StatusUpdateOptions optionalProperties = base.OptionalProperties as StatusUpdateOptions;
			if (optionalProperties != null)
			{
				NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
				if (optionalProperties.InReplyToStatusId > new decimal(0))
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					decimal inReplyToStatusId = optionalProperties.InReplyToStatusId;
					requestParameters.Add("in_reply_to_status_id", inReplyToStatusId.ToString(CultureInfo.CurrentCulture));
				}
				if (optionalProperties.Latitude != 0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					latitude = optionalProperties.Latitude;
					strs.Add("lat", latitude.ToString(numberFormat));
				}
				if (optionalProperties.Longitude != 0)
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					latitude = optionalProperties.Longitude;
					requestParameters1.Add("long", latitude.ToString(numberFormat));
				}
				if (!string.IsNullOrEmpty(optionalProperties.PlaceId))
				{
					base.RequestParameters.Add("place_id", optionalProperties.PlaceId);
				}
				if (optionalProperties.PlacePin)
				{
					base.RequestParameters.Add("display_coordinates", "true");
				}
				if (optionalProperties.WrapLinks)
				{
					base.RequestParameters.Add("wrap_links", "true");
				}
			}
		}
	}
}