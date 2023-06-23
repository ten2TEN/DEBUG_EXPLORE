using A;
using Chilkat;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace SqlLibrary
{
	public class DbLocation
	{
		private string c1362f2d9d7c2837a56acca09d4cb2b39;

		private string c4d3aa220c76a8fa749a28dc5fc433809;

		private string cb4eb4757d812261350df31d51e7e0347;

		private int cbf9867d2b4bb22caddc6b87de8deb2f0;

		private string c15f669270bf8d9a5c9ba5edada54fa78;

		private int c90b8d9b7d1758b8941828203dbe9111d;

		private string ce673ad045388c70a56dd8848ef552c2e;

		private string c939f4758d0c41f3668e0cb5f5f13f854;

		private string c63132a62ec40fa9086e7e80291eca4c1;

		private string cef5cbf8efd7932998399dc49014ca816;

		private string c4368ebb0c7d33b0ca8881c6126102e7e;

		private string cacc16bb50cba540622a7b8d793886f41;

		private string c87e5d93713edf42ad8583de94940c3f6;

		private Crypt2 c3164742b9632edceb2921d140b1527f5;

		public Crypt2 Crypt
		{
			get
			{
				return this.c3164742b9632edceb2921d140b1527f5;
			}
			set
			{
				this.c3164742b9632edceb2921d140b1527f5 = value;
			}
		}

		public string db
		{
			get
			{
				return this.ce673ad045388c70a56dd8848ef552c2e;
			}
			set
			{
				this.ce673ad045388c70a56dd8848ef552c2e = value;
			}
		}

		public string dbName
		{
			get
			{
				return this.c939f4758d0c41f3668e0cb5f5f13f854;
			}
			set
			{
				this.c939f4758d0c41f3668e0cb5f5f13f854 = value;
			}
		}

		public string DrawerNumber
		{
			get
			{
				return this.cacc16bb50cba540622a7b8d793886f41;
			}
			set
			{
				this.cacc16bb50cba540622a7b8d793886f41 = value;
			}
		}

		public string HashAlgorithm
		{
			get
			{
				return this.cb4eb4757d812261350df31d51e7e0347;
			}
			set
			{
				this.cb4eb4757d812261350df31d51e7e0347 = value;
			}
		}

		public string InitVector
		{
			get
			{
				return this.c15f669270bf8d9a5c9ba5edada54fa78;
			}
			set
			{
				this.c15f669270bf8d9a5c9ba5edada54fa78 = value;
			}
		}

		public int KeySize
		{
			get
			{
				return this.c90b8d9b7d1758b8941828203dbe9111d;
			}
			set
			{
				this.c90b8d9b7d1758b8941828203dbe9111d = value;
			}
		}

		public string PassPhrase
		{
			get
			{
				return this.c1362f2d9d7c2837a56acca09d4cb2b39;
			}
			set
			{
				this.c1362f2d9d7c2837a56acca09d4cb2b39 = value;
			}
		}

		public string Password
		{
			get
			{
				return this.cef5cbf8efd7932998399dc49014ca816;
			}
			set
			{
				this.cef5cbf8efd7932998399dc49014ca816 = value;
			}
		}

		public int PasswordIterations
		{
			get
			{
				return this.cbf9867d2b4bb22caddc6b87de8deb2f0;
			}
			set
			{
				this.cbf9867d2b4bb22caddc6b87de8deb2f0 = value;
			}
		}

		public string Port
		{
			get
			{
				return this.c87e5d93713edf42ad8583de94940c3f6;
			}
			set
			{
				this.c87e5d93713edf42ad8583de94940c3f6 = value;
			}
		}

		public string SaltValue
		{
			get
			{
				return this.c4d3aa220c76a8fa749a28dc5fc433809;
			}
			set
			{
				this.c4d3aa220c76a8fa749a28dc5fc433809 = value;
			}
		}

		public string StoreNumber
		{
			get
			{
				return this.c4368ebb0c7d33b0ca8881c6126102e7e;
			}
			set
			{
				this.c4368ebb0c7d33b0ca8881c6126102e7e = value;
			}
		}

		public string UserName
		{
			get
			{
				return this.c63132a62ec40fa9086e7e80291eca4c1;
			}
			set
			{
				this.c63132a62ec40fa9086e7e80291eca4c1 = value;
			}
		}

		public DbLocation()
		{
			this.cbf9867d2b4bb22caddc6b87de8deb2f0 = new int();
			this.c90b8d9b7d1758b8941828203dbe9111d = new int();
			this.c4368ebb0c7d33b0ca8881c6126102e7e = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11220);
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11220);
			this.cacc16bb50cba540622a7b8d793886f41 = str;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112dc);
			this.c87e5d93713edf42ad8583de94940c3f6 = str1;
			this.c3164742b9632edceb2921d140b1527f5 = new Crypt2();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void CryptLoad()
		{
			// 
			// Current member / type: System.Void SqlLibrary.DbLocation::CryptLoad()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void CryptLoad()
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Load()
		{
			try
			{
				AssemblyInfo info = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996.Info;
				string productName = info.ProductName;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x99ff);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11209);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11220);
				string setting = Interaction.GetSetting(productName, str, str1, str2);
				string str3 = Strings.Trim(setting);
				this.StoreNumber = str3;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				string productName1 = _cef4fffd9795b6af60f35514532347eb4.Info.ProductName;
				string setting1 = Interaction.GetSetting(productName1, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x99ff), c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11223), c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11220));
				string str4 = Strings.Trim(setting1);
				this.DrawerNumber = str4;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb41 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				AssemblyInfo assemblyInfo = _cef4fffd9795b6af60f35514532347eb41.Info;
				string productName2 = assemblyInfo.ProductName;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1123c);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1124d);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1125a);
				string setting2 = Interaction.GetSetting(productName2, str5, str6, str7);
				string str8 = Strings.Trim(setting2);
				this.Port = str8;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		public void SetCryptValues()
		{
			// 
			// Current member / type: System.Void SqlLibrary.DbLocation::SetCryptValues()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void SetCryptValues()
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

		public void SetValues()
		{
			this.PassPhrase = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11123);
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11134);
			this.SaltValue = str;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11151);
			this.HashAlgorithm = str1;
			this.PasswordIterations = 2;
			this.InitVector = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1115a);
			this.KeySize = 0x100;
		}
	}
}