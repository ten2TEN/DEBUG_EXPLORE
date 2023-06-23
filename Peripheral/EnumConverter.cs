using System;

namespace Peripheral
{
	public class EnumConverter
	{
		public EnumConverter()
		{
		}

		public static PeripheralReturnCode DataCapReturnCodeToEnum(string returnCode)
		{
			if (returnCode == "005000")
			{
				return PeripheralReturnCode.GeneralFailure;
			}
			if (returnCode == "005001")
			{
				return PeripheralReturnCode.Timeout;
			}
			if (returnCode == "005002")
			{
				return PeripheralReturnCode.CancelledAtPOS;
			}
			if (returnCode == "005003")
			{
				return PeripheralReturnCode.CancelledAtPinPad;
			}
			if (returnCode == "005004")
			{
				return PeripheralReturnCode.FailedToParseXML;
			}
			if (returnCode == "005005")
			{
				return PeripheralReturnCode.InvalidComPortValue;
			}
			if (returnCode == "005006")
			{
				return PeripheralReturnCode.InvalidCommand;
			}
			if (returnCode == "005007")
			{
				return PeripheralReturnCode.CouldNotAccessComPort;
			}
			if (returnCode == "005008")
			{
				return PeripheralReturnCode.InProcess;
			}
			if (returnCode == "005010")
			{
				return PeripheralReturnCode.InvalidAmount;
			}
			if (returnCode == "005011")
			{
				return PeripheralReturnCode.InvalidAccount;
			}
			if (returnCode == "005012")
			{
				return PeripheralReturnCode.PertinentErrorInformation;
			}
			if (returnCode == "005020")
			{
				return PeripheralReturnCode.TranTypeNotEnabled;
			}
			if (returnCode == "005021")
			{
				return PeripheralReturnCode.DatacapConfigNotSet;
			}
			if (returnCode == "005022")
			{
				return PeripheralReturnCode.InvalidTranType;
			}
			if (returnCode == "005023")
			{
				return PeripheralReturnCode.InvalidTranCode;
			}
			if (returnCode == "009999")
			{
				return PeripheralReturnCode.Unknown;
			}
			return PeripheralReturnCode.Unknown;
		}
	}
}