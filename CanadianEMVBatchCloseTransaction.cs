using DSITransaction;
using System;

namespace Transaction
{
	public class CanadianEMVBatchCloseTransaction : CanadianEMVTransaction
	{
		private BatchInfo _batchInfo;

		public CanadianEMVBatchCloseTransaction()
		{
			this._batchInfo = new BatchInfo();
		}

		public override Response ProcessTransaction()
		{
			Response response;
			try
			{
				if (this._batchInfo.ForceBatchClose)
				{
					CanadianEMVBatchSummaryTransaction canadianEMVBatchSummaryTransaction = new CanadianEMVBatchSummaryTransaction()
					{
						PinPadConfig = base.PinPadConfig,
						MerchantLanguage = base.MerchantLanguage,
						UserID = base.UserID,
						MerchantID = base.MerchantID,
						Memo = base.Memo
					};
					Response response1 = canadianEMVBatchSummaryTransaction.ProcessTransaction();
					this._batchInfo.BatchNo = response1.BatchInfo.BatchNo;
					this._batchInfo.BatchItemCount = response1.BatchInfo.BatchItemCount;
					this._batchInfo.NetBatchTotal = response1.BatchInfo.NetBatchTotal;
					this._batchInfo.CreditPurchaseAmount = response1.BatchInfo.CreditPurchaseAmount;
					this._batchInfo.CreditPurchaseCount = response1.BatchInfo.CreditPurchaseCount;
					this._batchInfo.CreditReturnAmount = response1.BatchInfo.CreditReturnAmount;
					this._batchInfo.CreditReturnCount = response1.BatchInfo.CreditReturnCount;
					this._batchInfo.DebitPurchaseAmount = response1.BatchInfo.DebitPurchaseAmount;
					this._batchInfo.DebitPurchaseCount = response1.BatchInfo.DebitPurchaseCount;
					this._batchInfo.DebitReturnAmount = response1.BatchInfo.DebitReturnAmount;
					this._batchInfo.DebitReturnCount = response1.BatchInfo.DebitReturnCount;
					response1 = null;
				}
				response = base.ProcessTransaction();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Response response2 = new Response()
				{
					CmdStatus = "Error",
					ResponseOrigin = "Client",
					TextResponse = exception.Message
				};
				response = response2;
			}
			return response;
		}

		public override void SetInternalMemberVariables(Request request)
		{
			try
			{
				this._batchInfo.BatchNo = request.BatchInfo.BatchNo;
				this._batchInfo.BatchItemCount = request.BatchInfo.BatchItemCount;
				this._batchInfo.NetBatchTotal = request.BatchInfo.NetBatchTotal;
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
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetInternalMemberVariables(): ", exception.Message));
			}
		}

		protected override void SetValues()
		{
			try
			{
				base.DSIEmvTransaction.TranCode = DSIEMVTransaction.eEMVTranCode.BatchClose.ToString();
				base.DSIEmvTransaction.BatchNo = this._batchInfo.BatchNo.ToString();
				base.DSIEmvTransaction.BatchItemCount = this._batchInfo.BatchItemCount;
				base.DSIEmvTransaction.NetBatchTotal = (decimal)((double)this._batchInfo.NetBatchTotal);
				base.DSIEmvTransaction.CreditPurchaseCount = this._batchInfo.CreditPurchaseCount;
				base.DSIEmvTransaction.CreditPurchaseAmount = (decimal)((double)this._batchInfo.CreditPurchaseAmount);
				base.DSIEmvTransaction.CreditReturnCount = this._batchInfo.CreditReturnCount;
				base.DSIEmvTransaction.CreditReturnAmount = (decimal)((double)this._batchInfo.CreditReturnAmount);
				base.DSIEmvTransaction.DebitPurchaseCount = this._batchInfo.DebitPurchaseCount;
				base.DSIEmvTransaction.DebitPurchaseAmount = (decimal)((double)this._batchInfo.DebitPurchaseAmount);
				base.DSIEmvTransaction.DebitReturnCount = this._batchInfo.DebitReturnCount;
				base.DSIEmvTransaction.DebitReturnAmount = (decimal)((double)this._batchInfo.DebitReturnAmount);
				base.SetValues();
			}
			catch (Exception exception)
			{
				throw new Exception(string.Concat("An error occurred when calling SetValues(): ", exception.Message));
			}
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