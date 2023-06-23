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
	[XmlRoot("dsAppointment")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dsAppointment : DataSet
	{
		private dsAppointment.tblAppointmentsDataTable tabletblAppointments;

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
				return base.Tables;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsAppointment.tblAppointmentsDataTable tblAppointments
		{
			get
			{
				return this.tabletblAppointments;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsAppointment()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			dsAppointment _dsAppointment = this;
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(_dsAppointment.c70e3aced97d5cf7509794216755f6e5d);
			DataTableCollection tables = base.Tables;
			tables.CollectionChanged += collectionChangeEventHandler;
			DataRelationCollection relations = base.Relations;
			relations.CollectionChanged += collectionChangeEventHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsAppointment(SerializationInfo info, StreamingContext context)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsAppointment::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
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
		private bool c162346998d4df40b2fcff4d2263ade9e()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void c70e3aced97d5cf7509794216755f6e5d(object cf7d8a347db4ec9aed6c0c9437e4edbb6, CollectionChangeEventArgs c38331f058065b55f8ef1950a745341e0)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsAppointment::c70e3aced97d5cf7509794216755f6e5d(System.Object,System.ComponentModel.CollectionChangeEventArgs)
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
		private void ce9285e807b6d3d13062294184142fedb()
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(32);
			this.DataSetName = str;
			this.Prefix = "";
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(59);
			this.Namespace = str1;
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tabletblAppointments = new dsAppointment.tblAppointmentsDataTable();
			DataTableCollection tables = base.Tables;
			tables.Add(this.tabletblAppointments);
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
			// Current member / type: System.Void SqlLibrary.dsAppointment::cfb93e8c2fa64f1123fa8988e476c2203(System.Boolean)
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
			dsAppointment schemaSerializationMode = (dsAppointment)dataSet;
			schemaSerializationMode.cfb93e8c2fa64f1123fa8988e476c2203();
			schemaSerializationMode.SchemaSerializationMode = this.SchemaSerializationMode;
			return schemaSerializationMode;
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
			// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsAppointment::GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
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
			// Current member / type: System.Void SqlLibrary.dsAppointment::ReadXmlSerializable(System.Xml.XmlReader)
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
		public class tblAppointmentsDataTable : TypedTableBase<dsAppointment.tblAppointmentsRow>
		{
			private DataColumn columnID;

			private DataColumn columnStart_Date;

			private DataColumn columnLength;

			private DataColumn columnblockout;

			private DataColumn columnIsEvent;

			private DataColumn columnIsFlagged;

			private DataColumn columnIsReadonly;

			private DataColumn columnMaxLength;

			private DataColumn columnMinLength;

			private DataColumn columnNotes;

			private DataColumn columnPriority;

			private DataColumn columnRecurrence_GUID;

			private DataColumn columnRoom_Number;

			private DataColumn columnBed_ID;

			private DataColumn columnSubject;

			private DataColumn columnAlarm_Is_Armed;

			private DataColumn columnAlarm_Reminder;

			private DataColumn columnAlarm_Allow_Open;

			private DataColumn columnAlarm_Allow_Snooze;

			private DataColumn columnAlarm_Was_Dismissed;

			private DataColumn columnclient_ID;

			private DataColumn columnbUsed;

			private DataColumn columnClient_Name;

			private DataColumn columnLoc_Num;

			private DataColumn columnName;

			private dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowChangingEvent;

			private dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowChangedEvent;

			private dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowDeletingEvent;

			private dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowDeletedEvent;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Alarm_Allow_OpenColumn
			{
				get
				{
					return this.columnAlarm_Allow_Open;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Alarm_Allow_SnoozeColumn
			{
				get
				{
					return this.columnAlarm_Allow_Snooze;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Alarm_Is_ArmedColumn
			{
				get
				{
					return this.columnAlarm_Is_Armed;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Alarm_ReminderColumn
			{
				get
				{
					return this.columnAlarm_Reminder;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Alarm_Was_DismissedColumn
			{
				get
				{
					return this.columnAlarm_Was_Dismissed;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Bed_IDColumn
			{
				get
				{
					return this.columnBed_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn blockoutColumn
			{
				get
				{
					return this.columnblockout;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bUsedColumn
			{
				get
				{
					return this.columnbUsed;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn client_IDColumn
			{
				get
				{
					return this.columnclient_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Client_NameColumn
			{
				get
				{
					return this.columnClient_Name;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					int count = this.Rows.Count;
					return count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsEventColumn
			{
				get
				{
					return this.columnIsEvent;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsFlaggedColumn
			{
				get
				{
					return this.columnIsFlagged;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsReadonlyColumn
			{
				get
				{
					return this.columnIsReadonly;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsAppointment.tblAppointmentsRow this[int index]
			{
				get
				{
					DataRowCollection rows = this.Rows;
					DataRow item = rows[index];
					return (dsAppointment.tblAppointmentsRow)item;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn LengthColumn
			{
				get
				{
					return this.columnLength;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Loc_NumColumn
			{
				get
				{
					return this.columnLoc_Num;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MaxLengthColumn
			{
				get
				{
					return this.columnMaxLength;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MinLengthColumn
			{
				get
				{
					return this.columnMinLength;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NotesColumn
			{
				get
				{
					return this.columnNotes;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PriorityColumn
			{
				get
				{
					return this.columnPriority;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Recurrence_GUIDColumn
			{
				get
				{
					return this.columnRecurrence_GUID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Room_NumberColumn
			{
				get
				{
					return this.columnRoom_Number;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Start_DateColumn
			{
				get
				{
					return this.columnStart_Date;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SubjectColumn
			{
				get
				{
					return this.columnSubject;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblAppointmentsDataTable()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(1);
				this.TableName = str;
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblAppointmentsDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsAppointment/tblAppointmentsDataTable::.ctor(System.Data.DataTable)
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
			protected tblAppointmentsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtblAppointmentsRow(dsAppointment.tblAppointmentsRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsAppointment.tblAppointmentsRow AddtblAppointmentsRow(int ID, DateTime Start_Date, int Length, bool blockout, bool IsEvent, bool IsFlagged, bool IsReadonly, int MaxLength, int MinLength, string Notes, int Priority, string Recurrence_GUID, int Room_Number, int Bed_ID, string Subject, bool Alarm_Is_Armed, int Alarm_Reminder, bool Alarm_Allow_Open, bool Alarm_Allow_Snooze, bool Alarm_Was_Dismissed, int client_ID, bool bUsed, string Client_Name, int Loc_Num, string Name)
			{
				DataRow dataRow = this.NewRow();
				dsAppointment.tblAppointmentsRow _tblAppointmentsRow = (dsAppointment.tblAppointmentsRow)dataRow;
				object[] d = new object[] { ID, Start_Date, Length, blockout, IsEvent, IsFlagged, IsReadonly, MaxLength, MinLength, Notes, Priority, Recurrence_GUID, Room_Number, Bed_ID, Subject, Alarm_Is_Armed, Alarm_Reminder, Alarm_Allow_Open, Alarm_Allow_Snooze, Alarm_Was_Dismissed, client_ID, bUsed, Client_Name, Loc_Num, Name };
				_tblAppointmentsRow.ItemArray = d;
				DataRowCollection rows = this.Rows;
				rows.Add(_tblAppointmentsRow);
				return _tblAppointmentsRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(151);
				Type type = typeof(int);
				this.columnID = new DataColumn(str, type, null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnID);
				this.columnStart_Date = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(156), typeof(DateTime), null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnStart_Date);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(177);
				Type type1 = typeof(int);
				this.columnLength = new DataColumn(str1, type1, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnLength);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(190);
				Type type2 = typeof(bool);
				this.columnblockout = new DataColumn(str2, type2, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnblockout);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(207);
				Type type3 = typeof(bool);
				this.columnIsEvent = new DataColumn(str3, type3, null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnIsEvent);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(222);
				this.columnIsFlagged = new DataColumn(str4, typeof(bool), null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnIsFlagged);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(241);
				this.columnIsReadonly = new DataColumn(str5, typeof(bool), null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnIsReadonly);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x106);
				Type type4 = typeof(int);
				this.columnMaxLength = new DataColumn(str6, type4, null, MappingType.Element);
				DataColumnCollection dataColumnCollection3 = base.Columns;
				dataColumnCollection3.Add(this.columnMaxLength);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119);
				Type type5 = typeof(int);
				this.columnMinLength = new DataColumn(str7, type5, null, MappingType.Element);
				DataColumnCollection columns4 = base.Columns;
				columns4.Add(this.columnMinLength);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12c);
				this.columnNotes = new DataColumn(str8, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNotes);
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x137);
				Type type6 = typeof(int);
				this.columnPriority = new DataColumn(str9, type6, null, MappingType.Element);
				base.Columns.Add(this.columnPriority);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x148);
				Type type7 = typeof(string);
				this.columnRecurrence_GUID = new DataColumn(str10, type7, null, MappingType.Element);
				DataColumnCollection dataColumnCollection4 = base.Columns;
				dataColumnCollection4.Add(this.columnRecurrence_GUID);
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x167);
				Type type8 = typeof(int);
				this.columnRoom_Number = new DataColumn(str11, type8, null, MappingType.Element);
				DataColumnCollection columns5 = base.Columns;
				columns5.Add(this.columnRoom_Number);
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17e);
				Type type9 = typeof(int);
				this.columnBed_ID = new DataColumn(str12, type9, null, MappingType.Element);
				DataColumnCollection dataColumnCollection5 = base.Columns;
				dataColumnCollection5.Add(this.columnBed_ID);
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x18b);
				Type type10 = typeof(string);
				this.columnSubject = new DataColumn(str13, type10, null, MappingType.Element);
				base.Columns.Add(this.columnSubject);
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19a);
				Type type11 = typeof(bool);
				this.columnAlarm_Is_Armed = new DataColumn(str14, type11, null, MappingType.Element);
				DataColumnCollection columns6 = base.Columns;
				columns6.Add(this.columnAlarm_Is_Armed);
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1b7);
				Type type12 = typeof(int);
				this.columnAlarm_Reminder = new DataColumn(str15, type12, null, MappingType.Element);
				DataColumnCollection dataColumnCollection6 = base.Columns;
				dataColumnCollection6.Add(this.columnAlarm_Reminder);
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d4);
				this.columnAlarm_Allow_Open = new DataColumn(str16, typeof(bool), null, MappingType.Element);
				DataColumnCollection columns7 = base.Columns;
				columns7.Add(this.columnAlarm_Allow_Open);
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f5);
				Type type13 = typeof(bool);
				this.columnAlarm_Allow_Snooze = new DataColumn(str17, type13, null, MappingType.Element);
				DataColumnCollection dataColumnCollection7 = base.Columns;
				dataColumnCollection7.Add(this.columnAlarm_Allow_Snooze);
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21a);
				Type type14 = typeof(bool);
				this.columnAlarm_Was_Dismissed = new DataColumn(str18, type14, null, MappingType.Element);
				base.Columns.Add(this.columnAlarm_Was_Dismissed);
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x241);
				Type type15 = typeof(int);
				this.columnclient_ID = new DataColumn(str19, type15, null, MappingType.Element);
				base.Columns.Add(this.columnclient_ID);
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x254);
				this.columnbUsed = new DataColumn(str20, typeof(bool), null, MappingType.Element);
				DataColumnCollection columns8 = base.Columns;
				columns8.Add(this.columnbUsed);
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x25f);
				Type type16 = typeof(string);
				this.columnClient_Name = new DataColumn(str21, type16, null, MappingType.Element);
				DataColumnCollection dataColumnCollection8 = base.Columns;
				dataColumnCollection8.Add(this.columnClient_Name);
				this.columnLoc_Num = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x276), typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnLoc_Num);
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x285);
				Type type17 = typeof(string);
				this.columnName = new DataColumn(str22, type17, null, MappingType.Element);
				DataColumnCollection columns9 = base.Columns;
				columns9.Add(this.columnName);
				this.columnID.AllowDBNull = false;
				this.columnStart_Date.AllowDBNull = false;
				this.columnLength.AllowDBNull = false;
				DataColumn columnClientName = this.columnClient_Name;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28e);
				columnClientName.DefaultValue = str23;
				this.columnName.DefaultValue = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x293);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(151);
				DataColumn item = columns[str];
				this.columnID = item;
				DataColumnCollection dataColumnCollection = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(156);
				DataColumn dataColumn = dataColumnCollection[str1];
				this.columnStart_Date = dataColumn;
				DataColumnCollection columns1 = base.Columns;
				DataColumn item1 = columns1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(177)];
				this.columnLength = item1;
				DataColumnCollection dataColumnCollection1 = base.Columns;
				DataColumn dataColumn1 = dataColumnCollection1[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(190)];
				this.columnblockout = dataColumn1;
				DataColumnCollection columns2 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(207);
				DataColumn item2 = columns2[str2];
				this.columnIsEvent = item2;
				DataColumnCollection dataColumnCollection2 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(222);
				DataColumn dataColumn2 = dataColumnCollection2[str3];
				this.columnIsFlagged = dataColumn2;
				DataColumnCollection columns3 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(241);
				this.columnIsReadonly = columns3[str4];
				DataColumnCollection dataColumnCollection3 = base.Columns;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x106);
				DataColumn item3 = dataColumnCollection3[str5];
				this.columnMaxLength = item3;
				DataColumnCollection columns4 = base.Columns;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119);
				DataColumn dataColumn3 = columns4[str6];
				this.columnMinLength = dataColumn3;
				DataColumnCollection dataColumnCollection4 = base.Columns;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12c);
				DataColumn item4 = dataColumnCollection4[str7];
				this.columnNotes = item4;
				DataColumn dataColumn4 = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x137)];
				this.columnPriority = dataColumn4;
				DataColumnCollection columns5 = base.Columns;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x148);
				DataColumn item5 = columns5[str8];
				this.columnRecurrence_GUID = item5;
				DataColumnCollection dataColumnCollection5 = base.Columns;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x167);
				this.columnRoom_Number = dataColumnCollection5[str9];
				DataColumnCollection columns6 = base.Columns;
				DataColumn dataColumn5 = columns6[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17e)];
				this.columnBed_ID = dataColumn5;
				DataColumnCollection dataColumnCollection6 = base.Columns;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x18b);
				DataColumn item6 = dataColumnCollection6[str10];
				this.columnSubject = item6;
				DataColumnCollection columns7 = base.Columns;
				DataColumn dataColumn6 = columns7[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19a)];
				this.columnAlarm_Is_Armed = dataColumn6;
				DataColumnCollection dataColumnCollection7 = base.Columns;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1b7);
				DataColumn item7 = dataColumnCollection7[str11];
				this.columnAlarm_Reminder = item7;
				DataColumnCollection columns8 = base.Columns;
				DataColumn dataColumn7 = columns8[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d4)];
				this.columnAlarm_Allow_Open = dataColumn7;
				DataColumnCollection dataColumnCollection8 = base.Columns;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f5);
				this.columnAlarm_Allow_Snooze = dataColumnCollection8[str12];
				DataColumnCollection columns9 = base.Columns;
				this.columnAlarm_Was_Dismissed = columns9[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x21a)];
				DataColumnCollection dataColumnCollection9 = base.Columns;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x241);
				DataColumn item8 = dataColumnCollection9[str13];
				this.columnclient_ID = item8;
				DataColumnCollection columns10 = base.Columns;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x254);
				this.columnbUsed = columns10[str14];
				DataColumnCollection dataColumnCollection10 = base.Columns;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x25f);
				DataColumn dataColumn8 = dataColumnCollection10[str15];
				this.columnClient_Name = dataColumn8;
				DataColumn item9 = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x276)];
				this.columnLoc_Num = item9;
				DataColumnCollection columns11 = base.Columns;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x285);
				DataColumn dataColumn9 = columns11[str16];
				this.columnName = dataColumn9;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsAppointment.tblAppointmentsDataTable _tblAppointmentsDataTable = (dsAppointment.tblAppointmentsDataTable)dataTable;
				_tblAppointmentsDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return _tblAppointmentsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsAppointment.tblAppointmentsDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				Type type = typeof(dsAppointment.tblAppointmentsRow);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsAppointment/tblAppointmentsDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
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
				return new dsAppointment.tblAppointmentsRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsAppointment.tblAppointmentsRow NewtblAppointmentsRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsAppointment.tblAppointmentsRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsAppointment/tblAppointmentsDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				base.OnRowChanging(e);
				if (this.tblAppointmentsRowChangingEvent != null)
				{
					dsAppointment.tblAppointmentsRowChangeEventHandler _tblAppointmentsRowChangeEventHandler = this.tblAppointmentsRowChangingEvent;
					if (_tblAppointmentsRowChangeEventHandler != null)
					{
						DataRow row = e.Row;
						dsAppointment.tblAppointmentsRow _tblAppointmentsRow = (dsAppointment.tblAppointmentsRow)row;
						DataRowAction action = e.Action;
						_tblAppointmentsRowChangeEventHandler(this, new dsAppointment.tblAppointmentsRowChangeEvent(_tblAppointmentsRow, action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsAppointment/tblAppointmentsDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsAppointment/tblAppointmentsDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			public void RemovetblAppointmentsRow(dsAppointment.tblAppointmentsRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblAppointmentsRowChangedEvent, obj);
					this.tblAppointmentsRowChangedEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.tblAppointmentsRowChangedEvent -= obj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblAppointmentsRowChangingEvent, obj);
					this.tblAppointmentsRowChangingEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblAppointmentsRowChangingEvent, obj);
					this.tblAppointmentsRowChangingEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblAppointmentsRowDeletedEvent, obj);
					this.tblAppointmentsRowDeletedEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblAppointmentsRowDeletedEvent, obj);
					this.tblAppointmentsRowDeletedEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsAppointment.tblAppointmentsRowChangeEventHandler tblAppointmentsRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.tblAppointmentsRowDeletingEvent, obj);
					this.tblAppointmentsRowDeletingEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.tblAppointmentsRowDeletingEvent, obj);
					this.tblAppointmentsRowDeletingEvent = (dsAppointment.tblAppointmentsRowChangeEventHandler)@delegate;
				}
			}
		}

		public class tblAppointmentsRow : DataRow
		{
			private dsAppointment.tblAppointmentsDataTable cf941950a7c7a817be59cb703be398f51;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Alarm_Allow_Open
			{
				get
				{
					bool flag;
					try
					{
						DataColumn alarmAllowOpenColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_OpenColumn;
						object item = this[alarmAllowOpenColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xb61);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_OpenColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Alarm_Allow_Snooze
			{
				get
				{
					bool flag;
					try
					{
						flag = Conversions.ToBoolean(this[this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_SnoozeColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xbfd);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn alarmAllowSnoozeColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_SnoozeColumn;
					this[alarmAllowSnoozeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Alarm_Is_Armed
			{
				get
				{
					bool flag;
					try
					{
						DataColumn alarmIsArmedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Is_ArmedColumn;
						bool flag1 = Conversions.ToBoolean(this[alarmIsArmedColumn]);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa31), invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn alarmIsArmedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Is_ArmedColumn;
					this[alarmIsArmedColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Alarm_Reminder
			{
				get
				{
					int num;
					try
					{
						DataColumn alarmReminderColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_ReminderColumn;
						int integer = Conversions.ToInteger(this[alarmReminderColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xac9), invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.Alarm_ReminderColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Alarm_Was_Dismissed
			{
				get
				{
					bool flag;
					try
					{
						DataColumn alarmWasDismissedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Was_DismissedColumn;
						flag = Conversions.ToBoolean(this[alarmWasDismissedColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc9d);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn alarmWasDismissedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Was_DismissedColumn;
					this[alarmWasDismissedColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Bed_ID
			{
				get
				{
					int num;
					try
					{
						DataColumn bedIDColumn = this.cf941950a7c7a817be59cb703be398f51.Bed_IDColumn;
						int integer = Conversions.ToInteger(this[bedIDColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x91f);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn bedIDColumn = this.cf941950a7c7a817be59cb703be398f51.Bed_IDColumn;
					this[bedIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool blockout
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.blockoutColumn;
						bool flag1 = Conversions.ToBoolean(this[dataColumn]);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x391);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.blockoutColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bUsed
			{
				get
				{
					bool flag;
					try
					{
						DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.bUsedColumn;
						object item = this[dataColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdcd);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.bUsedColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int client_ID
			{
				get
				{
					int num;
					try
					{
						DataColumn clientIDColumn = this.cf941950a7c7a817be59cb703be398f51.client_IDColumn;
						object item = this[clientIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd3f);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.client_IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Client_Name
			{
				get
				{
					string str;
					try
					{
						DataColumn clientNameColumn = this.cf941950a7c7a817be59cb703be398f51.Client_NameColumn;
						object item = this[clientNameColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe53);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.Client_NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ID
			{
				get
				{
					DataColumn dColumn = this.cf941950a7c7a817be59cb703be398f51.IDColumn;
					object item = this[dColumn];
					int integer = Conversions.ToInteger(item);
					return integer;
				}
				set
				{
					DataColumn dColumn = this.cf941950a7c7a817be59cb703be398f51.IDColumn;
					this[dColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEvent
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.cf941950a7c7a817be59cb703be398f51.IsEventColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x41d);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.IsEventColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFlagged
			{
				get
				{
					bool flag;
					try
					{
						DataColumn isFlaggedColumn = this.cf941950a7c7a817be59cb703be398f51.IsFlaggedColumn;
						bool flag1 = Conversions.ToBoolean(this[isFlaggedColumn]);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4a7);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn isFlaggedColumn = this.cf941950a7c7a817be59cb703be398f51.IsFlaggedColumn;
					this[isFlaggedColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReadonly
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.cf941950a7c7a817be59cb703be398f51.IsReadonlyColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x535);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn isReadonlyColumn = this.cf941950a7c7a817be59cb703be398f51.IsReadonlyColumn;
					this[isReadonlyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Length
			{
				get
				{
					object item = this[this.cf941950a7c7a817be59cb703be398f51.LengthColumn];
					int integer = Conversions.ToInteger(item);
					return integer;
				}
				set
				{
					DataColumn lengthColumn = this.cf941950a7c7a817be59cb703be398f51.LengthColumn;
					this[lengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Loc_Num
			{
				get
				{
					int num;
					try
					{
						int integer = Conversions.ToInteger(this[this.cf941950a7c7a817be59cb703be398f51.Loc_NumColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xee5), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn locNumColumn = this.cf941950a7c7a817be59cb703be398f51.Loc_NumColumn;
					this[locNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int MaxLength
			{
				get
				{
					int integer;
					try
					{
						DataColumn maxLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MaxLengthColumn;
						object item = this[maxLengthColumn];
						integer = Conversions.ToInteger(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c5);
						throw new StrongTypingException(str, invalidCastException);
					}
					return integer;
				}
				set
				{
					DataColumn maxLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MaxLengthColumn;
					this[maxLengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int MinLength
			{
				get
				{
					int num;
					try
					{
						object item = this[this.cf941950a7c7a817be59cb703be398f51.MinLengthColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x653), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn minLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MinLengthColumn;
					this[minLengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string str;
					try
					{
						string str1 = Conversions.ToString(this[this.cf941950a7c7a817be59cb703be398f51.NameColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf6f);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn nameColumn = this.cf941950a7c7a817be59cb703be398f51.NameColumn;
					this[nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Notes
			{
				get
				{
					string str;
					try
					{
						DataColumn notesColumn = this.cf941950a7c7a817be59cb703be398f51.NotesColumn;
						str = Conversions.ToString(this[notesColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e1), invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cf941950a7c7a817be59cb703be398f51.NotesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Priority
			{
				get
				{
					int num;
					try
					{
						DataColumn priorityColumn = this.cf941950a7c7a817be59cb703be398f51.PriorityColumn;
						int integer = Conversions.ToInteger(this[priorityColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x767), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn priorityColumn = this.cf941950a7c7a817be59cb703be398f51.PriorityColumn;
					this[priorityColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Recurrence_GUID
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cf941950a7c7a817be59cb703be398f51.Recurrence_GUIDColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f3);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn recurrenceGUIDColumn = this.cf941950a7c7a817be59cb703be398f51.Recurrence_GUIDColumn;
					this[recurrenceGUIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Room_Number
			{
				get
				{
					int integer;
					try
					{
						DataColumn roomNumberColumn = this.cf941950a7c7a817be59cb703be398f51.Room_NumberColumn;
						integer = Conversions.ToInteger(this[roomNumberColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x88d);
						throw new StrongTypingException(str, invalidCastException);
					}
					return integer;
				}
				set
				{
					DataColumn roomNumberColumn = this.cf941950a7c7a817be59cb703be398f51.Room_NumberColumn;
					this[roomNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime Start_Date
			{
				get
				{
					DataColumn startDateColumn = this.cf941950a7c7a817be59cb703be398f51.Start_DateColumn;
					DateTime date = Conversions.ToDate(this[startDateColumn]);
					return date;
				}
				set
				{
					DataColumn startDateColumn = this.cf941950a7c7a817be59cb703be398f51.Start_DateColumn;
					this[startDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Subject
			{
				get
				{
					string str;
					try
					{
						DataColumn subjectColumn = this.cf941950a7c7a817be59cb703be398f51.SubjectColumn;
						object item = this[subjectColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9a7);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn subjectColumn = this.cf941950a7c7a817be59cb703be398f51.SubjectColumn;
					this[subjectColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tblAppointmentsRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.cf941950a7c7a817be59cb703be398f51 = (dsAppointment.tblAppointmentsDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAlarm_Allow_OpenNull()
			{
				DataColumn alarmAllowOpenColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_OpenColumn;
				return this.IsNull(alarmAllowOpenColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAlarm_Allow_SnoozeNull()
			{
				return this.IsNull(this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_SnoozeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAlarm_Is_ArmedNull()
			{
				DataColumn alarmIsArmedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Is_ArmedColumn;
				return this.IsNull(alarmIsArmedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAlarm_ReminderNull()
			{
				DataColumn alarmReminderColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_ReminderColumn;
				return this.IsNull(alarmReminderColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAlarm_Was_DismissedNull()
			{
				DataColumn alarmWasDismissedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Was_DismissedColumn;
				bool flag = this.IsNull(alarmWasDismissedColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsBed_IDNull()
			{
				DataColumn bedIDColumn = this.cf941950a7c7a817be59cb703be398f51.Bed_IDColumn;
				return this.IsNull(bedIDColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsblockoutNull()
			{
				bool flag = this.IsNull(this.cf941950a7c7a817be59cb703be398f51.blockoutColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbUsedNull()
			{
				DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.bUsedColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isclient_IDNull()
			{
				bool flag = this.IsNull(this.cf941950a7c7a817be59cb703be398f51.client_IDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsClient_NameNull()
			{
				DataColumn clientNameColumn = this.cf941950a7c7a817be59cb703be398f51.Client_NameColumn;
				bool flag = this.IsNull(clientNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIsEventNull()
			{
				DataColumn isEventColumn = this.cf941950a7c7a817be59cb703be398f51.IsEventColumn;
				return this.IsNull(isEventColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIsFlaggedNull()
			{
				DataColumn isFlaggedColumn = this.cf941950a7c7a817be59cb703be398f51.IsFlaggedColumn;
				return this.IsNull(isFlaggedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIsReadonlyNull()
			{
				return this.IsNull(this.cf941950a7c7a817be59cb703be398f51.IsReadonlyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLoc_NumNull()
			{
				return this.IsNull(this.cf941950a7c7a817be59cb703be398f51.Loc_NumColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMaxLengthNull()
			{
				DataColumn maxLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MaxLengthColumn;
				bool flag = this.IsNull(maxLengthColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMinLengthNull()
			{
				DataColumn minLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MinLengthColumn;
				return this.IsNull(minLengthColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				DataColumn nameColumn = this.cf941950a7c7a817be59cb703be398f51.NameColumn;
				bool flag = this.IsNull(nameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNotesNull()
			{
				bool flag = this.IsNull(this.cf941950a7c7a817be59cb703be398f51.NotesColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPriorityNull()
			{
				return this.IsNull(this.cf941950a7c7a817be59cb703be398f51.PriorityColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRecurrence_GUIDNull()
			{
				DataColumn recurrenceGUIDColumn = this.cf941950a7c7a817be59cb703be398f51.Recurrence_GUIDColumn;
				bool flag = this.IsNull(recurrenceGUIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRoom_NumberNull()
			{
				bool flag = this.IsNull(this.cf941950a7c7a817be59cb703be398f51.Room_NumberColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSubjectNull()
			{
				DataColumn subjectColumn = this.cf941950a7c7a817be59cb703be398f51.SubjectColumn;
				return this.IsNull(subjectColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAlarm_Allow_OpenNull()
			{
				DataColumn alarmAllowOpenColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_OpenColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[alarmAllowOpenColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAlarm_Allow_SnoozeNull()
			{
				DataColumn alarmAllowSnoozeColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Allow_SnoozeColumn;
				this[alarmAllowSnoozeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAlarm_Is_ArmedNull()
			{
				DataColumn alarmIsArmedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Is_ArmedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[alarmIsArmedColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAlarm_ReminderNull()
			{
				DataColumn alarmReminderColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_ReminderColumn;
				this[alarmReminderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAlarm_Was_DismissedNull()
			{
				DataColumn alarmWasDismissedColumn = this.cf941950a7c7a817be59cb703be398f51.Alarm_Was_DismissedColumn;
				this[alarmWasDismissedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetBed_IDNull()
			{
				DataColumn bedIDColumn = this.cf941950a7c7a817be59cb703be398f51.Bed_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[bedIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetblockoutNull()
			{
				DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.blockoutColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbUsedNull()
			{
				DataColumn dataColumn = this.cf941950a7c7a817be59cb703be398f51.bUsedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setclient_IDNull()
			{
				DataColumn clientIDColumn = this.cf941950a7c7a817be59cb703be398f51.client_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClient_NameNull()
			{
				DataColumn clientNameColumn = this.cf941950a7c7a817be59cb703be398f51.Client_NameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIsEventNull()
			{
				DataColumn isEventColumn = this.cf941950a7c7a817be59cb703be398f51.IsEventColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[isEventColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIsFlaggedNull()
			{
				DataColumn isFlaggedColumn = this.cf941950a7c7a817be59cb703be398f51.IsFlaggedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[isFlaggedColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIsReadonlyNull()
			{
				this[this.cf941950a7c7a817be59cb703be398f51.IsReadonlyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetLoc_NumNull()
			{
				DataColumn locNumColumn = this.cf941950a7c7a817be59cb703be398f51.Loc_NumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[locNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMaxLengthNull()
			{
				DataColumn maxLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MaxLengthColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[maxLengthColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMinLengthNull()
			{
				DataColumn minLengthColumn = this.cf941950a7c7a817be59cb703be398f51.MinLengthColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[minLengthColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				DataColumn nameColumn = this.cf941950a7c7a817be59cb703be398f51.NameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[nameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNotesNull()
			{
				DataColumn notesColumn = this.cf941950a7c7a817be59cb703be398f51.NotesColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[notesColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPriorityNull()
			{
				DataColumn priorityColumn = this.cf941950a7c7a817be59cb703be398f51.PriorityColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[priorityColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRecurrence_GUIDNull()
			{
				DataColumn recurrenceGUIDColumn = this.cf941950a7c7a817be59cb703be398f51.Recurrence_GUIDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[recurrenceGUIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRoom_NumberNull()
			{
				DataColumn roomNumberColumn = this.cf941950a7c7a817be59cb703be398f51.Room_NumberColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[roomNumberColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSubjectNull()
			{
				DataColumn subjectColumn = this.cf941950a7c7a817be59cb703be398f51.SubjectColumn;
				this[subjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tblAppointmentsRowChangeEvent : EventArgs
		{
			private dsAppointment.tblAppointmentsRow c1cbccf2ba30b0268c407c29b056c2fdd;

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
			public dsAppointment.tblAppointmentsRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tblAppointmentsRowChangeEvent(dsAppointment.tblAppointmentsRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tblAppointmentsRowChangeEventHandler(object sender, dsAppointment.tblAppointmentsRowChangeEvent e);
	}
}