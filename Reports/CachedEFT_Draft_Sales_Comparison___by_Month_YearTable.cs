using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedEFT_Draft_Sales_Comparison___by_Month_YearTable : Component, ICachedReport
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

		public CachedEFT_Draft_Sales_Comparison___by_Month_YearTable()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			EFT_Draft_Sales_Comparison___by_Month_YearTable eFTDraftSalesComparison_ByMonthYearTable = new EFT_Draft_Sales_Comparison___by_Month_YearTable();
			ISite site = this.Site;
			eFTDraftSalesComparison_ByMonthYearTable.set_Site(site);
			return eFTDraftSalesComparison_ByMonthYearTable;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}