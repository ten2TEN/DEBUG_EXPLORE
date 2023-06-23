using A;
using Chilkat;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace TimerObjects
{
	public class Employee : SqlBase
	{
		private string c44185a51ccb36e495583e9f79402d9d2;

		private string c0f589f0410a9e279a6c9317774c43f33;

		private string c7b9394f3d8bc47c614878e8bd3995779;

		private int ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;

		private string cc2a62a75378045b4cb7d49501d60f1b9;

		private string cb1004409d640d1c3f5949022888e9c32;

		private string c514c078e75f59bda884cb81a3af6ce48;

		private string c5b7c467bb382cc2351973ca3a47416b2;

		private string cb44ab9cb7b3c78c3d05d47571870c581;

		private string c2168f76345360f219e4815caf6da0fd8;

		private string c1b911ad5605ab77ce05e1d7e1086a822;

		private string c53378c383d40c53475b7ea6736083237;

		private DateTime cf0b147587c14244dcf4d9ab0e658d23d;

		private DateTime ca17a516b9b83e0dfad9d2112386e4814;

		private string cd1a6f19b2baff6439680b28d34188d7e;

		private string c70c76a4ee4a503a6ead318b8b0572779;

		private string c7d281d699b365ff8a0bf54b653401e19;

		private string c56c7c5716ec9f9ebeeb5a297347810ce;

		private decimal c947760290b097be31505d13bc8be6093;

		private bool cf4cd9b8a6628f753f04e3d959a0b426a;

		private bool c24a8e3f58a8b7a1072621dbdf6aea72a;

		private string c812666379ed7993cb3f6c7184d4648fa;

		private string c7311c3f0c89b42a192e978a3e92e1763;

		private string c8af649bd75d08c2b6fc2197ee8b18ca9;

		private string c828c0c29272255ded1af2484474bcc7a;

		private string c1cd14941a8728ac4e15df8b0a0e28829;

		private string c11959c32d6fd23bc974d8a8e2b4b6e44;

		private string ce9af970cd65ec65d196f2f6310beb966;

		private string cb62aad1a383eb75ced06503d9234ee4f;

		private bool cad890e8107476e321246d375d331467d;

		private double ce0d1b1a88008c754f6b5eb6de9a186ca;

		private double c0273b17d81492da0611afd39a32a0268;

		private string c1c8374bfc1f5371de5c1fcf0d6371ef2;

		private int c1537fb41f79ffb612838eb1aa724800c;

		private object c9811840ede924ad70f3aef8910bf9635;

		private DateTime cedc9d66586b316cefbd17330cf237e37;

		private bool c1ec9576e9f28ac5d8e13712943b33adf;

		private DateTime cbf69bcfbb3bc8a1ddb4d2084c303de16;

		private bool c07a35ed310aecbd92ccd21bbe52a20cf;

		private bool c5cb25bd5b92254dd6410890412210f04;

		private bool c4131aab55281c4c7ea9ac4bdf5d2cd06;

		private bool ca4ac0039398d434dcbafe6cc58874fab;

		private bool c28ef8f331649d8478749a3864bb764e0;

		private string c998455d60c898dd59a6618ea01b5828e;

		private bool c7caba41bdc31837163ea87d24b6080a6;

		private bool ce69c54714c4d9dc4e84a891d5c169932;

		private bool ceadda08cb2586f1353af7a1ab18bd658;

		private bool cd3460e6d78bb30d472da595a49eaf18f;

		private bool c667b725536e3afcb6f110fed6aacd967;

		private bool c8bfd78303f0d80910404aaaddc750f0d;

		private bool c0e0d0e8b726f9951340a421bb67be660;

		private bool c29cac42d67ca1066a6bf1858e67c3957;

		private bool c6a1aae1c5a84bdddedc7de0e99750d3c;

		private bool c3ab3a7ce7a6744417401e19e77ac4efb;

		private string c2e1dfb57e3450c98aa181f256eff6887;

		private bool c75c00a825829f2fbc9311408bf639942;

		private bool cdbf8a7aa4fa01aebb98197a66a647fbe;

		private bool c40c5e2f667d07de7078e448e889ad524;

		private bool c2b302cac4fe735f98c657e9f3b462738;

		private bool c83fda04781e377d85f12fa914cb1fdb4;

		private bool c83e91368d672c5f2f87fd7c6b42979d1;

		private bool ca33581e87cb3913a17cebb97fea89bca;

		private byte[] ca06e20889bed3207518d14e47f08b227;

		private byte[] c4ba1cefe5dd42cfe63a89f1fc5483582;

		private bool c2dfbae59736577c6cefc21dc2c01b21a;

		private bool c3d5cec444a5da1f180a11586a0909688;

		private bool ccb38bc5df2f3f9eb7dc42a1a5705ef05;

		private DataSet c83af6310381e48dafa9edfaa3ff91e0e;

		private DataSet c5211bb6d57f9b9cca79210505063b431;

		public string Address
		{
			get
			{
				return this.cc2a62a75378045b4cb7d49501d60f1b9;
			}
			set
			{
				this.cc2a62a75378045b4cb7d49501d60f1b9 = value;
			}
		}

		public bool bAllowBackups
		{
			get
			{
				return this.c40c5e2f667d07de7078e448e889ad524;
			}
			set
			{
				this.c40c5e2f667d07de7078e448e889ad524 = value;
			}
		}

		public bool bAllowEMail
		{
			get
			{
				return this.c2b302cac4fe735f98c657e9f3b462738;
			}
			set
			{
				this.c2b302cac4fe735f98c657e9f3b462738 = value;
			}
		}

		public bool bAllowOverrides
		{
			get
			{
				return this.c75c00a825829f2fbc9311408bf639942;
			}
			set
			{
				this.c75c00a825829f2fbc9311408bf639942 = value;
			}
		}

		public bool bAllowVacationHolds
		{
			get
			{
				return this.cdbf8a7aa4fa01aebb98197a66a647fbe;
			}
			set
			{
				this.cdbf8a7aa4fa01aebb98197a66a647fbe = value;
			}
		}

		public bool bCancelEFT
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

		public bool bCustomerReports
		{
			get
			{
				return this.c0e0d0e8b726f9951340a421bb67be660;
			}
			set
			{
				this.c0e0d0e8b726f9951340a421bb67be660 = value;
			}
		}

		public bool bDeleteCustomers
		{
			get
			{
				return this.c7caba41bdc31837163ea87d24b6080a6;
			}
			set
			{
				this.c7caba41bdc31837163ea87d24b6080a6 = value;
			}
		}

		public bool bDirty
		{
			get
			{
				return this.c24a8e3f58a8b7a1072621dbdf6aea72a;
			}
			set
			{
				this.c24a8e3f58a8b7a1072621dbdf6aea72a = value;
			}
		}

		public bool bEdit_Client_package
		{
			get
			{
				return this.c3d5cec444a5da1f180a11586a0909688;
			}
			set
			{
				this.c3d5cec444a5da1f180a11586a0909688 = value;
			}
		}

		public bool bEditBed
		{
			get
			{
				return this.c83e91368d672c5f2f87fd7c6b42979d1;
			}
			set
			{
				this.c83e91368d672c5f2f87fd7c6b42979d1 = value;
			}
		}

		public bool bEditCategories
		{
			get
			{
				return this.cd3460e6d78bb30d472da595a49eaf18f;
			}
			set
			{
				this.cd3460e6d78bb30d472da595a49eaf18f = value;
			}
		}

		public bool bEditCustomerSessions
		{
			get
			{
				return this.ce69c54714c4d9dc4e84a891d5c169932;
			}
			set
			{
				this.ce69c54714c4d9dc4e84a891d5c169932 = value;
			}
		}

		public bool bEditEmployees
		{
			get
			{
				return this.c07a35ed310aecbd92ccd21bbe52a20cf;
			}
			set
			{
				this.c07a35ed310aecbd92ccd21bbe52a20cf = value;
			}
		}

		public bool bEditEquipment
		{
			get
			{
				return this.c667b725536e3afcb6f110fed6aacd967;
			}
			set
			{
				this.c667b725536e3afcb6f110fed6aacd967 = value;
			}
		}

		public bool bEditGiftCertificate
		{
			get
			{
				return this.c28ef8f331649d8478749a3864bb764e0;
			}
			set
			{
				this.c28ef8f331649d8478749a3864bb764e0 = value;
			}
		}

		public bool bEditPackages
		{
			get
			{
				return this.c4131aab55281c4c7ea9ac4bdf5d2cd06;
			}
			set
			{
				this.c4131aab55281c4c7ea9ac4bdf5d2cd06 = value;
			}
		}

		public bool bEditProducts
		{
			get
			{
				return this.c5cb25bd5b92254dd6410890412210f04;
			}
			set
			{
				this.c5cb25bd5b92254dd6410890412210f04 = value;
			}
		}

		public bool bEditService
		{
			get
			{
				return this.ca33581e87cb3913a17cebb97fea89bca;
			}
			set
			{
				this.ca33581e87cb3913a17cebb97fea89bca = value;
			}
		}

		public bool bEditSetup
		{
			get
			{
				return this.ca4ac0039398d434dcbafe6cc58874fab;
			}
			set
			{
				this.ca4ac0039398d434dcbafe6cc58874fab = value;
			}
		}

		public bool bEditSuppliers
		{
			get
			{
				return this.ceadda08cb2586f1353af7a1ab18bd658;
			}
			set
			{
				this.ceadda08cb2586f1353af7a1ab18bd658 = value;
			}
		}

		public bool bHourly
		{
			get
			{
				return this.cf4cd9b8a6628f753f04e3d959a0b426a;
			}
			set
			{
				this.cf4cd9b8a6628f753f04e3d959a0b426a = value;
			}
		}

		public DateTime BirthDate
		{
			get
			{
				return this.cf0b147587c14244dcf4d9ab0e658d23d;
			}
			set
			{
				this.cf0b147587c14244dcf4d9ab0e658d23d = value;
			}
		}

		public bool bOpenDrawer
		{
			get
			{
				return this.c6a1aae1c5a84bdddedc7de0e99750d3c;
			}
			set
			{
				this.c6a1aae1c5a84bdddedc7de0e99750d3c = value;
			}
		}

		public bool bRefunds
		{
			get
			{
				return this.c3ab3a7ce7a6744417401e19e77ac4efb;
			}
			set
			{
				this.c3ab3a7ce7a6744417401e19e77ac4efb = value;
			}
		}

		public bool bRehire
		{
			get
			{
				return this.cad890e8107476e321246d375d331467d;
			}
			set
			{
				this.cad890e8107476e321246d375d331467d = value;
			}
		}

		public bool bSalesReports
		{
			get
			{
				return this.c29cac42d67ca1066a6bf1858e67c3957;
			}
			set
			{
				this.c29cac42d67ca1066a6bf1858e67c3957 = value;
			}
		}

		public bool bTerminated
		{
			get
			{
				return this.c1ec9576e9f28ac5d8e13712943b33adf;
			}
			set
			{
				this.c1ec9576e9f28ac5d8e13712943b33adf = value;
			}
		}

		public bool bTimer_Queue
		{
			get
			{
				return this.ccb38bc5df2f3f9eb7dc42a1a5705ef05;
			}
			set
			{
				this.ccb38bc5df2f3f9eb7dc42a1a5705ef05 = value;
			}
		}

		public bool bTransferSessions
		{
			get
			{
				return this.c83fda04781e377d85f12fa914cb1fdb4;
			}
			set
			{
				this.c83fda04781e377d85f12fa914cb1fdb4 = value;
			}
		}

		public bool bUseSystemTools
		{
			get
			{
				return this.c8bfd78303f0d80910404aaaddc750f0d;
			}
			set
			{
				this.c8bfd78303f0d80910404aaaddc750f0d = value;
			}
		}

		public string City
		{
			get
			{
				return this.cb1004409d640d1c3f5949022888e9c32;
			}
			set
			{
				this.cb1004409d640d1c3f5949022888e9c32 = value;
			}
		}

		public string Country
		{
			get
			{
				return this.c56c7c5716ec9f9ebeeb5a297347810ce;
			}
			set
			{
				this.c56c7c5716ec9f9ebeeb5a297347810ce = value;
			}
		}

		public string County
		{
			get
			{
				return this.c7d281d699b365ff8a0bf54b653401e19;
			}
			set
			{
				this.c7d281d699b365ff8a0bf54b653401e19 = value;
			}
		}

		public double dPackageCommission
		{
			get
			{
				return this.c0273b17d81492da0611afd39a32a0268;
			}
			set
			{
				this.c0273b17d81492da0611afd39a32a0268 = value;
			}
		}

		public double dProductCommission
		{
			get
			{
				return this.ce0d1b1a88008c754f6b5eb6de9a186ca;
			}
			set
			{
				this.ce0d1b1a88008c754f6b5eb6de9a186ca = value;
			}
		}

		public DataSet ds
		{
			get
			{
				return this.c83af6310381e48dafa9edfaa3ff91e0e;
			}
			set
			{
				this.c83af6310381e48dafa9edfaa3ff91e0e = value;
			}
		}

		public string ECAddress
		{
			get
			{
				return this.c7311c3f0c89b42a192e978a3e92e1763;
			}
			set
			{
				this.c7311c3f0c89b42a192e978a3e92e1763 = value;
			}
		}

		public string ECCity
		{
			get
			{
				return this.c8af649bd75d08c2b6fc2197ee8b18ca9;
			}
			set
			{
				this.c8af649bd75d08c2b6fc2197ee8b18ca9 = value;
			}
		}

		public string ECName
		{
			get
			{
				return this.c812666379ed7993cb3f6c7184d4648fa;
			}
			set
			{
				this.c812666379ed7993cb3f6c7184d4648fa = value;
			}
		}

		public string ECPhone1
		{
			get
			{
				return this.c11959c32d6fd23bc974d8a8e2b4b6e44;
			}
			set
			{
				this.c11959c32d6fd23bc974d8a8e2b4b6e44 = value;
			}
		}

		public string ECPhone2
		{
			get
			{
				return this.ce9af970cd65ec65d196f2f6310beb966;
			}
			set
			{
				this.ce9af970cd65ec65d196f2f6310beb966 = value;
			}
		}

		public string ECRelation
		{
			get
			{
				return this.cb62aad1a383eb75ced06503d9234ee4f;
			}
			set
			{
				this.cb62aad1a383eb75ced06503d9234ee4f = value;
			}
		}

		public string ECState
		{
			get
			{
				return this.c828c0c29272255ded1af2484474bcc7a;
			}
			set
			{
				this.c828c0c29272255ded1af2484474bcc7a = value;
			}
		}

		public string ECZip
		{
			get
			{
				return this.c1cd14941a8728ac4e15df8b0a0e28829;
			}
			set
			{
				this.c1cd14941a8728ac4e15df8b0a0e28829 = value;
			}
		}

		public string Email
		{
			get
			{
				return this.cd1a6f19b2baff6439680b28d34188d7e;
			}
			set
			{
				this.cd1a6f19b2baff6439680b28d34188d7e = value;
			}
		}

		public string Employee_Number
		{
			get
			{
				return this.c1c8374bfc1f5371de5c1fcf0d6371ef2;
			}
			set
			{
				this.c1c8374bfc1f5371de5c1fcf0d6371ef2 = value;
			}
		}

		public string Extension
		{
			get
			{
				return this.c70c76a4ee4a503a6ead318b8b0572779;
			}
			set
			{
				this.c70c76a4ee4a503a6ead318b8b0572779 = value;
			}
		}

		public byte[] FingerImage
		{
			get
			{
				return this.c4ba1cefe5dd42cfe63a89f1fc5483582;
			}
			set
			{
				this.c4ba1cefe5dd42cfe63a89f1fc5483582 = value;
			}
		}

		public string FirstName
		{
			get
			{
				return this.c44185a51ccb36e495583e9f79402d9d2;
			}
			set
			{
				this.c44185a51ccb36e495583e9f79402d9d2 = value;
			}
		}

		public DateTime HireDate
		{
			get
			{
				return this.ca17a516b9b83e0dfad9d2112386e4814;
			}
			set
			{
				this.ca17a516b9b83e0dfad9d2112386e4814 = value;
			}
		}

		public int Home_Store_Number
		{
			get
			{
				return this.c1537fb41f79ffb612838eb1aa724800c;
			}
			set
			{
				this.c1537fb41f79ffb612838eb1aa724800c = value;
			}
		}

		public string HomePhone
		{
			get
			{
				return this.cb44ab9cb7b3c78c3d05d47571870c581;
			}
			set
			{
				this.cb44ab9cb7b3c78c3d05d47571870c581 = value;
			}
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

		public string LastName
		{
			get
			{
				return this.c7b9394f3d8bc47c614878e8bd3995779;
			}
			set
			{
				this.c7b9394f3d8bc47c614878e8bd3995779 = value;
			}
		}

		public DateTime LastReviewDate
		{
			get
			{
				return this.cbf69bcfbb3bc8a1ddb4d2084c303de16;
			}
			set
			{
				this.cbf69bcfbb3bc8a1ddb4d2084c303de16 = value;
			}
		}

		public string MiddleName
		{
			get
			{
				return this.c0f589f0410a9e279a6c9317774c43f33;
			}
			set
			{
				this.c0f589f0410a9e279a6c9317774c43f33 = value;
			}
		}

		public string Notes
		{
			get
			{
				return this.c2168f76345360f219e4815caf6da0fd8;
			}
			set
			{
				this.c2168f76345360f219e4815caf6da0fd8 = value;
			}
		}

		public byte[] Picture
		{
			get
			{
				return this.ca06e20889bed3207518d14e47f08b227;
			}
			set
			{
				this.ca06e20889bed3207518d14e47f08b227 = value;
			}
		}

		public string QBEmpName
		{
			get
			{
				return this.c2e1dfb57e3450c98aa181f256eff6887;
			}
			set
			{
				this.c2e1dfb57e3450c98aa181f256eff6887 = value;
			}
		}

		public string SSN
		{
			get
			{
				return this.c1b911ad5605ab77ce05e1d7e1086a822;
			}
			set
			{
				this.c1b911ad5605ab77ce05e1d7e1086a822 = value;
			}
		}

		public string State
		{
			get
			{
				return this.c514c078e75f59bda884cb81a3af6ce48;
			}
			set
			{
				this.c514c078e75f59bda884cb81a3af6ce48 = value;
			}
		}

		public string strPassword
		{
			get
			{
				return this.c998455d60c898dd59a6618ea01b5828e;
			}
			set
			{
				this.c998455d60c898dd59a6618ea01b5828e = value;
			}
		}

		public DateTime TerminationDate
		{
			get
			{
				return this.cedc9d66586b316cefbd17330cf237e37;
			}
			set
			{
				this.cedc9d66586b316cefbd17330cf237e37 = value;
			}
		}

		public string Title
		{
			get
			{
				return this.c53378c383d40c53475b7ea6736083237;
			}
			set
			{
				this.c53378c383d40c53475b7ea6736083237 = value;
			}
		}

		public object vPicture
		{
			get
			{
				// 
				// Current member / type: System.Object TimerObjects.Employee::get_vPicture()
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Object get_vPicture()
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
			set
			{
				object objectValue = RuntimeHelpers.GetObjectValue(value);
				if (!(Information.IsReference(objectValue) & !(value is string)))
				{
					object obj = RuntimeHelpers.GetObjectValue(value);
					this.c9811840ede924ad70f3aef8910bf9635 = obj;
				}
				else
				{
					object objectValue1 = RuntimeHelpers.GetObjectValue(value);
					this.c9811840ede924ad70f3aef8910bf9635 = objectValue1;
				}
			}
		}

		public decimal Wage_Hourly
		{
			get
			{
				return this.c947760290b097be31505d13bc8be6093;
			}
			set
			{
				this.c947760290b097be31505d13bc8be6093 = value;
			}
		}

		public string Zip
		{
			get
			{
				return this.c5b7c467bb382cc2351973ca3a47416b2;
			}
			set
			{
				this.c5b7c467bb382cc2351973ca3a47416b2 = value;
			}
		}

		public Employee()
		{
			this.c83af6310381e48dafa9edfaa3ff91e0e = new DataSet();
			this.c5211bb6d57f9b9cca79210505063b431 = new DataSet();
		}

		private object c1b95a3e96f0a5466604b2e0304bd2b04(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object TimerObjects.Employee::c1b95a3e96f0a5466604b2e0304bd2b04(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object c1b95a3e96f0a5466604b2e0304bd2b04(System.Object)
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

		public void Clear()
		{
			this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = -1;
			this.c44185a51ccb36e495583e9f79402d9d2 = "";
			this.c7b9394f3d8bc47c614878e8bd3995779 = "";
			this.c0f589f0410a9e279a6c9317774c43f33 = "";
			this.cc2a62a75378045b4cb7d49501d60f1b9 = "";
			this.cb1004409d640d1c3f5949022888e9c32 = "";
			this.c514c078e75f59bda884cb81a3af6ce48 = "";
			this.c5b7c467bb382cc2351973ca3a47416b2 = "";
			this.cb44ab9cb7b3c78c3d05d47571870c581 = "";
			this.c1b911ad5605ab77ce05e1d7e1086a822 = "";
			this.ca17a516b9b83e0dfad9d2112386e4814 = DateAndTime.Now;
			DateTime now = DateAndTime.Now;
			this.cf0b147587c14244dcf4d9ab0e658d23d = now;
			this.cf4cd9b8a6628f753f04e3d959a0b426a = false;
			this.c947760290b097be31505d13bc8be6093 = new decimal();
			this.c1c8374bfc1f5371de5c1fcf0d6371ef2 = "";
			this.c1537fb41f79ffb612838eb1aa724800c = 1;
			this.c812666379ed7993cb3f6c7184d4648fa = "";
			this.c7311c3f0c89b42a192e978a3e92e1763 = "";
			this.c8af649bd75d08c2b6fc2197ee8b18ca9 = "";
			this.c828c0c29272255ded1af2484474bcc7a = "";
			this.c1cd14941a8728ac4e15df8b0a0e28829 = "";
			this.c11959c32d6fd23bc974d8a8e2b4b6e44 = "";
			this.ce9af970cd65ec65d196f2f6310beb966 = "";
			this.c24a8e3f58a8b7a1072621dbdf6aea72a = false;
			this.bAllowBackups = false;
			this.bAllowEMail = false;
			this.bAllowOverrides = false;
			this.bAllowVacationHolds = false;
			this.bCustomerReports = false;
			this.bEditEmployees = false;
			this.bEditPackages = false;
			this.bEditProducts = false;
			this.bEditGiftCertificate = false;
			this.bEditSetup = false;
			this.bEditCustomerSessions = false;
			this.bDeleteCustomers = false;
			this.bEditSuppliers = false;
			this.bEditCategories = false;
			this.bEditEquipment = false;
			this.bOpenDrawer = false;
			this.bRefunds = false;
			this.bSalesReports = false;
			this.bTransferSessions = false;
			this.bUseSystemTools = false;
			this.c998455d60c898dd59a6618ea01b5828e = "";
			this.c2e1dfb57e3450c98aa181f256eff6887 = "";
			this.c1ec9576e9f28ac5d8e13712943b33adf = false;
		}

		public int dbGetEmployeeIDByEmpNumber(string EmpNumber)
		{
			// 
			// Current member / type: System.Int32 TimerObjects.Employee::dbGetEmployeeIDByEmpNumber(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 dbGetEmployeeIDByEmpNumber(System.String)
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

		public string dbGetEmployeeNameByEmpNumber(string EmpNum)
		{
			// 
			// Current member / type: System.String TimerObjects.Employee::dbGetEmployeeNameByEmpNumber(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String dbGetEmployeeNameByEmpNumber(System.String)
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

		public DataSet dbLoadEmployeeByEmpID(string empID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x234e);
			SqlParameter[] sqlParameter = new SqlParameter[1];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2379);
			sqlParameter[0] = new SqlParameter(str1, empID);
			DataSet dataSet = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, str, sqlParameter);
			return dataSet;
		}

		public DataSet dbLoadEmployeeById(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x23c4);
			SqlParameter[] sqlParameter = new SqlParameter[1];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2379);
			sqlParameter[0] = new SqlParameter(str1, (object)ID);
			DataSet dataSet = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, str, sqlParameter);
			return dataSet;
		}

		public string dbLoadEmployeeNameByID(string ID, string pwd, bool IsPwdVisible, string empid, int loc_num)
		{
			// 
			// Current member / type: System.String TimerObjects.Employee::dbLoadEmployeeNameByID(System.String,System.String,System.Boolean,System.String,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String dbLoadEmployeeNameByID(System.String,System.String,System.Boolean,System.String,System.Int32)
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

		public string Get_EmployeeByID(string empnum, string pwd, bool IsPwdVisible, int locnum)
		{
			string str;
			try
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				string str1 = dbLocation.Crypt.EncryptStringENC(empnum);
				Crypt2 crypt = dbLocation.Crypt;
				str = this.dbLoadEmployeeNameByID(str1, crypt.EncryptStringENC(pwd), IsPwdVisible, empnum, locnum);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = exception.ToString();
				Interaction.MsgBox(str2, MsgBoxStyle.OkOnly, null);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public int GetEmployeeID(string FName, string LName, string SSN)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2380);
			SqlParameter[] sqlParameter = new SqlParameter[3];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x23a1);
			sqlParameter[0] = new SqlParameter(str1, FName);
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x23ae), LName);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x23bb);
			sqlParameter[2] = new SqlParameter(str2, SSN);
			DataSet dataSet1 = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, str, sqlParameter);
			DataTableCollection tables = dataSet1.Tables;
			DataTable item = tables[0];
			DataRowCollection rows = item.Rows;
			DataRow dataRow = rows[0];
			int integer = Conversions.ToInteger(dataRow[0]);
			return integer;
		}

		public int GetEmployeeIDByEmpNumber(string empnum)
		{
			int num;
			try
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				Crypt2 crypt = dbLocation.Crypt;
				string str = crypt.EncryptStringENC(empnum);
				int num1 = this.dbGetEmployeeIDByEmpNumber(str);
				num = num1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public string GetEmployeeNameByEmpNumber(string empNum)
		{
			string str;
			try
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				Crypt2 crypt = dbLocation.Crypt;
				string str1 = crypt.EncryptStringENC(empNum);
				str = this.dbGetEmployeeNameByEmpNumber(str1);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public void LoadEmployeeByEmpID(string employeeid)
		{
			// 
			// Current member / type: System.Void TimerObjects.Employee::LoadEmployeeByEmpID(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void LoadEmployeeByEmpID(System.String)
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

		public void LoadEmployeeByID(int employeeid)
		{
			try
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				DataSet dataSet = this.dbLoadEmployeeById(employeeid);
				this.ds = dataSet;
				this.ID = employeeid;
				DataSet dataSet1 = this.ds;
				DataTableCollection tables = dataSet1.Tables;
				DataRowCollection rows = tables[0].Rows;
				DataRow item = rows[0];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1c86);
				object obj = item[str];
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				object obj1 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue);
				string str1 = Conversions.ToString(obj1);
				this.Notes = str1;
				Crypt2 crypt = dbLocation.Crypt;
				DataSet dataSet2 = this.ds;
				DataTableCollection dataTableCollection = dataSet2.Tables;
				DataTable dataTable = dataTableCollection[0];
				DataRowCollection dataRowCollection = dataTable.Rows;
				DataRow dataRow = dataRowCollection[0];
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1c91);
				object item1 = dataRow[str2];
				string str3 = Conversions.ToString(item1);
				string str4 = crypt.DecryptStringENC(str3);
				object obj2 = this.c1b95a3e96f0a5466604b2e0304bd2b04(str4);
				string str5 = Conversions.ToString(obj2);
				this.SSN = str5;
				Crypt2 crypt2 = dbLocation.Crypt;
				DataSet dataSet3 = this.ds;
				DataTableCollection tables1 = dataSet3.Tables;
				DataTable dataTable1 = tables1[0];
				DataRow dataRow1 = dataTable1.Rows[0];
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1c98);
				object item2 = dataRow1[str6];
				string str7 = Conversions.ToString(item2);
				string str8 = crypt2.DecryptStringENC(str7);
				object obj3 = this.c1b95a3e96f0a5466604b2e0304bd2b04(str8);
				string str9 = Conversions.ToString(obj3);
				this.Employee_Number = str9;
				DataSet dataSet4 = this.ds;
				DataTableCollection dataTableCollection1 = dataSet4.Tables;
				DataTable dataTable2 = dataTableCollection1[0];
				DataRowCollection rows1 = dataTable2.Rows;
				DataRow dataRow2 = rows1[0];
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1cb7);
				object item3 = dataRow2[str10];
				object objectValue1 = RuntimeHelpers.GetObjectValue(item3);
				object obj4 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue1);
				int integer = Conversions.ToInteger(obj4);
				this.Home_Store_Number = integer;
				DataTableCollection tables2 = this.ds.Tables;
				DataTable dataTable3 = tables2[0];
				DataRowCollection dataRowCollection1 = dataTable3.Rows;
				DataRow dataRow3 = dataRowCollection1[0];
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1cda);
				object obj5 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(dataRow3[str11]));
				string str12 = Conversions.ToString(obj5);
				this.FirstName = str12;
				DataSet dataSet5 = this.ds;
				DataTableCollection dataTableCollection2 = dataSet5.Tables;
				DataTable item4 = dataTableCollection2[0];
				DataRowCollection rows2 = item4.Rows;
				DataRow dataRow4 = rows2[0];
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1cef);
				object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow4[str13]);
				object obj6 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue2);
				string str14 = Conversions.ToString(obj6);
				this.MiddleName = str14;
				DataTableCollection tables3 = this.ds.Tables;
				DataTable dataTable4 = tables3[0];
				DataRow item5 = dataTable4.Rows[0];
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d0c);
				object item6 = item5[str15];
				object objectValue3 = RuntimeHelpers.GetObjectValue(item6);
				object obj7 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue3);
				string str16 = Conversions.ToString(obj7);
				this.LastName = str16;
				DataSet dataSet6 = this.ds;
				DataTableCollection dataTableCollection3 = dataSet6.Tables;
				DataRowCollection dataRowCollection2 = dataTableCollection3[0].Rows;
				DataRow dataRow5 = dataRowCollection2[0];
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d1f);
				object item7 = dataRow5[str17];
				object objectValue4 = RuntimeHelpers.GetObjectValue(item7);
				object obj8 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue4);
				string str18 = Conversions.ToString(obj8);
				this.Title = str18;
				DataSet dataSet7 = this.ds;
				DataTableCollection tables4 = dataSet7.Tables;
				DataTable dataTable5 = tables4[0];
				DataRowCollection rows3 = dataTable5.Rows;
				object objectValue5 = RuntimeHelpers.GetObjectValue(rows3[0][c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d2a)]);
				object obj9 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue5);
				string str19 = Conversions.ToString(obj9);
				this.Email = str19;
				DataSet dataSet8 = this.ds;
				DataTableCollection dataTableCollection4 = dataSet8.Tables;
				DataTable dataTable6 = dataTableCollection4[0];
				DataRowCollection dataRowCollection3 = dataTable6.Rows;
				DataRow dataRow6 = dataRowCollection3[0];
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d3f);
				object item8 = dataRow6[str20];
				string str21 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item8)));
				this.Extension = str21;
				DataSet dataSet9 = this.ds;
				DataTableCollection tables5 = dataSet9.Tables;
				DataTable dataTable7 = tables5[0];
				DataRowCollection rows4 = dataTable7.Rows;
				DataRow dataRow7 = rows4[0];
				object item9 = dataRow7[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d52)];
				object objectValue6 = RuntimeHelpers.GetObjectValue(item9);
				string str22 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue6));
				this.Address = str22;
				DataSet dataSet10 = this.ds;
				DataTableCollection dataTableCollection5 = dataSet10.Tables;
				DataTable dataTable8 = dataTableCollection5[0];
				DataRowCollection dataRowCollection4 = dataTable8.Rows;
				DataRow dataRow8 = dataRowCollection4[0];
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d61);
				object item10 = dataRow8[str23];
				object objectValue7 = RuntimeHelpers.GetObjectValue(item10);
				object obj10 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue7);
				this.City = Conversions.ToString(obj10);
				DataTable dataTable9 = this.ds.Tables[0];
				DataRow dataRow9 = dataTable9.Rows[0];
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d6a);
				object item11 = dataRow9[str24];
				object obj11 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item11));
				string str25 = Conversions.ToString(obj11);
				this.State = str25;
				DataSet dataSet11 = this.ds;
				DataTable dataTable10 = dataSet11.Tables[0];
				DataRowCollection rows5 = dataTable10.Rows;
				DataRow dataRow10 = rows5[0];
				string str26 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d75);
				object item12 = dataRow10[str26];
				object objectValue8 = RuntimeHelpers.GetObjectValue(item12);
				object obj12 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue8);
				string str27 = Conversions.ToString(obj12);
				this.County = str27;
				DataSet dataSet12 = this.ds;
				DataTable dataTable11 = dataSet12.Tables[0];
				DataRowCollection dataRowCollection5 = dataTable11.Rows;
				DataRow dataRow11 = dataRowCollection5[0];
				string str28 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d82);
				object item13 = dataRow11[str28];
				object obj13 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item13));
				this.Zip = Conversions.ToString(obj13);
				DataTable dataTable12 = this.ds.Tables[0];
				DataRowCollection rows6 = dataTable12.Rows;
				DataRow dataRow12 = rows6[0];
				string str29 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d89);
				object item14 = dataRow12[str29];
				object obj14 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item14));
				this.Country = Conversions.ToString(obj14);
				DataSet dataSet13 = this.ds;
				DataTableCollection tables6 = dataSet13.Tables;
				DataTable dataTable13 = tables6[0];
				DataRow dataRow13 = dataTable13.Rows[0];
				string str30 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d98);
				object item15 = dataRow13[str30];
				object objectValue9 = RuntimeHelpers.GetObjectValue(item15);
				string str31 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue9));
				this.HomePhone = str31;
				DataSet dataSet14 = this.ds;
				DataTableCollection dataTableCollection6 = dataSet14.Tables;
				DataTable dataTable14 = dataTableCollection6[0];
				DataRowCollection dataRowCollection6 = dataTable14.Rows;
				DataRow dataRow14 = dataRowCollection6[0];
				string str32 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1dad);
				object obj15 = dataRow14[str32];
				object obj16 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(obj15));
				object objectValue10 = RuntimeHelpers.GetObjectValue(obj16);
				this.vPicture = objectValue10;
				DataSet dataSet15 = this.ds;
				DataTableCollection tables7 = dataSet15.Tables;
				DataTable dataTable15 = tables7[0];
				DataRowCollection rows7 = dataTable15.Rows;
				DataRow dataRow15 = rows7[0];
				object item16 = dataRow15[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1dc2)];
				object objectValue11 = RuntimeHelpers.GetObjectValue(item16);
				object obj17 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue11);
				DateTime date = Conversions.ToDate(obj17);
				this.HireDate = date;
				DataSet dataSet16 = this.ds;
				DataTableCollection dataTableCollection7 = dataSet16.Tables;
				DataTable dataTable16 = dataTableCollection7[0];
				DataRowCollection dataRowCollection7 = dataTable16.Rows;
				DataRow dataRow16 = dataRowCollection7[0];
				string str33 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1dcf);
				object objectValue12 = RuntimeHelpers.GetObjectValue(dataRow16[str33]);
				object obj18 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue12);
				this.BirthDate = Conversions.ToDate(obj18);
				DataSet dataSet17 = this.ds;
				DataTable item17 = dataSet17.Tables[0];
				DataRowCollection rows8 = item17.Rows;
				DataRow dataRow17 = rows8[0];
				object item18 = dataRow17[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1dde)];
				object objectValue13 = RuntimeHelpers.GetObjectValue(item18);
				object obj19 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue13);
				decimal num = Conversions.ToDecimal(obj19);
				this.Wage_Hourly = num;
				DataSet dataSet18 = this.ds;
				DataTableCollection tables8 = dataSet18.Tables;
				DataTable dataTable17 = tables8[0];
				DataRowCollection dataRowCollection8 = dataTable17.Rows;
				DataRow dataRow18 = dataRowCollection8[0];
				string str34 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1df5);
				object objectValue14 = RuntimeHelpers.GetObjectValue(dataRow18[str34]);
				object obj20 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue14);
				bool flag = Conversions.ToBoolean(obj20);
				this.bHourly = flag;
				DataSet dataSet19 = this.ds;
				DataTableCollection dataTableCollection8 = dataSet19.Tables;
				DataRow item19 = dataTableCollection8[0].Rows[0];
				object item20 = item19[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e02)];
				object obj21 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item20));
				DateTime dateTime = Conversions.ToDate(obj21);
				this.LastReviewDate = dateTime;
				DataSet dataSet20 = this.ds;
				DataTableCollection tables9 = dataSet20.Tables;
				DataRowCollection rows9 = tables9[0].Rows;
				DataRow dataRow19 = rows9[0];
				string str35 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e1d);
				object item21 = dataRow19[str35];
				object objectValue15 = RuntimeHelpers.GetObjectValue(item21);
				object obj22 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue15);
				bool flag1 = Conversions.ToBoolean(obj22);
				this.bRehire = flag1;
				DataSet dataSet21 = this.ds;
				DataTableCollection dataTableCollection9 = dataSet21.Tables;
				DataTable dataTable18 = dataTableCollection9[0];
				DataRow dataRow20 = dataTable18.Rows[0];
				string str36 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e2a);
				object objectValue16 = RuntimeHelpers.GetObjectValue(dataRow20[str36]);
				object obj23 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue16);
				DateTime date1 = Conversions.ToDate(obj23);
				this.TerminationDate = date1;
				DataSet dataSet22 = this.ds;
				DataTableCollection tables10 = dataSet22.Tables;
				DataTable dataTable19 = tables10[0];
				DataRow dataRow21 = dataTable19.Rows[0];
				string str37 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e45);
				object item22 = dataRow21[str37];
				object objectValue17 = RuntimeHelpers.GetObjectValue(item22);
				object obj24 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue17);
				this.dProductCommission = Conversions.ToDouble(obj24);
				DataTableCollection dataTableCollection10 = this.ds.Tables;
				DataTable dataTable20 = dataTableCollection10[0];
				DataRowCollection dataRowCollection9 = dataTable20.Rows;
				DataRow dataRow22 = dataRowCollection9[0];
				string str38 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e6a);
				object item23 = dataRow22[str38];
				object obj25 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item23));
				double num1 = Conversions.ToDouble(obj25);
				this.dPackageCommission = num1;
				DataSet dataSet23 = this.ds;
				DataTable dataTable21 = dataSet23.Tables[0];
				DataRow dataRow23 = dataTable21.Rows[0];
				string str39 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e8f);
				object item24 = dataRow23[str39];
				object objectValue18 = RuntimeHelpers.GetObjectValue(item24);
				object obj26 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue18);
				string str40 = Conversions.ToString(obj26);
				this.ECName = str40;
				DataSet dataSet24 = this.ds;
				DataTableCollection tables11 = dataSet24.Tables;
				DataTable dataTable22 = tables11[0];
				DataRowCollection rows10 = dataTable22.Rows;
				DataRow dataRow24 = rows10[0];
				string str41 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1ebc);
				object item25 = dataRow24[str41];
				object objectValue19 = RuntimeHelpers.GetObjectValue(item25);
				object obj27 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue19);
				string str42 = Conversions.ToString(obj27);
				this.ECPhone1 = str42;
				DataSet dataSet25 = this.ds;
				DataTableCollection dataTableCollection11 = dataSet25.Tables;
				DataRowCollection dataRowCollection10 = dataTableCollection11[0].Rows;
				DataRow dataRow25 = dataRowCollection10[0];
				string str43 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1eed);
				object item26 = dataRow25[str43];
				object objectValue20 = RuntimeHelpers.GetObjectValue(item26);
				object obj28 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue20);
				this.ECPhone2 = Conversions.ToString(obj28);
				DataSet dataSet26 = this.ds;
				DataTableCollection tables12 = dataSet26.Tables;
				DataRow dataRow26 = tables12[0].Rows[0];
				string str44 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f1e);
				object item27 = dataRow26[str44];
				object objectValue21 = RuntimeHelpers.GetObjectValue(item27);
				object obj29 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue21);
				this.ECRelation = Conversions.ToString(obj29);
				DataSet dataSet27 = this.ds;
				DataTableCollection dataTableCollection12 = dataSet27.Tables;
				DataTable dataTable23 = dataTableCollection12[0];
				DataRowCollection rows11 = dataTable23.Rows;
				DataRow dataRow27 = rows11[0];
				string str45 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f53);
				object objectValue22 = RuntimeHelpers.GetObjectValue(dataRow27[str45]);
				this.ECAddress = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue22));
				DataTableCollection tables13 = this.ds.Tables;
				DataTable dataTable24 = tables13[0];
				DataRow item28 = dataTable24.Rows[0];
				string str46 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item28[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f86)])));
				this.ECCity = str46;
				DataSet dataSet28 = this.ds;
				DataTable dataTable25 = dataSet28.Tables[0];
				DataRowCollection dataRowCollection11 = dataTable25.Rows;
				DataRow dataRow28 = dataRowCollection11[0];
				string str47 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1fb3);
				object item29 = dataRow28[str47];
				object objectValue23 = RuntimeHelpers.GetObjectValue(item29);
				object obj30 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue23);
				this.ECState = Conversions.ToString(obj30);
				DataSet dataSet29 = this.ds;
				DataTableCollection dataTableCollection13 = dataSet29.Tables;
				DataTable dataTable26 = dataTableCollection13[0];
				DataRowCollection rows12 = dataTable26.Rows;
				DataRow dataRow29 = rows12[0];
				string str48 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1fe2);
				object objectValue24 = RuntimeHelpers.GetObjectValue(dataRow29[str48]);
				string str49 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue24));
				this.ECZip = str49;
				DataTableCollection tables14 = this.ds.Tables;
				DataTable dataTable27 = tables14[0];
				DataRowCollection dataRowCollection12 = dataTable27.Rows;
				DataRow item30 = dataRowCollection12[0];
				string str50 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x200d);
				object item31 = item30[str50];
				object obj31 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item31));
				bool flag2 = Conversions.ToBoolean(obj31);
				this.bEditEmployees = flag2;
				DataSet dataSet30 = this.ds;
				DataTable dataTable28 = dataSet30.Tables[0];
				DataRow dataRow30 = dataTable28.Rows[0];
				string str51 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x202c);
				object item32 = dataRow30[str51];
				object objectValue25 = RuntimeHelpers.GetObjectValue(item32);
				object obj32 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue25);
				bool flag3 = Conversions.ToBoolean(obj32);
				this.bEditProducts = flag3;
				DataSet dataSet31 = this.ds;
				DataTableCollection dataTableCollection14 = dataSet31.Tables;
				DataTable dataTable29 = dataTableCollection14[0];
				DataRowCollection rows13 = dataTable29.Rows;
				DataRow dataRow31 = rows13[0];
				string str52 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2049);
				object item33 = dataRow31[str52];
				object obj33 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item33));
				bool flag4 = Conversions.ToBoolean(obj33);
				this.bEditPackages = flag4;
				DataSet dataSet32 = this.ds;
				DataTableCollection tables15 = dataSet32.Tables;
				DataTable dataTable30 = tables15[0];
				DataRow dataRow32 = dataTable30.Rows[0];
				string str53 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2066);
				object item34 = dataRow32[str53];
				object objectValue26 = RuntimeHelpers.GetObjectValue(item34);
				bool flag5 = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue26));
				this.bEditSetup = flag5;
				Crypt2 crypt1 = dbLocation.Crypt;
				DataSet dataSet33 = this.ds;
				DataTableCollection dataTableCollection15 = dataSet33.Tables;
				DataRow dataRow33 = dataTableCollection15[0].Rows[0];
				string str54 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x207d);
				object obj34 = dataRow33[str54];
				string str55 = Conversions.ToString(obj34);
				string str56 = crypt1.DecryptStringENC(str55);
				object obj35 = this.c1b95a3e96f0a5466604b2e0304bd2b04(str56);
				string str57 = Conversions.ToString(obj35);
				this.strPassword = str57;
				DataSet dataSet34 = this.ds;
				DataTableCollection tables16 = dataSet34.Tables;
				DataTable dataTable31 = tables16[0];
				DataRowCollection dataRowCollection13 = dataTable31.Rows;
				DataRow dataRow34 = dataRowCollection13[0];
				string str58 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x208e);
				object item35 = dataRow34[str58];
				object objectValue27 = RuntimeHelpers.GetObjectValue(item35);
				object obj36 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue27);
				bool flag6 = Conversions.ToBoolean(obj36);
				this.bDeleteCustomers = flag6;
				DataSet dataSet35 = this.ds;
				DataTableCollection dataTableCollection16 = dataSet35.Tables;
				DataTable dataTable32 = dataTableCollection16[0];
				DataRowCollection rows14 = dataTable32.Rows;
				DataRow dataRow35 = rows14[0];
				string str59 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x20b1);
				object item36 = dataRow35[str59];
				object objectValue28 = RuntimeHelpers.GetObjectValue(item36);
				object obj37 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue28);
				this.bEditCustomerSessions = Conversions.ToBoolean(obj37);
				DataSet dataSet36 = this.ds;
				DataTableCollection tables17 = dataSet36.Tables;
				DataTable dataTable33 = tables17[0];
				DataRowCollection dataRowCollection14 = dataTable33.Rows;
				DataRow dataRow36 = dataRowCollection14[0];
				string str60 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x20e0);
				object item37 = dataRow36[str60];
				object obj38 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item37));
				bool flag7 = Conversions.ToBoolean(obj38);
				this.bEditSuppliers = flag7;
				DataSet dataSet37 = this.ds;
				DataTable dataTable34 = dataSet37.Tables[0];
				DataRow dataRow37 = dataTable34.Rows[0];
				string str61 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x20ff);
				object item38 = dataRow37[str61];
				bool flag8 = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item38)));
				this.bCustomerReports = flag8;
				DataTableCollection dataTableCollection17 = this.ds.Tables;
				DataTable dataTable35 = dataTableCollection17[0];
				DataRowCollection rows15 = dataTable35.Rows;
				DataRow dataRow38 = rows15[0];
				string str62 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2122);
				object item39 = dataRow38[str62];
				bool flag9 = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item39)));
				this.bSalesReports = flag9;
				DataSet dataSet38 = this.ds;
				DataTableCollection tables18 = dataSet38.Tables;
				DataRowCollection dataRowCollection15 = tables18[0].Rows;
				DataRow dataRow39 = dataRowCollection15[0];
				object objectValue29 = RuntimeHelpers.GetObjectValue(dataRow39[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x213f)]);
				object obj39 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue29);
				bool flag10 = Conversions.ToBoolean(obj39);
				this.bOpenDrawer = flag10;
				DataSet dataSet39 = this.ds;
				DataTable dataTable36 = dataSet39.Tables[0];
				DataRowCollection rows16 = dataTable36.Rows;
				DataRow item40 = rows16[0];
				string str63 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2158);
				object obj40 = item40[str63];
				object obj41 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(obj40));
				bool flag11 = Conversions.ToBoolean(obj41);
				this.bRefunds = flag11;
				DataSet dataSet40 = this.ds;
				DataTableCollection dataTableCollection18 = dataSet40.Tables;
				DataTable dataTable37 = dataTableCollection18[0];
				DataRow dataRow40 = dataTable37.Rows[0];
				string str64 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2169);
				object objectValue30 = RuntimeHelpers.GetObjectValue(dataRow40[str64]);
				object obj42 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue30);
				bool flag12 = Conversions.ToBoolean(obj42);
				this.bEditGiftCertificate = flag12;
				DataTableCollection tables19 = this.ds.Tables;
				DataRowCollection dataRowCollection16 = tables19[0].Rows;
				DataRow item41 = dataRowCollection16[0];
				string str65 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2188);
				object item42 = item41[str65];
				object objectValue31 = RuntimeHelpers.GetObjectValue(item42);
				object obj43 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue31);
				bool flag13 = Conversions.ToBoolean(obj43);
				this.bUseSystemTools = flag13;
				DataSet dataSet41 = this.ds;
				DataTableCollection dataTableCollection19 = dataSet41.Tables;
				DataTable dataTable38 = dataTableCollection19[0];
				DataRow dataRow41 = dataTable38.Rows[0];
				string str66 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21ab);
				object item43 = dataRow41[str66];
				object objectValue32 = RuntimeHelpers.GetObjectValue(item43);
				string str67 = Conversions.ToString(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue32));
				this.QBEmpName = str67;
				DataTableCollection tables20 = this.ds.Tables;
				DataTable dataTable39 = tables20[0];
				DataRowCollection rows17 = dataTable39.Rows;
				DataRow dataRow42 = rows17[0];
				string str68 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21c0);
				object item44 = dataRow42[str68];
				object objectValue33 = RuntimeHelpers.GetObjectValue(item44);
				object obj44 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue33);
				bool flag14 = Conversions.ToBoolean(obj44);
				this.bTerminated = flag14;
				DataRowCollection dataRowCollection17 = this.ds.Tables[0].Rows;
				object objectValue34 = RuntimeHelpers.GetObjectValue(dataRowCollection17[0][c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21d7)]);
				object obj45 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue34);
				this.bTransferSessions = Conversions.ToBoolean(obj45);
				DataSet dataSet42 = this.ds;
				DataTable dataTable40 = dataSet42.Tables[0];
				DataRowCollection rows18 = dataTable40.Rows;
				DataRow dataRow43 = rows18[0];
				string str69 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21fa);
				object item45 = dataRow43[str69];
				object objectValue35 = RuntimeHelpers.GetObjectValue(item45);
				object obj46 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue35);
				bool flag15 = Conversions.ToBoolean(obj46);
				this.bAllowOverrides = flag15;
				DataSet dataSet43 = this.ds;
				DataTable dataTable41 = dataSet43.Tables[0];
				DataRowCollection dataRowCollection18 = dataTable41.Rows;
				DataRow dataRow44 = dataRowCollection18[0];
				object obj47 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(dataRow44[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x221b)]));
				bool flag16 = Conversions.ToBoolean(obj47);
				this.bAllowVacationHolds = flag16;
				DataTableCollection dataTableCollection20 = this.ds.Tables;
				DataTable dataTable42 = dataTableCollection20[0];
				DataRow dataRow45 = dataTable42.Rows[0];
				string str70 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2246);
				object item46 = dataRow45[str70];
				object objectValue36 = RuntimeHelpers.GetObjectValue(item46);
				bool flag17 = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue36));
				this.bEditBed = flag17;
				DataTable dataTable43 = this.ds.Tables[0];
				DataRow dataRow46 = dataTable43.Rows[0];
				string str71 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x225b);
				object item47 = dataRow46[str71];
				object obj48 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item47));
				this.bEditCategories = Conversions.ToBoolean(obj48);
				DataSet dataSet44 = this.ds;
				DataRowCollection rows19 = dataSet44.Tables[0].Rows;
				DataRow dataRow47 = rows19[0];
				string str72 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x227c);
				object item48 = dataRow47[str72];
				object objectValue37 = RuntimeHelpers.GetObjectValue(item48);
				object obj49 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue37);
				bool flag18 = Conversions.ToBoolean(obj49);
				this.bAllowBackups = flag18;
				DataSet dataSet45 = this.ds;
				DataTable dataTable44 = dataSet45.Tables[0];
				DataRowCollection dataRowCollection19 = dataTable44.Rows;
				DataRow dataRow48 = dataRowCollection19[0];
				object item49 = dataRow48[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2299)];
				object objectValue38 = RuntimeHelpers.GetObjectValue(item49);
				this.bAllowEMail = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue38));
				DataSet dataSet46 = this.ds;
				DataTable dataTable45 = dataSet46.Tables[0];
				DataRowCollection rows20 = dataTable45.Rows;
				DataRow dataRow49 = rows20[0];
				string str73 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x22b2);
				object objectValue39 = RuntimeHelpers.GetObjectValue(dataRow49[str73]);
				this.Picture = (byte[])this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue39);
				DataRow item50 = this.ds.Tables[0].Rows[0];
				string str74 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x22c1);
				object objectValue40 = RuntimeHelpers.GetObjectValue(item50[str74]);
				object obj50 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue40);
				bool flag19 = Conversions.ToBoolean(obj50);
				this.bEditService = flag19;
				DataTableCollection tables21 = this.ds.Tables;
				DataTable dataTable46 = tables21[0];
				DataRow dataRow50 = dataTable46.Rows[0];
				object item51 = dataRow50[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x22de)];
				object obj51 = this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item51));
				this.FingerImage = (byte[])obj51;
				DataTableCollection dataTableCollection21 = this.ds.Tables;
				DataTable dataTable47 = dataTableCollection21[0];
				DataRowCollection dataRowCollection20 = dataTable47.Rows;
				DataRow dataRow51 = dataRowCollection20[0];
				object item52 = dataRow51[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x22f7)];
				bool flag20 = Conversions.ToBoolean(this.c1b95a3e96f0a5466604b2e0304bd2b04(RuntimeHelpers.GetObjectValue(item52)));
				this.bCancelEFT = flag20;
				DataSet dataSet47 = this.ds;
				DataTableCollection tables22 = dataSet47.Tables;
				DataRow dataRow52 = tables22[0].Rows[0];
				string str75 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x230e);
				object obj52 = dataRow52[str75];
				object objectValue41 = RuntimeHelpers.GetObjectValue(obj52);
				object obj53 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue41);
				bool flag21 = Conversions.ToBoolean(obj53);
				this.bEdit_Client_package = flag21;
				DataSet dataSet48 = this.ds;
				DataTableCollection dataTableCollection22 = dataSet48.Tables;
				DataTable dataTable48 = dataTableCollection22[0];
				DataRowCollection rows21 = dataTable48.Rows;
				DataRow item53 = rows21[0];
				string str76 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2337);
				object item54 = item53[str76];
				object objectValue42 = RuntimeHelpers.GetObjectValue(item54);
				object obj54 = this.c1b95a3e96f0a5466604b2e0304bd2b04(objectValue42);
				bool flag22 = Conversions.ToBoolean(obj54);
				this.bTimer_Queue = flag22;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}
	}
}