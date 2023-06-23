using A;
using Microsoft.VisualBasic.CompilerServices;
using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class Bucket
	{
		private int ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;

		private string c5b1d3e7d0c14fd00c089e8f881a7916c;

		private int c71daf099810ce1eccb06bd8d3133bf07;

		private bool c7bf73ce1786f8eb9c2d85f507c7b8be7;

		private bool cade2ca018ad1079c607f62000686761d;

		private bool c0f987055cb54ead72758a4fdb6513cce;

		private bool c773856ba409b5e943dca9ecab5750671;

		private bool cb5f66560c223c123bf31339a9124c31c;

		private bool c29bf02c94a1167cce6f49a857268253c;

		private bool cf22be60f67e583cf7821bea154a70dad;

		private dbBucket c159fce105a6ad06c71422bf493aa6e90;

		public bool bFriday
		{
			get
			{
				return this.cb5f66560c223c123bf31339a9124c31c;
			}
			set
			{
				this.cb5f66560c223c123bf31339a9124c31c = value;
			}
		}

		public bool bMonday
		{
			get
			{
				return this.c7bf73ce1786f8eb9c2d85f507c7b8be7;
			}
			set
			{
				this.c7bf73ce1786f8eb9c2d85f507c7b8be7 = value;
			}
		}

		public bool bSaturday
		{
			get
			{
				return this.c29bf02c94a1167cce6f49a857268253c;
			}
			set
			{
				this.c29bf02c94a1167cce6f49a857268253c = value;
			}
		}

		public bool bSunday
		{
			get
			{
				return this.cf22be60f67e583cf7821bea154a70dad;
			}
			set
			{
				this.cf22be60f67e583cf7821bea154a70dad = value;
			}
		}

		public bool bThursday
		{
			get
			{
				return this.c773856ba409b5e943dca9ecab5750671;
			}
			set
			{
				this.c773856ba409b5e943dca9ecab5750671 = value;
			}
		}

		public bool bTuesday
		{
			get
			{
				return this.cade2ca018ad1079c607f62000686761d;
			}
			set
			{
				this.cade2ca018ad1079c607f62000686761d = value;
			}
		}

		public string BucketName
		{
			get
			{
				return this.c5b1d3e7d0c14fd00c089e8f881a7916c;
			}
			set
			{
				this.c5b1d3e7d0c14fd00c089e8f881a7916c = value;
			}
		}

		public int BucketType
		{
			get
			{
				return this.c71daf099810ce1eccb06bd8d3133bf07;
			}
			set
			{
				this.c71daf099810ce1eccb06bd8d3133bf07 = value;
			}
		}

		public bool bWednesday
		{
			get
			{
				return this.c0f987055cb54ead72758a4fdb6513cce;
			}
			set
			{
				this.c0f987055cb54ead72758a4fdb6513cce = value;
			}
		}

		public int ID
		{
			get
			{
				return this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;
			}
			set
			{
				this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = value;
			}
		}

		public Bucket()
		{
			this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = 0;
			this.c5b1d3e7d0c14fd00c089e8f881a7916c = "";
			this.c71daf099810ce1eccb06bd8d3133bf07 = 0;
			this.c7bf73ce1786f8eb9c2d85f507c7b8be7 = false;
			this.cade2ca018ad1079c607f62000686761d = false;
			this.c0f987055cb54ead72758a4fdb6513cce = false;
			this.c773856ba409b5e943dca9ecab5750671 = false;
			this.cb5f66560c223c123bf31339a9124c31c = false;
			this.c29bf02c94a1167cce6f49a857268253c = false;
			this.cf22be60f67e583cf7821bea154a70dad = false;
			this.c159fce105a6ad06c71422bf493aa6e90 = new dbBucket();
		}

		public bool LoadBucket(string name)
		{
			bool flag;
			try
			{
				DataSet dataSet = new DataSet();
				DataSet dataSet1 = this.c159fce105a6ad06c71422bf493aa6e90.LoadBucketbyName(name);
				dataSet = dataSet1;
				DataTable item = dataSet.Tables[0];
				DataRowCollection rows = item.Rows;
				int count = rows.Count;
				if (count != 0)
				{
					DataTableCollection tables = dataSet.Tables;
					DataTable dataTable = tables[0];
					DataRow dataRow = dataTable.Rows[0];
					string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(1);
					object obj = dataRow[str];
					int integer = Conversions.ToInteger(obj);
					this.ID = integer;
					DataTableCollection dataTableCollection = dataSet.Tables;
					DataTable item1 = dataTableCollection[0];
					DataRowCollection dataRowCollection = item1.Rows;
					DataRow dataRow1 = dataRowCollection[0];
					string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x882);
					object obj1 = dataRow1[str1];
					string str2 = Conversions.ToString(obj1);
					this.BucketName = str2;
					DataTableCollection tables1 = dataSet.Tables;
					DataTable dataTable1 = tables1[0];
					DataRowCollection rows1 = dataTable1.Rows;
					DataRow item2 = rows1[0];
					string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x897);
					int num = Conversions.ToInteger(item2[str3]);
					this.BucketType = num;
					DataTable dataTable2 = dataSet.Tables[0];
					DataRow dataRow2 = dataTable2.Rows[0];
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ac);
					object obj2 = dataRow2[str4];
					this.bMonday = Conversions.ToBoolean(obj2);
					DataTableCollection dataTableCollection1 = dataSet.Tables;
					DataTable item3 = dataTableCollection1[0];
					DataRow dataRow3 = item3.Rows[0];
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8bb);
					object obj3 = dataRow3[str5];
					bool flag1 = Conversions.ToBoolean(obj3);
					this.bTuesday = flag1;
					DataTableCollection tables2 = dataSet.Tables;
					DataTable dataTable3 = tables2[0];
					DataRowCollection dataRowCollection1 = dataTable3.Rows;
					DataRow item4 = dataRowCollection1[0];
					string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8cc);
					object obj4 = item4[str6];
					bool flag2 = Conversions.ToBoolean(obj4);
					this.bWednesday = flag2;
					DataTableCollection dataTableCollection2 = dataSet.Tables;
					DataTable dataTable4 = dataTableCollection2[0];
					DataRowCollection rows2 = dataTable4.Rows;
					DataRow dataRow4 = rows2[0];
					string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e1);
					object item5 = dataRow4[str7];
					bool flag3 = Conversions.ToBoolean(item5);
					this.bThursday = flag3;
					DataTableCollection tables3 = dataSet.Tables;
					DataTable dataTable5 = tables3[0];
					DataRowCollection dataRowCollection2 = dataTable5.Rows;
					DataRow dataRow5 = dataRowCollection2[0];
					string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8f4);
					object obj5 = dataRow5[str8];
					bool flag4 = Conversions.ToBoolean(obj5);
					this.bFriday = flag4;
					DataTableCollection dataTableCollection3 = dataSet.Tables;
					DataTable item6 = dataTableCollection3[0];
					DataRowCollection rows3 = item6.Rows;
					DataRow dataRow6 = rows3[0];
					string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x903);
					object obj6 = dataRow6[str9];
					this.bSaturday = Conversions.ToBoolean(obj6);
					DataTableCollection tables4 = dataSet.Tables;
					DataTable dataTable6 = tables4[0];
					DataRowCollection dataRowCollection3 = dataTable6.Rows;
					DataRow item7 = dataRowCollection3[0];
					string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x916);
					object obj7 = item7[str10];
					this.bSunday = Conversions.ToBoolean(obj7);
					dataSet = null;
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}
}