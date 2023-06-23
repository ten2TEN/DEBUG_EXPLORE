using DSITransaction;
using System;

namespace Transaction
{
	public class CreditPreAuthCaptureTransaction : CreditTransaction
	{
		public CreditPreAuthCaptureTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.AcqRefData = base.AcqRefData;
			base.dsiTransaction.AuthCode = base.AuthCode;
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "PreAuthCapture";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.Authorize = Convert.ToDecimal(base.AmountData.AuthorizeAmount);
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
			if (base.AmountData.PurchaseAmount <= 0)
			{
				throw new Exception(StringsReader.GetText("NoPurchaseAmountProvidedError"));
			}
			if (base.AmountData.PurchaseAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("PurchaseAmountTooLargeError"));
			}
			if (base.AmountData.AuthorizeAmount <= 0)
			{
				throw new Exception(StringsReader.GetText("NoAuthorizeAmountProvidedError"));
			}
			if (base.AmountData.AuthorizeAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("AuthorizeAmountTooLargeError"));
			}
			if (string.IsNullOrEmpty(base.AuthCode) || base.AuthCode.Length != 6)
			{
				throw new Exception(StringsReader.GetText("NoAuthCodeProvidedError"));
			}
			if (!Utils.IsAlphaNumSpace(base.AuthCode))
			{
				throw new Exception(StringsReader.GetText("AuthCodeAlphaNumError"));
			}
			if (base.AcqRefData.Length > 200)
			{
				throw new Exception(StringsReader.GetText("AcqRefDataTooLongError"));
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
		}
	}
}