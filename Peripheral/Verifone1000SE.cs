using MPS.POS.Utils;
using MSEnum;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Xml;
using Transaction;
using VER1000XLib;

namespace Peripheral
{
	public class Verifone1000SE : IPeripheral
	{
		// 
		private const double u0001 = 9999.99;

		// 
		private Ver1000X u0002;

		// 
		private string u0003 = string.Empty;

		// 
		private string u0004 = string.Empty;

		// 
		private SecureString u0005;

		// 
		private double u0006;

		// 
		private int u0007 = 30;

		// 
		private PinPadConnectionMethod u0008 = PinPadConnectionMethod.Unknown;

		// 
		private int u000e;

		// 
		private int u000f;

		// 
		private double u0010;

		// 
		private string u0011 = string.Empty;

		// 
		private bool u0012;

		// 
		private bool u0013;

		// 
		private PeripheralReturnCode u0014 = PeripheralReturnCode.Ok;

		public SecureString Account
		{
			set
			{
				this.u0005 = value;
			}
		}

		public double CashBackAmount
		{
			set
			{
				this.u0015u0003(this.u0006, value);
				this.u0010 = value;
			}
		}

		public string DervdKey
		{
			get
			{
				return this.u0004;
			}
		}

		public string PINBlock
		{
			get
			{
				return this.u0003;
			}
		}

		public double PurchaseAmount
		{
			set
			{
				this.u0015u0003(value, this.u0010);
				this.u0006 = value;
			}
		}

		public PeripheralReturnCode ReturnCode
		{
			get
			{
				return this.u0014;
			}
			set
			{
			}
		}

		public string SignatureData
		{
			get
			{
				return string.Empty;
			}
		}

		public bool SupportsCardReader
		{
			get
			{
				return false;
			}
		}

		public bool SupportsExplicitInitialization
		{
			get
			{
				return false;
			}
		}

		public bool SupportsPinPad
		{
			get
			{
				return true;
			}
		}

		public bool SupportsSignatureCapture
		{
			get
			{
				return false;
			}
		}

		public bool SupportsUserSelectedTender
		{
			get
			{
				return false;
			}
		}

		public bool UsesCanadianEMV
		{
			get
			{
				return false;
			}
		}

		// 
		private void u0015u0003(double purchaseAmount, double cashBackAmount)
		{
			if (purchaseAmount + cashBackAmount > 9999.99)
			{
				throw new Exception("The total amount of a debit transaction cannot exceed $9999.99.  Please cancel the transaction and modify the amount in the POS.");
			}
		}

		public Verifone1000SE()
		{
			this.u0002 = new Ver1000XClass();
			this.u0005 = new SecureString();
		}

		public bool GetData(TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount)
		{
			return false;
		}

