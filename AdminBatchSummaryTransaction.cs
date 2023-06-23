using DSITransaction;
using System;

namespace Transaction
{
	public class AdminBatchSummaryTransaction : Transaction
	{
		public AdminBatchSummaryTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "BatchSummary";
		}

		protected override void ValidateTransactionSpecificParameters()
		{
		}
	}
}