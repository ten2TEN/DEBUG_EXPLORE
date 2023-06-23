using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook
{
	public class FacebookClient
	{
		private const int BufferSize = 0x1000;

		private const string AttachmentMustHavePropertiesSetError = "Attachment (FacebookMediaObject/FacebookMediaStream) must have a content type, file name, and value set.";

		private const string AttachmentValueIsNull = "The value of attachment (FacebookMediaObject/FacebookMediaStream) is null.";

		private const string UnknownResponse = "Unknown facebook response.";

		private const string MultiPartFormPrefix = "--";

		private const string MultiPartNewLine = "\r\n";

		private const string ETagKey = "_etag_";

		private const string AtLeastOneBatchParameterRequried = "At least one batch parameter is required";

		private const string OnlyOneAttachmentAllowedPerBatchRequest = "Only one attachement (FacebookMediaObject/FacebookMediaStream) allowed per FacebookBatchParamter.";

		private const string InvalidSignedRequest = "Invalid signed_request";

		private const string SubscriptionXHubSigntureRequestHeaderKey = "X-Hub-Signature";

		private const string SubscriptionHubChallengeKey = "hub.challenge";

		private const string SubscriptionHubVerifyTokenKey = "hub.verify_token";

		private const string SubscriptionHubModeKey = "hub.mode";

		private const string InvalidHttpXHubSignature = "Invalid X-Hub-Signature request header";

		private const string InvalidHubChallenge = "Invalid hub.challenge";

		private const string InvalidVerifyToken = "Invalid hub.verify_token";

		private const string InvalidHubMode = "Invalid hub.mode";

		internal readonly static string[] LegacyRestApiReadOnlyCalls;

		private string _accessToken;

		private string _appId;

		private string _appSecret;

		private bool _isSecureConnection;

		private bool _useFacebookBeta;

		private string _version;

		private static string _defaultVersion;

		private Func<object, string> _serializeJson;

		private static Func<object, string> _defaultJsonSerializer;

		private Func<string, Type, object> _deserializeJson;

		private static Func<string, Type, object> _defaultJsonDeserializer;

		private Func<Uri, HttpWebRequestWrapper> _httpWebRequestFactory;

		private static Func<Uri, HttpWebRequestWrapper> _defaultHttpWebRequestFactory;

		private HttpWebRequestWrapper _httpWebRequest;

		private object _httpWebRequestLocker = new object();

		public virtual string AccessToken
		{
			get
			{
				return this._accessToken;
			}
			set
			{
				this._accessToken = value;
			}
		}

		public virtual string AppId
		{
			get
			{
				return this._appId;
			}
			set
			{
				this._appId = value;
			}
		}

		public virtual string AppSecret
		{
			get
			{
				return this._appSecret;
			}
			set
			{
				this._appSecret = value;
			}
		}

		internal Func<string> Boundary
		{
			get;
			set;
		}

		public static string DefaultVersion
		{
			get
			{
				return FacebookClient._defaultVersion;
			}
			set
			{
				FacebookClient._defaultVersion = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use SetJsonSerializers")]
		public virtual Func<string, Type, object> DeserializeJson
		{
			get
			{
				return this._deserializeJson;
			}
			set
			{
				Func<string, Type, object> func = value;
				if (func == null)
				{
					Func<string, Type, object> func1 = FacebookClient._defaultJsonDeserializer;
					Func<string, Type, object> func2 = func1;
					this._deserializeJson = func1;
					func = func2;
				}
				this._deserializeJson = func;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use SetHttpWebRequestFactory.")]
		public virtual Func<Uri, HttpWebRequestWrapper> HttpWebRequestFactory
		{
			get
			{
				return this._httpWebRequestFactory;
			}
			set
			{
				Func<Uri, HttpWebRequestWrapper> func = value;
				if (func == null)
				{
					Func<Uri, HttpWebRequestWrapper> func1 = FacebookClient._defaultHttpWebRequestFactory;
					Func<Uri, HttpWebRequestWrapper> func2 = func1;
					this._httpWebRequestFactory = func1;
					func = func2;
				}
				this._httpWebRequestFactory = func;
			}
		}

		public virtual bool IsSecureConnection
		{
			get
			{
				return this._isSecureConnection;
			}
			set
			{
				this._isSecureConnection = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use SetJsonSerializers")]
		public virtual Func<object, string> SerializeJson
		{
			get
			{
				Func<object, string> func = this._serializeJson;
				if (func == null)
				{
					Func<object, string> func1 = FacebookClient._defaultJsonSerializer;
					Func<object, string> func2 = func1;
					this._serializeJson = func1;
					func = func2;
				}
				return func;
			}
			set
			{
				this._serializeJson = value;
			}
		}

		public virtual string SubscriptionVerifyToken
		{
			get;
			set;
		}

		public virtual bool UseFacebookBeta
		{
			get
			{
				return this._useFacebookBeta;
			}
			set
			{
				this._useFacebookBeta = value;
			}
		}

		public virtual string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}

		static FacebookClient()
		{
			string[] strArrays = new string[] { "admin.getallocation", "admin.getappproperties", "admin.getbannedusers", "admin.getlivestreamvialink", "admin.getmetrics", "admin.getrestrictioninfo", "application.getpublicinfo", "auth.getapppublickey", "auth.getsession", "auth.getsignedpublicsessiondata", "comments.get", "connect.getunconnectedfriendscount", "dashboard.getactivity", "dashboard.getcount", "dashboard.getglobalnews", "dashboard.getnews", "dashboard.multigetcount", "dashboard.multigetnews", "data.getcookies", "events.get", "events.getmembers", "fbml.getcustomtags", "feed.getappfriendstories", "feed.getregisteredtemplatebundlebyid", "feed.getregisteredtemplatebundles", "fql.multiquery", "fql.query", "friends.arefriends", "friends.get", "friends.getappusers", "friends.getlists", "friends.getmutualfriends", "gifts.get", "groups.get", "groups.getmembers", "intl.gettranslations", "links.get", "notes.get", "notifications.get", "pages.getinfo", "pages.isadmin", "pages.isappadded", "pages.isfan", "permissions.checkavailableapiaccess", "permissions.checkgrantedapiaccess", "photos.get", "photos.getalbums", "photos.gettags", "profile.getinfo", "profile.getinfooptions", "stream.get", "stream.getcomments", "stream.getfilters", "users.getinfo", "users.getloggedinuser", "users.getstandardinfo", "users.hasapppermission", "users.isappuser", "users.isverified", "video.getuploadlimits" };
			FacebookClient.LegacyRestApiReadOnlyCalls = strArrays;
			FacebookClient.SetDefaultJsonSerializers(null, null);
		}

		public FacebookClient()
		{
			this._version = FacebookClient._defaultVersion;
			this._deserializeJson = FacebookClient._defaultJsonDeserializer;
			this._httpWebRequestFactory = FacebookClient._defaultHttpWebRequestFactory;
		}

		public FacebookClient(string accessToken) : this()
		{
			if (string.IsNullOrEmpty(accessToken))
			{
				throw new ArgumentNullException("accessToken");
			}
			this._accessToken = accessToken;
		}

		protected virtual object Api(HttpMethod httpMethod, string path, object parameters, Type resultType)
		{
			Stream stream;
			bool flag;
			IList<int> nums;
			string end;
			HttpHelper httpHelper = this.PrepareRequest(httpMethod, path, parameters, resultType, out stream, out flag, out nums);
			if (stream != null)
			{
				try
				{
					try
					{
						using (Stream stream1 = httpHelper.OpenWrite())
						{
							byte[] numArray = new byte[0x1000];
							while (true)
							{
								int num = stream.Read(numArray, 0, (int)numArray.Length);
								stream.Flush();
								if (num <= 0)
								{
									break;
								}
								stream1.Write(numArray, 0, num);
								stream1.Flush();
							}
						}
					}
					catch (WebExceptionWrapper webExceptionWrapper)
					{
						if (webExceptionWrapper.GetResponse() == null)
						{
							throw;
						}
					}
				}
				finally
				{
					stream.Dispose();
				}
			}
			Stream stream2 = null;
			object obj = null;
			bool flag1 = false;
			try
			{
				try
				{
					stream2 = httpHelper.OpenRead();
					flag1 = true;
				}
				catch (WebExceptionWrapper webExceptionWrapper1)
				{
					HttpWebResponseWrapper response = webExceptionWrapper1.GetResponse();
					if (response == null)
					{
						throw;
					}
					if (response.StatusCode != HttpStatusCode.NotModified)
					{
						stream2 = httpHelper.OpenRead();
						flag1 = true;
					}
					else
					{
						JsonObject jsonObjects = new JsonObject();
						JsonObject item = new JsonObject();
						string[] allKeys = response.Headers.AllKeys;
						for (int i = 0; i < (int)allKeys.Length; i++)
						{
							string str = allKeys[i];
							item[str] = response.Headers[str];
						}
						jsonObjects["headers"] = item;
						obj = jsonObjects;
					}
				}
			}
			finally
			{
				if (flag1)
				{
					using (Stream stream3 = stream2)
					{
						using (StreamReader streamReader = new StreamReader(stream3))
						{
							end = streamReader.ReadToEnd();
						}
					}
					obj = this.ProcessResponse(httpHelper, end, resultType, flag, nums);
				}
			}
			return obj;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ApiTaskAsync instead.")]
		protected virtual void ApiAsync(HttpMethod httpMethod, string path, object parameters, Type resultType, object userState)
		{
			Stream stream;
			bool flag;
			IList<int> nums = null;
			HttpHelper httpHelper = this.PrepareRequest(httpMethod, path, parameters, resultType, out stream, out flag, out nums);
			this._httpWebRequest = httpHelper.HttpWebRequest;
			if (this.HttpWebRequestWrapperCreated != null)
			{
				this.HttpWebRequestWrapperCreated(this, new HttpWebRequestCreatedEventArgs(userState, httpHelper.HttpWebRequest));
			}
			EventHandler<FacebookUploadProgressChangedEventArgs> eventHandler = this.UploadProgressChanged;
			bool flag1 = (eventHandler == null ? false : httpHelper.HttpWebRequest.Method == "POST");
			httpHelper.OpenReadCompleted += new OpenReadCompletedEventHandler((object o, Facebook.OpenReadCompletedEventArgs e) => {
				FacebookApiEventArgs facebookApiEventArg;
				if (!e.Cancelled)
				{
					if (e.Error != null)
					{
						WebExceptionWrapper error = e.Error as WebExceptionWrapper;
						if (error == null)
						{
							facebookApiEventArg = new FacebookApiEventArgs(e.Error, httpHelper.HttpWebRequest.IsCancelled, userState, null);
							this.OnCompleted(httpMethod, facebookApiEventArg);
							return;
						}
						else if (error.GetResponse() != null)
						{
							HttpWebResponseWrapper httpWebResponse = httpHelper.HttpWebResponse;
							if (httpWebResponse.StatusCode == HttpStatusCode.NotModified)
							{
								JsonObject jsonObjects = new JsonObject();
								JsonObject item = new JsonObject();
								string[] allKeys = httpWebResponse.Headers.AllKeys;
								for (int i = 0; i < (int)allKeys.Length; i++)
								{
									string str = allKeys[i];
									item[str] = httpWebResponse.Headers[str];
								}
								jsonObjects["headers"] = item;
								facebookApiEventArg = new FacebookApiEventArgs(null, false, userState, jsonObjects);
								this.OnCompleted(httpMethod, facebookApiEventArg);
								return;
							}
							httpHelper.OpenReadAsync();
						}
						else
						{
							facebookApiEventArg = new FacebookApiEventArgs(error, false, userState, null);
							this.OnCompleted(httpMethod, facebookApiEventArg);
							return;
						}
					}
					else
					{
						string end = null;
						try
						{
							using (Stream result = e.Result)
							{
								HttpWebResponseWrapper httpWebResponseWrapper = httpHelper.HttpWebResponse;
								if (httpWebResponseWrapper == null || httpWebResponseWrapper.StatusCode != HttpStatusCode.NotModified)
								{
									using (StreamReader streamReader = new StreamReader(result))
									{
										end = streamReader.ReadToEnd();
									}
								}
								else
								{
									JsonObject jsonObjects1 = new JsonObject();
									JsonObject item1 = new JsonObject();
									string[] strArrays = httpWebResponseWrapper.Headers.AllKeys;
									for (int j = 0; j < (int)strArrays.Length; j++)
									{
										string str1 = strArrays[j];
										item1[str1] = httpWebResponseWrapper.Headers[str1];
									}
									jsonObjects1["headers"] = item1;
									facebookApiEventArg = new FacebookApiEventArgs(null, false, userState, jsonObjects1);
									this.OnCompleted(httpMethod, facebookApiEventArg);
									return;
								}
							}
							try
							{
								object obj = this.ProcessResponse(httpHelper, end, resultType, flag, nums);
								facebookApiEventArg = new FacebookApiEventArgs(null, false, userState, obj);
							}
							catch (Exception exception)
							{
								facebookApiEventArg = new FacebookApiEventArgs(exception, false, userState, null);
							}
							this.OnCompleted(httpMethod, facebookApiEventArg);
							return;
						}
						catch (Exception exception2)
						{
							Exception exception1 = exception2;
							facebookApiEventArg = (httpHelper.HttpWebRequest.IsCancelled ? new FacebookApiEventArgs(exception1, true, userState, null) : new FacebookApiEventArgs(exception1, false, userState, null));
							this.OnCompleted(httpMethod, facebookApiEventArg);
							return;
						}
					}
					return;
				}
				else
				{
					facebookApiEventArg = new FacebookApiEventArgs(e.Error, true, userState, null);
				}
				this.OnCompleted(httpMethod, facebookApiEventArg);
			});
			if (stream == null)
			{
				httpHelper.OpenReadAsync();
				return;
			}
			httpHelper.OpenWriteCompleted += new OpenWriteCompletedEventHandler((object o, Facebook.OpenWriteCompletedEventArgs e) => {
				FacebookApiEventArgs facebookApiEventArg;
				int num;
				if (!e.Cancelled)
				{
					if (e.Error != null)
					{
						stream.Dispose();
						WebExceptionWrapper error = e.Error as WebExceptionWrapper;
						if (error != null && error.GetResponse() != null)
						{
							httpHelper.OpenReadAsync();
							return;
						}
						facebookApiEventArg = new FacebookApiEventArgs(e.Error, false, userState, null);
						this.OnCompleted(httpMethod, facebookApiEventArg);
						return;
					}
					else
					{
						try
						{
							try
							{
								using (Stream result = e.Result)
								{
									byte[] numArray = new byte[0x1000];
									if (!flag1)
									{
										while (true)
										{
											int num1 = stream.Read(numArray, 0, (int)numArray.Length);
											num = num1;
											if (num1 == 0)
											{
												break;
											}
											result.Write(numArray, 0, num);
											result.Flush();
										}
									}
									else
									{
										long length = stream.Length;
										long num2 = (long)0;
										while (true)
										{
											int num3 = stream.Read(numArray, 0, (int)numArray.Length);
											num = num3;
											if (num3 == 0)
											{
												break;
											}
											result.Write(numArray, 0, num);
											result.Flush();
											num2 += (long)num;
											this.OnUploadProgressChanged(new FacebookUploadProgressChangedEventArgs((long)0, (long)0, num2, length, (int)(num2 * (long)100 / length), userState));
										}
									}
								}
								httpHelper.OpenReadAsync();
								return;
							}
							catch (Exception exception)
							{
								facebookApiEventArg = new FacebookApiEventArgs(exception, httpHelper.HttpWebRequest.IsCancelled, userState, null);
							}
							this.OnCompleted(httpMethod, facebookApiEventArg);
							return;
						}
						finally
						{
							stream.Dispose();
						}
					}
					return;
				}
				else
				{
					stream.Dispose();
					facebookApiEventArg = new FacebookApiEventArgs(e.Error, true, userState, null);
				}
				this.OnCompleted(httpMethod, facebookApiEventArg);
			});
			httpHelper.OpenWriteAsync();
		}

		protected virtual Task<object> ApiTaskAsync(HttpMethod httpMethod, string path, object parameters, Type resultType, object userState, CancellationToken cancellationToken)
		{
			TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>(userState);
			if (cancellationToken.IsCancellationRequested)
			{
				taskCompletionSource.TrySetCanceled();
				return taskCompletionSource.Task;
			}
			HttpWebRequestWrapper httpWebRequestWrapper = null;
			EventHandler<HttpWebRequestCreatedEventArgs> eventHandler = null;
			eventHandler += new EventHandler<HttpWebRequestCreatedEventArgs>((object o, HttpWebRequestCreatedEventArgs e) => {
				if (e.UserState != taskCompletionSource)
				{
					return;
				}
				httpWebRequestWrapper = e.HttpWebRequest;
			});
			CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.Register(() => {
				try
				{
					if (httpWebRequestWrapper != null)
					{
						httpWebRequestWrapper.Abort();
					}
				}
				catch
				{
				}
			});
			EventHandler<FacebookApiEventArgs> task = null;
			task = (object sender, FacebookApiEventArgs e) => FacebookClient.TransferCompletionToTask<object>(taskCompletionSource, e, new Func<object>(e.GetResultData), () => {
				cancellationTokenRegistration.Dispose();
				this.RemoveTaskAsyncHandlers(httpMethod, task);
				this.HttpWebRequestWrapperCreated -= eventHandler;
			});
			if (httpMethod == HttpMethod.Get)
			{
				this.GetCompleted += task;
			}
			else if (httpMethod != HttpMethod.Post)
			{
				if (httpMethod != HttpMethod.Delete)
				{
					throw new ArgumentOutOfRangeException("httpMethod");
				}
				this.DeleteCompleted += task;
			}
			else
			{
				this.PostCompleted += task;
			}
			this.HttpWebRequestWrapperCreated += eventHandler;
			try
			{
				this.ApiAsync(httpMethod, path, parameters, resultType, taskCompletionSource);
			}
			catch
			{
				this.RemoveTaskAsyncHandlers(httpMethod, task);
				this.HttpWebRequestWrapperCreated -= eventHandler;
				throw;
			}
			return taskCompletionSource.Task;
		}

		private static byte[] Base64UrlDecode(string base64UrlSafeString)
		{
			if (string.IsNullOrEmpty(base64UrlSafeString))
			{
				throw new ArgumentNullException("base64UrlSafeString");
			}
			base64UrlSafeString = base64UrlSafeString.PadRight(base64UrlSafeString.Length + (4 - base64UrlSafeString.Length % 4) % 4, '=');
			base64UrlSafeString = base64UrlSafeString.Replace('-', '+').Replace('\u005F', '/');
			return Convert.FromBase64String(base64UrlSafeString);
		}

		public virtual object Batch(params FacebookBatchParameter[] batchParameters)
		{
			return this.Batch(batchParameters, null);
		}

		public virtual object Batch(FacebookBatchParameter[] batchParameters, object parameters)
		{
			return this.Post(this.PrepareBatchRequest(batchParameters, parameters));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BatchTaskAsync instead.")]
		public virtual void BatchAsync(FacebookBatchParameter[] batchParameters, object userState, object parameters)
		{
			this.PostAsync(null, this.PrepareBatchRequest(batchParameters, parameters), userState);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BatchTaskAsync instead.")]
		public virtual void BatchAsync(FacebookBatchParameter[] batchParameters, object userState)
		{
			this.BatchAsync(batchParameters, userState, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BatchTaskAsync instead.")]
		public virtual void BatchAsync(FacebookBatchParameter[] batchParameters)
		{
			this.BatchAsync(batchParameters, null);
		}

		public virtual Task<object> BatchTaskAsync(params FacebookBatchParameter[] batchParameters)
		{
			return this.BatchTaskAsync(batchParameters, null, CancellationToken.None);
		}

		public virtual Task<object> BatchTaskAsync(FacebookBatchParameter[] batchParameters, object userState, CancellationToken cancellationToken)
		{
			return this.BatchTaskAsync(batchParameters, userState, null, cancellationToken);
		}

		public virtual Task<object> BatchTaskAsync(FacebookBatchParameter[] batchParameters, object userState, object parameters, CancellationToken cancellationToken)
		{
			object obj = this.PrepareBatchRequest(batchParameters, parameters);
			return this.PostTaskAsync(null, obj, userState, cancellationToken);
		}

		private static string BuildHttpQuery(object parameter, Func<string, string> encode)
		{
			IDictionary<string, FacebookMediaObject> strs;
			IDictionary<string, FacebookMediaStream> strs1;
			if (parameter == null)
			{
				return "null";
			}
			if (parameter is string)
			{
				return (string)parameter;
			}
			if (parameter is bool)
			{
				if (!(bool)parameter)
				{
					return "false";
				}
				return "true";
			}
			if (parameter is int || parameter is long || parameter is float || parameter is double || parameter is decimal || parameter is byte || parameter is sbyte || parameter is short || parameter is ushort || parameter is uint || parameter is ulong)
			{
				return parameter.ToString();
			}
			if (parameter is Uri)
			{
				return parameter.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (parameter is IEnumerable<KeyValuePair<string, object>>)
			{
				foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>)parameter)
				{
					stringBuilder.AppendFormat("{0}={1}&", encode(keyValuePair.Key), encode(FacebookClient.BuildHttpQuery(keyValuePair.Value, encode)));
				}
			}
			else if (!(parameter is IEnumerable<KeyValuePair<string, string>>))
			{
				if (!(parameter is IEnumerable))
				{
					if (parameter is DateTime)
					{
						return DateTimeConvertor.ToIso8601FormattedDateTime((DateTime)parameter);
					}
					IDictionary<string, object> dictionary = FacebookClient.ToDictionary(parameter, out strs, out strs1);
					if (strs.Count > 0 || strs1.Count > 0)
					{
						throw new InvalidOperationException("Parameter can contain attachements (FacebookMediaObject/FacebookMediaStream) only in the top most level.");
					}
					return FacebookClient.BuildHttpQuery(dictionary, encode);
				}
				foreach (object obj in (IEnumerable)parameter)
				{
					stringBuilder.AppendFormat("{0},", encode(FacebookClient.BuildHttpQuery(obj, encode)));
				}
			}
			else
			{
				foreach (KeyValuePair<string, string> keyValuePair1 in (IEnumerable<KeyValuePair<string, string>>)parameter)
				{
					stringBuilder.AppendFormat("{0}={1}&", encode(keyValuePair1.Key), encode(keyValuePair1.Value));
				}
			}
			if (stringBuilder.Length > 0)
			{
				StringBuilder length = stringBuilder;
				length.Length = length.Length - 1;
			}
			return stringBuilder.ToString();
		}

		public virtual void CancelAsync()
		{
			lock (this._httpWebRequestLocker)
			{
				if (this._httpWebRequest != null)
				{
					this._httpWebRequest.Abort();
				}
			}
		}

		private static byte[] ComputeHmacSha1Hash(byte[] data, byte[] key)
		{
			byte[] numArray;
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			using (HMACSHA1 hMACSHA1 = new HMACSHA1(key))
			{
				numArray = hMACSHA1.ComputeHash(data);
			}
			return numArray;
		}

		private static byte[] ComputeHmacSha256Hash(byte[] data, byte[] key)
		{
			byte[] numArray;
			using (HMACSHA256 hMACSHA256 = new HMACSHA256(key))
			{
				numArray = hMACSHA256.ComputeHash(data);
			}
			return numArray;
		}

		public virtual object Delete(string path)
		{
			return this.Delete(path, null);
		}

		public virtual object Delete(string path, object parameters)
		{
			return this.Api(HttpMethod.Delete, path, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DeleteTaskAsync instead.")]
		public virtual void DeleteAsync(string path)
		{
			this.DeleteAsync(path, null, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DeleteTaskAsync instead.")]
		public virtual void DeleteAsync(string path, object parameters, object userState)
		{
			this.ApiAsync(HttpMethod.Delete, path, parameters, null, userState);
		}

		public virtual Task<object> DeleteTaskAsync(string path)
		{
			return this.DeleteTaskAsync(path, null, CancellationToken.None);
		}

		public virtual Task<object> DeleteTaskAsync(string path, object parameters, CancellationToken cancellationToken)
		{
			return this.ApiTaskAsync(HttpMethod.Delete, path, parameters, null, null, cancellationToken);
		}

		public virtual object Get(string path)
		{
			return this.Get(path, null);
		}

		public virtual object Get(object parameters)
		{
			return this.Get(null, parameters);
		}

		public virtual object Get(string path, object parameters)
		{
			return this.Get(path, parameters, null);
		}

		public virtual object Get(string path, object parameters, Type resultType)
		{
			return this.Api(HttpMethod.Get, path, parameters, resultType);
		}

		public virtual TResult Get<TResult>(string path)
		{
			return this.Get<TResult>(path, null);
		}

		public virtual TResult Get<TResult>(object parameters)
		{
			return this.Get<TResult>(null, parameters);
		}

		public virtual TResult Get<TResult>(string path, object parameters)
		{
			return (TResult)this.Get(path, parameters, typeof(TResult));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync(string path)
		{
			this.GetAsync(path, null, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync(object parameters)
		{
			this.GetAsync(null, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync(string path, object parameters)
		{
			this.GetAsync(path, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync(string path, object parameters, object userState)
		{
			this.GetAsync(path, parameters, userState, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync(string path, object parameters, object userState, Type resultType)
		{
			this.ApiAsync(HttpMethod.Get, path, parameters, resultType, userState);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync<TResult>(string path, object parameters, object userState)
		{
			this.ApiAsync(HttpMethod.Get, path, parameters, typeof(TResult), userState);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync<TResult>(string path, object parameters)
		{
			this.GetAsync<TResult>(path, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync<TResult>(string path)
		{
			this.GetAsync<TResult>(path, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetTaskAsync instead.")]
		public virtual void GetAsync<TResult>(object parameters)
		{
			this.GetAsync<TResult>(null, parameters);
		}

		public virtual Uri GetDialogUrl(string dialog, object parameters)
		{
			IDictionary<string, FacebookMediaObject> strs;
			IDictionary<string, FacebookMediaStream> strs1;
			if (string.IsNullOrEmpty(dialog))
			{
				throw new ArgumentNullException("dialog");
			}
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			object dictionary = FacebookClient.ToDictionary(parameters, out strs, out strs1);
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, object>();
			}
			IDictionary<string, object> strs2 = (IDictionary<string, object>)dictionary;
			bool item = false;
			if (strs2.ContainsKey("mobile"))
			{
				item = (bool)strs2["mobile"];
				strs2.Remove("mobile");
			}
			if (dialog.Equals("oauth", StringComparison.OrdinalIgnoreCase) && !strs2.ContainsKey("client_id") && !string.IsNullOrEmpty(this.AppId))
			{
				strs2.Add("client_id", this.AppId);
			}
			if (!dialog.Equals("oauth", StringComparison.OrdinalIgnoreCase) && !strs2.ContainsKey("app_id") && !string.IsNullOrEmpty(this.AppId))
			{
				strs2.Add("app_id", this.AppId);
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat((item ? "https://m.facebook.com/" : "https://www.facebook.com/"), new object[0]);
			if (!string.IsNullOrEmpty(this.Version))
			{
				stringBuilder.AppendFormat("{0}/", this.Version);
			}
			stringBuilder.AppendFormat("dialog/{0}?", dialog);
			foreach (KeyValuePair<string, object> keyValuePair in strs2)
			{
				stringBuilder.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair.Value, new Func<string, string>(HttpHelper.UrlEncode))));
			}
			StringBuilder length = stringBuilder;
			length.Length = length.Length - 1;
			return new Uri(stringBuilder.ToString());
		}

		internal static Exception GetException(HttpHelper httpHelper, object result)
		{
			if (result == null)
			{
				return null;
			}
			IDictionary<string, object> strs = result as IDictionary<string, object>;
			if (strs == null)
			{
				return null;
			}
			FacebookApiException facebookOAuthException = null;
			if (httpHelper != null)
			{
				Uri responseUri = httpHelper.HttpWebResponse.ResponseUri;
				if (responseUri.Host == "api.facebook.com" || responseUri.Host == "api-read.facebook.com" || responseUri.Host == "api-video.facebook.com" || responseUri.Host == "api.beta.facebook.com" || responseUri.Host == "api-read.beta.facebook.com" || responseUri.Host == "api-video.facebook.com")
				{
					if (!strs.ContainsKey("error_code"))
					{
						return null;
					}
					string str = strs["error_code"].ToString();
					string item = null;
					if (strs.ContainsKey("error_msg"))
					{
						item = strs["error_msg"] as string;
					}
					if (str == "190")
					{
						facebookOAuthException = new FacebookOAuthException(item, str);
					}
					else if (str == "4" || str == "API_EC_TOO_MANY_CALLS" || item != null && item.Contains("request limit reached"))
					{
						facebookOAuthException = new FacebookApiLimitException(item, str);
					}
					else
					{
						facebookOAuthException = new FacebookApiException(item, str);
					}
					return facebookOAuthException;
				}
			}
			if (strs.ContainsKey("error"))
			{
				IDictionary<string, object> item1 = strs["error"] as IDictionary<string, object>;
				if (item1 == null)
				{
					long? nullable = null;
					if (strs["error"] is long)
					{
						nullable = new long?((long)strs["error"]);
					}
					if (!nullable.HasValue && strs["error"] is int)
					{
						nullable = new long?((long)((int)strs["error"]));
					}
					string str1 = null;
					if (strs.ContainsKey("error_description"))
					{
						str1 = strs["error_description"] as string;
					}
					if (nullable.HasValue && !string.IsNullOrEmpty(str1))
					{
						long? nullable1 = nullable;
						if ((nullable1.GetValueOrDefault() != (long)190 ? true : !nullable1.HasValue))
						{
							long value = nullable.Value;
							facebookOAuthException = new FacebookApiException(str1, value.ToString(CultureInfo.InvariantCulture));
						}
						else
						{
							facebookOAuthException = new FacebookOAuthException(str1, "API_EC_PARAM_ACCESS_TOKEN");
						}
					}
				}
				else
				{
					string item2 = item1["type"] as string;
					string str2 = item1["message"] as string;
					int num = 0;
					if (item1.ContainsKey("code"))
					{
						int.TryParse(item1["code"].ToString(), out num);
					}
					int num1 = 0;
					if (item1.ContainsKey("error_subcode"))
					{
						int.TryParse(item1["error_subcode"].ToString(), out num1);
					}
					if (!string.IsNullOrEmpty(item2) && !string.IsNullOrEmpty(str2))
					{
						if (item2 == "OAuthException")
						{
							facebookOAuthException = new FacebookOAuthException(str2, item2, num, num1);
						}
						else if (item2 == "API_EC_TOO_MANY_CALLS" || str2.Contains("request limit reached"))
						{
							facebookOAuthException = new FacebookApiLimitException(str2, item2);
						}
						else
						{
							facebookOAuthException = new FacebookApiException(str2, item2, num, num1);
						}
					}
				}
			}
			return facebookOAuthException;
		}

		public virtual Uri GetLoginUrl(object parameters)
		{
			return this.GetDialogUrl("oauth", parameters);
		}

		public virtual Uri GetLogoutUrl(object parameters)
		{
			IDictionary<string, FacebookMediaObject> strs;
			IDictionary<string, FacebookMediaStream> strs1;
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			IDictionary<string, object> dictionary = FacebookClient.ToDictionary(parameters, out strs, out strs1);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("https://www.facebook.com/logout.php?");
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, object> keyValuePair in dictionary)
				{
					stringBuilder.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair.Value, new Func<string, string>(HttpHelper.UrlEncode))));
				}
			}
			StringBuilder length = stringBuilder;
			length.Length = length.Length - 1;
			return new Uri(stringBuilder.ToString());
		}

		public virtual Task<object> GetTaskAsync(string path)
		{
			return this.GetTaskAsync(path, null, CancellationToken.None);
		}

		public virtual Task<object> GetTaskAsync(object parameters)
		{
			return this.GetTaskAsync(null, parameters, CancellationToken.None);
		}

		public virtual Task<object> GetTaskAsync(string path, object parameters)
		{
			return this.GetTaskAsync(path, parameters, CancellationToken.None);
		}

		public virtual Task<object> GetTaskAsync(string path, object parameters, CancellationToken cancellationToken)
		{
			return this.GetTaskAsync(path, parameters, cancellationToken, null);
		}

		public virtual Task<object> GetTaskAsync(string path, object parameters, CancellationToken cancellationToken, Type resultType)
		{
			return this.ApiTaskAsync(HttpMethod.Get, path, parameters, resultType, null, cancellationToken);
		}

		public virtual Task<TResult> GetTaskAsync<TResult>(string path, object parameters, CancellationToken cancellationToken)
		{
			return this.GetTaskAsync(path, parameters, cancellationToken, typeof(TResult)).Then<object, TResult>((object result) => (TResult)result);
		}

		public virtual Task<TResult> GetTaskAsync<TResult>(string path, object parameters)
		{
			return this.GetTaskAsync<TResult>(path, parameters, CancellationToken.None);
		}

		public virtual Task<TResult> GetTaskAsync<TResult>(object parameters)
		{
			return this.GetTaskAsync<TResult>(null, parameters);
		}

		public virtual Task<TResult> GetTaskAsync<TResult>(string path)
		{
			return this.GetTaskAsync<TResult>(path, null);
		}

		[Obsolete]
		private void OnCompleted(HttpMethod httpMethod, FacebookApiEventArgs args)
		{
			switch (httpMethod)
			{
				case HttpMethod.Get:
				{
					this.OnGetCompleted(args);
					return;
				}
				case HttpMethod.Post:
				{
					this.OnPostCompleted(args);
					return;
				}
				case HttpMethod.Delete:
				{
					this.OnDeleteCompleted(args);
					return;
				}
			}
			throw new ArgumentOutOfRangeException("httpMethod");
		}

		[Obsolete]
		protected virtual void OnDeleteCompleted(FacebookApiEventArgs args)
		{
			if (this.DeleteCompleted != null)
			{
				this.DeleteCompleted(this, args);
			}
		}

		[Obsolete]
		protected virtual void OnGetCompleted(FacebookApiEventArgs args)
		{
			if (this.GetCompleted != null)
			{
				this.GetCompleted(this, args);
			}
		}

		[Obsolete]
		protected virtual void OnPostCompleted(FacebookApiEventArgs args)
		{
			if (this.PostCompleted != null)
			{
				this.PostCompleted(this, args);
			}
		}

		[Obsolete]
		protected void OnUploadProgressChanged(FacebookUploadProgressChangedEventArgs args)
		{
			if (this.UploadProgressChanged != null)
			{
				this.UploadProgressChanged(this, args);
			}
		}

		public virtual object ParseDialogCallbackUrl(Uri uri)
		{
			Dictionary<string, object> strs = new Dictionary<string, object>();
			FacebookClient.ParseUrlQueryString(uri.Query, strs, true);
			string serializeJson = this.SerializeJson(strs);
			return this.DeserializeJson(serializeJson, null);
		}

		public virtual FacebookOAuthResult ParseOAuthCallbackUrl(Uri uri)
		{
			Dictionary<string, object> strs = new Dictionary<string, object>();
			bool flag = false;
			if (!string.IsNullOrEmpty(uri.Fragment))
			{
				string str = uri.Fragment.Substring(1);
				FacebookClient.ParseUrlQueryString(string.Concat("?", str), strs, true);
				if (strs.ContainsKey("access_token"))
				{
					flag = true;
				}
			}
			Dictionary<string, object> strs1 = new Dictionary<string, object>();
			FacebookClient.ParseUrlQueryString(uri.Query, strs1, true);
			if (strs1.ContainsKey("code") || strs1.ContainsKey("error") && strs1.ContainsKey("error_description"))
			{
				flag = true;
			}
			foreach (KeyValuePair<string, object> keyValuePair in strs1)
			{
				strs[keyValuePair.Key] = keyValuePair.Value;
			}
			if (!flag)
			{
				throw new InvalidOperationException("Could not parse Facebook OAuth url.");
			}
			return new FacebookOAuthResult(strs);
		}

		public virtual object ParseSignedRequest(string appSecret, string signedRequestValue)
		{
			if (string.IsNullOrEmpty(appSecret))
			{
				throw new ArgumentNullException("appSecret");
			}
			if (string.IsNullOrEmpty(signedRequestValue))
			{
				throw new ArgumentNullException("signedRequestValue");
			}
			string[] strArrays = signedRequestValue.Split(new char[] { '.' });
			if ((int)strArrays.Length != 2)
			{
				throw new InvalidOperationException("Invalid signed_request");
			}
			string str = strArrays[0];
			string str1 = strArrays[1];
			if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str1))
			{
				throw new InvalidOperationException("Invalid signed_request");
			}
			byte[] numArray = FacebookClient.Base64UrlDecode(str1);
			object deserializeJson = this.DeserializeJson(Encoding.UTF8.GetString(numArray, 0, (int)numArray.Length), null);
			byte[] bytes = Encoding.UTF8.GetBytes(appSecret);
			byte[] numArray1 = FacebookClient.ComputeHmacSha256Hash(Encoding.UTF8.GetBytes(str1), bytes);
			byte[] numArray2 = FacebookClient.Base64UrlDecode(str);
			if ((int)numArray1.Length != (int)numArray2.Length)
			{
				throw new InvalidOperationException("Invalid signed_request");
			}
			bool flag = true;
			for (int i = 0; i < (int)numArray1.Length; i++)
			{
				flag = flag & numArray1[i] == numArray2[i];
			}
			if (!flag)
			{
				throw new InvalidOperationException("Invalid signed_request");
			}
			return deserializeJson;
		}

		public virtual object ParseSignedRequest(string signedRequestValue)
		{
			return this.ParseSignedRequest(this.AppSecret, signedRequestValue);
		}

		private static string ParseUrlQueryString(string path, IDictionary<string, object> parameters, bool forceParseAllUrls, out Uri uri, out bool isLegacyRestApi, out bool isAbsolutePath)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			isLegacyRestApi = false;
			isAbsolutePath = false;
			uri = null;
			if (Uri.TryCreate(path, UriKind.Absolute, out uri))
			{
				isAbsolutePath = true;
				if (!forceParseAllUrls)
				{
					string host = uri.Host;
					string str = host;
					if (host != null)
					{
						switch (str)
						{
							case "graph.facebook.com":
							case "graph-video.facebook.com":
							case "graph.beta.facebook.com":
							case "graph-video.beta.facebook.com":
							{
								path = string.Concat(uri.AbsolutePath, uri.Query);
								goto Label0;
							}
							case "api.facebook.com":
							case "api-read.facebook.com":
							case "api-video.facebook.com":
							case "api.beta.facebook.com":
							case "api-read.beta.facebook.com":
							case "api-video.beta.facebook.com":
							{
								isLegacyRestApi = true;
								path = string.Concat(uri.AbsolutePath, uri.Query);
								goto Label0;
							}
						}
					}
					uri = null;
				}
				else
				{
					path = string.Concat(uri.AbsolutePath, uri.Query);
				}
			}
		Label0:
			if (string.IsNullOrEmpty(path))
			{
				return string.Empty;
			}
			if (path.Length > 0 && path[0] == '/')
			{
				path = path.Substring(1);
			}
			string[] strArrays = path.Split(new char[] { '?' });
			path = strArrays[0];
			if ((int)strArrays.Length == 2 && strArrays[1] != null)
			{
				string str1 = strArrays[1];
				string[] strArrays1 = str1.Split(new char[] { '&' });
				for (int i = 0; i < (int)strArrays1.Length; i++)
				{
					string str2 = strArrays1[i];
					if (!string.IsNullOrEmpty(str2))
					{
						string[] strArrays2 = str2.Split(new char[] { '=' });
						if ((int)strArrays2.Length >= 2)
						{
							if ((int)strArrays2.Length != 2 || string.IsNullOrEmpty(strArrays2[0]))
							{
								throw new ArgumentException("Invalid path", "path");
							}
							string str3 = HttpHelper.UrlDecode(strArrays2[0]);
							if (!parameters.ContainsKey(str3))
							{
								parameters[str3] = HttpHelper.UrlDecode(strArrays2[1]);
							}
						}
					}
				}
			}
			else if ((int)strArrays.Length > 2)
			{
				throw new ArgumentException("Invalid path", "path");
			}
			return path;
		}

		internal static string ParseUrlQueryString(string path, IDictionary<string, object> parameters, bool forceParseAllUrls)
		{
			Uri uri;
			bool flag;
			bool flag1;
			return FacebookClient.ParseUrlQueryString(path, parameters, forceParseAllUrls, out uri, out flag, out flag1);
		}

		public virtual object Post(object parameters)
		{
			return this.Post(null, parameters);
		}

		public virtual object Post(string path, object parameters)
		{
			return this.Api(HttpMethod.Post, path, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use PostTaskAsync instead.")]
		public virtual void PostAsync(object parameters)
		{
			this.PostAsync(null, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use PostTaskAsync instead.")]
		public virtual void PostAsync(string path, object parameters)
		{
			this.PostAsync(path, parameters, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use PostTaskAsync instead.")]
		public virtual void PostAsync(string path, object parameters, object userState)
		{
			this.ApiAsync(HttpMethod.Post, path, parameters, null, userState);
		}

		public virtual Task<object> PostTaskAsync(object parameters)
		{
			return this.PostTaskAsync(null, parameters, CancellationToken.None);
		}

		public virtual Task<object> PostTaskAsync(string path, object parameters)
		{
			return this.PostTaskAsync(path, parameters, CancellationToken.None);
		}

		public virtual Task<object> PostTaskAsync(string path, object parameters, CancellationToken cancellationToken)
		{
			return this.ApiTaskAsync(HttpMethod.Post, path, parameters, null, null, cancellationToken);
		}

		public virtual Task<object> PostTaskAsync(string path, object parameters, object userState, CancellationToken cancellationToken)
		{
			return this.ApiTaskAsync(HttpMethod.Post, path, parameters, null, userState, cancellationToken);
		}

		internal object PrepareBatchRequest(FacebookBatchParameter[] batchParameters, object parameters)
		{
			IDictionary<string, FacebookMediaObject> strs;
			IDictionary<string, FacebookMediaStream> strs1;
			string str;
			if (batchParameters == null)
			{
				throw new ArgumentNullException("batchParameters");
			}
			if ((int)batchParameters.Length == 0)
			{
				throw new ArgumentNullException("batchParameters", "At least one batch parameter is required");
			}
			IDictionary<string, object> value = new Dictionary<string, object>();
			IList<object> objs = new List<object>();
			value["batch"] = objs;
			FacebookBatchParameter[] facebookBatchParameterArray = batchParameters;
			for (int i = 0; i < (int)facebookBatchParameterArray.Length; i++)
			{
				FacebookBatchParameter facebookBatchParameter = facebookBatchParameterArray[i];
				IDictionary<string, object> dictionary = FacebookClient.ToDictionary(facebookBatchParameter.Data, out strs, out strs1);
				if (strs.Count + strs1.Count > 0)
				{
					throw new ArgumentException("Attachments (FacebookMediaObject/FacebookMediaStream) are only allowed in FacebookBatchParameter.Parameters");
				}
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
				}
				if (!dictionary.ContainsKey("method"))
				{
					switch (facebookBatchParameter.HttpMethod)
					{
						case HttpMethod.Get:
						{
							dictionary["method"] = "GET";
							goto Label0;
						}
						case HttpMethod.Post:
						{
							dictionary["method"] = "POST";
							goto Label0;
						}
						case HttpMethod.Delete:
						{
							dictionary["method"] = "DELETE";
							goto Label0;
						}
					}
					throw new ArgumentOutOfRangeException();
				}
			Label0:
				IList<string> strs2 = new List<string>();
				object obj = FacebookClient.ToDictionary(facebookBatchParameter.Parameters, out strs, out strs1);
				if (obj == null)
				{
					obj = new Dictionary<string, object>();
				}
				IDictionary<string, object> strs3 = (IDictionary<string, object>)obj;
				bool flag = false;
				string item = null;
				if (strs3.ContainsKey("_etag_"))
				{
					item = (string)strs3["_etag_"];
					flag = true;
					strs3.Remove("_etag_");
				}
				bool flag1 = false;
				foreach (KeyValuePair<string, FacebookMediaObject> keyValuePair in strs)
				{
					if (flag1)
					{
						throw new ArgumentException("Only one attachement (FacebookMediaObject/FacebookMediaStream) allowed per FacebookBatchParamter.", "batchParameters");
					}
					if (value.ContainsKey(keyValuePair.Key))
					{
						CultureInfo invariantCulture = CultureInfo.InvariantCulture;
						object[] key = new object[] { keyValuePair.Key };
						throw new ArgumentException(string.Format(invariantCulture, "Attachment (FacebookMediaObject/FacebookMediaStream) with key '{0}' already exists", key));
					}
					strs2.Add(HttpHelper.UrlEncode(keyValuePair.Key));
					value.Add(keyValuePair.Key, keyValuePair.Value);
					flag1 = true;
				}
				foreach (KeyValuePair<string, FacebookMediaStream> keyValuePair1 in strs1)
				{
					if (flag1)
					{
						throw new ArgumentException("Only one attachement (FacebookMediaObject/FacebookMediaStream) allowed per FacebookBatchParamter.", "batchParameters");
					}
					if (value.ContainsKey(keyValuePair1.Key))
					{
						CultureInfo cultureInfo = CultureInfo.InvariantCulture;
						object[] objArray = new object[] { keyValuePair1.Key };
						throw new ArgumentException(string.Format(cultureInfo, "Attachment (FacebookMediaObject/FacebookMediaStream) with key '{0}' already exists", objArray));
					}
					strs2.Add(HttpHelper.UrlEncode(keyValuePair1.Key));
					value.Add(keyValuePair1.Key, keyValuePair1.Value);
					flag1 = true;
				}
				if (strs2.Count > 0 && !dictionary.ContainsKey("attached_files"))
				{
					dictionary["attached_files"] = string.Join(",", strs2.ToArray<string>());
				}
				if (dictionary["method"].ToString().Equals("POST", StringComparison.OrdinalIgnoreCase))
				{
					str = FacebookClient.ParseUrlQueryString(facebookBatchParameter.Path, strs3, false);
					this.SerializeParameters(strs3);
					if (!dictionary.ContainsKey("relative_url") && str.Length > 0)
					{
						dictionary["relative_url"] = str;
					}
					if (!dictionary.ContainsKey("body"))
					{
						StringBuilder stringBuilder = new StringBuilder();
						foreach (KeyValuePair<string, object> keyValuePair2 in strs3)
						{
							stringBuilder.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair2.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair2.Value, new Func<string, string>(HttpHelper.UrlEncode))));
						}
						if (stringBuilder.Length > 0)
						{
							StringBuilder length = stringBuilder;
							length.Length = length.Length - 1;
							dictionary["body"] = stringBuilder.ToString();
						}
					}
				}
				else if (!dictionary.ContainsKey("relative_url"))
				{
					str = FacebookClient.ParseUrlQueryString(facebookBatchParameter.Path, strs3, false);
					this.SerializeParameters(strs3);
					StringBuilder stringBuilder1 = new StringBuilder();
					stringBuilder1.Append(str).Append("?");
					foreach (KeyValuePair<string, object> keyValuePair3 in strs3)
					{
						stringBuilder1.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair3.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair3.Value, new Func<string, string>(HttpHelper.UrlEncode))));
					}
					if (stringBuilder1.Length > 0)
					{
						StringBuilder length1 = stringBuilder1;
						length1.Length = length1.Length - 1;
					}
					dictionary["relative_url"] = stringBuilder1.ToString();
				}
				if (flag)
				{
					dictionary["_etag_"] = item;
				}
				objs.Add(dictionary);
			}
			IDictionary<string, object> dictionary1 = FacebookClient.ToDictionary(parameters, out strs, out strs1);
			if (dictionary1 != null)
			{
				foreach (KeyValuePair<string, object> keyValuePair4 in dictionary1)
				{
					value[keyValuePair4.Key] = keyValuePair4.Value;
				}
			}
			foreach (KeyValuePair<string, FacebookMediaObject> keyValuePair5 in strs)
			{
				value[keyValuePair5.Key] = keyValuePair5.Value;
			}
			foreach (KeyValuePair<string, FacebookMediaStream> keyValuePair6 in strs1)
			{
				value[keyValuePair6.Key] = keyValuePair6.Value;
			}
			return value;
		}

		private HttpHelper PrepareRequest(HttpMethod httpMethod, string path, object parameters, Type resultType, out Stream input, out bool containsEtag, out IList<int> batchEtags)
		{
			IDictionary<string, FacebookMediaObject> strs;
			IDictionary<string, FacebookMediaStream> strs1;
			Uri uri;
			bool flag;
			bool flag1;
			UriBuilder uriBuilder;
			int i;
			IDictionary<string, object> item;
			string str;
			Stream memoryStream;
			input = null;
			containsEtag = false;
			batchEtags = null;
			object dictionary = FacebookClient.ToDictionary(parameters, out strs, out strs1);
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, object>();
			}
			IDictionary<string, object> accessToken = (IDictionary<string, object>)dictionary;
			if (!accessToken.ContainsKey("access_token") && !string.IsNullOrEmpty(this.AccessToken))
			{
				accessToken["access_token"] = this.AccessToken;
			}
			if (!accessToken.ContainsKey("return_ssl_resources") && this.IsSecureConnection)
			{
				accessToken["return_ssl_resources"] = true;
			}
			string item1 = null;
			if (accessToken.ContainsKey("_etag_"))
			{
				item1 = (string)accessToken["_etag_"];
				accessToken.Remove("_etag_");
				containsEtag = true;
			}
			path = FacebookClient.ParseUrlQueryString(path, accessToken, false, out uri, out flag, out flag1);
			if (accessToken.ContainsKey("format"))
			{
				accessToken["format"] = "json-strings";
			}
			string str1 = null;
			if (accessToken.ContainsKey("method"))
			{
				str1 = (string)accessToken["method"];
				if (str1.Equals("DELETE", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException("Parameter cannot contain method=delete. Use Delete or DeleteAsync or DeleteTaskAsync methods instead.", "parameters");
				}
				accessToken.Remove("method");
				flag = true;
			}
			else if (flag)
			{
				throw new ArgumentException("Parameters should contain rest 'method' name", "parameters");
			}
			if (uri != null)
			{
				UriBuilder uriBuilder1 = new UriBuilder()
				{
					Host = uri.Host,
					Scheme = uri.Scheme
				};
				uriBuilder = uriBuilder1;
			}
			else
			{
				uriBuilder = new UriBuilder()
				{
					Scheme = "https"
				};
				if (!flag)
				{
					if (accessToken.ContainsKey("batch"))
					{
						if ((!accessToken.ContainsKey("_process_batch_response_") ? true : (bool)accessToken["_process_batch_response_"]))
						{
							batchEtags = new List<int>();
							IList<object> objs = accessToken["batch"] as IList<object>;
							if (objs != null)
							{
								for (i = 0; i < objs.Count; i++)
								{
									item = objs[i] as IDictionary<string, object>;
									if (item != null)
									{
										IDictionary<string, object> item2 = null;
										if (item.ContainsKey("headers"))
										{
											item2 = (IDictionary<string, object>)item["headers"];
										}
										bool flag2 = item.ContainsKey("_etag_");
										if (flag2)
										{
											if (string.IsNullOrEmpty((string)item["_etag_"]))
											{
												goto Label1;
											}
											if (item2 == null)
											{
												item2 = new Dictionary<string, object>();
												item["headers"] = item2;
											}
										}
										if (flag2)
										{
											if (!item2.ContainsKey("If-None-Match"))
											{
												item2["If-None-Match"] = string.Concat('\"', item["_etag_"], '\"');
											}
											item.Remove("_etag_");
											batchEtags.Add(i);
										}
										else if (item2 != null && item2.ContainsKey("If-None-Match"))
										{
											batchEtags.Add(i);
										}
									}
								Label0:
								}
							}
						}
					}
					path = path ?? string.Empty;
					if (httpMethod != HttpMethod.Post || !path.EndsWith("/videos", StringComparison.OrdinalIgnoreCase))
					{
						uriBuilder.Host = (this.UseFacebookBeta ? "graph.beta.facebook.com" : "graph.facebook.com");
					}
					else
					{
						uriBuilder.Host = (this.UseFacebookBeta ? "graph-video.beta.facebook.com" : "graph-video.facebook.com");
					}
				}
				else
				{
					if (string.IsNullOrEmpty(str1))
					{
						throw new InvalidOperationException("Legacy rest api 'method' in parameters is null or empty.");
					}
					path = string.Concat("method/", str1);
					accessToken["format"] = "json-strings";
					if (str1.Equals("video.upload"))
					{
						uriBuilder.Host = (this.UseFacebookBeta ? "api-video.beta.facebook.com" : "api-video.facebook.com");
					}
					else if (!FacebookClient.LegacyRestApiReadOnlyCalls.Contains<string>(str1))
					{
						uriBuilder.Host = (this.UseFacebookBeta ? "api.beta.facebook.com" : "api.facebook.com");
					}
					else
					{
						uriBuilder.Host = (this.UseFacebookBeta ? "api-read.beta.facebook.com" : "api-read.facebook.com");
					}
				}
			}
			if (flag1 || string.IsNullOrEmpty(this.Version))
			{
				uriBuilder.Path = path;
			}
			else
			{
				uriBuilder.Path = string.Concat(this.Version, "/", path);
			}
			string str2 = null;
			long? nullable = null;
			StringBuilder stringBuilder = new StringBuilder();
			this.SerializeParameters(accessToken);
			if (accessToken.ContainsKey("access_token"))
			{
				string item3 = accessToken["access_token"] as string;
				if (!string.IsNullOrEmpty(item3) && item3 != "null")
				{
					stringBuilder.AppendFormat("access_token={0}&", item3);
				}
				accessToken.Remove("access_token");
			}
			if (httpMethod == HttpMethod.Post)
			{
				if (strs.Count != 0 || strs1.Count != 0)
				{
					if (this.Boundary == null)
					{
						long ticks = DateTime.UtcNow.Ticks;
						str = ticks.ToString("x", CultureInfo.InvariantCulture);
					}
					else
					{
						str = this.Boundary();
					}
					string str3 = str;
					str2 = string.Concat("multipart/form-data; boundary=", str3);
					List<Stream> streams = new List<Stream>();
					List<int> nums = new List<int>();
					StringBuilder stringBuilder1 = new StringBuilder();
					foreach (KeyValuePair<string, object> keyValuePair in accessToken)
					{
						stringBuilder1.Append("--").Append(str3).Append("\r\n");
						stringBuilder1.Append("Content-Disposition: form-data; name=\"").Append(keyValuePair.Key).Append("\"");
						stringBuilder1.Append("\r\n").Append("\r\n");
						stringBuilder1.Append(FacebookClient.BuildHttpQuery(keyValuePair.Value, new Func<string, string>(HttpHelper.UrlEncode)));
						stringBuilder1.Append("\r\n");
					}
					nums.Add(streams.Count);
					streams.Add(new MemoryStream(Encoding.UTF8.GetBytes(stringBuilder1.ToString())));
					foreach (KeyValuePair<string, FacebookMediaObject> keyValuePair1 in strs)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						FacebookMediaObject value = keyValuePair1.Value;
						if (value.ContentType == null || value.GetValue() == null || string.IsNullOrEmpty(value.FileName))
						{
							throw new InvalidOperationException("Attachment (FacebookMediaObject/FacebookMediaStream) must have a content type, file name, and value set.");
						}
						stringBuilder2.Append("--").Append(str3).Append("\r\n");
						stringBuilder2.Append("Content-Disposition: form-data; name=\"").Append(keyValuePair1.Key).Append("\"; filename=\"").Append(value.FileName).Append("\"").Append("\r\n");
						stringBuilder2.Append("Content-Type: ").Append(value.ContentType).Append("\r\n").Append("\r\n");
						nums.Add(streams.Count);
						streams.Add(new MemoryStream(Encoding.UTF8.GetBytes(stringBuilder2.ToString())));
						byte[] numArray = value.GetValue();
						if (numArray == null)
						{
							throw new InvalidOperationException("The value of attachment (FacebookMediaObject/FacebookMediaStream) is null.");
						}
						nums.Add(streams.Count);
						streams.Add(new MemoryStream(numArray));
						nums.Add(streams.Count);
						streams.Add(new MemoryStream(Encoding.UTF8.GetBytes("\r\n")));
					}
					foreach (KeyValuePair<string, FacebookMediaStream> keyValuePair2 in strs1)
					{
						StringBuilder stringBuilder3 = new StringBuilder();
						FacebookMediaStream facebookMediaStream = keyValuePair2.Value;
						if (facebookMediaStream.ContentType == null || facebookMediaStream.GetValue() == null || string.IsNullOrEmpty(facebookMediaStream.FileName))
						{
							throw new InvalidOperationException("Attachment (FacebookMediaObject/FacebookMediaStream) must have a content type, file name, and value set.");
						}
						stringBuilder3.Append("--").Append(str3).Append("\r\n");
						stringBuilder3.Append("Content-Disposition: form-data; name=\"").Append(keyValuePair2.Key).Append("\"; filename=\"").Append(facebookMediaStream.FileName).Append("\"").Append("\r\n");
						stringBuilder3.Append("Content-Type: ").Append(facebookMediaStream.ContentType).Append("\r\n").Append("\r\n");
						nums.Add(streams.Count);
						streams.Add(new MemoryStream(Encoding.UTF8.GetBytes(stringBuilder3.ToString())));
						Stream stream = facebookMediaStream.GetValue();
						if (stream == null)
						{
							throw new InvalidOperationException("The value of attachment (FacebookMediaObject/FacebookMediaStream) is null.");
						}
						streams.Add(stream);
						nums.Add(streams.Count);
						streams.Add(new MemoryStream(Encoding.UTF8.GetBytes("\r\n")));
					}
					nums.Add(streams.Count);
					Encoding uTF8 = Encoding.UTF8;
					string[] strArrays = new string[] { "\r\n", "--", str3, "--", "\r\n" };
					streams.Add(new MemoryStream(uTF8.GetBytes(string.Concat(strArrays))));
					input = new CombinationStream(streams, nums);
				}
				else
				{
					str2 = "application/x-www-form-urlencoded";
					StringBuilder stringBuilder4 = new StringBuilder();
					foreach (KeyValuePair<string, object> keyValuePair3 in accessToken)
					{
						stringBuilder4.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair3.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair3.Value, new Func<string, string>(HttpHelper.UrlEncode))));
					}
					if (stringBuilder4.Length > 0)
					{
						StringBuilder length = stringBuilder4;
						length.Length = length.Length - 1;
					}
					if (stringBuilder4.Length == 0)
					{
						memoryStream = null;
					}
					else
					{
						memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringBuilder4.ToString()));
					}
					input = memoryStream;
				}
				nullable = new long?((input == null ? (long)0 : input.Length));
			}
			else
			{
				if (containsEtag && httpMethod != HttpMethod.Get)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object[] objArray = new object[] { "_etag_" };
					throw new ArgumentException(string.Format(invariantCulture, "{0} is only supported for http get method.", objArray), "httpMethod");
				}
				if (strs.Count > 0 && strs1.Count > 0)
				{
					throw new InvalidOperationException("Attachments (FacebookMediaObject/FacebookMediaStream) are valid only in POST requests.");
				}
				foreach (KeyValuePair<string, object> keyValuePair4 in accessToken)
				{
					stringBuilder.AppendFormat("{0}={1}&", HttpHelper.UrlEncode(keyValuePair4.Key), HttpHelper.UrlEncode(FacebookClient.BuildHttpQuery(keyValuePair4.Value, new Func<string, string>(HttpHelper.UrlEncode))));
				}
			}
			if (stringBuilder.Length > 0)
			{
				StringBuilder length1 = stringBuilder;
				length1.Length = length1.Length - 1;
			}
			uriBuilder.Query = stringBuilder.ToString();
			HttpWebRequestWrapper httpWebRequestWrapper = (this.HttpWebRequestFactory == null ? new HttpWebRequestWrapper((HttpWebRequest)WebRequest.Create(uriBuilder.Uri)) : this.HttpWebRequestFactory(uriBuilder.Uri));
			switch (httpMethod)
			{
				case HttpMethod.Get:
				{
					httpWebRequestWrapper.Method = "GET";
					break;
				}
				case HttpMethod.Post:
				{
					httpWebRequestWrapper.Method = "POST";
					break;
				}
				case HttpMethod.Delete:
				{
					httpWebRequestWrapper.Method = "DELETE";
					httpWebRequestWrapper.TrySetContentLength((long)0);
					break;
				}
				default:
				{
					throw new ArgumentOutOfRangeException("httpMethod");
				}
			}
			httpWebRequestWrapper.ContentType = str2;
			if (!string.IsNullOrEmpty(item1))
			{
				httpWebRequestWrapper.Headers[HttpRequestHeader.IfNoneMatch] = string.Concat('\"', item1, '\"');
			}
			httpWebRequestWrapper.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebRequestWrapper.AllowWriteStreamBuffering = false;
			if (nullable.HasValue)
			{
				httpWebRequestWrapper.TrySetContentLength(nullable.Value);
			}
			httpWebRequestWrapper.TrySetUserAgent("Facebook C# SDK");
			return new HttpHelper(httpWebRequestWrapper);
		Label1:
			batchEtags.Add(i);
			item.Remove("_etag_");
			goto Label0;
		}

		internal object ProcessBatchResponse(object result, IList<int> batchEtags)
		{
			if (result == null)
			{
				return null;
			}
			JsonArray jsonArray = new JsonArray();
			IList<object> objs = (IList<object>)result;
			int num = 0;
			foreach (object obj in objs)
			{
				if (obj != null)
				{
					IDictionary<string, object> strs = (IDictionary<string, object>)obj;
					long num1 = Convert.ToInt64(strs["code"], CultureInfo.InvariantCulture);
					object obj1 = null;
					try
					{
						if (batchEtags == null || !batchEtags.Contains(num))
						{
							string item = (string)strs["body"];
							obj1 = this.ProcessResponse(null, item, null, false, null);
						}
						else
						{
							JsonObject jsonObjects = new JsonObject();
							IList<object> item1 = (IList<object>)strs["headers"];
							JsonObject jsonObjects1 = new JsonObject();
							foreach (object obj2 in item1)
							{
								IDictionary<string, object> strs1 = (IDictionary<string, object>)obj2;
								jsonObjects1[(string)strs1["name"]] = strs1["value"];
							}
							jsonObjects["headers"] = jsonObjects1;
							if (num1 != (long)0x130)
							{
								string str = (string)strs["body"];
								object obj3 = this.ProcessResponse(null, str, null, true, null);
								obj1 = obj3;
								jsonObjects["body"] = obj3;
							}
							obj1 = jsonObjects;
						}
						jsonArray.Add(obj1);
					}
					catch (Exception exception)
					{
						jsonArray.Add(exception);
					}
				}
				else
				{
					jsonArray.Add(null);
				}
				num++;
			}
			return jsonArray;
		}

		private object ProcessResponse(HttpHelper httpHelper, string responseString, Type resultType, bool containsEtag, IList<int> batchEtags)
		{
			object obj;
			try
			{
				object deserializeJson = null;
				Exception exception = null;
				if (httpHelper != null)
				{
					HttpWebResponseWrapper httpWebResponse = httpHelper.HttpWebResponse;
					if (httpWebResponse == null)
					{
						throw new InvalidOperationException("Unknown facebook response.");
					}
					if (httpWebResponse.ContentType.Contains("text/javascript") || httpWebResponse.ContentType.Contains("application/json"))
					{
						deserializeJson = this.DeserializeJson(responseString, null);
						exception = FacebookClient.GetException(httpHelper, deserializeJson);
						if (exception == null && resultType != null)
						{
							deserializeJson = this.DeserializeJson(responseString, resultType);
						}
					}
					else
					{
						if (httpWebResponse.StatusCode != HttpStatusCode.OK || !httpWebResponse.ContentType.Contains("text/plain"))
						{
							throw new InvalidOperationException("Unknown facebook response.");
						}
						if (!httpWebResponse.ResponseUri.AbsolutePath.EndsWith("/oauth/access_token"))
						{
							throw new InvalidOperationException("Unknown facebook response.");
						}
						JsonObject jsonObjects = new JsonObject();
						string[] strArrays = responseString.Split(new char[] { '&' });
						for (int i = 0; i < (int)strArrays.Length; i++)
						{
							string str = strArrays[i];
							string[] strArrays1 = str.Split(new char[] { '=' });
							if ((int)strArrays1.Length == 2)
							{
								jsonObjects[strArrays1[0]] = strArrays1[1];
							}
						}
						if (jsonObjects.ContainsKey("expires"))
						{
							jsonObjects["expires"] = Convert.ToInt64(jsonObjects["expires"], CultureInfo.InvariantCulture);
						}
						deserializeJson = this.DeserializeJson(jsonObjects.ToString(), resultType);
						obj = deserializeJson;
						return obj;
					}
				}
				else
				{
					deserializeJson = this.DeserializeJson(responseString, resultType);
				}
				if (exception != null)
				{
					throw exception;
				}
				if (!containsEtag || httpHelper == null)
				{
					obj = (batchEtags == null ? deserializeJson : this.ProcessBatchResponse(deserializeJson, batchEtags));
				}
				else
				{
					JsonObject jsonObjects1 = new JsonObject();
					HttpWebResponseWrapper httpWebResponseWrapper = httpHelper.HttpWebResponse;
					JsonObject item = new JsonObject();
					string[] allKeys = httpWebResponseWrapper.Headers.AllKeys;
					for (int j = 0; j < (int)allKeys.Length; j++)
					{
						string str1 = allKeys[j];
						item[str1] = httpWebResponseWrapper.Headers[str1];
					}
					jsonObjects1["headers"] = item;
					jsonObjects1["body"] = deserializeJson;
					obj = jsonObjects1;
				}
			}
			catch (FacebookApiException facebookApiException)
			{
				throw;
			}
			catch (Exception exception1)
			{
				if (httpHelper != null && httpHelper.InnerException != null)
				{
					throw httpHelper.InnerException;
				}
				throw;
			}
			return obj;
		}

		private void RemoveTaskAsyncHandlers(HttpMethod httpMethod, EventHandler<FacebookApiEventArgs> handler)
		{
			switch (httpMethod)
			{
				case HttpMethod.Get:
				{
					this.GetCompleted -= handler;
					return;
				}
				case HttpMethod.Post:
				{
					this.PostCompleted -= handler;
					return;
				}
				case HttpMethod.Delete:
				{
					this.DeleteCompleted -= handler;
					return;
				}
				default:
				{
					return;
				}
			}
		}

		private void SerializeParameters(IDictionary<string, object> parameters)
		{
			List<string> strs = new List<string>();
			foreach (string key in parameters.Keys)
			{
				if (parameters[key] is string)
				{
					continue;
				}
				strs.Add(key);
			}
			foreach (string str in strs)
			{
				parameters[str] = this.SerializeJson(parameters[str]);
			}
		}

		public static void SetDefaultHttpWebRequestFactory(Func<Uri, HttpWebRequestWrapper> httpWebRequestFactory)
		{
			FacebookClient._defaultHttpWebRequestFactory = httpWebRequestFactory;
		}

		public static void SetDefaultJsonSerializers(Func<object, string> jsonSerializer, Func<string, Type, object> jsonDeserializer)
		{
			FacebookClient._defaultJsonSerializer = jsonSerializer ?? new Func<object, string>(SimpleJson.SerializeObject);
			FacebookClient._defaultJsonDeserializer = jsonDeserializer ?? new Func<string, Type, object>(SimpleJson.DeserializeObject);
		}

		public virtual void SetHttpWebRequestFactory(Func<Uri, HttpWebRequestWrapper> httpWebRequestFactory)
		{
			this.HttpWebRequestFactory = httpWebRequestFactory;
		}

		public virtual void SetJsonSerializers(Func<object, string> jsonSerializer, Func<string, Type, object> jsonDeserializer)
		{
			this.SerializeJson = jsonSerializer;
			this.DeserializeJson = jsonDeserializer;
		}

		private static IDictionary<string, object> ToDictionary(object parameters, out IDictionary<string, FacebookMediaObject> mediaObjects, out IDictionary<string, FacebookMediaStream> mediaStreams)
		{
			mediaObjects = new Dictionary<string, FacebookMediaObject>();
			mediaStreams = new Dictionary<string, FacebookMediaStream>();
			IDictionary<string, object> strs = parameters as IDictionary<string, object>;
			if (strs == null)
			{
				if (parameters == null)
				{
					return null;
				}
				strs = new Dictionary<string, object>();
				PropertyInfo[] properties = parameters.GetType().GetProperties();
				for (int i = 0; i < (int)properties.Length; i++)
				{
					PropertyInfo propertyInfo = properties[i];
					if (propertyInfo.CanRead)
					{
						strs[propertyInfo.Name] = propertyInfo.GetValue(parameters, null);
					}
				}
			}
			foreach (KeyValuePair<string, object> str in strs)
			{
				if (!(str.Value is FacebookMediaObject))
				{
					if (!(str.Value is FacebookMediaStream))
					{
						continue;
					}
					mediaStreams.Add(str.Key, (FacebookMediaStream)str.Value);
				}
				else
				{
					mediaObjects.Add(str.Key, (FacebookMediaObject)str.Value);
				}
			}
			foreach (KeyValuePair<string, FacebookMediaObject> mediaObject in mediaObjects)
			{
				strs.Remove(mediaObject.Key);
			}
			foreach (KeyValuePair<string, FacebookMediaStream> mediaStream in mediaStreams)
			{
				strs.Remove(mediaStream.Key);
			}
			return strs;
		}

		private static void TransferCompletionToTask<T>(TaskCompletionSource<T> tcs, AsyncCompletedEventArgs e, Func<T> getResult, Action unregisterHandler)
		{
			if (e.UserState != tcs)
			{
				return;
			}
			try
			{
				unregisterHandler();
			}
			finally
			{
				if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else if (e.Error == null)
				{
					tcs.TrySetResult(getResult());
				}
				else
				{
					tcs.TrySetException(e.Error);
				}
			}
		}

		public virtual bool TryParseOAuthCallbackUrl(Uri url, out FacebookOAuthResult facebookOAuthResult)
		{
			bool flag;
			facebookOAuthResult = null;
			try
			{
				facebookOAuthResult = this.ParseOAuthCallbackUrl(url);
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public virtual bool TryParseSignedRequest(string appSecret, string signedRequestValue, out object signedRequest)
		{
			bool flag;
			signedRequest = null;
			try
			{
				signedRequest = this.ParseSignedRequest(appSecret, signedRequestValue);
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public virtual bool TryParseSignedRequest(string signedRequestValue, out object signedRequest)
		{
			return this.TryParseSignedRequest(this.AppSecret, signedRequestValue, out signedRequest);
		}

		public virtual void VerifyGetSubscription(string requestHubMode, string requestVerifyToken, string requestHubChallenge, string verifyToken)
		{
			if (string.IsNullOrEmpty(verifyToken))
			{
				throw new ArgumentNullException("verifyToken");
			}
			if (requestHubMode != "subscribe")
			{
				throw new ArgumentException("Invalid hub.mode", "requestHubMode");
			}
			if (requestVerifyToken != verifyToken)
			{
				throw new ArgumentException("Invalid hub.verify_token", requestVerifyToken);
			}
			if (string.IsNullOrEmpty(requestHubChallenge))
			{
				throw new ArgumentException("Invalid hub.challenge", "requestHubChallenge");
			}
		}

		public virtual void VerifyGetSubscription(string requestHubMode, string requestVerifyToken, string requestHubChallenge)
		{
			this.VerifyGetSubscription(requestHubMode, requestVerifyToken, requestHubChallenge, this.SubscriptionVerifyToken);
		}

		public virtual object VerifyPostSubscription(string requestHttpXHubSignature, string requestBody, Type resultType, string appSecret)
		{
			if (string.IsNullOrEmpty(appSecret))
			{
				throw new ArgumentNullException("appSecret");
			}
			if (string.IsNullOrEmpty(requestHttpXHubSignature) || !requestHttpXHubSignature.StartsWith("sha1="))
			{
				throw new ArgumentException("Invalid X-Hub-Signature request header", requestHttpXHubSignature);
			}
			string str = requestHttpXHubSignature.Substring(5);
			if (string.IsNullOrEmpty(str))
			{
				throw new ArgumentException("Invalid X-Hub-Signature request header", requestHttpXHubSignature);
			}
			if (string.IsNullOrEmpty(requestBody))
			{
				throw new ArgumentException(requestBody, "requestBody");
			}
			byte[] numArray = FacebookClient.ComputeHmacSha1Hash(Encoding.UTF8.GetBytes(requestBody), Encoding.UTF8.GetBytes(appSecret));
			StringBuilder stringBuilder = new StringBuilder();
			byte[] numArray1 = numArray;
			for (int i = 0; i < (int)numArray1.Length; i++)
			{
				byte num = numArray1[i];
				stringBuilder.Append(num.ToString("x2"));
			}
			if (str != stringBuilder.ToString())
			{
				throw new ArgumentException("Invalid X-Hub-Signature request header", "requestHttpXHubSignature");
			}
			return this.DeserializeJson(requestBody, resultType);
		}

		public object VerifyPostSubscription(string requestHttpXHubSignature, string requestBody, Type resultType)
		{
			return this.VerifyPostSubscription(requestHttpXHubSignature, requestBody, resultType, this.AppSecret);
		}

		public object VerifyPostSubscription(string requestHttpXHubSignature, string requestBody)
		{
			return this.VerifyPostSubscription(requestHttpXHubSignature, requestBody, null, this.AppSecret);
		}

		public virtual object VerifyPostSubscription(string requestHttpXHubSignature, string requestBody, string appSecret)
		{
			return this.VerifyPostSubscription(requestHttpXHubSignature, requestBody, null, appSecret);
		}

		public event EventHandler<FacebookApiEventArgs> DeleteCompleted;

		public event EventHandler<FacebookApiEventArgs> GetCompleted;

		private event EventHandler<HttpWebRequestCreatedEventArgs> HttpWebRequestWrapperCreated;

		public event EventHandler<FacebookApiEventArgs> PostCompleted;

		public event EventHandler<FacebookUploadProgressChangedEventArgs> UploadProgressChanged;
	}
}