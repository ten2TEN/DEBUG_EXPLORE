using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	internal abstract class JsonSerializerInternalBase
	{
		private ErrorContext _currentErrorContext;

		private BidirectionalDictionary<string, object> _mappings;

		internal readonly JsonSerializer Serializer;

		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			get
			{
				if (this._mappings == null)
				{
					this._mappings = new BidirectionalDictionary<string, object>(EqualityComparer<string>.Default, new JsonSerializerInternalBase.ReferenceEqualsEqualityComparer());
				}
				return this._mappings;
			}
		}

		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
			ValidationUtils.ArgumentNotNull(serializer, "serializer");
			this.Serializer = serializer;
		}

		protected void ClearErrorContext()
		{
			if (this._currentErrorContext == null)
			{
				throw new InvalidOperationException("Could not clear error context. Error context is already null.");
			}
			this._currentErrorContext = null;
		}

		protected ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error)
		{
			if (this._currentErrorContext == null)
			{
				this._currentErrorContext = new ErrorContext(currentObject, member, path, error);
			}
			if (this._currentErrorContext.Error != error)
			{
				throw new InvalidOperationException("Current error context error is different to requested error.");
			}
			return this._currentErrorContext;
		}

		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, string path, Exception ex)
		{
			ErrorContext errorContext = this.GetErrorContext(currentObject, keyValue, path, ex);
			if (contract != null)
			{
				contract.InvokeOnError(currentObject, this.Serializer.Context, errorContext);
			}
			if (!errorContext.Handled)
			{
				this.Serializer.OnError(new ErrorEventArgs(currentObject, errorContext));
			}
			return errorContext.Handled;
		}

		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			public ReferenceEqualsEqualityComparer()
			{
			}

			bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y)
			{
				return object.ReferenceEquals(x, y);
			}

			int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
			{
				return RuntimeHelpers.GetHashCode(obj);
			}
		}
	}
}