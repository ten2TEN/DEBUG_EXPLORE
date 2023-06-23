using MPS.POS.Utils;
using MSEnum;
using System;
using System.Security;

namespace Transaction
{
	public class TransactionProcessing
	{
		private const string _CLASS = "TransactionProcessing.cs";

		public TransactionProcessing()
		{
		}

		public static Response BuildAndProcessTransaction(Request POSRequest, TransactionData componentTransactionData)
		{
			Response response = new Response();
			string empty = string.Empty;
			string str = "TranSentry";
			try
			{
				if (componentTransactionData.TenderType != TenderTypes.Unknown)
				{
					POSRequest.TenderType = componentTransactionData.TenderType;
				}
				if (componentTransactionData.TransactionType != TransactionTypes.Unknown)
				{
					POSRequest.TransactionType = componentTransactionData.TransactionType;
				}
				if (componentTransactionData.PurchaseAmount > 0)
				{
					POSRequest.AmountData.PurchaseAmount = componentTransactionData.PurchaseAmount;
				}
				Transaction authCode = null;
				authCode = TransactionProcessing.CreateTransactionObject(POSRequest.TenderType, POSRequest.TransactionType);
				if (authCode == null)
				{
					throw new Exception(string.Format("Transaction object for TenderType - {0}, TransactionType - {1} is not implemented.", POSRequest.TenderType, POSRequest.TransactionType));
				}
				empty = string.Format("TranSentry building {0} Transaction.", POSRequest.TenderType.ToString());
				Logging.LogData(empty, str);
				switch (POSRequest.TenderType)
				{
					case TenderTypes.Credit:
					{
						((CreditTransaction)authCode).AuthCode = componentTransactionData.AuthCode;
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack1(componentTransactionData.Track1.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetTrack3(componentTransactionData.Track3.Copy());
						((CardTransaction)authCode).SetCardholderName(componentTransactionData.CardholderName);
						((CardTransaction)authCode).SetExpirationDateMonth(componentTransactionData.ExpDateMonth);
						((CardTransaction)authCode).SetExpirationDateYear(componentTransactionData.ExpDateYear);
						((CardTransaction)authCode).SetAVSZipCode(POSRequest.AddressData.ZipCode);
						((CardTransaction)authCode).SetAVSAddress(POSRequest.AddressData.Address);
						((CardTransaction)authCode).SetCVV(componentTransactionData.CVV);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						((CardTransaction)authCode).AmountData = POSRequest.AmountData;
						break;
					}
					case TenderTypes.Debit:
					{
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack1(componentTransactionData.Track1.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetTrack3(componentTransactionData.Track3.Copy());
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetExpirationDateMonth(componentTransactionData.ExpDateMonth);
						((CardTransaction)authCode).SetExpirationDateYear(componentTransactionData.ExpDateYear);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						((CardTransaction)authCode).AmountData = POSRequest.AmountData;
						((DebitTransaction)authCode).SetPinBlock(componentTransactionData.PINBlock.Copy());
						((DebitTransaction)authCode).SetDervdKey(componentTransactionData.DervdKey.Copy());
						break;
					}
					case TenderTypes.EBT:
					{
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack1(componentTransactionData.Track1.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetTrack3(componentTransactionData.Track3.Copy());
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetExpirationDateMonth(1);
						((CardTransaction)authCode).SetExpirationDateYear(0x833);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						((CardTransaction)authCode).AmountData = POSRequest.AmountData;
						if (POSRequest.TransactionType != TransactionTypes.Voucher)
						{
							((DebitTransaction)authCode).SetPinBlock(componentTransactionData.PINBlock.Copy());
							((DebitTransaction)authCode).SetDervdKey(componentTransactionData.DervdKey.Copy());
							break;
						}
						else
						{
							((EBTVoucherTransaction)authCode).AuthCode = POSRequest.AuthCode;
							((EBTVoucherTransaction)authCode).Voucher = POSRequest.VoucherNo;
							break;
						}
					}
					case TenderTypes.PrePaid:
					{
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack1(componentTransactionData.Track1.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetTrack3(componentTransactionData.Track3.Copy());
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						((CardTransaction)authCode).AmountData = POSRequest.AmountData;
						((CardTransaction)authCode).SetExpirationDateMonth(1);
						((CardTransaction)authCode).SetExpirationDateYear(0x833);
						if (POSRequest.PrePaidAccount.Length <= 0)
						{
							break;
						}
						SecureString secureString = new SecureString();
						string prePaidAccount = POSRequest.PrePaidAccount;
						for (int i = 0; i < prePaidAccount.Length; i++)
						{
							secureString.AppendChar(prePaidAccount[i]);
						}
						((CardTransaction)authCode).SetAccount(secureString);
						((CardTransaction)authCode).SetAccountType(AccountType.Keyed);
						break;
					}
					case TenderTypes.Admin:
					case TenderTypes.CanadianPinDebit:
					case TenderTypes.Unknown:
					case TenderTypes.CanadianEMVAdmin:
					{
						throw new Exception("Not Implemented.");
					}
					case TenderTypes.CanadianEMV:
					{
						throw new Exception("Not Implemented.");
					}
					case TenderTypes.FSA:
					{
						((CreditTransaction)authCode).AuthCode = componentTransactionData.AuthCode;
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack1(componentTransactionData.Track1.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetTrack3(componentTransactionData.Track3.Copy());
						((CardTransaction)authCode).SetCardholderName(componentTransactionData.CardholderName);
						((CardTransaction)authCode).SetExpirationDateMonth(componentTransactionData.ExpDateMonth);
						((CardTransaction)authCode).SetExpirationDateYear(componentTransactionData.ExpDateYear);
						((CardTransaction)authCode).SetAVSZipCode(POSRequest.AddressData.ZipCode);
						((CardTransaction)authCode).SetAVSAddress(POSRequest.AddressData.Address);
						((CardTransaction)authCode).SetCVV(componentTransactionData.CVV);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						((CardTransaction)authCode).AmountData = POSRequest.AmountData;
						break;
					}
					case TenderTypes.CardLookup:
					{
						((CardTransaction)authCode).SetAccountType(componentTransactionData.AccountType);
						((CardTransaction)authCode).SetAccount(componentTransactionData.Account.Copy());
						((CardTransaction)authCode).SetTrack2(componentTransactionData.Track2.Copy());
						((CardTransaction)authCode).SetExpirationDateMonth(componentTransactionData.ExpDateMonth);
						((CardTransaction)authCode).SetExpirationDateYear(componentTransactionData.ExpDateYear);
						((CardTransaction)authCode).SetEncryptedBlock(componentTransactionData.EncryptedBlock);
						((CardTransaction)authCode).SetEncryptedKey(componentTransactionData.EncryptedKey);
						((CardTransaction)authCode).SetAccountSource(componentTransactionData.AccountSource);
						((CardTransaction)authCode).SetEncryptedFormat(componentTransactionData.EncryptedFormat);
						break;
					}
					default:
					{
						throw new Exception("Not Implemented.");
					}
				}
				empty = string.Format("TranSentry calling ProcessTransaction for  {0} Object.", authCode.GetType().ToString());
				Logging.LogData(empty, str);
				authCode.LogName = str;
				authCode.SetInternalMemberVariables(POSRequest);
				response = authCode.ProcessTransaction();
				response.TenderTypeUsed = POSRequest.TenderType;
				response.TransactionTypeUsed = POSRequest.TransactionType;
				response.AmountData.CashBackAmount = POSRequest.AmountData.CashBackAmount;
				if (string.IsNullOrEmpty(response.CardUsage) && !string.IsNullOrEmpty(componentTransactionData.CardUsage))
				{
					response.CardUsage = componentTransactionData.CardUsage;
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				response.CmdStatus = "Error";
				response.ResponseOrigin = "Client";
				response.TextResponse = CommonMethods.GetExceptionMessage();
				object[] message = new object[] { "TransactionProcessing.cs", "BuildAndProcessTransaction", exception.Message };
				Logging.LogData(string.Format("Exception caught. Class = '{0}', method = '{1}', Exception = '{2}'.", message), str);
			}
			return response;
		}

		public static Response CardLookup(Request request, AccountType accountType, SecureString account, SecureString track2, int expDateMonth, int expDateYear, SecureString encryptedBlock, SecureString encryptedKey, AccountSource accountSource, EncryptedFormat encryptedFormat, string logname)
		{
			Response response = new Response();
			TokenFrequencies tokenFrequency = request.TokenFrequency;
			request.TokenFrequency = TokenFrequencies.OneTime;
			try
			{
				CardLookupTransaction cardLookupTransaction = (CardLookupTransaction)TransactionProcessing.CreateTransactionObject(TenderTypes.CardLookup, TransactionTypes.Unknown);
				if (cardLookupTransaction == null)
				{
					response.CmdStatus = "Error";
					response.ResponseOrigin = "Client";
					response.TextResponse = "Failed to create CardLookup transaction";
					Logging.LogData("Failed to create CardLookup transaction.", logname);
				}
				else
				{
					cardLookupTransaction.SetAccountType(accountType);
					cardLookupTransaction.SetAccount(account);
					cardLookupTransaction.SetTrack2(track2);
					cardLookupTransaction.SetExpirationDateMonth(expDateMonth);
					cardLookupTransaction.SetExpirationDateYear(expDateYear);
					cardLookupTransaction.SetEncryptedBlock(encryptedBlock);
					cardLookupTransaction.SetEncryptedKey(encryptedKey);
					cardLookupTransaction.SetAccountSource(accountSource);
					cardLookupTransaction.SetEncryptedFormat(encryptedFormat);
					Logging.LogData("Performing CardLookup.", logname);
					cardLookupTransaction.LogName = logname;
					cardLookupTransaction.SetInternalMemberVariables(request);
					response = cardLookupTransaction.ProcessTransaction();
					if (!string.Equals(response.CmdStatus, "approved", StringComparison.OrdinalIgnoreCase))
					{
						string[] cmdStatus = new string[] { "CardLookup unsuccessful, CmdStatus '", response.CmdStatus, "', TextResponse '", response.TextResponse, "', DSIXReturnCode '", response.ReturnCode, "'" };
						Logging.LogData(string.Concat(cmdStatus), logname);
					}
					else
					{
						string[] cardUsage = new string[] { "Result of CardLookup -- Usage: '", response.CardUsage, "' CmdStatus: '", response.CmdStatus, "' TextMessage: '", response.TextResponse, "' DSIXReturnCode '", response.ReturnCode, "'" };
						Logging.LogData(string.Concat(cardUsage), logname);
					}
					cardLookupTransaction = null;
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				response.CmdStatus = "Error";
				response.ResponseOrigin = "Client";
				response.TextResponse = CommonMethods.GetExceptionMessage();
				object[] message = new object[] { "TransactionProcessing.cs", "CardLookup()", exception.Message };
				Logging.LogData(string.Format("Exception caught. Class = '{0}', method = '{1}', Exception = '{2}'.", message), logname);
			}
			request.TokenFrequency = tokenFrequency;
			return response;
		}

		public static Transaction CreateTransactionObject(TenderTypes tenderType, TransactionTypes transactionType)
		{
			Transaction creditSaleTransaction = null;
			switch (tenderType)
			{
				case TenderTypes.Credit:
				{
					switch (transactionType)
					{
						case TransactionTypes.Sale:
						{
							creditSaleTransaction = new CreditSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Return:
						{
							creditSaleTransaction = new CreditReturnTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.PreAuth:
						{
							creditSaleTransaction = new CreditPreAuthTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.PreAuthCapture:
						{
							creditSaleTransaction = new CreditPreAuthCaptureTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoiceAuth:
						{
							creditSaleTransaction = new CreditVoiceAuthTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Adjust:
						{
							creditSaleTransaction = new CreditAdjustTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidSale:
						{
							creditSaleTransaction = new CreditVoidSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidReturn:
						{
							creditSaleTransaction = new CreditVoidReturnTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							return creditSaleTransaction;
						}
					}
					break;
				}
				case TenderTypes.Debit:
				{
					switch (transactionType)
					{
						case TransactionTypes.Sale:
						{
							creditSaleTransaction = new DebitSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Return:
						{
							creditSaleTransaction = new DebitReturnTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							return creditSaleTransaction;
						}
					}
					break;
				}
				case TenderTypes.EBT:
				{
					TransactionTypes transactionType1 = transactionType;
					switch (transactionType1)
					{
						case TransactionTypes.Sale:
						{
							creditSaleTransaction = new EBTSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Return:
						{
							creditSaleTransaction = new EBTReturnTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							if (transactionType1 == TransactionTypes.Balance)
							{
								creditSaleTransaction = new EBTBalanceTransaction();
								return creditSaleTransaction;
							}
							else
							{
								switch (transactionType1)
								{
									case TransactionTypes.Voucher:
									{
										creditSaleTransaction = new EBTVoucherTransaction();
										return creditSaleTransaction;
									}
									case TransactionTypes.CashBalance:
									{
										creditSaleTransaction = new EBTCashBalanceTransaction();
										return creditSaleTransaction;
									}
									case TransactionTypes.CashSale:
									{
										creditSaleTransaction = new EBTCashSaleTransaction();
										return creditSaleTransaction;
									}
									default:
									{
										return creditSaleTransaction;
									}
								}
							}
							break;
						}
					}
					break;
				}
				case TenderTypes.PrePaid:
				{
					switch (transactionType)
					{
						case TransactionTypes.Sale:
						{
							creditSaleTransaction = new PrepaidSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Return:
						{
							creditSaleTransaction = new PrepaidReturnTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.PreAuth:
						case TransactionTypes.PreAuthCapture:
						case TransactionTypes.VoiceAuth:
						case TransactionTypes.Adjust:
						case TransactionTypes.BatchClose:
						case TransactionTypes.BatchSummary:
						case TransactionTypes.BatchClear:
						{
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidSale:
						{
							creditSaleTransaction = new PrepaidVoidSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidReturn:
						{
							creditSaleTransaction = new PrepaidVoidReturnTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Issue:
						{
							creditSaleTransaction = new PrepaidIssueTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Balance:
						{
							creditSaleTransaction = new PrepaidBalanceTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidIssue:
						{
							creditSaleTransaction = new PrepaidVoidIssueTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Reload:
						{
							creditSaleTransaction = new PrepaidReloadTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.VoidReload:
						{
							creditSaleTransaction = new PrepaidVoidReloadTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.NoNSFSale:
						{
							creditSaleTransaction = new PrepaidNoNSFSaleTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							return creditSaleTransaction;
						}
					}
					break;
				}
				case TenderTypes.Admin:
				{
					switch (transactionType)
					{
						case TransactionTypes.BatchClose:
						{
							creditSaleTransaction = new AdminBatchCloseTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.BatchSummary:
						{
							creditSaleTransaction = new AdminBatchSummaryTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.BatchClear:
						{
							creditSaleTransaction = new AdminBatchClearTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							return creditSaleTransaction;
						}
					}
					break;
				}
				case TenderTypes.CanadianPinDebit:
				{
					TransactionTypes transactionType2 = transactionType;
					switch (transactionType2)
					{
						case TransactionTypes.Sale:
						{
							creditSaleTransaction = new CanadianDebitSaleTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.Return:
						{
							creditSaleTransaction = new CanadianDebitReturnTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							switch (transactionType2)
							{
								case TransactionTypes.SaleGratuity:
								{
									creditSaleTransaction = new CanadianDebitSaleTransaction();
									return creditSaleTransaction;
								}
								case TransactionTypes.KeyChange:
								{
									creditSaleTransaction = new CanadianDebitKeyChangeTransaction();
									return creditSaleTransaction;
								}
								case TransactionTypes.PadReset:
								{
									creditSaleTransaction = new CanadianDebitPadResetTransaction();
									return creditSaleTransaction;
								}
								default:
								{
									return creditSaleTransaction;
								}
							}
							break;
						}
					}
					break;
				}
				case TenderTypes.Unknown:
				{
					return creditSaleTransaction;
				}
				case TenderTypes.CanadianEMV:
				{
					TransactionTypes transactionType3 = transactionType;
					if (transactionType3 <= TransactionTypes.PadReset)
					{
						switch (transactionType3)
						{
							case TransactionTypes.Sale:
							{
								creditSaleTransaction = new CanadianEMVSaleTransaction();
								return creditSaleTransaction;
							}
							case TransactionTypes.Return:
							{
								creditSaleTransaction = new CanadianEMVReturnTransaction();
								return creditSaleTransaction;
							}
							case TransactionTypes.PreAuth:
							case TransactionTypes.PreAuthCapture:
							case TransactionTypes.Adjust:
							{
								return creditSaleTransaction;
							}
							case TransactionTypes.VoiceAuth:
							{
								creditSaleTransaction = new CanadianEMVVoiceAuthTransaction();
								return creditSaleTransaction;
							}
							case TransactionTypes.VoidSale:
							{
								creditSaleTransaction = new CanadianEMVVoidSaleTransaction();
								return creditSaleTransaction;
							}
							case TransactionTypes.VoidReturn:
							{
								creditSaleTransaction = new CanadianEMVVoidReturnTransaction();
								return creditSaleTransaction;
							}
							default:
							{
								switch (transactionType3)
								{
									case TransactionTypes.KeyChange:
									{
										creditSaleTransaction = new CanadianEMVKeyChangeTransaction();
										return creditSaleTransaction;
									}
									case TransactionTypes.PadReset:
									{
										creditSaleTransaction = new CanadianEMVPadResetTransaction();
										return creditSaleTransaction;
									}
									default:
									{
										return creditSaleTransaction;
									}
								}
								break;
							}
						}
					}
					else if (transactionType3 == TransactionTypes.ParamDownload)
					{
						creditSaleTransaction = new CanadianEMVParamDownloadTransaction();
						return creditSaleTransaction;
					}
					else if (transactionType3 == TransactionTypes.GetPrePaidStripe)
					{
						creditSaleTransaction = new CanadianEMVGetPrePaidStripeTransaction();
						return creditSaleTransaction;
					}
					else
					{
						return creditSaleTransaction;
					}
					break;
				}
				case TenderTypes.CanadianEMVAdmin:
				{
					TransactionTypes transactionType4 = transactionType;
					switch (transactionType4)
					{
						case TransactionTypes.BatchClose:
						{
							creditSaleTransaction = new CanadianEMVBatchCloseTransaction();
							return creditSaleTransaction;
						}
						case TransactionTypes.BatchSummary:
						{
							creditSaleTransaction = new CanadianEMVBatchSummaryTransaction();
							return creditSaleTransaction;
						}
						default:
						{
							switch (transactionType4)
							{
								case TransactionTypes.PublicKeyReport:
								{
									creditSaleTransaction = new CanadianEMVPublicKeyReport();
									return creditSaleTransaction;
								}
								case TransactionTypes.StatisticsReport:
								{
									creditSaleTransaction = new CanadianEMVStatisticsReport();
									return creditSaleTransaction;
								}
								case TransactionTypes.ParameterReport:
								{
									creditSaleTransaction = new CanadianEMVParameterReportTransaction();
									return creditSaleTransaction;
								}
								case TransactionTypes.OfflineDeclineReport:
								{
									return creditSaleTransaction;
								}
								case TransactionTypes.ServerVersion:
								{
									creditSaleTransaction = new CanadianEMVServerVersionTransaction();
									return creditSaleTransaction;
								}
								default:
								{
									return creditSaleTransaction;
								}
							}
							break;
						}
					}
					break;
				}
				case TenderTypes.FSA:
				{
					TransactionTypes transactionType5 = transactionType;
					if (transactionType5 == TransactionTypes.Sale)
					{
						creditSaleTransaction = new FSASaleTransaction();
						return creditSaleTransaction;
					}
					else if (transactionType5 == TransactionTypes.ReverseSale)
					{
						creditSaleTransaction = new FSAReverseSaleTransaction();
						return creditSaleTransaction;
					}
					else
					{
						return creditSaleTransaction;
					}
				}
				case TenderTypes.CardLookup:
				{
					creditSaleTransaction = new CardLookupTransaction();
					return creditSaleTransaction;
				}
				default:
				{
					return creditSaleTransaction;
				}
			}
		}

		public static FSAEvaluationResult EvaluateFSACardUsage(Request request, string usage, AccountType cardAccountType, string logname)
		{
			string str;
			FSAEvaluationResult fSAEvaluationResult = FSAEvaluationResult.OK;
			try
			{
				string lowerInvariant = usage.ToLowerInvariant();
				str = lowerInvariant;
				if (lowerInvariant == null)
				{
					goto Label0;
				}
				else if (str == "fsa")
				{
					fSAEvaluationResult = (request.AmountData.FSAAmount <= 0 || request.AmountData.PurchaseAmount == request.AmountData.FSAAmount || request.FSACardNotPresented != FSACardNotPresented.FailTransaction ? FSAEvaluationResult.OK : FSAEvaluationResult.PurchaseAndFSAAmountMismatch);
				}
				else if (str != "debit")
				{
					if (str != "other")
					{
						goto Label1;
					}
					fSAEvaluationResult = (request.FSACardNotPresented != FSACardNotPresented.RunCreditOrDebitIfPresented ? FSAEvaluationResult.OtherNotSupported : FSAEvaluationResult.OK);
				}
				else if (request.FSACardNotPresented == FSACardNotPresented.RunDebitIfDebitPresented || request.FSACardNotPresented == FSACardNotPresented.RunCreditOrDebitIfPresented)
				{
					fSAEvaluationResult = (cardAccountType == AccountType.Keyed || cardAccountType == AccountType.E2EKeyed ? FSAEvaluationResult.ManuallyEnteredDebit : FSAEvaluationResult.OK);
				}
				else
				{
					fSAEvaluationResult = FSAEvaluationResult.DebitNotSupported;
				}
			Label2:
				Logging.LogData(string.Concat("FSAEvaluationResult: ", Enum.GetName(typeof(FSAEvaluationResult), fSAEvaluationResult)), logname);
			}
			catch (Exception exception)
			{
				object[] message = new object[] { "TransactionProcessing.cs", "EvaluateFSACardUsage", exception.Message };
				Logging.LogData(string.Format("Exception caught. Class = '{0}', method = '{1}', Exception = '{2}'.", message), logname);
				fSAEvaluationResult = FSAEvaluationResult.Error;
			}
			return fSAEvaluationResult;
		Label0:
			fSAEvaluationResult = FSAEvaluationResult.Error;
			goto Label2;
		Label1:
			if (str != "error")
			{
				goto Label0;
			}
			else
			{
				goto Label0;
			}
		}
	}
}