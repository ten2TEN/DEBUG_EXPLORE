using A;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace CCProcess.com.mercurypay.w1
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.34209")]
	[WebServiceBinding(Namespace="http://www.mercurypay.com", Name="wsSoap")]
	public class ws : SoapHttpClientProtocol
	{
		private SendOrPostCallback cec6190e2ae6bf245ffcc83aa16fd28c3;

		private SendOrPostCallback c163c8b5f21a96982565b99f556facf9b;

		private SendOrPostCallback c07bfe8875e1fb40de963e635457764f4;

		private SendOrPostCallback cd8299c0a5326f2d780b7b38869614a84;

		private SendOrPostCallback cea0f66cab8e8ce8f428633f284d03d87;

		private SendOrPostCallback c5894b02bec5c74e7372a2e5f54c22861;

		private SendOrPostCallback c0b276e86b83032b89b14eb147163487d;

		private SendOrPostCallback c3efad42e83dae6b6e7b9ada9246776b0;

		private SendOrPostCallback cc08f2d207cf7420905ab429a558d1463;

		private SendOrPostCallback cbd576aca9cfe791316af48fe0feda0c9;

		private SendOrPostCallback cf53dee8bbb6bd4c18ac66fca2ef3d914;

		private SendOrPostCallback c93253433cb4ea3ea3cf73f8046275592;

		private bool cbc4aa939fab65266405a3bd3863e01b7;

		private CBatchCompletedEventHandler c5dc9d9ae128da2baea9d6e079b3c1869;

		private AllowRunAsDebitCompletedEventHandler c1b3db1abcc6fad57fc95708d8b863f8c;

		private CTranDetailCompletedEventHandler c326b13139ea5710542336a6e00404aee;

		private CAllDetailCompletedEventHandler c66d85cfaaa6761c804fec2d2eb3d661e;

		private CAllDetailExCompletedEventHandler c8ea0aa341be43de825f0e47bd4e3c014;

		private CAllGiftDetailCompletedEventHandler ceccf8a0b1201e788dea555614b6955fa;

		private CreditTransactionCompletedEventHandler c8ac63297cd509ecf1eb5cf93dc5c47e2;

		private GiftTransactionCompletedEventHandler ca6e3d533981b5298600ae87404207b4e;

		private LoyaltyTransactionCompletedEventHandler c372df9765351fcb53004428670e78298;

		private AssociateAccountCompletedEventHandler c69d68f046827e1cec71dfd11ec4b19fa;

		private RemoveAccountAssociationCompletedEventHandler cc64cbf4d38357add21fe9a9e8562ab84;

		private LookupCompletedEventHandler cab9460057a0ed6edb497265c65cca8e6;

		public new string Url
		{
			get
			{
				string url = base.Url;
				return url;
			}
			set
			{
				// 
				// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::set_Url(System.String)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void set_Url(System.String)
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

		public new bool UseDefaultCredentials
		{
			get
			{
				bool useDefaultCredentials = base.UseDefaultCredentials;
				return useDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				this.cbc4aa939fab65266405a3bd3863e01b7 = true;
			}
		}

		public ws()
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::.ctor()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void .ctor()
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

		[SoapDocumentMethod("http://www.mercurypay.com/AllowRunAsDebit", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public bool AllowRunAsDebit(string merchant, string pw, string account)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x174c);
			object[] objArray = new object[] { merchant, pw, account };
			object[] objArray1 = this.Invoke(str, objArray);
			bool flag = Conversions.ToBoolean(objArray1[0]);
			return flag;
		}

		public void AllowRunAsDebitAsync(string merchant, string pw, string account)
		{
			this.AllowRunAsDebitAsync(merchant, pw, account, null);
		}

		public void AllowRunAsDebitAsync(string merchant, string pw, string account, object userState)
		{
			if (this.c163c8b5f21a96982565b99f556facf9b == null)
			{
				ws w = this;
				this.c163c8b5f21a96982565b99f556facf9b = new SendOrPostCallback(w.ccc2933bf78e5b057ec7090c7500fd357);
			}
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x174c);
			object[] objArray = new object[] { merchant, pw, account };
			this.InvokeAsync(str, objArray, this.c163c8b5f21a96982565b99f556facf9b, RuntimeHelpers.GetObjectValue(userState));
		}

		[SoapDocumentMethod("http://www.mercurypay.com/AssociateAccount", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public bool AssociateAccount(string account, string identifier, string merchantid, string memo, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1834);
			object[] objArray = new object[] { account, identifier, merchantid, memo, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			bool flag = Conversions.ToBoolean(objArray1[0]);
			return flag;
		}

		public void AssociateAccountAsync(string account, string identifier, string merchantid, string memo, string pw)
		{
			this.AssociateAccountAsync(account, identifier, merchantid, memo, pw, null);
		}

		public void AssociateAccountAsync(string account, string identifier, string merchantid, string memo, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::AssociateAccountAsync(System.String,System.String,System.String,System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void AssociateAccountAsync(System.String,System.String,System.String,System.String,System.String,System.Object)
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

		private void c0130445740f021764221e6afdd70e8a0(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c0130445740f021764221e6afdd70e8a0(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c0130445740f021764221e6afdd70e8a0(System.Object)
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

		private bool c3359653c346eaeb7815c8847052cf5c0(string cfa6de4ad573d345929ae630d3997a59c)
		{
			// 
			// Current member / type: System.Boolean CCProcess.com.mercurypay.w1.ws::c3359653c346eaeb7815c8847052cf5c0(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean c3359653c346eaeb7815c8847052cf5c0(System.String)
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

		private void c4c908b899eb63bc82f1378a2123df387(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c4c908b899eb63bc82f1378a2123df387(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c4c908b899eb63bc82f1378a2123df387(System.Object)
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

		private void c4d0e9236702e8d9d19c23b2eeee7db71(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c4d0e9236702e8d9d19c23b2eeee7db71(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c4d0e9236702e8d9d19c23b2eeee7db71(System.Object)
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

		private void c4da21965b52af909bf634b34863b690f(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c4da21965b52af909bf634b34863b690f(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c4da21965b52af909bf634b34863b690f(System.Object)
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

		private void c6350d6f96fa6e3b355d7bc48ad2f4192(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c6350d6f96fa6e3b355d7bc48ad2f4192(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c6350d6f96fa6e3b355d7bc48ad2f4192(System.Object)
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

		private void c66ec11374cc02c488b54ace8aecce918(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c66ec11374cc02c488b54ace8aecce918(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c66ec11374cc02c488b54ace8aecce918(System.Object)
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

		private void c83555c4601d8bfef6c0c89685c52027e(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c83555c4601d8bfef6c0c89685c52027e(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c83555c4601d8bfef6c0c89685c52027e(System.Object)
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

		private void c92b47eff59d1d02e2c992c954ffeadaf(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::c92b47eff59d1d02e2c992c954ffeadaf(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c92b47eff59d1d02e2c992c954ffeadaf(System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/CAllDetail", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string CAllDetail(string merchant, string pw, string invoice, string startdate, string enddate)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1782);
			object[] objArray = new object[] { merchant, pw, invoice, startdate, enddate };
			object[] objArray1 = this.Invoke(str, objArray);
			return Conversions.ToString(objArray1[0]);
		}

		public void CAllDetailAsync(string merchant, string pw, string invoice, string startdate, string enddate)
		{
			this.CAllDetailAsync(merchant, pw, invoice, startdate, enddate, null);
		}

		public void CAllDetailAsync(string merchant, string pw, string invoice, string startdate, string enddate, object userState)
		{
			if (this.cd8299c0a5326f2d780b7b38869614a84 == null)
			{
				ws w = this;
				this.cd8299c0a5326f2d780b7b38869614a84 = new SendOrPostCallback(w.c92b47eff59d1d02e2c992c954ffeadaf);
			}
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1782);
			object[] objArray = new object[] { merchant, pw, invoice, startdate, enddate };
			SendOrPostCallback sendOrPostCallback = this.cd8299c0a5326f2d780b7b38869614a84;
			object objectValue = RuntimeHelpers.GetObjectValue(userState);
			this.InvokeAsync(str, objArray, sendOrPostCallback, objectValue);
		}

		[SoapDocumentMethod("http://www.mercurypay.com/CAllDetailEx", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string CAllDetailEx(string merchant, string pw, string invoice, string startdate, string enddate, string transactioncode)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1797);
			object[] objArray = new object[] { merchant, pw, invoice, startdate, enddate, transactioncode };
			object[] objArray1 = this.Invoke(str, objArray);
			string str1 = Conversions.ToString(objArray1[0]);
			return str1;
		}

		public void CAllDetailExAsync(string merchant, string pw, string invoice, string startdate, string enddate, string transactioncode)
		{
			this.CAllDetailExAsync(merchant, pw, invoice, startdate, enddate, transactioncode, null);
		}

		public void CAllDetailExAsync(string merchant, string pw, string invoice, string startdate, string enddate, string transactioncode, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::CAllDetailExAsync(System.String,System.String,System.String,System.String,System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void CAllDetailExAsync(System.String,System.String,System.String,System.String,System.String,System.String,System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/CAllGiftDetail", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string CAllGiftDetail(string merchant, string pw, string invoice, string startdate, string enddate)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17b0);
			object[] objArray = new object[] { merchant, pw, invoice, startdate, enddate };
			object[] objArray1 = this.Invoke(str, objArray);
			string str1 = Conversions.ToString(objArray1[0]);
			return str1;
		}

		public void CAllGiftDetailAsync(string merchant, string pw, string invoice, string startdate, string enddate)
		{
			this.CAllGiftDetailAsync(merchant, pw, invoice, startdate, enddate, null);
		}

		public void CAllGiftDetailAsync(string merchant, string pw, string invoice, string startdate, string enddate, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::CAllGiftDetailAsync(System.String,System.String,System.String,System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void CAllGiftDetailAsync(System.String,System.String,System.String,System.String,System.String,System.Object)
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

		public new void CancelAsync(object userState)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(userState);
			base.CancelAsync(objectValue);
		}

		private void cb34b516d93d367b7a061a28915a7c628(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::cb34b516d93d367b7a061a28915a7c628(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void cb34b516d93d367b7a061a28915a7c628(System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/CBatch", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public DataSet CBatch(string merchant)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x173f);
			object[] objArray = new object[] { merchant };
			object[] objArray1 = this.Invoke(str, objArray);
			return (DataSet)objArray1[0];
		}

		public void CBatchAsync(string merchant)
		{
			this.CBatchAsync(merchant, null);
		}

		public void CBatchAsync(string merchant, object userState)
		{
			if (this.cec6190e2ae6bf245ffcc83aa16fd28c3 == null)
			{
				ws w = this;
				this.cec6190e2ae6bf245ffcc83aa16fd28c3 = new SendOrPostCallback(w.c0130445740f021764221e6afdd70e8a0);
			}
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x173f);
			object[] objArray = new object[] { merchant };
			SendOrPostCallback sendOrPostCallback = this.cec6190e2ae6bf245ffcc83aa16fd28c3;
			object objectValue = RuntimeHelpers.GetObjectValue(userState);
			this.InvokeAsync(str, objArray, sendOrPostCallback, objectValue);
		}

		private void cc1697932298a50de981963542455fe76(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::cc1697932298a50de981963542455fe76(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void cc1697932298a50de981963542455fe76(System.Object)
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

		private void ccc2933bf78e5b057ec7090c7500fd357(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::ccc2933bf78e5b057ec7090c7500fd357(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void ccc2933bf78e5b057ec7090c7500fd357(System.Object)
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

		private void cdb091f414d5196e27bc63032251cf513(object c5dca7ad6df7b7ae41685b45dd913c03f)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::cdb091f414d5196e27bc63032251cf513(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void cdb091f414d5196e27bc63032251cf513(System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/CreditTransaction", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string CreditTransaction(string tran, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17cd);
			object[] objArray = new object[] { tran, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			return Conversions.ToString(objArray1[0]);
		}

		public void CreditTransactionAsync(string tran, string pw)
		{
			this.CreditTransactionAsync(tran, pw, null);
		}

		public void CreditTransactionAsync(string tran, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::CreditTransactionAsync(System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void CreditTransactionAsync(System.String,System.String,System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/CTranDetail", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string CTranDetail(string merchant, string pw, string invoice)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x176b);
			object[] objArray = new object[] { merchant, pw, invoice };
			object[] objArray1 = this.Invoke(str, objArray);
			return Conversions.ToString(objArray1[0]);
		}

		public void CTranDetailAsync(string merchant, string pw, string invoice)
		{
			this.CTranDetailAsync(merchant, pw, invoice, null);
		}

		public void CTranDetailAsync(string merchant, string pw, string invoice, object userState)
		{
			if (this.c07bfe8875e1fb40de963e635457764f4 == null)
			{
				ws w = this;
				this.c07bfe8875e1fb40de963e635457764f4 = new SendOrPostCallback(w.cdb091f414d5196e27bc63032251cf513);
			}
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x176b);
			object[] objArray = new object[] { merchant, pw, invoice };
			this.InvokeAsync(str, objArray, this.c07bfe8875e1fb40de963e635457764f4, RuntimeHelpers.GetObjectValue(userState));
		}

		[SoapDocumentMethod("http://www.mercurypay.com/GiftTransaction", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string GiftTransaction(string tran, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17f0);
			object[] objArray = new object[] { tran, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			return Conversions.ToString(objArray1[0]);
		}

		public void GiftTransactionAsync(string tran, string pw)
		{
			this.GiftTransactionAsync(tran, pw, null);
		}

		public void GiftTransactionAsync(string tran, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::GiftTransactionAsync(System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void GiftTransactionAsync(System.String,System.String,System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/Lookup", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string Lookup(string tran, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1886);
			object[] objArray = new object[] { tran, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			string str1 = Conversions.ToString(objArray1[0]);
			return str1;
		}

		public void LookupAsync(string tran, string pw)
		{
			this.LookupAsync(tran, pw, null);
		}

		public void LookupAsync(string tran, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::LookupAsync(System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void LookupAsync(System.String,System.String,System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/LoyaltyTransaction", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public string LoyaltyTransaction(string tran, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x180f);
			object[] objArray = new object[] { tran, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			string str1 = Conversions.ToString(objArray1[0]);
			return str1;
		}

		public void LoyaltyTransactionAsync(string tran, string pw)
		{
			this.LoyaltyTransactionAsync(tran, pw, null);
		}

		public void LoyaltyTransactionAsync(string tran, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::LoyaltyTransactionAsync(System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void LoyaltyTransactionAsync(System.String,System.String,System.Object)
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

		[SoapDocumentMethod("http://www.mercurypay.com/RemoveAccountAssociation", ResponseNamespace="http://www.mercurypay.com", ParameterStyle=SoapParameterStyle.Wrapped, Use=SoapBindingUse.Literal, RequestNamespace="http://www.mercurypay.com")]
		public bool RemoveAccountAssociation(string account, string identifier, string merchantid, string pw)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1855);
			object[] objArray = new object[] { account, identifier, merchantid, pw };
			object[] objArray1 = this.Invoke(str, objArray);
			bool flag = Conversions.ToBoolean(objArray1[0]);
			return flag;
		}

		public void RemoveAccountAssociationAsync(string account, string identifier, string merchantid, string pw)
		{
			this.RemoveAccountAssociationAsync(account, identifier, merchantid, pw, null);
		}

		public void RemoveAccountAssociationAsync(string account, string identifier, string merchantid, string pw, object userState)
		{
			// 
			// Current member / type: System.Void CCProcess.com.mercurypay.w1.ws::RemoveAccountAssociationAsync(System.String,System.String,System.String,System.String,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void RemoveAccountAssociationAsync(System.String,System.String,System.String,System.String,System.Object)
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

		public event AllowRunAsDebitCompletedEventHandler AllowRunAsDebitCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.c1b3db1abcc6fad57fc95708d8b863f8c, obj);
				this.c1b3db1abcc6fad57fc95708d8b863f8c = (AllowRunAsDebitCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c1b3db1abcc6fad57fc95708d8b863f8c, obj);
				this.c1b3db1abcc6fad57fc95708d8b863f8c = (AllowRunAsDebitCompletedEventHandler)@delegate;
			}
		}

		public event AssociateAccountCompletedEventHandler AssociateAccountCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.c69d68f046827e1cec71dfd11ec4b19fa += obj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c69d68f046827e1cec71dfd11ec4b19fa, obj);
				this.c69d68f046827e1cec71dfd11ec4b19fa = (AssociateAccountCompletedEventHandler)@delegate;
			}
		}

		public event CAllDetailCompletedEventHandler CAllDetailCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.c66d85cfaaa6761c804fec2d2eb3d661e, obj);
				this.c66d85cfaaa6761c804fec2d2eb3d661e = (CAllDetailCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c66d85cfaaa6761c804fec2d2eb3d661e, obj);
				this.c66d85cfaaa6761c804fec2d2eb3d661e = (CAllDetailCompletedEventHandler)@delegate;
			}
		}

		public event CAllDetailExCompletedEventHandler CAllDetailExCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.c8ea0aa341be43de825f0e47bd4e3c014 += obj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.c8ea0aa341be43de825f0e47bd4e3c014 -= obj;
			}
		}

		public event CAllGiftDetailCompletedEventHandler CAllGiftDetailCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.ceccf8a0b1201e788dea555614b6955fa, obj);
				this.ceccf8a0b1201e788dea555614b6955fa = (CAllGiftDetailCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ceccf8a0b1201e788dea555614b6955fa -= obj;
			}
		}

		public event CBatchCompletedEventHandler CBatchCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.c5dc9d9ae128da2baea9d6e079b3c1869, obj);
				this.c5dc9d9ae128da2baea9d6e079b3c1869 = (CBatchCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c5dc9d9ae128da2baea9d6e079b3c1869, obj);
				this.c5dc9d9ae128da2baea9d6e079b3c1869 = (CBatchCompletedEventHandler)@delegate;
			}
		}

		public event CreditTransactionCompletedEventHandler CreditTransactionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.c8ac63297cd509ecf1eb5cf93dc5c47e2, obj);
				this.c8ac63297cd509ecf1eb5cf93dc5c47e2 = (CreditTransactionCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c8ac63297cd509ecf1eb5cf93dc5c47e2, obj);
				this.c8ac63297cd509ecf1eb5cf93dc5c47e2 = (CreditTransactionCompletedEventHandler)@delegate;
			}
		}

		public event CTranDetailCompletedEventHandler CTranDetailCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.c326b13139ea5710542336a6e00404aee, obj);
				this.c326b13139ea5710542336a6e00404aee = (CTranDetailCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.c326b13139ea5710542336a6e00404aee, obj);
				this.c326b13139ea5710542336a6e00404aee = (CTranDetailCompletedEventHandler)@delegate;
			}
		}

		public event GiftTransactionCompletedEventHandler GiftTransactionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ca6e3d533981b5298600ae87404207b4e += obj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ca6e3d533981b5298600ae87404207b4e, obj);
				this.ca6e3d533981b5298600ae87404207b4e = (GiftTransactionCompletedEventHandler)@delegate;
			}
		}

		public event LookupCompletedEventHandler LookupCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.cab9460057a0ed6edb497265c65cca8e6, obj);
				this.cab9460057a0ed6edb497265c65cca8e6 = (LookupCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.cab9460057a0ed6edb497265c65cca8e6, obj);
				this.cab9460057a0ed6edb497265c65cca8e6 = (LookupCompletedEventHandler)@delegate;
			}
		}

		public event LoyaltyTransactionCompletedEventHandler LoyaltyTransactionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.c372df9765351fcb53004428670e78298 += obj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.c372df9765351fcb53004428670e78298 -= obj;
			}
		}

		public event RemoveAccountAssociationCompletedEventHandler RemoveAccountAssociationCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				Delegate @delegate = Delegate.Combine(this.cc64cbf4d38357add21fe9a9e8562ab84, obj);
				this.cc64cbf4d38357add21fe9a9e8562ab84 = (RemoveAccountAssociationCompletedEventHandler)@delegate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.cc64cbf4d38357add21fe9a9e8562ab84, obj);
				this.cc64cbf4d38357add21fe9a9e8562ab84 = (RemoveAccountAssociationCompletedEventHandler)@delegate;
			}
		}
	}
}