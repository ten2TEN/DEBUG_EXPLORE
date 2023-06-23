using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class CreateListCommand : TwitterCommand<TwitterList>
	{
		public string Description
		{
			get;
			set;
		}

		public bool IsPublic
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public CreateListCommand(OAuthTokens requestTokens, string name, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "lists/create.json", requestTokens, options)
		{
			if (base.Tokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}
			this.Name = name;
		}

		public override void Init()
		{
			base.RequestParameters.Add("name", this.Name);
			base.RequestParameters.Add("mode", (this.IsPublic ? "public" : "private"));
			if (!string.IsNullOrEmpty(this.Description))
			{
				base.RequestParameters.Add("description", this.Description);
			}
		}
	}
}