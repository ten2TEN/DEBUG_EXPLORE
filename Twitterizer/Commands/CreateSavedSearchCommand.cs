using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class CreateSavedSearchCommand : TwitterCommand<TwitterSavedSearch>
	{
		public string Query
		{
			get;
			internal set;
		}

		public CreateSavedSearchCommand(OAuthTokens tokens, string query, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "saved_searches/create.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(query))
			{
				throw new ArgumentException("Query is required.");
			}
			this.Query = query;
		}

		public override void Init()
		{
			if (!string.IsNullOrEmpty(this.Query))
			{
				base.RequestParameters.Add("query", this.Query.ToString(CultureInfo.InvariantCulture));
			}
		}
	}
}