using DSITransaction;
using System;

namespace Transaction
{
	public class EBTReturnTransaction : DebitTransaction
	{
		public EBTReturnTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "EBT";
			base.dsiTransaction.TranCode = "Return";
			base.dsiTransaction.CardType = "Foodstamp";
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
			base.ValidateAccountInformation();
		}
	}
}