using System;

namespace Twitterizer.Core
{
	[AttributeUsage(AttributeTargets.Class, Inherited=false, AllowMultiple=false)]
	internal sealed class AuthorizedCommandAttribute : Attribute
	{
		public AuthorizedCommandAttribute()
		{
		}
	}
}