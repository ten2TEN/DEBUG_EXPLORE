using System;

namespace Peripheral
{
	public enum PeripheralReturnCode
	{
		GeneralFailure,
		Timeout,
		CancelledAtPOS,
		CancelledAtPinPad,
		FailedToParseXML,
		InvalidComPortValue,
		InvalidCommand,
		CouldNotAccessComPort,
		InProcess,
		InvalidAmount,
		InvalidAccount,
		PertinentErrorInformation,
		TranTypeNotEnabled,
		DatacapConfigNotSet,
		InvalidTranType,
		InvalidTranCode,
		InvalidSignature,
		Unknown,
		Ok
	}
}