using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Twitterizer.Core;

namespace Twitterizer
{
	[DebuggerDisplay("@{ErrorMessage}")]
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	[XmlRoot("hash")]
	public class TwitterErrorDetails : TwitterObject
	{
		[JsonProperty(PropertyName="error")]
		[XmlElement("error")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="request")]
		[XmlElement("request")]
		public string RequestPath
		{
			get;
			set;
		}

		public TwitterErrorDetails()
		{
		}
	}
}