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
	[XmlRoot("dsSalePayments")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dsSalePayments : DataSet
	{
		private dsSalePayments.tblSalePaymentDataTable tabletblSalePayment;

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
		public dsSalePayments.tblSalePaymentDataTable tblSalePayment
		{
			get
			{
				return this.tabletblSalePayment;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsSalePayments()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			dsSalePayments dsSalePayment = this;
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(dsSalePayment.c70e3aced97d5cf7509794216755f6e5d);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			DataRelationCollection relations = base.Relations;
			relations.CollectionChanged += collectionChangeEventHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsSalePayments(SerializationInfo info, StreamingContext context)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsSalePayments::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
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
			CollectionChangeAction action = c38331f058065b55f8ef1950a745341e0.Action;
			if (action == CollectionChangeAction.Remove)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool c94b6484d48fc111845734abc87e6667a()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void ce9285e807b6d3d13062294184142fedb()
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e31);
			this.DataSetName = str;
			this.Prefix = "";
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e4e);
			this.Namespace = str1;
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tabletblSalePayment = new dsSalePayments.tblSalePaymentDataTable();
			DataTableCollection tables = base.Tables;
			tables.Add(this.tabletblSalePayment);
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
			// 
			// Current member / type: System.Void SqlLibrary.dsSalePayments::cfb93e8c2fa64f1123fa8988e476c2203(System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void cfb93e8c2fa64f1123fa8988e476c2203(System.Boolean)
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
		public override DataSet Clone()
		{
			dsSalePayments dsSalePayment = (dsSalePayments)base.Clone();
			dsSalePayment.cfb93e8c2fa64f1123fa8988e476c2203();
			System.Data.SchemaSerializationMode schemaSerializationMode = this.SchemaSerializationMode;
			dsSalePayment.SchemaSerializationMode = schemaSerializationMode;
			return dsSalePayment;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = (long)0;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			// 
			// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsSalePayments::GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
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
			// Current member / type: System.Void SqlLibrary.dsSalePayments::ReadXmlSerializable(System.Xml.XmlReader)
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
		public class tblSalePaymentDataTable : TypedTableBase<dsSalePayments.tblSalePaymentRow>
		{
			private DataColumn columnType;

			private DataColumn columnReferenceNum;

			private DataColumn columnExpiry;

			private DataColumn columnAmount;

			private DataColumn columnAuthNum;

			private DataColumn columnGiftNum;

			private DataColumn columnNameOnCard;

			private DataColumn columnResponse;

			private DataColumn columnTroutD;

			private DataColumn columnResult;

			private DataColumn columnCCType;

			private DataColumn columntempCCNUM;

			private DataColumn columntempCVV;

			private DataColumn columntempExp;

			private DataColumn columntempDup;

			private DataColumn columnCashValue;

			private DataColumn columnInvNum;

			private DataColumn columnRefNum;

			private DataColumn columnbSwiped;

			private DataColumn columnTip;

			private dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowChangingEvent;

			private dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowChangedEvent;

			private dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowDeletedEvent;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AuthNumColumn
			{
				get
				{
					return this.columnAuthNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bSwipedColumn
			{
				get
				{
					return this.columnbSwiped;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CashValueColumn
			{
				get
				{
					return this.columnCashValue;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CCTypeColumn
			{
				get
				{
					return this.columnCCType;
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
			public DataColumn ExpiryColumn
			{
				get
				{
					return this.columnExpiry;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GiftNumColumn
			{
				get
				{
					return this.columnGiftNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn InvNumColumn
			{
				get
				{
					return this.columnInvNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSalePayments.tblSalePaymentRow this[int index]
			{
				get
				{
					DataRowCollection rows = this.Rows;
					return (dsSalePayments.tblSalePaymentRow)rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameOnCardColumn
			{
				get
				{
					return this.columnNameOnCard;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ReferenceNumColumn
			{
				get
				{
					return this.columnReferenceNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RefNumColumn
			{
				get
				{
					return this.columnRefNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ResponseColumn
			{
				get
				{
					return this.columnResponse;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ResultColumn
			{
				get
				{
					return this.columnResult;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tempCCNUMColumn
			{
				get
				{
					return this.columntempCCNUM;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tempCVVColumn
			{
				get
				{
					return this.columntempCVV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tempDupColumn
			{
				get
				{
					return this.columntempDup;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tempExpColumn
			{
				get
				{
					return this.columntempExp;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TipColumn
			{
				get
				{
					return this.columnTip;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TroutDColumn
			{
				get
				{
					return this.columnTroutD;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblSalePaymentDataTable()
			{
				this.TableName = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e14);
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblSalePaymentDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSalePayments/tblSalePaymentDataTable::.ctor(System.Data.DataTable)
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
			protected tblSalePaymentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtblSalePaymentRow(dsSalePayments.tblSalePaymentRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSalePayments.tblSalePaymentRow AddtblSalePaymentRow(string Type, string ReferenceNum, string Expiry, double Amount, string AuthNum, string GiftNum, string NameOnCard, string Response, string TroutD, string Result, string CCType, string tempCCNUM, string tempCVV, string tempExp, bool tempDup, double CashValue, string InvNum, string RefNum, bool bSwiped, decimal Tip)
			{
				DataRow dataRow = this.NewRow();
				dsSalePayments.tblSalePaymentRow _tblSalePaymentRow = (dsSalePayments.tblSalePaymentRow)dataRow;
				object[] type = new object[] { Type, ReferenceNum, Expiry, Amount, AuthNum, GiftNum, NameOnCard, Response, TroutD, Result, CCType, tempCCNUM, tempCVV, tempExp, tempDup, CashValue, InvNum, RefNum, bSwiped, Tip };
				_tblSalePaymentRow.ItemArray = type;
				DataRowCollection rows = this.Rows;
				rows.Add(_tblSalePaymentRow);
				return _tblSalePaymentRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e99);
				this.columnType = new DataColumn(str, typeof(string), null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnType);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ea2);
				Type type = typeof(string);
				this.columnReferenceNum = new DataColumn(str1, type, null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnReferenceNum);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ebb);
				Type type1 = typeof(string);
				this.columnExpiry = new DataColumn(str2, type1, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnExpiry);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x314b);
				Type type2 = typeof(double);
				this.columnAmount = new DataColumn(str3, type2, null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ec8);
				Type type3 = typeof(string);
				this.columnAuthNum = new DataColumn(str4, type3, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnAuthNum);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ed7);
				this.columnGiftNum = new DataColumn(str5, typeof(string), null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnGiftNum);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ee6);
				Type type4 = typeof(string);
				this.columnNameOnCard = new DataColumn(str6, type4, null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnNameOnCard);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4efb);
				Type type5 = typeof(string);
				this.columnResponse = new DataColumn(str7, type5, null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnResponse);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f0c);
				this.columnTroutD = new DataColumn(str8, typeof(string), null, MappingType.Element);
				DataColumnCollection dataColumnCollection3 = base.Columns;
				dataColumnCollection3.Add(this.columnTroutD);
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f19);
				Type type6 = typeof(string);
				this.columnResult = new DataColumn(str9, type6, null, MappingType.Element);
				DataColumnCollection columns4 = base.Columns;
				columns4.Add(this.columnResult);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f26);
				Type type7 = typeof(string);
				this.columnCCType = new DataColumn(str10, type7, null, MappingType.Element);
				DataColumnCollection dataColumnCollection4 = base.Columns;
				dataColumnCollection4.Add(this.columnCCType);
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f33);
				Type type8 = typeof(string);
				this.columntempCCNUM = new DataColumn(str11, type8, null, MappingType.Element);
				DataColumnCollection columns5 = base.Columns;
				columns5.Add(this.columntempCCNUM);
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f46);
				Type type9 = typeof(string);
				this.columntempCVV = new DataColumn(str12, type9, null, MappingType.Element);
				DataColumnCollection dataColumnCollection5 = base.Columns;
				dataColumnCollection5.Add(this.columntempCVV);
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f55);
				Type type10 = typeof(string);
				this.columntempExp = new DataColumn(str13, type10, null, MappingType.Element);
				DataColumnCollection columns6 = base.Columns;
				columns6.Add(this.columntempExp);
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f64);
				Type type11 = typeof(bool);
				this.columntempDup = new DataColumn(str14, type11, null, MappingType.Element);
				DataColumnCollection dataColumnCollection6 = base.Columns;
				dataColumnCollection6.Add(this.columntempDup);
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f73);
				this.columnCashValue = new DataColumn(str15, typeof(double), null, MappingType.Element);
				DataColumnCollection columns7 = base.Columns;
				columns7.Add(this.columnCashValue);
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f86);
				Type type12 = typeof(string);
				this.columnInvNum = new DataColumn(str16, type12, null, MappingType.Element);
				DataColumnCollection dataColumnCollection7 = base.Columns;
				dataColumnCollection7.Add(this.columnInvNum);
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f93);
				this.columnRefNum = new DataColumn(str17, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRefNum);
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fa0);
				Type type13 = typeof(bool);
				this.columnbSwiped = new DataColumn(str18, type13, null, MappingType.Element);
				DataColumnCollection columns8 = base.Columns;
				columns8.Add(this.columnbSwiped);
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4faf);
				Type type14 = typeof(decimal);
				this.columnTip = new DataColumn(str19, type14, null, MappingType.Element);
				DataColumnCollection dataColumnCollection8 = base.Columns;
				dataColumnCollection8.Add(this.columnTip);
				DataColumn dataColumn = this.columnResponse;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28e);
				dataColumn.DefaultValue = str20;
				DataColumn dataColumn1 = this.columnTroutD;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28e);
				dataColumn1.DefaultValue = str21;
				DataColumn dataColumn2 = this.columnResult;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28e);
				dataColumn2.DefaultValue = str22;
				this.columnCCType.AllowDBNull = false;
				DataColumn dataColumn3 = this.columnCCType;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fb6);
				dataColumn3.DefaultValue = str23;
				this.columnCCType.MaxLength = 15;
				this.columntempCCNUM.MaxLength = 100;
				this.columntempCVV.MaxLength = 30;
				this.columntempExp.MaxLength = 30;
				this.columntempDup.AllowDBNull = false;
				this.columntempDup.DefaultValue = false;
				this.columnCashValue.AllowDBNull = false;
				this.columnCashValue.DefaultValue = 0;
				this.columnInvNum.AllowDBNull = false;
				this.columnInvNum.DefaultValue = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28e);
				this.columnInvNum.MaxLength = 30;
				this.columnRefNum.AllowDBNull = false;
				this.columnRefNum.DefaultValue = "";
				this.columnRefNum.MaxLength = 30;
				this.columnbSwiped.AllowDBNull = false;
				this.columnbSwiped.DefaultValue = false;
				this.columnTip.AllowDBNull = false;
				this.columnTip.DefaultValue = new decimal(0, 0, 0, false, 2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e99);
				DataColumn item = columns[str];
				this.columnType = item;
				DataColumnCollection dataColumnCollection = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ea2);
				this.columnReferenceNum = dataColumnCollection[str1];
				DataColumnCollection columns1 = base.Columns;
				this.columnExpiry = columns1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ebb)];
				DataColumnCollection dataColumnCollection1 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x314b);
				DataColumn dataColumn = dataColumnCollection1[str2];
				this.columnAmount = dataColumn;
				DataColumnCollection columns2 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ec8);
				this.columnAuthNum = columns2[str3];
				DataColumnCollection dataColumnCollection2 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ed7);
				this.columnGiftNum = dataColumnCollection2[str4];
				DataColumnCollection columns3 = base.Columns;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4ee6);
				DataColumn item1 = columns3[str5];
				this.columnNameOnCard = item1;
				DataColumnCollection dataColumnCollection3 = base.Columns;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4efb);
				DataColumn dataColumn1 = dataColumnCollection3[str6];
				this.columnResponse = dataColumn1;
				DataColumnCollection columns4 = base.Columns;
				this.columnTroutD = columns4[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f0c)];
				DataColumnCollection dataColumnCollection4 = base.Columns;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f19);
				this.columnResult = dataColumnCollection4[str7];
				DataColumnCollection columns5 = base.Columns;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f26);
				DataColumn item2 = columns5[str8];
				this.columnCCType = item2;
				DataColumnCollection dataColumnCollection5 = base.Columns;
				DataColumn dataColumn2 = dataColumnCollection5[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f33)];
				this.columntempCCNUM = dataColumn2;
				DataColumnCollection columns6 = base.Columns;
				DataColumn item3 = columns6[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f46)];
				this.columntempCVV = item3;
				DataColumn dataColumn3 = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f55)];
				this.columntempExp = dataColumn3;
				DataColumnCollection dataColumnCollection6 = base.Columns;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f64);
				DataColumn item4 = dataColumnCollection6[str9];
				this.columntempDup = item4;
				DataColumnCollection columns7 = base.Columns;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f73);
				this.columnCashValue = columns7[str10];
				DataColumnCollection dataColumnCollection7 = base.Columns;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f86);
				this.columnInvNum = dataColumnCollection7[str11];
				DataColumnCollection columns8 = base.Columns;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4f93);
				DataColumn dataColumn4 = columns8[str12];
				this.columnRefNum = dataColumn4;
				DataColumnCollection dataColumnCollection8 = base.Columns;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fa0);
				this.columnbSwiped = dataColumnCollection8[str13];
				DataColumnCollection columns9 = base.Columns;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4faf);
				DataColumn item5 = columns9[str14];
				this.columnTip = item5;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsSalePayments.tblSalePaymentDataTable _tblSalePaymentDataTable = (dsSalePayments.tblSalePaymentDataTable)dataTable;
				_tblSalePaymentDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return _tblSalePaymentDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSalePayments.tblSalePaymentDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				Type type = typeof(dsSalePayments.tblSalePaymentRow);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsSalePayments/tblSalePaymentDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
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
				return new dsSalePayments.tblSalePaymentRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSalePayments.tblSalePaymentRow NewtblSalePaymentRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsSalePayments.tblSalePaymentRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsSalePayments/tblSalePaymentDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsSalePayments/tblSalePaymentDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsSalePayments/tblSalePaymentDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsSalePayments/tblSalePaymentDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			public void RemovetblSalePaymentRow(dsSalePayments.tblSalePaymentRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblSalePaymentRowChangedEvent, obj);
					this.tblSalePaymentRowChangedEvent = (dsSalePayments.tblSalePaymentRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblSalePaymentRowChangedEvent, obj);
					this.tblSalePaymentRowChangedEvent = (dsSalePayments.tblSalePaymentRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.tblSalePaymentRowChangingEvent += obj;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblSalePaymentRowChangingEvent, obj);
					this.tblSalePaymentRowChangingEvent = (dsSalePayments.tblSalePaymentRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.tblSalePaymentRowDeletedEvent += obj;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblSalePaymentRowDeletedEvent, obj);
					this.tblSalePaymentRowDeletedEvent = (dsSalePayments.tblSalePaymentRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSalePayments.tblSalePaymentRowChangeEventHandler tblSalePaymentRowDeleting;
		}

		public class tblSalePaymentRow : DataRow
		{
			private dsSalePayments.tblSalePaymentDataTable cb1ad63790ac2a0466de980fcaa9de1d2;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double Amount
			{
				get
				{
					double num;
					try
					{
						DataColumn amountColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.AmountColumn;
						object item = this[amountColumn];
						double num1 = Conversions.ToDouble(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5186);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.AmountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string AuthNum
			{
				get
				{
					string str;
					try
					{
						DataColumn authNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.AuthNumColumn;
						object item = this[authNumColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x520c), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.AuthNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bSwiped
			{
				get
				{
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.bSwipedColumn;
					object item = this[dataColumn];
					return Conversions.ToBoolean(item);
				}
				set
				{
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.bSwipedColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double CashValue
			{
				get
				{
					object item = this[this.cb1ad63790ac2a0466de980fcaa9de1d2.CashValueColumn];
					return Conversions.ToDouble(item);
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.CashValueColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CCType
			{
				get
				{
					DataColumn cCTypeColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.CCTypeColumn;
					object item = this[cCTypeColumn];
					return Conversions.ToString(item);
				}
				set
				{
					DataColumn cCTypeColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.CCTypeColumn;
					this[cCTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Expiry
			{
				get
				{
					string str;
					try
					{
						DataColumn expiryColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ExpiryColumn;
						object item = this[expiryColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5100);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn expiryColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ExpiryColumn;
					this[expiryColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string GiftNum
			{
				get
				{
					string str;
					try
					{
						DataColumn giftNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.GiftNumColumn;
						object item = this[giftNumColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5294);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn giftNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.GiftNumColumn;
					this[giftNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string InvNum
			{
				get
				{
					DataColumn invNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.InvNumColumn;
					object item = this[invNumColumn];
					string str = Conversions.ToString(item);
					return str;
				}
				set
				{
					DataColumn invNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.InvNumColumn;
					this[invNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NameOnCard
			{
				get
				{
					string str;
					try
					{
						DataColumn nameOnCardColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.NameOnCardColumn;
						string str1 = Conversions.ToString(this[nameOnCardColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x531c), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn nameOnCardColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.NameOnCardColumn;
					this[nameOnCardColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ReferenceNum
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cb1ad63790ac2a0466de980fcaa9de1d2.ReferenceNumColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x506e);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn referenceNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ReferenceNumColumn;
					this[referenceNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string RefNum
			{
				get
				{
					DataColumn refNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.RefNumColumn;
					object item = this[refNumColumn];
					string str = Conversions.ToString(item);
					return str;
				}
				set
				{
					DataColumn refNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.RefNumColumn;
					this[refNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Response
			{
				get
				{
					string str;
					try
					{
						DataColumn responseColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ResponseColumn;
						string str1 = Conversions.ToString(this[responseColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x53aa), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.ResponseColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Result
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cb1ad63790ac2a0466de980fcaa9de1d2.ResultColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x54ba);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.ResultColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tempCCNUM
			{
				get
				{
					// 
					// Current member / type: System.String SqlLibrary.dsSalePayments/tblSalePaymentRow::get_tempCCNUM()
					// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
					// 
					// Product version: 2019.1.118.0
					// Exception in: System.String get_tempCCNUM()
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
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCCNUMColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tempCVV
			{
				get
				{
					string str;
					try
					{
						DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCVVColumn;
						object item = this[dataColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5540);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCVVColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool tempDup
			{
				get
				{
					object item = this[this.cb1ad63790ac2a0466de980fcaa9de1d2.tempDupColumn];
					bool flag = Conversions.ToBoolean(item);
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempDupColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tempExp
			{
				get
				{
					string str;
					try
					{
						DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempExpColumn;
						object item = this[dataColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x55c8);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempExpColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tip
			{
				get
				{
					DataColumn tipColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.TipColumn;
					object item = this[tipColumn];
					decimal num = Conversions.ToDecimal(item);
					return num;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.TipColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TroutD
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cb1ad63790ac2a0466de980fcaa9de1d2.TroutDColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5434);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn troutDColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.TroutDColumn;
					this[troutDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Type
			{
				get
				{
					string str;
					try
					{
						DataColumn typeColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.TypeColumn;
						object item = this[typeColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fec), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cb1ad63790ac2a0466de980fcaa9de1d2.TypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblSalePaymentRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.cb1ad63790ac2a0466de980fcaa9de1d2 = (dsSalePayments.tblSalePaymentDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAmountNull()
			{
				DataColumn amountColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.AmountColumn;
				return this.IsNull(amountColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAuthNumNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.AuthNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsExpiryNull()
			{
				DataColumn expiryColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ExpiryColumn;
				bool flag = this.IsNull(expiryColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsGiftNumNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.GiftNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameOnCardNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.NameOnCardColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReferenceNumNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.ReferenceNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsResponseNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.ResponseColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsResultNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.ResultColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstempCCNUMNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCCNUMColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstempCVVNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCVVColumn;
				return this.IsNull(dataColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstempExpNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempExpColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTroutDNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.TroutDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTypeNull()
			{
				bool flag = this.IsNull(this.cb1ad63790ac2a0466de980fcaa9de1d2.TypeColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAmountNull()
			{
				DataColumn amountColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.AmountColumn;
				this[amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAuthNumNull()
			{
				DataColumn authNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.AuthNumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[authNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetExpiryNull()
			{
				DataColumn expiryColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ExpiryColumn;
				this[expiryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetGiftNumNull()
			{
				DataColumn giftNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.GiftNumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[giftNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameOnCardNull()
			{
				DataColumn nameOnCardColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.NameOnCardColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[nameOnCardColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReferenceNumNull()
			{
				DataColumn referenceNumColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ReferenceNumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[referenceNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetResponseNull()
			{
				DataColumn responseColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ResponseColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[responseColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetResultNull()
			{
				DataColumn resultColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.ResultColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[resultColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettempCCNUMNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCCNUMColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettempCVVNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempCVVColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettempExpNull()
			{
				DataColumn dataColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.tempExpColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTroutDNull()
			{
				this[this.cb1ad63790ac2a0466de980fcaa9de1d2.TroutDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTypeNull()
			{
				DataColumn typeColumn = this.cb1ad63790ac2a0466de980fcaa9de1d2.TypeColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[typeColumn] = objectValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tblSalePaymentRowChangeEvent : EventArgs
		{
			private dsSalePayments.tblSalePaymentRow c1cbccf2ba30b0268c407c29b056c2fdd;

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
			public dsSalePayments.tblSalePaymentRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblSalePaymentRowChangeEvent(dsSalePayments.tblSalePaymentRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tblSalePaymentRowChangeEventHandler(object sender, dsSalePayments.tblSalePaymentRowChangeEvent e);
	}
}