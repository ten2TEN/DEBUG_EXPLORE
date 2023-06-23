using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVPublicKeyReport : CanadianEMVTransaction
	{
		public CanadianEMVPublicKeyReport()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVPublicKeyReport.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}
	}
}