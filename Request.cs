using MSEnum;
using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("8296EDA3-CA29-4011-99B4-C0A73707289B")]
	public class Request : IRequest
	{
		private string _acqRefData = string.Empty;

		private string _merchantID = string.Empty;

		private string _creditServers = string.Empty;

		private string _giftServers = string.Empty;

		private string _userID = string.Empty;

		private string _invoiceNumber = string.Empty;

		private string _referenceNumber = string.Empty;

		private string _memo = string.Empty;

		private string _authcode = string.Empty;

		private Transaction.AmountData _amountData;

		private Transaction.BatchInfo _batchInfo;

		private Transaction.PinPadConfig _pinPadConfig;

		private TenderTypes _tenderType = TenderTypes.Unknown;

		private TransactionTypes _transactionType = TransactionTypes.Unknown;

		private bool _override;

		private Transaction.MercuryShieldConfig _mercuryShieldConfig;

		private Transaction.LevelIIData _levelIIData;

		private string _processData = string.Empty;

		private string _token = string.Empty;

		private TokenFrequencies _tokenFrequency;

		private string _terminalName = string.Empty;

		private string _prePaidAccount = string.Empty;

		private string _canadianEMVTerminalID = string.Empty;

		private string _userTraceData = string.Empty;

		private string _merchantLanguage = string.Empty;

		private string _cardType = string.Empty;

		private bool _canadianEMVCreditManualEntry;

		private bool _canadianEMVGratuityPrompt;

		private bool _cancelDialogueTransaction;

		private string _implementationType = string.Empty;

		private string _processingSetName = string.Empty;

		private string _voucherNo = string.Empty;

		private AVSData _addressData;

		private MSEnum.FSACardNotPresented _fsaCardNotPresented;

		public string AcqRefData
		{
			get
			{
				return this._acqRefData;
			}
			set
			{
				this._acqRefData = value;
			}
		}

		public AVSData AddressData
		{
			get
			{
				return this._addressData;
			}
			set
			{
				this._addressData = value;
			}
		}

		public Transaction.AmountData AmountData
		{
			get
			{
				return this._amountData;
			}
			set
			{
				this._amountData = value;
			}
		}

		public string AuthCode
		{
			get
			{
				return this._authcode;
			}
			set
			{
				this._authcode = value;
			}
		}

		public Transaction.BatchInfo BatchInfo
		{
			get
			{
				return this._batchInfo;
			}
			set
			{
				this._batchInfo = value;
			}
		}

		public bool CanadianEMVCreditManualEntry
		{
			get
			{
				return this._canadianEMVCreditManualEntry;
			}
			set
			{
				this._canadianEMVCreditManualEntry = value;
			}
		}

		public bool CanadianEMVGratuityPrompt
		{
			get
			{
				return this._canadianEMVGratuityPrompt;
			}
			set
			{
				this._canadianEMVGratuityPrompt = value;
			}
		}

		public string CanadianEMVTerminalID
		{
			get
			{
				return this._canadianEMVTerminalID;
			}
			set
			{
				this._canadianEMVTerminalID = value;
			}
		}

		public bool CancelDialogueTransaction
		{
			get
			{
				return this._cancelDialogueTransaction;
			}
			set
			{
				this._cancelDialogueTransaction = value;
			}
		}

		public string CardType
		{
			get
			{
				return this._cardType;
			}
			set
			{
				this._cardType = value;
			}
		}

		public string CreditServers
		{
			get
			{
				return this._creditServers;
			}
			set
			{
				this._creditServers = value;
			}
		}

		public MSEnum.FSACardNotPresented FSACardNotPresented
		{
			get
			{
				return this._fsaCardNotPresented;
			}
			set
			{
				this._fsaCardNotPresented = value;
			}
		}

		public string GiftServers
		{
			get
			{
				return this._giftServers;
			}
			set
			{
				this._giftServers = value;
			}
		}

		public string ImplementationType
		{
			get
			{
				return this._implementationType;
			}
			set
			{
				this._implementationType = value;
			}
		}

		public string InvoiceNumber
		{
			get
			{
				return this._invoiceNumber;
			}
			set
			{
				this._invoiceNumber = value;
			}
		}

		public Transaction.LevelIIData LevelIIData
		{
			get
			{
				return this._levelIIData;
			}
			set
			{
				this._levelIIData = value;
			}
		}

		public string Memo
		{
			get
			{
				return this._memo;
			}
			set
			{
				this._memo = value;
			}
		}

		public string MerchantID
		{
			get
			{
				return this._merchantID;
			}
			set
			{
				this._merchantID = value;
			}
		}

		public string MerchantLanguage
		{
			get
			{
				return this._merchantLanguage;
			}
			set
			{
				this._merchantLanguage = value;
			}
		}

		public Transaction.MercuryShieldConfig MercuryShieldConfig
		{
			get
			{
				return this._mercuryShieldConfig;
			}
			set
			{
				this._mercuryShieldConfig = value;
			}
		}

		public bool Override
		{
			get
			{
				return JustDecompileGenerated_get_Override();
			}
			set
			{
				JustDecompileGenerated_set_Override(value);
			}
		}

		public bool JustDecompileGenerated_get_Override()
		{
			return this._override;
		}

		public void JustDecompileGenerated_set_Override(bool value)
		{
			this._override = value;
		}

		public Transaction.PinPadConfig PinPadConfig
		{
			get
			{
				return this._pinPadConfig;
			}
			set
			{
				this._pinPadConfig = value;
			}
		}

		public string PrePaidAccount
		{
			get
			{
				return this._prePaidAccount;
			}
			set
			{
				this._prePaidAccount = value;
			}
		}

		public string ProcessData
		{
			get
			{
				return this._processData;
			}
			set
			{
				this._processData = value;
			}
		}

		public string ProcessingSetName
		{
			get
			{
				return this._processingSetName;
			}
			set
			{
				this._processingSetName = value;
			}
		}

		public string ReferenceNumber
		{
			get
			{
				return this._referenceNumber;
			}
			set
			{
				this._referenceNumber = value;
			}
		}

		public TenderTypes TenderType
		{
			get
			{
				return this._tenderType;
			}
			set
			{
				this._tenderType = value;
			}
		}

		public string TerminalName
		{
			get
			{
				return this._terminalName;
			}
			set
			{
				this._terminalName = value;
			}
		}

		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				this._token = value;
			}
		}

		public TokenFrequencies TokenFrequency
		{
			get
			{
				return this._tokenFrequency;
			}
			set
			{
				this._tokenFrequency = value;
			}
		}

		public TransactionTypes TransactionType
		{
			get
			{
				return this._transactionType;
			}
			set
			{
				this._transactionType = value;
			}
		}

		public string UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				this._userID = value;
			}
		}

		public string UserTraceData
		{
			get
			{
				return this._userTraceData;
			}
			set
			{
				this._userTraceData = value;
			}
		}

		public string VoucherNo
		{
			get
			{
				return this._voucherNo;
			}
			set
			{
				this._voucherNo = value;
			}
		}

		public string Xml
		{
			set
			{
				if (!this.ValidXML(value))
				{
					throw new Exception("An attempt was made to assign XML with card holder data included.  Please remove card holder data and try again.");
				}
			}
		}

		public Request()
		{
			this._amountData = new Transaction.AmountData();
			this._batchInfo = new Transaction.BatchInfo();
			this._mercuryShieldConfig = new Transaction.MercuryShieldConfig();
			this._levelIIData = new Transaction.LevelIIData();
			this._addressData = new AVSData();
			this._pinPadConfig = new Transaction.PinPadConfig();
		}

		private bool ValidXML(string xml)
		{
			bool flag;
			string empty = string.Empty;
			if (string.IsNullOrEmpty(xml))
			{
				return true;
			}
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNodes = null;
			try
			{
				xml = xml.Replace("&", "&amp;");
				xmlDocument.LoadXml(xml);
				xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Account/Track1");
				if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
				{
					xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Account/Track2");
					if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
					{
						xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/PIN/PINBlock");
						if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
						{
							xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/PIN/DervdKey");
							if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
							{
								xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Account/AcctNo");
								if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
								{
									xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Account/ExpDate");
									if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
									{
										xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/AVS/Address");
										if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
										{
											xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/AVS/Zip");
											if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
											{
												xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/CVVData");
												if (xmlNodes == null || string.IsNullOrEmpty(xmlNodes.InnerText.ToString()))
												{
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/MerchantID");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.MerchantID = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/OperatorID");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.UserID = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TranType");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.TenderType = (string.IsNullOrEmpty(empty) ? TenderTypes.Unknown : EnumHelper.GetTenderType(empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TranCode");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.TransactionType = (string.IsNullOrEmpty(empty) ? TransactionTypes.Unknown : EnumHelper.GetTransactionType(this.TenderType, empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/InvoiceNo");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.InvoiceNumber = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/RefNo");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.ReferenceNumber = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Amount/Purchase");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.AmountData.PurchaseAmount = (string.IsNullOrEmpty(empty) ? 0 : double.Parse(empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Amount/Authorize");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.AmountData.AuthorizeAmount = (string.IsNullOrEmpty(empty) ? 0 : double.Parse(empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Amount/Tax");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.LevelIIData.TaxAmount = (string.IsNullOrEmpty(empty) ? 0 : double.Parse(empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TranInfo/CustomerCode");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.LevelIIData.CustomerCode = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Amount/Gratuity");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.AmountData.GratuityAmount = (string.IsNullOrEmpty(empty) ? 0 : double.Parse(empty));
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TranInfo/AuthCode");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.AuthCode = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TranInfo/AcqRefData");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.AcqRefData = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/Memo");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.Memo = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/TerminalName");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.TerminalName = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													xmlNodes = xmlDocument.SelectSingleNode("TStream/Transaction/MerchantLanguage");
													if (xmlNodes != null)
													{
														empty = xmlNodes.InnerText.ToString();
														this.MerchantLanguage = (string.IsNullOrEmpty(empty) ? string.Empty : empty);
													}
													return true;
												}
												else
												{
													flag = false;
												}
											}
											else
											{
												flag = false;
											}
										}
										else
										{
											flag = false;
										}
									}
									else
									{
										flag = false;
									}
								}
								else
								{
									flag = false;
								}
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}
	}
}