using DSITransaction;
using System;

namespace Transaction
{
	public class EBTVoucherTransaction : DebitTransaction
	{
		private string _authCode = string.Empty;

		private string _voucher = string.Empty;

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

		public string Voucher
		{
			get
			{
				return this._voucher;
			}
			set
			{
				this._voucher = value;
			}
		}

		public EBTVoucherTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "EBT";
			base.dsiTransaction.TranCode = "Voucher";
			base.dsiTransaction.CardType = "Foodstamp";
			base.dsiTransaction.AuthCode = this.AuthCode;
			base.dsiTransaction.Voucher = this.Voucher;
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.SetDebitInfo();
			base.SetAccountInfo();
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			base.ValidateTransactionSpecificParameters();
			if (base.AmountData.PurchaseAmount <= 0)
			{
				throw new Exception(StringsReader.GetText("NoPurchaseAmountProvidedError"));
			}
			if (base.AmountData.PurchaseAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("PurchaseAmountTooLargeError"));
			}
			if (string.IsNullOrEmpty(this.AuthCode) || this.AuthCode.Length != 6)
			{
				throw new Exception(StringsReader.GetText("NoAuthCodeProvidedError"));
			}
			if (string.IsNullOrEmpty(this.Voucher) || this.Voucher.Length > 16)
			{
				throw new Exception(StringsReader.GetText("NoVoucherProvidedError"));
			}
			base.ValidateAccountInformation();
		}
	}
}