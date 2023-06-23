using System;
using System.IO;
using System.Reflection;

namespace A
{
	internal class c1f0cc3d07c2b739a0d672e1cf3855285
	{
		private readonly static Assembly cf49214b6d2d67cbf49c45eefc06ba149;

		static c1f0cc3d07c2b739a0d672e1cf3855285()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.ResourceResolve += new ResolveEventHandler(c1f0cc3d07c2b739a0d672e1cf3855285.ccb05187647cc20ef06f9a3f5c042bb58);
			AppDomain appDomain = AppDomain.CurrentDomain;
			appDomain.AssemblyResolve += new ResolveEventHandler(c1f0cc3d07c2b739a0d672e1cf3855285.ca7f90a40e3323192b5645f38db95382b);
			string str = c1f0cc3d07c2b739a0d672e1cf3855285.c5a24ec171242a91aefffe7f3bdba7e25(Assembly.GetExecutingAssembly());
			c1f0cc3d07c2b739a0d672e1cf3855285.cf49214b6d2d67cbf49c45eefc06ba149 = Assembly.Load(str);
		}

		public c1f0cc3d07c2b739a0d672e1cf3855285()
		{
		}

		internal static void c530d0621fa43c28dc4e27d775445ae59()
		{
		}

		private static string c5a24ec171242a91aefffe7f3bdba7e25(Assembly ce7cb013702e09f7ddb5e3c7cf7c6fe1d)
		{
			string fullName = ce7cb013702e09f7ddb5e3c7cf7c6fe1d.FullName;
			string str = fullName;
			int num = str.IndexOf(',');
			int num1 = num;
			if (num1 >= 0)
			{
				string str1 = str.Substring(0, num1);
				str = str1;
			}
			return string.Concat(str, '&');
		}

		private static Assembly ca7f90a40e3323192b5645f38db95382b(object cf7d8a347db4ec9aed6c0c9437e4edbb6, ResolveEventArgs c0120e44e2313c0baf02e5a52170ad83d)
		{
			// 
			// Current member / type: System.Reflection.Assembly A.c1f0cc3d07c2b739a0d672e1cf3855285::ca7f90a40e3323192b5645f38db95382b(System.Object,System.ResolveEventArgs)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Reflection.Assembly ca7f90a40e3323192b5645f38db95382b(System.Object,System.ResolveEventArgs)
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

		private static Assembly ccb05187647cc20ef06f9a3f5c042bb58(object cf7d8a347db4ec9aed6c0c9437e4edbb6, ResolveEventArgs c0120e44e2313c0baf02e5a52170ad83d)
		{
			// 
			// Current member / type: System.Reflection.Assembly A.c1f0cc3d07c2b739a0d672e1cf3855285::ccb05187647cc20ef06f9a3f5c042bb58(System.Object,System.ResolveEventArgs)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Reflection.Assembly ccb05187647cc20ef06f9a3f5c042bb58(System.Object,System.ResolveEventArgs)
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