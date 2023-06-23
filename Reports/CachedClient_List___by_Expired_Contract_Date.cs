using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedClient_List___by_Expired_Contract_Date : Component, ICachedReport
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

		public CachedClient_List___by_Expired_Contract_Date()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Client_List___by_Expired_Contract_Date clientList_ByExpiredContractDate = new Client_List___by_Expired_Contract_Date();
			ISite site = this.Site;
			clientList_ByExpiredContractDate.set_Site(site);
			return clientList_ByExpiredContractDate;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}