using DSITransaction;
using MPS.POS.Utils;
using System;

namespace Transaction
{
	public class CanadianEMVReturnTransaction : CanadianEMVTransaction
	{
		private Transaction.AmountData _amountData;

		private bool _manualCredit;

		private bool _override;

		private string _cardType = string.Empty;

		private bool _promptForGratuity;

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

		public bool ManualCredit
		{
			get
			{
				return this._manualCredit;
			}
			set
			{
				this._manualCredit = value;
			}
		}

		public bool Override
		{
			get
			{
				return this._override;
			}
			set
			{
				this._override = value;
			}
		}

		public bool PromptForGratuity
		{
			get
			{
				return this._promptForGratuity;
			}
			set
			{
				this._promptForGratuity = value;
			}
		}

		public CanadianEMVReturnTransaction()
		{
			this._amountData = new Transaction.AmountData();
		}

		public override Response ProcessTransaction()
		{
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				CanadianEMVPadResetTransaction canadianEMVPadResetTransaction = new CanadianEMVPadResetTransaction()
				{
					InvoiceNumber = base.InvoiceNumber,
					ReferenceNumber = base.ReferenceNumber,
					PinPadConfig = base.PinPadConfig,
					LogName = base.LogName,
					MerchantID = base.MerchantID,
					UserID = base.UserID,
					HostOrIP = base.HostOrIP,
					IPPort = base.IPPort,
					TerminalID = base.TerminalID,
					MerchantLanguage = base.MerchantLanguage,
					UserTraceData = base.UserTraceData
				};
				empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
				Logging.LogData(empty, base.LogName);
				if (canadianEMVPadResetTransaction.ProcessTransaction().CmdStatus.ToLower() != "success")
				{
					response.CmdStatus = "Error";
					response.ResponseOrigin = "Client";
					response.TextResponse = "Unable to reset pinpad.";
					empty = string.Format("Reset failed for pinpad device: userid:{0}.", base.UserID);
					Logging.LogData(empty, base.LogName);
				}
				else
				{
					response = base.ProcessTransaction();
					empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
					Logging.LogData(empty, base.LogName);
					canadianEMVPadResetTransaction.ProcessTransaction();
				}
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
			try
			{
				base.SetInternalMemberVariables(request);
				if (request.AmountData.PurchaseAmount > 0)
				{
					this._amountData.PurchaseAmount = request.AmountData.PurchaseAmount;
				}
				if (request.AmountData.GratuityAmount > 0)
				{
					this._amountData.GratuityAmount = request.AmountData.GratuityAmount;
				}
				this._manualCredit = request.CanadianEMVCreditManualEntry;
				this._cardType = request.CardType;
				this._override = request.Override;
				this._promptForGratuity = request.CanadianEMVGratuityPrompt;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetInternalMemberVariables(): ", exception.Message));
			}
		}

		protected override void SetValues()
		{
			try
			{
				base.SetValues();
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVReturn.ToString();
				base.DSIEmvTransaction.Purchase = Convert.ToDecimal(this._amountData.PurchaseAmount);
				base.DSIEmvTransaction.CardType = this.CardType;
				base.DSIEmvTransaction.PromptForAccount = this.ManualCredit;
				base.DSIEmvTransaction.Duplicate = this.Override;
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			base.ValidateTransactionSpecificParameters();
			if (this.AmountData.PurchaseAmount <= 0)
			{
				throw new Exception(StringsReader.GetText("NoPurchaseAmountProvidedError"));
			}
			if (this.AmountData.PurchaseAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("PurchaseAmountTooLargeError"));
			}
			if (this.AmountData.GratuityAmount > 0)
			{
				throw new Exception(StringsReader.GetText("GratuityNotSupported"));
			}
			if (this.PromptForGratuity)
			{
				throw new Exception(StringsReader.GetText("GratuityNotSupported"));
			}
		}
	}
}