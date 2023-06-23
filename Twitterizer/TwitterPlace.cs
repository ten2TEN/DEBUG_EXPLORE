using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[DebuggerDisplay("{FullName} ({Id})")]
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public sealed class TwitterPlace : TwitterObject
	{
		[JsonProperty(PropertyName="app:id")]
		public string AppIds
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="bounding_box")]
		public TwitterBoundingBox BoundingBox
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="country")]
		public string Country
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="country_code")]
		public string CountryCode
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="url")]
		public string DataAddress
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="full_name")]
		public string FullName
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="id")]
		public string Id
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="iso3")]
		public string Iso3CountryCode
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="locality")]
		public string Locality
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="name")]
		public string Name
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="phone")]
		public string Phone
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="place_type")]
		public string PlaceType
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="postal_code")]
		public string PostalCode
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="region")]
		public string Region
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="street_address")]
		public string StreetAddress
		{
			get;
			set;
		}

		public TwitterPlace()
		{
		}

		public static TwitterResponse<TwitterPlaceCollection> Lookup(OAuthTokens tokens, double latitude, double longitude, TwitterPlaceLookupOptions options)
		{
			ReverseGeocodeCommand reverseGeocodeCommand = new ReverseGeocodeCommand(tokens, latitude, longitude, options);
			return CommandPerformer.PerformAction<TwitterPlaceCollection>(reverseGeocodeCommand);
		}

		public static TwitterResponse<TwitterPlaceCollection> Lookup(OAuthTokens tokens, double latitude, double longitude)
		{
			return TwitterPlace.Lookup(tokens, latitude, longitude, null);
		}
	}
}