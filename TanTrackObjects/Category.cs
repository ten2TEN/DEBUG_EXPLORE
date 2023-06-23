using A;
using Microsoft.VisualBasic.CompilerServices;
using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class Category
	{
		private int cf389da6dd3d599c20a5d6e23392df500;

		private string c5197932e1605d215a7828015bb806e98;

		private int c9819f714a3ab0c8198288b2d2de1bb00;

		private string c6ce17fad5fa1506c98411d1fd6ee549b;

		private DataSet c83af6310381e48dafa9edfaa3ff91e0e;

		private dbCategory ca379c245fc4cfb1160e6bf3c0ebad564;

		public int Color
		{
			get
			{
				return this.c9819f714a3ab0c8198288b2d2de1bb00;
			}
			set
			{
				this.c9819f714a3ab0c8198288b2d2de1bb00 = value;
			}
		}

		public dbCategory db
		{
			get
			{
				return this.ca379c245fc4cfb1160e6bf3c0ebad564;
			}
			set
			{
				this.ca379c245fc4cfb1160e6bf3c0ebad564 = value;
			}
		}

		public DataSet ds
		{
			get
			{
				return this.c83af6310381e48dafa9edfaa3ff91e0e;
			}
			set
			{
				this.c83af6310381e48dafa9edfaa3ff91e0e = value;
			}
		}

		public int ID
		{
			get
			{
				return this.cf389da6dd3d599c20a5d6e23392df500;
			}
			set
			{
				this.cf389da6dd3d599c20a5d6e23392df500 = value;
			}
		}

		public string Name
		{
			get
			{
				return this.c5197932e1605d215a7828015bb806e98;
			}
			set
			{
				this.c5197932e1605d215a7828015bb806e98 = value;
			}
		}

		public string Note
		{
			get
			{
				return this.c6ce17fad5fa1506c98411d1fd6ee549b;
			}
			set
			{
				this.c6ce17fad5fa1506c98411d1fd6ee549b = value;
			}
		}

		public Category()
		{
			this.c83af6310381e48dafa9edfaa3ff91e0e = new DataSet();
			this.ca379c245fc4cfb1160e6bf3c0ebad564 = new dbCategory();
		}

		public bool AddCategory(string categry)
		{
			bool flag;
			try
			{
				bool flag1 = this.db.AddCategory(categry);
				flag = flag1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int IsCategoryInUse(int CategoryID)
		{
			int num;
			try
			{
				dbCategory _dbCategory = this.db;
				int num1 = _dbCategory.IsCategoryInUse(CategoryID);
				num = num1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public DataSet Load()
		{
			dbCategory _dbCategory = this.db;
			DataSet dataSet = _dbCategory.CategoryList();
			return dataSet;
		}

		public bool Reassign(int ReferalID, int NewID)
		{
			dbCategory _dbCategory = this.db;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x925);
			bool flag = _dbCategory.Reassign(ReferalID, NewID, str);
			return flag;
		}

		public bool RemoveCategory(int CategoryID)
		{
			bool flag;
			try
			{
				dbCategory _dbCategory = this.db;
				bool flag1 = _dbCategory.DeleteCategory(CategoryID);
				flag = flag1;
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