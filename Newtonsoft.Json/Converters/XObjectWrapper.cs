using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XObjectWrapper : IXmlNode
	{
		private readonly XObject _xmlObject;

		public virtual IList<IXmlNode> Attributes
		{
			get
			{
				return null;
			}
		}

		public virtual IList<IXmlNode> ChildNodes
		{
			get
			{
				return new List<IXmlNode>();
			}
		}

		public virtual string LocalName
		{
			get
			{
				return null;
			}
		}

		public virtual string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		public virtual XmlNodeType NodeType
		{
			get
			{
				return this._xmlObject.NodeType;
			}
		}

		public virtual IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		public object WrappedNode
		{
			get
			{
				return this._xmlObject;
			}
		}

		public XObjectWrapper(XObject xmlObject)
		{
			this._xmlObject = xmlObject;
		}

		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			throw new InvalidOperationException();
		}
	}
}