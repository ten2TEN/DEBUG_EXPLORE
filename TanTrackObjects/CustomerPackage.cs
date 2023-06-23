using Microsoft.VisualBasic;
using SqlLibrary;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace TanTrackObjects
{
	public class CustomerPackage
	{
		private int ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;

		private DateTime c7a66d5f5ecd66d92ad0d8f13e5255e1b;

		private int c57ce9238e0993552425c90df37720676;

		private int cffb83a18056a1eeaab713f89766c4bb0;

		private string cd31814b5f8d9e3a1e1057de5a173e803;

		private decimal c328ed57416383014dadbe0039c4212e4;

		private DateTime c4e06337911f0a975ea6e4f16368edf3e;

		private bool c2dfbae59736577c6cefc21dc2c01b21a;

		private int cdfb4f5c5937388ac52c862a57f85a7aa;

		private bool ce9c9284e04d3034b6501df6d46fea998;

		private DateTime c52378e3612d5ab77f7add08b59733e7a;

		private DateTime c5a8c3b1e92aa4c70e612700bc2250c86;

		private double ca65dad990f710e45064be4f274b8e460;

		private int c5703038875f79c3cd8cab8a8878e6800;

		private decimal ce46330e8f7c9ed4ea4c91fab0bad093c;

		private dbClient ca379c245fc4cfb1160e6bf3c0ebad564;

		private DataSet c5561cf841cbdf0b5aa63d2cb94a5e6ff;

		public bool bActivate_First_Use
		{
			get;
			set;
		}

		public bool bEFT
		{
			get
			{
				return this.c2dfbae59736577c6cefc21dc2c01b21a;
			}
			set
			{
				this.c2dfbae59736577c6cefc21dc2c01b21a = value;
			}
		}

		public bool bFrozen
		{
			get
			{
				return this.ce9c9284e04d3034b6501df6d46fea998;
			}
			set
			{
				this.ce9c9284e04d3034b6501df6d46fea998 = value;
			}
		}

		public bool bRollover
		{
			get;
			set;
		}

		public int ClientID
		{
			get
			{
				return this.c57ce9238e0993552425c90df37720676;
			}
			set
			{
				this.c57ce9238e0993552425c90df37720676 = value;
			}
		}

		public DateTime DateCreate
		{
			get
			{
				return this.c7a66d5f5ecd66d92ad0d8f13e5255e1b;
			}
			set
			{
				this.c7a66d5f5ecd66d92ad0d8f13e5255e1b = value;
			}
		}

		public dbClient db
		{
			get
			{
				return this.ca379c245fc4cfb1160e6bf3c0ebad564;
			}
			set
			{
				this.ca379c245fc4cfb1160e6bf3c0ebad564 = value;
			}
		}

		public double DraftAmount
		{
			get
			{
				return this.ca65dad990f710e45064be4f274b8e460;
			}
			set
			{
				this.ca65dad990f710e45064be4f274b8e460 = value;
			}
		}

		public DataTable DSEFT
		{
			get
			{
				DataTableCollection tables = this.c5561cf841cbdf0b5aa63d2cb94a5e6ff.Tables;
				DataTable item = tables[1];
				return item;
			}
		}

		public DateTime dtEFTNextPay
		{
			get
			{
				return this.c5a8c3b1e92aa4c70e612700bc2250c86;
			}
			set
			{
				this.c5a8c3b1e92aa4c70e612700bc2250c86 = value;
			}
		}

		public DateTime dtEFTPrevPay
		{
			get
			{
				return this.c52378e3612d5ab77f7add08b59733e7a;
			}
			set
			{
				this.c52378e3612d5ab77f7add08b59733e7a = value;
			}
		}

		public DateTime dtExpire
		{
			get
			{
				return this.c4e06337911f0a975ea6e4f16368edf3e;
			}
			set
			{
				this.c4e06337911f0a975ea6e4f16368edf3e = value;
			}
		}

		public DateTime dtForcedExp
		{
			get;
			set;
		}

		public DateTime dtForcedStart
		{
			get;
			set;
		}

		public decimal EFTTotal
		{
			get
			{
				return this.ce46330e8f7c9ed4ea4c91fab0bad093c;
			}
			set
			{
				this.ce46330e8f7c9ed4ea4c91fab0bad093c = value;
			}
		}

		public int EFTType
		{
			get
			{
				return this.cdfb4f5c5937388ac52c862a57f85a7aa;
			}
			set
			{
				this.cdfb4f5c5937388ac52c862a57f85a7aa = value;
			}
		}

		public int EndTypeID
		{
			get;
			set;
		}

		public int ExpiryDays
		{
			get;
			set;
		}

		public int ExpiryMonths
		{
			get;
			set;
		}

		public int ID
		{
			get
			{
				return this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;
			}
			set
			{
				this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = value;
			}
		}

		public string PackageName
		{
			get
			{
				return this.cd31814b5f8d9e3a1e1057de5a173e803;
			}
			set
			{
				this.cd31814b5f8d9e3a1e1057de5a173e803 = value;
			}
		}

		public int PackageTypeID
		{
			get
			{
				return this.c5703038875f79c3cd8cab8a8878e6800;
			}
			set
			{
				this.c5703038875f79c3cd8cab8a8878e6800 = value;
			}
		}

		public int PandSID
		{
			get
			{
				return this.cffb83a18056a1eeaab713f89766c4bb0;
			}
			set
			{
				this.cffb83a18056a1eeaab713f89766c4bb0 = value;
			}
		}

		public decimal Qty
		{
			get
			{
				return this.c328ed57416383014dadbe0039c4212e4;
			}
			set
			{
				this.c328ed57416383014dadbe0039c4212e4 = value;
			}
		}

		public int StartTypeID
		{
			get;
			set;
		}

		public CustomerPackage()
		{
			this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = new int();
			this.c7a66d5f5ecd66d92ad0d8f13e5255e1b = new DateTime();
			this.c57ce9238e0993552425c90df37720676 = new int();
			this.cffb83a18056a1eeaab713f89766c4bb0 = new int();
			this.c328ed57416383014dadbe0039c4212e4 = new decimal();
			this.c4e06337911f0a975ea6e4f16368edf3e = new DateTime();
			this.c2dfbae59736577c6cefc21dc2c01b21a = new bool();
			this.ce46330e8f7c9ed4ea4c91fab0bad093c = new decimal();
			this.ca379c245fc4cfb1160e6bf3c0ebad564 = new dbClient();
			this.c5561cf841cbdf0b5aa63d2cb94a5e6ff = new DataSet();
		}

		private object c1b95a3e96f0a5466604b2e0304bd2b04(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ce5f8f2f2cdceaf36fe8cd52bf4c9f139);
			bool flag = Information.IsDBNull(objectValue);
			if (flag)
			{
				return null;
			}
			return ce5f8f2f2cdceaf36fe8cd52bf4c9f139;
		}

		public bool Load(int cpid)
		{
			// 
			// Current member / type: System.Boolean TanTrackObjects.CustomerPackage::Load(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean Load(System.Int32)
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