using System;
using System.Runtime.InteropServices;

namespace Transaction
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("62901F34-0FD8-490a-9E46-BA64AA6D2727")]
	public class MercuryShieldConfig : IMercuryShieldConfig
	{
		private bool _useEnterAsTab;

		private bool _topMost;

		private bool _cvvRequiredOnManualEntry;

		public bool CVVRequiredOnManualEntry
		{
			get
			{
				return this._cvvRequiredOnManualEntry;
			}
			set
			{
				this._cvvRequiredOnManualEntry = value;
			}
		}

		public bool TopMost
		{
			get
			{
				return this._topMost;
			}
			set
			{
				this._topMost = value;
			}
		}

		public bool UseEnterAsTab
		{
			get
			{
				return this._useEnterAsTab;
			}
			set
			{
				this._useEnterAsTab = value;
			}
		}

		public MercuryShieldConfig()
		{
		}
	}
}