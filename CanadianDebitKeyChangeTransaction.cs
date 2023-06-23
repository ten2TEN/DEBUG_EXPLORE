using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianDebitKeyChangeTransaction : Transaction
	{
		private string _invoiceNumber = string.Empty;

		private string _referenceNumber = string.Empty;

		private Transaction.PinPadConfig _pinPadConfig;

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

		public CanadianDebitKeyChangeTransaction()
		{
			this._pinPadConfig = new Transaction.PinPadConfig();
		}

		public CanadianDebitKeyChangeTransaction(Transaction.PinPadConfig pinPadConfig)
		{
			this._pinPadConfig = pinPadConfig;
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
			base.Servers = request.CreditServers;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			base.MerchantID = this._pinPadConfig.MerchantID;
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "CanadianDebit";
			base.dsiTransaction.TranCode = "KeyChange";
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