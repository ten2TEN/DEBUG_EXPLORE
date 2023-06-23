using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class UpdateListCommand : TwitterCommand<TwitterList>
	{
		private readonly string id;

		public UpdateListCommand(OAuthTokens tokens, string id, UpdateListOptions options) : base(HTTPVerb.POST, "lists/update.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(id))
			{
				throw new ArgumentNullException("id");
			}
			this.id = id;
		}

		public override void Init()
		{
			if (!string.IsNullOrEmpty(this.id))
			{
				base.RequestParameters.Add("list_id", this.id);
			}
			UpdateListOptions optionalProperties = base.OptionalProperties as UpdateListOptions;
			if (optionalProperties != null)
			{
				if (!string.IsNullOrEmpty(optionalProperties.Name))
				{
					base.RequestParameters.Add("name", optionalProperties.Name);
				}
				if (optionalProperties.IsPublic.HasValue)
				{
					base.RequestParameters.Add("mode", (optionalProperties.IsPublic.Value ? "public" : "private"));
				}
				if (!string.IsNullOrEmpty(optionalProperties.Description))
				{
					base.RequestParameters.Add("description", optionalProperties.Description);
				}
			}
		}
	}
}