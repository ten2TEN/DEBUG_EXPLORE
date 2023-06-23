using MPS.POS.Utils;
using MSEnum;
using System;
using System.Security;

namespace Transaction
{
	public class TransactionData
	{
		private const string _CLASS = "TransactionData.cs";

		private string _logName = string.Empty;

		private TenderTypes _tenderType = TenderTypes.Unknown;

		private TransactionTypes _transactionType = TransactionTypes.Unknown;

		private MSEnum.AccountType _accountType = MSEnum.AccountType.Unknown;

		private SecureString _track1;

		private SecureString _track2;

		private SecureString _track3;

		private string _cardholderName = string.Empty;

		private SecureString _encryptedBlock;

		private SecureString _encryptedKey;

		private MSEnum.EncryptedFormat _encryptedFormat = MSEnum.EncryptedFormat.Unknown;

		private MSEnum.AccountSource _accountSource = MSEnum.AccountSource.Unknown;

		private SecureString _account;

		private int _expDateMonth;

		private int _expDateYear;

		private string _cvv = string.Empty;

		private Transaction.AVSData _avsData;

		private SecureString _pinBlock;

		private SecureString _dervdKey;

		private double _purchaseAmount;

		private double _cashBackAmount;

		private string _authCode = string.Empty;

		private string _cardUsage = string.Empty;

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

		public string AuthCode
		{
			get
			{
				return this._authCode;
			}
			set
			{
				this._authCode = value;
			}
		}

		public Transaction.AVSData AVSData
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

		public string CardUsage
		{
			get
			{
				return this._cardUsage;
			}
			set
			{
				this._cardUsage = value;
			}
		}

		public double CashBackAmount
		{
			get
			{
				return this._cashBackAmount;
			}
			set
			{
				this._cashBackAmount = value;
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

		public SecureString DervdKey
		{
			get
			{
				return this._dervdKey;
			}
			set
			{
				this._dervdKey = value;
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

		public int ExpDateMonth
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

		public int ExpDateYear
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

		public string LogName
		{
			get
			{
				return this._logName;
			}
			set
			{
				this._logName = value;
			}
		}

		public SecureString PINBlock
		{
			get
			{
				return this._pinBlock;
			}
			set
			{
				this._pinBlock = value;
			}
		}

		public double PurchaseAmount
		{
			get
			{
				return this._purchaseAmount;
			}
			set
			{
				this._purchaseAmount = value;
			}
		}

		public TenderTypes TenderType
		{
			get
			{
				return this._tenderType;
			}
			set
			{
				this._tenderType = value;
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

		public TransactionTypes TransactionType
		{
			get
			{
				return this._transactionType;
			}
			set
			{
				this._transactionType = value;
			}
		}

		public TransactionData(string logName)
		{
			this._track1 = new SecureString();
			this._track2 = new SecureString();
			this._track3 = new SecureString();
			this._encryptedBlock = new SecureString();
			this._encryptedKey = new SecureString();
			this._account = new SecureString();
			this._pinBlock = new SecureString();
			this._dervdKey = new SecureString();
			this._avsData = new Transaction.AVSData();
			this._logName = logName;
		}

		public void MergeTransactionData(TransactionData componentTxnData)
		{
			try
			{
				if (componentTxnData.EncryptedFormat != MSEnum.EncryptedFormat.Unknown)
				{
					this.EncryptedFormat = componentTxnData.EncryptedFormat;
				}
				if (componentTxnData.AccountSource != MSEnum.AccountSource.Unknown)
				{
					this.AccountSource = componentTxnData.AccountSource;
				}
				if (componentTxnData.AccountType != MSEnum.AccountType.Unknown)
				{
					this.AccountType = componentTxnData.AccountType;
				}
				if (componentTxnData.EncryptedBlock != null && componentTxnData.EncryptedBlock.Length > 0)
				{
					this.EncryptedBlock = componentTxnData.EncryptedBlock.Copy();
				}
				if (componentTxnData.EncryptedKey != null && componentTxnData.EncryptedKey.Length > 0)
				{
					this.EncryptedKey = componentTxnData.EncryptedKey.Copy();
				}
				if (componentTxnData.Track1 != null && componentTxnData.Track1.Length > 0)
				{
					this.Track1 = componentTxnData.Track1.Copy();
				}
				if (componentTxnData.Track2 != null && componentTxnData.Track2.Length > 0)
				{
					this.Track2 = componentTxnData.Track2.Copy();
				}
				if (componentTxnData.Track3 != null && componentTxnData.Track3.Length > 0)
				{
					this.Track3 = componentTxnData.Track3.Copy();
				}
				if (componentTxnData.PINBlock != null && componentTxnData.PINBlock.Length > 0)
				{
					this.PINBlock = componentTxnData.PINBlock.Copy();
				}
				if (componentTxnData.DervdKey != null && componentTxnData.DervdKey.Length > 0)
				{
					this.DervdKey = componentTxnData.DervdKey.Copy();
				}
				if (componentTxnData.PurchaseAmount > 0)
				{
					this.PurchaseAmount = componentTxnData.PurchaseAmount;
				}
				if (componentTxnData.CashBackAmount != this.CashBackAmount)
				{
					this.CashBackAmount = componentTxnData.CashBackAmount;
				}
				if (!string.IsNullOrEmpty(componentTxnData.AuthCode))
				{
					this.AuthCode = componentTxnData.AuthCode;
				}
				if (!string.IsNullOrEmpty(componentTxnData.CardUsage))
				{
					this.CardUsage = componentTxnData.CardUsage;
				}
				if (componentTxnData.TenderType != TenderTypes.Unknown)
				{
					this.TenderType = componentTxnData.TenderType;
				}
				if (componentTxnData.TransactionType != TransactionTypes.Unknown)
				{
					this.TransactionType = componentTxnData.TransactionType;
				}
			}
			catch (Exception exception)
			{
				object[] message = new object[] { "TransactionData.cs", "MergeTransactionData", exception.Message };
				Logging.LogData(string.Format("Exception caught. Class = '{0}', method = '{1}', Exception = '{2}'.", message), this._logName);
			}
		}
	}
}