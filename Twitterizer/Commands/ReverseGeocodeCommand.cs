using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal class ReverseGeocodeCommand : TwitterCommand<TwitterPlaceCollection>
	{
		public double Latitude
		{
			get;
			set;
		}

		public double Longitude
		{
			get;
			set;
		}

		public ReverseGeocodeCommand(OAuthTokens tokens, double latitude, double longitude, TwitterPlaceLookupOptions options) : base(HTTPVerb.GET, "geo/reverse_geocode.json", tokens, options)
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
		}

		public override void Init()
		{
			NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
			Dictionary<string, object> requestParameters = base.RequestParameters;
			double latitude = this.Latitude;
			requestParameters.Add("lat", latitude.ToString(numberFormat));
			Dictionary<string, object> strs = base.RequestParameters;
			latitude = this.Longitude;
			strs.Add("long", latitude.ToString(numberFormat));
			TwitterPlaceLookupOptions optionalProperties = base.OptionalProperties as TwitterPlaceLookupOptions;
			if (optionalProperties != null)
			{
				if (!string.IsNullOrEmpty(optionalProperties.Accuracy))
				{
					base.RequestParameters.Add("accuracy", optionalProperties.Accuracy);
				}
				if (!string.IsNullOrEmpty(optionalProperties.Granularity))
				{
					base.RequestParameters.Add("granularity", optionalProperties.Granularity);
				}
				if (optionalProperties.MaxResults.HasValue)
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					int value = optionalProperties.MaxResults.Value;
					requestParameters1.Add("max_results", value.ToString(numberFormat));
				}
			}
		}
	}
}