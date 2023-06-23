using MSEnum;
using System;
using System.Security;

namespace Transaction
{
	public class CardData : ISwipedData, IKeyedData, IEncryptedData
	{
		private SecureString _track1;

		private SecureString _track2;

		private SecureString _track3;

		private SecureString _account;

		private int _expDateMonth;

		private int _expDateYear;

		private string _cvv = string.Empty;

		private AVSData _avsData;

		private MSEnum.AccountType _accountType = MSEnum.AccountType.Unknown;

		private string _cardholderName = string.Empty;

		private SecureString _encryptedBlock;

		private SecureString _encryptedKey;

		private MSEnum.EncryptedFormat _encryptedFormat = MSEnum.EncryptedFormat.Unknown;

		private MSEnum.AccountSource _accountSource = MSEnum.AccountSource.Unknown;

		public SecureString Account
		{
			get
			{
				return this._account;
			}
			set
			{
				this._account = value;
			}
		}

		public MSEnum.AccountSource AccountSource
		{
			get
			{
				return this._accountSource;
			}
			set
			{
				this._accountSource = value;
			}
		}

		public MSEnum.AccountType AccountType
		{
			get
			{
				return this._accountType;
			}
			set
			{
				this._accountType = value;
			}
		}

		public AVSData AVS
		{
			get
			{
				return this._avsData;
			}
			set
			{
				this._avsData = value;
			}
		}

		public string CardholderName
		{
			get
			{
				return this._cardholderName;
			}
			set
			{
				this._cardholderName = value;
			}
		}

		public string CVV
		{
			get
			{
				return this._cvv;
			}
			set
			{
				this._cvv = value;
			}
		}

		public SecureString EncryptedBlock
		{
			get
			{
				return this._encryptedBlock;
			}
			set
			{
				this._encryptedBlock = value;
			}
		}

		public MSEnum.EncryptedFormat EncryptedFormat
		{
			get
			{
				return this._encryptedFormat;
			}
			set
			{
				this._encryptedFormat = value;
			}
		}

		public SecureString EncryptedKey
		{
			get
			{
				return this._encryptedKey;
			}
			set
			{
				this._encryptedKey = value;
			}
		}

		public int ExpirationDateMonth
		{
			get
			{
				return this._expDateMonth;
			}
			set
			{
				this._expDateMonth = value;
			}
		}

		public int ExpirationDateYear
		{
			get
			{
				return this._expDateYear;
			}
			set
			{
				this._expDateYear = value;
			}
		}

		public SecureString Track1
		{
			get
			{
				return this._track1;
			}
			set
			{
				this._track1 = value;
			}
		}

		public SecureString Track2
		{
			get
			{
				return this._track2;
			}
			set
			{
				this._track2 = value;
			}
		}

		public SecureString Track3
		{
			get
			{
				return this._track3;
			}
			set
			{
				this._track3 = value;
			}
		}

		public CardData()
		{
			this._avsData = new AVSData();
			this._track1 = new SecureString();
			this._track2 = new SecureString();
			this._account = new SecureString();
			this._encryptedBlock = new SecureString();
			this._encryptedKey = new SecureString();
		}

		public SecureString ParseAccountFromTrack1()
		{
			throw new NotImplementedException();
		}

		public SecureString ParseAccountFromTrack2()
		{
			throw new NotImplementedException();
		}

		public void ParseExpDateFromTrack1(ref int month, ref int year)
		{
			throw new NotImplementedException();
		}

		public void ParseExpDateFromTrack2(ref int month, ref int year)
		{
			throw new NotImplementedException();
		}

		public string ParseNameFromTrack1()
		{
			throw new NotImplementedException();
		}
	}
}