using MSEnum;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Transaction
{
	[Guid("68A910B5-68E6-455c-9C86-E9D720B4CE0D")]
	public interface IResponse
	{
		[DispId(15)]
		string Account
		{
			get;
			set;
		}

		[DispId(29)]
		string AcqRefData
		{
			get;
			set;
		}

		[DispId(3)]
		Transaction.AmountData AmountData
		{
			get;
			set;
		}

		[DispId(20)]
		string AuthCode
		{
			get;
			set;
		}

		[DispId(21)]
		string AvsResult
		{
			get;
			set;
		}

		[DispId(37)]
		string BankRespCode
		{
			get;
			set;
		}

		[DispId(4)]
		Transaction.BatchInfo BatchInfo
		{
			get;
			set;
		}

		[DispId(50)]
		string CanadianEMVTerminalID
		{
			get;
			set;
		}

		[DispId(24)]
		string CaptureStatus
		{
			get;
			set;
		}

		[DispId(44)]
		string CardholderName
		{
			get;
			set;
		}

		[DispId(17)]
		string CardType
		{
			get;
			set;
		}

		[DispId(56)]
		string CardUsage
		{
			get;
			set;
		}

		[DispId(9)]
		string CmdStatus
		{
			get;
			set;
		}

		[DispId(22)]
		string CvvResult
		{
			get;
			set;
		}

		[DispId(45)]
		AccountType EntryMode
		{
			get;
			set;
		}

		[DispId(34)]
		string ExchangeRate
		{
			get;
			set;
		}

		[DispId(16)]
		string ExpDate
		{
			get;
			set;
		}

		[DispId(1)]
		SecureString FullAccount
		{
			set;
		}

		[DispId(2)]
		string FullExpirationDate
		{
			set;
		}

		[DispId(26)]
		string InvoiceNumber
		{
			get;
			set;
		}

		[DispId(38)]
		string IsoRespCode
		{
			get;
			set;
		}

		[DispId(31)]
		string IssueCurrency
		{
			get;
			set;
		}

		[DispId(33)]
		string IssueCurrencyEndingBalance
		{
			get;
			set;
		}

		[DispId(32)]
		string IssueCurrencyPreviousBalance
		{
			get;
			set;
		}

		[DispId(5)]
		string ItemAmount1
		{
			get;
			set;
		}

		[DispId(6)]
		string ItemAmount2
		{
			get;
			set;
		}

		[DispId(36)]
		string Language
		{
			get;
			set;
		}

		[DispId(28)]
		string Memo
		{
			get;
			set;
		}

		[DispId(13)]
		string MerchantID
		{
			get;
			set;
		}

		[DispId(27)]
		string OperatorID
		{
			get;
			set;
		}

		[DispId(51)]
		string PostProcess
		{
			get;
			set;
		}

		[DispId(49)]
		string PrePaidAccount
		{
			get;
			set;
		}

		[DispId(35)]
		string PrePaidExp
		{
			get;
			set;
		}

		[DispId(42)]
		string PrintData
		{
			get;
			set;
		}

		[DispId(46)]
		string ProcessData
		{
			get;
			set;
		}

		[DispId(53)]
		string ProductClass
		{
			get;
			set;
		}

		[DispId(52)]
		string ProductName
		{
			get;
			set;
		}

		[DispId(54)]
		string ProductVersion
		{
			get;
			set;
		}

		[DispId(55)]
		string Provider
		{
			get;
			set;
		}

		[DispId(30)]
		string RecordNo
		{
			get;
			set;
		}

		[DispId(25)]
		string ReferenceNumber
		{
			get;
			set;
		}

		[DispId(7)]
		string ResponseOrigin
		{
			get;
			set;
		}

		[DispId(8)]
		string ReturnCode
		{
			get;
			set;
		}

		[DispId(18)]
		string Selection
		{
			get;
			set;
		}

		[DispId(12)]
		string SequenceNo
		{
			get;
			set;
		}

		[DispId(47)]
		string SignatureData
		{
			get;
			set;
		}

		[DispId(57)]
		TenderTypes TenderTypeUsed
		{
			get;
			set;
		}

		[DispId(14)]
		string TerminalID
		{
			get;
			set;
		}

		[DispId(10)]
		string TextResponse
		{
			get;
			set;
		}

		[DispId(48)]
		string Token
		{
			get;
			set;
		}

		[DispId(43)]
		SecureString Track2
		{
			set;
		}

		[DispId(19)]
		string TranCode
		{
			get;
			set;
		}

		[DispId(39)]
		string TranDate
		{
			get;
			set;
		}

		[DispId(58)]
		TransactionTypes TransactionTypeUsed
		{
			get;
			set;
		}

		[DispId(40)]
		string TranTime
		{
			get;
			set;
		}

		[DispId(11)]
		string UserTraceData
		{
			get;
			set;
		}

		[DispId(23)]
		string VoucherNo
		{
			get;
			set;
		}

		[DispId(41)]
		string XmlResponse
		{
			get;
			set;
		}
	}
}