using DSITransaction;
using System;

namespace Transaction
{
	public class EBTBalanceTransaction : DebitTransaction
	{
		public EBTBalanceTransaction()
		{
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "EBT";
			base.dsiTransaction.TranCode = "Balance";
			base.dsiTransaction.CardType = "Foodstamp";
			base.dsiTransaction.Purchase = new decimal(0);
			base.dsiTransaction.InvoiceNo = base.InvoiceNumber.ToString();
			base.dsiTransaction.RefNo = base.ReferenceNumber.ToString();
			base.SetDebitInfo();
			base.SetAccountInfo();
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			base.ValidateTransactionSpecificParameters();
			base.ValidateAccountInformation();
		}
	}
}