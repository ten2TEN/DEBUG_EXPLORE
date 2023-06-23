using DSITransaction;
using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	public class PrepaidTransaction : CardTransaction
	{
		private string _invoicenumber = string.Empty;

		private string _referencenumber = string.Empty;

		private bool _override;

		public string InvoiceNumber
		{
			get
			{
				return this._invoicenumber;
			}
			set
			{
				this._invoicenumber = value;
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

		public string ReferenceNumber
		{
			get
			{
				return this._referencenumber;
			}
			set
			{
				this._referencenumber = value;
			}
		}

		public PrepaidTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.GiftServers;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			this.Override = request.Override;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetTransactionSpecificResponseInfo(Response response)
		{
			if (base.dsiTransaction.Status.ToUpper() != "Approved".ToUpper())
			{
				base.SetTransactionSpecificResponseInfo(response);
				return;
			}
			IntPtr bSTR = Marshal.SecureStringToBSTR(base.dsiTransaction.AcctNo);
			response.PrePaidAccount = Marshal.PtrToStringBSTR(bSTR);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "PrePaid";
			base.dsiTransaction.IpPort = "9100";
			base.dsiTransaction.InvoiceNo = this.InvoiceNumber;
			base.dsiTransaction.RefNo = this.ReferenceNumber;
			base.dsiTransaction.Duplicate = this.Override;
			base.SetAccountInfo();
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
			base.ValidateAccountInformation();
		}
	}
}