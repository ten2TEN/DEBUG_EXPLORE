using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("DEBB5636-244D-47b3-BDD3-5337BD316AB2")]
	public interface ILevelII
	{
		[DispId(2)]
		string CustomerCode
		{
			get;
			set;
		}

		[DispId(1)]
		double TaxAmount
		{
			get;
			set;
		}
	}
}