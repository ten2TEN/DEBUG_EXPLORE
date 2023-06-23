using A;
using Microsoft.VisualBasic.CompilerServices;
using PSCharge;
using System;
using System.Runtime.CompilerServices;

namespace CCProcess
{
	public class CCProcess
	{
		private Debit cb42845b7c474536a76f65b4c7caa78b4;

		private Charge c74bc2f21fa03a25ed344ec3433147475;

		public int iTransType;

		public string strTroutD;

		public string strResult;

		public string strResponse;

		private decimal c052c8b8cb26cefc5e0d78cd9e45de371;

		private string cd330fdfa309803a273a63fc0618f64fa;

		private DbLocation c233604abeca67a6e6b798fdea78cdf5f;

		private string c719722294a35b556f008b22a55045df8;

		private string c5006497749ec529ffaf0cb4590fb8948;

		private string c5f851ef21499ec4b65129a5f51bd121e;

		private CCResponse c9e256a57dd1ba0f572ade479aa871469;

		public string Card
		{
			get
			{
				string card = this.objCharge.Card;
				return card;
			}
		}

		public string CCType
		{
			get
			{
				return this.cd330fdfa309803a273a63fc0618f64fa;
			}
			set
			{
				this.cd330fdfa309803a273a63fc0618f64fa = value;
			}
		}

		public string DebitCard
		{
			get
			{
				string card = this.objDebit.Card;
				return card;
			}
		}

		public string DebitExp
		{
			get
			{
				return this.objDebit.ExpDate;
			}
		}

		public string DebitMember
		{
			get
			{
				Debit variable = this.objDebit;
				string str = variable.member;
				return str;
			}
		}

		public string DebitPath
		{
			get
			{
				Debit variable = this.objDebit;
				return variable.Path;
			}
			set
			{
				Debit variable = this.objDebit;
				variable.Path = value;
			}
		}

		public string Exp
		{
			get
			{
				Charge variable = this.objCharge;
				string expDate = variable.ExpDate;
				return expDate;
			}
		}

		public string Member
		{
			get
			{
				Charge variable = this.objCharge;
				string str = variable.member;
				return str;
			}
		}

		public Charge objCharge
		{
			get
			{
				return this.c74bc2f21fa03a25ed344ec3433147475;
			}
			set
			{
				this.c74bc2f21fa03a25ed344ec3433147475 = value;
			}
		}

		public Debit objDebit
		{
			get
			{
				return this.cb42845b7c474536a76f65b4c7caa78b4;
			}
			set
			{
				this.cb42845b7c474536a76f65b4c7caa78b4 = value;
			}
		}

		public string Path
		{
			get
			{
				Charge variable = this.objCharge;
				return variable.Path;
			}
			set
			{
				Charge variable = this.objCharge;
				variable.Path = value;
			}
		}

		public decimal PaymentLimit
		{
			get
			{
				return this.c052c8b8cb26cefc5e0d78cd9e45de371;
			}
			set
			{
				this.c052c8b8cb26cefc5e0d78cd9e45de371 = value;
			}
		}

		public string PCChargeAuth
		{
			get
			{
				Charge variable = this.objCharge;
				string auth = variable.GetAuth();
				return auth;
			}
		}

		public string PCChargeAVS
		{
			get
			{
				Charge variable = this.objCharge;
				string aVS = variable.GetAVS();
				return aVS;
			}
		}

		public string PCChargeCVV2
		{
			get
			{
				Charge variable = this.objCharge;
				string cVV2 = variable.GetCVV2();
				return cVV2;
			}
		}

		public string PCChargeErrorCode
		{
			get
			{
				Charge variable = this.objCharge;
				int errorCode = variable.GetErrorCode();
				string str = Conversions.ToString(errorCode);
				return str;
			}
		}

		public string PCChargeErrorDesc
		{
			get
			{
				Charge variable = this.objCharge;
				string errorDesc = variable.GetErrorDesc();
				return errorDesc;
			}
		}

		public short PCChargeGetParseData(string str)
		{
			get
			{
				short num;
				try
				{
					short parseData = this.objCharge.GetParseData(ref str);
					num = parseData;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					num = 0;
					ProjectData.ClearProjectError();
				}
				return num;
			}
		}

		public string PCChargeRespCode
		{
			get
			{
				Charge variable = this.objCharge;
				return variable.GetRespCode();
			}
		}

		public string PCChargeResult
		{
			get
			{
				Charge variable = this.objCharge;
				string result = variable.GetResult();
				return result;
			}
		}

		public string PCChargeTroutD
		{
			get
			{
				Charge variable = this.objCharge;
				return variable.GetTroutD();
			}
		}

		public string PCDebitAuth
		{
			get
			{
				Debit variable = this.objDebit;
				object auth = variable.GetAuth();
				string str = Conversions.ToString(auth);
				return str;
			}
		}

		public string PCDebitErrorCode
		{
			get
			{
				int errorCode = this.objDebit.GetErrorCode();
				string str = Conversions.ToString(errorCode);
				return str;
			}
		}

		public string PCDebitErrorDesc
		{
			get
			{
				Debit variable = this.objDebit;
				return variable.GetErrorDesc();
			}
		}

		public short PCDebitGetParseData(string str)
		{
			get
			{
				short num;
				try
				{
					Debit variable = this.objDebit;
					string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(72);
					object[] objArray = new object[] { str };
					bool[] flagArray = new bool[] { true };
					object obj = NewLateBinding.LateGet(variable, null, str1, objArray, null, null, flagArray);
					if (flagArray[0])
					{
						object objectValue = RuntimeHelpers.GetObjectValue(objArray[0]);
						Type type = typeof(string);
						object obj1 = Conversions.ChangeType(objectValue, type);
						str = (string)obj1;
					}
					short num1 = Conversions.ToShort(obj);
					num = num1;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					num = 0;
					ProjectData.ClearProjectError();
				}
				return num;
			}
		}

