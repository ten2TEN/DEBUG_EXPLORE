using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class UpdateProfileOptions : OptionalProperties
	{
		public string Description
		{
			get;
			set;
		}

		public string Location
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		public UpdateProfileOptions()
		{
		}
	}
}