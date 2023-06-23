using System;

namespace Peripheral
{
	public class Ingenico3070 : IngenicoBase, IPeripheral
	{
		public bool SupportsCardReader
		{
			get
			{
				return true;
			}
		}

		public bool SupportsExplicitInitialization
		{
			get
			{
				return true;
			}
		}

		public bool SupportsPinPad
		{
			get
			{
				return true;
			}
		}

		public bool SupportsSignatureCapture
		{
			get
			{
				return false;
			}
		}

		public bool SupportsUserSelectedTender
		{
			get
			{
				return true;
			}
		}

		public bool UsesCanadianEMV
		{
			get
			{
				return false;
			}
		}

		public Ingenico3070()
		{
		}
	}
}