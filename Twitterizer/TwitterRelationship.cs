using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[DebuggerDisplay("TwitterRelationship = {Source} -> {Target}")]
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterRelationship : TwitterObject
	{
		[JsonProperty(PropertyName="relationship")]
		public TwitterRelationship Relationship
		{
			get
			{
				return this;
			}
			set
			{
				if (value != null)
				{
					this.Target = value.Target;
					this.Source = value.Source;
				}
			}
		}

		[JsonProperty(PropertyName="source")]
		public TwitterRelationshipUser Source
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="target")]
		public TwitterRelationshipUser Target
		{
			get;
			set;
		}

		public TwitterRelationship()
		{
		}

		public TwitterResponse<TwitterUser> Delete(OAuthTokens tokens)
		{
			DeleteFriendshipCommand deleteFriendshipCommand = new DeleteFriendshipCommand(tokens, this.Target.Id, string.Empty, null);
			return CommandPerformer.PerformAction<TwitterUser>(deleteFriendshipCommand);
		}
	}
}