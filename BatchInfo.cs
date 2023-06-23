using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("787CC27E-E1E2-4613-8655-DACF9EE88090")]
	public class BatchInfo : IBatchInfo
	{
		private int _batchNo;

		private int _batchItemCount;

		private double _netBatchTotal;

		private int _creditPurchaseCount;

		private double _creditPurchaseAmount;

		private int _creditReturnCount;

		private double _creditReturnAmount;

		private int _debitPurchaseCount;

		private double _debitPurchaseAmount;

		private int _debitReturnCount;

		private double _debitReturnAmount;

		private bool _forceBatchClose;

		private string _controlNo = string.Empty;

		public int BatchItemCount
		{
			get
			{
				return this._batchItemCount;
			}
			set
			{
				this._batchItemCount = value;
			}
		}

		public int BatchNo
		{
			get
			{
				return this._batchNo;
			}
			set
			{
				this._batchNo = value;
			}
		}

		public string ControlNo
		{
			get
			{
				return this._controlNo;
			}
			set
			{
				this._controlNo = value;
			}
		}

		public double CreditPurchaseAmount
		{
			get
			{
				return this._creditPurchaseAmount;
			}
			set
			{
				this._creditPurchaseAmount = value;
			}
		}

		public int CreditPurchaseCount
		{
			get
			{
				return this._creditPurchaseCount;
			}
			set
			{
				this._creditPurchaseCount = value;
			}
		}

		public double CreditReturnAmount
		{
			get
			{
				return this._creditReturnAmount;
			}
			set
			{
				this._creditReturnAmount = value;
			}
		}

		public int CreditReturnCount
		{
			get
			{
				return this._creditReturnCount;
			}
			set
			{
				this._creditReturnCount = value;
			}
		}

		public double DebitPurchaseAmount
		{
			get
			{
				return this._debitPurchaseAmount;
			}
			set
			{
				this._debitPurchaseAmount = value;
			}
		}

		public int DebitPurchaseCount
		{
			get
			{
				return this._debitPurchaseCount;
			}
			set
			{
				this._debitPurchaseCount = value;
			}
		}

		public double DebitReturnAmount
		{
			get
			{
				return this._debitReturnAmount;
			}
			set
			{
				this._debitReturnAmount = value;
			}
		}

		public int DebitReturnCount
		{
			get
			{
				return this._debitReturnCount;
			}
			set
			{
				this._debitReturnCount = value;
			}
		}

		public bool ForceBatchClose
		{
			get
			{
				return this._forceBatchClose;
			}
			set
			{
				this._forceBatchClose = value;
			}
		}

		public double NetBatchTotal
		{
			get
			{
				return this._netBatchTotal;
			}
			set
			{
				this._netBatchTotal = value;
			}
		}

		public BatchInfo()
		{
		}
	}
}