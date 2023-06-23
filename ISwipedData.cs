using System;
using System.Security;

namespace Transaction
{
	internal interface ISwipedData
	{
		SecureString Track1
		{
			get;
			set;
		}

		SecureString Track2
		{
			get;
			set;
		}

		SecureString Track3
		{
			get;
			set;
		}

		SecureString ParseAccountFromTrack1();

		SecureString ParseAccountFromTrack2();

		void ParseExpDateFromTrack1(ref int month, ref int year);

		void ParseExpDateFromTrack2(ref int month, ref int year);

		string ParseNameFromTrack1();
	}
}