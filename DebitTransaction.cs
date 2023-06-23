using DSITransaction;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Transaction
{
	public class DebitTransaction : CardTransaction
	{
		private string _pinBlock = string.Empty;

		private string _dervdKey = string.Empty;

		private string _referenceNumber = string.Empty;

		private string _invoiceNumber = string.Empty;

		public string DervdKey
		{
			set
			{
				this._dervdKey = value;
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

		public string PinBlock
		{
			set
			{
				this._pinBlock = value;
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

		public DebitTransaction()
		{
		}

		public void SetDebitInfo()
		{
			base.dsiTransaction.PINBlock = this._pinBlock;
			base.dsiTransaction.DervdKey = this._dervdKey;
		}

		public void SetDervdKey(SecureString dervdKey)
		{
			this._dervdKey = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(dervdKey));
			if (this._dervdKey.Length >= 16)
			{
				this._dervdKey = this._dervdKey.Substring(this._dervdKey.Length - 16);
			}
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			base.SetInternalMemberVariables(request);
		}

		public void SetPinBlock(SecureString pinBlock)
		{
			this._pinBlock = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(pinBlock));
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
		}
	}
}