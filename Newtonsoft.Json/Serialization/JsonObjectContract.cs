using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonObjectContract : JsonContainerContract
	{
		private bool? _hasRequiredOrDefaultValueProperties;

		public JsonPropertyCollection ConstructorParameters
		{
			get;
			private set;
		}

		internal bool HasRequiredOrDefaultValueProperties
		{
			get
			{
				JsonProperty current;
				DefaultValueHandling? nullable;
				bool flag;
				if (!this._hasRequiredOrDefaultValueProperties.HasValue)
				{
					this._hasRequiredOrDefaultValueProperties = new bool?(false);
					if (this.ItemRequired.GetValueOrDefault(Required.Default) == Required.Default)
					{
						using (IEnumerator<JsonProperty> enumerator = this.Properties.GetEnumerator())
						{
							do
							{
								if (!enumerator.MoveNext())
								{
									goto Label0;
								}
								current = enumerator.Current;
								if (current.Required != Required.Default)
								{
									break;
								}
								DefaultValueHandling? defaultValueHandling = current.DefaultValueHandling;
								if (defaultValueHandling.HasValue)
								{
									nullable = new DefaultValueHandling?(defaultValueHandling.GetValueOrDefault() & DefaultValueHandling.Populate);
								}
								else
								{
									nullable = null;
								}
								DefaultValueHandling? nullable1 = nullable;
								flag = (nullable1.GetValueOrDefault() != DefaultValueHandling.Populate ? false : nullable1.HasValue);
							}
							while (!flag || !current.Writable);
							this._hasRequiredOrDefaultValueProperties = new bool?(true);
						Label0:
						}
					}
					else
					{
						this._hasRequiredOrDefaultValueProperties = new bool?(true);
					}
				}
				return this._hasRequiredOrDefaultValueProperties.Value;
			}
		}

		public Required? ItemRequired
		{
			get;
			set;
		}

		public Newtonsoft.Json.MemberSerialization MemberSerialization
		{
			get;
			set;
		}

		public ConstructorInfo OverrideConstructor
		{
			get;
			set;
		}

		public ConstructorInfo ParametrizedConstructor
		{
			get;
			set;
		}

		public JsonPropertyCollection Properties
		{
			get;
			private set;
		}

		public JsonObjectContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Object;
			this.Properties = new JsonPropertyCollection(base.UnderlyingType);
			this.ConstructorParameters = new JsonPropertyCollection(base.UnderlyingType);
		}
	}
}