using DSITransaction;
using System;

namespace Transaction
{
	internal class FSAReverseSaleTransaction : CreditTransaction
	{
		private double _fsaPrescriptionAmount;

		public double FSAPrescriptionAmount
		{
			get
			{
				return this._fsaPrescriptionAmount;
			}
			set
			{
				this._fsaPrescriptionAmount = value;
			}
		}

		public FSAReverseSaleTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "FSA";
			base.dsiTransaction.TranCode = "ReverseFSASale";
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.dsiTransaction.FSAPrescriptionAmount = Convert.ToDecimal(this.FSAPrescriptionAmount);
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
			if (base.AmountData.FSAPrescriptionAmount < 0)
			{
				throw new Exception(StringsReader.GetText("FSAPrescriptionAmountInvalidError"));
			}
			if (!Utils.IsAlphaNumSpace(base.AuthCode))
			{
				throw new Exception(StringsReader.GetText("AuthCodeAlphaNumError"));
			}
		}
	}
}