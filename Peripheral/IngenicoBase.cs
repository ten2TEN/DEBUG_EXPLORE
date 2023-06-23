using INGENICORBAXLib;
using MPS.POS.Utils;
using MSEnum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Xml;
using Transaction;

namespace Peripheral
{
	public class IngenicoBase
	{
		// 
		private const double u0001 = 9999.99;

		// 
		private IngenicoRBAX u0002;

		// 
		private string u0003 = string.Empty;

		// 
		private string u0004 = string.Empty;

		// 
		private SecureString u0005;

		// 
		private SecureString u0006;

		// 
		private double u0007;

		// 
		private int u0008 = 30;

		// 
		private PinPadConnectionMethod u000e = PinPadConnectionMethod.Unknown;

		// 
		private int u000f;

		// 
		private double u0010;

		// 
		private string u0011 = string.Empty;

		// 
		private double u0012;

		// 
		private double u0013;

		// 
		private TenderTypes u0014 = TenderTypes.Unknown;

		// 
		private TenderTypes[] u0015 = new TenderTypes[] { TenderTypes.Credit, TenderTypes.Debit, TenderTypes.EBT, TenderTypes.PrePaid };

		// 
		private string u0016 = string.Empty;

		// 
		private PeripheralReturnCode u0017 = PeripheralReturnCode.Unknown;

		// 
		private int u0018;

		// 
		private bool u0019;

		// 
		private bool u001a;

		// 
		private bool u001b;

		// 
		private bool u001c;

		// 
		private bool u001d = true;

		public SecureString Account
		{
			set
			{
				this.u0005 = value;
			}
		}

		public double CashBackAmount
		{
			get
			{
				return JustDecompileGenerated_get_CashBackAmount();
			}
			set
			{
				JustDecompileGenerated_set_CashBackAmount(value);
			}
		}

		public double JustDecompileGenerated_get_CashBackAmount()
		{
			return this.u0010;
		}

		public void JustDecompileGenerated_set_CashBackAmount(double value)
		{
			this.u0010 = value;
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
				this.u0007 = value;
			}
		}

		public PeripheralReturnCode ReturnCode
		{
			get
			{
				return this.u0017;
			}
			set
			{
				this.u0017 = value;
			}
		}

		public string SignatureData
		{
			get
			{
				return JustDecompileGenerated_get_SignatureData();
			}
			set
			{
				JustDecompileGenerated_set_SignatureData(value);
			}
		}

		public string JustDecompileGenerated_get_SignatureData()
		{
			return this.u0016;
		}

		public void JustDecompileGenerated_set_SignatureData(string value)
		{
			this.u0016 = value;
		}

		public TenderTypes TenderType
		{
			get
			{
				return this.u0014;
			}
		}

		public IngenicoBase()
		{
			this.u0002 = new IngenicoRBAXClass();
			this.u0005 = new SecureString();
		}

