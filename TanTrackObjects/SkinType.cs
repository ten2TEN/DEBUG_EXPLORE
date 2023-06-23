using A;
using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class SkinType
	{
		private int cf389da6dd3d599c20a5d6e23392df500;

		private string c5197932e1605d215a7828015bb806e98;

		private string c228cb31eefe04bbde923998d70722be3;

		private DataSet c83af6310381e48dafa9edfaa3ff91e0e;

		private dbCategory ca379c245fc4cfb1160e6bf3c0ebad564;

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

		public string Description
		{
			get
			{
				return this.c228cb31eefe04bbde923998d70722be3;
			}
			set
			{
				this.c228cb31eefe04bbde923998d70722be3 = value;
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

		public SkinType()
		{
			this.c83af6310381e48dafa9edfaa3ff91e0e = new DataSet();
			this.ca379c245fc4cfb1160e6bf3c0ebad564 = new dbCategory();
		}

		public bool AddSkinType(string skin)
		{
			dbCategory _dbCategory = this.db;
			return _dbCategory.AddSkin(skin);
		}

		public int IsSkinInUse(int SkinID)
		{
			int num = this.db.IsSkinInUse(SkinID);
			return num;
		}

		public DataSet Load()
		{
			dbCategory _dbCategory = this.db;
			return _dbCategory.SkinTypeList();
		}

		public bool Reassign(int ReferalID, int NewID)
		{
			dbCategory _dbCategory = this.db;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x43b0);
			return _dbCategory.Reassign(ReferalID, NewID, str);
		}

		public bool RemoveSkinType(int SkinID)
		{
			return this.db.DeleteSkinType(SkinID);
		}
	}
}