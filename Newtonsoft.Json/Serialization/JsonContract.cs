using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	public abstract class JsonContract
	{
		internal bool IsNullable;

		internal bool IsConvertable;

		internal Type NonNullableUnderlyingType;

		internal ReadType InternalReadType;

		internal JsonContractType ContractType;

		public JsonConverter Converter
		{
			get;
			set;
		}

		public Type CreatedType
		{
			get;
			set;
		}

		public Func<object> DefaultCreator
		{
			get;
			set;
		}

		public bool DefaultCreatorNonPublic
		{
			get;
			set;
		}

		internal JsonConverter InternalConverter
		{
			get;
			set;
		}

		public bool? IsReference
		{
			get;
			set;
		}

		public MethodInfo OnDeserialized
		{
			get;
			set;
		}

		public MethodInfo OnDeserializing
		{
			get;
			set;
		}

		public MethodInfo OnError
		{
			get;
			set;
		}

		public MethodInfo OnSerialized
		{
			get;
			set;
		}

		public MethodInfo OnSerializing
		{
			get;
			set;
		}

		public Type UnderlyingType
		{
			get;
			private set;
		}

		internal JsonContract(Type underlyingType)
		{
			ValidationUtils.ArgumentNotNull(underlyingType, "underlyingType");
			this.UnderlyingType = underlyingType;
			this.IsNullable = ReflectionUtils.IsNullable(underlyingType);
			this.NonNullableUnderlyingType = (!this.IsNullable || !ReflectionUtils.IsNullableType(underlyingType) ? underlyingType : Nullable.GetUnderlyingType(underlyingType));
			this.CreatedType = this.NonNullableUnderlyingType;
			this.IsConvertable = ConvertUtils.IsConvertible(this.NonNullableUnderlyingType);
			if (this.NonNullableUnderlyingType == typeof(byte[]))
			{
				this.InternalReadType = ReadType.ReadAsBytes;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(int))
			{
				this.InternalReadType = ReadType.ReadAsInt32;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(decimal))
			{
				this.InternalReadType = ReadType.ReadAsDecimal;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(string))
			{
				this.InternalReadType = ReadType.ReadAsString;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(DateTime))
			{
				this.InternalReadType = ReadType.ReadAsDateTime;
				return;
			}
			if (this.NonNullableUnderlyingType == typeof(DateTimeOffset))
			{
				this.InternalReadType = ReadType.ReadAsDateTimeOffset;
				return;
			}
			this.InternalReadType = ReadType.Read;
		}

		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
			if (this.OnDeserialized != null)
			{
				MethodInfo onDeserialized = this.OnDeserialized;
				object[] objArray = new object[] { context };
				onDeserialized.Invoke(o, objArray);
			}
		}

		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
			if (this.OnDeserializing != null)
			{
				MethodInfo onDeserializing = this.OnDeserializing;
				object[] objArray = new object[] { context };
				onDeserializing.Invoke(o, objArray);
			}
		}

		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
			if (this.OnError != null)
			{
				MethodInfo onError = this.OnError;
				object[] objArray = new object[] { context, errorContext };
				onError.Invoke(o, objArray);
			}
		}

		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
			if (this.OnSerialized != null)
			{
				MethodInfo onSerialized = this.OnSerialized;
				object[] objArray = new object[] { context };
				onSerialized.Invoke(o, objArray);
			}
		}

		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
			if (this.OnSerializing != null)
			{
				MethodInfo onSerializing = this.OnSerializing;
				object[] objArray = new object[] { context };
				onSerializing.Invoke(o, objArray);
			}
		}
	}
}