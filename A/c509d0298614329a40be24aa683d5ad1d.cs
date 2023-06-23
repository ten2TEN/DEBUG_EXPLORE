using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	internal class c509d0298614329a40be24aa683d5ad1d
	{
		internal readonly static byte[] c15e33c00562e84aede6d8bfe60a3f241;

		static c509d0298614329a40be24aa683d5ad1d()
		{
			if (c509d0298614329a40be24aa683d5ad1d.c15e33c00562e84aede6d8bfe60a3f241 == null)
			{
				byte[] numArray = Convert.FromBase64String("VGFuVHJhY2tPYmplY3RzJA==");
				byte[] numArray1 = numArray;
				Encoding uTF8 = Encoding.UTF8;
				string str = uTF8.GetString(numArray1, 0, (int)numArray1.Length);
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(str);
				byte[] numArray2 = cc2bb9055ed4d0eae3799bffa4e83d25b.c2911bb035c7da8116056d61e1e4a299a((long)97, manifestResourceStream);
				c509d0298614329a40be24aa683d5ad1d.c15e33c00562e84aede6d8bfe60a3f241 = numArray2;
			}
		}

		public c509d0298614329a40be24aa683d5ad1d()
		{
		}

		internal static string c2a612a176ab45500f820316f6e1b7149(int c1332cc1afe220d024455b145f96e087a)
		{
			// 
			// Current member / type: System.String A.c509d0298614329a40be24aa683d5ad1d::c2a612a176ab45500f820316f6e1b7149(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String c2a612a176ab45500f820316f6e1b7149(System.Int32)
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