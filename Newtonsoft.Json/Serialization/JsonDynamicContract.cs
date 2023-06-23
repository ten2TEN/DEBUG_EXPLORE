using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDynamicContract : JsonContract
	{
		public JsonPropertyCollection Properties
		{
			get;
			private set;
		}

		public Func<string, string> PropertyNameResolver
		{
			get;
			set;
		}

		public JsonDynamicContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Dynamic;
			this.Properties = new JsonPropertyCollection(base.UnderlyingType);
		}
	}
}