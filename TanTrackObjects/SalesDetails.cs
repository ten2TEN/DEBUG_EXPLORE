using Microsoft.VisualBasic;
using SqlLibrary;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace TanTrackObjects
{
	public class SalesDetails
	{
		private int ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;

		private int c5d74ba5cfaff75cf41530577d343b40f;

		private bool caee392023c86dbe0aa9e2e746e82f522;

		private int c74504ca22e8b1802b6bb96bb2a9fa20e;

		private double ca55e6cca6fc140cf66f7e9831077fae9;

		private double c6e9ae8aa94c86f2b156d214326e6531f;

		private double c38a5860095f9c462b33bc67453e4e43e;

		private double cb009eb05e194ad66a23026640526d166;

		private int c535a636b673b9e6a06783dfe4edc312e;

		private string cb501ea3335b43b6f6f931d2848678e9a;

		private bool cab29f0ad938a7a4ec9139c4ea13ed48f;

		private int c3701a8067dd861ece94e53d2e115e397;

		private string ce421080d3b13873e9f3afd704375441d;

		private int c18c61be3f2d9f7acdb92fef3c3e10a67;

		private double c946095e7d1a83f832cada37e4431dbbf;

		private int cdf7915c5467ba2770a2c06306f9b6b60;

		private DataSet c5561cf841cbdf0b5aa63d2cb94a5e6ff;

		private dbSale ca379c245fc4cfb1160e6bf3c0ebad564;

		public int ClientPkgID
		{
			get
			{
				return this.cdf7915c5467ba2770a2c06306f9b6b60;
			}
			set
			{
				this.cdf7915c5467ba2770a2c06306f9b6b60 = value;
			}
		}

		public double Commission
		{
			get
			{
				return this.cb009eb05e194ad66a23026640526d166;
			}
			set
			{
				this.cb009eb05e194ad66a23026640526d166 = value;
			}
		}

		public dbSale db
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

		public bool IsEFTPayment
		{
			get
			{
				return this.cab29f0ad938a7a4ec9139c4ea13ed48f;
			}
			set
			{
				this.cab29f0ad938a7a4ec9139c4ea13ed48f = value;
			}
		}

		public bool IsProduct
		{
			get
			{
				return this.caee392023c86dbe0aa9e2e746e82f522;
			}
			set
			{
				this.caee392023c86dbe0aa9e2e746e82f522 = value;
			}
		}

		public string ItemName
		{
			get
			{
				return this.ce421080d3b13873e9f3afd704375441d;
			}
			set
			{
				this.ce421080d3b13873e9f3afd704375441d = value;
			}
		}

		public int ItemType
		{
			get
			{
				return this.c3701a8067dd861ece94e53d2e115e397;
			}
			set
			{
				this.c3701a8067dd861ece94e53d2e115e397 = value;
			}
		}

		public int PAndSID
		{
			get
			{
				return this.c74504ca22e8b1802b6bb96bb2a9fa20e;
			}
			set
			{
				this.c74504ca22e8b1802b6bb96bb2a9fa20e = value;
			}
		}

		public int PerformerID
		{
			get
			{
				return this.c535a636b673b9e6a06783dfe4edc312e;
			}
			set
			{
				this.c535a636b673b9e6a06783dfe4edc312e = value;
			}
		}

		public string PerformerName
		{
			get
			{
				return this.cb501ea3335b43b6f6f931d2848678e9a;
			}
			set
			{
				this.cb501ea3335b43b6f6f931d2848678e9a = value;
			}
		}

		public double Price
		{
			get
			{
				return this.c6e9ae8aa94c86f2b156d214326e6531f;
			}
			set
			{
				this.c6e9ae8aa94c86f2b156d214326e6531f = value;
			}
		}

		public double Qty
		{
			get
			{
				return this.ca55e6cca6fc140cf66f7e9831077fae9;
			}
			set
			{
				this.ca55e6cca6fc140cf66f7e9831077fae9 = value;
			}
		}

		public double RefQty
		{
			get
			{
				return this.c946095e7d1a83f832cada37e4431dbbf;
			}
			set
			{
				this.c946095e7d1a83f832cada37e4431dbbf = value;
			}
		}

		public int RefSaleID
		{
			get
			{
				return this.c18c61be3f2d9f7acdb92fef3c3e10a67;
			}
			set
			{
				this.c18c61be3f2d9f7acdb92fef3c3e10a67 = value;
			}
		}

		public int SaleID
		{
			get
			{
				return this.c5d74ba5cfaff75cf41530577d343b40f;
			}
			set
			{
				this.c5d74ba5cfaff75cf41530577d343b40f = value;
			}
		}

		public double Tax
		{
			get
			{
				return this.c38a5860095f9c462b33bc67453e4e43e;
			}
			set
			{
				this.c38a5860095f9c462b33bc67453e4e43e = value;
			}
		}

		public SalesDetails()
		{
			this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = new int();
			this.c5561cf841cbdf0b5aa63d2cb94a5e6ff = new DataSet();
			this.ca379c245fc4cfb1160e6bf3c0ebad564 = new dbSale();
		}

		private object c1b95a3e96f0a5466604b2e0304bd2b04(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ce5f8f2f2cdceaf36fe8cd52bf4c9f139);
			bool flag = Information.IsDBNull(objectValue);
			if (flag)
			{
				return null;
			}
			return ce5f8f2f2cdceaf36fe8cd52bf4c9f139;
		}
	}
}