using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVParamDownloadTransaction : CanadianEMVTransaction
	{
		public CanadianEMVParamDownloadTransaction()
		{
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.EMVParamDownload.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues() for ParamDownload: ", exception.Message));
			}
		}
	}
}