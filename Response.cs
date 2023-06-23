using MPS.POS.Utils;
using MSEnum;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("A071B5F8-BD45-4e39-90C3-E49A78665BDA")]
	public class Response : IResponse
	{
		private const string _CLASS = "Response.cs";

		private string _responseOrigin = string.Empty;

		private string _returnCode = string.Empty;

		private string _cmdStatus = string.Empty;

		private string _textResponse = string.Empty;

		private string _userTraceData = string.Empty;

		private string _sequenceNo = string.Empty;

		private string _merchantID = string.Empty;

		private string _terminalID = string.Empty;

		private string _account = string.Empty;

		private string _expDate = string.Empty;

		private string _cardType = string.Empty;

		private string _selection = string.Empty;

		private string _tranCode = string.Empty;

		private string _authCode = string.Empty;

		private string _avsResult = string.Empty;

		private string _cvvResult = string.Empty;

		private string _voucherNo = string.Empty;

		private string _captureStatus = string.Empty;

		private string _referenceNumber = string.Empty;

		private string _invoiceNumber = string.Empty;

		private string _operatorID = string.Empty;

		private string _memo = string.Empty;

		private string _acqRefData = string.Empty;

		private string _recordNo = string.Empty;

		private string _issueCurrency = string.Empty;

		private string _issueCurrencyPreviousBalance = string.Empty;

		private string _issueCurrencyEndingBalance = string.Empty;

		private string _exchangeRate = string.Empty;

		private string _prePaidExp = string.Empty;

		private string _language = string.Empty;

		private string _bankRespCode = string.Empty;

		private string _isoRespCode = string.Empty;

		private string _tranDate = string.Empty;

		private string _tranTime = string.Empty;

		private string _itemAmount1 = string.Empty;

		private string _itemAmount2 = string.Empty;

		private Transaction.BatchInfo _batchInfo;

		private Transaction.AmountData _amountData;

		private string _xmlresponse = string.Empty;

		private SecureString _fullAccount;

		private string _fullExpirationDate = string.Empty;

		private string _printData = string.Empty;

		private SecureString _track2;

		private string _cardholderName = string.Empty;

		private AccountType _entryMode = AccountType.Unknown;

		private string _processData = string.Empty;

		private string _signatureData = string.Empty;

		private string _token = string.Empty;

		private string _prePaidAccount = string.Empty;

		private string _canadianEMVTerminalID = string.Empty;

		private string _postProcess = string.Empty;

		private string _productName = string.Empty;

		private string _productClass = string.Empty;

		private string _productVersion = string.Empty;

		private string _provider = string.Empty;

		private string _cardUsage = string.Empty;

		private TenderTypes _tenderTypeUsed = TenderTypes.Unknown;

		private TransactionTypes _transactionTypesUsed = TransactionTypes.Unknown;

		public string Account
		{
			get
			{
				return this._account;
			}
			set
			{
				this._account = value;
			}
		}

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
				return this._authCode;
			}
			set
			{
				this._authCode = value;
			}
		}

		public string AvsResult
		{
			get
			{
				return this._avsResult;
			}
			set
			{
				this._avsResult = value;
			}
		}

		public string BankRespCode
		{
			get
			{
				return this._bankRespCode;
			}
			set
			{
				this._bankRespCode = value;
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

		public string CaptureStatus
		{
			get
			{
				return this._captureStatus;
			}
			set
			{
				this._captureStatus = value;
			}
		}

		public string CardholderName
		{
			get
			{
				return this._cardholderName;
			}
			set
			{
				this._cardholderName = value;
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

		public string CardUsage
		{
			get
			{
				return this._cardUsage;
			}
			set
			{
				this._cardUsage = value;
			}
		}

		public string CmdStatus
		{
			get
			{
				return this._cmdStatus;
			}
			set
			{
				this._cmdStatus = value;
			}
		}

		public string CvvResult
		{
			get
			{
				return this._cvvResult;
			}
			set
			{
				this._cvvResult = value;
			}
		}

		public AccountType EntryMode
		{
			get
			{
				return this._entryMode;
			}
			set
			{
				this._entryMode = value;
			}
		}

		public string ExchangeRate
		{
			get
			{
				return this._exchangeRate;
			}
			set
			{
				this._exchangeRate = value;
			}
		}

		public string ExpDate
		{
			get
			{
				return this._expDate;
			}
			set
			{
				this._expDate = value;
			}
		}

		public SecureString FullAccount
		{
			set
			{
				this._fullAccount = value;
			}
		}

		public string FullExpirationDate
		{
			set
			{
				this._fullExpirationDate = value;
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

		public string IsoRespCode
		{
			get
			{
				return this._isoRespCode;
			}
			set
			{
				this._isoRespCode = value;
			}
		}

		public string IssueCurrency
		{
			get
			{
				return this._issueCurrency;
			}
			set
			{
				this._issueCurrency = value;
			}
		}

		public string IssueCurrencyEndingBalance
		{
			get
			{
				return this._issueCurrencyEndingBalance;
			}
			set
			{
				this._issueCurrencyEndingBalance = value;
			}
		}

		public string IssueCurrencyPreviousBalance
		{
			get
			{
				return this._issueCurrencyPreviousBalance;
			}
			set
			{
				this._issueCurrencyPreviousBalance = value;
			}
		}

		public string ItemAmount1
		{
			get
			{
				return this._itemAmount1;
			}
			set
			{
				this._itemAmount1 = value;
			}
		}

		public string ItemAmount2
		{
			get
			{
				return this._itemAmount2;
			}
			set
			{
				this._itemAmount2 = value;
			}
		}

		public string Language
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
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

		public string OperatorID
		{
			get
			{
				return this._operatorID;
			}
			set
			{
				this._operatorID = value;
			}
		}

		public string PostProcess
		{
			get
			{
				return this._postProcess;
			}
			set
			{
				this._postProcess = value;
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

		public string PrePaidExp
		{
			get
			{
				return this._prePaidExp;
			}
			set
			{
				this._prePaidExp = value;
			}
		}

		public string PrintData
		{
			get
			{
				return this._printData;
			}
			set
			{
				this._printData = value;
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

		public string ProductClass
		{
			get
			{
				return this._productClass;
			}
			set
			{
				this._productClass = value;
			}
		}

		public string ProductName
		{
			get
			{
				return this._productName;
			}
			set
			{
				this._productName = value;
			}
		}

		public string ProductVersion
		{
			get
			{
				return this._productVersion;
			}
			set
			{
				this._productVersion = value;
			}
		}

		public string Provider
		{
			get
			{
				return this._provider;
			}
			set
			{
				this._provider = value;
			}
		}

		public string RecordNo
		{
			get
			{
				return this._recordNo;
			}
			set
			{
				this._recordNo = value;
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

		public string ResponseOrigin
		{
			get
			{
				return this._responseOrigin;
			}
			set
			{
				this._responseOrigin = value;
			}
		}

		public string ReturnCode
		{
			get
			{
				return this._returnCode;
			}
			set
			{
				this._returnCode = value;
			}
		}

		public string Selection
		{
			get
			{
				return this._selection;
			}
			set
			{
				this._selection = value;
			}
		}

		public string SequenceNo
		{
			get
			{
				return this._sequenceNo;
			}
			set
			{
				this._sequenceNo = value;
			}
		}

		public string SignatureData
		{
			get
			{
				return this._signatureData;
			}
			set
			{
				this._signatureData = value;
			}
		}

		public TenderTypes TenderTypeUsed
		{
			get
			{
				return this._tenderTypeUsed;
			}
			set
			{
				this._tenderTypeUsed = value;
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

		public string TextResponse
		{
			get
			{
				return this._textResponse;
			}
			set
			{
				this._textResponse = value;
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

		public SecureString Track2
		{
			set
			{
				this._track2 = value;
			}
		}

		public string TranCode
		{
			get
			{
				return this._tranCode;
			}
			set
			{
				this._tranCode = value;
			}
		}

		public string TranDate
		{
			get
			{
				return this._tranDate;
			}
			set
			{
				this._tranDate = value;
			}
		}

		public TransactionTypes TransactionTypeUsed
		{
			get
			{
				return this._transactionTypesUsed;
			}
			set
			{
				this._transactionTypesUsed = value;
			}
		}

		public string TranTime
		{
			get
			{
				return this._tranTime;
			}
			set
			{
				this._tranTime = value;
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

		public string XmlResponse
		{
			get
			{
				return this._xmlresponse;
			}
			set
			{
				this._xmlresponse = value;
			}
		}

		public Response()
		{
			this._batchInfo = new Transaction.BatchInfo();
			this._amountData = new Transaction.AmountData();
			this._fullAccount = new SecureString();
			this._track2 = new SecureString();
		}

		public void MemberWiseCopy(Response responseToCopy)
		{
			try
			{
				this._responseOrigin = responseToCopy.ResponseOrigin;
				this._returnCode = responseToCopy.ReturnCode;
				this._cmdStatus = responseToCopy.CmdStatus;
				this._textResponse = responseToCopy.TextResponse;
				this._userTraceData = responseToCopy.UserTraceData;
				this._sequenceNo = responseToCopy.SequenceNo;
				this._merchantID = responseToCopy.MerchantID;
				this._terminalID = responseToCopy.TerminalID;
				this._account = responseToCopy.Account;
				this._expDate = responseToCopy.ExpDate;
				this._cardType = responseToCopy.CardType;
				this._selection = responseToCopy.Selection;
				this._tranCode = responseToCopy.TranCode;
				this._authCode = responseToCopy.AuthCode;
				this._avsResult = responseToCopy.AvsResult;
				this._cvvResult = responseToCopy.CvvResult;
				this._voucherNo = responseToCopy.VoucherNo;
				this._captureStatus = responseToCopy.CaptureStatus;
				this._referenceNumber = responseToCopy.ReferenceNumber;
				this._invoiceNumber = responseToCopy.InvoiceNumber;
				this._operatorID = responseToCopy.OperatorID;
				this._memo = responseToCopy.Memo;
				this._acqRefData = responseToCopy.AcqRefData;
				this._recordNo = responseToCopy.RecordNo;
				this._issueCurrency = responseToCopy.IssueCurrency;
				this._issueCurrencyPreviousBalance = responseToCopy.IssueCurrencyPreviousBalance;
				this._issueCurrencyEndingBalance = responseToCopy.IssueCurrencyEndingBalance;
				this._exchangeRate = responseToCopy.ExchangeRate;
				this._prePaidExp = responseToCopy.PrePaidExp;
				this._language = responseToCopy.Language;
				this._bankRespCode = responseToCopy.BankRespCode;
				this._isoRespCode = responseToCopy.IsoRespCode;
				this._tranDate = responseToCopy.TranDate;
				this._tranTime = responseToCopy.TranTime;
				this._itemAmount1 = responseToCopy.ItemAmount1;
				this._itemAmount2 = responseToCopy.ItemAmount2;
				this._batchInfo = responseToCopy.BatchInfo;
				this._amountData = responseToCopy.AmountData;
				this._xmlresponse = responseToCopy.XmlResponse;
				this._fullAccount = responseToCopy._fullAccount.Copy();
				this._fullExpirationDate = responseToCopy._fullExpirationDate;
				this._printData = responseToCopy.PrintData;
				this._track2 = responseToCopy._track2.Copy();
				this._cardholderName = responseToCopy.CardholderName;
				this._entryMode = responseToCopy.EntryMode;
				this._processData = responseToCopy.ProcessData;
				this._signatureData = responseToCopy.SignatureData;
				this._token = responseToCopy.Token;
				this._prePaidAccount = responseToCopy.PrePaidAccount;
				this._canadianEMVTerminalID = responseToCopy.CanadianEMVTerminalID;
				this._postProcess = responseToCopy.PostProcess;
				this._productName = responseToCopy.ProductName;
				this._productClass = responseToCopy.ProductClass;
				this._productVersion = responseToCopy.ProductVersion;
				this._provider = responseToCopy.Provider;
				this._cardUsage = responseToCopy.CardUsage;
				this._tenderTypeUsed = responseToCopy.TenderTypeUsed;
				this._transactionTypesUsed = responseToCopy.TransactionTypeUsed;
			}
			catch (Exception exception)
			{
				object[] message = new object[] { "Response.cs", "MemberWiseCopy", exception.Message };
				Logging.LogData(string.Format("Exception caught. Class = '{0}', method = '{1}', Exception = '{2}'.", message), "TranSentry");
			}
		}

		public void SetExpirationDateMonth(CardTransaction transaction)
		{
			transaction.SetExpirationDateMonth(int.Parse(this._fullExpirationDate.Substring(0, 2)));
		}

		public void SetExpirationDateYear(CardTransaction transaction)
		{
			transaction.SetExpirationDateYear(int.Parse(this._fullExpirationDate.Substring(2, 2)) + 0x7d0);
		}

		public void SetFullAccount(CardTransaction transaction)
		{
			transaction.SetAccount(this._fullAccount);
		}

		public void SetTrack2(CardTransaction transaction)
		{
			transaction.SetTrack2(this._track2);
		}
	}
}