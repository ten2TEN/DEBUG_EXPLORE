using A;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Reports
{
	public class Product_Sales_Comparison___by_Month_YearTable : ReportClass
	{
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				return sections.get_Item(2);
			}
		}

		public override string FullResourceName
		{
			get
			{
				return c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fd4);
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
				return sections.get_Item(4);
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				Sections sections = this.get_ReportDefinition().get_Sections();
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
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinition item = dataDefinition.get_ParameterFields().get_Item(0);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Store_Number
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(1);
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
				Section item = reportDefinition.get_Sections().get_Item(3);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				return sections.get_Item(0);
			}
		}

		public override string ResourceName
		{
			get
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f6d);
				return str;
			}
			set
			{
			}
		}

		public Product_Sales_Comparison___by_Month_YearTable()
		{
		}
	}
}