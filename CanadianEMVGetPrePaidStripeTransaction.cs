using DSITransaction;
using MPS.POS.Utils;
using System;

namespace Transaction
{
	public class CanadianEMVGetPrePaidStripeTransaction : CanadianEMVTransaction
	{
		public CanadianEMVGetPrePaidStripeTransaction()
		{
		}

		public override Response ProcessTransaction()
		{
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				CanadianEMVPadResetTransaction canadianEMVPadResetTransaction = new CanadianEMVPadResetTransaction()
				{
					InvoiceNumber = base.InvoiceNumber,
					ReferenceNumber = base.ReferenceNumber,
					PinPadConfig = base.PinPadConfig,
					LogName = base.LogName,
					MerchantID = base.MerchantID,
					UserID = base.UserID,
					HostOrIP = base.HostOrIP,
					IPPort = base.IPPort,
					TerminalID = base.TerminalID,
					MerchantLanguage = base.MerchantLanguage,
					UserTraceData = base.UserTraceData
				};
				empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
				Logging.LogData(empty, base.LogName);
				if (canadianEMVPadResetTransaction.ProcessTransaction().CmdStatus.ToLower() != "success")
				{
					response.CmdStatus = "Error";
					response.ResponseOrigin = "Client";
					response.TextResponse = "Unable to reset pinpad.";
					empty = string.Format("Reset failed for pinpad device: userid:{0}.", base.UserID);
					Logging.LogData(empty, base.LogName);
				}
				else
				{
					response = base.ProcessTransaction();
					empty = string.Format("Sending reset to pinpad device: userid:{0}.", base.UserID);
					Logging.LogData(empty, base.LogName);
					canadianEMVPadResetTransaction.ProcessTransaction();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				response.CmdStatus = "Error";
				response.ResponseOrigin = "Client";
				response.TextResponse = exception.Message;
			}
			return response;
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.GetPrePaidStripe.ToString();
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues() for GetPrePaidStripe: ", exception.Message));
			}
		}
	}
}