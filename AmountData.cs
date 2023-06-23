using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("ACFF9376-7E65-4b5a-A8B9-D67E53E0CA61")]
	public class AmountData : IAmountData
	{
		private double _purchaseAmount;

		private double _gratuityAmount;

		private double _authorizeAmount;

		private double _cashbackAmount;

		private double _balance;

		private double _fsaPrescriptionAmount;

		private double _fsaAmount;

		public double AuthorizeAmount
		{
			get
			{
				return this._authorizeAmount;
			}
			set
			{
				this._authorizeAmount = value;
			}
		}

		public double Balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				this._balance = value;
			}
		}

		public double CashBackAmount
		{
			get
			{
				return this._cashbackAmount;
			}
			set
			{
				this._cashbackAmount = value;
			}
		}

		public double FSAAmount
		{
			get
			{
				return this._fsaAmount;
			}
			set
			{
				this._fsaAmount = value;
			}
		}

		public double FSAPrescriptionAmount
		{
			get
			{
				return this._fsaPrescriptionAmount;
			}
			set
			{
				this._fsaPrescriptionAmount = value;
			}
		}

		public double GratuityAmount
		{
			get
			{
				return this._gratuityAmount;
			}
			set
			{
				this._gratuityAmount = value;
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

		public AmountData()
		{
		}
	}
}