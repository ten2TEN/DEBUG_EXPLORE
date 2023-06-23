using System;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	internal class WrapperDictionary
	{
		private readonly Dictionary<string, Type> _wrapperTypes = new Dictionary<string, Type>();

		public WrapperDictionary()
		{
		}

		private static string GenerateKey(Type interfaceType, Type realObjectType)
		{
			return string.Concat(interfaceType.Name, "_", realObjectType.Name);
		}

		public Type GetType(Type interfaceType, Type realObjectType)
		{
			string str = WrapperDictionary.GenerateKey(interfaceType, realObjectType);
			if (!this._wrapperTypes.ContainsKey(str))
			{
				return null;
			}
			return this._wrapperTypes[str];
		}

		public void SetType(Type interfaceType, Type realObjectType, Type wrapperType)
		{
			string str = WrapperDictionary.GenerateKey(interfaceType, realObjectType);
			if (this._wrapperTypes.ContainsKey(str))
			{
				this._wrapperTypes[str] = wrapperType;
				return;
			}
			this._wrapperTypes.Add(str, wrapperType);
		}
	}
}