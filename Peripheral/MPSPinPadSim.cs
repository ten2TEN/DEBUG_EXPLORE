using MPS.POS.Utils;
using MSEnum;
using System;
using System.Runtime.InteropServices;
using System.Security;
using Transaction;

namespace Peripheral
{
	public class MPSPinPadSim : IPeripheral
	{
		// 
		private const double u0001 = 9999.99;

		// 
		private string u0002 = string.Empty;

		// 
		private string u0003 = string.Empty;

		// 
		private SecureString u0004;

		// 
		private double u0005;

		// 
		private int u0006 = 30;

		// 
		private PinPadConnectionMethod u0007 = PinPadConnectionMethod.Unknown;

		// 
		private int u0008;

		// 
		private int u000e;

		// 
		private double u000f;

		// 
		private string u0010 = string.Empty;

		public SecureString Account
		{
			set
			{
				this.u0004 = value;
			}
		}

		public double CashBackAmount
		{
			set
			{
				this.u0015u0003(this.u0005, value);
				this.u000f = value;
			}
		}

		public string DervdKey
		{
			get
			{
				return this.u0003;
			}
		}

		public string PINBlock
		{
			get
			{
				return this.u0002;
			}
		}

		public double PurchaseAmount
		{
			set
			{
				this.u0015u0003(value, this.u000f);
				this.u0005 = value;
			}
		}

		public PeripheralReturnCode ReturnCode
		{
			get
			{
				return PeripheralReturnCode.Ok;
			}
			set
			{
			}
		}

		public string SignatureData
		{
			get
			{
				return string.Empty;
			}
		}

		public bool SupportsCardReader
		{
			get
			{
				return false;
			}
		}

		public bool SupportsExplicitInitialization
		{
			get
			{
				return true;
			}
		}

		public bool SupportsPinPad
		{
			get
			{
				return true;
			}
		}

		public bool SupportsSignatureCapture
		{
			get
			{
				return false;
			}
		}

		public bool SupportsUserSelectedTender
		{
			get
			{
				return false;
			}
		}

		public bool UsesCanadianEMV
		{
			get
			{
				return false;
			}
		}

		// 
		private void u0015u0003(double purchaseAmount, double cashBackAmount)
		{
			if (purchaseAmount + cashBackAmount > 9999.99)
			{
				throw new Exception("The total amount of a debit transaction cannot exceed $9999.99.  Please cancel the transaction and modify the amount in the POS.");
			}
		}

		public MPSPinPadSim()
		{
			this.u0004 = new SecureString();
		}

		public bool GetData(TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount)
		{
			return false;
		}

		public bool GetPin(TenderTypes tenderType, TransactionTypes transactionType)
		{
			string empty = string.Empty;
			empty = string.Format("getting pin from mpspinpadsim pinpad.", new object[0]);
			Logging.LogData(empty, this.u0010);
			string stringUni = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(this.u0004));
			if (stringUni == "5499990123456781")
			{
				this.u0002 = "15DDEEE32989FE16";
				this.u0003 = "3D01000005600013";
			}
			else if (stringUni != "4003000123456781")
			{
				this.u0002 = "1111111111111111";
				this.u0003 = "1111111111111111";
			}
			else
			{
				this.u0002 = "57B86D207E95A0C3";
				this.u0003 = "3D01000005600014";
			}
			return true;
		}

		public bool GetSignatureData()
		{
			return false;
		}

		public bool GetSwipeData()
		{
			return false;
		}

		public bool Initialize(PinPadConfig config, string logName)
		{
			string empty = string.Empty;
			this.u0010 = logName;
			empty = string.Format("initializing pinpad information.", new object[0]);
			Logging.LogData(empty, this.u0010);
			this.u0007 = config.PinPadConnectionMethod;
			this.u0006 = config.TimeOutValue;
			if (config.ComPort <= 0 || config.ComPort > 254)
			{
				return false;
			}
			this.u0008 = config.ComPort;
			this.u000e = config.DelayBeforeSendingDataToDevice;
			return true;
		}

		public string ReceiveData()
		{
			throw new NotImplementedException();
		}

		public bool SendConfig()
		{
			string empty = string.Empty;
			if (this.u0010 == "TestFailure")
			{
				return false;
			}
			empty = string.Format("sending mpspinpadsim pinpad config info.", new object[0]);
			Logging.LogData(empty, this.u0010);
			empty = string.Format("success sending change prompt.", new object[0]);
			Logging.LogData(empty, this.u0010);
			return true;
		}

		public string SendData(string data)
		{
			return "simmulated message from pinpad";
		}

		public void SetData(PeripheralResponse pr)
		{
		}

		public void SetEncrytpedInfo(DebitTransaction tran)
		{
			tran.DervdKey = this.u0003;
			tran.PinBlock = this.u0002;
		}
	}
}