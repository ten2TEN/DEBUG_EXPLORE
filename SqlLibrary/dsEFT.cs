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
	[XmlRoot("dsEFT")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dsEFT : DataSet
	{
		private dsEFT.tblEFTPaymentDataTable tabletblEFTPayment;

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
		public dsEFT.tblEFTPaymentDataTable tblEFTPayment
		{
			get
			{
				return this.tabletblEFTPayment;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsEFT()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			dsEFT _dsEFT = this;
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(_dsEFT.c70e3aced97d5cf7509794216755f6e5d);
			DataTableCollection tables = base.Tables;
			tables.CollectionChanged += collectionChangeEventHandler;
			DataRelationCollection relations = base.Relations;
			relations.CollectionChanged += collectionChangeEventHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsEFT(SerializationInfo info, StreamingContext context)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsEFT::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
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
		private bool c7dbc0c3771c0a89a54909c2f68c64517()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void ce9285e807b6d3d13062294184142fedb()
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3076);
			this.DataSetName = str;
			this.Prefix = "";
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3081);
			this.Namespace = str1;
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tabletblEFTPayment = new dsEFT.tblEFTPaymentDataTable();
			base.Tables.Add(this.tabletblEFTPayment);
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
			// Current member / type: System.Void SqlLibrary.dsEFT::cfb93e8c2fa64f1123fa8988e476c2203(System.Boolean)
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
			DataSet dataSet = base.Clone();
			dsEFT _dsEFT = (dsEFT)dataSet;
			_dsEFT.cfb93e8c2fa64f1123fa8988e476c2203();
			System.Data.SchemaSerializationMode schemaSerializationMode = this.SchemaSerializationMode;
			_dsEFT.SchemaSerializationMode = schemaSerializationMode;
			return _dsEFT;
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
			// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsEFT::GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
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
			// Current member / type: System.Void SqlLibrary.dsEFT::ReadXmlSerializable(System.Xml.XmlReader)
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
		public class tblEFTPaymentDataTable : TypedTableBase<dsEFT.tblEFTPaymentRow>
		{
			private DataColumn columnClientID;

			private DataColumn columnClientName;

			private DataColumn columnPackageID;

			private DataColumn columnPackageName;

			private DataColumn columnCusPackageID;

			private DataColumn columnCusPackageName;

			private DataColumn columndtDue;

			private DataColumn columnAmount;

			private DataColumn columnTax1;

			private DataColumn columnTax2;

			private DataColumn columnTax3;

			private DataColumn columnbProcessed;

			private DataColumn columnSalesID;

			private DataColumn columnStatus;

			private DataColumn columndtPackageExpire;

			private dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowChangingEvent;

			private dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowChangedEvent;

			private dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowDeletingEvent;

			private dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowDeletedEvent;

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
			public DataColumn bProcessedColumn
			{
				get
				{
					return this.columnbProcessed;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ClientNameColumn
			{
				get
				{
					return this.columnClientName;
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
					return rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CusPackageIDColumn
			{
				get
				{
					return this.columnCusPackageID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CusPackageNameColumn
			{
				get
				{
					return this.columnCusPackageName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtDueColumn
			{
				get
				{
					return this.columndtDue;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtPackageExpireColumn
			{
				get
				{
					return this.columndtPackageExpire;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsEFT.tblEFTPaymentRow this[int index]
			{
				get
				{
					DataRow item = this.Rows[index];
					return (dsEFT.tblEFTPaymentRow)item;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PackageIDColumn
			{
				get
				{
					return this.columnPackageID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PackageNameColumn
			{
				get
				{
					return this.columnPackageName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SalesIDColumn
			{
				get
				{
					return this.columnSalesID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn StatusColumn
			{
				get
				{
					return this.columnStatus;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tax1Column
			{
				get
				{
					return this.columnTax1;
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
			public DataColumn Tax3Column
			{
				get
				{
					return this.columnTax3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblEFTPaymentDataTable()
			{
				this.TableName = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x305b);
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblEFTPaymentDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsEFT/tblEFTPaymentDataTable::.ctor(System.Data.DataTable)
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
			protected tblEFTPaymentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtblEFTPaymentRow(dsEFT.tblEFTPaymentRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsEFT.tblEFTPaymentRow AddtblEFTPaymentRow(string ClientID, string ClientName, int PackageID, string PackageName, int CusPackageID, string CusPackageName, DateTime dtDue, decimal Amount, decimal Tax1, decimal Tax2, decimal Tax3, bool bProcessed, int SalesID, string Status, DateTime dtPackageExpire)
			{
				DataRow dataRow = this.NewRow();
				dsEFT.tblEFTPaymentRow _tblEFTPaymentRow = (dsEFT.tblEFTPaymentRow)dataRow;
				object[] clientID = new object[] { ClientID, ClientName, PackageID, PackageName, CusPackageID, CusPackageName, dtDue, Amount, Tax1, Tax2, Tax3, bProcessed, SalesID, Status, dtPackageExpire };
				_tblEFTPaymentRow.ItemArray = clientID;
				DataRowCollection rows = this.Rows;
				rows.Add(_tblEFTPaymentRow);
				return _tblEFTPaymentRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30ba);
				Type type = typeof(string);
				this.columnClientID = new DataColumn(str, type, null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnClientID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30cb);
				Type type1 = typeof(string);
				this.columnClientName = new DataColumn(str1, type1, null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnClientName);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30e0);
				Type type2 = typeof(int);
				this.columnPackageID = new DataColumn(str2, type2, null, MappingType.Element);
				base.Columns.Add(this.columnPackageID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30f3);
				Type type3 = typeof(string);
				this.columnPackageName = new DataColumn(str3, type3, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnPackageName);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x310a);
				Type type4 = typeof(int);
				this.columnCusPackageID = new DataColumn(str4, type4, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnCusPackageID);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3123);
				Type type5 = typeof(string);
				this.columnCusPackageName = new DataColumn(str5, type5, null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnCusPackageName);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3140);
				this.columndtDue = new DataColumn(str6, typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndtDue);
				this.columnAmount = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x314b), typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3158);
				Type type6 = typeof(decimal);
				this.columnTax1 = new DataColumn(str7, type6, null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnTax1);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3161);
				this.columnTax2 = new DataColumn(str8, typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnTax2);
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x316a);
				this.columnTax3 = new DataColumn(str9, typeof(decimal), null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnTax3);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3173);
				Type type7 = typeof(bool);
				this.columnbProcessed = new DataColumn(str10, type7, null, MappingType.Element);
				base.Columns.Add(this.columnbProcessed);
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3188);
				Type type8 = typeof(int);
				this.columnSalesID = new DataColumn(str11, type8, null, MappingType.Element);
				DataColumnCollection dataColumnCollection3 = base.Columns;
				dataColumnCollection3.Add(this.columnSalesID);
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3197);
				this.columnStatus = new DataColumn(str12, typeof(string), null, MappingType.Element);
				DataColumnCollection columns4 = base.Columns;
				columns4.Add(this.columnStatus);
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x31a4);
				Type type9 = typeof(DateTime);
				this.columndtPackageExpire = new DataColumn(str13, type9, null, MappingType.Element);
				DataColumnCollection dataColumnCollection4 = base.Columns;
				dataColumnCollection4.Add(this.columndtPackageExpire);
				this.columnPackageID.AllowDBNull = false;
				this.columnCusPackageID.AllowDBNull = false;
				this.columnAmount.AllowDBNull = false;
				this.columnAmount.DefaultValue = decimal.Zero;
				this.columnTax1.AllowDBNull = false;
				this.columnTax1.DefaultValue = decimal.Zero;
				this.columnTax2.AllowDBNull = false;
				this.columnTax2.DefaultValue = decimal.Zero;
				this.columnTax3.AllowDBNull = false;
				this.columnTax3.DefaultValue = decimal.Zero;
				this.columnbProcessed.DefaultValue = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30ba);
				this.columnClientID = columns[str];
				DataColumnCollection dataColumnCollection = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30cb);
				DataColumn item = dataColumnCollection[str1];
				this.columnClientName = item;
				DataColumnCollection columns1 = base.Columns;
				this.columnPackageID = columns1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30e0)];
				DataColumnCollection dataColumnCollection1 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x30f3);
				DataColumn dataColumn = dataColumnCollection1[str2];
				this.columnPackageName = dataColumn;
				DataColumnCollection columns2 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x310a);
				DataColumn item1 = columns2[str3];
				this.columnCusPackageID = item1;
				DataColumnCollection dataColumnCollection2 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3123);
				this.columnCusPackageName = dataColumnCollection2[str4];
				DataColumnCollection columns3 = base.Columns;
				DataColumn dataColumn1 = columns3[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3140)];
				this.columndtDue = dataColumn1;
				DataColumnCollection dataColumnCollection3 = base.Columns;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x314b);
				DataColumn item2 = dataColumnCollection3[str5];
				this.columnAmount = item2;
				DataColumnCollection columns4 = base.Columns;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3158);
				DataColumn dataColumn2 = columns4[str6];
				this.columnTax1 = dataColumn2;
				DataColumnCollection dataColumnCollection4 = base.Columns;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3161);
				DataColumn item3 = dataColumnCollection4[str7];
				this.columnTax2 = item3;
				DataColumnCollection columns5 = base.Columns;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x316a);
				DataColumn dataColumn3 = columns5[str8];
				this.columnTax3 = dataColumn3;
				DataColumnCollection dataColumnCollection5 = base.Columns;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3173);
				this.columnbProcessed = dataColumnCollection5[str9];
				DataColumnCollection columns6 = base.Columns;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3188);
				DataColumn item4 = columns6[str10];
				this.columnSalesID = item4;
				DataColumnCollection dataColumnCollection6 = base.Columns;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3197);
				DataColumn dataColumn4 = dataColumnCollection6[str11];
				this.columnStatus = dataColumn4;
				DataColumnCollection columns7 = base.Columns;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x31a4);
				DataColumn item5 = columns7[str12];
				this.columndtPackageExpire = item5;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsEFT.tblEFTPaymentDataTable _tblEFTPaymentDataTable = (dsEFT.tblEFTPaymentDataTable)dataTable;
				_tblEFTPaymentDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return _tblEFTPaymentDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsEFT.tblEFTPaymentDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				Type type = typeof(dsEFT.tblEFTPaymentRow);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsEFT/tblEFTPaymentDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
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
				return new dsEFT.tblEFTPaymentRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsEFT.tblEFTPaymentRow NewtblEFTPaymentRow()
			{
				return (dsEFT.tblEFTPaymentRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsEFT/tblEFTPaymentDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsEFT/tblEFTPaymentDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsEFT/tblEFTPaymentDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsEFT/tblEFTPaymentDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			public void RemovetblEFTPaymentRow(dsEFT.tblEFTPaymentRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblEFTPaymentRowChangedEvent, obj);
					this.tblEFTPaymentRowChangedEvent = (dsEFT.tblEFTPaymentRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.tblEFTPaymentRowChangedEvent -= obj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.tblEFTPaymentRowChangingEvent += obj;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblEFTPaymentRowChangingEvent, obj);
					this.tblEFTPaymentRowChangingEvent = (dsEFT.tblEFTPaymentRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblEFTPaymentRowDeletedEvent, obj);
					this.tblEFTPaymentRowDeletedEvent = (dsEFT.tblEFTPaymentRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblEFTPaymentRowDeletedEvent, obj);
					this.tblEFTPaymentRowDeletedEvent = (dsEFT.tblEFTPaymentRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsEFT.tblEFTPaymentRowChangeEventHandler tblEFTPaymentRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblEFTPaymentRowDeletingEvent, obj);
					this.tblEFTPaymentRowDeletingEvent = (dsEFT.tblEFTPaymentRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.tblEFTPaymentRowDeletingEvent -= obj;
				}
			}
		}

		public class tblEFTPaymentRow : DataRow
		{
			private dsEFT.tblEFTPaymentDataTable c4a7da2a9cd7292a6a170c20eb7745537;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Amount
			{
				get
				{
					object item = this[this.c4a7da2a9cd7292a6a170c20eb7745537.AmountColumn];
					decimal num = Conversions.ToDecimal(item);
					return num;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.AmountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bProcessed
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.bProcessedColumn;
						flag = Conversions.ToBoolean(this[dataColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x34a8), invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.bProcessedColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ClientID
			{
				get
				{
					string str;
					try
					{
						DataColumn clientIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientIDColumn;
						object item = this[clientIDColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x31f0);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn clientIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientIDColumn;
					this[clientIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ClientName
			{
				get
				{
					string str;
					try
					{
						DataColumn clientNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientNameColumn;
						string str1 = Conversions.ToString(this[clientNameColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3278);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn clientNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientNameColumn;
					this[clientNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int CusPackageID
			{
				get
				{
					DataColumn cusPackageIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageIDColumn;
					object item = this[cusPackageIDColumn];
					int integer = Conversions.ToInteger(item);
					return integer;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CusPackageName
			{
				get
				{
					string str;
					try
					{
						object item = this[this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageNameColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3392), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn cusPackageNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageNameColumn;
					this[cusPackageNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtDue
			{
				get
				{
					DateTime dateTime;
					try
					{
						DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtDueColumn;
						DateTime date = Conversions.ToDate(this[dataColumn]);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3426), invalidCastException);
					}
					return dateTime;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.dtDueColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtPackageExpire
			{
				get
				{
					DateTime dateTime;
					try
					{
						DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtPackageExpireColumn;
						object item = this[dataColumn];
						DateTime date = Conversions.ToDate(item);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x363e);
						throw new StrongTypingException(str, invalidCastException);
					}
					return dateTime;
				}
				set
				{
					DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtPackageExpireColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int PackageID
			{
				get
				{
					object item = this[this.c4a7da2a9cd7292a6a170c20eb7745537.PackageIDColumn];
					int integer = Conversions.ToInteger(item);
					return integer;
				}
				set
				{
					DataColumn packageIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.PackageIDColumn;
					this[packageIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PackageName
			{
				get
				{
					string str;
					try
					{
						DataColumn packageNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.PackageNameColumn;
						object item = this[packageNameColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3304);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.PackageNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int SalesID
			{
				get
				{
					int num;
					try
					{
						DataColumn salesIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.SalesIDColumn;
						int integer = Conversions.ToInteger(this[salesIDColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3534);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.SalesIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Status
			{
				get
				{
					string str;
					try
					{
						DataColumn statusColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.StatusColumn;
						object item = this[statusColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x35ba);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.c4a7da2a9cd7292a6a170c20eb7745537.StatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax1
			{
				get
				{
					DataColumn tax1Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax1Column;
					object item = this[tax1Column];
					decimal num = Conversions.ToDecimal(item);
					return num;
				}
				set
				{
					DataColumn tax1Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax1Column;
					this[tax1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax2
			{
				get
				{
					DataColumn tax2Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax2Column;
					object item = this[tax2Column];
					decimal num = Conversions.ToDecimal(item);
					return num;
				}
				set
				{
					DataColumn tax2Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax2Column;
					this[tax2Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Tax3
			{
				get
				{
					DataColumn tax3Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax3Column;
					object item = this[tax3Column];
					return Conversions.ToDecimal(item);
				}
				set
				{
					DataColumn tax3Column = this.c4a7da2a9cd7292a6a170c20eb7745537.Tax3Column;
					this[tax3Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblEFTPaymentRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.c4a7da2a9cd7292a6a170c20eb7745537 = (dsEFT.tblEFTPaymentDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbProcessedNull()
			{
				DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.bProcessedColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsClientIDNull()
			{
				DataColumn clientIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientIDColumn;
				bool flag = this.IsNull(clientIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsClientNameNull()
			{
				DataColumn clientNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientNameColumn;
				return this.IsNull(clientNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCusPackageNameNull()
			{
				DataColumn cusPackageNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageNameColumn;
				bool flag = this.IsNull(cusPackageNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtDueNull()
			{
				DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtDueColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtPackageExpireNull()
			{
				DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtPackageExpireColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPackageNameNull()
			{
				return this.IsNull(this.c4a7da2a9cd7292a6a170c20eb7745537.PackageNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSalesIDNull()
			{
				DataColumn salesIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.SalesIDColumn;
				bool flag = this.IsNull(salesIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsStatusNull()
			{
				DataColumn statusColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.StatusColumn;
				return this.IsNull(statusColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbProcessedNull()
			{
				DataColumn objectValue = this.c4a7da2a9cd7292a6a170c20eb7745537.bProcessedColumn;
				this[objectValue] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClientIDNull()
			{
				DataColumn clientIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClientNameNull()
			{
				DataColumn clientNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.ClientNameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCusPackageNameNull()
			{
				DataColumn cusPackageNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.CusPackageNameColumn;
				this[cusPackageNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtDueNull()
			{
				DataColumn objectValue = this.c4a7da2a9cd7292a6a170c20eb7745537.dtDueColumn;
				this[objectValue] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtPackageExpireNull()
			{
				DataColumn dataColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.dtPackageExpireColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPackageNameNull()
			{
				DataColumn packageNameColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.PackageNameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[packageNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSalesIDNull()
			{
				DataColumn salesIDColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.SalesIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[salesIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetStatusNull()
			{
				DataColumn statusColumn = this.c4a7da2a9cd7292a6a170c20eb7745537.StatusColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[statusColumn] = objectValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tblEFTPaymentRowChangeEvent : EventArgs
		{
			private dsEFT.tblEFTPaymentRow c1cbccf2ba30b0268c407c29b056c2fdd;

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
			public dsEFT.tblEFTPaymentRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblEFTPaymentRowChangeEvent(dsEFT.tblEFTPaymentRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tblEFTPaymentRowChangeEventHandler(object sender, dsEFT.tblEFTPaymentRowChangeEvent e);
	}
}