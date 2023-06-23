using MSEnum;
using System;
using System.Security;

namespace Transaction
{
	internal interface IEncryptedData
	{
		MSEnum.AccountSource AccountSource
		{
			get;
			set;
		}

		SecureString EncryptedBlock
		{
			get;
			set;
		}

		MSEnum.EncryptedFormat EncryptedFormat
		{
			get;
			set;
		}

		SecureString EncryptedKey
		{
			get;
			set;
		}
	}
}