		public string PCDebitResult
		{
			get
			{
				object result = this.objDebit.GetResult();
				string str = Conversions.ToString(result);
				return str;
			}
		}

		public string Response
		{
			get
			{
				return this.strResponse;
			}
			set
			{
				this.strResponse = value;
			}
		}

		public string Result
		{
			get
			{
				return this.strResult;
			}
			set
			{
				this.strResult = value;
			}
		}

		public string TroutD
		{
			get
			{
				return this.strTroutD;
			}
			set
			{
				this.strTroutD = value;
			}
		}

		public bool VerifyCreditCard(string str)
		{
			get
			{
				Charge variable = this.objCharge;
				bool flag = variable.VerifyCreditCard(str);
				return flag;
			}
		}

		public bool VerifyDebitCard(string str)
		{
			get
			{
				// 
				// Current member / type: System.Boolean CCProcess.CCProcess::get_VerifyDebitCard(System.String)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Boolean get_VerifyDebitCard(System.String)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at ..(MethodBody , & ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\PropertyDecompiler.cs:line 345
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
		}

		public string XMLRequest
		{
			get
			{
				string rEQUEST = this.c9e256a57dd1ba0f572ade479aa871469.REQUEST;
				return rEQUEST;
			}
		}

		public string XMLResponse
		{
			get
			{
				string rESPONSE = this.c9e256a57dd1ba0f572ade479aa871469.RESPONSE;
				return rESPONSE;
			}
		}

		public CCProcess(string loc)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d2);
			Guid guid = new Guid(str);
			Type typeFromCLSID = Type.GetTypeFromCLSID(guid);
			object obj = Activator.CreateInstance(typeFromCLSID);
			this.cb42845b7c474536a76f65b4c7caa78b4 = (Debit)obj;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x15a);
			guid = new Guid(str1);
			Type type = Type.GetTypeFromCLSID(guid);
			object obj1 = Activator.CreateInstance(type);
			this.c74bc2f21fa03a25ed344ec3433147475 = (Charge)obj1;
			this.strTroutD = "";
			this.strResult = "";
			this.strResponse = "";
			this.c052c8b8cb26cefc5e0d78cd9e45de371 = new decimal();
			this.c233604abeca67a6e6b798fdea78cdf5f = new DbLocation();
			this.c719722294a35b556f008b22a55045df8 = "";
			char[] charArrayRankOne = Conversions.ToCharArrayRankOne("");
			this.c5006497749ec529ffaf0cb4590fb8948 = new string(charArrayRankOne);
			char[] chrArray = Conversions.ToCharArrayRankOne("");
			this.c5f851ef21499ec4b65129a5f51bd121e = new string(chrArray);
			this.c9e256a57dd1ba0f572ade479aa871469 = new CCResponse();
			this.c719722294a35b556f008b22a55045df8 = loc;
			this.c5f851ef21499ec4b65129a5f51bd121e = "";
			this.c5006497749ec529ffaf0cb4590fb8948 = "";
		}

		private string c6fc17dd71aa00e72da37b52b4ecd3178(string c73f31cc9fa989d346d26bbde84dc2c9e)
		{
			// 
			// Current member / type: System.String CCProcess.CCProcess::c6fc17dd71aa00e72da37b52b4ecd3178(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String c6fc17dd71aa00e72da37b52b4ecd3178(System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public void DelUserfile()
		{
			this.objCharge.DeleteUserFiles();
			Debit variable = this.objDebit;
			object obj = variable.DeleteUserFiles();
		}

		public bool loadDebitPCCW()
		{
			// 
			// Current member / type: System.Boolean CCProcess.CCProcess::loadDebitPCCW()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean loadDebitPCCW()
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public bool loadPCCW()
		{
			// 
			// Current member / type: System.Boolean CCProcess.CCProcess::loadPCCW()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean loadPCCW()
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public void Objclear()
		{
			// 
			// Current member / type: System.Void CCProcess.CCProcess::Objclear()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void Objclear()
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public bool ProcessCanadaDebit(int SaleOrRefund, string NameOnCard, string CCNum, string expdate, string Amt, string CCProcessCode, string Mer, string debittype, string Language, int timeout, string InvoiceNumber, string CCEXELocation, int Manual, string pinnum, string track, string Cashier, string CashierPwd, string CardPresent = "", bool IsOverride = true)
		{
			// 
			// Current member / type: System.Boolean CCProcess.CCProcess::ProcessCanadaDebit(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean ProcessCanadaDebit(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string ProcessCC(int SaleOrRefund, string NameOnCard, string CCNum, string expdate, string CCV, string Amt, string tax, string ticket, string zip, string Street, string CCProcessCode, string Mer, int timeout, string CCEXELocation, int Manual, string Cashier, string CashierPwd, string Track, string CardPresent = "", bool IsOverride = false, bool bEFT = false, int LocNum = 0, int drawer = 0)
		{
			// 
			// Current member / type: System.String CCProcess.CCProcess::ProcessCC(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Int32,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String ProcessCC(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Int32,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Int32,System.Int32)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public bool ProcessCCDebit(int SaleOrRefund, string NameOnCard, string CCNum, string expdate, string Amt, string CCProcessCode, string Mer, int timeout, string InvoiceNumber, string CCEXELocation, int Manual, string pinnum, string track, string Cashier, string CashierPwd, string CardPresent = "", bool IsOverride = true)
		{
			// 
			// Current member / type: System.Boolean CCProcess.CCProcess::ProcessCCDebit(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean ProcessCCDebit(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}
	}
}