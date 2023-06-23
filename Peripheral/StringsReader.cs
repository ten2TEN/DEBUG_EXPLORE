using System;
using System.Reflection;
using System.Resources;

namespace Peripheral
{
	public class StringsReader
	{
		public StringsReader()
		{
		}

		public static string GetText(string keyString)
		{
			return (new ResourceManager("\u0099\b.\u001c\u0002", Assembly.GetExecutingAssembly())).GetString(keyString);
		}
	}
}