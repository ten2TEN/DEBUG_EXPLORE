using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("64B8CF06-0003-4104-B0DB-07CA6BAB7F8B")]
	public class LevelIIData : ILevelII
	{
		private double _taxAmount;

		private string _customerCode = string.Empty;

		public string CustomerCode
		{
			get
			{
				return this._customerCode;
			}
			set
			{
				this._customerCode = value;
			}
		}

		public double TaxAmount
		{
			get
			{
				return this._taxAmount;
			}
			set
			{
				this._taxAmount = value;
			}
		}

		public LevelIIData()
		{
		}
	}
}