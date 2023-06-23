using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook
{
	internal class HttpHelper
	{
		private const string ErrorPerformingHttpRequest = "An error occurred performing a http web request.";

		private readonly HttpWebRequestWrapper _httpWebRequest;

		private HttpWebResponseWrapper _httpWebResponse;

		private Exception _innerException;

		private readonly static CultureInfo InvariantCulture;

		private static object entitiesLock;

		private static SortedDictionary<string, char> entities;

		private static IDictionary<string, char> Entities
		{
			get
			{
				IDictionary<string, char> strs;
				lock (HttpHelper.entitiesLock)
				{
					if (HttpHelper.entities == null)
					{
						HttpHelper.InitEntities();
					}
					strs = HttpHelper.entities;
				}
				return strs;
			}
		}

		public HttpWebRequestWrapper HttpWebRequest
		{
			get
			{
				return this._httpWebRequest;
			}
		}

		public HttpWebResponseWrapper HttpWebResponse
		{
			get
			{
				return this._httpWebResponse;
			}
		}

		public Exception InnerException
		{
			get
			{
				return this._innerException;
			}
		}

		public int Timeout
		{
			get;
			set;
		}

		static HttpHelper()
		{
			HttpHelper.InvariantCulture = CultureInfo.InvariantCulture;
			HttpHelper.entitiesLock = new object();
		}

		public HttpHelper(Uri url) : this(new HttpWebRequestWrapper((System.Net.HttpWebRequest)WebRequest.Create(url)))
		{
		}

		public HttpHelper(string url) : this(new Uri(url))
		{
		}

		public HttpHelper(HttpWebRequestWrapper httpWebRequest)
		{
			this._httpWebRequest = httpWebRequest;
		}

		public void CancelAsync()
		{
			try
			{
				this.HttpWebRequest.Abort();
			}
			catch (WebExceptionWrapper webExceptionWrapper)
			{
				throw;
			}
			catch (WebException webException)
			{
				throw new WebExceptionWrapper(webException);
			}
			catch (Exception exception)
			{
				throw new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
			}
		}

		private static int GetChar(string str, int offset, int length)
		{
			int num = 0;
			int num1 = length + offset;
			for (int i = offset; i < num1; i++)
			{
				char chr = str[i];
				if (chr > '\u007F')
				{
					return -1;
				}
				int num2 = HttpHelper.GetInt((byte)chr);
				if (num2 == -1)
				{
					return -1;
				}
				num = (num << 4) + num2;
			}
			return num;
		}

		private static int GetInt(byte b)
		{
			char chr = (char)b;
			if (chr >= '0' && chr <= '9')
			{
				return chr - 48;
			}
			if (chr >= 'a' && chr <= 'f')
			{
				return chr - 97 + 10;
			}
			if (chr < 'A' || chr > 'F')
			{
				return -1;
			}
			return chr - 65 + 10;
		}

		public static string HtmlDecode(string s)
		{
			if (s == null)
			{
				return null;
			}
			if (s.Length == 0)
			{
				return string.Empty;
			}
			if (s.IndexOf('&') == -1)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder1 = new StringBuilder();
			int length = s.Length;
			int num = 0;
			int num1 = 0;
			bool flag = false;
			bool flag1 = false;
			for (int i = 0; i < length; i++)
			{
				char chr = s[i];
				if (num == 0)
				{
					if (chr != '&')
					{
						stringBuilder1.Append(chr);
					}
					else
					{
						stringBuilder.Append(chr);
						num = 1;
					}
				}
				else if (chr == '&')
				{
					num = 1;
					if (flag1)
					{
						stringBuilder.Append(num1.ToString(HttpHelper.InvariantCulture));
						flag1 = false;
					}
					stringBuilder1.Append(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append('&');
				}
				else if (num == 1)
				{
					if (chr != ';')
					{
						num1 = 0;
						flag = false;
						num = (chr == '#' ? 3 : 2);
						stringBuilder.Append(chr);
					}
					else
					{
						num = 0;
						stringBuilder1.Append(stringBuilder.ToString());
						stringBuilder1.Append(chr);
						stringBuilder.Length = 0;
					}
				}
				else if (num == 2)
				{
					stringBuilder.Append(chr);
					if (chr == ';')
					{
						string str = stringBuilder.ToString();
						if (str.Length > 1 && HttpHelper.Entities.ContainsKey(str.Substring(1, str.Length - 2)))
						{
							char item = HttpHelper.Entities[str.Substring(1, str.Length - 2)];
							str = item.ToString();
						}
						stringBuilder1.Append(str);
						num = 0;
						stringBuilder.Length = 0;
					}
				}
				else if (num == 3)
				{
					if (chr == ';')
					{
						if (num1 <= 0xffff)
						{
							stringBuilder1.Append((char)num1);
						}
						else
						{
							stringBuilder1.Append("&#");
							stringBuilder1.Append(num1.ToString(HttpHelper.InvariantCulture));
							stringBuilder1.Append(";");
						}
						num = 0;
						stringBuilder.Length = 0;
						flag1 = false;
					}
					else if (flag && Uri.IsHexDigit(chr))
					{
						num1 = num1 * 16 + Uri.FromHex(chr);
						flag1 = true;
					}
					else if (char.IsDigit(chr))
					{
						num1 = num1 * 10 + (chr - 48);
						flag1 = true;
					}
					else if (num1 != 0 || chr != 'x' && chr != 'X')
					{
						num = 2;
						if (flag1)
						{
							stringBuilder.Append(num1.ToString(HttpHelper.InvariantCulture));
							flag1 = false;
						}
						stringBuilder.Append(chr);
					}
					else
					{
						flag = true;
					}
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder1.Append(stringBuilder.ToString());
			}
			else if (flag1)
			{
				stringBuilder1.Append(num1.ToString(HttpHelper.InvariantCulture));
			}
			return stringBuilder1.ToString();
		}

		private static void InitEntities()
		{
			HttpHelper.entities = new SortedDictionary<string, char>(StringComparer.Ordinal)
			{
				{ "nbsp", '\u00A0' },
				{ "iexcl", '¡' },
				{ "cent", '¢' },
				{ "pound", '£' },
				{ "curren", '¤' },
				{ "yen", '¥' },
				{ "brvbar", '\u00A6' },
				{ "sect", '\u00A7' },
				{ "uml", '\u00A8' },
				{ "copy", '\u00A9' },
				{ "ordf", 'ª' },
				{ "laquo", '«' },
				{ "not", '¬' },
				{ "shy", '­' },
				{ "reg", '\u00AE' },
				{ "macr", '\u00AF' },
				{ "deg", '\u00B0' },
				{ "plusmn", '±' },
				{ "sup2", '\u00B2' },
				{ "sup3", '\u00B3' },
				{ "acute", '\u00B4' },
				{ "micro", 'µ' },
				{ "para", '\u00B6' },
				{ "middot", '·' },
				{ "cedil", '\u00B8' },
				{ "sup1", '\u00B9' },
				{ "ordm", 'º' },
				{ "raquo", '»' },
				{ "frac14", '\u00BC' },
				{ "frac12", '\u00BD' },
				{ "frac34", '\u00BE' },
				{ "iquest", '¿' },
				{ "Agrave", 'À' },
				{ "Aacute", 'Á' },
				{ "Acirc", 'Â' },
				{ "Atilde", 'Ã' },
				{ "Auml", 'Ä' },
				{ "Aring", 'Å' },
				{ "AElig", 'Æ' },
				{ "Ccedil", 'Ç' },
				{ "Egrave", 'È' },
				{ "Eacute", 'É' },
				{ "Ecirc", 'Ê' },
				{ "Euml", 'Ë' },
				{ "Igrave", 'Ì' },
				{ "Iacute", 'Í' },
				{ "Icirc", 'Î' },
				{ "Iuml", 'Ï' },
				{ "ETH", 'Ð' },
				{ "Ntilde", 'Ñ' },
				{ "Ograve", 'Ò' },
				{ "Oacute", 'Ó' },
				{ "Ocirc", 'Ô' },
				{ "Otilde", 'Õ' },
				{ "Ouml", 'Ö' },
				{ "times", '×' },
				{ "Oslash", 'Ø' },
				{ "Ugrave", 'Ù' },
				{ "Uacute", 'Ú' },
				{ "Ucirc", 'Û' },
				{ "Uuml", 'Ü' },
				{ "Yacute", 'Ý' },
				{ "THORN", 'Þ' },
				{ "szlig", 'ß' },
				{ "agrave", 'à' },
				{ "aacute", 'á' },
				{ "acirc", 'â' },
				{ "atilde", 'ã' },
				{ "auml", 'ä' },
				{ "aring", 'å' },
				{ "aelig", 'æ' },
				{ "ccedil", 'ç' },
				{ "egrave", 'è' },
				{ "eacute", 'é' },
				{ "ecirc", 'ê' },
				{ "euml", 'ë' },
				{ "igrave", 'ì' },
				{ "iacute", 'í' },
				{ "icirc", 'î' },
				{ "iuml", 'ï' },
				{ "eth", 'ð' },
				{ "ntilde", 'ñ' },
				{ "ograve", 'ò' },
				{ "oacute", 'ó' },
				{ "ocirc", 'ô' },
				{ "otilde", 'õ' },
				{ "ouml", 'ö' },
				{ "divide", '÷' },
				{ "oslash", 'ø' },
				{ "ugrave", 'ù' },
				{ "uacute", 'ú' },
				{ "ucirc", 'û' },
				{ "uuml", 'ü' },
				{ "yacute", 'ý' },
				{ "thorn", 'þ' },
				{ "yuml", 'ÿ' },
				{ "fnof", 'ƒ' },
				{ "Alpha", 'Α' },
				{ "Beta", 'Β' },
				{ "Gamma", 'Γ' },
				{ "Delta", 'Δ' },
				{ "Epsilon", 'Ε' },
				{ "Zeta", 'Ζ' },
				{ "Eta", 'Η' },
				{ "Theta", 'Θ' },
				{ "Iota", 'Ι' },
				{ "Kappa", 'Κ' },
				{ "Lambda", 'Λ' },
				{ "Mu", 'Μ' },
				{ "Nu", 'Ν' },
				{ "Xi", 'Ξ' },
				{ "Omicron", 'Ο' },
				{ "Pi", 'Π' },
				{ "Rho", 'Ρ' },
				{ "Sigma", 'Σ' },
				{ "Tau", 'Τ' },
				{ "Upsilon", 'Υ' },
				{ "Phi", 'Φ' },
				{ "Chi", 'Χ' },
				{ "Psi", 'Ψ' },
				{ "Omega", 'Ω' },
				{ "alpha", 'α' },
				{ "beta", 'β' },
				{ "gamma", 'γ' },
				{ "delta", 'δ' },
				{ "epsilon", 'ε' },
				{ "zeta", 'ζ' },
				{ "eta", 'η' },
				{ "theta", 'θ' },
				{ "iota", 'ι' },
				{ "kappa", 'κ' },
				{ "lambda", 'λ' },
				{ "mu", 'μ' },
				{ "nu", 'ν' },
				{ "xi", 'ξ' },
				{ "omicron", 'ο' },
				{ "pi", 'π' },
				{ "rho", 'ρ' },
				{ "sigmaf", 'ς' },
				{ "sigma", 'σ' },
				{ "tau", 'τ' },
				{ "upsilon", 'υ' },
				{ "phi", 'φ' },
				{ "chi", 'χ' },
				{ "psi", 'ψ' },
				{ "omega", 'ω' },
				{ "thetasym", 'ϑ' },
				{ "upsih", 'ϒ' },
				{ "piv", 'ϖ' },
				{ "bull", '•' },
				{ "hellip", '…' },
				{ "prime", '′' },
				{ "Prime", '″' },
				{ "oline", '‾' },
				{ "frasl", '⁄' },
				{ "weierp", '℘' },
				{ "image", 'ℑ' },
				{ "real", 'ℜ' },
				{ "trade", '\u2122' },
				{ "alefsym", '\u2135' },
				{ "larr", '←' },
				{ "uarr", '↑' },
				{ "rarr", '→' },
				{ "darr", '↓' },
				{ "harr", '↔' },
				{ "crarr", '\u21B5' },
				{ "lArr", '\u21D0' },
				{ "uArr", '\u21D1' },
				{ "rArr", '⇒' },
				{ "dArr", '\u21D3' },
				{ "hArr", '⇔' },
				{ "forall", '∀' },
				{ "part", '∂' },
				{ "exist", '∃' },
				{ "empty", '∅' },
				{ "nabla", '∇' },
				{ "isin", '∈' },
				{ "notin", '∉' },
				{ "ni", '∋' },
				{ "prod", '∏' },
				{ "sum", '∑' },
				{ "minus", '−' },
				{ "lowast", '∗' },
				{ "radic", '√' },
				{ "prop", '∝' },
				{ "infin", '∞' },
				{ "ang", '∠' },
				{ "and", '∧' },
				{ "or", '∨' },
				{ "cap", '∩' },
				{ "cup", '∪' },
				{ "int", '∫' },
				{ "there4", '∴' },
				{ "sim", '∼' },
				{ "cong", '≅' },
				{ "asymp", '≈' },
				{ "ne", '≠' },
				{ "equiv", '≡' },
				{ "le", '≤' },
				{ "ge", '≥' },
				{ "sub", '⊂' },
				{ "sup", '⊃' },
				{ "nsub", '⊄' },
				{ "sube", '⊆' },
				{ "supe", '⊇' },
				{ "oplus", '⊕' },
				{ "otimes", '⊗' },
				{ "perp", '⊥' },
				{ "sdot", '⋅' },
				{ "lceil", '⌈' },
				{ "rceil", '⌉' },
				{ "lfloor", '⌊' },
				{ "rfloor", '⌋' },
				{ "lang", '〈' },
				{ "rang", '〉' },
				{ "loz", '\u25CA' },
				{ "spades", '\u2660' },
				{ "clubs", '\u2663' },
				{ "hearts", '\u2665' },
				{ "diams", '\u2666' },
				{ "quot", '\"' },
				{ "amp", '&' },
				{ "lt", '<' },
				{ "gt", '>' },
				{ "OElig", 'Œ' },
				{ "oelig", 'œ' },
				{ "Scaron", 'Š' },
				{ "scaron", 'š' },
				{ "Yuml", 'Ÿ' },
				{ "circ", '\u02C6' },
				{ "tilde", '\u02DC' },
				{ "ensp", '\u2002' },
				{ "emsp", '\u2003' },
				{ "thinsp", '\u2009' },
				{ "zwnj", '\u200C' },
				{ "zwj", '\u200D' },
				{ "lrm", '\u200E' },
				{ "rlm", '\u200F' },
				{ "ndash", '–' },
				{ "mdash", '—' },
				{ "lsquo", '‘' },
				{ "rsquo", '’' },
				{ "sbquo", '‚' },
				{ "ldquo", '“' },
				{ "rdquo", '”' },
				{ "bdquo", '„' },
				{ "dagger", '†' },
				{ "Dagger", '‡' },
				{ "permil", '‰' },
				{ "lsaquo", '‹' },
				{ "rsaquo", '›' },
				{ "euro", '€' }
			};
		}

		protected virtual void OnOpenReadCompleted(Facebook.OpenReadCompletedEventArgs args)
		{
			if (this.OpenReadCompleted != null)
			{
				this.OpenReadCompleted(this, args);
			}
		}

		protected virtual void OnOpenWriteCompleted(Facebook.OpenWriteCompletedEventArgs args)
		{
			if (this.OpenWriteCompleted != null)
			{
				this.OpenWriteCompleted(this, args);
			}
		}

		public virtual Stream OpenRead()
		{
			Stream responseStream;
			try
			{
				if (this._httpWebResponse == null)
				{
					this._httpWebResponse = this._httpWebRequest.GetResponse();
				}
				responseStream = this._httpWebResponse.GetResponseStream();
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				if (webException.Response != null)
				{
					this._httpWebResponse = new HttpWebResponseWrapper((System.Net.HttpWebResponse)webException.Response);
				}
				this._innerException = new WebExceptionWrapper(webException);
				throw this._innerException;
			}
			catch (WebExceptionWrapper webExceptionWrapper1)
			{
				WebExceptionWrapper webExceptionWrapper = webExceptionWrapper1;
				this._httpWebResponse = webExceptionWrapper.GetResponse();
				this._innerException = webExceptionWrapper;
				throw this._innerException;
			}
			catch (Exception exception)
			{
				this._innerException = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
				throw this._innerException;
			}
			return responseStream;
		}

		public virtual void OpenReadAsync(object userToken)
		{
			if (this._httpWebResponse != null)
			{
				this.ResponseCallback(null, userToken);
			}
			else
			{
				WebExceptionWrapper webExceptionWrapper = null;
				try
				{
					try
					{
						IAsyncResult asyncResult = this._httpWebRequest.BeginGetResponse((IAsyncResult ar) => this.ResponseCallback(ar, userToken), null);
						int timeout = 0;
						if (this.HttpWebRequest.Timeout > 0)
						{
							timeout = this.HttpWebRequest.Timeout;
						}
						if (this.Timeout > 0)
						{
							timeout = this.Timeout;
						}
						if (timeout > 0)
						{
							ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, new WaitOrTimerCallback(this.ScanTimoutCallback), userToken, timeout, true);
						}
					}
					catch (WebException webException1)
					{
						WebException webException = webException1;
						if (webException.Response != null)
						{
							this._httpWebResponse = new HttpWebResponseWrapper((System.Net.HttpWebResponse)webException.Response);
						}
						webExceptionWrapper = new WebExceptionWrapper(webException);
						this._innerException = webExceptionWrapper;
					}
					catch (WebExceptionWrapper webExceptionWrapper2)
					{
						WebExceptionWrapper webExceptionWrapper1 = webExceptionWrapper2;
						this._httpWebResponse = webExceptionWrapper1.GetResponse();
						webExceptionWrapper = webExceptionWrapper1;
						this._innerException = webExceptionWrapper;
					}
					catch (Exception exception)
					{
						webExceptionWrapper = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
						this._innerException = webExceptionWrapper;
					}
				}
				finally
				{
					if (webExceptionWrapper != null)
					{
						this.OnOpenReadCompleted(new Facebook.OpenReadCompletedEventArgs(null, webExceptionWrapper, webExceptionWrapper.Status == WebExceptionStatus.RequestCanceled, userToken));
					}
				}
			}
		}

		public virtual void OpenReadAsync()
		{
			this.OpenReadAsync(null);
		}

		public virtual Task<Stream> OpenReadTaskAsync(CancellationToken cancellationToken)
		{
			TaskCompletionSource<Stream> taskCompletionSource = new TaskCompletionSource<Stream>(this);
			cancellationToken.Register(() => {
				try
				{
					this.CancelAsync();
				}
				catch (WebExceptionWrapper webExceptionWrapper)
				{
					if (webExceptionWrapper.Status != WebExceptionStatus.RequestCanceled)
					{
						throw;
					}
				}
			});
			Facebook.OpenReadCompletedEventHandler task = null;
			task = (object sender, Facebook.OpenReadCompletedEventArgs e) => HttpHelper.TransferCompletionToTask<Stream>(this.tcs, e, () => e.Result, () => {
				this.ctr.Dispose();
				this.u003cu003e4__this.OpenReadCompleted -= this.handler;
			});
			this.OpenReadCompleted += task;
			try
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					this.OpenReadAsync(taskCompletionSource);
					if (cancellationToken.IsCancellationRequested)
					{
						taskCompletionSource.TrySetCanceled();
					}
				}
				else
				{
					taskCompletionSource.TrySetCanceled();
				}
			}
			catch
			{
				this.OpenReadCompleted -= task;
				throw;
			}
			return taskCompletionSource.Task;
		}

		public virtual Task<Stream> OpenReadTaskAsync()
		{
			return this.OpenReadTaskAsync(CancellationToken.None);
		}

		public virtual Stream OpenWrite()
		{
			Stream requestStream;
			try
			{
				requestStream = this._httpWebRequest.GetRequestStream();
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				if (webException.Response != null)
				{
					this._httpWebResponse = new HttpWebResponseWrapper((System.Net.HttpWebResponse)webException.Response);
				}
				this._innerException = webException;
				throw new WebExceptionWrapper(webException);
			}
			catch (WebExceptionWrapper webExceptionWrapper1)
			{
				WebExceptionWrapper webExceptionWrapper = webExceptionWrapper1;
				this._httpWebResponse = webExceptionWrapper.GetResponse();
				this._innerException = webExceptionWrapper;
				throw;
			}
			catch (Exception exception)
			{
				this._innerException = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
				throw this._innerException;
			}
			return requestStream;
		}

		public virtual void OpenWriteAsync(object userToken)
		{
			WebExceptionWrapper webExceptionWrapper3 = null;
			try
			{
				try
				{
					this._httpWebRequest.BeginGetRequestStream((IAsyncResult ar) => {
						Stream stream = null;
						WebExceptionWrapper webExceptionWrapper = null;
						try
						{
							stream = this._httpWebRequest.EndGetRequestStream(ar);
						}
						catch (WebException webException1)
						{
							WebException webException = webException1;
							if (webException.Response != null)
							{
								this._httpWebResponse = new HttpWebResponseWrapper((System.Net.HttpWebResponse)webException.Response);
							}
							webExceptionWrapper = new WebExceptionWrapper(webException);
							this._innerException = webException;
						}
						catch (WebExceptionWrapper webExceptionWrapper2)
						{
							WebExceptionWrapper webExceptionWrapper1 = webExceptionWrapper2;
							this._httpWebResponse = webExceptionWrapper1.GetResponse();
							webExceptionWrapper = webExceptionWrapper1;
							this._innerException = webExceptionWrapper1;
						}
						catch (Exception exception)
						{
							webExceptionWrapper = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
							this._innerException = webExceptionWrapper;
						}
						this.OnOpenWriteCompleted(new Facebook.OpenWriteCompletedEventArgs(stream, webExceptionWrapper, (webExceptionWrapper == null ? false : webExceptionWrapper.Status == WebExceptionStatus.RequestCanceled), userToken));
					}, userToken);
				}
				catch (WebException webException3)
				{
					WebException webException2 = webException3;
					webExceptionWrapper3 = new WebExceptionWrapper(webException2);
					this._innerException = webException2;
				}
				catch (WebExceptionWrapper webExceptionWrapper5)
				{
					WebExceptionWrapper webExceptionWrapper4 = webExceptionWrapper5;
					webExceptionWrapper3 = webExceptionWrapper4;
					this._innerException = webExceptionWrapper4;
				}
				catch (Exception exception1)
				{
					webExceptionWrapper3 = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception1));
					this._innerException = webExceptionWrapper3;
				}
			}
			finally
			{
				if (webExceptionWrapper3 != null)
				{
					this.OnOpenWriteCompleted(new Facebook.OpenWriteCompletedEventArgs(null, webExceptionWrapper3, webExceptionWrapper3.Status == WebExceptionStatus.RequestCanceled, userToken));
				}
			}
		}

		public virtual void OpenWriteAsync()
		{
			this.OpenWriteAsync(null);
		}

		public virtual Task<Stream> OpenWriteTaskAsync()
		{
			return this.OpenWriteTaskAsync(CancellationToken.None);
		}

		public virtual Task<Stream> OpenWriteTaskAsync(CancellationToken cancellationToken)
		{
			TaskCompletionSource<Stream> taskCompletionSource = new TaskCompletionSource<Stream>(this);
			cancellationToken.Register(() => {
				try
				{
					this.CancelAsync();
				}
				catch (WebExceptionWrapper webExceptionWrapper)
				{
					if (webExceptionWrapper.Status != WebExceptionStatus.RequestCanceled)
					{
						throw;
					}
				}
			});
			Facebook.OpenWriteCompletedEventHandler task = null;
			task = (object sender, Facebook.OpenWriteCompletedEventArgs e) => HttpHelper.TransferCompletionToTask<Stream>(this.tcs, e, () => e.Result, () => {
				this.ctr.Dispose();
				this.u003cu003e4__this.OpenWriteCompleted -= this.handler;
			});
			this.OpenWriteCompleted += task;
			try
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					this.OpenWriteAsync(taskCompletionSource);
					if (cancellationToken.IsCancellationRequested)
					{
						taskCompletionSource.TrySetCanceled();
					}
				}
				else
				{
					taskCompletionSource.TrySetCanceled();
				}
			}
			catch
			{
				this.OpenWriteCompleted -= task;
				throw;
			}
			return taskCompletionSource.Task;
		}

		private void ResponseCallback(IAsyncResult asyncResult, object userToken)
		{
			WebExceptionWrapper webExceptionWrapper = null;
			Stream responseStream = null;
			try
			{
				if (this._httpWebResponse == null)
				{
					this._httpWebResponse = this._httpWebRequest.EndGetResponse(asyncResult);
				}
				responseStream = this._httpWebResponse.GetResponseStream();
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				if (webException.Response != null)
				{
					this._httpWebResponse = new HttpWebResponseWrapper((System.Net.HttpWebResponse)webException.Response);
				}
				webExceptionWrapper = new WebExceptionWrapper(webException);
				this._innerException = webExceptionWrapper;
			}
			catch (WebExceptionWrapper webExceptionWrapper2)
			{
				WebExceptionWrapper webExceptionWrapper1 = webExceptionWrapper2;
				this._httpWebResponse = webExceptionWrapper1.GetResponse();
				webExceptionWrapper = webExceptionWrapper1;
				this._innerException = webExceptionWrapper;
			}
			catch (Exception exception)
			{
				webExceptionWrapper = new WebExceptionWrapper(new WebException("An error occurred performing a http web request.", exception));
				this._innerException = webExceptionWrapper;
			}
			this.OnOpenReadCompleted(new Facebook.OpenReadCompletedEventArgs(responseStream, webExceptionWrapper, (webExceptionWrapper == null ? false : webExceptionWrapper.Status == WebExceptionStatus.RequestCanceled), userToken));
		}

		private void ScanTimoutCallback(object state, bool timedOut)
		{
			if (this.HttpWebRequest != null && timedOut)
			{
				this.HttpWebRequest.Abort();
			}
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

		public static string UrlDecode(string s)
		{
			return HttpHelper.UrlDecode(s, Encoding.UTF8);
		}

		private static string UrlDecode(string s, Encoding e)
		{
			int chr;
			if (s == null)
			{
				return null;
			}
			if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
			{
				return s;
			}
			if (e == null)
			{
				e = Encoding.UTF8;
			}
			long length = (long)s.Length;
			List<byte> nums = new List<byte>();
			for (int i = 0; (long)i < length; i++)
			{
				char chr1 = s[i];
				if (chr1 == '%' && (long)(i + 2) < length && s[i + 1] != '%')
				{
					if (s[i + 1] != 'u' || (long)(i + 5) >= length)
					{
						int num = HttpHelper.GetChar(s, i + 1, 2);
						chr = num;
						if (num == -1)
						{
							HttpHelper.WriteCharBytes(nums, '%', e);
						}
						else
						{
							HttpHelper.WriteCharBytes(nums, (char)chr, e);
							i += 2;
						}
					}
					else
					{
						chr = HttpHelper.GetChar(s, i + 2, 4);
						if (chr == -1)
						{
							HttpHelper.WriteCharBytes(nums, '%', e);
						}
						else
						{
							HttpHelper.WriteCharBytes(nums, (char)chr, e);
							i += 5;
						}
					}
				}
				else if (chr1 != '+')
				{
					HttpHelper.WriteCharBytes(nums, chr1, e);
				}
				else
				{
					HttpHelper.WriteCharBytes(nums, ' ', e);
				}
			}
			byte[] array = nums.ToArray();
			nums = null;
			return e.GetString(array, 0, (int)array.Length);
		}

		public static string UrlEncode(string s)
		{
			if (s == null || s.Length <= 0x3e8)
			{
				return Uri.EscapeDataString(s);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = s.Length / 0x3e8;
			for (int i = 0; i <= length; i++)
			{
				stringBuilder.Append((i < length ? Uri.EscapeDataString(s.Substring(0x3e8 * i, 0x3e8)) : Uri.EscapeDataString(s.Substring(0x3e8 * i))));
			}
			return stringBuilder.ToString();
		}

		private static void WriteCharBytes(IList buf, char ch, Encoding e)
		{
			if (ch <= 'ÿ')
			{
				buf.Add((byte)ch);
				return;
			}
			byte[] bytes = e.GetBytes(new char[] { ch });
			for (int i = 0; i < (int)bytes.Length; i++)
			{
				buf.Add(bytes[i]);
			}
		}

		public event Facebook.OpenReadCompletedEventHandler OpenReadCompleted;

		public event Facebook.OpenWriteCompletedEventHandler OpenWriteCompleted;
	}
}