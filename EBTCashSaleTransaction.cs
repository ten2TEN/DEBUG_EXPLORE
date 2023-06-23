using DSITransaction;
using System;

namespace Transaction
{
	public class EBTCashSaleTransaction : DebitTransaction
	{
		public EBTCashSaleTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "EBT";
			base.dsiTransaction.TranCode = "Sale";
			base.dsiTransaction.CardType = "Cash";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.CashBack = Convert.ToDecimal(base.AmountData.CashBackAmount);
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
			if (base.AmountData.CashBackAmount > 0)
			{
				if (base.AmountData.CashBackAmount > 999999.99)
				{
					throw new Exception(StringsReader.GetText("CashBackError"));
				}
			}
			else if (base.AmountData.CashBackAmount < 0)
			{
				throw new Exception(StringsReader.GetText("CashBackError"));
			}
			base.ValidateAccountInformation();
		}
	}
}