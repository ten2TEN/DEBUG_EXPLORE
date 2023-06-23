using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("EE34A6E6-3850-4edb-ADBB-E6024DA12FF7")]
	public interface IAmountData
	{
		[DispId(5)]
		double AuthorizeAmount
		{
			get;
			set;
		}

		[DispId(1)]
		double Balance
		{
			get;
			set;
		}

		[DispId(2)]
		double CashBackAmount
		{
			get;
			set;
		}

		[DispId(7)]
		double FSAAmount
		{
			get;
			set;
		}

		[DispId(6)]
		double FSAPrescriptionAmount
		{
			get;
			set;
		}

		[DispId(4)]
		double GratuityAmount
		{
			get;
			set;
		}

		[DispId(3)]
		double PurchaseAmount
		{
			get;
			set;
		}
	}
}