using MercuryShield;
using Microsoft.VisualBasic.CompilerServices;
using MSEnum;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Transaction;

namespace TranSentry
{
	public class TranSentryCanadianEMV
	{
		[DebuggerNonUserCode]
		public TranSentryCanadianEMV()
		{
		}

		public object CanadianEMVReports(string InvoiceNumber, string ReferenceNumber, int RptType, string UserID, string MerchantLanguage, string UserTraceData, string MerchantID, int ComPort, string SequenceNumber)
		{
			object obj;
			Request request = new Request();
			MercuryShieldUI mercuryShieldUI = new MercuryShieldUI();
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				request = this.PopulateBaseRequest(UserID, InvoiceNumber, ReferenceNumber, MerchantLanguage, UserTraceData);
				if (RptType == 1)
				{
					request.set_TransactionType(TransactionTypes.StatisticsReport);
				}
				else if (RptType == 2)
				{
					request.set_TransactionType(TransactionTypes.ParameterReport);
				}
				else if (RptType == 3)
				{
					request.set_TransactionType(TransactionTypes.ServerVersion);
				}
				else if (RptType != 4)
				{
					MessageBox.Show("TranSentry Type not coded for!. Using default report", "Problem", MessageBoxButtons.OK);
					request.set_TransactionType(TransactionTypes.StatisticsReport);
				}
				else
				{
					request.set_TransactionType(TransactionTypes.PublicKeyReport);
				}
				request.set_PinPadConfig(this.PopulateBasePinPadConfig(MerchantID, ComPort, SequenceNumber));
				request.set_TenderType(TenderTypes.CanadianEMVAdmin);
				mercuryShieldUI.MercuryShieldRequest = request;
				mercuryShieldUI.ProcessTransactionNoUI();
				response = mercuryShieldUI.MercuryShieldResponse;
				if (response.get_CmdStatus().Equals("Success"))
				{
					request.set_TenderType(TenderTypes.CanadianEMV);
					request.set_TransactionType(TransactionTypes.PadReset);
					mercuryShieldUI.MercuryShieldRequest = request;
					mercuryShieldUI.ProcessTransactionNoUI();
					Response mercuryShieldResponse = mercuryShieldUI.MercuryShieldResponse;
				}
				obj = response;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				obj = response;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public Response CanadianEMVSetup(string UserID, string InvoiceNumber, string ReferenceNumber, string MerchantLanguage, string UserTraceData, string MerchantID, int ComPort, string SequenceNumber)
		{
			Request request = this.PopulateBaseRequest(UserID, InvoiceNumber, ReferenceNumber, MerchantLanguage, UserTraceData);
			Response response = new Response();
			string empty = string.Empty;
			MercuryShieldUI mercuryShieldUI = new MercuryShieldUI();
			request.set_TenderType(TenderTypes.CanadianEMV);
			request.set_TransactionType(TransactionTypes.ParamDownload);
			request.set_PinPadConfig(this.PopulateBasePinPadConfig(MerchantID, ComPort, SequenceNumber));
			mercuryShieldUI.MercuryShieldRequest = request;
			mercuryShieldUI.ProcessTransactionNoUI();
			response = mercuryShieldUI.MercuryShieldResponse;
			if (response.get_CmdStatus().Equals("Success"))
			{
				request.set_TenderType(TenderTypes.CanadianEMV);
				request.set_TransactionType(TransactionTypes.KeyChange);
				mercuryShieldUI.MercuryShieldRequest = request;
				mercuryShieldUI.ProcessTransactionNoUI();
				response = mercuryShieldUI.MercuryShieldResponse;
				if (response.get_CmdStatus().Equals("Success"))
				{
					request.set_TenderType(TenderTypes.CanadianEMV);
					request.set_TransactionType(TransactionTypes.PadReset);
					mercuryShieldUI.MercuryShieldRequest = request;
					mercuryShieldUI.ProcessTransactionNoUI();
					response = mercuryShieldUI.MercuryShieldResponse;
				}
			}
			empty = string.Concat("CanadianEMV Setup Response", Environment.NewLine);
			empty = string.Concat(empty, Environment.NewLine);
			empty = string.Concat(empty, "CmdStatus: ", response.get_CmdStatus(), Environment.NewLine);
			empty = string.Concat(empty, "TextResponse: ", response.get_TextResponse(), Environment.NewLine);
			empty = string.Concat(empty, "ProcessData: ", response.get_ProcessData());
			return response;
		}

