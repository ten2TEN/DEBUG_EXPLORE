using DSITransaction;
using System;

namespace Transaction
{
	public class FSASaleTransaction : CreditTransaction
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

		public FSASaleTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
			this._fsaPrescriptionAmount = request.AmountData.FSAPrescriptionAmount;
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "FSA";
			base.dsiTransaction.TranCode = "FSASale";
			base.dsiTransaction.PartialAuth = true;
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.FSAPrescriptionAmount = Convert.ToDecimal(this.FSAPrescriptionAmount);
			if (!string.IsNullOrEmpty(base.CardData.AVS.Address))
			{
				base.dsiTransaction.Address = base.CardData.AVS.Address;
				base.dsiTransaction.AVSFlag = true;
			}
			if (!string.IsNullOrEmpty(base.CardData.AVS.ZipCode))
			{
				base.dsiTransaction.ZipCode = base.CardData.AVS.ZipCode;
				base.dsiTransaction.AVSFlag = true;
			}
			if (base.CardData.CVV.Length > 0)
			{
				base.dsiTransaction.CVVData = base.CardData.CVV;
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
			if (base.AmountData.FSAPrescriptionAmount < 0)
			{
				throw new Exception(StringsReader.GetText("FSAPrescriptionAmountInvalidError"));
			}
			if (base.AmountData.FSAPrescriptionAmount > 999999.99)
			{
				throw new Exception(StringsReader.GetText("FSAPrescriptionAmountTooLargeError"));
			}
			if (base.AmountData.FSAPrescriptionAmount > base.AmountData.PurchaseAmount)
			{
				throw new Exception(StringsReader.GetText("FSAPrescriptionAmountExceedsPurchaseError"));
			}
			if (base.CardData.CVV.Length > 0)
			{
				if (base.CardData.CVV.Length != 3 && base.CardData.CVV.Length != 4)
				{
					throw new Exception(StringsReader.GetText("InvalidCVVError"));
				}
				try
				{
					int.Parse(base.CardData.CVV);
				}
				catch
				{
					throw new Exception(StringsReader.GetText("InvalidCVVError"));
				}
			}
			if (!string.IsNullOrEmpty(base.CardData.AVS.ZipCode) && base.CardData.AVS.ZipCode.Length != 5 && base.CardData.AVS.ZipCode.Length != 9)
			{
				throw new Exception(StringsReader.GetText("ZipCodeError"));
			}
			if (string.IsNullOrEmpty(base.Token))
			{
				base.ValidateAccountInformation();
			}
		}
	}
}