		public bool GetPin(TenderTypes tenderType, TransactionTypes transactionType)
		{
			StringWriter stringWriter = new StringWriter();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			string empty = string.Empty;
			string str = string.Empty;
			double num = this.u0006 + this.u0010;
			string empty1 = string.Empty;
			empty1 = string.Format("getting pin from verifone pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 10;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000e.ToString());
			xmlTextWriter.WriteElementString("Command", "GetPin");
			xmlTextWriter.WriteElementString("Timeout", this.u0007.ToString());
			IntPtr bSTR = Marshal.SecureStringToBSTR(this.u0005);
			xmlTextWriter.WriteElementString("AccountNo", Marshal.PtrToStringUni(bSTR));
			xmlTextWriter.WriteElementString("Amount", string.Format("{0:0.00}", num));
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			Thread.Sleep(this.u000f);
			empty1 = string.Format("sending xml.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			str = this.SendData(empty, this.u0012);
			empty1 = string.Format("got response from pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			if (str.Contains("Cancelled at POS."))
			{
				this.u0014 = PeripheralReturnCode.CancelledAtPOS;
				empty1 = string.Format("transaction was cancelled at POS in GetPin.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				return false;
			}
			if (!str.Contains("Success"))
			{
				XmlDocument xmlDocument = new XmlDocument();
				string str1 = string.Empty;
				try
				{
					xmlDocument.LoadXml(str);
					XmlNode xmlNodes = xmlDocument.SelectSingleNode("/ResponseStream/ReturnCode");
					if (xmlNodes != null)
					{
						str1 = string.Concat("Return Code: ", xmlNodes.InnerText.ToString());
					}
					XmlNode xmlNodes1 = xmlDocument.SelectSingleNode("/ResponseStream/CmdStatus");
					if (xmlNodes1 != null)
					{
						str1 = string.Concat(str1, " CmdStatus: ", xmlNodes1.InnerText.ToString());
					}
				}
				catch
				{
					str1 = "(Could not parse error information from Response.)";
				}
				empty1 = string.Format(string.Concat("received error from pinpad: ", str1), new object[0]);
				Logging.LogData(empty1, this.u0011);
				return false;
			}
			empty1 = string.Format("received successful response, parsing data.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			XmlDocument xmlDocument1 = new XmlDocument();
			xmlDocument1.LoadXml(str);
			XmlNode xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/PINBlock");
			if (xmlNodes2 != null)
			{
				this.u0003 = xmlNodes2.InnerText.ToString();
				if (!PeripheralValidation.ValidatePinBlock(this.u0003))
				{
					empty1 = string.Format("invalid pinblock.", new object[0]);
					Logging.LogData(empty1, this.u0011);
					return false;
				}
			}
			xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/DervdKey");
			if (xmlNodes2 != null)
			{
				this.u0004 = xmlNodes2.InnerText.ToString();
				if (!PeripheralValidation.ValidateDervdKey(this.u0004))
				{
					empty1 = string.Format("invalid dervdkey.", new object[0]);
					Logging.LogData(empty1, this.u0011);
					return false;
				}
			}
			xmlDocument1 = null;
			stringWriter = new StringWriter();
			xmlTextWriter = new XmlTextWriter(stringWriter);
			empty = string.Empty;
			str = string.Empty;
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 10;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000e.ToString());
			xmlTextWriter.WriteElementString("Command", "ResetPinPad");
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			Thread.Sleep(this.u000f);
			str = this.SendData(empty);
			return true;
		}

		public bool GetSignatureData()
		{
			return false;
		}

		public bool GetSwipeData()
		{
			return false;
		}

		public bool Initialize(PinPadConfig config, string logName)
		{
			string empty = string.Empty;
			this.u0011 = logName;
			empty = string.Format("initializing pinpad information.", new object[0]);
			Logging.LogData(empty, this.u0011);
			this.u0008 = config.PinPadConnectionMethod;
			this.u0007 = config.TimeOutValue;
			if (config.ComPort <= 0 || config.ComPort > 254)
			{
				return false;
			}
			this.u000e = config.ComPort;
			this.u000f = config.DelayBeforeSendingDataToDevice;
			this.u0013 = config.CancelDialogueConfig;
			this.u0012 = config.CancelDialogueGetPin;
			return true;
		}

		public string ReceiveData()
		{
			throw new NotImplementedException();
		}

		public bool SendConfig()
		{
			StringWriter stringWriter = new StringWriter();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			string empty = string.Empty;
			string str = string.Empty;
			string empty1 = string.Empty;
			empty1 = string.Format("sending verifone pinpad config info.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			stringWriter = new StringWriter();
			xmlTextWriter = new XmlTextWriter(stringWriter);
			empty = string.Empty;
			str = string.Empty;
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 10;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000e.ToString());
			xmlTextWriter.WriteElementString("Command", "Init");
			xmlTextWriter.WriteElementString("IdlePrompt", "WELCOME!!!");
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			empty1 = string.Format("sending change prompt.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			empty1 = string.Format(empty, new object[0]);
			Logging.LogData(empty1, this.u0011);
			Thread.Sleep(this.u000f);
			str = this.SendData(empty, this.u0013);
			if (str.Contains("Cancelled at POS."))
			{
				this.u0014 = PeripheralReturnCode.CancelledAtPOS;
				empty1 = string.Format("transaction was cancelled at POS in SendConfig.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				return false;
			}
			if (str.Contains("Success"))
			{
				empty1 = string.Format("success sending change prompt.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				return true;
			}
			XmlDocument xmlDocument = new XmlDocument();
			string str1 = string.Empty;
			try
			{
				xmlDocument.LoadXml(str);
				XmlNode xmlNodes = xmlDocument.SelectSingleNode("/ResponseStream/ReturnCode");
				if (xmlNodes != null)
				{
					str1 = string.Concat("Return Code: ", xmlNodes.InnerText.ToString());
				}
				XmlNode xmlNodes1 = xmlDocument.SelectSingleNode("/ResponseStream/CmdStatus");
				if (xmlNodes1 != null)
				{
					str1 = string.Concat(str1, " CmdStatus: ", xmlNodes1.InnerText.ToString());
				}
			}
			catch
			{
				str1 = "(Could not parse error information from Response.)";
			}
			empty1 = string.Format(string.Concat("received error from pinpad: ", str1), new object[0]);
			Logging.LogData(empty1, this.u0011);
			return false;
		}

		public string SendData(string data)
		{
			return this.u0002.ProcessRequest(data, 1);
		}

		public string SendData(string data, bool showDialog)
		{
			short num = 1;
			if (showDialog)
			{
				num = 0;
			}
			return this.u0002.ProcessRequest(data, num);
		}

		public void SetData(PeripheralResponse pr)
		{
			pr.CashBackAmount = this.u0010;
		}

		public void SetEncrytpedInfo(DebitTransaction tran)
		{
			tran.DervdKey = this.u0004;
			tran.PinBlock = this.u0003;
		}
	}
}