		public object CanadianEMVTransaction(decimal Amount, int TransType, bool bOveride, bool bUseUI, string UserID, string InvoiceNumber, string ReferenceNumber, string MerchantLanguage, string UserTraceData, string MerchantID, int ComPort, bool bManual, string VoiceAuth, bool bDebit, string SequenceNumber, bool bCanadianEMVGratuityPrompt)
		{
			object obj;
			Request request = new Request();
			MercuryShieldUI mercuryShieldUI = new MercuryShieldUI();
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				request = this.PopulateBaseRequest(UserID, InvoiceNumber, ReferenceNumber, MerchantLanguage, UserTraceData);
				request.set_PinPadConfig(this.PopulateBasePinPadConfig(MerchantID, ComPort, SequenceNumber));
				request.set_TenderType(TenderTypes.CanadianEMV);
				if (bDebit & TransType != 3)
				{
					request.set_CardType("DEBIT");
				}
				request.set_CanadianEMVCreditManualEntry(bManual);
				if (TransType == 1)
				{
					request.set_TransactionType(TransactionTypes.Sale);
					if (!bCanadianEMVGratuityPrompt)
					{
						request.set_CanadianEMVGratuityPrompt(false);
					}
					else
					{
						request.set_CanadianEMVGratuityPrompt(true);
					}
				}
				else if (TransType == 2)
				{
					request.set_TransactionType(TransactionTypes.Return);
				}
				else if (TransType != 3)
				{
					MessageBox.Show("TranSentry Type not coded for!", "Problem", MessageBoxButtons.OK);
					obj = response;
					return obj;
				}
				else
				{
					request.set_TransactionType(TransactionTypes.VoiceAuth);
					request.set_AuthCode(VoiceAuth);
				}
				if (!bOveride)
				{
					request.set_Override(false);
				}
				else
				{
					request.set_Override(true);
				}
				request.get_AmountData().set_PurchaseAmount(Convert.ToDouble(Amount));
				mercuryShieldUI.MercuryShieldRequest = request;
				if (!bUseUI)
				{
					mercuryShieldUI.ProcessTransactionNoUI();
				}
				else
				{
					mercuryShieldUI.TopMost = true;
					if (mercuryShieldUI.ShowDialog() == DialogResult.Cancel)
					{
						obj = response;
						return obj;
					}
				}
				response = mercuryShieldUI.MercuryShieldResponse;
				obj = response;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Response response1 = response;
				response1.set_TextResponse(string.Concat(response1.get_TextResponse(), exception.ToString()));
				obj = response;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public object CanadianEMVVOID(decimal Amount, string AuthorizationCode, int TransType, string UserID, string InvoiceNumber, string ReferenceNumber, string MerchantLanguage, string UserTraceData, string MerchantID, int ComPort, string SequenceNumber, bool bManual)
		{
			object obj;
			MercuryShieldUI mercuryShieldUI = new MercuryShieldUI();
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				Request request = new Request();
				request = this.PopulateBaseRequest(UserID, InvoiceNumber, ReferenceNumber, MerchantLanguage, UserTraceData);
				request.set_PinPadConfig(this.PopulateBasePinPadConfig(MerchantID, ComPort, SequenceNumber));
				request.set_TenderType(TenderTypes.CanadianEMV);
				if (TransType != 1)
				{
					request.set_TransactionType(TransactionTypes.VoidReturn);
				}
				else
				{
					request.set_TransactionType(TransactionTypes.VoidSale);
				}
				request.set_AuthCode(AuthorizationCode);
				request.set_InvoiceNumber(InvoiceNumber);
				request.set_ReferenceNumber(ReferenceNumber);
				request.get_AmountData().set_PurchaseAmount(Convert.ToDouble(Amount));
				request.set_CanadianEMVCreditManualEntry(bManual);
				mercuryShieldUI.MercuryShieldRequest = request;
				mercuryShieldUI.ProcessTransactionNoUI();
				response = mercuryShieldUI.MercuryShieldResponse;
				obj = response;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Response response1 = response;
				response1.set_TextResponse(string.Concat(response1.get_TextResponse(), exception.ToString()));
				obj = response;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public object CanadianPadReset(string InvoiceNumber, string ReferenceNumber, string UserID, string MerchantLanguage, string UserTraceData, string MerchantID, int ComPort, string SequenceNumber)
		{
			object obj;
			Request request = new Request();
			MercuryShieldUI mercuryShieldUI = new MercuryShieldUI();
			Response response = new Response();
			string empty = string.Empty;
			try
			{
				request = this.PopulateBaseRequest(UserID, InvoiceNumber, ReferenceNumber, MerchantLanguage, UserTraceData);
				request.set_TransactionType(TransactionTypes.PadReset);
				request.set_PinPadConfig(this.PopulateBasePinPadConfig(MerchantID, ComPort, SequenceNumber));
				request.set_TenderType(TenderTypes.CanadianEMV);
				mercuryShieldUI.MercuryShieldRequest = request;
				mercuryShieldUI.ProcessTransactionNoUI();
				response = mercuryShieldUI.MercuryShieldResponse;
				obj = response;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				obj = response;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public PinPadConfig PopulateBasePinPadConfig(string MerchantID, int ComPort, string SequenceNumber)
		{
			PinPadConfig pinPadConfig = new PinPadConfig();
			pinPadConfig.set_PinPadType(8);
			pinPadConfig.set_MerchantID(MerchantID);
			pinPadConfig.set_ComPort(ComPort);
			pinPadConfig.set_SequenceNumber(SequenceNumber);
			pinPadConfig.set_PinPadConnectionMethod(1);
			pinPadConfig.set_TimeOutValue(60);
			pinPadConfig.set_HostOrIP("127.0.0.1");
			pinPadConfig.set_IPPort("9000");
			return pinPadConfig;
		}

		public Request PopulateBaseRequest(string UserID, string InvoiceNumber, string ReferenceNumber, string MerchantLanguage, string UserTraceData)
		{
			Request request = new Request();
			request.set_UserID(UserID);
			request.set_InvoiceNumber(InvoiceNumber);
			request.set_ReferenceNumber(ReferenceNumber);
			request.set_MerchantLanguage(MerchantLanguage);
			request.set_UserTraceData(UserTraceData);
			return request;
		}
	}
}