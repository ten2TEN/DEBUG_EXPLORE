using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		public override IList<IXmlNode> Attributes
		{
			get
			{
				return (
					from a in this.Element.Attributes()
					select new XAttributeWrapper(a)).Cast<IXmlNode>().ToList<IXmlNode>();
			}
		}

		private XElement Element
		{
			get
			{
				return (XElement)base.WrappedNode;
			}
		}

		public override string LocalName
		{
			get
			{
				return this.Element.Name.LocalName;
			}
		}

		public override string NamespaceUri
		{
			get
			{
				return this.Element.Name.NamespaceName;
			}
		}

		public override string Value
		{
			get
			{
				return this.Element.Value;
			}
			set
			{
				this.Element.Value = value;
			}
		}

		public XElementWrapper(XElement element) : base(element)
		{
		}

		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this.Element.GetPrefixOfNamespace(namespaceUri);
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
			XObjectWrapper xObjectWrapper = (XObjectWrapper)attribute;
			this.Element.Add(xObjectWrapper.WrappedNode);
		}
	}
}