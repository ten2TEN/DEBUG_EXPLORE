using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterMediaEntity : TwitterUrlEntity
	{
		public decimal Id
		{
			get;
			set;
		}

		public string IdString
		{
			get;
			set;
		}

		public TwitterMediaEntity.MediaTypes MediaType
		{
			get;
			set;
		}

		public string MediaUrl
		{
			get;
			set;
		}

		public string MediaUrlSecure
		{
			get;
			set;
		}

		public List<TwitterMediaEntity.MediaSize> Sizes
		{
			get;
			set;
		}

		public TwitterMediaEntity()
		{
		}

		public class MediaSize
		{
			public int Height
			{
				get;
				set;
			}

			public TwitterMediaEntity.MediaSize.MediaSizeResizes Resize
			{
				get;
				set;
			}

			public TwitterMediaEntity.MediaSize.MediaSizes Size
			{
				get;
				set;
			}

			public int Width
			{
				get;
				set;
			}

			public MediaSize()
			{
			}

			public enum MediaSizeResizes
			{
				Unknown,
				Crop,
				Fit
			}

			public enum MediaSizes
			{
				Unknown,
				Thumb,
				Small,
				Medium,
				Large
			}
		}

		public enum MediaTypes
		{
			Unknown,
			Photo
		}
	}
}