using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Reports
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedInventory_Level___by_Manufacturer : Component, ICachedReport
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

		public CachedInventory_Level___by_Manufacturer()
		{
		}

		public virtual ReportDocument CreateReport()
		{
			Inventory_Level___by_Manufacturer inventoryLevel_ByManufacturer = new Inventory_Level___by_Manufacturer();
			ISite site = this.Site;
			inventoryLevel_ByManufacturer.set_Site(site);
			return inventoryLevel_ByManufacturer;
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}