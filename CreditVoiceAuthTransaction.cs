using DSITransaction;
using MSEnum;
using System;

namespace Transaction
{
	public class CreditVoiceAuthTransaction : CreditTransaction
	{
		public CreditVoiceAuthTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "VoiceAuth";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.AuthCode = base.AuthCode.ToString();
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.dsiTransaction.RequestToken = true;
			if (base.TokenFrequency == TokenFrequencies.OneTime)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.OneTime;
			}
			else if (base.TokenFrequency == TokenFrequencies.Recurring)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.Recurring;
			}
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
			if (string.IsNullOrEmpty(base.AuthCode) || base.AuthCode.Length != 6)
			{
				throw new Exception(StringsReader.GetText("NoAuthCodeProvidedError"));
			}
			if (!Utils.IsAlphaNumSpace(base.AuthCode))
			{
				throw new Exception(StringsReader.GetText("AuthCodeAlphaNumError"));
			}
			if (string.IsNullOrEmpty(base.Token))
			{
				base.ValidateAccountInformation();
			}
		}
	}
}