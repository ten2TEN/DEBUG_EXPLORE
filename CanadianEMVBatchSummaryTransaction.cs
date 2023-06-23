using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVBatchSummaryTransaction : CanadianEMVTransaction
	{
		public CanadianEMVBatchSummaryTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.BatchSummary.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}
	}
}