using System;
using System.Runtime.CompilerServices;

namespace Facebook
{
	public class FacebookBatchParameter
	{
		public object Data
		{
			get;
			set;
		}

		public Facebook.HttpMethod HttpMethod
		{
			get;
			set;
		}

		public object Parameters
		{
			get;
			set;
		}

		public string Path
		{
			get;
			set;
		}

		public FacebookBatchParameter()
		{
			this.HttpMethod = Facebook.HttpMethod.Get;
		}

		public FacebookBatchParameter(string path) : this(Facebook.HttpMethod.Get, path)
		{
		}

		public FacebookBatchParameter(Facebook.HttpMethod httpMethod, string path) : this(httpMethod, path, null)
		{
		}

		public FacebookBatchParameter(string path, object parameters) : this(Facebook.HttpMethod.Get, path, parameters)
		{
		}

		public FacebookBatchParameter(Facebook.HttpMethod httpMethod, string path, object parameters)
		{
			this.HttpMethod = httpMethod;
			this.Path = path;
			this.Parameters = parameters;
		}
	}
}