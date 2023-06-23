using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[DebuggerDisplay("TwitterList = {FullName}")]
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterList : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="uri")]
		public string AbsolutePath
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="description")]
		public string Description
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="full_name")]
		public string FullName
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="id")]
		public long Id
		{
			get;
			set;
		}

		[DataMember]
		public bool IsPublic
		{
			get
			{
				return this.Mode == "public";
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="mode")]
		public string Mode
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="name")]
		public string Name
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="member_count")]
		public int NumberOfMembers
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="subscriber_count")]
		public int NumberOfSubscribers
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="slug")]
		public string Slug
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="user")]
		public TwitterUser User
		{
			get;
			set;
		}

		public TwitterList()
		{
		}

		public static TwitterResponse<TwitterList> AddMember(OAuthTokens tokens, string ownerUsername, string listId, decimal userIdToAdd, OptionalProperties options)
		{
			AddListMemberCommand addListMemberCommand = new AddListMemberCommand(tokens, ownerUsername, listId, userIdToAdd, options);
			return CommandPerformer.PerformAction<TwitterList>(addListMemberCommand);
		}

		public static TwitterResponse<TwitterList> AddMember(OAuthTokens tokens, string Owner, string listId, decimal userId)
		{
			return TwitterList.AddMember(tokens, Owner, listId, userId, null);
		}

		public static TwitterResponse<TwitterList> Delete(OAuthTokens tokens, string username, string listIdOrSlug, OptionalProperties options)
		{
			DeleteListCommand deleteListCommand = new DeleteListCommand(tokens, username, listIdOrSlug, options);
			return CommandPerformer.PerformAction<TwitterList>(deleteListCommand);
		}

		public static TwitterResponse<TwitterListCollection> GetLists(OAuthTokens tokens, GetListsOptions options = null)
		{
			return CommandPerformer.PerformAction<TwitterListCollection>(new GetListsCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUserCollection> GetMembers(OAuthTokens tokens, string username, string listIdOrSlug, GetListMembersOptions options)
		{
			GetListMembersCommand getListMembersCommand = new GetListMembersCommand(tokens, username, listIdOrSlug, options);
			return CommandPerformer.PerformAction<TwitterUserCollection>(getListMembersCommand);
		}

		public static TwitterResponse<TwitterUserCollection> GetMembers(OAuthTokens tokens, string username, string listIdOrSlug)
		{
			return TwitterList.GetMembers(tokens, username, listIdOrSlug, null);
		}

		public static TwitterResponse<TwitterListCollection> GetMemberships(OAuthTokens tokens, string screenname, ListMembershipsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterListCollection>(new ListMembershipsCommand(tokens, screenname, options));
		}

		public static TwitterResponse<TwitterListCollection> GetMemberships(OAuthTokens tokens, string screenname)
		{
			return TwitterList.GetMemberships(tokens, screenname, null);
		}

		public static TwitterResponse<TwitterListCollection> GetMemberships(OAuthTokens tokens, decimal userid, ListMembershipsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterListCollection>(new ListMembershipsCommand(tokens, userid, options));
		}

		public static TwitterResponse<TwitterListCollection> GetMemberships(OAuthTokens tokens, decimal userid)
		{
			return TwitterList.GetMemberships(tokens, userid, null);
		}

		public static TwitterResponse<TwitterStatusCollection> GetStatuses(OAuthTokens tokens, string username, string listIdOrSlug, ListStatusesOptions options)
		{
			ListStatusesCommand listStatusesCommand = new ListStatusesCommand(tokens, username, listIdOrSlug, options);
			return CommandPerformer.PerformAction<TwitterStatusCollection>(listStatusesCommand);
		}

		public static TwitterResponse<TwitterListCollection> GetSubscriptions(OAuthTokens tokens, string userName, GetListSubscriptionsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterListCollection>(new GetListSubscriptionsCommand(tokens, userName, options));
		}

		public static TwitterResponse<TwitterListCollection> GetSubscriptions(OAuthTokens tokens, string userName)
		{
			return TwitterList.GetSubscriptions(tokens, userName, null);
		}

		[Obsolete("The username parameter is no longer required.")]
		public static TwitterResponse<TwitterList> New(OAuthTokens tokens, string username, string name, bool isPublic, string description, OptionalProperties options)
		{
			return TwitterList.New(tokens, name, isPublic, description, options);
		}

		public static TwitterResponse<TwitterList> New(OAuthTokens tokens, string name, bool isPublic, string description, OptionalProperties options)
		{
			CreateListCommand createListCommand = new CreateListCommand(tokens, name, options)
			{
				IsPublic = isPublic,
				Description = description
			};
			return CommandPerformer.PerformAction<TwitterList>(createListCommand);
		}

		public static TwitterResponse<TwitterList> New(OAuthTokens tokens, string username, string name, bool isPublic, string description)
		{
			return TwitterList.New(tokens, name, isPublic, description, null);
		}

		public static TwitterResponse<TwitterList> RemoveMember(OAuthTokens tokens, string Owner, string slug, string screenname, OptionalProperties options)
		{
			RemoveListMemberCommand removeListMemberCommand = new RemoveListMemberCommand(tokens, Owner, slug, screenname, options);
			return CommandPerformer.PerformAction<TwitterList>(removeListMemberCommand);
		}

		public static TwitterResponse<TwitterList> RemoveMember(OAuthTokens tokens, string ownerUsername, string slug, string screenname)
		{
			return TwitterList.RemoveMember(tokens, ownerUsername, slug, screenname, null);
		}

		public static TwitterResponse<TwitterList> Show(OAuthTokens tokens, string slug)
		{
			return TwitterList.Show(tokens, slug, null);
		}

		public static TwitterResponse<TwitterList> Show(OAuthTokens tokens, string slug, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterList>(new GetListCommand(tokens, slug, options));
		}

		public static TwitterResponse<TwitterList> Subscribe(OAuthTokens tokens, decimal listId)
		{
			return TwitterList.Subscribe(tokens, listId, null);
		}

		public static TwitterResponse<TwitterList> Subscribe(OAuthTokens tokens, decimal listId, OptionalProperties optionalProperties)
		{
			return CommandPerformer.PerformAction<TwitterList>(new CreateListMembershipCommand(tokens, listId, optionalProperties));
		}

		public static TwitterResponse<TwitterList> UnSubscribe(OAuthTokens tokens, decimal listId, OptionalProperties optionalProperties)
		{
			return CommandPerformer.PerformAction<TwitterList>(new DestroyListSubscriber(tokens, listId, optionalProperties));
		}

		[Obsolete("The username parameter is no longer required.")]
		public static TwitterResponse<TwitterList> Update(OAuthTokens tokens, string username, string listId, UpdateListOptions options)
		{
			return TwitterList.Update(tokens, listId, options);
		}

		public static TwitterResponse<TwitterList> Update(OAuthTokens tokens, string listId, UpdateListOptions options)
		{
			return CommandPerformer.PerformAction<TwitterList>(new UpdateListCommand(tokens, listId, options));
		}
	}
}