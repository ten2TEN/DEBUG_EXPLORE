using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedProduct_Screen_Security_Log___by_Date : Component, ICachedReport
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

		public CachedProduct_Screen_Security_Log___by_Date()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Product_Screen_Security_Log___by_Date productScreenSecurityLog_ByDate = new Product_Screen_Security_Log___by_Date();
			ISite site = this.Site;
			productScreenSecurityLog_ByDate.set_Site(site);
			return productScreenSecurityLog_ByDate;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}