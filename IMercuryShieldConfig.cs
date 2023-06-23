using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("A0C2122D-82A6-450f-83CE-67F0514ED6B7")]
	public interface IMercuryShieldConfig
	{
		[DispId(3)]
		bool CVVRequiredOnManualEntry
		{
			get;
			set;
		}

		[DispId(2)]
		bool TopMost
		{
			get;
			set;
		}

		[DispId(1)]
		bool UseEnterAsTab
		{
			get;
			set;
		}
	}
}