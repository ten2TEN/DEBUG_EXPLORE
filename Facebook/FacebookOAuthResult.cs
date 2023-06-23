using System;
using System.Collections.Generic;
using System.Globalization;

namespace Facebook
{
	public class FacebookOAuthResult
	{
		private readonly string _accessToken;

		private readonly DateTime _expires;

		private readonly string _error;

		private readonly string _errorReason;

		private readonly string _errorDescription;

		private readonly string _code;

		private readonly string _state;

		public virtual string AccessToken
		{
			get
			{
				return this._accessToken;
			}
		}

		public virtual string Code
		{
			get
			{
				return this._code;
			}
		}

		public virtual string Error
		{
			get
			{
				return this._error;
			}
		}

		public virtual string ErrorDescription
		{
			get
			{
				return this._errorDescription;
			}
		}

		public virtual string ErrorReason
		{
			get
			{
				return this._errorReason;
			}
		}

		public virtual DateTime Expires
		{
			get
			{
				return this._expires;
			}
		}

		public virtual bool IsSuccess
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Error))
				{
					return false;
				}
				if (!string.IsNullOrEmpty(this.AccessToken))
				{
					return true;
				}
				return !string.IsNullOrEmpty(this.Code);
			}
		}

		public virtual string State
		{
			get
			{
				return this._state;
			}
		}

		protected FacebookOAuthResult()
		{
		}

		internal FacebookOAuthResult(IDictionary<string, object> parameters)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			if (parameters.ContainsKey("state"))
			{
				this._state = parameters["state"].ToString();
			}
			if (parameters.ContainsKey("error"))
			{
				this._error = parameters["error"].ToString();
				if (parameters.ContainsKey("error_reason"))
				{
					this._errorReason = parameters["error_reason"].ToString();
				}
				if (parameters.ContainsKey("error_description"))
				{
					this._errorDescription = parameters["error_description"].ToString();
				}
				return;
			}
			if (parameters.ContainsKey("code"))
			{
				this._code = parameters["code"].ToString();
			}
			if (parameters.ContainsKey("access_token"))
			{
				this._accessToken = parameters["access_token"].ToString();
			}
			if (parameters.ContainsKey("expires_in"))
			{
				double num = Convert.ToDouble(parameters["expires_in"], CultureInfo.InvariantCulture);
				this._expires = (num > 0 ? DateTime.UtcNow.AddSeconds(num) : DateTime.MaxValue);
			}
		}
	}
}