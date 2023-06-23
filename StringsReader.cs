using System;
using System.Reflection;
using System.Resources;

namespace Transaction
{
	public class StringsReader
	{
		public StringsReader()
		{
		}

		public static string GetText(string keyString)
		{
			return (new ResourceManager("Transaction.Utility.Strings", Assembly.GetExecutingAssembly())).GetString(keyString);
		}
	}
}