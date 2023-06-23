using System;
using System.Reflection;

namespace Twitterizer
{
	internal static class Information
	{
		public static string AssemblyVersion()
		{
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}
	}
}