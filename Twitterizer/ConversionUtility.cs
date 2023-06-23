using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Twitterizer
{
	internal static class ConversionUtility
	{
		internal static Color FromTwitterString(string value)
		{
			Color color;
			if (!string.IsNullOrEmpty(value))
			{
				color = (!Regex.IsMatch(value, "^#?[a-f0-9]{6}$", RegexOptions.IgnoreCase) ? Color.FromName(value) : ColorTranslator.FromHtml(Regex.Replace(value, "^#?([a-f0-9]{6})$", "#$1", RegexOptions.IgnoreCase)));
			}
			else
			{
				color = new Color();
			}
			return color;
		}

		internal static byte[] ReadStream(Stream responseStream)
		{
			byte[] array = new byte[0x8000];
			byte[] numArray = new byte[0x8000];
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				bool flag = false;
				while (!flag)
				{
					int num = responseStream.Read(numArray, 0, (int)numArray.Length);
					if (num > 0)
					{
						memoryStream.Write(numArray, 0, num);
					}
					else
					{
						array = memoryStream.ToArray();
						flag = true;
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					((IDisposable)memoryStream).Dispose();
				}
			}
			return array;
		}
	}
}