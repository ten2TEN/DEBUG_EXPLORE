using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("26E3E212-4312-4533-9615-E5197F67721A")]
	public interface IBatchInfo
	{
		[DispId(3)]
		int BatchItemCount
		{
			get;
			set;
		}

		[DispId(2)]
		int BatchNo
		{
			get;
			set;
		}

		[DispId(13)]
		string ControlNo
		{
			get;
			set;
		}

		[DispId(6)]
		double CreditPurchaseAmount
		{
			get;
			set;
		}

		[DispId(5)]
		int CreditPurchaseCount
		{
			get;
			set;
		}

		[DispId(8)]
		double CreditReturnAmount
		{
			get;
			set;
		}

		[DispId(7)]
		int CreditReturnCount
		{
			get;
			set;
		}

		[DispId(10)]
		double DebitPurchaseAmount
		{
			get;
			set;
		}

		[DispId(9)]
		int DebitPurchaseCount
		{
			get;
			set;
		}

		[DispId(12)]
		double DebitReturnAmount
		{
			get;
			set;
		}

		[DispId(11)]
		int DebitReturnCount
		{
			get;
			set;
		}

		[DispId(1)]
		bool ForceBatchClose
		{
			get;
			set;
		}

		[DispId(4)]
		double NetBatchTotal
		{
			get;
			set;
		}
	}
}