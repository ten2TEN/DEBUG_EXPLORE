using DSITransaction;
using System;

namespace Transaction
{
	public class AdminBatchClearTransaction : Transaction
	{
		public AdminBatchClearTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "BatchClear";
		}

		protected override void ValidateTransactionSpecificParameters()
		{
		}
	}
}