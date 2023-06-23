using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class Coupon
	{
		private DataSet cbc00bd297d89482e15fb79c85b891623;

		public decimal Amount
		{
			get;
			set;
		}

		public bool bActive
		{
			get;
			set;
		}

		public bool bAllowExceedOfPrice
		{
			get;
			set;
		}

		public bool bValidOnSalePrice
		{
			get;
			set;
		}

		public decimal Cost
		{
			get;
			set;
		}

		public dbCoupon db
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public short Discount_Item_Type
		{
			get;
			set;
		}

		public short Discount_Type
		{
			get;
			set;
		}

		public DataSet dsCouponItems_ID
		{
			get;
			set;
		}

		public DateTime dtEnd
		{
			get;
			set;
		}

		public DateTime dtStart
		{
			get;
			set;
		}

		public int ID
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public int rowID
		{
			get;
			set;
		}

		public string SKU_Number
		{
			get;
			set;
		}

		public short Usage_Frequency
		{
			get;
			set;
		}

		public Coupon()
		{
			this.db = new dbCoupon();
		}

		private void cd1e6945d4647aca115cb5194b20eb790()
		{
			// 
			// Current member / type: System.Void TanTrackObjects.Coupon::cd1e6945d4647aca115cb5194b20eb790()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void cd1e6945d4647aca115cb5194b20eb790()
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

		public bool DeleteCoupon(int CouponID)
		{
			bool flag = this.db.DeleteCoupon(CouponID);
			return flag;
		}

		public bool DeleteCouponItems(int CouponID)
		{
			dbCoupon _dbCoupon = this.db;
			bool flag = _dbCoupon.DeleteCouponItems(CouponID);
			return flag;
		}

		public DataSet GetCouponItems(int CouponID)
		{
			dbCoupon _dbCoupon = this.db;
			DataSet couponItems = _dbCoupon.GetCouponItems(CouponID);
			return couponItems;
		}

		public DataSet GetCouponRedemtionHistory(int CouponID)
		{
			dbCoupon _dbCoupon = this.db;
			DataSet couponRedemtionHistory = _dbCoupon.GetCouponRedemtionHistory(CouponID);
			return couponRedemtionHistory;
		}

		public long GetLastCouponSKUNum()
		{
			dbCoupon _dbCoupon = this.db;
			return _dbCoupon.GetLastCouponSKUNum();
		}

		public bool IsCouponInUse(int CouponID)
		{
			dbCoupon _dbCoupon = this.db;
			bool flag = _dbCoupon.IsCouponInUse(CouponID);
			return flag;
		}

		public bool IsCouponUsedbyClient(int CouponID, int clientID)
		{
			dbCoupon _dbCoupon = this.db;
			bool flag = _dbCoupon.IsCouponUsedbyClient(CouponID, clientID);
			return flag;
		}

		public short IsSkuDuplicate(string SKU_Number)
		{
			dbCoupon _dbCoupon = this.db;
			short num = _dbCoupon.IsSkuDuplicate(SKU_Number);
			return num;
		}

		public DataSet LoadActiveCoupons(string Name = "", string Sku = "")
		{
			dbCoupon _dbCoupon = this.db;
			return _dbCoupon.LoadActiveCoupons(Name, Sku);
		}

		public DataSet LoadCouponsBYReqType(int CouponID, int RowID, short RecordType, string Name = "", string Sku = "")
		{
			// 
			// Current member / type: System.Data.DataSet TanTrackObjects.Coupon::LoadCouponsBYReqType(System.Int32,System.Int32,System.Int16,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadCouponsBYReqType(System.Int32,System.Int32,System.Int16,System.String,System.String)
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

		public DataSet PandSList(short ItemType = 0)
		{
			dbCoupon _dbCoupon = this.db;
			DataSet dataSet = _dbCoupon.PandSList(ItemType);
			return dataSet;
		}

		public int SaveCoupon(int ID, string Name, string Description, string SKU_Number, decimal Cost, decimal Amount, DateTime dtStart, DateTime dtEnd, short Usage_Frequency, short Discount_Type, short Discount_Item_Type, bool bValidOnSalePrice, bool bAllowExceedOfPrice, bool bActive)
		{
			dbCoupon _dbCoupon = this.db;
			int num = _dbCoupon.SaveCoupon(ID, Name, Description, SKU_Number, Cost, Amount, dtStart, dtEnd, Usage_Frequency, Discount_Type, Discount_Item_Type, bValidOnSalePrice, bAllowExceedOfPrice, bActive);
			return num;
		}

		public bool SaveCouponItems(int CouponID, int PandSID)
		{
			dbCoupon _dbCoupon = this.db;
			bool flag = _dbCoupon.SaveCouponItems(CouponID, PandSID);
			return flag;
		}
	}
}