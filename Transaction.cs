using Common;
using DSITransaction;
using MPS.POS.Utils;
using MSEnum;
using System;
using System.Reflection;
using System.Security;

namespace Transaction
{
	public abstract class Transaction
	{
		private string _servers = string.Empty;

		private string _memo = string.Empty;

		private netTransaction _dsiTransaction;

		private string _userid = string.Empty;

		private string _merchantid = string.Empty;

		private string _logName = string.Empty;

		private string _terminalName = string.Empty;

		private int _processControl = 1;

		protected netTransaction dsiTransaction
		{
			get
			{
				return this._dsiTransaction;
			}
		}

		public string LogName
		{
			get
			{
				return this._logName;
			}
			set
			{
				this._logName = value;
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
				return this._merchantid;
			}
			set
			{
				this._merchantid = value;
			}
		}

		public int ProcessControl
		{
			get
			{
				return this._processControl;
			}
			set
			{
				this._processControl = value;
			}
		}

		public string Servers
		{
			get
			{
				return this._servers;
			}
			set
			{
				this._servers = value;
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

		public string UserID
		{
			get
			{
				return this._userid;
			}
			set
			{
				this._userid = value;
			}
		}

		public Transaction()
		{
			this._dsiTransaction = new netTransaction();
		}

		public virtual Response ProcessTransaction()
		{
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				empty = string.Format("Validating Parameters", new object[0]);
				Logging.LogData(empty, this._logName);
				this.ValidateParameters();
				empty = string.Format("Validating Transaction Specific Parameters", new object[0]);
				Logging.LogData(empty, this._logName);
				this.ValidateTransactionSpecificParameters();
				empty = string.Format("Setting global properties", new object[0]);
				Logging.LogData(empty, this._logName);
				this._dsiTransaction.ServerString = this._servers;
				this._dsiTransaction.OperatorID = this._userid;
				this._dsiTransaction.MerchantID = this._merchantid;
				this._dsiTransaction.Memo = string.Concat(this._memo, " MPSMS ", Assembly.GetExecutingAssembly().GetName().Version);
				this._dsiTransaction.TerminalName = this._terminalName;
				this._dsiTransaction.ProcessControl = this._processControl;
				empty = string.Format("Set transaction specific properties", new object[0]);
				Logging.LogData(empty, this._logName);
				this.SetValues();
				empty = string.Format("Getting XML for transaction", new object[0]);
				Logging.LogData(empty, this._logName);
				if (!this._dsiTransaction.GetXML())
				{
					response.CmdStatus = "Error";
					response.ResponseOrigin = "Client";
					response.TextResponse = string.Concat("Error converting properties to XML.  A property was not set correctly:  ", this._dsiTransaction.ErrText.ToString());
				}
				else
				{
					empty = string.Format("Attempting to process a {0} for user: {1}", this.ToString(), this._userid);
					Logging.LogData(empty, this._logName);
					if (!this._dsiTransaction.Process_Transaction())
					{
						response.CmdStatus = "Error";
						response.ResponseOrigin = "Client";
						response.TextResponse = string.Concat("Error processing transaction. ", this._dsiTransaction.ErrText.ToString());
					}
					else
					{
						response.ResponseOrigin = this._dsiTransaction.ResponseOrigin;
						response.ReturnCode = this._dsiTransaction.ReturnCode;
						response.CmdStatus = this._dsiTransaction.Status;
						response.TextResponse = this._dsiTransaction.TextResponse;
						response.UserTraceData = this._dsiTransaction.UserTraceData;
						response.SequenceNo = this._dsiTransaction.SequenceNo;
						response.MerchantID = this._dsiTransaction.MerchantID;
						response.FullAccount = this._dsiTransaction.AcctNo.Copy();
						response.FullExpirationDate = this._dsiTransaction.ExpDate;
						Account account = new Account(this._dsiTransaction.AcctNo);
						response.Account = account.MaskedAccount;
						account = null;
						response.ExpDate = "XXXX";
						response.CardType = this._dsiTransaction.CardType;
						response.Selection = this._dsiTransaction.Selection;
						response.TranCode = this._dsiTransaction.TranCode;
						response.AuthCode = this._dsiTransaction.AuthCode;
						response.AvsResult = this._dsiTransaction.AVSResult;
						response.CvvResult = this._dsiTransaction.CVVResult;
						response.VoucherNo = this._dsiTransaction.VoucherNo;
						response.CaptureStatus = this._dsiTransaction.CaptureStatus;
						response.ReferenceNumber = this._dsiTransaction.RefNo;
						response.InvoiceNumber = this._dsiTransaction.InvoiceNo;
						response.OperatorID = this._dsiTransaction.OperatorID;
						response.Memo = this._dsiTransaction.Memo;
						response.AmountData.PurchaseAmount = (double)((double)this._dsiTransaction.Purchase);
						response.AmountData.AuthorizeAmount = (double)((double)this._dsiTransaction.Authorize);
						response.AmountData.GratuityAmount = (double)((double)this._dsiTransaction.Gratuity);
						response.AmountData.CashBackAmount = (double)((double)this._dsiTransaction.CashBack);
						response.AmountData.Balance = (double)((double)this._dsiTransaction.Balance);
						response.AcqRefData = this._dsiTransaction.AcqRefData;
						response.RecordNo = this._dsiTransaction.RecordNo;
						response.IssueCurrency = this._dsiTransaction.IssueCurrency;
						response.IssueCurrencyPreviousBalance = this._dsiTransaction.IssueCurrencyPreviousBalance;
						response.IssueCurrencyEndingBalance = this._dsiTransaction.IssueCurrencyEndingBalance;
						response.ExchangeRate = this._dsiTransaction.ExchangeRate;
						response.PrePaidExp = this._dsiTransaction.PrePaidExp;
						response.Language = this._dsiTransaction.Language;
						response.BankRespCode = this._dsiTransaction.BankRespCode;
						response.IsoRespCode = this._dsiTransaction.ISORespCode;
						response.TranDate = this._dsiTransaction.TranDate;
						response.TranTime = this._dsiTransaction.TranTime;
						response.BatchInfo.BatchNo = (!string.IsNullOrEmpty(this._dsiTransaction.BatchNo) ? int.Parse(this._dsiTransaction.BatchNo) : 0);
						response.BatchInfo.BatchItemCount = this._dsiTransaction.BatchItemCount;
						response.BatchInfo.NetBatchTotal = (double)((double)this._dsiTransaction.NetBatchTotal);
						response.BatchInfo.CreditPurchaseCount = this._dsiTransaction.CreditPurchaseCount;
						response.BatchInfo.CreditPurchaseAmount = (double)((double)this._dsiTransaction.CreditPurchaseAmount);
						response.BatchInfo.CreditReturnCount = this._dsiTransaction.CreditReturnCount;
						response.BatchInfo.CreditReturnAmount = (double)((double)this._dsiTransaction.CreditReturnAmount);
						response.BatchInfo.DebitPurchaseCount = this._dsiTransaction.DebitPurchaseCount;
						response.BatchInfo.DebitPurchaseAmount = (double)((double)this._dsiTransaction.DebitPurchaseAmount);
						response.BatchInfo.DebitReturnCount = this._dsiTransaction.DebitReturnCount;
						response.BatchInfo.DebitReturnAmount = (double)((double)this._dsiTransaction.DebitReturnAmount);
						response.XmlResponse = Utils.MaskTransactionData(this._dsiTransaction.Response);
						response.PrintData = this._dsiTransaction.PrintData;
						response.Track2 = this._dsiTransaction.Track2.Copy();
						response.CardholderName = this._dsiTransaction.CardholderName;
						response.EntryMode = EnumHelper.GetAccountType(this._dsiTransaction.EntryMode.ToString());
						response.ProcessData = this._dsiTransaction.ProcessData;
						response.Token = this._dsiTransaction.TokenResponse;
						response.CardUsage = this._dsiTransaction.CardUsage;
						this.SetTransactionSpecificResponseInfo(response);
					}
				}
				empty = string.Format("Text Response from attempt to process transaction:{0} for userid:{1}.", response.TextResponse, this._userid);
				Logging.LogData(empty, this._logName);
				empty = string.Format("Cmd Status from attempt to process transaction:{0} for userid:{1}.", response.CmdStatus, this._userid);
				Logging.LogData(empty, this._logName);
				empty = string.Format("Response Origin from attempt to process transaction:{0} for userid:{1}.", response.ResponseOrigin, this._userid);
				Logging.LogData(empty, this._logName);
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

		public virtual void SetInternalMemberVariables(Request request)
		{
			this.Memo = request.Memo;
			this.MerchantID = request.MerchantID;
			this.UserID = request.UserID;
			this.TerminalName = request.TerminalName;
			this.ProcessControl = 1;
			if (request.CancelDialogueTransaction)
			{
				this.ProcessControl = 0;
			}
		}

		protected virtual void SetTransactionSpecificResponseInfo(Response response)
		{
			response.PrePaidAccount = string.Empty;
		}

		protected abstract void SetValues();

		protected void ValidateParameters()
		{
			if (string.IsNullOrEmpty(this._servers))
			{
				throw new Exception(StringsReader.GetText("NoServersProvidedError"));
			}
			if (string.IsNullOrEmpty(this._merchantid))
			{
				throw new Exception(StringsReader.GetText("NoMerchantIDProvidedError"));
			}
			if (this._merchantid.Length > 55)
			{
				throw new Exception(StringsReader.GetText("MerchantIDTooLongError"));
			}
			if (string.IsNullOrEmpty(this._userid))
			{
				throw new Exception(StringsReader.GetText("NoUserIDProvidedError"));
			}
			if (this._userid.Length > 40)
			{
				throw new Exception(StringsReader.GetText("UserIDTooLongError"));
			}
			if (string.IsNullOrEmpty(this._memo))
			{
				throw new Exception(StringsReader.GetText("NoMemoProvidedError"));
			}
			if (this._memo.Length > 20)
			{
				throw new Exception(StringsReader.GetText("MemoTooLongError"));
			}
			if (!string.IsNullOrEmpty(this._terminalName) && this._terminalName.Length > 20)
			{
				throw new Exception(StringsReader.GetText("TerminalNameTooLongError"));
			}
		}

		protected abstract void ValidateTransactionSpecificParameters();
	}
}