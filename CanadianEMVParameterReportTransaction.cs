using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVParameterReportTransaction : CanadianEMVTransaction
	{
		public CanadianEMVParameterReportTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVParameterReport.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}
	}
}