using DSITransaction;
using System;

namespace Transaction
{
	public class AdminBatchCloseTransaction : Transaction
	{
		private BatchInfo _batchInfo;

		public AdminBatchCloseTransaction()
		{
			this._batchInfo = new BatchInfo();
		}

		public override Response ProcessTransaction()
		{
			if (this._batchInfo.ForceBatchClose)
			{
				AdminBatchSummaryTransaction adminBatchSummaryTransaction = new AdminBatchSummaryTransaction()
				{
					Servers = base.Servers,
					UserID = base.UserID,
					MerchantID = base.MerchantID,
					Memo = base.Memo
				};
				Response response = adminBatchSummaryTransaction.ProcessTransaction();
				this._batchInfo.BatchItemCount = response.BatchInfo.BatchItemCount;
				this._batchInfo.BatchNo = response.BatchInfo.BatchNo;
				this._batchInfo.CreditPurchaseAmount = response.BatchInfo.CreditPurchaseAmount;
				this._batchInfo.CreditPurchaseCount = response.BatchInfo.CreditPurchaseCount;
				this._batchInfo.CreditReturnAmount = response.BatchInfo.CreditReturnAmount;
				this._batchInfo.CreditReturnCount = response.BatchInfo.CreditReturnCount;
				this._batchInfo.DebitPurchaseAmount = response.BatchInfo.DebitPurchaseAmount;
				this._batchInfo.DebitPurchaseCount = response.BatchInfo.DebitPurchaseCount;
				this._batchInfo.DebitReturnAmount = response.BatchInfo.DebitReturnAmount;
				this._batchInfo.DebitReturnCount = response.BatchInfo.DebitReturnCount;
				response = null;
			}
			return base.ProcessTransaction();
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			this._batchInfo.BatchNo = request.BatchInfo.BatchNo;
			this._batchInfo.BatchItemCount = request.BatchInfo.BatchItemCount;
			this._batchInfo.CreditPurchaseAmount = request.BatchInfo.CreditPurchaseAmount;
			this._batchInfo.CreditPurchaseCount = request.BatchInfo.CreditPurchaseCount;
			this._batchInfo.CreditReturnCount = request.BatchInfo.CreditReturnCount;
			this._batchInfo.CreditReturnAmount = request.BatchInfo.CreditReturnAmount;
			this._batchInfo.DebitPurchaseAmount = request.BatchInfo.DebitPurchaseAmount;
			this._batchInfo.DebitPurchaseCount = request.BatchInfo.DebitPurchaseCount;
			this._batchInfo.DebitReturnAmount = request.BatchInfo.DebitReturnAmount;
			this._batchInfo.DebitReturnCount = request.BatchInfo.DebitReturnCount;
			this._batchInfo.ForceBatchClose = request.BatchInfo.ForceBatchClose;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranCode = "BatchClose";
			base.dsiTransaction.BatchNo = this._batchInfo.BatchNo.ToString();
			base.dsiTransaction.BatchItemCount = this._batchInfo.BatchItemCount;
			base.dsiTransaction.NetBatchTotal = (decimal)((double)this._batchInfo.NetBatchTotal);
			base.dsiTransaction.CreditPurchaseCount = this._batchInfo.CreditPurchaseCount;
			base.dsiTransaction.CreditPurchaseAmount = (decimal)((double)this._batchInfo.CreditPurchaseAmount);
			base.dsiTransaction.CreditReturnCount = this._batchInfo.CreditReturnCount;
			base.dsiTransaction.CreditReturnAmount = (decimal)((double)this._batchInfo.CreditReturnAmount);
			base.dsiTransaction.DebitPurchaseCount = this._batchInfo.DebitPurchaseCount;
			base.dsiTransaction.DebitPurchaseAmount = (decimal)((double)this._batchInfo.DebitPurchaseAmount);
			base.dsiTransaction.DebitReturnCount = this._batchInfo.DebitReturnCount;
			base.dsiTransaction.DebitReturnAmount = (decimal)((double)this._batchInfo.DebitReturnAmount);
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			if (this._batchInfo.NetBatchTotal < -99999999.99 || this._batchInfo.NetBatchTotal > 99999999.99)
			{
				throw new Exception(StringsReader.GetText("NetBatchTotalError"));
			}
			if (this._batchInfo.BatchNo < 0 || this._batchInfo.BatchNo > 0xf423f)
			{
				throw new Exception(StringsReader.GetText("BatchNoError"));
			}
			if (this._batchInfo.BatchItemCount < 0 || this._batchInfo.BatchItemCount > 0x5f5e0ff)
			{
				throw new Exception(StringsReader.GetText("BatchItemCountError"));
			}
			if (this._batchInfo.CreditPurchaseAmount < 0 || this._batchInfo.CreditPurchaseAmount > 99999999.99)
			{
				throw new Exception(StringsReader.GetText("CreditPurchaseAmountError"));
			}
			if (this._batchInfo.CreditPurchaseCount < 0 || this._batchInfo.CreditPurchaseCount > 0x5f5e0ff)
			{
				throw new Exception(StringsReader.GetText("CreditPurchaseCountError"));
			}
			if (this._batchInfo.CreditReturnCount < 0 || this._batchInfo.CreditReturnCount > 0x5f5e0ff)
			{
				throw new Exception(StringsReader.GetText("CreditReturnCountError"));
			}
			if (this._batchInfo.CreditReturnAmount < 0 || this._batchInfo.CreditReturnAmount > 99999999.99)
			{
				throw new Exception(StringsReader.GetText("CreditReturnAmountError"));
			}
			if (this._batchInfo.DebitPurchaseAmount < 0 || this._batchInfo.DebitPurchaseAmount > 99999999.99)
			{
				throw new Exception(StringsReader.GetText("DebitPurchaseAmountError"));
			}
			if (this._batchInfo.DebitPurchaseCount < 0 || this._batchInfo.DebitPurchaseCount > 0x5f5e0ff)
			{
				throw new Exception(StringsReader.GetText("DebitPurchaseCountError"));
			}
			if (this._batchInfo.DebitReturnAmount < 0 || this._batchInfo.DebitReturnAmount > 99999999.99)
			{
				throw new Exception(StringsReader.GetText("DebitReturnAmountError"));
			}
			if (this._batchInfo.DebitReturnCount < 0 || this._batchInfo.DebitReturnCount > 0x5f5e0ff)
			{
				throw new Exception(StringsReader.GetText("DebitReturnCountError"));
			}
		}
	}
}