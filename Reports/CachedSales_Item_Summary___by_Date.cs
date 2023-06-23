using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSales_Item_Summary___by_Date : Component, ICachedReport
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

		public CachedSales_Item_Summary___by_Date()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Sales_Item_Summary___by_Date salesItemSummary_ByDate = new Sales_Item_Summary___by_Date();
			ISite site = this.Site;
			salesItemSummary_ByDate.set_Site(site);
			return salesItemSummary_ByDate;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}