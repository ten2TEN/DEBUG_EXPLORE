using MSEnum;
using System;
using System.Security;
using Transaction;

namespace Peripheral
{
	public class PeripheralResponse
	{
		// 
		private SecureString u0001;

		// 
		private string u0002 = string.Empty;

		// 
		private string u0003 = string.Empty;

		// 
		private TenderTypes u0004 = TenderTypes.Unknown;

		// 
		private double u0005;

		// 
		private double u0006;

		// 
		private string u0007 = string.Empty;

		// 
		private PeripheralReturnCode u0008 = PeripheralReturnCode.Unknown;

		public double CashBackAmount
		{
			get
			{
				return this.u0006;
			}
			set
			{
				this.u0006 = value;
			}
		}

		public string DervdKey
		{
			get
			{
				return this.u0003;
			}
			set
			{
				this.u0003 = value;
			}
		}

		public string PinBlock
		{
			get
			{
				return this.u0002;
			}
			set
			{
				this.u0002 = value;
			}
		}

		public double PurchaseAmount
		{
			get
			{
				return this.u0005;
			}
			set
			{
				this.u0005 = value;
			}
		}

		public PeripheralReturnCode ReturnCode
		{
			get
			{
				return this.u0008;
			}
			set
			{
				this.u0008 = value;
			}
		}

		public string SignatureData
		{
			get
			{
				return this.u0007;
			}
			set
			{
				this.u0007 = value;
			}
		}

		public TenderTypes TenderType
		{
			get
			{
				return this.u0004;
			}
			set
			{
				this.u0004 = value;
			}
		}

		public SecureString TrackData
		{
			get
			{
				return this.u0001.Copy();
			}
			set
			{
				this.u0001 = value;
			}
		}

		public PeripheralResponse()
		{
			this.u0001 = new SecureString();
		}

		public void SetCardData(CardTransaction transaction)
		{
			transaction.SetAccountType(AccountType.Track2);
			transaction.SetTrack2(this.u0001.Copy());
		}

		public void SetDebitData(DebitTransaction transaction)
		{
			transaction.PinBlock = this.u0002;
			transaction.DervdKey = this.u0003;
		}
	}
}