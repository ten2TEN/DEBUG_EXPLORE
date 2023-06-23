using Microsoft.VisualBasic;
using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class Appointments
	{
		private int ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;

		private DateTime c6238fdac87750e2c1942043de294ad0e;

		private int cded32d3a7be65a3d16b917800d566731;

		private bool c056286f718a506d60a664f11c92dba97;

		private bool cf5fb28baba6922de54af4e7bfbd44152;

		private bool c5c962e88757ac97b626df5c51649b409;

		private bool c15e49067be1eff0143e760a7878438f6;

		private int cd7df0f0a8e8be7ad7785d03345b1ac81;

		private int cfed2981a762e2fce7599f740a45f7301;

		private string c2168f76345360f219e4815caf6da0fd8;

		private int c604d071ad13e11aaa522cf5e50d5a174;

		private string cf80df6b71cc36123ce20dfa965384796;

		private int c9823ebee90e7ac9de53ca6ccc3a644d0;

		private int cbea442e2b005360db1aa13a804390c70;

		private string ce093341e03f428c96c7b750c352e9a37;

		private bool c760ee5f83f9e950bbac065747e665d05;

		private int c76b2c0f5d8add1779da62b6d30172836;

		private bool c052856e68168327d1f2d96987d8af533;

		private bool c82e95e927e7bd0f5c9813ff0f66fb6a7;

		private bool c5b6765da8b73668dea7eef2a3edd021f;

		private DateTime c2717d36ec910553a82920127780e56b2;

		private int c0117d626cb593e2784625e2cb4c7bdec;

		private bool c9786dd5f2733b258065bd248e526a616;

		private string c076c3d5179f345dfe6b63b972d6f376d;

		private int c9302aefd7a8f64bfdda5362f402871bb;

		private int c00754124b54a9632c18ae4ef0379887a;

		private int ca8c8f7cdfbf916bcd84a8fc93f93f120;

		private Collection c656314b1723150e95f40e0d3236692d8;

		private dbAppointment ca379c245fc4cfb1160e6bf3c0ebad564;

		private dsAppointment c83af6310381e48dafa9edfaa3ff91e0e;

		public bool AlarmDismissed
		{
			get
			{
				return this.c5b6765da8b73668dea7eef2a3edd021f;
			}
			set
			{
				this.c5b6765da8b73668dea7eef2a3edd021f = value;
			}
		}

		public bool AlarmIsArmed
		{
			get
			{
				return this.c760ee5f83f9e950bbac065747e665d05;
			}
			set
			{
				this.c760ee5f83f9e950bbac065747e665d05 = value;
			}
		}

		public bool AlarmOpen
		{
			get
			{
				return this.c052856e68168327d1f2d96987d8af533;
			}
			set
			{
				this.c052856e68168327d1f2d96987d8af533 = value;
			}
		}

		public int AlarmReminder
		{
			get
			{
				return this.c76b2c0f5d8add1779da62b6d30172836;
			}
			set
			{
				this.c76b2c0f5d8add1779da62b6d30172836 = value;
			}
		}

		public bool AlarmSnooze
		{
			get
			{
				return this.c82e95e927e7bd0f5c9813ff0f66fb6a7;
			}
			set
			{
				this.c82e95e927e7bd0f5c9813ff0f66fb6a7 = value;
			}
		}

		public Collection AppCollection
		{
			get
			{
				return this.c656314b1723150e95f40e0d3236692d8;
			}
			set
			{
				this.c656314b1723150e95f40e0d3236692d8 = value;
			}
		}

		public int BedID
		{
			get
			{
				return this.cbea442e2b005360db1aa13a804390c70;
			}
			set
			{
				this.cbea442e2b005360db1aa13a804390c70 = value;
			}
		}

		public bool Blockout
		{
			get
			{
				return this.c056286f718a506d60a664f11c92dba97;
			}
			set
			{
				this.c056286f718a506d60a664f11c92dba97 = value;
			}
		}

		public bool bUsed
		{
			get
			{
				return this.c9786dd5f2733b258065bd248e526a616;
			}
			set
			{
				this.c9786dd5f2733b258065bd248e526a616 = value;
			}
		}

		public int ClientID
		{
			get
			{
				return this.c0117d626cb593e2784625e2cb4c7bdec;
			}
			set
			{
				this.c0117d626cb593e2784625e2cb4c7bdec = value;
			}
		}

		public string ClientName
		{
			get
			{
				return this.c076c3d5179f345dfe6b63b972d6f376d;
			}
			set
			{
				this.c076c3d5179f345dfe6b63b972d6f376d = value;
			}
		}

		public int company_Row_Create_ID
		{
			get
			{
				return this.c00754124b54a9632c18ae4ef0379887a;
			}
			set
			{
				this.c00754124b54a9632c18ae4ef0379887a = value;
			}
		}

		public int company_Row_Update_ID
		{
			get
			{
				return this.ca8c8f7cdfbf916bcd84a8fc93f93f120;
			}
			set
			{
				this.ca8c8f7cdfbf916bcd84a8fc93f93f120 = value;
			}
		}

		public dbAppointment db
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

		public dsAppointment ds
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
				return this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1;
			}
			set
			{
				this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = value;
			}
		}

		public bool IsEvent
		{
			get
			{
				return this.cf5fb28baba6922de54af4e7bfbd44152;
			}
			set
			{
				this.cf5fb28baba6922de54af4e7bfbd44152 = value;
			}
		}

		public bool IsFlagged
		{
			get
			{
				return this.c5c962e88757ac97b626df5c51649b409;
			}
			set
			{
				this.c5c962e88757ac97b626df5c51649b409 = value;
			}
		}

		public bool IsReadonly
		{
			get
			{
				return this.c15e49067be1eff0143e760a7878438f6;
			}
			set
			{
				this.c15e49067be1eff0143e760a7878438f6 = value;
			}
		}

		public int Length
		{
			get
			{
				return this.cded32d3a7be65a3d16b917800d566731;
			}
			set
			{
				this.cded32d3a7be65a3d16b917800d566731 = value;
			}
		}

		public int LocNum
		{
			get
			{
				return this.c9302aefd7a8f64bfdda5362f402871bb;
			}
			set
			{
				this.c9302aefd7a8f64bfdda5362f402871bb = value;
			}
		}

		public int Maxlength
		{
			get
			{
				return this.cd7df0f0a8e8be7ad7785d03345b1ac81;
			}
			set
			{
				this.cd7df0f0a8e8be7ad7785d03345b1ac81 = value;
			}
		}

		public int Minlength
		{
			get
			{
				return this.cfed2981a762e2fce7599f740a45f7301;
			}
			set
			{
				this.cfed2981a762e2fce7599f740a45f7301 = value;
			}
		}

		public string Note
		{
			get
			{
				return this.c2168f76345360f219e4815caf6da0fd8;
			}
			set
			{
				this.c2168f76345360f219e4815caf6da0fd8 = value;
			}
		}

		public int Priority
		{
			get
			{
				return this.c604d071ad13e11aaa522cf5e50d5a174;
			}
			set
			{
				this.c604d071ad13e11aaa522cf5e50d5a174 = value;
			}
		}

		public string RecurrenceGuid
		{
			get
			{
				return this.cf80df6b71cc36123ce20dfa965384796;
			}
			set
			{
				this.cf80df6b71cc36123ce20dfa965384796 = value;
			}
		}

		public int RoomNumber
		{
			get
			{
				return this.c9823ebee90e7ac9de53ca6ccc3a644d0;
			}
			set
			{
				this.c9823ebee90e7ac9de53ca6ccc3a644d0 = value;
			}
		}

		public DateTime StartDate
		{
			get
			{
				return this.c6238fdac87750e2c1942043de294ad0e;
			}
			set
			{
				this.c6238fdac87750e2c1942043de294ad0e = value;
			}
		}

		public string Subject
		{
			get
			{
				return this.ce093341e03f428c96c7b750c352e9a37;
			}
			set
			{
				this.ce093341e03f428c96c7b750c352e9a37 = value;
			}
		}

		public Appointments()
		{
			this.ce79b8f0ad7ad79fc2fbc02a7d9a4cba1 = new int();
			this.c00754124b54a9632c18ae4ef0379887a = 0;
			this.ca8c8f7cdfbf916bcd84a8fc93f93f120 = 0;
			this.c656314b1723150e95f40e0d3236692d8 = new Collection();
			this.ca379c245fc4cfb1160e6bf3c0ebad564 = new dbAppointment();
			this.c83af6310381e48dafa9edfaa3ff91e0e = new dsAppointment();
		}

		public int GetlastAppointmentID()
		{
			dbAppointment _dbAppointment = this.db;
			int appointmentLastID = _dbAppointment.GetAppointmentLastID();
			return appointmentLastID;
		}

		public dsAppointment Load(int storeNum, DateTime dt, bool IncludingFuture, int NumberOfDaysToLoad)
		{
			dbAppointment _dbAppointment = this.db;
			dsAppointment _dsAppointment = _dbAppointment.LoadAppointments(storeNum, dt, IncludingFuture, NumberOfDaysToLoad);
			this.ds = _dsAppointment;
			dsAppointment _dsAppointment1 = this.ds;
			return _dsAppointment1;
		}

		public dsAppointment LoadAppointmentByID(int apptid)
		{
			dbAppointment _dbAppointment = this.db;
			dsAppointment _dsAppointment = _dbAppointment.LoadAppointmentByID(apptid);
			return _dsAppointment;
		}

		public DataSet LoadApptServices(int storeNum, DateTime dt, int NumberOfDaysToLoad)
		{
			dbAppointment _dbAppointment = this.db;
			DataSet dataSet = _dbAppointment.LoadAppointments_Service(storeNum, dt, NumberOfDaysToLoad);
			return dataSet;
		}
	}
}