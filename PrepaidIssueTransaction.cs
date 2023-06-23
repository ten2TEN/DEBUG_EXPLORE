using DSITransaction;
using System;

namespace Transaction
{
	public class PrepaidIssueTransaction : PrepaidTransaction
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

		public PrepaidIssueTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "Issue";
			base.dsiTransaction.Purchase = (decimal)((double)base.AmountData.PurchaseAmount);
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
			base.ValidateAccountInformation();
		}
	}
}