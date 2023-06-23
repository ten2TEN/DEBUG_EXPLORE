using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XContainerWrapper : XObjectWrapper
	{
		public override IList<IXmlNode> ChildNodes
		{
			get
			{
				return (
					from n in this.Container.Nodes()
					select XContainerWrapper.WrapNode(n)).ToList<IXmlNode>();
			}
		}

		private XContainer Container
		{
			get
			{
				return (XContainer)base.WrappedNode;
			}
		}

		public override IXmlNode ParentNode
		{
			get
			{
				if (this.Container.Parent == null)
				{
					return null;
				}
				return XContainerWrapper.WrapNode(this.Container.Parent);
			}
		}

		public XContainerWrapper(XContainer container) : base(container)
		{
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			this.Container.Add(newChild.WrappedNode);
			return newChild;
		}

		internal static IXmlNode WrapNode(XObject node)
		{
			if (node is XDocument)
			{
				return new XDocumentWrapper((XDocument)node);
			}
			if (node is XElement)
			{
				return new XElementWrapper((XElement)node);
			}
			if (node is XContainer)
			{
				return new XContainerWrapper((XContainer)node);
			}
			if (node is XProcessingInstruction)
			{
				return new XProcessingInstructionWrapper((XProcessingInstruction)node);
			}
			if (node is XText)
			{
				return new XTextWrapper((XText)node);
			}
			if (node is XComment)
			{
				return new XCommentWrapper((XComment)node);
			}
			if (!(node is XAttribute))
			{
				return new XObjectWrapper(node);
			}
			return new XAttributeWrapper((XAttribute)node);
		}
	}
}