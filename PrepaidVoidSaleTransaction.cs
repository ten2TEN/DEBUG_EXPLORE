using DSITransaction;
using System;

namespace Transaction
{
	public class PrepaidVoidSaleTransaction : PrepaidTransaction
	{
		private string _authcode = string.Empty;

		public string AuthCode
		{
			get
			{
				return this._authcode;
			}
			set
			{
				this._authcode = value;
			}
		}

		public PrepaidVoidSaleTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			this.AuthCode = request.AuthCode;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "VoidSale";
			base.dsiTransaction.Purchase = (decimal)((double)base.AmountData.PurchaseAmount);
			base.dsiTransaction.AuthCode = this.AuthCode;
			base.SetValues();
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
			base.ValidateAccountInformation();
		}
	}
}