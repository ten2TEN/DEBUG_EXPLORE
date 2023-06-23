using DSITransaction;
using MPS.POS.Utils;
using System;

namespace Transaction
{
	public class CanadianDebitSaleTransaction : Transaction
	{
		private string _invoiceNumber = string.Empty;

		private string _referenceNumber = string.Empty;

		private Transaction.PinPadConfig _pinPadConfig;

		private Transaction.AmountData _amountData;

		private bool _promptForGratuity;

		private bool _override;

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

		public CanadianDebitSaleTransaction()
		{
			this._pinPadConfig = new Transaction.PinPadConfig();
			this._amountData = new Transaction.AmountData();
		}

		public CanadianDebitSaleTransaction(Transaction.PinPadConfig pinPadConfig, Transaction.AmountData amountData)
		{
			this._pinPadConfig = pinPadConfig;
			this._amountData = amountData;
		}

		public override Response ProcessTransaction()
		{
			Response message = null;
			string empty = string.Empty;
			try
			{
				CanadianDebitPadResetTransaction canadianDebitPadResetTransaction = new CanadianDebitPadResetTransaction()
				{
					InvoiceNumber = this.InvoiceNumber,
					ReferenceNumber = this.ReferenceNumber,
					PinPadConfig = this.PinPadConfig,
					LogName = base.LogName,
					Memo = base.Memo,
					MerchantID = base.MerchantID,
					Servers = base.Servers,
					UserID = base.UserID
				};
				empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
				Logging.LogData(empty, base.LogName);
				canadianDebitPadResetTransaction.ProcessTransaction();
				empty = string.Format("Sending debit transaction userid:{0}.", base.UserID);
				Logging.LogData(empty, base.LogName);
				message = base.ProcessTransaction();
				if (message.BankRespCode == "898" && message.IsoRespCode == "63")
				{
					CanadianDebitKeyChangeTransaction canadianDebitKeyChangeTransaction = new CanadianDebitKeyChangeTransaction()
					{
						InvoiceNumber = this.InvoiceNumber,
						ReferenceNumber = this.ReferenceNumber,
						PinPadConfig = this.PinPadConfig,
						LogName = base.LogName,
						Memo = base.Memo,
						MerchantID = base.MerchantID,
						Servers = base.Servers,
						UserID = base.UserID
					};
					canadianDebitKeyChangeTransaction.ProcessTransaction();
				}
				empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
				Logging.LogData(empty, base.LogName);
				canadianDebitPadResetTransaction.ProcessTransaction();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				message.CmdStatus = "Error";
				message.ResponseOrigin = "Client";
				message.TextResponse = exception.Message;
			}
			return message;
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
			base.Servers = request.CreditServers;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			base.MerchantID = this._pinPadConfig.MerchantID;
			this._override = request.Override;
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "CanadianDebit";
			base.dsiTransaction.TranCode = "Sale";
			base.dsiTransaction.ComPort = this._pinPadConfig.ComPort.ToString();
			if (this._pinPadConfig.PinPadType == PinPadType.VerifoneSC5000CAMercury1)
			{
				base.dsiTransaction.PadType = netTransaction.ePadType.Mercury1;
			}
			else if (this._pinPadConfig.PinPadType == PinPadType.Ingenico3070CAMercury2)
			{
				base.dsiTransaction.PadType = netTransaction.ePadType.Mercury2;
			}
			else if (this._pinPadConfig.PinPadType == PinPadType.Ingenico3070CAMercury3)
			{
				base.dsiTransaction.PadType = netTransaction.ePadType.Mercury3;
			}
			base.dsiTransaction.SequenceNo = this._pinPadConfig.SequenceNumber;
			base.dsiTransaction.InvoiceNo = this._invoiceNumber.ToString();
			base.dsiTransaction.RefNo = this._referenceNumber.ToString();
			base.dsiTransaction.Purchase = Convert.ToDecimal(this._amountData.PurchaseAmount);
			base.dsiTransaction.Gratuity = Convert.ToDecimal(this._amountData.GratuityAmount);
			base.dsiTransaction.PromptForGratuity = this._promptForGratuity;
			if (this._override)
			{
				base.dsiTransaction.Duplicate = true;
			}
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			if (string.IsNullOrEmpty(this.InvoiceNumber))
			{
				throw new Exception(StringsReader.GetText("NoInvoiceProvidedError"));
			}
			if (this.InvoiceNumber.Length > 16)
			{
				throw new Exception(StringsReader.GetText("InvoiceTooLongError"));
			}
			if (!Utils.IsNumericString(this.InvoiceNumber))
			{
				throw new Exception(StringsReader.GetText("InvoiceNotNumericError"));
			}
			if (string.IsNullOrEmpty(this.ReferenceNumber))
			{
				throw new Exception(StringsReader.GetText("NoReferenceNumberProvidedError"));
			}
			if (this.ReferenceNumber.Length > 16)
			{
				throw new Exception(StringsReader.GetText("ReferenceNumberTooLongError"));
			}
			if (!Utils.IsNumericString(this.ReferenceNumber))
			{
				throw new Exception(StringsReader.GetText("ReferenceNotNumericError"));
			}
			if (this._pinPadConfig.PinPadType == PinPadType.Unknown)
			{
				throw new Exception(StringsReader.GetText("PinPadTypeError"));
			}
			if (this._pinPadConfig.ComPort <= 0 || this._pinPadConfig.ComPort > 254)
			{
				throw new Exception(StringsReader.GetText("ComPortError"));
			}
		}
	}
}