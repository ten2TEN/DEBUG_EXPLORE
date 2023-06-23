using A;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Reports
{
	public class Inactive_Client_List___by_No_Package : ReportClass
	{
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Section item = reportDefinition.get_Sections().get_Item(2);
				return item;
			}
		}

		public override string FullResourceName
		{
			get
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3d86);
				return str;
			}
			set
			{
			}
		}

		public override bool NewGenerator
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
		public Section PageFooterSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				Section item = sections.get_Item(4);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				Section item = sections.get_Item(1);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Company_Name
		{
			get
			{
				ParameterFieldDefinition item = this.get_DataDefinition().get_ParameterFields().get_Item(0);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Language
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				return dataDefinition.get_ParameterFields().get_Item(1);
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Loc_Num
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinition item = dataDefinition.get_ParameterFields().get_Item(2);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				Section item = sections.get_Item(3);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				Sections sections = this.get_ReportDefinition().get_Sections();
				return sections.get_Item(0);
			}
		}

		public override string ResourceName
		{
			get
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3d35);
				return str;
			}
			set
			{
			}
		}

		public Inactive_Client_List___by_No_Package()
		{
		}
	}
}