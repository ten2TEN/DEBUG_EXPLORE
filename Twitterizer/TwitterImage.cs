using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class TwitterImage
	{
		public byte[] Data
		{
			get;
			set;
		}

		public string Filename
		{
			get;
			set;
		}

		public TwitterImageImageType ImageType
		{
			get;
			set;
		}

		public TwitterImage()
		{
		}

		public string GetMimeType()
		{
			string str;
			switch (this.ImageType)
			{
				case TwitterImageImageType.Jpeg:
				{
					str = "image/jpeg";
					break;
				}
				case TwitterImageImageType.Gif:
				{
					str = "image/gif";
					break;
				}
				case TwitterImageImageType.PNG:
				{
					str = "image/png";
					break;
				}
				default:
				{
					throw new ArgumentOutOfRangeException();
				}
			}
			return str;
		}

		public static TwitterImage ReadFromDisk(string filePath)
		{
			if (!File.Exists(filePath))
			{
				throw new ArgumentException(string.Format("File does not be exist: {0}.", filePath));
			}
			TwitterImage twitterImage = new TwitterImage()
			{
				Data = File.ReadAllBytes(filePath)
			};
			FileInfo fileInfo = new FileInfo(filePath);
			twitterImage.Filename = fileInfo.Name;
			string lower = fileInfo.Extension.ToLower();
			if (lower != null)
			{
				if (lower == ".jpg" || lower == ".jpeg")
				{
					twitterImage.ImageType = TwitterImageImageType.Jpeg;
				}
				else if (lower == ".gif")
				{
					twitterImage.ImageType = TwitterImageImageType.Gif;
				}
				else
				{
					if (lower != ".png")
					{
						throw new Exception("File is not a recognized type. Must be jpg, png, or gif.");
					}
					twitterImage.ImageType = TwitterImageImageType.PNG;
				}
				return twitterImage;
			}
			throw new Exception("File is not a recognized type. Must be jpg, png, or gif.");
		}
	}
}