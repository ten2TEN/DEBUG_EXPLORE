using DSITransaction;
using MPS.POS.Utils;
using System;
using System.Reflection;
using System.Security;

namespace Transaction
{
	public class CanadianEMVTransaction : Transaction
	{
		private DSIEMVTransaction _dsiEMVTransaction;

		private string _hostOrIP = string.Empty;

		private string _ipPort = string.Empty;

		private string _terminalID = string.Empty;

		private string _merchantLanguage = string.Empty;

		private Transaction.PinPadConfig _pinPadConfig;

		private string _userTraceData = string.Empty;

		private string _invoiceNumber = string.Empty;

		private string _referenceNumber = string.Empty;

		public DSIEMVTransaction DSIEmvTransaction
		{
			get
			{
				return this._dsiEMVTransaction;
			}
			set
			{
				this._dsiEMVTransaction = value;
			}
		}

		public string HostOrIP
		{
			get
			{
				return this._hostOrIP;
			}
			set
			{
				this._hostOrIP = value;
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

		public string IPPort
		{
			get
			{
				return this._ipPort;
			}
			set
			{
				this._ipPort = value;
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

		public string TerminalID
		{
			get
			{
				return this._terminalID;
			}
			set
			{
				this._terminalID = value;
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

		public CanadianEMVTransaction()
		{
			this._dsiEMVTransaction = new DSIEMVTransaction();
			this._pinPadConfig = new Transaction.PinPadConfig();
		}

		private string CheckAccountMasking(string returnedAccount)
		{
			string str = returnedAccount;
			if (returnedAccount.Length > 0 && !returnedAccount.Contains("*") && !returnedAccount.ToLower().Contains("x"))
			{
				long num = (long)0;
				if (returnedAccount.Length > 4 && long.TryParse(returnedAccount, out num))
				{
					str = string.Concat("************", str.Substring(returnedAccount.Length - 1, 4));
				}
			}
			return str;
		}

		public override Response ProcessTransaction()
		{
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				empty = string.Format("Validating Transaction Specific Parameters", new object[0]);
				Logging.LogData(empty, base.LogName);
				this.ValidateTransactionSpecificParameters();
				empty = string.Format("Setting global properties", new object[0]);
				Logging.LogData(empty, base.LogName);
				this.DSIEmvTransaction.UserTraceData = string.Concat(this.UserTraceData, " MPSMS ", Assembly.GetExecutingAssembly().GetName().Version);
				empty = string.Format("Set transaction specific properties", new object[0]);
				Logging.LogData(empty, base.LogName);
				this.SetValues();
				empty = string.Format("Getting XML for transaction", new object[0]);
				Logging.LogData(empty, base.LogName);
				if (!this.DSIEmvTransaction.GetXML())
				{
					response.TextResponse = string.Concat("Error converting properties to XML.  A property was not set correctly:  ", this.DSIEmvTransaction.ErrText.ToString());
					response.CmdStatus = "Error";
					response.ResponseOrigin = "Client";
				}
				else
				{
					empty = string.Format("Attempting to process a {0} for user: {1}", this.ToString(), base.UserID);
					Logging.LogData(empty, base.LogName);
					if (!this.DSIEmvTransaction.Process_Transaction())
					{
						response.TextResponse = "The transaction was not processed successfully by DSIEMVClient.";
						response.CmdStatus = "Error";
						response.ResponseOrigin = "Client";
					}
					else
					{
						response.ResponseOrigin = this.DSIEmvTransaction.ResponseOrigin;
						response.ReturnCode = this.DSIEmvTransaction.ReturnCode;
						response.CmdStatus = this.DSIEmvTransaction.Status;
						response.TextResponse = this.DSIEmvTransaction.TextResponse;
						response.UserTraceData = this.DSIEmvTransaction.UserTraceData;
						response.SequenceNo = this.DSIEmvTransaction.SequenceNo;
						response.ReferenceNumber = this.DSIEmvTransaction.RefNo;
						response.MerchantID = this.DSIEmvTransaction.MerchantID;
						response.CanadianEMVTerminalID = this.DSIEmvTransaction.TerminalID;
						response.CardType = this.DSIEmvTransaction.CardType;
						response.TranCode = this.DSIEmvTransaction.TranCode;
						response.AuthCode = this.DSIEmvTransaction.AuthCode;
						response.CaptureStatus = this.DSIEmvTransaction.CaptureStatus;
						response.Account = this.CheckAccountMasking(this.DSIEmvTransaction.MaskedAcctNo);
						response.InvoiceNumber = this.DSIEmvTransaction.InvoiceNo;
						response.OperatorID = this.DSIEmvTransaction.OperatorID;
						response.TranDate = this.DSIEmvTransaction.TranDate;
						response.TranTime = this.DSIEmvTransaction.TranTime;
						response.AcqRefData = this.DSIEmvTransaction.AcqRefData;
						response.PostProcess = this.DSIEmvTransaction.PostProcess;
						response.AvsResult = this.DSIEmvTransaction.AVSResult;
						response.CvvResult = this.DSIEmvTransaction.CVVResult;
						response.AmountData.PurchaseAmount = (double)((double)this.DSIEmvTransaction.Purchase);
						response.AmountData.AuthorizeAmount = (double)((double)this.DSIEmvTransaction.Authorize);
						response.AmountData.GratuityAmount = (double)((double)this.DSIEmvTransaction.Gratuity);
						response.PrintData = this.DSIEmvTransaction.PrintData;
						response.BatchInfo.BatchNo = (!string.IsNullOrEmpty(this.DSIEmvTransaction.BatchNo) ? int.Parse(this.DSIEmvTransaction.BatchNo) : 0);
						response.BatchInfo.BatchItemCount = this.DSIEmvTransaction.BatchItemCount;
						response.BatchInfo.NetBatchTotal = (double)((double)this.DSIEmvTransaction.NetBatchTotal);
						response.BatchInfo.CreditPurchaseCount = this.DSIEmvTransaction.CreditPurchaseCount;
						response.BatchInfo.CreditPurchaseAmount = (double)((double)this.DSIEmvTransaction.CreditPurchaseAmount);
						response.BatchInfo.CreditReturnCount = this.DSIEmvTransaction.CreditReturnCount;
						response.BatchInfo.CreditReturnAmount = (double)((double)this.DSIEmvTransaction.CreditReturnAmount);
						response.BatchInfo.DebitPurchaseCount = this.DSIEmvTransaction.DebitPurchaseCount;
						response.BatchInfo.DebitPurchaseAmount = (double)((double)this.DSIEmvTransaction.DebitPurchaseAmount);
						response.BatchInfo.DebitReturnCount = this.DSIEmvTransaction.DebitReturnCount;
						response.BatchInfo.DebitReturnAmount = (double)((double)this.DSIEmvTransaction.DebitReturnAmount);
						response.BatchInfo.ControlNo = this.DSIEmvTransaction.ControlNo;
						response.ProductName = this.DSIEmvTransaction.ProductName;
						response.ProductClass = this.DSIEmvTransaction.ProductClass;
						response.Provider = this.DSIEmvTransaction.Provider;
						response.ProductVersion = this.DSIEmvTransaction.ProductVersion;
						response.Track2 = this.DSIEmvTransaction.Track2.Copy();
						response.XmlResponse = Utils.MaskTransactionData(this.DSIEmvTransaction.Response);
						this.SetTransactionSpecificResponseInfo(response);
					}
				}
				empty = string.Format("Text Response from attempt to process transaction:{0} for userid:{1}.", response.TextResponse, base.UserID);
				Logging.LogData(empty, base.LogName);
				empty = string.Format("Cmd Status from attempt to process transaction:{0} for userid:{1}.", response.CmdStatus, base.UserID);
				Logging.LogData(empty, base.LogName);
				empty = string.Format("Response Origin from attempt to process transaction:{0} for userid:{1}.", response.ResponseOrigin, base.UserID);
				Logging.LogData(empty, base.LogName);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				response.CmdStatus = "Error";
				response.ResponseOrigin = "Client";
				response.TextResponse = exception.Message;
			}
			return response;
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.UserID = request.UserID;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			this.HostOrIP = this._pinPadConfig.HostOrIP;
			this.IPPort = this._pinPadConfig.IPPort;
			base.MerchantID = this._pinPadConfig.MerchantID;
			this.TerminalID = request.CanadianEMVTerminalID;
			this.MerchantLanguage = request.MerchantLanguage;
			this.UserTraceData = request.UserTraceData;
		}

		protected override void SetTransactionSpecificResponseInfo(Response response)
		{
			base.SetTransactionSpecificResponseInfo(response);
		}

		protected override void SetValues()
		{
			this.DSIEmvTransaction.ComPort = this._pinPadConfig.ComPort.ToString();
			if (this._pinPadConfig.PinPadType == PinPadType.VerifoneVX810CAEMVGlobal1)
			{
				this.DSIEmvTransaction.PadType = DSIEMVTransaction.eEMVPadType.Global1;
			}
			this.DSIEmvTransaction.SequenceNo = this._pinPadConfig.SequenceNumber;
			this.DSIEmvTransaction.HostOrIP = this._hostOrIP;
			this.DSIEmvTransaction.IpPort = this._ipPort;
			this.DSIEmvTransaction.OperatorID = base.UserID;
			this.DSIEmvTransaction.TerminalID = this._terminalID;
			this.DSIEmvTransaction.MerchantID = base.MerchantID;
			this.DSIEmvTransaction.MerchantLanguage = this._merchantLanguage;
			this.DSIEmvTransaction.InvoiceNo = this._invoiceNumber;
			this.DSIEmvTransaction.RefNo = this._referenceNumber;
			this.DSIEmvTransaction.LogName = base.LogName;
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			if (string.IsNullOrEmpty(this.MerchantLanguage))
			{
				throw new Exception(StringsReader.GetText("NoMerchantLanguageProvidedError"));
			}
			if (string.IsNullOrEmpty(this.PinPadConfig.MerchantID))
			{
				throw new Exception(StringsReader.GetText("NoMerchantIDProvidedError"));
			}
			if (this.PinPadConfig.PinPadType == PinPadType.Unknown)
			{
				throw new Exception(StringsReader.GetText("PinPadTypeError"));
			}
			if (string.IsNullOrEmpty(this.PinPadConfig.SequenceNumber))
			{
				throw new Exception(StringsReader.GetText("NoSequenceNumberProvidedError"));
			}
			if (this._pinPadConfig.ComPort <= 0 || this._pinPadConfig.ComPort > 254)
			{
				throw new Exception(StringsReader.GetText("ComPortError"));
			}
		}
	}
}