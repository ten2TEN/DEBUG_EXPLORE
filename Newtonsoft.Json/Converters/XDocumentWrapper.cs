using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		public override IList<IXmlNode> ChildNodes
		{
			get
			{
				IList<IXmlNode> childNodes = base.ChildNodes;
				if (this.Document.Declaration != null)
				{
					childNodes.Insert(0, new XDeclarationWrapper(this.Document.Declaration));
				}
				return childNodes;
			}
		}

		private XDocument Document
		{
			get
			{
				return (XDocument)base.WrappedNode;
			}
		}

		public IXmlElement DocumentElement
		{
			get
			{
				if (this.Document.Root == null)
				{
					return null;
				}
				return new XElementWrapper(this.Document.Root);
			}
		}

		public XDocumentWrapper(XDocument document) : base(document)
		{
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			XDeclarationWrapper xDeclarationWrapper = newChild as XDeclarationWrapper;
			if (xDeclarationWrapper == null)
			{
				return base.AppendChild(newChild);
			}
			this.Document.Declaration = xDeclarationWrapper.Declaration;
			return xDeclarationWrapper;
		}

		public IXmlNode CreateAttribute(string name, string value)
		{
			return new XAttributeWrapper(new XAttribute(name, value));
		}

		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			string localName = MiscellaneousUtils.GetLocalName(qualifiedName);
			return new XAttributeWrapper(new XAttribute(XName.Get(localName, namespaceUri), value));
		}

		public IXmlNode CreateCDataSection(string data)
		{
			return new XObjectWrapper(new XCData(data));
		}

		public IXmlNode CreateComment(string text)
		{
			return new XObjectWrapper(new XComment(text));
		}

		public IXmlElement CreateElement(string elementName)
		{
			return new XElementWrapper(new XElement(elementName));
		}

		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			string localName = MiscellaneousUtils.GetLocalName(qualifiedName);
			return new XElementWrapper(new XElement(XName.Get(localName, namespaceUri)));
		}

		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XProcessingInstructionWrapper(new XProcessingInstruction(target, data));
		}

		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		public IXmlNode CreateTextNode(string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		public IXmlNode CreateWhitespace(string text)
		{
			return new XObjectWrapper(new XText(text));
		}

		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return new XDeclarationWrapper(new XDeclaration(version, encoding, standalone));
		}
	}
}