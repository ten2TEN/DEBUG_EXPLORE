using MSEnum;
using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("C5CA11DF-50C0-4848-941C-F0792E6B84F1")]
	public class PinPadConfig : IPinPadConfig
	{
		private Transaction.PinPadConnectionMethod _pinPadConnectionMethod = Transaction.PinPadConnectionMethod.Unknown;

		private int _comPort;

		private int _timeOutValue = 30;

		private Transaction.PinPadType _pinPadType = Transaction.PinPadType.Unknown;

		private int _delayBeforeSendingDataToDevice;

		private string _sequenceNumber = string.Empty;

		private string _merchantID = string.Empty;

		private double _debitMaxCashBack;

		private double _ebtMaxCashBack;

		private string _hostOrIP = string.Empty;

		private string _ipPort = string.Empty;

		private string _supportedTransactionsString = string.Empty;

		private TenderTypes[] _supportedTransactions = new TenderTypes[] { TenderTypes.Credit, TenderTypes.Debit, TenderTypes.EBT, TenderTypes.PrePaid };

		private bool _captureSignature;

		private bool _ebtManual;

		private bool _cancelDialogueConfig;

		private bool _cancelDialogueGetData;

		private bool _cancelDialogueGetPin;

		private bool _cancelDialogueGetSignature;

		private bool _noManualAfterSwipe;

		private bool _initializePinPad = true;

		public bool CancelDialogueConfig
		{
			get
			{
				return this._cancelDialogueConfig;
			}
			set
			{
				this._cancelDialogueConfig = value;
			}
		}

		public bool CancelDialogueGetData
		{
			get
			{
				return this._cancelDialogueGetData;
			}
			set
			{
				this._cancelDialogueGetData = value;
			}
		}

		public bool CancelDialogueGetPin
		{
			get
			{
				return this._cancelDialogueGetPin;
			}
			set
			{
				this._cancelDialogueGetPin = value;
			}
		}

		public bool CancelDialogueGetSignature
		{
			get
			{
				return this._cancelDialogueGetSignature;
			}
			set
			{
				this._cancelDialogueGetSignature = value;
			}
		}

		public bool CaptureSignature
		{
			get
			{
				return this._captureSignature;
			}
			set
			{
				this._captureSignature = value;
			}
		}

		public int ComPort
		{
			get
			{
				return this._comPort;
			}
			set
			{
				this._comPort = value;
			}
		}

		public double DebitMaxCashBack
		{
			get
			{
				return this._debitMaxCashBack;
			}
			set
			{
				this._debitMaxCashBack = value;
			}
		}

		public int DelayBeforeSendingDataToDevice
		{
			get
			{
				return this._delayBeforeSendingDataToDevice;
			}
			set
			{
				this._delayBeforeSendingDataToDevice = value;
			}
		}

		public bool EBTManual
		{
			get
			{
				return this._ebtManual;
			}
			set
			{
				this._ebtManual = value;
			}
		}

		public double EBTMaxCashBack
		{
			get
			{
				return this._ebtMaxCashBack;
			}
			set
			{
				this._ebtMaxCashBack = value;
			}
		}

		public string HostOrIP
		{
			get
			{
				return this._hostOrIP;
			}
			set
			{
				this._hostOrIP = value;
			}
		}

		public bool InitializePinPad
		{
			get
			{
				return this._initializePinPad;
			}
			set
			{
				this._initializePinPad = value;
			}
		}

		public string IPPort
		{
			get
			{
				return this._ipPort;
			}
			set
			{
				this._ipPort = value;
			}
		}

		public string MerchantID
		{
			get
			{
				return this._merchantID;
			}
			set
			{
				this._merchantID = value;
			}
		}

		public bool NoManualAfterSwipe
		{
			get
			{
				return this._noManualAfterSwipe;
			}
			set
			{
				this._noManualAfterSwipe = value;
			}
		}

		public Transaction.PinPadConnectionMethod PinPadConnectionMethod
		{
			get
			{
				return this._pinPadConnectionMethod;
			}
			set
			{
				this._pinPadConnectionMethod = value;
			}
		}

		public Transaction.PinPadType PinPadType
		{
			get
			{
				return this._pinPadType;
			}
			set
			{
				this._pinPadType = value;
			}
		}

		public string SequenceNumber
		{
			get
			{
				return this._sequenceNumber;
			}
			set
			{
				this._sequenceNumber = value;
			}
		}

		public TenderTypes[] SupportedTransactions
		{
			get
			{
				return this._supportedTransactions;
			}
			set
			{
				this._supportedTransactions = value;
			}
		}

		public string SupportedTransactionsString
		{
			get
			{
				return this._supportedTransactionsString;
			}
			set
			{
				this._supportedTransactionsString = value;
			}
		}

		public int TimeOutValue
		{
			get
			{
				return this._timeOutValue;
			}
			set
			{
				this._timeOutValue = value;
			}
		}

		public PinPadConfig()
		{
		}
	}
}