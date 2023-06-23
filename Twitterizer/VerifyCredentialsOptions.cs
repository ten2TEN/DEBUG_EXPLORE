using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class VerifyCredentialsOptions : OptionalProperties
	{
		public bool IncludeEntities
		{
			get;
			set;
		}

		public VerifyCredentialsOptions()
		{
			this.IncludeEntities = false;
		}
	}
}