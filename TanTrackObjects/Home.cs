using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class Home
	{
		private dbHome c159fce105a6ad06c71422bf493aa6e90;

		public Home()
		{
			this.c159fce105a6ad06c71422bf493aa6e90 = new dbHome();
		}

		public DataSet Check_Remote_Status(string phone)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Check_Remote_Status(phone);
		}

		public DataSet CheckLStatus(string phone, string name, string mac)
		{
			DataSet dataSet = this.c159fce105a6ad06c71422bf493aa6e90.CheckLStatus(phone, name, mac);
			return dataSet;
		}

		public DataSet CheckPiracy(string phone)
		{
			DataSet dataSet = this.c159fce105a6ad06c71422bf493aa6e90.CheckPiracy(phone);
			return dataSet;
		}

		public DataSet CheckSupportStatus(string phone)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.CheckSupportStatus(phone);
		}

		public DataSet LoadNews(DateTime ExeDate, string verNum)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.LoadNews(ExeDate, verNum);
		}

		public DataSet LoadSupport(DateTime ExeDate, string verNum)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.LoadSupport(ExeDate, verNum);
		}

		public bool UpdateVersion(string version, DateTime dtEXE, DateTime dt, string phone)
		{
			bool flag = this.c159fce105a6ad06c71422bf493aa6e90.UpdateVersion(version, dtEXE, dt, phone);
			return flag;
		}
	}
}