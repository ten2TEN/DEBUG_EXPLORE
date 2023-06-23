using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class GetListsCommand : TwitterCommand<TwitterListCollection>
	{
		public GetListsCommand(OAuthTokens requestTokens, GetListsOptions options) : base(HTTPVerb.GET, "lists/list.json", requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
		}

		public override void Init()
		{
			GetListsOptions optionalProperties = base.OptionalProperties as GetListsOptions;
			if ((optionalProperties == null ? false : optionalProperties.Cursor != (long)0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				long cursor = optionalProperties.Cursor;
				requestParameters.Add("cursor", cursor.ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				base.RequestParameters.Add("cursor", "-1");
			}
		}
	}
}