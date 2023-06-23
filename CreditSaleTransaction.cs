using DSITransaction;
using System;

namespace Transaction
{
	public class CreditSaleTransaction : CreditTransaction
	{
		private Transaction.LevelIIData _levelIIData;

		public Transaction.LevelIIData LevelIIData
		{
			get
			{
				return this._levelIIData;
			}
			set
			{
				this._levelIIData = value;
			}
		}

		public CreditSaleTransaction()
		{
			this._levelIIData = new Transaction.LevelIIData();
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.SetInternalMemberVariables(request);
			this._levelIIData = request.LevelIIData;
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "Credit";
			base.dsiTransaction.TranCode = "Sale";
			base.dsiTransaction.PartialAuth = true;
			base.dsiTransaction.Purchase = Convert.ToDecimal(base.AmountData.PurchaseAmount);
			base.dsiTransaction.Gratuity = Convert.ToDecimal(base.AmountData.GratuityAmount);
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
			if (this.LevelIIData.TaxAmount > 0)
			{
				base.dsiTransaction.Tax = Convert.ToDecimal(this.LevelIIData.TaxAmount);
				if (!string.IsNullOrEmpty(this.LevelIIData.CustomerCode))
				{
					base.dsiTransaction.CustomerCode = this.LevelIIData.CustomerCode;
				}
				else if (base.InvoiceNumber.Length <= 17)
				{
					base.dsiTransaction.CustomerCode = base.InvoiceNumber;
				}
				else
				{
					base.dsiTransaction.CustomerCode = base.InvoiceNumber.Substring(0, 17);
				}
			}
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
			if (this.LevelIIData.TaxAmount > 0)
			{
				if (this.LevelIIData.TaxAmount > 999999.99)
				{
					throw new Exception(StringsReader.GetText("TaxError"));
				}
				if (this.LevelIIData.CustomerCode.Length > 17)
				{
					throw new Exception(StringsReader.GetText("CustomerCodeError"));
				}
			}
			else if (this.LevelIIData.TaxAmount < 0)
			{
				throw new Exception(StringsReader.GetText("TaxError"));
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