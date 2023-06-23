using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("7B7954B7-7E0A-42bf-8B66-2FCB9C7E7F4F")]
	public class AVSData : IAVSData
	{
		private string _address = string.Empty;

		private string _zipCode = string.Empty;

		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}

		public string ZipCode
		{
			get
			{
				return this._zipCode;
			}
			set
			{
				this._zipCode = value;
			}
		}

		public AVSData()
		{
		}
	}
}