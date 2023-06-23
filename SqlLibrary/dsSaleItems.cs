using A;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SqlLibrary
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	[ToolboxItem(true)]
	[XmlRoot("dsSaleItems")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dsSaleItems : DataSet
	{
		private dsSaleItems.tblSaleDataDataTable tabletblSaleData;

		private dsSaleItems.tblCouponDataDataTable tabletblCouponData;

		private DataRelation relationtblSaleData_tblCouponData;

		private System.Data.SchemaSerializationMode _schemaSerializationMode;

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				DataRelationCollection relations = base.Relations;
				return relations;
			}
		}

		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override System.Data.SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				DataTableCollection tables = base.Tables;
				return tables;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsSaleItems.tblCouponDataDataTable tblCouponData
		{
			get
			{
				return this.tabletblCouponData;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsSaleItems.tblSaleDataDataTable tblSaleData
		{
			get
			{
				return this.tabletblSaleData;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsSaleItems()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			dsSaleItems dsSaleItem = this;
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(dsSaleItem.c70e3aced97d5cf7509794216755f6e5d);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			DataRelationCollection relations = base.Relations;
			relations.CollectionChanged += collectionChangeEventHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsSaleItems(SerializationInfo info, StreamingContext context)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsSaleItems::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void .ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void c70e3aced97d5cf7509794216755f6e5d(object cf7d8a347db4ec9aed6c0c9437e4edbb6, CollectionChangeEventArgs c38331f058065b55f8ef1950a745341e0)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsSaleItems::c70e3aced97d5cf7509794216755f6e5d(System.Object,System.ComponentModel.CollectionChangeEventArgs)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void c70e3aced97d5cf7509794216755f6e5d(System.Object,System.ComponentModel.CollectionChangeEventArgs)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool c9ebc290fb6ec7c4240be26cc16f69efb()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool cd7cd15df851a2f49b9c8164f4068166e()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void ce9285e807b6d3d13062294184142fedb()
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3739);
			this.DataSetName = str;
			this.Prefix = "";
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3750);
			this.Namespace = str1;
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tabletblSaleData = new dsSaleItems.tblSaleDataDataTable();
			DataTableCollection tables = base.Tables;
			tables.Add(this.tabletblSaleData);
			this.tabletblCouponData = new dsSaleItems.tblCouponDataDataTable();
			base.Tables.Add(this.tabletblCouponData);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3706);
			DataColumn[] rowIDColumn = new DataColumn[] { this.tabletblSaleData.RowIDColumn };
			DataColumn[] dataColumnArray = new DataColumn[] { this.tabletblCouponData.RowIDColumn };
			ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(str2, rowIDColumn, dataColumnArray);
			ConstraintCollection constraints = this.tabletblCouponData.Constraints;
			constraints.Add(foreignKeyConstraint);
			foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			foreignKeyConstraint.DeleteRule = Rule.Cascade;
			foreignKeyConstraint.UpdateRule = Rule.Cascade;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3706);
			dataColumnArray = new DataColumn[] { this.tabletblSaleData.RowIDColumn };
			rowIDColumn = new DataColumn[] { this.tabletblCouponData.RowIDColumn };
			this.relationtblSaleData_tblCouponData = new DataRelation(str3, dataColumnArray, rowIDColumn, false);
			this.Relations.Add(this.relationtblSaleData_tblCouponData);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void cfb93e8c2fa64f1123fa8988e476c2203()
		{
			this.cfb93e8c2fa64f1123fa8988e476c2203(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void cfb93e8c2fa64f1123fa8988e476c2203(bool cd470cdb9ec6f4c001d9b021df579c631)
		{
			DataTableCollection tables = base.Tables;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x36d4);
			DataTable item = tables[str];
			this.tabletblSaleData = (dsSaleItems.tblSaleDataDataTable)item;
			if (cd470cdb9ec6f4c001d9b021df579c631 && this.tabletblSaleData != null)
			{
				this.tabletblSaleData.cfb93e8c2fa64f1123fa8988e476c2203();
			}
			DataTableCollection dataTableCollection = base.Tables;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x36eb);
			DataTable dataTable = dataTableCollection[str1];
			this.tabletblCouponData = (dsSaleItems.tblCouponDataDataTable)dataTable;
			if (cd470cdb9ec6f4c001d9b021df579c631 && this.tabletblCouponData != null)
			{
				this.tabletblCouponData.cfb93e8c2fa64f1123fa8988e476c2203();
			}
			DataRelationCollection relations = this.Relations;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3706);
			DataRelation dataRelation = relations[str2];
			this.relationtblSaleData_tblCouponData = dataRelation;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			DataSet dataSet = base.Clone();
			dsSaleItems dsSaleItem = (dsSaleItems)dataSet;
			dsSaleItem.cfb93e8c2fa64f1123fa8988e476c2203();
			System.Data.SchemaSerializationMode schemaSerializationMode = this.SchemaSerializationMode;
			dsSaleItem.SchemaSerializationMode = schemaSerializationMode;
			return dsSaleItem;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = (long)0;
			XmlSchema xmlSchema = XmlSchema.Read(new XmlTextReader(memoryStream), null);
			return xmlSchema;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			// 
			// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsSaleItems::GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsSaleItems::ReadXmlSerializable(System.Xml.XmlReader)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void ReadXmlSerializable(System.Xml.XmlReader)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class tblCouponDataDataTable : TypedTableBase<dsSaleItems.tblCouponDataRow>
		{
			private DataColumn columnRowID;

			private DataColumn columnCouponID;

			private DataColumn columnCoupon;

			private DataColumn columnCouponName;

			private DataColumn columnDiscountAmount;

			private DataColumn columnDiscount_Item_Type;

			private DataColumn columnDiscount_Type;

			private DataColumn columnbDelete;

			private dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowChangingEvent;

			private dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowChangedEvent;

			private dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowDeletingEvent;

			private dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowDeletedEvent;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bDeleteColumn
			{
				get
				{
					return this.columnbDelete;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					DataRowCollection rows = this.Rows;
					int count = rows.Count;
					return count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CouponColumn
			{
				get
				{
					return this.columnCoupon;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CouponIDColumn
			{
				get
				{
					return this.columnCouponID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CouponNameColumn
			{
				get
				{
					return this.columnCouponName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Discount_Item_TypeColumn
			{
				get
				{
					return this.columnDiscount_Item_Type;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Discount_TypeColumn
			{
				get
				{
					return this.columnDiscount_Type;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DiscountAmountColumn
			{
				get
				{
					return this.columnDiscountAmount;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblCouponDataRow this[int index]
			{
				get
				{
					DataRowCollection rows = this.Rows;
					return (dsSaleItems.tblCouponDataRow)rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RowIDColumn
			{
				get
				{
					return this.columnRowID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblCouponDataDataTable()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x36eb);
				this.TableName = str;
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblCouponDataDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblCouponDataDataTable::.ctor(System.Data.DataTable)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void .ctor(System.Data.DataTable)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tblCouponDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtblCouponDataRow(dsSaleItems.tblCouponDataRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblCouponDataRow AddtblCouponDataRow(dsSaleItems.tblSaleDataRow parenttblSaleDataRowBytblSaleData_tblCouponData, int CouponID, string Coupon, string CouponName, decimal DiscountAmount, string Discount_Item_Type, string Discount_Type, bool bDelete)
			{
				// 
				// Current member / type: SqlLibrary.dsSaleItems/tblCouponDataRow SqlLibrary.dsSaleItems/tblCouponDataDataTable::AddtblCouponDataRow(SqlLibrary.dsSaleItems/tblSaleDataRow,System.Int32,System.String,System.String,System.Decimal,System.String,System.String,System.Boolean)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: SqlLibrary.dsSaleItems/tblCouponDataRow AddtblCouponDataRow(SqlLibrary.dsSaleItems/tblSaleDataRow,System.Int32,System.String,System.String,System.Decimal,System.String,System.String,System.Boolean)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				this.columnRowID = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x388f), typeof(int), null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnRowID);
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39e7);
				this.columnCouponID = new DataColumn(str, typeof(int), null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnCouponID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39f8);
				Type type = typeof(string);
				this.columnCoupon = new DataColumn(str1, type, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnCoupon);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a05);
				Type type1 = typeof(string);
				this.columnCouponName = new DataColumn(str2, type1, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnCouponName);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a1a);
				this.columnDiscountAmount = new DataColumn(str3, typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnDiscountAmount);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a37);
				Type type2 = typeof(string);
				this.columnDiscount_Item_Type = new DataColumn(str4, type2, null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnDiscount_Item_Type);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a5c);
				this.columnDiscount_Type = new DataColumn(str5, typeof(string), null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnDiscount_Type);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a77);
				Type type3 = typeof(bool);
				this.columnbDelete = new DataColumn(str6, type3, null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnbDelete);
				DataColumn dataColumn = this.columnCoupon;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39f8);
				dataColumn.DefaultValue = str7;
				this.columnbDelete.AllowDBNull = false;
				this.columnbDelete.DefaultValue = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x388f);
				DataColumn item = columns[str];
				this.columnRowID = item;
				DataColumnCollection dataColumnCollection = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39e7);
				DataColumn dataColumn = dataColumnCollection[str1];
				this.columnCouponID = dataColumn;
				DataColumnCollection columns1 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39f8);
				DataColumn item1 = columns1[str2];
				this.columnCoupon = item1;
				DataColumnCollection dataColumnCollection1 = base.Columns;
				DataColumn dataColumn1 = dataColumnCollection1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a05)];
				this.columnCouponName = dataColumn1;
				DataColumnCollection columns2 = base.Columns;
				DataColumn item2 = columns2[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a1a)];
				this.columnDiscountAmount = item2;
				DataColumnCollection dataColumnCollection2 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a37);
				DataColumn dataColumn2 = dataColumnCollection2[str3];
				this.columnDiscount_Item_Type = dataColumn2;
				DataColumnCollection columns3 = base.Columns;
				DataColumn item3 = columns3[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a5c)];
				this.columnDiscount_Type = item3;
				DataColumnCollection dataColumnCollection3 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3a77);
				this.columnbDelete = dataColumnCollection3[str4];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsSaleItems.tblCouponDataDataTable _tblCouponDataDataTable = (dsSaleItems.tblCouponDataDataTable)dataTable;
				_tblCouponDataDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return _tblCouponDataDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSaleItems.tblCouponDataDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dsSaleItems.tblCouponDataRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsSaleItems/tblCouponDataDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSaleItems.tblCouponDataRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblCouponDataRow NewtblCouponDataRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsSaleItems.tblCouponDataRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tblCouponDataRowChangedEvent != null)
				{
					dsSaleItems.tblCouponDataRowChangeEventHandler _tblCouponDataRowChangeEventHandler = this.tblCouponDataRowChangedEvent;
					if (_tblCouponDataRowChangeEventHandler != null)
					{
						DataRow row = e.Row;
						dsSaleItems.tblCouponDataRow _tblCouponDataRow = (dsSaleItems.tblCouponDataRow)row;
						DataRowAction action = e.Action;
						_tblCouponDataRowChangeEventHandler(this, new dsSaleItems.tblCouponDataRowChangeEvent(_tblCouponDataRow, action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblCouponDataDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowChanging(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblCouponDataDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblCouponDataDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovetblCouponDataRow(dsSaleItems.tblCouponDataRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblCouponDataRowChangedEvent, obj);
					this.tblCouponDataRowChangedEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblCouponDataRowChangedEvent, obj);
					this.tblCouponDataRowChangedEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblCouponDataRowChangingEvent, obj);
					this.tblCouponDataRowChangingEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblCouponDataRowChangingEvent, obj);
					this.tblCouponDataRowChangingEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblCouponDataRowDeletedEvent, obj);
					this.tblCouponDataRowDeletedEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblCouponDataRowDeletedEvent, obj);
					this.tblCouponDataRowDeletedEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblCouponDataRowChangeEventHandler tblCouponDataRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblCouponDataRowDeletingEvent, obj);
					this.tblCouponDataRowDeletingEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblCouponDataRowDeletingEvent, obj);
					this.tblCouponDataRowDeletingEvent = (dsSaleItems.tblCouponDataRowChangeEventHandler)@delegate;
				}
			}
		}

		public class tblCouponDataRow : DataRow
		{
			private dsSaleItems.tblCouponDataDataTable c19c89dd7a5bce2390eb775437df351d8;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bDelete
			{
				get
				{
					object item = this[this.c19c89dd7a5bce2390eb775437df351d8.bDeleteColumn];
					bool flag = Conversions.ToBoolean(item);
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c19c89dd7a5bce2390eb775437df351d8.bDeleteColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Coupon
			{
				get
				{
					string str;
					try
					{
						DataColumn couponColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponColumn;
						object item = this[couponColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4b42), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn couponColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponColumn;
					this[couponColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int CouponID
			{
				get
				{
					int num;
					try
					{
						DataColumn couponIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponIDColumn;
						int integer = Conversions.ToInteger(this[couponIDColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4aba), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn couponIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponIDColumn;
					this[couponIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CouponName
			{
				get
				{
					string str;
					try
					{
						object item = this[this.c19c89dd7a5bce2390eb775437df351d8.CouponNameColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4bc6), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn couponNameColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponNameColumn;
					this[couponNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Discount_Item_Type
			{
				get
				{
					string str;
					try
					{
						DataColumn discountItemTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_Item_TypeColumn;
						string str1 = Conversions.ToString(this[discountItemTypeColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ce6), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn discountItemTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_Item_TypeColumn;
					this[discountItemTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Discount_Type
			{
				get
				{
					string str;
					try
					{
						DataColumn discountTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_TypeColumn;
						str = Conversions.ToString(this[discountTypeColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4d82);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn discountTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_TypeColumn;
					this[discountTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal DiscountAmount
			{
				get
				{
					decimal num;
					try
					{
						DataColumn discountAmountColumn = this.c19c89dd7a5bce2390eb775437df351d8.DiscountAmountColumn;
						object item = this[discountAmountColumn];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4c52);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c19c89dd7a5bce2390eb775437df351d8.DiscountAmountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int RowID
			{
				get
				{
					int num;
					try
					{
						DataColumn rowIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.RowIDColumn;
						object item = this[rowIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4a38);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c19c89dd7a5bce2390eb775437df351d8.RowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblSaleDataRow tblSaleDataRow
			{
				get
				{
					DataTable table = this.Table;
					DataRelationCollection parentRelations = table.ParentRelations;
					string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3706);
					DataRow parentRow = this.GetParentRow(parentRelations[str]);
					return (dsSaleItems.tblSaleDataRow)parentRow;
				}
				set
				{
					DataTable table = this.Table;
					DataRelationCollection parentRelations = table.ParentRelations;
					string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3706);
					this.SetParentRow(value, parentRelations[str]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblCouponDataRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.c19c89dd7a5bce2390eb775437df351d8 = (dsSaleItems.tblCouponDataDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCouponIDNull()
			{
				bool flag = this.IsNull(this.c19c89dd7a5bce2390eb775437df351d8.CouponIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCouponNameNull()
			{
				DataColumn couponNameColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponNameColumn;
				bool flag = this.IsNull(couponNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCouponNull()
			{
				DataColumn couponColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponColumn;
				bool flag = this.IsNull(couponColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDiscount_Item_TypeNull()
			{
				DataColumn discountItemTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_Item_TypeColumn;
				return this.IsNull(discountItemTypeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDiscount_TypeNull()
			{
				DataColumn discountTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_TypeColumn;
				return this.IsNull(discountTypeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDiscountAmountNull()
			{
				DataColumn discountAmountColumn = this.c19c89dd7a5bce2390eb775437df351d8.DiscountAmountColumn;
				bool flag = this.IsNull(discountAmountColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRowIDNull()
			{
				DataColumn rowIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.RowIDColumn;
				bool flag = this.IsNull(rowIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCouponIDNull()
			{
				DataColumn couponIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[couponIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCouponNameNull()
			{
				DataColumn couponNameColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponNameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[couponNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCouponNull()
			{
				DataColumn couponColumn = this.c19c89dd7a5bce2390eb775437df351d8.CouponColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[couponColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDiscount_Item_TypeNull()
			{
				DataColumn discountItemTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_Item_TypeColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[discountItemTypeColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDiscount_TypeNull()
			{
				DataColumn discountTypeColumn = this.c19c89dd7a5bce2390eb775437df351d8.Discount_TypeColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[discountTypeColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDiscountAmountNull()
			{
				DataColumn discountAmountColumn = this.c19c89dd7a5bce2390eb775437df351d8.DiscountAmountColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[discountAmountColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRowIDNull()
			{
				DataColumn rowIDColumn = this.c19c89dd7a5bce2390eb775437df351d8.RowIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[rowIDColumn] = objectValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tblCouponDataRowChangeEvent : EventArgs
		{
			private dsSaleItems.tblCouponDataRow c1cbccf2ba30b0268c407c29b056c2fdd;

			private DataRowAction c066b556286adffc3d6471a61b6be6ffc;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.c066b556286adffc3d6471a61b6be6ffc;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblCouponDataRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblCouponDataRowChangeEvent(dsSaleItems.tblCouponDataRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tblCouponDataRowChangeEventHandler(object sender, dsSaleItems.tblCouponDataRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class tblSaleDataDataTable : TypedTableBase<dsSaleItems.tblSaleDataRow>
		{
			private DataColumn columnPandSID;

			private DataColumn columnItemType;

			private DataColumn columnGifCertificateID;

			private DataColumn columnQty;

			private DataColumn columnDescription;

			private DataColumn columnPerformerID;

			private DataColumn columnPerformer;

			private DataColumn columnPrice;

			private DataColumn columnTotal;

			private DataColumn columnClientID;

			private DataColumn columnPandSName;

			private DataColumn columnPackagePayMonth;

			private DataColumn columnSetupFee;

			private DataColumn columndtExpiry;

			private DataColumn columnTax;

			private DataColumn columnTax2;

			private DataColumn columnTax3;

			private DataColumn columnRowID;

			private DataColumn columnbCouponApplied;

			private DataColumn columnbOnSale;

			private DataColumn columndtForced;

			private DataColumn columnExpiryMonths;

			private DataColumn columnExpiryDays;

			private DataColumn columnEnd_Type_ID;

			private DataColumn columnStart_Type_ID;

			private DataColumn columnbRollover;

			private DataColumn columndtStart;

			private DataColumn columnbTax1;

			private DataColumn columnbTax2;

			private DataColumn columnbTax3;

			private DataColumn columnTax1_Prct;

			private DataColumn columnTax2_Prct;

			private DataColumn columnTax3_Prct;

			private dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowChangingEvent;

			private dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowChangedEvent;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bCouponAppliedColumn
			{
				get
				{
					return this.columnbCouponApplied;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bOnSaleColumn
			{
				get
				{
					return this.columnbOnSale;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bRolloverColumn
			{
				get
				{
					return this.columnbRollover;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bTax1Column
			{
				get
				{
					return this.columnbTax1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bTax2Column
			{
				get
				{
					return this.columnbTax2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bTax3Column
			{
				get
				{
					return this.columnbTax3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ClientIDColumn
			{
				get
				{
					return this.columnClientID;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					DataRowCollection rows = this.Rows;
					int count = rows.Count;
					return count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtExpiryColumn
			{
				get
				{
					return this.columndtExpiry;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtForcedColumn
			{
				get
				{
					return this.columndtForced;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtStartColumn
			{
				get
				{
					return this.columndtStart;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn End_Type_IDColumn
			{
				get
				{
					return this.columnEnd_Type_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ExpiryDaysColumn
			{
				get
				{
					return this.columnExpiryDays;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ExpiryMonthsColumn
			{
				get
				{
					return this.columnExpiryMonths;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GifCertificateIDColumn
			{
				get
				{
					return this.columnGifCertificateID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblSaleDataRow this[int index]
			{
				get
				{
					DataRowCollection rows = this.Rows;
					DataRow item = rows[index];
					return (dsSaleItems.tblSaleDataRow)item;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ItemTypeColumn
			{
				get
				{
					return this.columnItemType;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PackagePayMonthColumn
			{
				get
				{
					return this.columnPackagePayMonth;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PandSIDColumn
			{
				get
				{
					return this.columnPandSID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PandSNameColumn
			{
				get
				{
					return this.columnPandSName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PerformerColumn
			{
				get
				{
					return this.columnPerformer;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PerformerIDColumn
			{
				get
				{
					return this.columnPerformerID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PriceColumn
			{
				get
				{
					return this.columnPrice;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn QtyColumn
			{
				get
				{
					return this.columnQty;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RowIDColumn
			{
				get
				{
					return this.columnRowID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SetupFeeColumn
			{
				get
				{
					return this.columnSetupFee;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Start_Type_IDColumn
			{
				get
				{
					return this.columnStart_Type_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax1_PrctColumn
			{
				get
				{
					return this.columnTax1_Prct;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax2_PrctColumn
			{
				get
				{
					return this.columnTax2_Prct;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax2Column
			{
				get
				{
					return this.columnTax2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax3_PrctColumn
			{
				get
				{
					return this.columnTax3_Prct;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax3Column
			{
				get
				{
					return this.columnTax3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TaxColumn
			{
				get
				{
					return this.columnTax;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TotalColumn
			{
				get
				{
					return this.columnTotal;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblSaleDataDataTable()
			{
				dsSaleItems.tblSaleDataDataTable _tblSaleDataDataTable = this;
				base.ColumnChanging += new DataColumnChangeEventHandler(_tblSaleDataDataTable.ca710d51bd2e76e19ab28b3f003197031);
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x36d4);
				this.TableName = str;
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblSaleDataDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblSaleDataDataTable::.ctor(System.Data.DataTable)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void .ctor(System.Data.DataTable)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tblSaleDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				dsSaleItems.tblSaleDataDataTable _tblSaleDataDataTable = this;
				base.ColumnChanging += new DataColumnChangeEventHandler(_tblSaleDataDataTable.ca710d51bd2e76e19ab28b3f003197031);
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtblSaleDataRow(dsSaleItems.tblSaleDataRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblSaleDataRow AddtblSaleDataRow(int PandSID, string ItemType, string GifCertificateID, decimal Qty, string Description, int PerformerID, string Performer, decimal Price, decimal Total, int ClientID, string PandSName, int PackagePayMonth, decimal SetupFee, string dtExpiry, decimal Tax, decimal Tax2, decimal Tax3, bool bCouponApplied, bool bOnSale, string dtForced, int ExpiryMonths, int ExpiryDays, int End_Type_ID, int Start_Type_ID, bool bRollover, string dtStart, bool bTax1, bool bTax2, bool bTax3, decimal Tax1_Prct, decimal Tax2_Prct, decimal Tax3_Prct)
			{
				dsSaleItems.tblSaleDataRow _tblSaleDataRow = (dsSaleItems.tblSaleDataRow)this.NewRow();
				object[] pandSID = new object[] { PandSID, ItemType, GifCertificateID, Qty, Description, PerformerID, Performer, Price, Total, ClientID, PandSName, PackagePayMonth, SetupFee, dtExpiry, Tax, Tax2, Tax3, null, bCouponApplied, bOnSale, dtForced, ExpiryMonths, ExpiryDays, End_Type_ID, Start_Type_ID, bRollover, dtStart, bTax1, bTax2, bTax3, Tax1_Prct, Tax2_Prct, Tax3_Prct };
				_tblSaleDataRow.ItemArray = pandSID;
				DataRowCollection rows = this.Rows;
				rows.Add(_tblSaleDataRow);
				return _tblSaleDataRow;
			}

			private void ca710d51bd2e76e19ab28b3f003197031(object cf7d8a347db4ec9aed6c0c9437e4edbb6, DataColumnChangeEventArgs c38331f058065b55f8ef1950a745341e0)
			{
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3795);
				Type type = typeof(int);
				this.columnPandSID = new DataColumn(str, type, null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnPandSID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37a4);
				Type type1 = typeof(string);
				this.columnItemType = new DataColumn(str1, type1, null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnItemType);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37b5);
				Type type2 = typeof(string);
				this.columnGifCertificateID = new DataColumn(str2, type2, null, MappingType.Element);
				base.Columns.Add(this.columnGifCertificateID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37d6);
				Type type3 = typeof(decimal);
				this.columnQty = new DataColumn(str3, type3, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnQty);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37dd);
				Type type4 = typeof(string);
				this.columnDescription = new DataColumn(str4, type4, null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37f4);
				Type type5 = typeof(int);
				this.columnPerformerID = new DataColumn(str5, type5, null, MappingType.Element);
				base.Columns.Add(this.columnPerformerID);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x380b);
				Type type6 = typeof(string);
				this.columnPerformer = new DataColumn(str6, type6, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnPerformer);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x381e);
				Type type7 = typeof(decimal);
				this.columnPrice = new DataColumn(str7, type7, null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnPrice);
				this.columnTotal = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3829), typeof(decimal), null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnTotal);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30ba);
				Type type8 = typeof(int);
				this.columnClientID = new DataColumn(str8, type8, null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnClientID);
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3834);
				this.columnPandSName = new DataColumn(str9, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPandSName);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3847);
				Type type9 = typeof(int);
				this.columnPackagePayMonth = new DataColumn(str10, type9, null, MappingType.Element);
				base.Columns.Add(this.columnPackagePayMonth);
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3866);
				Type type10 = typeof(decimal);
				this.columnSetupFee = new DataColumn(str11, type10, null, MappingType.Element);
				DataColumnCollection dataColumnCollection3 = base.Columns;
				dataColumnCollection3.Add(this.columnSetupFee);
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3877);
				Type type11 = typeof(string);
				this.columndtExpiry = new DataColumn(str12, type11, null, MappingType.Element);
				base.Columns.Add(this.columndtExpiry);
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3888);
				this.columnTax = new DataColumn(str13, typeof(decimal), null, MappingType.Element);
				DataColumnCollection columns4 = base.Columns;
				columns4.Add(this.columnTax);
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3161);
				Type type12 = typeof(decimal);
				this.columnTax2 = new DataColumn(str14, type12, null, MappingType.Element);
				DataColumnCollection dataColumnCollection4 = base.Columns;
				dataColumnCollection4.Add(this.columnTax2);
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x316a);
				Type type13 = typeof(decimal);
				this.columnTax3 = new DataColumn(str15, type13, null, MappingType.Element);
				DataColumnCollection columns5 = base.Columns;
				columns5.Add(this.columnTax3);
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x388f);
				Type type14 = typeof(int);
				this.columnRowID = new DataColumn(str16, type14, null, MappingType.Element);
				DataColumnCollection dataColumnCollection5 = base.Columns;
				dataColumnCollection5.Add(this.columnRowID);
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x389a);
				Type type15 = typeof(bool);
				this.columnbCouponApplied = new DataColumn(str17, type15, null, MappingType.Element);
				DataColumnCollection columns6 = base.Columns;
				columns6.Add(this.columnbCouponApplied);
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38b7);
				Type type16 = typeof(bool);
				this.columnbOnSale = new DataColumn(str18, type16, null, MappingType.Element);
				DataColumnCollection dataColumnCollection6 = base.Columns;
				dataColumnCollection6.Add(this.columnbOnSale);
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38c6);
				Type type17 = typeof(string);
				this.columndtForced = new DataColumn(str19, type17, null, MappingType.Element);
				DataColumnCollection columns7 = base.Columns;
				columns7.Add(this.columndtForced);
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38d7);
				Type type18 = typeof(int);
				this.columnExpiryMonths = new DataColumn(str20, type18, null, MappingType.Element);
				base.Columns.Add(this.columnExpiryMonths);
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38f0);
				Type type19 = typeof(int);
				this.columnExpiryDays = new DataColumn(str21, type19, null, MappingType.Element);
				DataColumnCollection dataColumnCollection7 = base.Columns;
				dataColumnCollection7.Add(this.columnExpiryDays);
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3905);
				Type type20 = typeof(int);
				this.columnEnd_Type_ID = new DataColumn(str22, type20, null, MappingType.Element);
				DataColumnCollection columns8 = base.Columns;
				columns8.Add(this.columnEnd_Type_ID);
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x391c);
				Type type21 = typeof(int);
				this.columnStart_Type_ID = new DataColumn(str23, type21, null, MappingType.Element);
				base.Columns.Add(this.columnStart_Type_ID);
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3937);
				Type type22 = typeof(bool);
				this.columnbRollover = new DataColumn(str24, type22, null, MappingType.Element);
				base.Columns.Add(this.columnbRollover);
				string str25 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x394a);
				Type type23 = typeof(string);
				this.columndtStart = new DataColumn(str25, type23, null, MappingType.Element);
				DataColumnCollection dataColumnCollection8 = base.Columns;
				dataColumnCollection8.Add(this.columndtStart);
				string str26 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3959);
				Type type24 = typeof(bool);
				this.columnbTax1 = new DataColumn(str26, type24, null, MappingType.Element);
				DataColumnCollection columns9 = base.Columns;
				columns9.Add(this.columnbTax1);
				string str27 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3964);
				Type type25 = typeof(bool);
				this.columnbTax2 = new DataColumn(str27, type25, null, MappingType.Element);
				base.Columns.Add(this.columnbTax2);
				string str28 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x396f);
				Type type26 = typeof(bool);
				this.columnbTax3 = new DataColumn(str28, type26, null, MappingType.Element);
				DataColumnCollection dataColumnCollection9 = base.Columns;
				dataColumnCollection9.Add(this.columnbTax3);
				string str29 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x397a);
				Type type27 = typeof(decimal);
				this.columnTax1_Prct = new DataColumn(str29, type27, null, MappingType.Element);
				DataColumnCollection columns10 = base.Columns;
				columns10.Add(this.columnTax1_Prct);
				this.columnTax2_Prct = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x398d), typeof(decimal), null, MappingType.Element);
				DataColumnCollection dataColumnCollection10 = base.Columns;
				dataColumnCollection10.Add(this.columnTax2_Prct);
				string str30 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39a0);
				Type type28 = typeof(decimal);
				this.columnTax3_Prct = new DataColumn(str30, type28, null, MappingType.Element);
				base.Columns.Add(this.columnTax3_Prct);
				ConstraintCollection constraints = this.Constraints;
				string str31 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1583);
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnRowID };
				constraints.Add(new UniqueConstraint(str31, dataColumnArray, false));
				this.columnGifCertificateID.MaxLength = 50;
				this.columnQty.DefaultValue = decimal.Zero;
				this.columnPerformerID.DefaultValue = 0;
				this.columnPrice.DefaultValue = decimal.Zero;
				this.columnTotal.DefaultValue = decimal.Zero;
				this.columnSetupFee.DefaultValue = decimal.Zero;
				this.columndtExpiry.AllowDBNull = false;
				this.columndtExpiry.DefaultValue = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39b3);
				this.columnTax.DefaultValue = decimal.Zero;
				this.columnTax2.DefaultValue = decimal.Zero;
				this.columnTax3.DefaultValue = decimal.Zero;
				this.columnRowID.AutoIncrement = true;
				this.columnRowID.AutoIncrementSeed = (long)1;
				this.columnRowID.AllowDBNull = false;
				this.columnRowID.ReadOnly = true;
				this.columnRowID.Unique = true;
				this.columnbCouponApplied.DefaultValue = false;
				this.columnbOnSale.DefaultValue = false;
				this.columnExpiryMonths.DefaultValue = 0;
				this.columnExpiryDays.DefaultValue = 0;
				this.columnEnd_Type_ID.DefaultValue = 0;
				this.columnStart_Type_ID.DefaultValue = 0;
				this.columnbRollover.DefaultValue = false;
				this.columnbTax1.DefaultValue = false;
				this.columnbTax2.DefaultValue = false;
				this.columnbTax3.DefaultValue = false;
				this.columnTax1_Prct.DefaultValue = new decimal((long)100);
				this.columnTax2_Prct.DefaultValue = new decimal((long)100);
				this.columnTax3_Prct.DefaultValue = new decimal((long)100);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3795);
				DataColumn item = columns[str];
				this.columnPandSID = item;
				DataColumnCollection dataColumnCollection = base.Columns;
				this.columnItemType = dataColumnCollection[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37a4)];
				this.columnGifCertificateID = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37b5)];
				DataColumnCollection columns1 = base.Columns;
				DataColumn dataColumn = columns1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37d6)];
				this.columnQty = dataColumn;
				DataColumnCollection dataColumnCollection1 = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37dd);
				this.columnDescription = dataColumnCollection1[str1];
				DataColumnCollection columns2 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x37f4);
				DataColumn item1 = columns2[str2];
				this.columnPerformerID = item1;
				DataColumnCollection dataColumnCollection2 = base.Columns;
				this.columnPerformer = dataColumnCollection2[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x380b)];
				DataColumnCollection columns3 = base.Columns;
				DataColumn dataColumn1 = columns3[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x381e)];
				this.columnPrice = dataColumn1;
				DataColumnCollection dataColumnCollection3 = base.Columns;
				DataColumn item2 = dataColumnCollection3[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3829)];
				this.columnTotal = item2;
				DataColumnCollection columns4 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30ba);
				DataColumn dataColumn2 = columns4[str3];
				this.columnClientID = dataColumn2;
				DataColumnCollection dataColumnCollection4 = base.Columns;
				DataColumn item3 = dataColumnCollection4[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3834)];
				this.columnPandSName = item3;
				DataColumnCollection columns5 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3847);
				this.columnPackagePayMonth = columns5[str4];
				DataColumnCollection dataColumnCollection5 = base.Columns;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3866);
				DataColumn dataColumn3 = dataColumnCollection5[str5];
				this.columnSetupFee = dataColumn3;
				DataColumnCollection columns6 = base.Columns;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3877);
				DataColumn item4 = columns6[str6];
				this.columndtExpiry = item4;
				DataColumnCollection dataColumnCollection6 = base.Columns;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3888);
				DataColumn dataColumn4 = dataColumnCollection6[str7];
				this.columnTax = dataColumn4;
				DataColumnCollection columns7 = base.Columns;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3161);
				DataColumn item5 = columns7[str8];
				this.columnTax2 = item5;
				DataColumnCollection dataColumnCollection7 = base.Columns;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x316a);
				this.columnTax3 = dataColumnCollection7[str9];
				DataColumnCollection columns8 = base.Columns;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x388f);
				DataColumn dataColumn5 = columns8[str10];
				this.columnRowID = dataColumn5;
				DataColumnCollection dataColumnCollection8 = base.Columns;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x389a);
				DataColumn item6 = dataColumnCollection8[str11];
				this.columnbCouponApplied = item6;
				DataColumnCollection columns9 = base.Columns;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38b7);
				DataColumn dataColumn6 = columns9[str12];
				this.columnbOnSale = dataColumn6;
				DataColumnCollection dataColumnCollection9 = base.Columns;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38c6);
				DataColumn item7 = dataColumnCollection9[str13];
				this.columndtForced = item7;
				DataColumnCollection columns10 = base.Columns;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38d7);
				this.columnExpiryMonths = columns10[str14];
				DataColumnCollection dataColumnCollection10 = base.Columns;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x38f0);
				DataColumn dataColumn7 = dataColumnCollection10[str15];
				this.columnExpiryDays = dataColumn7;
				DataColumnCollection columns11 = base.Columns;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3905);
				DataColumn item8 = columns11[str16];
				this.columnEnd_Type_ID = item8;
				DataColumnCollection dataColumnCollection11 = base.Columns;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x391c);
				DataColumn dataColumn8 = dataColumnCollection11[str17];
				this.columnStart_Type_ID = dataColumn8;
				DataColumnCollection columns12 = base.Columns;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3937);
				DataColumn item9 = columns12[str18];
				this.columnbRollover = item9;
				DataColumnCollection dataColumnCollection12 = base.Columns;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x394a);
				DataColumn dataColumn9 = dataColumnCollection12[str19];
				this.columndtStart = dataColumn9;
				DataColumnCollection columns13 = base.Columns;
				DataColumn item10 = columns13[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3959)];
				this.columnbTax1 = item10;
				DataColumnCollection dataColumnCollection13 = base.Columns;
				DataColumn dataColumn10 = dataColumnCollection13[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3964)];
				this.columnbTax2 = dataColumn10;
				DataColumnCollection columns14 = base.Columns;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x396f);
				DataColumn item11 = columns14[str20];
				this.columnbTax3 = item11;
				DataColumnCollection dataColumnCollection14 = base.Columns;
				DataColumn dataColumn11 = dataColumnCollection14[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x397a)];
				this.columnTax1_Prct = dataColumn11;
				DataColumnCollection columns15 = base.Columns;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x398d);
				this.columnTax2_Prct = columns15[str21];
				DataColumnCollection dataColumnCollection15 = base.Columns;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x39a0);
				DataColumn item12 = dataColumnCollection15[str22];
				this.columnTax3_Prct = item12;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				dsSaleItems.tblSaleDataDataTable _tblSaleDataDataTable = (dsSaleItems.tblSaleDataDataTable)base.Clone();
				_tblSaleDataDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return _tblSaleDataDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSaleItems.tblSaleDataDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				Type type = typeof(dsSaleItems.tblSaleDataRow);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsSaleItems/tblSaleDataDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSaleItems.tblSaleDataRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblSaleDataRow NewtblSaleDataRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsSaleItems.tblSaleDataRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblSaleDataDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowChanged(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblSaleDataDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowChanging(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSaleItems/tblSaleDataDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs)
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tblSaleDataRowDeleting != null)
				{
					dsSaleItems.tblSaleDataRowChangeEventHandler _tblSaleDataRowChangeEventHandler = this.tblSaleDataRowDeleting;
					if (_tblSaleDataRowChangeEventHandler != null)
					{
						_tblSaleDataRowChangeEventHandler(this, new dsSaleItems.tblSaleDataRowChangeEvent((dsSaleItems.tblSaleDataRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovetblSaleDataRow(dsSaleItems.tblSaleDataRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblSaleDataRowChangedEvent, obj);
					this.tblSaleDataRowChangedEvent = (dsSaleItems.tblSaleDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.tblSaleDataRowChangedEvent -= obj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblSaleDataRowChangingEvent, obj);
					this.tblSaleDataRowChangingEvent = (dsSaleItems.tblSaleDataRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblSaleDataRowChangingEvent, obj);
					this.tblSaleDataRowChangingEvent = (dsSaleItems.tblSaleDataRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSaleItems.tblSaleDataRowChangeEventHandler tblSaleDataRowDeleting;
		}

		public class tblSaleDataRow : DataRow
		{
			private dsSaleItems.tblSaleDataDataTable c57fef8cf7ad1f0146102f2351f659750;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bCouponApplied
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.c57fef8cf7ad1f0146102f2351f659750.bCouponAppliedColumn];
						flag = Conversions.ToBoolean(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42e9);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bCouponAppliedColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bOnSale
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bOnSaleColumn;
						bool flag1 = Conversions.ToBoolean(this[dataColumn]);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4379), invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bOnSaleColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bRollover
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bRolloverColumn;
						object item = this[dataColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4627);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bRolloverColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bTax1
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax1Column;
						object item = this[dataColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x472f);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax1Column;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bTax2
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax2Column;
						object item = this[dataColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x47ac), invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax2Column;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bTax3
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax3Column;
						bool flag1 = Conversions.ToBoolean(this[dataColumn]);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4829);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax3Column;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ClientID
			{
				get
				{
					int integer;
					try
					{
						DataColumn clientIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.ClientIDColumn;
						integer = Conversions.ToInteger(this[clientIDColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3f5a);
						throw new StrongTypingException(str, invalidCastException);
					}
					return integer;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.ClientIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Description
			{
				get
				{
					string str;
					try
					{
						string str1 = Conversions.ToString(this[this.c57fef8cf7ad1f0146102f2351f659750.DescriptionColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3cc6);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn descriptionColumn = this.c57fef8cf7ad1f0146102f2351f659750.DescriptionColumn;
					this[descriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string dtExpiry
			{
				get
				{
					object item = this[this.c57fef8cf7ad1f0146102f2351f659750.dtExpiryColumn];
					string str = Conversions.ToString(item);
					return str;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.dtExpiryColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string dtForced
			{
				get
				{
					// 
					// Current member / type: System.String SqlLibrary.dsSaleItems/tblSaleDataRow::get_dtForced()
					// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
					// 
					// Product version: 2019.1.118.0
					// Exception in: System.String get_dtForced()
					// 
					// Queue empty.
					//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
					//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
					//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
					//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
					//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
					//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
					//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
					//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
					//    at ..(MethodBody , & ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\PropertyDecompiler.cs:line 345
					// 
					// mailto: JustDecompilePublicFeedback@telerik.com

				}
				set
				{
					DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.dtForcedColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string dtStart
			{
				get
				{
					string str;
					try
					{
						DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.dtStartColumn;
						object item = this[dataColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x46ad), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.dtStartColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int End_Type_ID
			{
				get
				{
					int num;
					try
					{
						object item = this[this.c57fef8cf7ad1f0146102f2351f659750.End_Type_IDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x450f);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn endTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.End_Type_IDColumn;
					this[endTypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ExpiryDays
			{
				get
				{
					int num;
					try
					{
						int integer = Conversions.ToInteger(this[this.c57fef8cf7ad1f0146102f2351f659750.ExpiryDaysColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4487), invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.ExpiryDaysColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ExpiryMonths
			{
				get
				{
					int num;
					try
					{
						int integer = Conversions.ToInteger(this[this.c57fef8cf7ad1f0146102f2351f659750.ExpiryMonthsColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x43fb);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn expiryMonthsColumn = this.c57fef8cf7ad1f0146102f2351f659750.ExpiryMonthsColumn;
					this[expiryMonthsColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string GifCertificateID
			{
				get
				{
					string str;
					try
					{
						string str1 = Conversions.ToString(this[this.c57fef8cf7ad1f0146102f2351f659750.GifCertificateIDColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3bb9), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.GifCertificateIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ItemType
			{
				get
				{
					string str;
					try
					{
						string str1 = Conversions.ToString(this[this.c57fef8cf7ad1f0146102f2351f659750.ItemTypeColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b35);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.ItemTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int PackagePayMonth
			{
				get
				{
					int num;
					try
					{
						DataColumn packagePayMonthColumn = this.c57fef8cf7ad1f0146102f2351f659750.PackagePayMonthColumn;
						object item = this[packagePayMonthColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4064);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn packagePayMonthColumn = this.c57fef8cf7ad1f0146102f2351f659750.PackagePayMonthColumn;
					this[packagePayMonthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int PandSID
			{
				get
				{
					int num;
					try
					{
						DataColumn pandSIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSIDColumn;
						object item = this[pandSIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3ab3);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn pandSIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSIDColumn;
					this[pandSIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PandSName
			{
				get
				{
					string str;
					try
					{
						DataColumn pandSNameColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSNameColumn;
						object item = this[pandSNameColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3fde), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn pandSNameColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSNameColumn;
					this[pandSNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Performer
			{
				get
				{
					string str;
					try
					{
						DataColumn performerColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerColumn;
						string str1 = Conversions.ToString(this[performerColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3dda);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn performerColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerColumn;
					this[performerColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int PerformerID
			{
				get
				{
					int num;
					try
					{
						object item = this[this.c57fef8cf7ad1f0146102f2351f659750.PerformerIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3d50), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn performerIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerIDColumn;
					this[performerIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Price
			{
				get
				{
					decimal num;
					try
					{
						DataColumn priceColumn = this.c57fef8cf7ad1f0146102f2351f659750.PriceColumn;
						object item = this[priceColumn];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3e60);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn priceColumn = this.c57fef8cf7ad1f0146102f2351f659750.PriceColumn;
					this[priceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Qty
			{
				get
				{
					decimal num;
					try
					{
						DataColumn qtyColumn = this.c57fef8cf7ad1f0146102f2351f659750.QtyColumn;
						decimal num1 = Conversions.ToDecimal(this[qtyColumn]);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3c4d);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn qtyColumn = this.c57fef8cf7ad1f0146102f2351f659750.QtyColumn;
					this[qtyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int RowID
			{
				get
				{
					DataColumn rowIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.RowIDColumn;
					int integer = Conversions.ToInteger(this[rowIDColumn]);
					return integer;
				}
				set
				{
					DataColumn rowIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.RowIDColumn;
					this[rowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal SetupFee
			{
				get
				{
					decimal num;
					try
					{
						DataColumn setupFeeColumn = this.c57fef8cf7ad1f0146102f2351f659750.SetupFeeColumn;
						object item = this[setupFeeColumn];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x40f6), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn setupFeeColumn = this.c57fef8cf7ad1f0146102f2351f659750.SetupFeeColumn;
					this[setupFeeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Start_Type_ID
			{
				get
				{
					int num;
					try
					{
						DataColumn startTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.Start_Type_IDColumn;
						object item = this[startTypeIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4599);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn startTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.Start_Type_IDColumn;
					this[startTypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax
			{
				get
				{
					decimal num;
					try
					{
						DataColumn taxColumn = this.c57fef8cf7ad1f0146102f2351f659750.TaxColumn;
						num = Conversions.ToDecimal(this[taxColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x417a), invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.TaxColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax1_Prct
			{
				get
				{
					decimal num;
					try
					{
						DataColumn tax1PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax1_PrctColumn;
						object item = this[tax1PrctColumn];
						num = Conversions.ToDecimal(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x48a6);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn tax1PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax1_PrctColumn;
					this[tax1PrctColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax2
			{
				get
				{
					decimal num;
					try
					{
						decimal num1 = Conversions.ToDecimal(this[this.c57fef8cf7ad1f0146102f2351f659750.Tax2Column]);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x41f3);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.Tax2Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax2_Prct
			{
				get
				{
					decimal num;
					try
					{
						DataColumn tax2PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax2_PrctColumn;
						object item = this[tax2PrctColumn];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x492c);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn tax2PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax2_PrctColumn;
					this[tax2PrctColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax3
			{
				get
				{
					decimal num;
					try
					{
						DataColumn tax3Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax3Column;
						object item = this[tax3Column];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x426e);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn tax3Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax3Column;
					this[tax3Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax3_Prct
			{
				get
				{
					decimal num;
					try
					{
						DataColumn tax3PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax3_PrctColumn;
						object item = this[tax3PrctColumn];
						num = Conversions.ToDecimal(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x49b2), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn tax3PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax3_PrctColumn;
					this[tax3PrctColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Total
			{
				get
				{
					decimal num;
					try
					{
						DataColumn totalColumn = this.c57fef8cf7ad1f0146102f2351f659750.TotalColumn;
						object item = this[totalColumn];
						decimal num1 = Conversions.ToDecimal(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3edd);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c57fef8cf7ad1f0146102f2351f659750.TotalColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblSaleDataRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.c57fef8cf7ad1f0146102f2351f659750 = (dsSaleItems.tblSaleDataDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblCouponDataRow[] GettblCouponDataRows()
			{
				// 
				// Current member / type: SqlLibrary.dsSaleItems/tblCouponDataRow[] SqlLibrary.dsSaleItems/tblSaleDataRow::GettblCouponDataRows()
				// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
				// 
				// Product version: 2019.1.118.0
				// Exception in: SqlLibrary.dsSaleItems/tblCouponDataRow[] GettblCouponDataRows()
				// 
				// Queue empty.
				//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
				//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
				//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
				//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
				//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
				//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbCouponAppliedNull()
			{
				return this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.bCouponAppliedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbOnSaleNull()
			{
				return this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.bOnSaleColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbRolloverNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bRolloverColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbTax1Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax1Column;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbTax2Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax2Column;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbTax3Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax3Column;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsClientIDNull()
			{
				DataColumn clientIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.ClientIDColumn;
				return this.IsNull(clientIDColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDescriptionNull()
			{
				DataColumn descriptionColumn = this.c57fef8cf7ad1f0146102f2351f659750.DescriptionColumn;
				bool flag = this.IsNull(descriptionColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtForcedNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.dtForcedColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtStartNull()
			{
				return this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.dtStartColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEnd_Type_IDNull()
			{
				DataColumn endTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.End_Type_IDColumn;
				bool flag = this.IsNull(endTypeIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsExpiryDaysNull()
			{
				DataColumn expiryDaysColumn = this.c57fef8cf7ad1f0146102f2351f659750.ExpiryDaysColumn;
				bool flag = this.IsNull(expiryDaysColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsExpiryMonthsNull()
			{
				DataColumn expiryMonthsColumn = this.c57fef8cf7ad1f0146102f2351f659750.ExpiryMonthsColumn;
				return this.IsNull(expiryMonthsColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsGifCertificateIDNull()
			{
				DataColumn gifCertificateIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.GifCertificateIDColumn;
				bool flag = this.IsNull(gifCertificateIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsItemTypeNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.ItemTypeColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPackagePayMonthNull()
			{
				DataColumn packagePayMonthColumn = this.c57fef8cf7ad1f0146102f2351f659750.PackagePayMonthColumn;
				bool flag = this.IsNull(packagePayMonthColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPandSIDNull()
			{
				DataColumn pandSIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSIDColumn;
				bool flag = this.IsNull(pandSIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPandSNameNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.PandSNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPerformerIDNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.PerformerIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPerformerNull()
			{
				DataColumn performerColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerColumn;
				bool flag = this.IsNull(performerColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPriceNull()
			{
				return this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.PriceColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsQtyNull()
			{
				DataColumn qtyColumn = this.c57fef8cf7ad1f0146102f2351f659750.QtyColumn;
				return this.IsNull(qtyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSetupFeeNull()
			{
				DataColumn setupFeeColumn = this.c57fef8cf7ad1f0146102f2351f659750.SetupFeeColumn;
				bool flag = this.IsNull(setupFeeColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsStart_Type_IDNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.Start_Type_IDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTax1_PrctNull()
			{
				DataColumn tax1PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax1_PrctColumn;
				bool flag = this.IsNull(tax1PrctColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTax2_PrctNull()
			{
				DataColumn tax2PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax2_PrctColumn;
				bool flag = this.IsNull(tax2PrctColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTax2Null()
			{
				DataColumn tax2Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax2Column;
				bool flag = this.IsNull(tax2Column);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTax3_PrctNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.Tax3_PrctColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTax3Null()
			{
				DataColumn tax3Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax3Column;
				bool flag = this.IsNull(tax3Column);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTaxNull()
			{
				bool flag = this.IsNull(this.c57fef8cf7ad1f0146102f2351f659750.TaxColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTotalNull()
			{
				DataColumn totalColumn = this.c57fef8cf7ad1f0146102f2351f659750.TotalColumn;
				return this.IsNull(totalColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbCouponAppliedNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bCouponAppliedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbOnSaleNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bOnSaleColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbRolloverNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bRolloverColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbTax1Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax1Column;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbTax2Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax2Column;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbTax3Null()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.bTax3Column;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClientIDNull()
			{
				DataColumn clientIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.ClientIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDescriptionNull()
			{
				DataColumn descriptionColumn = this.c57fef8cf7ad1f0146102f2351f659750.DescriptionColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[descriptionColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtForcedNull()
			{
				DataColumn dataColumn = this.c57fef8cf7ad1f0146102f2351f659750.dtForcedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtStartNull()
			{
				DataColumn objectValue = this.c57fef8cf7ad1f0146102f2351f659750.dtStartColumn;
				this[objectValue] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEnd_Type_IDNull()
			{
				DataColumn endTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.End_Type_IDColumn;
				this[endTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetExpiryDaysNull()
			{
				this[this.c57fef8cf7ad1f0146102f2351f659750.ExpiryDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetExpiryMonthsNull()
			{
				DataColumn expiryMonthsColumn = this.c57fef8cf7ad1f0146102f2351f659750.ExpiryMonthsColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[expiryMonthsColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetGifCertificateIDNull()
			{
				DataColumn gifCertificateIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.GifCertificateIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[gifCertificateIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetItemTypeNull()
			{
				DataColumn itemTypeColumn = this.c57fef8cf7ad1f0146102f2351f659750.ItemTypeColumn;
				this[itemTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPackagePayMonthNull()
			{
				DataColumn packagePayMonthColumn = this.c57fef8cf7ad1f0146102f2351f659750.PackagePayMonthColumn;
				this[packagePayMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPandSIDNull()
			{
				DataColumn pandSIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[pandSIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPandSNameNull()
			{
				DataColumn pandSNameColumn = this.c57fef8cf7ad1f0146102f2351f659750.PandSNameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[pandSNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPerformerIDNull()
			{
				DataColumn performerIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[performerIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPerformerNull()
			{
				DataColumn performerColumn = this.c57fef8cf7ad1f0146102f2351f659750.PerformerColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[performerColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPriceNull()
			{
				DataColumn priceColumn = this.c57fef8cf7ad1f0146102f2351f659750.PriceColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[priceColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetQtyNull()
			{
				DataColumn qtyColumn = this.c57fef8cf7ad1f0146102f2351f659750.QtyColumn;
				this[qtyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSetupFeeNull()
			{
				DataColumn setupFeeColumn = this.c57fef8cf7ad1f0146102f2351f659750.SetupFeeColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[setupFeeColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetStart_Type_IDNull()
			{
				DataColumn startTypeIDColumn = this.c57fef8cf7ad1f0146102f2351f659750.Start_Type_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[startTypeIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTax1_PrctNull()
			{
				DataColumn tax1PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax1_PrctColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[tax1PrctColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTax2_PrctNull()
			{
				DataColumn tax2PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax2_PrctColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[tax2PrctColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTax2Null()
			{
				DataColumn tax2Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax2Column;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[tax2Column] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTax3_PrctNull()
			{
				DataColumn tax3PrctColumn = this.c57fef8cf7ad1f0146102f2351f659750.Tax3_PrctColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[tax3PrctColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTax3Null()
			{
				DataColumn tax3Column = this.c57fef8cf7ad1f0146102f2351f659750.Tax3Column;
				this[tax3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTaxNull()
			{
				DataColumn taxColumn = this.c57fef8cf7ad1f0146102f2351f659750.TaxColumn;
				this[taxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTotalNull()
			{
				DataColumn totalColumn = this.c57fef8cf7ad1f0146102f2351f659750.TotalColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[totalColumn] = objectValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tblSaleDataRowChangeEvent : EventArgs
		{
			private dsSaleItems.tblSaleDataRow c1cbccf2ba30b0268c407c29b056c2fdd;

			private DataRowAction c066b556286adffc3d6471a61b6be6ffc;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.c066b556286adffc3d6471a61b6be6ffc;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSaleItems.tblSaleDataRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblSaleDataRowChangeEvent(dsSaleItems.tblSaleDataRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tblSaleDataRowChangeEventHandler(object sender, dsSaleItems.tblSaleDataRowChangeEvent e);
	}
}