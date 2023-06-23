using MSEnum;
using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("08502B93-56C0-4d6b-BE73-154DD82374C8")]
	public interface IPinPadConfig
	{
		[DispId(16)]
		bool CancelDialogueConfig
		{
			get;
			set;
		}

		[DispId(17)]
		bool CancelDialogueGetData
		{
			get;
			set;
		}

		[DispId(18)]
		bool CancelDialogueGetPin
		{
			get;
			set;
		}

		[DispId(19)]
		bool CancelDialogueGetSignature
		{
			get;
			set;
		}

		[DispId(11)]
		bool CaptureSignature
		{
			get;
			set;
		}

		[DispId(3)]
		int ComPort
		{
			get;
			set;
		}

		[DispId(8)]
		double DebitMaxCashBack
		{
			get;
			set;
		}

		[DispId(5)]
		int DelayBeforeSendingDataToDevice
		{
			get;
			set;
		}

		[DispId(12)]
		bool EBTManual
		{
			get;
			set;
		}

		[DispId(9)]
		double EBTMaxCashBack
		{
			get;
			set;
		}

		[DispId(14)]
		string HostOrIP
		{
			get;
			set;
		}

		[DispId(21)]
		bool InitializePinPad
		{
			get;
			set;
		}

		[DispId(15)]
		string IPPort
		{
			get;
			set;
		}

		[DispId(7)]
		string MerchantID
		{
			get;
			set;
		}

		[DispId(20)]
		bool NoManualAfterSwipe
		{
			get;
			set;
		}

		[DispId(2)]
		Transaction.PinPadConnectionMethod PinPadConnectionMethod
		{
			get;
			set;
		}

		[DispId(1)]
		Transaction.PinPadType PinPadType
		{
			get;
			set;
		}

		[DispId(6)]
		string SequenceNumber
		{
			get;
			set;
		}

		[DispId(10)]
		TenderTypes[] SupportedTransactions
		{
			get;
			set;
		}

		[DispId(13)]
		string SupportedTransactionsString
		{
			get;
			set;
		}

		[DispId(4)]
		int TimeOutValue
		{
			get;
			set;
		}
	}
}