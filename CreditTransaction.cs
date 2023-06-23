using DSITransaction;
using MSEnum;
using System;

namespace Transaction
{
	public abstract class CreditTransaction : CardTransaction
	{
		private string _referenceNumber = string.Empty;

		private string _invoiceNumber = string.Empty;

		private string _authCode = string.Empty;

		private string _acqrefdata = string.Empty;

		private string _processData = string.Empty;

		private string _token = string.Empty;

		private TokenFrequencies _tokenFrequency;

		public string AcqRefData
		{
			get
			{
				return this._acqrefdata;
			}
			set
			{
				this._acqrefdata = value;
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

		public CreditTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			this.InvoiceNumber = request.InvoiceNumber;
			this.ReferenceNumber = request.ReferenceNumber;
			if (string.IsNullOrEmpty(this.AuthCode) && !string.IsNullOrEmpty(request.AuthCode))
			{
				this.AuthCode = request.AuthCode;
			}
			if (!string.IsNullOrEmpty(request.AcqRefData))
			{
				this.AcqRefData = request.AcqRefData;
			}
			if (!string.IsNullOrEmpty(request.ProcessData))
			{
				this.ProcessData = request.ProcessData;
			}
			this.Token = request.Token;
			this.TokenFrequency = request.TokenFrequency;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.Token = this.Token;
			base.dsiTransaction.RequestToken = true;
			if (this.TokenFrequency == TokenFrequencies.OneTime)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.OneTime;
			}
			else if (this.TokenFrequency == TokenFrequencies.Recurring)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.Recurring;
			}
			if (string.IsNullOrEmpty(this.Token))
			{
				base.SetAccountInfo();
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
			if (!string.IsNullOrEmpty(this.ProcessData) && this.ProcessData.Length > 200)
			{
				throw new Exception(StringsReader.GetText("ProcessDataLengthError"));
			}
		}
	}
}