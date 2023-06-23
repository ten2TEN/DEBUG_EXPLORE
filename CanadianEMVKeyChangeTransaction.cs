using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVKeyChangeTransaction : CanadianEMVTransaction
	{
		public CanadianEMVKeyChangeTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVKeyChange.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues() for KeyChange: ", exception.Message));
			}
		}
	}
}