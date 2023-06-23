using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedGift_Card_Reciprocal_Transaction_Details___by_DateReceive : Component, ICachedReport
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

		public CachedGift_Card_Reciprocal_Transaction_Details___by_DateReceive()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Gift_Card_Reciprocal_Transaction_Details___by_DateReceive giftCardReciprocalTransactionDetails_ByDateReceive = new Gift_Card_Reciprocal_Transaction_Details___by_DateReceive();
			ISite site = this.Site;
			giftCardReciprocalTransactionDetails_ByDateReceive.set_Site(site);
			return giftCardReciprocalTransactionDetails_ByDateReceive;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}