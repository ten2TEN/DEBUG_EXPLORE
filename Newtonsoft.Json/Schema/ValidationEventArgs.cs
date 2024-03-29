using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Schema
{
	public class ValidationEventArgs : EventArgs
	{
		private readonly JsonSchemaException _ex;

		public JsonSchemaException Exception
		{
			get
			{
				return this._ex;
			}
		}

		public string Message
		{
			get
			{
				return this._ex.Message;
			}
		}

		public string Path
		{
			get
			{
				return this._ex.Path;
			}
		}

		internal ValidationEventArgs(JsonSchemaException ex)
		{
			ValidationUtils.ArgumentNotNull(ex, "ex");
			this._ex = ex;
		}
	}
}