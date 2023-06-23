using DSITransaction;
using System;

namespace Transaction
{
	public class CreditVoidSaleTransaction : CreditTransaction
	{
		public CreditVoidSaleTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "VoidSale";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.dsiTransaction.AuthCode = base.AuthCode;
			if (!string.IsNullOrEmpty(base.ProcessData))
			{
				base.dsiTransaction.ProcessData = base.ProcessData;
			}
			if (!string.IsNullOrEmpty(base.AcqRefData))
			{
				base.dsiTransaction.AcqRefData = base.AcqRefData;
			}
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
			if (string.IsNullOrEmpty(base.AuthCode) || base.AuthCode.Length != 6)
			{
				throw new Exception(StringsReader.GetText("NoAuthCodeProvidedError"));
			}
			if (!Utils.IsAlphaNumSpace(base.AuthCode))
			{
				throw new Exception(StringsReader.GetText("AuthCodeAlphaNumError"));
			}
		}
	}
}