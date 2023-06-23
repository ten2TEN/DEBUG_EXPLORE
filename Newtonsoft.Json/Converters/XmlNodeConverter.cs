using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	public class XmlNodeConverter : JsonConverter
	{
		private const string TextName = "#text";

		private const string CommentName = "#comment";

		private const string CDataName = "#cdata-section";

		private const string WhitespaceName = "#whitespace";

		private const string SignificantWhitespaceName = "#significant-whitespace";

		private const string DeclarationName = "?xml";

		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		public string DeserializeRootElementName
		{
			get;
			set;
		}

		public bool OmitRootObject
		{
			get;
			set;
		}

		public bool WriteArrayAttribute
		{
			get;
			set;
		}

		public XmlNodeConverter()
		{
		}

		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
			element.SetAttributeNode(document.CreateAttribute("json:Array", "http://james.newtonking.com/projects/json", "true"));
			if (element is XElementWrapper && element.GetPrefixOfNamespace("http://james.newtonking.com/projects/json") == null)
			{
				element.SetAttributeNode(document.CreateAttribute("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
			}
		}

		public override bool CanConvert(Type valueType)
		{
			if (typeof(XObject).IsAssignableFrom(valueType))
			{
				return true;
			}
			if (typeof(XmlNode).IsAssignableFrom(valueType))
			{
				return true;
			}
			return false;
		}

		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.String)
			{
				return reader.Value.ToString();
			}
			if (reader.TokenType == JsonToken.Integer)
			{
				return XmlConvert.ToString(Convert.ToInt64(reader.Value, CultureInfo.InvariantCulture));
			}
			if (reader.TokenType == JsonToken.Float)
			{
				return XmlConvert.ToString(Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture));
			}
			if (reader.TokenType == JsonToken.Boolean)
			{
				return XmlConvert.ToString(Convert.ToBoolean(reader.Value, CultureInfo.InvariantCulture));
			}
			if (reader.TokenType == JsonToken.Date)
			{
				DateTime dateTime = Convert.ToDateTime(reader.Value, CultureInfo.InvariantCulture);
				return XmlConvert.ToString(dateTime, DateTimeUtils.ToSerializationMode(dateTime.Kind));
			}
			if (reader.TokenType != JsonToken.Null)
			{
				throw JsonSerializationException.Create(reader, "Cannot get an XML string value from token type '{0}'.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			return null;
		}

		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			string str = (string.IsNullOrEmpty(elementPrefix) ? manager.DefaultNamespace : manager.LookupNamespace(elementPrefix));
			return (!string.IsNullOrEmpty(str) ? document.CreateElement(elementName, str) : document.CreateElement(elementName));
		}

		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
			if (propertyName != "?xml")
			{
				IXmlNode xmlNode = document.CreateProcessingInstruction(propertyName.Substring(1), reader.Value.ToString());
				currentNode.AppendChild(xmlNode);
				return;
			}
			string str = null;
			string str1 = null;
			string str2 = null;
			while (true)
			{
				if (!reader.Read() || reader.TokenType == JsonToken.EndObject)
				{
					IXmlNode xmlNode1 = document.CreateXmlDeclaration(str, str1, str2);
					currentNode.AppendChild(xmlNode1);
					return;
				}
				string str3 = reader.Value.ToString();
				string str4 = str3;
				if (str3 == null)
				{
					break;
				}
				if (str4 == "@version")
				{
					reader.Read();
					str = reader.Value.ToString();
				}
				else if (str4 == "@encoding")
				{
					reader.Read();
					str1 = reader.Value.ToString();
				}
				else if (str4 == "@standalone")
				{
					reader.Read();
					str2 = reader.Value.ToString();
				}
				else
				{
					break;
				}
			}
			throw new JsonSerializationException(string.Concat("Unexpected property name encountered while deserializing XmlDeclaration: ", reader.Value));
		}

		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.StartConstructor:
					{
						string str = reader.Value.ToString();
						while (reader.Read())
						{
							if (reader.TokenType != JsonToken.EndConstructor)
							{
								this.DeserializeValue(reader, document, manager, str, currentNode);
							}
							else
							{
								goto Label0;
							}
						}
						goto Label0;
					}
					case JsonToken.PropertyName:
					{
						if (currentNode.NodeType == XmlNodeType.Document && document.DocumentElement != null)
						{
							throw new JsonSerializationException("JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifing a DeserializeRootElementName.");
						}
						string str1 = reader.Value.ToString();
						reader.Read();
						if (reader.TokenType != JsonToken.StartArray)
						{
							this.DeserializeValue(reader, document, manager, str1, currentNode);
							continue;
						}
						else
						{
							int num = 0;
							while (reader.Read() && reader.TokenType != JsonToken.EndArray)
							{
								this.DeserializeValue(reader, document, manager, str1, currentNode);
								num++;
							}
							if (num != 1 || !this.WriteArrayAttribute)
							{
								continue;
							}
							this.AddJsonArrayAttribute(currentNode.ChildNodes.CastValid<IXmlElement>().Single<IXmlElement>((IXmlElement n) => n.LocalName == str1), document);
							continue;
						}
					}
					case JsonToken.Comment:
					{
						currentNode.AppendChild(document.CreateComment((string)reader.Value));
						continue;
					}
					default:
					{
						switch (tokenType)
						{
							case JsonToken.EndObject:
							case JsonToken.EndArray:
							{
								return;
							}
						}
						break;
					}
				}
				throw new JsonSerializationException(string.Concat("Unexpected JsonToken when deserializing node: ", reader.TokenType));
			Label0:
			}
			while (reader.TokenType == JsonToken.PropertyName || reader.Read());
		}

		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
			string str = propertyName;
			string str1 = str;
			if (str != null)
			{
				if (str1 == "#text")
				{
					currentNode.AppendChild(document.CreateTextNode(reader.Value.ToString()));
					return;
				}
				if (str1 == "#cdata-section")
				{
					currentNode.AppendChild(document.CreateCDataSection(reader.Value.ToString()));
					return;
				}
				if (str1 == "#whitespace")
				{
					currentNode.AppendChild(document.CreateWhitespace(reader.Value.ToString()));
					return;
				}
				if (str1 == "#significant-whitespace")
				{
					currentNode.AppendChild(document.CreateSignificantWhitespace(reader.Value.ToString()));
					return;
				}
			}
			if (!string.IsNullOrEmpty(propertyName) && propertyName[0] == '?')
			{
				this.CreateInstruction(reader, document, currentNode, propertyName);
				return;
			}
			if (reader.TokenType == JsonToken.StartArray)
			{
				this.ReadArrayElements(reader, document, propertyName, currentNode, manager);
				return;
			}
			this.ReadElement(reader, document, currentNode, propertyName, manager);
		}

		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			switch (node.NodeType)
			{
				case XmlNodeType.Element:
				{
					return this.ResolveFullName(node, manager);
				}
				case XmlNodeType.Attribute:
				{
					if (node.NamespaceUri == "http://james.newtonking.com/projects/json")
					{
						return string.Concat("$", node.LocalName);
					}
					return string.Concat("@", this.ResolveFullName(node, manager));
				}
				case XmlNodeType.Text:
				{
					return "#text";
				}
				case XmlNodeType.CDATA:
				{
					return "#cdata-section";
				}
				case XmlNodeType.EntityReference:
				case XmlNodeType.Entity:
				case XmlNodeType.Document:
				case XmlNodeType.DocumentType:
				case XmlNodeType.DocumentFragment:
				case XmlNodeType.Notation:
				case XmlNodeType.EndElement:
				case XmlNodeType.EndEntity:
				{
					throw new JsonSerializationException(string.Concat("Unexpected XmlNodeType when getting node name: ", node.NodeType));
				}
				case XmlNodeType.ProcessingInstruction:
				{
					return string.Concat("?", this.ResolveFullName(node, manager));
				}
				case XmlNodeType.Comment:
				{
					return "#comment";
				}
				case XmlNodeType.Whitespace:
				{
					return "#whitespace";
				}
				case XmlNodeType.SignificantWhitespace:
				{
					return "#significant-whitespace";
				}
				case XmlNodeType.XmlDeclaration:
				{
					return "?xml";
				}
				default:
				{
					throw new JsonSerializationException(string.Concat("Unexpected XmlNodeType when getting node name: ", node.NodeType));
				}
			}
		}

		private bool IsArray(IXmlNode node)
		{
			IXmlNode xmlNode;
			if (node.Attributes != null)
			{
				xmlNode = node.Attributes.SingleOrDefault<IXmlNode>((IXmlNode a) => {
					if (a.LocalName != "Array")
					{
						return false;
					}
					return a.NamespaceUri == "http://james.newtonking.com/projects/json";
				});
			}
			else
			{
				xmlNode = null;
			}
			IXmlNode xmlNode1 = xmlNode;
			if (xmlNode1 == null)
			{
				return false;
			}
			return XmlConvert.ToBoolean(xmlNode1.Value);
		}

		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			if (attributeName.StartsWith("xmlns", StringComparison.Ordinal))
			{
				if (attributeName.Length == 5)
				{
					prefix = string.Empty;
					return true;
				}
				if (attributeName[5] == ':')
				{
					prefix = attributeName.Substring(6, attributeName.Length - 6);
					return true;
				}
			}
			prefix = null;
			return false;
		}

		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
			List<IXmlNode> xmlNodes = null;
			IXmlNode xmlNode = node;
			while (true)
			{
				IXmlNode parentNode = xmlNode.ParentNode;
				xmlNode = parentNode;
				if (parentNode == null)
				{
					break;
				}
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					if (xmlNodes == null)
					{
						xmlNodes = new List<IXmlNode>();
					}
					xmlNodes.Add(xmlNode);
				}
			}
			if (xmlNodes != null)
			{
				xmlNodes.Reverse();
				foreach (IXmlNode xmlNode1 in xmlNodes)
				{
					manager.PushScope();
					foreach (IXmlNode attribute in xmlNode1.Attributes)
					{
						if (!(attribute.NamespaceUri == "http://www.w3.org/2000/xmlns/") || !(attribute.LocalName != "xmlns"))
						{
							continue;
						}
						manager.AddNamespace(attribute.LocalName, attribute.Value);
					}
				}
			}
		}

		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
			IXmlElement xmlElement = this.CreateElement(propertyName, document, prefix, manager);
			currentNode.AppendChild(xmlElement);
			int num = 0;
			while (reader.Read() && reader.TokenType != JsonToken.EndArray)
			{
				this.DeserializeValue(reader, document, manager, propertyName, xmlElement);
				num++;
			}
			if (this.WriteArrayAttribute)
			{
				this.AddJsonArrayAttribute(xmlElement, document);
			}
			if (num == 1 && this.WriteArrayAttribute)
			{
				this.AddJsonArrayAttribute(xmlElement.ChildNodes.CastValid<IXmlElement>().Single<IXmlElement>((IXmlElement n) => n.LocalName == propertyName), document);
			}
		}

		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			string str;
			string str1;
			Dictionary<string, string> strs = new Dictionary<string, string>();
			bool flag = false;
			bool flag1 = false;
			if (reader.TokenType != JsonToken.String && reader.TokenType != JsonToken.Null && reader.TokenType != JsonToken.Boolean && reader.TokenType != JsonToken.Integer && reader.TokenType != JsonToken.Float && reader.TokenType != JsonToken.Date && reader.TokenType != JsonToken.StartConstructor)
			{
				while (!flag && !flag1 && reader.Read())
				{
					JsonToken tokenType = reader.TokenType;
					if (tokenType == JsonToken.PropertyName)
					{
						string str2 = reader.Value.ToString();
						if (string.IsNullOrEmpty(str2))
						{
							flag = true;
						}
						else
						{
							char chr = str2[0];
							if (chr == '$')
							{
								str2 = str2.Substring(1);
								reader.Read();
								str = reader.Value.ToString();
								string str3 = manager.LookupPrefix("http://james.newtonking.com/projects/json");
								if (str3 == null)
								{
									int? nullable = null;
									while (manager.LookupNamespace(string.Concat("json", nullable)) != null)
									{
										nullable = new int?(nullable.GetValueOrDefault() + 1);
									}
									str3 = string.Concat("json", nullable);
									strs.Add(string.Concat("xmlns:", str3), "http://james.newtonking.com/projects/json");
									manager.AddNamespace(str3, "http://james.newtonking.com/projects/json");
								}
								strs.Add(string.Concat(str3, ":", str2), str);
							}
							else if (chr != '@')
							{
								flag = true;
							}
							else
							{
								str2 = str2.Substring(1);
								reader.Read();
								str = this.ConvertTokenToXmlValue(reader);
								strs.Add(str2, str);
								if (!this.IsNamespaceAttribute(str2, out str1))
								{
									continue;
								}
								manager.AddNamespace(str1, str);
							}
						}
					}
					else
					{
						if (tokenType != JsonToken.EndObject)
						{
							throw new JsonSerializationException(string.Concat("Unexpected JsonToken: ", reader.TokenType));
						}
						flag1 = true;
					}
				}
			}
			return strs;
		}

		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
			IXmlNode xmlNode;
			if (string.IsNullOrEmpty(propertyName))
			{
				throw new JsonSerializationException("XmlNodeConverter cannot convert JSON with an empty property name to XML.");
			}
			Dictionary<string, string> strs = this.ReadAttributeElements(reader, manager);
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
			if (propertyName.StartsWith("@"))
			{
				string str = propertyName.Substring(1);
				string str1 = reader.Value.ToString();
				string prefix1 = MiscellaneousUtils.GetPrefix(str);
				xmlNode = (!string.IsNullOrEmpty(prefix1) ? document.CreateAttribute(str, manager.LookupNamespace(prefix1), str1) : document.CreateAttribute(str, str1));
				((IXmlElement)currentNode).SetAttributeNode(xmlNode);
				return;
			}
			IXmlElement xmlElement = this.CreateElement(propertyName, document, prefix, manager);
			currentNode.AppendChild(xmlElement);
			foreach (KeyValuePair<string, string> keyValuePair in strs)
			{
				string prefix2 = MiscellaneousUtils.GetPrefix(keyValuePair.Key);
				xmlElement.SetAttributeNode((!string.IsNullOrEmpty(prefix2) ? document.CreateAttribute(keyValuePair.Key, manager.LookupNamespace(prefix2), keyValuePair.Value) : document.CreateAttribute(keyValuePair.Key, keyValuePair.Value)));
			}
			if (reader.TokenType == JsonToken.String || reader.TokenType == JsonToken.Integer || reader.TokenType == JsonToken.Float || reader.TokenType == JsonToken.Boolean || reader.TokenType == JsonToken.Date)
			{
				xmlElement.AppendChild(document.CreateTextNode(this.ConvertTokenToXmlValue(reader)));
				return;
			}
			if (reader.TokenType == JsonToken.Null)
			{
				return;
			}
			if (reader.TokenType != JsonToken.EndObject)
			{
				manager.PushScope();
				this.DeserializeNode(reader, document, manager, xmlElement);
				manager.PopScope();
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			XmlNamespaceManager xmlNamespaceManagers = new XmlNamespaceManager(new NameTable());
			IXmlDocument xDocumentWrapper = null;
			IXmlNode xmlNode = null;
			if (typeof(XObject).IsAssignableFrom(objectType))
			{
				if (objectType != typeof(XDocument) && objectType != typeof(XElement))
				{
					throw new JsonSerializationException("XmlNodeConverter only supports deserializing XDocument or XElement.");
				}
				xDocumentWrapper = new XDocumentWrapper(new XDocument());
				xmlNode = xDocumentWrapper;
			}
			if (typeof(XmlNode).IsAssignableFrom(objectType))
			{
				if (objectType != typeof(XmlDocument))
				{
					throw new JsonSerializationException("XmlNodeConverter only supports deserializing XmlDocuments");
				}
				xDocumentWrapper = new XmlDocumentWrapper(new XmlDocument());
				xmlNode = xDocumentWrapper;
			}
			if (xDocumentWrapper == null || xmlNode == null)
			{
				throw new JsonSerializationException(string.Concat("Unexpected type when converting XML: ", objectType));
			}
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw new JsonSerializationException("XmlNodeConverter can only convert JSON that begins with an object.");
			}
			if (string.IsNullOrEmpty(this.DeserializeRootElementName))
			{
				reader.Read();
				this.DeserializeNode(reader, xDocumentWrapper, xmlNamespaceManagers, xmlNode);
			}
			else
			{
				this.ReadElement(reader, xDocumentWrapper, xmlNode, this.DeserializeRootElementName, xmlNamespaceManagers);
			}
			if (objectType != typeof(XElement))
			{
				return xDocumentWrapper.WrappedNode;
			}
			XElement wrappedNode = (XElement)xDocumentWrapper.DocumentElement.WrappedNode;
			wrappedNode.Remove();
			return wrappedNode;
		}

		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			string str;
			if (node.NamespaceUri == null || node.LocalName == "xmlns" && node.NamespaceUri == "http://www.w3.org/2000/xmlns/")
			{
				str = null;
			}
			else
			{
				str = manager.LookupPrefix(node.NamespaceUri);
			}
			string str1 = str;
			if (string.IsNullOrEmpty(str1))
			{
				return node.LocalName;
			}
			return string.Concat(str1, ":", node.LocalName);
		}

		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			List<IXmlNode> xmlNodes;
			bool flag;
			Dictionary<string, List<IXmlNode>> strs = new Dictionary<string, List<IXmlNode>>();
			for (int i = 0; i < node.ChildNodes.Count; i++)
			{
				IXmlNode item = node.ChildNodes[i];
				string propertyName = this.GetPropertyName(item, manager);
				if (!strs.TryGetValue(propertyName, out xmlNodes))
				{
					xmlNodes = new List<IXmlNode>();
					strs.Add(propertyName, xmlNodes);
				}
				xmlNodes.Add(item);
			}
			foreach (KeyValuePair<string, List<IXmlNode>> str in strs)
			{
				List<IXmlNode> value = str.Value;
				flag = (value.Count != 1 ? true : this.IsArray(value[0]));
				if (flag)
				{
					string key = str.Key;
					if (writePropertyName)
					{
						writer.WritePropertyName(key);
					}
					writer.WriteStartArray();
					for (int j = 0; j < value.Count; j++)
					{
						this.SerializeNode(writer, value[j], manager, false);
					}
					writer.WriteEndArray();
				}
				else
				{
					this.SerializeNode(writer, value[0], manager, writePropertyName);
				}
			}
		}

		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			switch (node.NodeType)
			{
				case XmlNodeType.Element:
				{
					if (this.IsArray(node))
					{
						if (node.ChildNodes.All<IXmlNode>((IXmlNode n) => n.LocalName == node.LocalName) && node.ChildNodes.Count > 0)
						{
							this.SerializeGroupedNodes(writer, node, manager, false);
							return;
						}
					}
					foreach (IXmlNode attribute in node.Attributes)
					{
						if (attribute.NamespaceUri != "http://www.w3.org/2000/xmlns/")
						{
							continue;
						}
						manager.AddNamespace((attribute.LocalName != "xmlns" ? attribute.LocalName : string.Empty), attribute.Value);
					}
					if (writePropertyName)
					{
						writer.WritePropertyName(this.GetPropertyName(node, manager));
					}
					if (!this.ValueAttributes(node.Attributes).Any<IXmlNode>() && node.ChildNodes.Count == 1 && node.ChildNodes[0].NodeType == XmlNodeType.Text)
					{
						writer.WriteValue(node.ChildNodes[0].Value);
						return;
					}
					if (node.ChildNodes.Count == 0 && CollectionUtils.IsNullOrEmpty<IXmlNode>(node.Attributes))
					{
						writer.WriteNull();
						return;
					}
					writer.WriteStartObject();
					for (int i = 0; i < node.Attributes.Count; i++)
					{
						this.SerializeNode(writer, node.Attributes[i], manager, true);
					}
					this.SerializeGroupedNodes(writer, node, manager, true);
					writer.WriteEndObject();
					return;
				}
				case XmlNodeType.Attribute:
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
				{
					if (node.NamespaceUri == "http://www.w3.org/2000/xmlns/" && node.Value == "http://james.newtonking.com/projects/json")
					{
						return;
					}
					if (node.NamespaceUri == "http://james.newtonking.com/projects/json" && node.LocalName == "Array")
					{
						return;
					}
					if (writePropertyName)
					{
						writer.WritePropertyName(this.GetPropertyName(node, manager));
					}
					writer.WriteValue(node.Value);
					return;
				}
				case XmlNodeType.EntityReference:
				case XmlNodeType.Entity:
				case XmlNodeType.DocumentType:
				case XmlNodeType.Notation:
				case XmlNodeType.EndElement:
				case XmlNodeType.EndEntity:
				{
					throw new JsonSerializationException(string.Concat("Unexpected XmlNodeType when serializing nodes: ", node.NodeType));
				}
				case XmlNodeType.Comment:
				{
					if (!writePropertyName)
					{
						return;
					}
					writer.WriteComment(node.Value);
					return;
				}
				case XmlNodeType.Document:
				case XmlNodeType.DocumentFragment:
				{
					this.SerializeGroupedNodes(writer, node, manager, writePropertyName);
					return;
				}
				case XmlNodeType.XmlDeclaration:
				{
					IXmlDeclaration xmlDeclaration = (IXmlDeclaration)node;
					writer.WritePropertyName(this.GetPropertyName(node, manager));
					writer.WriteStartObject();
					if (!string.IsNullOrEmpty(xmlDeclaration.Version))
					{
						writer.WritePropertyName("@version");
						writer.WriteValue(xmlDeclaration.Version);
					}
					if (!string.IsNullOrEmpty(xmlDeclaration.Encoding))
					{
						writer.WritePropertyName("@encoding");
						writer.WriteValue(xmlDeclaration.Encoding);
					}
					if (!string.IsNullOrEmpty(xmlDeclaration.Standalone))
					{
						writer.WritePropertyName("@standalone");
						writer.WriteValue(xmlDeclaration.Standalone);
					}
					writer.WriteEndObject();
					return;
				}
				default:
				{
					throw new JsonSerializationException(string.Concat("Unexpected XmlNodeType when serializing nodes: ", node.NodeType));
				}
			}
		}

		private IEnumerable<IXmlNode> ValueAttributes(IEnumerable<IXmlNode> c)
		{
			return 
				from a in c
				where a.NamespaceUri != "http://james.newtonking.com/projects/json"
				select a;
		}

		private IXmlNode WrapXml(object value)
		{
			if (value is XObject)
			{
				return XContainerWrapper.WrapNode((XObject)value);
			}
			if (!(value is XmlNode))
			{
				throw new ArgumentException("Value must be an XML object.", "value");
			}
			return new XmlNodeWrapper((XmlNode)value);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			IXmlNode xmlNode = this.WrapXml(value);
			XmlNamespaceManager xmlNamespaceManagers = new XmlNamespaceManager(new NameTable());
			this.PushParentNamespaces(xmlNode, xmlNamespaceManagers);
			if (!this.OmitRootObject)
			{
				writer.WriteStartObject();
			}
			this.SerializeNode(writer, xmlNode, xmlNamespaceManagers, !this.OmitRootObject);
			if (!this.OmitRootObject)
			{
				writer.WriteEndObject();
			}
		}
	}
}