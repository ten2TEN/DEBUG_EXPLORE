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
	[XmlRoot("dsClient")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dsClient : DataSet
	{
		private dsClient.ClientsDataTable tableClients;

		private dsClient.PicturesDataTable tablePictures;

		private System.Data.SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsClient.ClientsDataTable Clients
		{
			get
			{
				return this.tableClients;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsClient.PicturesDataTable Pictures
		{
			get
			{
				return this.tablePictures;
			}
		}

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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsClient()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.ce9285e807b6d3d13062294184142fedb();
			dsClient _dsClient = this;
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(_dsClient.c70e3aced97d5cf7509794216755f6e5d);
			DataTableCollection tables = base.Tables;
			tables.CollectionChanged += collectionChangeEventHandler;
			DataRelationCollection relations = base.Relations;
			relations.CollectionChanged += collectionChangeEventHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsClient(SerializationInfo info, StreamingContext context)
		{
			// 
			// Current member / type: System.Void SqlLibrary.dsClient::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
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
			// Current member / type: System.Void SqlLibrary.dsClient::c70e3aced97d5cf7509794216755f6e5d(System.Object,System.ComponentModel.CollectionChangeEventArgs)
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
		private bool cadc43f6a844d8ca304fd53fc45ead2c8()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void ce9285e807b6d3d13062294184142fedb()
		{
			this.DataSetName = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1013);
			this.Prefix = "";
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1024);
			this.Namespace = str;
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableClients = new dsClient.ClientsDataTable();
			DataTableCollection tables = base.Tables;
			tables.Add(this.tableClients);
			this.tablePictures = new dsClient.PicturesDataTable();
			DataTableCollection dataTableCollection = base.Tables;
			dataTableCollection.Add(this.tablePictures);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool cf97f483ccda8b1a39155e9787a780416()
		{
			return false;
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
			// Current member / type: System.Void SqlLibrary.dsClient::cfb93e8c2fa64f1123fa8988e476c2203(System.Boolean)
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
			dsClient _dsClient = (dsClient)dataSet;
			_dsClient.cfb93e8c2fa64f1123fa8988e476c2203();
			System.Data.SchemaSerializationMode schemaSerializationMode = this.SchemaSerializationMode;
			_dsClient.SchemaSerializationMode = schemaSerializationMode;
			return _dsClient;
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
			// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsClient::GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet)
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
			// Current member / type: System.Void SqlLibrary.dsClient::ReadXmlSerializable(System.Xml.XmlReader)
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
		public class ClientsDataTable : TypedTableBase<dsClient.ClientsRow>
		{
			private DataColumn columnID;

			private DataColumn columnClient_Number;

			private DataColumn columnFirst_Name;

			private DataColumn columnMiddle_Initial;

			private DataColumn columnLast_Name;

			private DataColumn columnAddress;

			private DataColumn columnCity;

			private DataColumn columnCounty;

			private DataColumn columnState_Or_Province;

			private DataColumn columnPostal_Code;

			private DataColumn columnCountry;

			private DataColumn columnHome_Phone;

			private DataColumn columnCell_Phone;

			private DataColumn columnWork_Phone;

			private DataColumn columnWork_Extension;

			private DataColumn columndtBirth;

			private DataColumn columnSex;

			private DataColumn columnMarital_Status;

			private DataColumn columnSkin_Type_ID;

			private DataColumn columnLast_Bed_ID;

			private DataColumn columndtLast_Visit;

			private DataColumn columnTans_Remaining;

			private DataColumn columnMinutes_Remaining;

			private DataColumn columnPoints_Remaining;

			private DataColumn columnReward_Dollars;

			private DataColumn columnDL_Number;

			private DataColumn columnDL_State_Or_Province;

			private DataColumn columndtRelease;

			private DataColumn columndtContact;

			private DataColumn columnReferral_ID;

			private DataColumn columnPicture_ID;

			private DataColumn columnSpecial_Note;

			private DataColumn columnEmail;

			private DataColumn columnEFT_CC_Num;

			private DataColumn columnEFT_CC_Expire;

			private DataColumn columnEFT_CC_Name_On_Card;

			private DataColumn columnEFT_CC_Billing_Address;

			private DataColumn columnEFT_CC_Zip;

			private DataColumn columnEFT_CC_3Digit_Code;

			private DataColumn columnEFT_Checking_Routing_Num;

			private DataColumn columnEFT_Checking_Account_Num;

			private DataColumn columnbHas_CC_EFT;

			private DataColumn columnbHas_Checking_EFT;

			private DataColumn columnbAllow_Email;

			private DataColumn columnbAllow_Direct_mail;

			private DataColumn columnbRepeat_Cust;

			private DataColumn columnLast_Length;

			private DataColumn columndtCreated;

			private DataColumn columnStore_Number;

			private DataColumn columnReferredBy_Client_ID;

			private DataColumn columnReferredBy_Client_Name;

			private dsClient.ClientsRowChangeEventHandler ClientsRowChangingEvent;

			private dsClient.ClientsRowChangeEventHandler ClientsRowChangedEvent;

			private dsClient.ClientsRowChangeEventHandler ClientsRowDeletingEvent;

			private dsClient.ClientsRowChangeEventHandler ClientsRowDeletedEvent;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AddressColumn
			{
				get
				{
					return this.columnAddress;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bAllow_Direct_mailColumn
			{
				get
				{
					return this.columnbAllow_Direct_mail;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bAllow_EmailColumn
			{
				get
				{
					return this.columnbAllow_Email;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bHas_CC_EFTColumn
			{
				get
				{
					return this.columnbHas_CC_EFT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bHas_Checking_EFTColumn
			{
				get
				{
					return this.columnbHas_Checking_EFT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bRepeat_CustColumn
			{
				get
				{
					return this.columnbRepeat_Cust;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Cell_PhoneColumn
			{
				get
				{
					return this.columnCell_Phone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CityColumn
			{
				get
				{
					return this.columnCity;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Client_NumberColumn
			{
				get
				{
					return this.columnClient_Number;
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
			public DataColumn CountryColumn
			{
				get
				{
					return this.columnCountry;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountyColumn
			{
				get
				{
					return this.columnCounty;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DL_NumberColumn
			{
				get
				{
					return this.columnDL_Number;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DL_State_Or_ProvinceColumn
			{
				get
				{
					return this.columnDL_State_Or_Province;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtBirthColumn
			{
				get
				{
					return this.columndtBirth;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtContactColumn
			{
				get
				{
					return this.columndtContact;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtCreatedColumn
			{
				get
				{
					return this.columndtCreated;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtLast_VisitColumn
			{
				get
				{
					return this.columndtLast_Visit;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dtReleaseColumn
			{
				get
				{
					return this.columndtRelease;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_3Digit_CodeColumn
			{
				get
				{
					return this.columnEFT_CC_3Digit_Code;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_Billing_AddressColumn
			{
				get
				{
					return this.columnEFT_CC_Billing_Address;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_ExpireColumn
			{
				get
				{
					return this.columnEFT_CC_Expire;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_Name_On_CardColumn
			{
				get
				{
					return this.columnEFT_CC_Name_On_Card;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_NumColumn
			{
				get
				{
					return this.columnEFT_CC_Num;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_CC_ZipColumn
			{
				get
				{
					return this.columnEFT_CC_Zip;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_Checking_Account_NumColumn
			{
				get
				{
					return this.columnEFT_Checking_Account_Num;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EFT_Checking_Routing_NumColumn
			{
				get
				{
					return this.columnEFT_Checking_Routing_Num;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EmailColumn
			{
				get
				{
					return this.columnEmail;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn First_NameColumn
			{
				get
				{
					return this.columnFirst_Name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Home_PhoneColumn
			{
				get
				{
					return this.columnHome_Phone;
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
			public dsClient.ClientsRow this[int index]
			{
				get
				{
					DataRow item = this.Rows[index];
					return (dsClient.ClientsRow)item;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Last_Bed_IDColumn
			{
				get
				{
					return this.columnLast_Bed_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Last_LengthColumn
			{
				get
				{
					return this.columnLast_Length;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Last_NameColumn
			{
				get
				{
					return this.columnLast_Name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Marital_StatusColumn
			{
				get
				{
					return this.columnMarital_Status;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Middle_InitialColumn
			{
				get
				{
					return this.columnMiddle_Initial;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Minutes_RemainingColumn
			{
				get
				{
					return this.columnMinutes_Remaining;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Picture_IDColumn
			{
				get
				{
					return this.columnPicture_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Points_RemainingColumn
			{
				get
				{
					return this.columnPoints_Remaining;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Postal_CodeColumn
			{
				get
				{
					return this.columnPostal_Code;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Referral_IDColumn
			{
				get
				{
					return this.columnReferral_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ReferredBy_Client_IDColumn
			{
				get
				{
					return this.columnReferredBy_Client_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ReferredBy_Client_NameColumn
			{
				get
				{
					return this.columnReferredBy_Client_Name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Reward_DollarsColumn
			{
				get
				{
					return this.columnReward_Dollars;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SexColumn
			{
				get
				{
					return this.columnSex;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Skin_Type_IDColumn
			{
				get
				{
					return this.columnSkin_Type_ID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Special_NoteColumn
			{
				get
				{
					return this.columnSpecial_Note;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn State_Or_ProvinceColumn
			{
				get
				{
					return this.columnState_Or_Province;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Store_NumberColumn
			{
				get
				{
					return this.columnStore_Number;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Tans_RemainingColumn
			{
				get
				{
					return this.columnTans_Remaining;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Work_ExtensionColumn
			{
				get
				{
					return this.columnWork_Extension;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Work_PhoneColumn
			{
				get
				{
					return this.columnWork_Phone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ClientsDataTable()
			{
				this.TableName = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xff3);
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ClientsDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsClient/ClientsDataTable::.ctor(System.Data.DataTable)
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
			protected ClientsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddClientsRow(dsClient.ClientsRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsClient.ClientsRow AddClientsRow(uint ID, string Client_Number, string First_Name, string Middle_Initial, string Last_Name, string Address, string City, string County, string State_Or_Province, string Postal_Code, string Country, string Home_Phone, string Cell_Phone, string Work_Phone, string Work_Extension, DateTime dtBirth, bool Sex, int Marital_Status, int Skin_Type_ID, int Last_Bed_ID, DateTime dtLast_Visit, int Tans_Remaining, decimal Minutes_Remaining, decimal Points_Remaining, decimal Reward_Dollars, string DL_Number, string DL_State_Or_Province, DateTime dtRelease, DateTime dtContact, int Referral_ID, long Picture_ID, string Special_Note, string Email, string EFT_CC_Num, DateTime EFT_CC_Expire, string EFT_CC_Name_On_Card, string EFT_CC_Billing_Address, string EFT_CC_Zip, string EFT_CC_3Digit_Code, string EFT_Checking_Routing_Num, string EFT_Checking_Account_Num, bool bHas_CC_EFT, bool bHas_Checking_EFT, bool bAllow_Email, string bAllow_Direct_mail, bool bRepeat_Cust, int Last_Length, DateTime dtCreated, int Store_Number, decimal ReferredBy_Client_ID, string ReferredBy_Client_Name)
			{
				DataRow dataRow = this.NewRow();
				dsClient.ClientsRow clientsRow = (dsClient.ClientsRow)dataRow;
				object[] d = new object[] { ID, Client_Number, First_Name, Middle_Initial, Last_Name, Address, City, County, State_Or_Province, Postal_Code, Country, Home_Phone, Cell_Phone, Work_Phone, Work_Extension, dtBirth, Sex, Marital_Status, Skin_Type_ID, Last_Bed_ID, dtLast_Visit, Tans_Remaining, Minutes_Remaining, Points_Remaining, Reward_Dollars, DL_Number, DL_State_Or_Province, dtRelease, dtContact, Referral_ID, Picture_ID, Special_Note, Email, EFT_CC_Num, EFT_CC_Expire, EFT_CC_Name_On_Card, EFT_CC_Billing_Address, EFT_CC_Zip, EFT_CC_3Digit_Code, EFT_Checking_Routing_Num, EFT_Checking_Account_Num, bHas_CC_EFT, bHas_Checking_EFT, bAllow_Email, bAllow_Direct_mail, bRepeat_Cust, Last_Length, dtCreated, Store_Number, ReferredBy_Client_ID, ReferredBy_Client_Name };
				clientsRow.ItemArray = d;
				DataRowCollection rows = this.Rows;
				rows.Add(clientsRow);
				return clientsRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(151);
				Type type = typeof(uint);
				this.columnID = new DataColumn(str, type, null, MappingType.Element);
				base.Columns.Add(this.columnID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1063);
				this.columnClient_Number = new DataColumn(str1, typeof(string), null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnClient_Number);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x107e);
				this.columnFirst_Name = new DataColumn(str2, typeof(string), null, MappingType.Element);
				DataColumnCollection dataColumnCollection = base.Columns;
				dataColumnCollection.Add(this.columnFirst_Name);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1093);
				Type type1 = typeof(string);
				this.columnMiddle_Initial = new DataColumn(str3, type1, null, MappingType.Element);
				DataColumnCollection columns1 = base.Columns;
				columns1.Add(this.columnMiddle_Initial);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b0);
				Type type2 = typeof(string);
				this.columnLast_Name = new DataColumn(str4, type2, null, MappingType.Element);
				DataColumnCollection dataColumnCollection1 = base.Columns;
				dataColumnCollection1.Add(this.columnLast_Name);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c3);
				Type type3 = typeof(string);
				this.columnAddress = new DataColumn(str5, type3, null, MappingType.Element);
				DataColumnCollection columns2 = base.Columns;
				columns2.Add(this.columnAddress);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10d2);
				Type type4 = typeof(string);
				this.columnCity = new DataColumn(str6, type4, null, MappingType.Element);
				DataColumnCollection dataColumnCollection2 = base.Columns;
				dataColumnCollection2.Add(this.columnCity);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10db);
				this.columnCounty = new DataColumn(str7, typeof(string), null, MappingType.Element);
				DataColumnCollection columns3 = base.Columns;
				columns3.Add(this.columnCounty);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10e8);
				Type type5 = typeof(string);
				this.columnState_Or_Province = new DataColumn(str8, type5, null, MappingType.Element);
				DataColumnCollection dataColumnCollection3 = base.Columns;
				dataColumnCollection3.Add(this.columnState_Or_Province);
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110b);
				Type type6 = typeof(string);
				this.columnPostal_Code = new DataColumn(str9, type6, null, MappingType.Element);
				DataColumnCollection columns4 = base.Columns;
				columns4.Add(this.columnPostal_Code);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1122);
				this.columnCountry = new DataColumn(str10, typeof(string), null, MappingType.Element);
				DataColumnCollection dataColumnCollection4 = base.Columns;
				dataColumnCollection4.Add(this.columnCountry);
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1131);
				Type type7 = typeof(string);
				this.columnHome_Phone = new DataColumn(str11, type7, null, MappingType.Element);
				DataColumnCollection columns5 = base.Columns;
				columns5.Add(this.columnHome_Phone);
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1146);
				Type type8 = typeof(string);
				this.columnCell_Phone = new DataColumn(str12, type8, null, MappingType.Element);
				DataColumnCollection dataColumnCollection5 = base.Columns;
				dataColumnCollection5.Add(this.columnCell_Phone);
				this.columnWork_Phone = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115b), typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnWork_Phone);
				this.columnWork_Extension = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1170), typeof(string), null, MappingType.Element);
				DataColumnCollection columns6 = base.Columns;
				columns6.Add(this.columnWork_Extension);
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118d);
				Type type9 = typeof(DateTime);
				this.columndtBirth = new DataColumn(str13, type9, null, MappingType.Element);
				DataColumnCollection dataColumnCollection6 = base.Columns;
				dataColumnCollection6.Add(this.columndtBirth);
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119c);
				Type type10 = typeof(bool);
				this.columnSex = new DataColumn(str14, type10, null, MappingType.Element);
				DataColumnCollection columns7 = base.Columns;
				columns7.Add(this.columnSex);
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11a3);
				Type type11 = typeof(int);
				this.columnMarital_Status = new DataColumn(str15, type11, null, MappingType.Element);
				DataColumnCollection dataColumnCollection7 = base.Columns;
				dataColumnCollection7.Add(this.columnMarital_Status);
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c0);
				Type type12 = typeof(int);
				this.columnSkin_Type_ID = new DataColumn(str16, type12, null, MappingType.Element);
				base.Columns.Add(this.columnSkin_Type_ID);
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d9);
				Type type13 = typeof(int);
				this.columnLast_Bed_ID = new DataColumn(str17, type13, null, MappingType.Element);
				DataColumnCollection columns8 = base.Columns;
				columns8.Add(this.columnLast_Bed_ID);
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11f0);
				Type type14 = typeof(DateTime);
				this.columndtLast_Visit = new DataColumn(str18, type14, null, MappingType.Element);
				base.Columns.Add(this.columndtLast_Visit);
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1209);
				Type type15 = typeof(int);
				this.columnTans_Remaining = new DataColumn(str19, type15, null, MappingType.Element);
				DataColumnCollection dataColumnCollection8 = base.Columns;
				dataColumnCollection8.Add(this.columnTans_Remaining);
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1226);
				Type type16 = typeof(decimal);
				this.columnMinutes_Remaining = new DataColumn(str20, type16, null, MappingType.Element);
				base.Columns.Add(this.columnMinutes_Remaining);
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1249);
				Type type17 = typeof(decimal);
				this.columnPoints_Remaining = new DataColumn(str21, type17, null, MappingType.Element);
				base.Columns.Add(this.columnPoints_Remaining);
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x126a);
				Type type18 = typeof(decimal);
				this.columnReward_Dollars = new DataColumn(str22, type18, null, MappingType.Element);
				DataColumnCollection columns9 = base.Columns;
				columns9.Add(this.columnReward_Dollars);
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1287);
				Type type19 = typeof(string);
				this.columnDL_Number = new DataColumn(str23, type19, null, MappingType.Element);
				DataColumnCollection dataColumnCollection9 = base.Columns;
				dataColumnCollection9.Add(this.columnDL_Number);
				this.columnDL_State_Or_Province = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x129a), typeof(string), null, MappingType.Element);
				DataColumnCollection columns10 = base.Columns;
				columns10.Add(this.columnDL_State_Or_Province);
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12c3);
				Type type20 = typeof(DateTime);
				this.columndtRelease = new DataColumn(str24, type20, null, MappingType.Element);
				DataColumnCollection dataColumnCollection10 = base.Columns;
				dataColumnCollection10.Add(this.columndtRelease);
				string str25 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12d6);
				Type type21 = typeof(DateTime);
				this.columndtContact = new DataColumn(str25, type21, null, MappingType.Element);
				DataColumnCollection columns11 = base.Columns;
				columns11.Add(this.columndtContact);
				string str26 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12e9);
				Type type22 = typeof(int);
				this.columnReferral_ID = new DataColumn(str26, type22, null, MappingType.Element);
				DataColumnCollection dataColumnCollection11 = base.Columns;
				dataColumnCollection11.Add(this.columnReferral_ID);
				string str27 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1300);
				Type type23 = typeof(long);
				this.columnPicture_ID = new DataColumn(str27, type23, null, MappingType.Element);
				DataColumnCollection columns12 = base.Columns;
				columns12.Add(this.columnPicture_ID);
				string str28 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1315);
				Type type24 = typeof(string);
				this.columnSpecial_Note = new DataColumn(str28, type24, null, MappingType.Element);
				DataColumnCollection dataColumnCollection12 = base.Columns;
				dataColumnCollection12.Add(this.columnSpecial_Note);
				string str29 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x132e);
				Type type25 = typeof(string);
				this.columnEmail = new DataColumn(str29, type25, null, MappingType.Element);
				DataColumnCollection columns13 = base.Columns;
				columns13.Add(this.columnEmail);
				string str30 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1339);
				Type type26 = typeof(string);
				this.columnEFT_CC_Num = new DataColumn(str30, type26, null, MappingType.Element);
				base.Columns.Add(this.columnEFT_CC_Num);
				string str31 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x134e);
				Type type27 = typeof(DateTime);
				this.columnEFT_CC_Expire = new DataColumn(str31, type27, null, MappingType.Element);
				DataColumnCollection dataColumnCollection13 = base.Columns;
				dataColumnCollection13.Add(this.columnEFT_CC_Expire);
				string str32 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1369);
				Type type28 = typeof(string);
				this.columnEFT_CC_Name_On_Card = new DataColumn(str32, type28, null, MappingType.Element);
				DataColumnCollection columns14 = base.Columns;
				columns14.Add(this.columnEFT_CC_Name_On_Card);
				string str33 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1390);
				Type type29 = typeof(string);
				this.columnEFT_CC_Billing_Address = new DataColumn(str33, type29, null, MappingType.Element);
				base.Columns.Add(this.columnEFT_CC_Billing_Address);
				string str34 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13bd);
				Type type30 = typeof(string);
				this.columnEFT_CC_Zip = new DataColumn(str34, type30, null, MappingType.Element);
				DataColumnCollection dataColumnCollection14 = base.Columns;
				dataColumnCollection14.Add(this.columnEFT_CC_Zip);
				string str35 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13d2);
				Type type31 = typeof(string);
				this.columnEFT_CC_3Digit_Code = new DataColumn(str35, type31, null, MappingType.Element);
				base.Columns.Add(this.columnEFT_CC_3Digit_Code);
				string str36 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f7);
				Type type32 = typeof(string);
				this.columnEFT_Checking_Routing_Num = new DataColumn(str36, type32, null, MappingType.Element);
				DataColumnCollection columns15 = base.Columns;
				columns15.Add(this.columnEFT_Checking_Routing_Num);
				string str37 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1428);
				this.columnEFT_Checking_Account_Num = new DataColumn(str37, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEFT_Checking_Account_Num);
				this.columnbHas_CC_EFT = new DataColumn(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1459), typeof(bool), null, MappingType.Element);
				DataColumnCollection dataColumnCollection15 = base.Columns;
				dataColumnCollection15.Add(this.columnbHas_CC_EFT);
				string str38 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1470);
				Type type33 = typeof(bool);
				this.columnbHas_Checking_EFT = new DataColumn(str38, type33, null, MappingType.Element);
				DataColumnCollection columns16 = base.Columns;
				columns16.Add(this.columnbHas_Checking_EFT);
				string str39 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1493);
				this.columnbAllow_Email = new DataColumn(str39, typeof(bool), null, MappingType.Element);
				DataColumnCollection dataColumnCollection16 = base.Columns;
				dataColumnCollection16.Add(this.columnbAllow_Email);
				string str40 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14ac);
				Type type34 = typeof(string);
				this.columnbAllow_Direct_mail = new DataColumn(str40, type34, null, MappingType.Element);
				base.Columns.Add(this.columnbAllow_Direct_mail);
				string str41 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14d1);
				Type type35 = typeof(bool);
				this.columnbRepeat_Cust = new DataColumn(str41, type35, null, MappingType.Element);
				DataColumnCollection columns17 = base.Columns;
				columns17.Add(this.columnbRepeat_Cust);
				string str42 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14ea);
				Type type36 = typeof(int);
				this.columnLast_Length = new DataColumn(str42, type36, null, MappingType.Element);
				base.Columns.Add(this.columnLast_Length);
				string str43 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1501);
				this.columndtCreated = new DataColumn(str43, typeof(DateTime), null, MappingType.Element);
				DataColumnCollection dataColumnCollection17 = base.Columns;
				dataColumnCollection17.Add(this.columndtCreated);
				string str44 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1514);
				Type type37 = typeof(int);
				this.columnStore_Number = new DataColumn(str44, type37, null, MappingType.Element);
				DataColumnCollection columns18 = base.Columns;
				columns18.Add(this.columnStore_Number);
				string str45 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x152d);
				this.columnReferredBy_Client_ID = new DataColumn(str45, typeof(decimal), null, MappingType.Element);
				DataColumnCollection dataColumnCollection18 = base.Columns;
				dataColumnCollection18.Add(this.columnReferredBy_Client_ID);
				string str46 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1556);
				this.columnReferredBy_Client_Name = new DataColumn(str46, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnReferredBy_Client_Name);
				ConstraintCollection constraints = this.Constraints;
				string str47 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1583);
				DataColumn[] columnPictureID = new DataColumn[] { this.columnPicture_ID };
				constraints.Add(new UniqueConstraint(str47, columnPictureID, false));
				this.columnID.AllowDBNull = false;
				this.columnPicture_ID.Unique = true;
				this.columnEFT_CC_Num.ReadOnly = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void cfb93e8c2fa64f1123fa8988e476c2203()
			{
				DataColumnCollection columns = base.Columns;
				this.columnID = columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(151)];
				DataColumnCollection dataColumnCollection = base.Columns;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1063);
				DataColumn item = dataColumnCollection[str];
				this.columnClient_Number = item;
				DataColumnCollection columns1 = base.Columns;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x107e);
				DataColumn dataColumn = columns1[str1];
				this.columnFirst_Name = dataColumn;
				DataColumnCollection dataColumnCollection1 = base.Columns;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1093);
				DataColumn item1 = dataColumnCollection1[str2];
				this.columnMiddle_Initial = item1;
				DataColumnCollection columns2 = base.Columns;
				this.columnLast_Name = columns2[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b0)];
				DataColumnCollection dataColumnCollection2 = base.Columns;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c3);
				DataColumn dataColumn1 = dataColumnCollection2[str3];
				this.columnAddress = dataColumn1;
				DataColumnCollection columns3 = base.Columns;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10d2);
				this.columnCity = columns3[str4];
				DataColumnCollection dataColumnCollection3 = base.Columns;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10db);
				DataColumn item2 = dataColumnCollection3[str5];
				this.columnCounty = item2;
				DataColumnCollection columns4 = base.Columns;
				DataColumn dataColumn2 = columns4[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10e8)];
				this.columnState_Or_Province = dataColumn2;
				DataColumnCollection dataColumnCollection4 = base.Columns;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110b);
				this.columnPostal_Code = dataColumnCollection4[str6];
				DataColumnCollection columns5 = base.Columns;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1122);
				this.columnCountry = columns5[str7];
				DataColumnCollection dataColumnCollection5 = base.Columns;
				DataColumn item3 = dataColumnCollection5[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1131)];
				this.columnHome_Phone = item3;
				DataColumnCollection columns6 = base.Columns;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1146);
				this.columnCell_Phone = columns6[str8];
				DataColumnCollection dataColumnCollection6 = base.Columns;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115b);
				DataColumn dataColumn3 = dataColumnCollection6[str9];
				this.columnWork_Phone = dataColumn3;
				DataColumnCollection columns7 = base.Columns;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1170);
				this.columnWork_Extension = columns7[str10];
				DataColumnCollection dataColumnCollection7 = base.Columns;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118d);
				this.columndtBirth = dataColumnCollection7[str11];
				DataColumnCollection columns8 = base.Columns;
				this.columnSex = columns8[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119c)];
				DataColumnCollection dataColumnCollection8 = base.Columns;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11a3);
				DataColumn item4 = dataColumnCollection8[str12];
				this.columnMarital_Status = item4;
				DataColumnCollection columns9 = base.Columns;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c0);
				DataColumn dataColumn4 = columns9[str13];
				this.columnSkin_Type_ID = dataColumn4;
				DataColumnCollection dataColumnCollection9 = base.Columns;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d9);
				this.columnLast_Bed_ID = dataColumnCollection9[str14];
				DataColumnCollection columns10 = base.Columns;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11f0);
				this.columndtLast_Visit = columns10[str15];
				DataColumnCollection dataColumnCollection10 = base.Columns;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1209);
				DataColumn item5 = dataColumnCollection10[str16];
				this.columnTans_Remaining = item5;
				DataColumnCollection columns11 = base.Columns;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1226);
				this.columnMinutes_Remaining = columns11[str17];
				DataColumnCollection dataColumnCollection11 = base.Columns;
				this.columnPoints_Remaining = dataColumnCollection11[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1249)];
				DataColumnCollection columns12 = base.Columns;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x126a);
				this.columnReward_Dollars = columns12[str18];
				DataColumnCollection dataColumnCollection12 = base.Columns;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1287);
				DataColumn dataColumn5 = dataColumnCollection12[str19];
				this.columnDL_Number = dataColumn5;
				DataColumnCollection columns13 = base.Columns;
				this.columnDL_State_Or_Province = columns13[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x129a)];
				DataColumnCollection dataColumnCollection13 = base.Columns;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12c3);
				DataColumn item6 = dataColumnCollection13[str20];
				this.columndtRelease = item6;
				DataColumnCollection columns14 = base.Columns;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12d6);
				this.columndtContact = columns14[str21];
				DataColumnCollection dataColumnCollection14 = base.Columns;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12e9);
				DataColumn dataColumn6 = dataColumnCollection14[str22];
				this.columnReferral_ID = dataColumn6;
				DataColumnCollection columns15 = base.Columns;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1300);
				this.columnPicture_ID = columns15[str23];
				DataColumnCollection dataColumnCollection15 = base.Columns;
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1315);
				DataColumn item7 = dataColumnCollection15[str24];
				this.columnSpecial_Note = item7;
				DataColumnCollection columns16 = base.Columns;
				DataColumn dataColumn7 = columns16[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x132e)];
				this.columnEmail = dataColumn7;
				this.columnEFT_CC_Num = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1339)];
				DataColumnCollection dataColumnCollection16 = base.Columns;
				this.columnEFT_CC_Expire = dataColumnCollection16[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x134e)];
				DataColumnCollection columns17 = base.Columns;
				string str25 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1369);
				DataColumn item8 = columns17[str25];
				this.columnEFT_CC_Name_On_Card = item8;
				DataColumnCollection dataColumnCollection17 = base.Columns;
				string str26 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1390);
				this.columnEFT_CC_Billing_Address = dataColumnCollection17[str26];
				DataColumnCollection columns18 = base.Columns;
				string str27 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13bd);
				DataColumn dataColumn8 = columns18[str27];
				this.columnEFT_CC_Zip = dataColumn8;
				DataColumnCollection dataColumnCollection18 = base.Columns;
				string str28 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13d2);
				this.columnEFT_CC_3Digit_Code = dataColumnCollection18[str28];
				DataColumnCollection columns19 = base.Columns;
				string str29 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f7);
				DataColumn item9 = columns19[str29];
				this.columnEFT_Checking_Routing_Num = item9;
				DataColumnCollection dataColumnCollection19 = base.Columns;
				string str30 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1428);
				this.columnEFT_Checking_Account_Num = dataColumnCollection19[str30];
				DataColumnCollection columns20 = base.Columns;
				string str31 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1459);
				DataColumn dataColumn9 = columns20[str31];
				this.columnbHas_CC_EFT = dataColumn9;
				DataColumn item10 = base.Columns[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1470)];
				this.columnbHas_Checking_EFT = item10;
				DataColumnCollection dataColumnCollection20 = base.Columns;
				string str32 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1493);
				DataColumn dataColumn10 = dataColumnCollection20[str32];
				this.columnbAllow_Email = dataColumn10;
				DataColumnCollection columns21 = base.Columns;
				string str33 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14ac);
				this.columnbAllow_Direct_mail = columns21[str33];
				DataColumnCollection dataColumnCollection21 = base.Columns;
				string str34 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14d1);
				DataColumn item11 = dataColumnCollection21[str34];
				this.columnbRepeat_Cust = item11;
				DataColumnCollection columns22 = base.Columns;
				this.columnLast_Length = columns22[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14ea)];
				DataColumnCollection dataColumnCollection22 = base.Columns;
				string str35 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1501);
				DataColumn dataColumn11 = dataColumnCollection22[str35];
				this.columndtCreated = dataColumn11;
				DataColumnCollection columns23 = base.Columns;
				string str36 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1514);
				DataColumn item12 = columns23[str36];
				this.columnStore_Number = item12;
				DataColumnCollection dataColumnCollection23 = base.Columns;
				string str37 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x152d);
				DataColumn dataColumn12 = dataColumnCollection23[str37];
				this.columnReferredBy_Client_ID = dataColumn12;
				DataColumnCollection columns24 = base.Columns;
				DataColumn item13 = columns24[c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1556)];
				this.columnReferredBy_Client_Name = item13;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsClient.ClientsDataTable clientsDataTable = (dsClient.ClientsDataTable)dataTable;
				clientsDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return clientsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsClient.ClientsDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				Type type = typeof(dsClient.ClientsRow);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsClient/ClientsDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
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
			public dsClient.ClientsRow NewClientsRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsClient.ClientsRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsClient.ClientsRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsClient/ClientsDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/ClientsDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/ClientsDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/ClientsDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			public void RemoveClientsRow(dsClient.ClientsRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.ClientsRowChangeEventHandler ClientsRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.ClientsRowChangedEvent, obj);
					this.ClientsRowChangedEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.ClientsRowChangedEvent, obj);
					this.ClientsRowChangedEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.ClientsRowChangeEventHandler ClientsRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.ClientsRowChangingEvent, obj);
					this.ClientsRowChangingEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.ClientsRowChangingEvent, obj);
					this.ClientsRowChangingEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.ClientsRowChangeEventHandler ClientsRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.ClientsRowDeletedEvent += obj;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.ClientsRowDeletedEvent, obj);
					this.ClientsRowDeletedEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.ClientsRowChangeEventHandler ClientsRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.ClientsRowDeletingEvent, obj);
					this.ClientsRowDeletingEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.ClientsRowDeletingEvent, obj);
					this.ClientsRowDeletingEvent = (dsClient.ClientsRowChangeEventHandler)@delegate;
				}
			}
		}

		public class ClientsRow : DataRow
		{
			private dsClient.ClientsDataTable cc68d82fdcf05ca12c82af71ae5bd7b43;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Address
			{
				get
				{
					string str;
					try
					{
						DataColumn addressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.AddressColumn;
						object item = this[addressColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x17f7);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.AddressColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string bAllow_Direct_mail
			{
				get
				{
					string str;
					try
					{
						DataColumn bAllowDirectMailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_Direct_mailColumn;
						string str1 = Conversions.ToString(this[bAllowDirectMailColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2c1d);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_Direct_mailColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bAllow_Email
			{
				get
				{
					bool flag;
					try
					{
						DataColumn bAllowEmailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_EmailColumn;
						object item = this[bAllowEmailColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2b99);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn bAllowEmailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_EmailColumn;
					this[bAllowEmailColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bHas_CC_EFT
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_CC_EFTColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2a89);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_CC_EFTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bHas_Checking_EFT
			{
				get
				{
					bool flag;
					try
					{
						DataColumn bHasCheckingEFTColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_Checking_EFTColumn;
						object item = this[bHasCheckingEFTColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2b0b);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_Checking_EFTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bRepeat_Cust
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.bRepeat_CustColumn];
						flag = Conversions.ToBoolean(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2cad);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn bRepeatCustColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bRepeat_CustColumn;
					this[bRepeatCustColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Cell_Phone
			{
				get
				{
					string str;
					try
					{
						string str1 = Conversions.ToString(this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Cell_PhoneColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1b62), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn cellPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Cell_PhoneColumn;
					this[cellPhoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string City
			{
				get
				{
					string str;
					try
					{
						DataColumn cityColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CityColumn;
						object item = this[cityColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1870), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn cityColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CityColumn;
					this[cityColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Client_Number
			{
				get
				{
					string str;
					try
					{
						DataColumn clientNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Client_NumberColumn;
						object item = this[clientNumberColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x15ed);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn clientNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Client_NumberColumn;
					this[clientNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Country
			{
				get
				{
					string str;
					try
					{
						DataColumn countryColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountryColumn;
						object item = this[countryColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a6a);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn countryColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountryColumn;
					this[countryColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string County
			{
				get
				{
					string str;
					try
					{
						DataColumn countyColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountyColumn;
						object item = this[countyColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x18e3);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn countyColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountyColumn;
					this[countyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string DL_Number
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_NumberColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x220e);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn dLNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_NumberColumn;
					this[dLNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string DL_State_Or_Province
			{
				get
				{
					string str;
					try
					{
						DataColumn dLStateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_State_Or_ProvinceColumn;
						object item = this[dLStateOrProvinceColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x228b);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn dLStateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_State_Or_ProvinceColumn;
					this[dLStateOrProvinceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtBirth
			{
				get
				{
					DateTime date;
					try
					{
						DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtBirthColumn;
						date = Conversions.ToDate(this[dataColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1ce8);
						throw new StrongTypingException(str, invalidCastException);
					}
					return date;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtBirthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtContact
			{
				get
				{
					DateTime dateTime;
					try
					{
						DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtContactColumn;
						object item = this[dataColumn];
						DateTime date = Conversions.ToDate(item);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x239c);
						throw new StrongTypingException(str, invalidCastException);
					}
					return dateTime;
				}
				set
				{
					DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtContactColumn;
					this[dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtCreated
			{
				get
				{
					DateTime dateTime;
					try
					{
						DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtCreatedColumn;
						DateTime date = Conversions.ToDate(this[dataColumn]);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2db3);
						throw new StrongTypingException(str, invalidCastException);
					}
					return dateTime;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtCreatedColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtLast_Visit
			{
				get
				{
					DateTime dateTime;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtLast_VisitColumn];
						DateTime date = Conversions.ToDate(item);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1f60);
						throw new StrongTypingException(str, invalidCastException);
					}
					return dateTime;
				}
				set
				{
					DataColumn dtLastVisitColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtLast_VisitColumn;
					this[dtLastVisitColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dtRelease
			{
				get
				{
					DateTime date;
					try
					{
						DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtReleaseColumn;
						object item = this[dataColumn];
						date = Conversions.ToDate(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x231f);
						throw new StrongTypingException(str, invalidCastException);
					}
					return date;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtReleaseColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_CC_3Digit_Code
			{
				get
				{
					string str;
					try
					{
						DataColumn eFTCC3DigitCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_3Digit_CodeColumn;
						object item = this[eFTCC3DigitCodeColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x28c1);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCC3DigitCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_3Digit_CodeColumn;
					this[eFTCC3DigitCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_CC_Billing_Address
			{
				get
				{
					string str;
					try
					{
						DataColumn eFTCCBillingAddressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Billing_AddressColumn;
						string str1 = Conversions.ToString(this[eFTCCBillingAddressColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x27aa);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCCBillingAddressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Billing_AddressColumn;
					this[eFTCCBillingAddressColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime EFT_CC_Expire
			{
				get
				{
					DateTime dateTime;
					try
					{
						DataColumn eFTCCExpireColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ExpireColumn;
						object item = this[eFTCCExpireColumn];
						DateTime date = Conversions.ToDate(item);
						dateTime = date;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2692);
						throw new StrongTypingException(str, invalidCastException);
					}
					return dateTime;
				}
				set
				{
					DataColumn eFTCCExpireColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ExpireColumn;
					this[eFTCCExpireColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_CC_Name_On_Card
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Name_On_CardColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2718);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCCNameOnCardColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Name_On_CardColumn;
					this[eFTCCNameOnCardColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_CC_Num
			{
				get
				{
					string str;
					try
					{
						DataColumn eFTCCNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_NumColumn;
						object item = this[eFTCCNumColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2613);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCCNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_NumColumn;
					this[eFTCCNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_CC_Zip
			{
				get
				{
					string str;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ZipColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2842);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCCZipColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ZipColumn;
					this[eFTCCZipColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_Checking_Account_Num
			{
				get
				{
					string str;
					try
					{
						DataColumn eFTCheckingAccountNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Account_NumColumn;
						object item = this[eFTCheckingAccountNumColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x29ed);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCheckingAccountNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Account_NumColumn;
					this[eFTCheckingAccountNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EFT_Checking_Routing_Num
			{
				get
				{
					string str;
					try
					{
						DataColumn eFTCheckingRoutingNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Routing_NumColumn;
						object item = this[eFTCheckingRoutingNumColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2951), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn eFTCheckingRoutingNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Routing_NumColumn;
					this[eFTCheckingRoutingNumColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Email
			{
				get
				{
					string str;
					try
					{
						DataColumn emailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EmailColumn;
						object item = this[emailColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x259e);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn emailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EmailColumn;
					this[emailColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string First_Name
			{
				get
				{
					string str;
					try
					{
						DataColumn firstNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.First_NameColumn;
						object item = this[firstNameColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1673);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.First_NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Home_Phone
			{
				get
				{
					string str;
					try
					{
						DataColumn homePhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Home_PhoneColumn;
						str = Conversions.ToString(this[homePhoneColumn]);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1ae3);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn homePhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Home_PhoneColumn;
					this[homePhoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public uint ID
			{
				get
				{
					DataColumn dColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.IDColumn;
					object item = this[dColumn];
					return Conversions.ToUInteger(item);
				}
				set
				{
					DataColumn dColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.IDColumn;
					this[dColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Last_Bed_ID
			{
				get
				{
					int num;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_Bed_IDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1ede);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn lastBedIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_Bed_IDColumn;
					this[lastBedIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Last_Length
			{
				get
				{
					int num;
					try
					{
						DataColumn lastLengthColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_LengthColumn;
						int integer = Conversions.ToInteger(this[lastLengthColumn]);
						num = integer;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2d31), invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn lastLengthColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_LengthColumn;
					this[lastLengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Last_Name
			{
				get
				{
					string str;
					try
					{
						DataColumn lastNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_NameColumn;
						object item = this[lastNameColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x177a);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn lastNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_NameColumn;
					this[lastNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Marital_Status
			{
				get
				{
					int integer;
					try
					{
						DataColumn maritalStatusColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Marital_StatusColumn;
						object item = this[maritalStatusColumn];
						integer = Conversions.ToInteger(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1dd2), invalidCastException);
					}
					return integer;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Marital_StatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Middle_Initial
			{
				get
				{
					string str;
					try
					{
						DataColumn middleInitialColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Middle_InitialColumn;
						object item = this[middleInitialColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x16f2), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn middleInitialColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Middle_InitialColumn;
					this[middleInitialColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Minutes_Remaining
			{
				get
				{
					decimal num;
					try
					{
						DataColumn minutesRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Minutes_RemainingColumn;
						decimal num1 = Conversions.ToDecimal(this[minutesRemainingColumn]);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x206c);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn minutesRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Minutes_RemainingColumn;
					this[minutesRemainingColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public long Picture_ID
			{
				get
				{
					long num;
					try
					{
						DataColumn pictureIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Picture_IDColumn;
						object item = this[pictureIDColumn];
						long num1 = Conversions.ToLong(item);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x249b);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn pictureIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Picture_IDColumn;
					this[pictureIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Points_Remaining
			{
				get
				{
					decimal num;
					try
					{
						DataColumn pointsRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Points_RemainingColumn;
						object item = this[pointsRemainingColumn];
						num = Conversions.ToDecimal(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x20fa);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn pointsRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Points_RemainingColumn;
					this[pointsRemainingColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Postal_Code
			{
				get
				{
					string str;
					try
					{
						DataColumn postalCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Postal_CodeColumn;
						object item = this[postalCodeColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19e8);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn postalCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Postal_CodeColumn;
					this[postalCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Referral_ID
			{
				get
				{
					int num;
					try
					{
						DataColumn referralIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Referral_IDColumn;
						object item = this[referralIDColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2419);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Referral_IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ReferredBy_Client_ID
			{
				get
				{
					decimal num;
					try
					{
						DataColumn referredByClientIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_IDColumn;
						object item = this[referredByClientIDColumn];
						num = Conversions.ToDecimal(item);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2eb4), invalidCastException);
					}
					return num;
				}
				set
				{
					this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ReferredBy_Client_Name
			{
				get
				{
					string str;
					try
					{
						DataColumn referredByClientNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_NameColumn;
						object item = this[referredByClientNameColumn];
						str = Conversions.ToString(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2f48);
						throw new StrongTypingException(str1, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn referredByClientNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_NameColumn;
					this[referredByClientNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Reward_Dollars
			{
				get
				{
					decimal num;
					try
					{
						DataColumn rewardDollarsColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Reward_DollarsColumn;
						decimal num1 = Conversions.ToDecimal(this[rewardDollarsColumn]);
						num = num1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2186);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn rewardDollarsColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Reward_DollarsColumn;
					this[rewardDollarsColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Sex
			{
				get
				{
					bool flag;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.SexColumn];
						bool flag1 = Conversions.ToBoolean(item);
						flag = flag1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1d61);
						throw new StrongTypingException(str, invalidCastException);
					}
					return flag;
				}
				set
				{
					DataColumn sexColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.SexColumn;
					this[sexColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Skin_Type_ID
			{
				get
				{
					int integer;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Skin_Type_IDColumn];
						integer = Conversions.ToInteger(item);
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1e5a);
						throw new StrongTypingException(str, invalidCastException);
					}
					return integer;
				}
				set
				{
					DataColumn skinTypeIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Skin_Type_IDColumn;
					this[skinTypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Special_Note
			{
				get
				{
					string str;
					try
					{
						DataColumn specialNoteColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Special_NoteColumn;
						object item = this[specialNoteColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x251a);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn specialNoteColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Special_NoteColumn;
					this[specialNoteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string State_Or_Province
			{
				get
				{
					string str;
					try
					{
						DataColumn stateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.State_Or_ProvinceColumn;
						string str1 = Conversions.ToString(this[stateOrProvinceColumn]);
						str = str1;
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x195a), invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn stateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.State_Or_ProvinceColumn;
					this[stateOrProvinceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Store_Number
			{
				get
				{
					int num;
					try
					{
						DataColumn storeNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Store_NumberColumn;
						object item = this[storeNumberColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2e30);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn storeNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Store_NumberColumn;
					this[storeNumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Tans_Remaining
			{
				get
				{
					int num;
					try
					{
						object item = this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Tans_RemainingColumn];
						int integer = Conversions.ToInteger(item);
						num = integer;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1fe4);
						throw new StrongTypingException(str, invalidCastException);
					}
					return num;
				}
				set
				{
					DataColumn tansRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Tans_RemainingColumn;
					this[tansRemainingColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Work_Extension
			{
				get
				{
					string str;
					try
					{
						DataColumn workExtensionColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_ExtensionColumn;
						object item = this[workExtensionColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1c60);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn workExtensionColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_ExtensionColumn;
					this[workExtensionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Work_Phone
			{
				get
				{
					string str;
					try
					{
						DataColumn workPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_PhoneColumn;
						object item = this[workPhoneColumn];
						string str1 = Conversions.ToString(item);
						str = str1;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1be1);
						throw new StrongTypingException(str2, invalidCastException);
					}
					return str;
				}
				set
				{
					DataColumn workPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_PhoneColumn;
					this[workPhoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ClientsRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				this.cc68d82fdcf05ca12c82af71ae5bd7b43 = (dsClient.ClientsDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAddressNull()
			{
				DataColumn addressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.AddressColumn;
				bool flag = this.IsNull(addressColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbAllow_Direct_mailNull()
			{
				DataColumn bAllowDirectMailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_Direct_mailColumn;
				return this.IsNull(bAllowDirectMailColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbAllow_EmailNull()
			{
				DataColumn bAllowEmailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_EmailColumn;
				bool flag = this.IsNull(bAllowEmailColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbHas_CC_EFTNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_CC_EFTColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbHas_Checking_EFTNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_Checking_EFTColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbRepeat_CustNull()
			{
				DataColumn bRepeatCustColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bRepeat_CustColumn;
				return this.IsNull(bRepeatCustColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCell_PhoneNull()
			{
				DataColumn cellPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Cell_PhoneColumn;
				return this.IsNull(cellPhoneColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCityNull()
			{
				DataColumn cityColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CityColumn;
				bool flag = this.IsNull(cityColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsClient_NumberNull()
			{
				DataColumn clientNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Client_NumberColumn;
				bool flag = this.IsNull(clientNumberColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountryNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountryColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountyNull()
			{
				return this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDL_NumberNull()
			{
				DataColumn dLNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_NumberColumn;
				bool flag = this.IsNull(dLNumberColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDL_State_Or_ProvinceNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_State_Or_ProvinceColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtBirthNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtBirthColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtContactNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtContactColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtCreatedNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtCreatedColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtLast_VisitNull()
			{
				DataColumn dtLastVisitColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtLast_VisitColumn;
				return this.IsNull(dtLastVisitColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdtReleaseNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtReleaseColumn;
				bool flag = this.IsNull(dataColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_3Digit_CodeNull()
			{
				DataColumn eFTCC3DigitCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_3Digit_CodeColumn;
				bool flag = this.IsNull(eFTCC3DigitCodeColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_Billing_AddressNull()
			{
				DataColumn eFTCCBillingAddressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Billing_AddressColumn;
				bool flag = this.IsNull(eFTCCBillingAddressColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_ExpireNull()
			{
				DataColumn eFTCCExpireColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ExpireColumn;
				return this.IsNull(eFTCCExpireColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_Name_On_CardNull()
			{
				DataColumn eFTCCNameOnCardColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Name_On_CardColumn;
				bool flag = this.IsNull(eFTCCNameOnCardColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_NumNull()
			{
				DataColumn eFTCCNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_NumColumn;
				bool flag = this.IsNull(eFTCCNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_CC_ZipNull()
			{
				DataColumn eFTCCZipColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ZipColumn;
				return this.IsNull(eFTCCZipColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_Checking_Account_NumNull()
			{
				DataColumn eFTCheckingAccountNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Account_NumColumn;
				bool flag = this.IsNull(eFTCheckingAccountNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEFT_Checking_Routing_NumNull()
			{
				DataColumn eFTCheckingRoutingNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Routing_NumColumn;
				bool flag = this.IsNull(eFTCheckingRoutingNumColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEmailNull()
			{
				DataColumn emailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EmailColumn;
				bool flag = this.IsNull(emailColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFirst_NameNull()
			{
				DataColumn firstNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.First_NameColumn;
				bool flag = this.IsNull(firstNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsHome_PhoneNull()
			{
				DataColumn homePhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Home_PhoneColumn;
				bool flag = this.IsNull(homePhoneColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLast_Bed_IDNull()
			{
				DataColumn lastBedIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_Bed_IDColumn;
				bool flag = this.IsNull(lastBedIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLast_LengthNull()
			{
				DataColumn lastLengthColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_LengthColumn;
				bool flag = this.IsNull(lastLengthColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLast_NameNull()
			{
				DataColumn lastNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_NameColumn;
				bool flag = this.IsNull(lastNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMarital_StatusNull()
			{
				DataColumn maritalStatusColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Marital_StatusColumn;
				return this.IsNull(maritalStatusColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMiddle_InitialNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.Middle_InitialColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMinutes_RemainingNull()
			{
				DataColumn minutesRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Minutes_RemainingColumn;
				bool flag = this.IsNull(minutesRemainingColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPicture_IDNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.Picture_IDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPoints_RemainingNull()
			{
				return this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.Points_RemainingColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPostal_CodeNull()
			{
				DataColumn postalCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Postal_CodeColumn;
				bool flag = this.IsNull(postalCodeColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReferral_IDNull()
			{
				DataColumn referralIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Referral_IDColumn;
				bool flag = this.IsNull(referralIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReferredBy_Client_IDNull()
			{
				DataColumn referredByClientIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_IDColumn;
				bool flag = this.IsNull(referredByClientIDColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReferredBy_Client_NameNull()
			{
				DataColumn referredByClientNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_NameColumn;
				bool flag = this.IsNull(referredByClientNameColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReward_DollarsNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.Reward_DollarsColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSexNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.SexColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSkin_Type_IDNull()
			{
				DataColumn skinTypeIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Skin_Type_IDColumn;
				return this.IsNull(skinTypeIDColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSpecial_NoteNull()
			{
				DataColumn specialNoteColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Special_NoteColumn;
				bool flag = this.IsNull(specialNoteColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsState_Or_ProvinceNull()
			{
				DataColumn stateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.State_Or_ProvinceColumn;
				bool flag = this.IsNull(stateOrProvinceColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsStore_NumberNull()
			{
				DataColumn storeNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Store_NumberColumn;
				bool flag = this.IsNull(storeNumberColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTans_RemainingNull()
			{
				DataColumn tansRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Tans_RemainingColumn;
				return this.IsNull(tansRemainingColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsWork_ExtensionNull()
			{
				bool flag = this.IsNull(this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_ExtensionColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsWork_PhoneNull()
			{
				DataColumn workPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_PhoneColumn;
				bool flag = this.IsNull(workPhoneColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAddressNull()
			{
				DataColumn addressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.AddressColumn;
				this[addressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbAllow_Direct_mailNull()
			{
				DataColumn bAllowDirectMailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_Direct_mailColumn;
				this[bAllowDirectMailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbAllow_EmailNull()
			{
				DataColumn bAllowEmailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bAllow_EmailColumn;
				this[bAllowEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbHas_CC_EFTNull()
			{
				DataColumn bHasCCEFTColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_CC_EFTColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[bHasCCEFTColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbHas_Checking_EFTNull()
			{
				DataColumn bHasCheckingEFTColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bHas_Checking_EFTColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[bHasCheckingEFTColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbRepeat_CustNull()
			{
				DataColumn bRepeatCustColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.bRepeat_CustColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[bRepeatCustColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCell_PhoneNull()
			{
				DataColumn cellPhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Cell_PhoneColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[cellPhoneColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCityNull()
			{
				DataColumn cityColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CityColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[cityColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClient_NumberNull()
			{
				DataColumn clientNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Client_NumberColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[clientNumberColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCountryNull()
			{
				DataColumn countryColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountryColumn;
				this[countryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCountyNull()
			{
				DataColumn countyColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.CountyColumn;
				this[countyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDL_NumberNull()
			{
				DataColumn dLNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_NumberColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dLNumberColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDL_State_Or_ProvinceNull()
			{
				DataColumn dLStateOrProvinceColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.DL_State_Or_ProvinceColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dLStateOrProvinceColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtBirthNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtBirthColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtContactNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtContactColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtCreatedNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtCreatedColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtLast_VisitNull()
			{
				DataColumn dtLastVisitColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtLast_VisitColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dtLastVisitColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdtReleaseNull()
			{
				DataColumn dataColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.dtReleaseColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[dataColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_3Digit_CodeNull()
			{
				DataColumn eFTCC3DigitCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_3Digit_CodeColumn;
				this[eFTCC3DigitCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_Billing_AddressNull()
			{
				DataColumn eFTCCBillingAddressColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Billing_AddressColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[eFTCCBillingAddressColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_ExpireNull()
			{
				DataColumn eFTCCExpireColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ExpireColumn;
				this[eFTCCExpireColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_Name_On_CardNull()
			{
				DataColumn eFTCCNameOnCardColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_Name_On_CardColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[eFTCCNameOnCardColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_NumNull()
			{
				DataColumn eFTCCNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_NumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[eFTCCNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_CC_ZipNull()
			{
				DataColumn eFTCCZipColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_CC_ZipColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[eFTCCZipColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_Checking_Account_NumNull()
			{
				DataColumn eFTCheckingAccountNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Account_NumColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[eFTCheckingAccountNumColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEFT_Checking_Routing_NumNull()
			{
				DataColumn eFTCheckingRoutingNumColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EFT_Checking_Routing_NumColumn;
				this[eFTCheckingRoutingNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEmailNull()
			{
				DataColumn emailColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.EmailColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[emailColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetFirst_NameNull()
			{
				DataColumn firstNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.First_NameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[firstNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetHome_PhoneNull()
			{
				DataColumn homePhoneColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Home_PhoneColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[homePhoneColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetLast_Bed_IDNull()
			{
				DataColumn lastBedIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_Bed_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[lastBedIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetLast_LengthNull()
			{
				DataColumn lastLengthColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_LengthColumn;
				this[lastLengthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetLast_NameNull()
			{
				DataColumn lastNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Last_NameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[lastNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMarital_StatusNull()
			{
				DataColumn maritalStatusColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Marital_StatusColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[maritalStatusColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMiddle_InitialNull()
			{
				DataColumn middleInitialColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Middle_InitialColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[middleInitialColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMinutes_RemainingNull()
			{
				DataColumn minutesRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Minutes_RemainingColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[minutesRemainingColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPicture_IDNull()
			{
				DataColumn pictureIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Picture_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[pictureIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPoints_RemainingNull()
			{
				DataColumn pointsRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Points_RemainingColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[pointsRemainingColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPostal_CodeNull()
			{
				DataColumn postalCodeColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Postal_CodeColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[postalCodeColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReferral_IDNull()
			{
				DataColumn referralIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Referral_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[referralIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReferredBy_Client_IDNull()
			{
				DataColumn referredByClientIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[referredByClientIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReferredBy_Client_NameNull()
			{
				DataColumn referredByClientNameColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.ReferredBy_Client_NameColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[referredByClientNameColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReward_DollarsNull()
			{
				DataColumn rewardDollarsColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Reward_DollarsColumn;
				this[rewardDollarsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSexNull()
			{
				DataColumn sexColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.SexColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[sexColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSkin_Type_IDNull()
			{
				DataColumn skinTypeIDColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Skin_Type_IDColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[skinTypeIDColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSpecial_NoteNull()
			{
				DataColumn specialNoteColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Special_NoteColumn;
				this[specialNoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetState_Or_ProvinceNull()
			{
				this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.State_Or_ProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetStore_NumberNull()
			{
				DataColumn storeNumberColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Store_NumberColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[storeNumberColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTans_RemainingNull()
			{
				DataColumn tansRemainingColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Tans_RemainingColumn;
				this[tansRemainingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetWork_ExtensionNull()
			{
				DataColumn workExtensionColumn = this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_ExtensionColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[workExtensionColumn] = objectValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetWork_PhoneNull()
			{
				this[this.cc68d82fdcf05ca12c82af71ae5bd7b43.Work_PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ClientsRowChangeEvent : EventArgs
		{
			private dsClient.ClientsRow c1cbccf2ba30b0268c407c29b056c2fdd;

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
			public dsClient.ClientsRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ClientsRowChangeEvent(dsClient.ClientsRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ClientsRowChangeEventHandler(object sender, dsClient.ClientsRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class PicturesDataTable : TypedTableBase<dsClient.PicturesRow>
		{
			private DataColumn columnID;

			private DataColumn columnPicture;

			private dsClient.PicturesRowChangeEventHandler PicturesRowChangingEvent;

			private dsClient.PicturesRowChangeEventHandler PicturesRowChangedEvent;

			private dsClient.PicturesRowChangeEventHandler PicturesRowDeletingEvent;

			private dsClient.PicturesRowChangeEventHandler PicturesRowDeletedEvent;

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
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsClient.PicturesRow this[int index]
			{
				get
				{
					DataRow item = this.Rows[index];
					return (dsClient.PicturesRow)item;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PictureColumn
			{
				get
				{
					return this.columnPicture;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public PicturesDataTable()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1002);
				this.TableName = str;
				this.BeginInit();
				this.ce9285e807b6d3d13062294184142fedb();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal PicturesDataTable(DataTable cba67311e6db443cfae5b772a52ce76ac)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsClient/PicturesDataTable::.ctor(System.Data.DataTable)
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
			protected PicturesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.cfb93e8c2fa64f1123fa8988e476c2203();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddPicturesRow(dsClient.PicturesRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsClient.PicturesRow AddPicturesRow(long ID, byte[] Picture)
			{
				DataRow dataRow = this.NewRow();
				dsClient.PicturesRow d = (dsClient.PicturesRow)dataRow;
				d.ItemArray = new object[] { ID, Picture };
				DataRowCollection rows = this.Rows;
				rows.Add(d);
				return d;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void ce9285e807b6d3d13062294184142fedb()
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(151);
				Type type = typeof(long);
				this.columnID = new DataColumn(str, type, null, MappingType.Element);
				DataColumnCollection columns = base.Columns;
				columns.Add(this.columnID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x15bb);
				Type type1 = typeof(byte[]);
				this.columnPicture = new DataColumn(str1, type1, null, MappingType.Element);
				base.Columns.Add(this.columnPicture);
				ConstraintCollection constraints = this.Constraints;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1583);
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnID };
				constraints.Add(new UniqueConstraint(str2, dataColumnArray, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
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
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x15bb);
				this.columnPicture = dataColumnCollection[str1];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable dataTable = base.Clone();
				dsClient.PicturesDataTable picturesDataTable = (dsClient.PicturesDataTable)dataTable;
				picturesDataTable.cfb93e8c2fa64f1123fa8988e476c2203();
				return picturesDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsClient.PicturesDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsClient.PicturesRow FindByID(long ID)
			{
				DataRowCollection rows = this.Rows;
				object[] d = new object[] { ID };
				return (dsClient.PicturesRow)rows.Find(d);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dsClient.PicturesRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				// 
				// Current member / type: System.Xml.Schema.XmlSchemaComplexType SqlLibrary.dsClient/PicturesDataTable::GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet)
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
			public dsClient.PicturesRow NewPicturesRow()
			{
				DataRow dataRow = this.NewRow();
				return (dsClient.PicturesRow)dataRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsClient.PicturesRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				// 
				// Current member / type: System.Void SqlLibrary.dsClient/PicturesDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/PicturesDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/PicturesDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				// Current member / type: System.Void SqlLibrary.dsClient/PicturesDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			public void RemovePicturesRow(dsClient.PicturesRow row)
			{
				DataRowCollection rows = this.Rows;
				rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.PicturesRowChangeEventHandler PicturesRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.PicturesRowChangedEvent, obj);
					this.PicturesRowChangedEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.PicturesRowChangedEvent, obj);
					this.PicturesRowChangedEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.PicturesRowChangeEventHandler PicturesRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.PicturesRowChangingEvent, obj);
					this.PicturesRowChangingEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.PicturesRowChangingEvent, obj);
					this.PicturesRowChangingEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.PicturesRowChangeEventHandler PicturesRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.PicturesRowDeletedEvent, obj);
					this.PicturesRowDeletedEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.PicturesRowDeletedEvent, obj);
					this.PicturesRowDeletedEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsClient.PicturesRowChangeEventHandler PicturesRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					Delegate @delegate = Delegate.Combine(this.PicturesRowDeletingEvent, obj);
					this.PicturesRowDeletingEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					Delegate @delegate = Delegate.Remove(this.PicturesRowDeletingEvent, obj);
					this.PicturesRowDeletingEvent = (dsClient.PicturesRowChangeEventHandler)@delegate;
				}
			}
		}

		public class PicturesRow : DataRow
		{
			private dsClient.PicturesDataTable cd4bcc7407d1b032726cf6ef822e95ade;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public long ID
			{
				get
				{
					DataColumn dColumn = this.cd4bcc7407d1b032726cf6ef822e95ade.IDColumn;
					object item = this[dColumn];
					long num = Conversions.ToLong(item);
					return num;
				}
				set
				{
					this[this.cd4bcc7407d1b032726cf6ef822e95ade.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] Picture
			{
				get
				{
					byte[] numArray;
					try
					{
						DataColumn pictureColumn = this.cd4bcc7407d1b032726cf6ef822e95ade.PictureColumn;
						object item = this[pictureColumn];
						numArray = (byte[])item;
					}
					catch (InvalidCastException invalidCastException1)
					{
						ProjectData.SetProjectError(invalidCastException1);
						InvalidCastException invalidCastException = invalidCastException1;
						string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2fe0);
						throw new StrongTypingException(str, invalidCastException);
					}
					return numArray;
				}
				set
				{
					DataColumn pictureColumn = this.cd4bcc7407d1b032726cf6ef822e95ade.PictureColumn;
					this[pictureColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal PicturesRow(DataRowBuilder c6e4838155b30365f8464dd2b19119c25) : base(c6e4838155b30365f8464dd2b19119c25)
			{
				DataTable table = this.Table;
				this.cd4bcc7407d1b032726cf6ef822e95ade = (dsClient.PicturesDataTable)table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPictureNull()
			{
				DataColumn pictureColumn = this.cd4bcc7407d1b032726cf6ef822e95ade.PictureColumn;
				bool flag = this.IsNull(pictureColumn);
				return flag;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPictureNull()
			{
				DataColumn pictureColumn = this.cd4bcc7407d1b032726cf6ef822e95ade.PictureColumn;
				object objectValue = RuntimeHelpers.GetObjectValue(Convert.DBNull);
				this[pictureColumn] = objectValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class PicturesRowChangeEvent : EventArgs
		{
			private dsClient.PicturesRow c1cbccf2ba30b0268c407c29b056c2fdd;

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
			public dsClient.PicturesRow Row
			{
				get
				{
					return this.c1cbccf2ba30b0268c407c29b056c2fdd;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public PicturesRowChangeEvent(dsClient.PicturesRow row, DataRowAction action)
			{
				this.c1cbccf2ba30b0268c407c29b056c2fdd = row;
				this.c066b556286adffc3d6471a61b6be6ffc = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void PicturesRowChangeEventHandler(object sender, dsClient.PicturesRowChangeEvent e);
	}
}