using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class UpdateProfileBackgroundImageOptions : OptionalProperties
	{
		public bool? Tiled
		{
			get;
			set;
		}

		public bool UseImage
		{
			get;
			set;
		}

		public UpdateProfileBackgroundImageOptions()
		{
			this.UseImage = true;
		}
	}
}