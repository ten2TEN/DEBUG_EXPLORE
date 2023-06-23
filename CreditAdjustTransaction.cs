using DSITransaction;
using System;

namespace Transaction
{
	public class CreditAdjustTransaction : CreditTransaction
	{
		public CreditAdjustTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "Adjust";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.AuthCode = base.AuthCode;
			if (base.AmountData.GratuityAmount > 0)
			{
				base.dsiTransaction.Gratuity = Convert.ToDecimal(base.AmountData.GratuityAmount);
			}
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.SetValues();
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			base.ValidateTransactionSpecificParameters();
			if (string.IsNullOrEmpty(base.InvoiceNumber))
			{
				throw new Exception(StringsReader.GetText("NoInvoiceProvidedError"));
			}
			if (base.InvoiceNumber.Length > 16)
			{
				throw new Exception(StringsReader.GetText("InvoiceTooLongError"));
			}
			if (string.IsNullOrEmpty(base.ReferenceNumber))
			{
				throw new Exception(StringsReader.GetText("NoReferenceNumberProvidedError"));
			}
			if (base.ReferenceNumber.Length > 16)
			{
				throw new Exception(StringsReader.GetText("ReferenceNumberTooLongError"));
			}
			if (base.AmountData.PurchaseAmount <= 0)
			{
				throw new Exception(StringsReader.GetText("NoPurchaseAmountProvidedError"));
			}
			if (base.AmountData.PurchaseAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("PurchaseAmountTooLargeError"));
			}
			if (base.AmountData.GratuityAmount > 0)
			{
				if (base.AmountData.GratuityAmount > 999999.99)
				{
					throw new Exception(StringsReader.GetText("GratuityError"));
				}
			}
			else if (base.AmountData.GratuityAmount < 0)
			{
				throw new Exception(StringsReader.GetText("GratuityError"));
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