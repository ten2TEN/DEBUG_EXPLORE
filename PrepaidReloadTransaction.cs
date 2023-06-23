using DSITransaction;
using System;

namespace Transaction
{
	public class PrepaidReloadTransaction : PrepaidTransaction
	{
		public PrepaidReloadTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "Reload";
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