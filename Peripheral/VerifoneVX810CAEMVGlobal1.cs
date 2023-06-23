using MSEnum;
using System;
using System.Security;
using Transaction;

namespace Peripheral
{
	public class VerifoneVX810CAEMVGlobal1 : IPeripheral
	{
		public SecureString Account
		{
			set
			{
			}
		}

		public double CashBackAmount
		{
			set
			{
			}
		}

		public string DervdKey
		{
			get
			{
				return string.Empty;
			}
		}

		public string PINBlock
		{
			get
			{
				return string.Empty;
			}
		}

		public double PurchaseAmount
		{
			set
			{
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
				return true;
			}
		}

		public bool SupportsExplicitInitialization
		{
			get
			{
				return false;
			}
		}

		public bool SupportsPinPad
		{
			get
			{
				return false;
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
				return true;
			}
		}

		public VerifoneVX810CAEMVGlobal1()
		{
		}

		public bool GetData(TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount)
		{
			return false;
		}

		public bool GetPin(TenderTypes tenderType, TransactionTypes transactionType)
		{
			return false;
		}

		public bool GetSignatureData()
		{
			return false;
		}

		public bool GetSwipeData()
		{
			return false;
		}

		public bool Initialize(PinPadConfig config, string LogName)
		{
			return false;
		}

		public string ReceiveData()
		{
			return string.Empty;
		}

		public bool SendConfig()
		{
			return false;
		}

		public string SendData(string data)
		{
			return string.Empty;
		}

		public void SetData(PeripheralResponse pr)
		{
		}

		public void SetEncrytpedInfo(DebitTransaction tran)
		{
		}
	}
}