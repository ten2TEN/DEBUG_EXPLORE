using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedClient_Referrals___by_Date_Client_Screen___Referral_Tab : Component, ICachedReport
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

		public CachedClient_Referrals___by_Date_Client_Screen___Referral_Tab()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Client_Referrals___by_Date_Client_Screen___Referral_Tab clientReferrals_ByDateClientScreen_ReferralTab = new Client_Referrals___by_Date_Client_Screen___Referral_Tab();
			ISite site = this.Site;
			clientReferrals_ByDateClientScreen_ReferralTab.set_Site(site);
			return clientReferrals_ByDateClientScreen_ReferralTab;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}