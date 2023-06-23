using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVStatisticsReport : CanadianEMVTransaction
	{
		public CanadianEMVStatisticsReport()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVStatisticsReport.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}
	}
}