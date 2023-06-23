using A;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Reports
{
	public class EFT_Declined_Payments : ReportClass
	{
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Section item = reportDefinition.get_Sections().get_Item(6);
				return item;
			}
		}

		public override string FullResourceName
		{
			get
			{
				return c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x26e4);
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupFooterSection1
		{
			get
			{
				Section item = this.get_ReportDefinition().get_Sections().get_Item(8);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupFooterSection2
		{
			get
			{
				Section item = this.get_ReportDefinition().get_Sections().get_Item(7);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection1
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				return sections.get_Item(2);
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection2
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
		public Section GroupHeaderSection4
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				Sections sections = reportDefinition.get_Sections();
				Section item = sections.get_Item(5);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection5
		{
			get
			{
				ReportDefinition reportDefinition = this.get_ReportDefinition();
				return reportDefinition.get_Sections().get_Item(4);
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
				Section item = sections.get_Item(10);
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
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(0);
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
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(2);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Store_Number
		{
			get
			{
				ParameterFieldDefinitions parameterFields = this.get_DataDefinition().get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(1);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Tax_1_Amount
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(3);
				return item;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Tax_2_Amount
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				return parameterFields.get_Item(4);
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_Tax_3_Amount
		{
			get
			{
				DataDefinition dataDefinition = this.get_DataDefinition();
				ParameterFieldDefinitions parameterFields = dataDefinition.get_ParameterFields();
				ParameterFieldDefinition item = parameterFields.get_Item(5);
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
				return reportDefinition.get_Sections().get_Item(9);
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
				Section item = sections.get_Item(0);
				return item;
			}
		}

		public override string ResourceName
		{
			get
			{
				return c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x26b1);
			}
			set
			{
			}
		}

		public EFT_Declined_Payments()
		{
		}
	}
}