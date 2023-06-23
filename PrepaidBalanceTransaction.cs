using DSITransaction;
using System;

namespace Transaction
{
	public class PrepaidBalanceTransaction : PrepaidTransaction
	{
		public PrepaidBalanceTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.AmountData.PurchaseAmount = 1;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "Balance";
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