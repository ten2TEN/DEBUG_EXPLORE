using System;
using Transaction;

namespace Peripheral
{
	public class PeripheralValidation
	{
		public PeripheralValidation()
		{
		}

		public static bool ValidateDervdKey(string dervdKey)
		{
			bool flag = false;
			if (dervdKey.Length >= 0 && dervdKey.Length <= 20 && Utils.IsAlphaNumeric(dervdKey))
			{
				flag = true;
			}
			return flag;
		}

		public static bool ValidatePinBlock(string pinBlock)
		{
			bool flag = false;
			if (pinBlock.Length >= 0 && pinBlock.Length <= 20 && Utils.IsAlphaNumeric(pinBlock))
			{
				flag = true;
			}
			return flag;
		}
	}
}