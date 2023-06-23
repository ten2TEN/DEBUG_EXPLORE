using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedGift_Card_Reciprocal_Transaction_Details___by_DatePayout : Component, ICachedReport
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

		public CachedGift_Card_Reciprocal_Transaction_Details___by_DatePayout()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Gift_Card_Reciprocal_Transaction_Details___by_DatePayout giftCardReciprocalTransactionDetails_ByDatePayout = new Gift_Card_Reciprocal_Transaction_Details___by_DatePayout();
			ISite site = this.Site;
			giftCardReciprocalTransactionDetails_ByDatePayout.set_Site(site);
			return giftCardReciprocalTransactionDetails_ByDatePayout;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}