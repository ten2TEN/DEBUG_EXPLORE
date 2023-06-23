using MSEnum;
using System;
using System.Security;
using Transaction;

namespace Peripheral
{
	public interface IPeripheral
	{
		SecureString Account
		{
			set;
		}

		double CashBackAmount
		{
			set;
		}

		string DervdKey
		{
			get;
		}

		string PINBlock
		{
			get;
		}

		double PurchaseAmount
		{
			set;
		}

		PeripheralReturnCode ReturnCode
		{
			get;
			set;
		}

		string SignatureData
		{
			get;
		}

		bool SupportsCardReader
		{
			get;
		}

		bool SupportsExplicitInitialization
		{
			get;
		}

		bool SupportsPinPad
		{
			get;
		}

		bool SupportsSignatureCapture
		{
			get;
		}

		bool SupportsUserSelectedTender
		{
			get;
		}

		bool UsesCanadianEMV
		{
			get;
		}

		bool GetData(TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount);

		bool GetPin(TenderTypes tenderType, TransactionTypes transactionType);

		bool GetSignatureData();

		bool GetSwipeData();

		bool Initialize(PinPadConfig config, string LogName);

		string ReceiveData();

		bool SendConfig();

		string SendData(string data);

		void SetData(PeripheralResponse pr);

		void SetEncrytpedInfo(DebitTransaction tran);
	}
}