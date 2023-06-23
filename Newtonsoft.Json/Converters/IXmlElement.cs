using System;

namespace Newtonsoft.Json.Converters
{
	internal interface IXmlElement : IXmlNode
	{
		string GetPrefixOfNamespace(string namespaceUri);

		void SetAttributeNode(IXmlNode attribute);
	}
}