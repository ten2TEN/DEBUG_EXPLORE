using DSITransaction;
using MSEnum;
using System;
using System.Security;

namespace Transaction
{
	public class CardTransaction : Transaction
	{
		public const int _ACCOUNT_SOURCE_MAX_LENGTH = 25;

		public const int _ENCRYPTED_FORMAT_MAX_LENGTH = 25;

		public const int _ENCRYPTED_BLOCK_MAX_LENGTH = 224;

		public const int _ENCRYPTED_KEY_MIN_MAX_LENGTH = 20;

		private Transaction.CardData _cardData;

		private Transaction.AmountData _amountData;

		public Transaction.AmountData AmountData
		{
			get
			{
				return this._amountData;
			}
			set
			{
				this._amountData = value;
			}
		}

		protected Transaction.CardData CardData
		{
			get
			{
				return this._cardData;
			}
			set
			{
				this._cardData = value;
			}
		}

		public CardTransaction()
		{
			this._cardData = new Transaction.CardData();
			this._amountData = new Transaction.AmountData();
		}

		public void SetAccount(SecureString account)
		{
			this._cardData.Account = account.Copy();
		}

		public void SetAccountInfo()
		{
			if (!string.IsNullOrEmpty(this._cardData.CardholderName))
			{
				base.dsiTransaction.CardholderName = this._cardData.CardholderName;
			}
			switch (this._cardData.AccountType)
			{
				case AccountType.Track1:
				{
					base.dsiTransaction.Track1 = this._cardData.Track1.Copy();
					return;
				}
				case AccountType.Track2:
				{
					base.dsiTransaction.Track2 = this._cardData.Track2.Copy();
					return;
				}
				case AccountType.Keyed:
				{
					base.dsiTransaction.AcctNo = this._cardData.Account.Copy();
					netTransaction _netTransaction = base.dsiTransaction;
					string str = string.Format("{0:00}", this._cardData.ExpirationDateMonth);
					int expirationDateYear = this._cardData.ExpirationDateYear;
					_netTransaction.ExpDate = string.Concat(str, expirationDateYear.ToString().Substring(2, 2));
					return;
				}
				case AccountType.Unknown:
				{
					throw new Exception("Unknown Account Type entered, no Account Info set.");
				}
				case AccountType.E2ESwiped:
				case AccountType.E2EKeyed:
				{
					base.dsiTransaction.EncryptedBlock = this._cardData.EncryptedBlock.Copy();
					base.dsiTransaction.EncryptedKey = this._cardData.EncryptedKey.Copy();
					switch (this._cardData.AccountSource)
					{
						case AccountSource.Swiped:
						{
							base.dsiTransaction.AccountSource = netTransaction.eAccountSource.Swiped;
							break;
						}
						case AccountSource.Keyed:
						{
							base.dsiTransaction.AccountSource = netTransaction.eAccountSource.Keyed;
							break;
						}
						case AccountSource.Contactless:
						{
							base.dsiTransaction.AccountSource = netTransaction.eAccountSource.Contactless;
							break;
						}
					}
					if (this._cardData.EncryptedFormat != EncryptedFormat.MagneSafe)
					{
						return;
					}
					base.dsiTransaction.EncryptedFormat = netTransaction.eEncryptedFormat.MagneSafe;
					return;
				}
				default:
				{
					throw new Exception("Unknown Account Type entered, no Account Info set.");
				}
			}
		}

		public void SetAccountSource(AccountSource accountSource)
		{
			this._cardData.AccountSource = accountSource;
		}

		public void SetAccountType(AccountType accountType)
		{
			this._cardData.AccountType = accountType;
		}

		public void SetAVSAddress(string address)
		{
			this._cardData.AVS.Address = address;
		}

		public void SetAVSZipCode(string zipcode)
		{
			this._cardData.AVS.ZipCode = zipcode;
		}

		public void SetCardholderName(string cardholderName)
		{
			this._cardData.CardholderName = cardholderName;
		}

		public void SetCVV(string cvv)
		{
			this._cardData.CVV = cvv;
		}

		public void SetEncryptedBlock(SecureString encryptedBlock)
		{
			this._cardData.EncryptedBlock = encryptedBlock.Copy();
		}

		public void SetEncryptedFormat(EncryptedFormat encryptedFormat)
		{
			this._cardData.EncryptedFormat = encryptedFormat;
		}

		public void SetEncryptedKey(SecureString encryptedKey)
		{
			this._cardData.EncryptedKey = encryptedKey.Copy();
		}

		public void SetExpirationDateMonth(int month)
		{
			this._cardData.ExpirationDateMonth = month;
		}

		public void SetExpirationDateYear(int year)
		{
			this._cardData.ExpirationDateYear = year;
		}

