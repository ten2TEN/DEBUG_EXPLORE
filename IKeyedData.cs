using System;
using System.Security;

namespace Transaction
{
	internal interface IKeyedData
	{
		SecureString Account
		{
			get;
			set;
		}

		AVSData AVS
		{
			get;
			set;
		}

		string CVV
		{
			get;
			set;
		}

		int ExpirationDateMonth
		{
			get;
			set;
		}

		int ExpirationDateYear
		{
			get;
			set;
		}
	}
}