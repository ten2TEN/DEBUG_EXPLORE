using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVPadResetTransaction : CanadianEMVTransaction
	{
		public CanadianEMVPadResetTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVPadReset.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues() for PadReset: ", exception.Message));
			}
		}
	}
}