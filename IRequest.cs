using MSEnum;
using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[Guid("31526136-D233-4d39-AE23-8D95B0B29802")]
	public interface IRequest
	{
		[DispId(7)]
		string AcqRefData
		{
			get;
			set;
		}

		[DispId(34)]
		AVSData AddressData
		{
			get;
			set;
		}

		[DispId(4)]
		Transaction.AmountData AmountData
		{
			get;
			set;
		}

		[DispId(14)]
		string AuthCode
		{
			get;
			set;
		}

		[DispId(5)]
		Transaction.BatchInfo BatchInfo
		{
			get;
			set;
		}

		[DispId(28)]
		bool CanadianEMVCreditManualEntry
		{
			get;
			set;
		}

		[DispId(29)]
		bool CanadianEMVGratuityPrompt
		{
			get;
			set;
		}

		[DispId(24)]
		string CanadianEMVTerminalID
		{
			get;
			set;
		}

		[DispId(30)]
		bool CancelDialogueTransaction
		{
			get;
			set;
		}

		[DispId(27)]
		string CardType
		{
			get;
			set;
		}

		[DispId(9)]
		string CreditServers
		{
			get;
			set;
		}

		[DispId(35)]
		MSEnum.FSACardNotPresented FSACardNotPresented
		{
			get;
			set;
		}

		[DispId(10)]
		string GiftServers
		{
			get;
			set;
		}

		[DispId(31)]
		string ImplementationType
		{
			get;
			set;
		}

		[DispId(12)]
		string InvoiceNumber
		{
			get;
			set;
		}

		[DispId(18)]
		Transaction.LevelIIData LevelIIData
		{
			get;
			set;
		}

		[DispId(6)]
		string Memo
		{
			get;
			set;
		}

		[DispId(8)]
		string MerchantID
		{
			get;
			set;
		}

		[DispId(26)]
		string MerchantLanguage
		{
			get;
			set;
		}

		[DispId(17)]
		Transaction.MercuryShieldConfig MercuryShieldConfig
		{
			get;
			set;
		}

		[DispId(16)]
		bool Override
		{
			set;
		}

		[DispId(1)]
		Transaction.PinPadConfig PinPadConfig
		{
			get;
			set;
		}

		[DispId(23)]
		string PrePaidAccount
		{
			get;
			set;
		}

		[DispId(19)]
		string ProcessData
		{
			get;
			set;
		}

		[DispId(32)]
		string ProcessingSetName
		{
			get;
			set;
		}

		[DispId(13)]
		string ReferenceNumber
		{
			get;
			set;
		}

		[DispId(2)]
		TenderTypes TenderType
		{
			get;
			set;
		}

		[DispId(22)]
		string TerminalName
		{
			get;
			set;
		}

		[DispId(20)]
		string Token
		{
			get;
			set;
		}

		[DispId(21)]
		TokenFrequencies TokenFrequency
		{
			get;
			set;
		}

		[DispId(3)]
		TransactionTypes TransactionType
		{
			get;
			set;
		}

		[DispId(11)]
		string UserID
		{
			get;
			set;
		}

		[DispId(25)]
		string UserTraceData
		{
			get;
			set;
		}

		[DispId(33)]
		string VoucherNo
		{
			get;
			set;
		}

		[DispId(15)]
		string Xml
		{
			set;
		}
	}
}