		public bool GetData(TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount)
		{
			bool flag = true;
			StringWriter stringWriter = new StringWriter();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			string empty = string.Empty;
			string str = string.Empty;
			string empty1 = string.Empty;
			empty1 = string.Format("getting transaction data from ingenico pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			stringWriter = new StringWriter();
			xmlTextWriter = new XmlTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented,
				Indentation = 10
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000f.ToString());
			xmlTextWriter.WriteElementString("Command", "DoTransaction");
			xmlTextWriter.WriteElementString("Timeout", this.u0008.ToString());
			if ((int)this.u0015.Length == 1 && this.u0015[0] != TenderTypes.EBT)
			{
				xmlTextWriter.WriteElementString("TranType", this.u0015[0].ToString());
			}
			xmlTextWriter.WriteStartElement("Amount");
			xmlTextWriter.WriteElementString("Purchase", string.Format("{0:0.00}", purchaseAmount));
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			empty1 = string.Format("sending xml.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			str = this.SendData(empty, this.u001a);
			empty1 = string.Format("got response from pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			if (str.Contains("Cancelled at POS."))
			{
				this.u0017 = PeripheralReturnCode.CancelledAtPOS;
				empty1 = string.Format("transaction was cancelled at POS in GetData.", new object[0]);
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
						this.u0017 = EnumConverter.DataCapReturnCodeToEnum(xmlNodes.InnerText.ToString());
						str1 = string.Concat("Return Code: ", xmlNodes.InnerText.ToString(), " ", this.u0017.ToString());
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
				flag = false;
			}
			else
			{
				this.u0017 = PeripheralReturnCode.Ok;
				empty1 = string.Format("received successful response, parsing data.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				XmlDocument xmlDocument1 = new XmlDocument();
				xmlDocument1.LoadXml(str);
				string empty2 = string.Empty;
				XmlNode xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/TranType");
				if (xmlNodes2 != null)
				{
					empty2 = xmlNodes2.InnerText.ToString().ToUpper().Trim();
					if (empty2 == "CREDIT")
					{
						this.u0014 = TenderTypes.Credit;
					}
					else if (empty2 == "DEBIT")
					{
						this.u0014 = TenderTypes.Debit;
					}
					else if (empty2 == "PREPAID")
					{
						this.u0014 = TenderTypes.PrePaid;
					}
					else if (empty2 == "EBTFOOD")
					{
						this.u0014 = TenderTypes.EBT;
					}
					else if (empty2 == "EBTCASH")
					{
						this.u0014 = TenderTypes.EBT;
					}
				}
				xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/Track2");
				if (xmlNodes2 != null)
				{
					this.u0006 = new SecureString();
					this.u0006.AppendChar(';');
					string str2 = xmlNodes2.InnerText.ToString();
					for (int i = 0; i < str2.Length; i++)
					{
						char chr = str2[i];
						this.u0006.AppendChar(chr);
					}
					this.u0006.AppendChar('?');
				}
				xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/PINBlock");
				if (xmlNodes2 != null)
				{
					this.u0003 = xmlNodes2.InnerText.ToString();
					if (!PeripheralValidation.ValidatePinBlock(this.u0003))
					{
						empty1 = string.Format("invalid pinblock.", new object[0]);
						Logging.LogData(empty1, this.u0011);
						this.u0017 = PeripheralReturnCode.FailedToParseXML;
						flag = false;
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
						this.u0017 = PeripheralReturnCode.FailedToParseXML;
						flag = false;
					}
				}
				xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/Amount/Purchase");
				if (xmlNodes2 != null)
				{
					this.u0007 = double.Parse(xmlNodes2.InnerText.ToString());
				}
				xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/Amount/CashBack");
				if (xmlNodes2 != null)
				{
					this.u0010 = double.Parse(xmlNodes2.InnerText.ToString());
				}
				xmlDocument1 = null;
			}
			return flag;
		}

		public bool GetPin(TenderTypes tenderType, TransactionTypes transactionType)
		{
			StringWriter stringWriter = new StringWriter();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			string empty = string.Empty;
			string str = string.Empty;
			string empty1 = string.Empty;
			empty1 = string.Format("getting pin from ingenico pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 10;
			stringWriter = new StringWriter();
			xmlTextWriter = new XmlTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented,
				Indentation = 10
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000f.ToString());
			xmlTextWriter.WriteElementString("Command", "DoTransaction");
			xmlTextWriter.WriteElementString("Timeout", this.u0008.ToString());
			IntPtr bSTR = Marshal.SecureStringToBSTR(this.u0005);
			xmlTextWriter.WriteElementString("AccountNo", Marshal.PtrToStringUni(bSTR));
			if (tenderType != TenderTypes.EBT)
			{
				xmlTextWriter.WriteElementString("TranType", "Debit");
			}
			else if (transactionType == TransactionTypes.CashBalance || transactionType == TransactionTypes.CashSale)
			{
				xmlTextWriter.WriteElementString("TranType", "EBTCash");
			}
			else
			{
				xmlTextWriter.WriteElementString("TranType", "EBTFood");
			}
			xmlTextWriter.WriteStartElement("Amount");
			xmlTextWriter.WriteElementString("Purchase", string.Format("{0:0.00}", this.u0007));
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			Thread.Sleep(this.u0018);
			empty1 = string.Format("sending xml.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			str = this.SendData(empty, this.u001b);
			empty1 = string.Format("got response from pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			if (str.Contains("Cancelled at POS."))
			{
				this.u0003 = string.Empty;
				this.u0004 = string.Empty;
				this.u0010 = 0;
				this.u0017 = PeripheralReturnCode.CancelledAtPOS;
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
						this.u0017 = EnumConverter.DataCapReturnCodeToEnum(xmlNodes.InnerText.ToString());
						str1 = string.Concat("Return Code: ", xmlNodes.InnerText.ToString(), " ", this.u0017.ToString());
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
			this.u0017 = PeripheralReturnCode.Ok;
			empty1 = string.Format("received successful response, parsing data.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			XmlDocument xmlDocument1 = new XmlDocument();
			xmlDocument1.LoadXml(str);
			XmlNode xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/PINBlock");
			if (xmlNodes2 != null)
			{
				this.u0003 = xmlNodes2.InnerText.ToString();
			}
			xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/DervdKey");
			if (xmlNodes2 != null)
			{
				this.u0004 = xmlNodes2.InnerText.ToString();
			}
			xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/Amount/CashBack");
			if (xmlNodes2 != null)
			{
				this.u0010 = double.Parse(xmlNodes2.InnerText.ToString());
			}
			else if (tenderType == TenderTypes.EBT && transactionType == TransactionTypes.CashSale && this.u0013 > 0)
			{
				this.u0010 = 0;
			}
			xmlDocument1 = null;
			return true;
		}

		public bool GetSignatureData()
		{
			StringWriter stringWriter = new StringWriter();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			string empty = string.Empty;
			string str = string.Empty;
			string empty1 = string.Empty;
			empty1 = string.Format("getting signature from ingenico pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 10;
			stringWriter = new StringWriter();
			xmlTextWriter = new XmlTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented,
				Indentation = 10
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RequestStream");
			xmlTextWriter.WriteElementString("ComPort", this.u000f.ToString());
			xmlTextWriter.WriteElementString("Command", "GetSignature");
			xmlTextWriter.WriteElementString("Timeout", this.u0008.ToString());
			xmlTextWriter.WriteEndElement();
			empty = stringWriter.ToString();
			stringWriter.Close();
			xmlTextWriter.Close();
			empty1 = string.Format("sending xml.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			str = this.SendData(empty, this.u001c);
			empty1 = string.Format("got response from pinpad.", new object[0]);
			Logging.LogData(empty1, this.u0011);
			if (str.Contains("Cancelled at POS."))
			{
				this.u0016 = string.Empty;
				this.u0017 = PeripheralReturnCode.CancelledAtPOS;
				empty1 = string.Format("transaction was cancelled at POS in GetSignature.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				return false;
			}
			if (str.Contains("Success"))
			{
				this.u0017 = PeripheralReturnCode.Ok;
				empty1 = string.Format("received successful response, parsing data.", new object[0]);
				Logging.LogData(empty1, this.u0011);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(str);
				XmlNode xmlNodes = xmlDocument.SelectSingleNode("/ResponseStream/Signature");
				if (xmlNodes != null)
				{
					this.u0016 = xmlNodes.InnerText.ToString();
				}
				xmlDocument = null;
				return true;
			}
			XmlDocument xmlDocument1 = new XmlDocument();
			string str1 = string.Empty;
			try
			{
				xmlDocument1.LoadXml(str);
				XmlNode xmlNodes1 = xmlDocument1.SelectSingleNode("/ResponseStream/ReturnCode");
				if (xmlNodes1 != null)
				{
					this.u0017 = EnumConverter.DataCapReturnCodeToEnum(xmlNodes1.InnerText.ToString());
					str1 = string.Concat("Return Code: ", xmlNodes1.InnerText.ToString(), " ", this.u0017.ToString());
				}
				XmlNode xmlNodes2 = xmlDocument1.SelectSingleNode("/ResponseStream/CmdStatus");
				if (xmlNodes2 != null)
				{
					str1 = string.Concat(str1, " CmdStatus: ", xmlNodes2.InnerText.ToString());
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

		public bool GetSwipeData()
		{
			return false;
		}

		public bool Initialize(PinPadConfig config, string logName)
		{
			bool flag;
			string empty = string.Empty;
			this.u0011 = logName;
			empty = string.Format("initializing pinpad information.", new object[0]);
			Logging.LogData(empty, this.u0011);
			this.u000e = config.PinPadConnectionMethod;
			this.u0008 = config.TimeOutValue;
			if (config.ComPort <= 0 || config.ComPort > 254)
			{
				return false;
			}
			this.u000f = config.ComPort;
			try
			{
				if (config.SupportedTransactionsString.Length > 0)
				{
					char[] chrArray = new char[] { ',' };
					string[] strArrays = config.SupportedTransactionsString.Split(chrArray);
					List<TenderTypes> tenderTypes = new List<TenderTypes>();
					string[] strArrays1 = strArrays;
					for (int i = 0; i < (int)strArrays1.Length; i++)
					{
						string lower = strArrays1[i].Trim().ToLower();
						string str = lower;
						if (lower != null)
						{
							if (str == "credit")
							{
								if (!tenderTypes.Contains(TenderTypes.Credit))
								{
									tenderTypes.Add(TenderTypes.Credit);
								}
							}
							else if (str == "debit")
							{
								if (!tenderTypes.Contains(TenderTypes.Debit))
								{
									tenderTypes.Add(TenderTypes.Debit);
								}
							}
							else if (str != "ebt")
							{
								if (str == "prepaid")
								{
									if (!tenderTypes.Contains(TenderTypes.PrePaid))
									{
										tenderTypes.Add(TenderTypes.PrePaid);
									}
								}
							}
							else if (!tenderTypes.Contains(TenderTypes.EBT))
							{
								tenderTypes.Add(TenderTypes.EBT);
							}
						}
					}
					if (tenderTypes.Count > 0)
					{
						config.SupportedTransactions = tenderTypes.ToArray();
					}
				}
				if (config.SupportedTransactions != null && (int)config.SupportedTransactions.Length > 0)
				{
					this.u0015 = config.SupportedTransactions;
				}
				this.u0012 = config.DebitMaxCashBack;
				this.u0013 = config.EBTMaxCashBack;
				this.u0018 = config.DelayBeforeSendingDataToDevice;
				this.u0019 = config.CancelDialogueConfig;
				this.u001a = config.CancelDialogueGetData;
				this.u001b = config.CancelDialogueGetPin;
				this.u001c = config.CancelDialogueGetSignature;
				this.u001d = config.InitializePinPad;
				return true;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.u0017 = PeripheralReturnCode.TranTypeNotEnabled;
				empty = string.Format(string.Concat("invalid SupportedTransactionsString - generated exception: ", exception.Message), new object[0]);
				Logging.LogData(empty, this.u0011);
				flag = false;
			}
			return flag;
		}

		public string ReceiveData()
		{
			throw new NotImplementedException();
		}

		public bool SendConfig()
		{
			bool flag = false;
			string empty = string.Empty;
			if (!this.u001d)
			{
				empty = string.Format("Configuration setting specified skipping PinPad initialization.", new object[0]);
				Logging.LogData(empty, this.u0011);
				flag = true;
			}
			else
			{
				StringWriter stringWriter = new StringWriter();
				XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
				string str = string.Empty;
				string empty1 = string.Empty;
				empty = string.Format("sending ingenico pinpad config info.", new object[0]);
				Logging.LogData(empty, this.u0011);
				xmlTextWriter.Formatting = Formatting.Indented;
				xmlTextWriter.Indentation = 10;
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteStartElement("RequestStream");
				xmlTextWriter.WriteElementString("ComPort", this.u000f.ToString());
				xmlTextWriter.WriteElementString("Command", "Init");
				int num = 1;
				if (this.u0015.Contains<TenderTypes>(TenderTypes.Credit))
				{
					xmlTextWriter.WriteElementString(string.Format("TranType{0}", num), "Credit");
					num++;
				}
				if (this.u0015.Contains<TenderTypes>(TenderTypes.Debit))
				{
					xmlTextWriter.WriteElementString(string.Format("TranType{0}", num), "Debit");
					num++;
				}
				if (this.u0015.Contains<TenderTypes>(TenderTypes.EBT))
				{
					xmlTextWriter.WriteElementString(string.Format("TranType{0}", num), "EBTFood");
					num++;
					xmlTextWriter.WriteElementString(string.Format("TranType{0}", num), "EBTCash");
					num++;
				}
				if (this.u0015.Contains<TenderTypes>(TenderTypes.PrePaid))
				{
					xmlTextWriter.WriteElementString(string.Format("TranType{0}", num), "PrePaid");
				}
				xmlTextWriter.WriteElementString("DebitMaxCashBack", string.Format("{0:0.00}", this.u0012));
				xmlTextWriter.WriteElementString("EBTMaxCashBack", string.Format("{0:0.00}", this.u0013));
				xmlTextWriter.WriteElementString("PINTimeout", this.u0008.ToString());
				xmlTextWriter.WriteEndElement();
				str = stringWriter.ToString();
				stringWriter.Close();
				xmlTextWriter.Close();
				empty = string.Format("sending INIT.", new object[0]);
				Logging.LogData(empty, this.u0011);
				empty = string.Format(str, new object[0]);
				Logging.LogData(empty, this.u0011);
				empty1 = this.SendData(str, this.u0019);
				if (empty1.Contains("Cancelled at POS."))
				{
					this.u0017 = PeripheralReturnCode.CancelledAtPOS;
					empty = string.Format("transaction was cancelled at POS in SendConfig.", new object[0]);
					Logging.LogData(empty, this.u0011);
					flag = false;
				}
				else if (!empty1.Contains("Success"))
				{
					XmlDocument xmlDocument = new XmlDocument();
					string str1 = string.Empty;
					try
					{
						xmlDocument.LoadXml(empty1);
						XmlNode xmlNodes = xmlDocument.SelectSingleNode("/ResponseStream/ReturnCode");
						if (xmlNodes != null)
						{
							this.u0017 = EnumConverter.DataCapReturnCodeToEnum(xmlNodes.InnerText.ToString());
							str1 = string.Concat("Return Code: ", xmlNodes.InnerText.ToString(), " ", this.u0017.ToString());
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
					empty = string.Format(string.Concat("received error from pinpad: ", str1), new object[0]);
					Logging.LogData(empty, this.u0011);
					flag = false;
				}
				else
				{
					this.u0017 = PeripheralReturnCode.Ok;
					empty = string.Format("success sending change prompt.", new object[0]);
					Logging.LogData(empty, this.u0011);
					flag = true;
				}
			}
			return flag;
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

		public void SetAccountInfo(CardTransaction tran)
		{
			tran.SetTrack2(this.u0006);
			tran.SetAccountType(AccountType.Track2);
		}

		public void SetData(PeripheralResponse pr)
		{
			SecureString secureString;
			pr.DervdKey = this.u0004;
			pr.PinBlock = this.u0003;
			PeripheralResponse peripheralResponse = pr;
			if (this.u0006 == null)
			{
				secureString = null;
			}
			else
			{
				secureString = this.u0006.Copy();
			}
			peripheralResponse.TrackData = secureString;
			pr.TenderType = this.u0014;
			pr.CashBackAmount = this.u0010;
			pr.PurchaseAmount = this.u0007;
			pr.ReturnCode = this.u0017;
		}

		public void SetEncrytpedInfo(DebitTransaction tran)
		{
			tran.DervdKey = this.u0004;
			tran.PinBlock = this.u0003;
		}
	}
}