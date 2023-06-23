using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("D10ACD31-DF1D-44b1-9E32-5C352F7E45AD")]
	public interface IAVSData
	{
		[DispId(1)]
		string Address
		{
			get;
			set;
		}

		[DispId(2)]
		string ZipCode
		{
			get;
			set;
		}
	}
}