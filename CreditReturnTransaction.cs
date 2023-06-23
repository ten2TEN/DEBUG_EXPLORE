using DSITransaction;
using System;

namespace Transaction
{
	public class CreditReturnTransaction : CreditTransaction
	{
		public CreditReturnTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "Return";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
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
			if (string.IsNullOrEmpty(base.Token))
			{
				base.ValidateAccountInformation();
			}
		}
	}
}