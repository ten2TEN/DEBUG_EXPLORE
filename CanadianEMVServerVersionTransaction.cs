using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVServerVersionTransaction : CanadianEMVTransaction
	{
		public CanadianEMVServerVersionTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.ServerVersion.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
		}
	}
}