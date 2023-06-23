using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedEFT_Draft_Sales_Count_Comparison___by_MonthTable : Component, ICachedReport
	{
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual TimeSpan CacheTimeOut
		{
			get
			{
				return CachedReportConstants.DEFAULT_TIMEOUT;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool IsCacheable
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool ShareDBLogonInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CachedEFT_Draft_Sales_Count_Comparison___by_MonthTable()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			EFT_Draft_Sales_Count_Comparison___by_MonthTable eFTDraftSalesCountComparison_ByMonthTable = new EFT_Draft_Sales_Count_Comparison___by_MonthTable();
			ISite site = this.Site;
			eFTDraftSalesCountComparison_ByMonthTable.set_Site(site);
			return eFTDraftSalesCountComparison_ByMonthTable;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}