		public override void SetInternalMemberVariables(Request request)
		{
			if (request.AmountData.PurchaseAmount > 0)
			{
				this.AmountData.PurchaseAmount = request.AmountData.PurchaseAmount;
			}
			if (request.AmountData.GratuityAmount > 0)
			{
				this.AmountData.GratuityAmount = request.AmountData.GratuityAmount;
			}
			if (request.AmountData.AuthorizeAmount > 0)
			{
				this.AmountData.AuthorizeAmount = request.AmountData.AuthorizeAmount;
			}
			if (request.AmountData.CashBackAmount > 0)
			{
				this.AmountData.CashBackAmount = request.AmountData.CashBackAmount;
			}
			base.SetInternalMemberVariables(request);
		}

		public void SetTrack1(SecureString track1)
		{
			this._cardData.Track1 = track1.Copy();
		}

		public void SetTrack2(SecureString track2)
		{
			this._cardData.Track2 = track2.Copy();
		}

		public void SetTrack3(SecureString track3)
		{
			this._cardData.Track3 = track3.Copy();
		}

		protected override void SetValues()
		{
			throw new NotImplementedException();
		}

		protected void ValidateAccountInformation()
		{
			if (this._cardData.AccountType == AccountType.Track1)
			{
				if (this._cardData.Track1.Length <= 0)
				{
					throw new Exception("You specified track1 data but there is no data in the track1 field.");
				}
				if (this._cardData.Track1.Length > 79)
				{
					throw new Exception("Track1 data is not in the correct format.");
				}
			}
			else if (this._cardData.AccountType == AccountType.Track2)
			{
				if (this._cardData.Track2.Length <= 0)
				{
					throw new Exception("You specified track2 data but there is no data in the track2 field.");
				}
				if (this._cardData.Track2.Length > 40)
				{
					throw new Exception("Track2 data is not in the correct format.");
				}
			}
			else if (this._cardData.AccountType != AccountType.Keyed)
			{
				if (this._cardData.AccountType != AccountType.E2EContactless && this._cardData.AccountType != AccountType.E2EKeyed && this._cardData.AccountType != AccountType.E2ESwiped)
				{
					throw new Exception("Please specify a value for accounttype prior to processing a transaction.");
				}
				if (this._cardData.AccountSource == AccountSource.Unknown)
				{
					throw new Exception("You specified E2E data, but Account Source field is Unknown.");
				}
				if (this._cardData.AccountSource.ToString().Length > 25)
				{
					int num = 25;
					throw new Exception(string.Concat("Account Source data is not in the correct format, ", num.ToString(), " character max length."));
				}
				if (this._cardData.EncryptedFormat == EncryptedFormat.Unknown)
				{
					throw new Exception("You specified E2E data, but Encrypted Format field is Unknown.");
				}
				if (this._cardData.AccountSource.ToString().Length > 25)
				{
					int num1 = 25;
					throw new Exception(string.Concat("Encrypted Format data is not in the correct format, ", num1.ToString(), " character max length."));
				}
				if (this._cardData.EncryptedBlock.Length == 0)
				{
					throw new Exception("You specified E2E data, but there is no data in the Encrypted Block field.");
				}
				if (this._cardData.EncryptedBlock.Length > 224)
				{
					int num2 = 224;
					throw new Exception(string.Concat("Encrypted Block data is not in the correct format, ", num2.ToString(), " character max length."));
				}
				if (this._cardData.EncryptedKey.Length == 0)
				{
					throw new Exception("You specified E2E data, but there is no data in the Encrypted Key field.");
				}
				if (this._cardData.EncryptedKey.Length != 20)
				{
					int num3 = 20;
					throw new Exception(string.Concat("Encrypted Key data is not in the correct format, Key data must be equal to ", num3.ToString(), " characters."));
				}
			}
			else
			{
				if (this._cardData.Account.Length <= 0)
				{
					throw new Exception("You specified keyed data but there is no data in the account field.");
				}
				if (this._cardData.Account.Length > 38)
				{
					throw new Exception("Account data is not in the correct format.");
				}
				if (this._cardData.ExpirationDateMonth <= 0)
				{
					throw new Exception("You specified keyed data but there is no data in the Expiration Date Month field.");
				}
				if (this._cardData.ExpirationDateMonth > 12)
				{
					throw new Exception("Expiration Month is not in the correct format.");
				}
				if (this._cardData.ExpirationDateYear <= 0)
				{
					throw new Exception("You specified keyed data but there is no data in the Expiration Date Year field.");
				}
				if (this._cardData.ExpirationDateYear < DateTime.Now.Year)
				{
					throw new Exception("Expiration Year is not in the correct format.");
				}
				if (this._cardData.ExpirationDateYear == DateTime.Now.Year && this._cardData.ExpirationDateMonth < DateTime.Now.Month)
				{
					throw new Exception("You specified an invalid Expiration Date.  Current month is after the user inputted date.");
				}
			}
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			throw new NotImplementedException();
		}
	}
}