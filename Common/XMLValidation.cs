using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Common
{
	public class XMLValidation
	{
		public XMLValidation()
		{
		}

		// 
		private static void u0092u001c(object sender, ValidationEventArgs args)
		{
			throw new Exception(args.Message);
		}

		public static void ValidateXML(XmlDocument doc, Stream xsdStream)
		{
			Assembly.GetExecutingAssembly();
			XmlSchema xmlSchema = (XmlSchema)(new XmlSerializer(typeof(XmlSchema))).Deserialize(xsdStream);
			doc.Schemas.Add(xmlSchema);
			doc.Validate(new ValidationEventHandler(XMLValidation.u0092u001c));
			doc.Schemas.Remove(xmlSchema);
		}
	}
}