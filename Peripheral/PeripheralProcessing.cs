using MSEnum;
using System;
using Transaction;

namespace Peripheral
{
	public class PeripheralProcessing
	{
		public PeripheralProcessing()
		{
		}

		public static IPeripheral CreatePeripheral(PinPadType pinPadType)
		{
			switch (pinPadType)
			{
				case PinPadType.Verifone1000SE:
				{
					return new Verifone1000SE();
				}
				case PinPadType.VerifoneSC5000CAMercury1:
				case PinPadType.Ingenico3070CAMercury2:
				case PinPadType.Ingenico3070CAMercury3:
				case PinPadType.Unknown:
				{
					return null;
				}
				case PinPadType.MPSPinPadSim:
				{
					return new MPSPinPadSim();
				}
				case PinPadType.Ingenico3070:
				{
					return new Ingenico3070();
				}
				case PinPadType.Ingenico6550:
				{
					return new Ingenico6550();
				}
				case PinPadType.VerifoneVX810CAEMVGlobal1:
				{
					return new VerifoneVX810CAEMVGlobal1();
				}
				default:
				{
					return null;
				}
			}
		}

		public void GetSignatureData(PinPadConfig config, string logName, PeripheralResponse peripheralResponse)
		{
			string empty = string.Empty;
			IPeripheral peripheral = null;
			peripheral = PeripheralProcessing.CreatePeripheral(config.PinPadType);
			if (peripheral != null && peripheral.SupportsSignatureCapture)
			{
				if (peripheral.Initialize(config, logName))
				{
					if (!peripheral.GetSignatureData())
					{
						peripheralResponse.ReturnCode = PeripheralReturnCode.Unknown;
						return;
					}
					peripheralResponse.SignatureData = peripheral.SignatureData;
					peripheralResponse.ReturnCode = peripheral.ReturnCode;
					return;
				}
				peripheralResponse.ReturnCode = PeripheralReturnCode.Unknown;
			}
		}

		public string InitializePeripheral(PinPadConfig config, string logName, bool performConfig)
		{
			string text = "OK";
			IPeripheral peripheral = null;
			if (config != null)
			{
				peripheral = PeripheralProcessing.CreatePeripheral(config.PinPadType);
			}
			if (peripheral == null)
			{
				text = Peripheral.StringsReader.GetText("PeripheralNotFoundError");
			}
			else if (!peripheral.SupportsExplicitInitialization)
			{
				text = Peripheral.StringsReader.GetText("PeripheralInitNotSupported");
			}
			else if (!peripheral.Initialize(config, logName))
			{
				text = Peripheral.StringsReader.GetText("InitError");
			}
			else if (performConfig && !peripheral.SendConfig())
			{
				text = Peripheral.StringsReader.GetText("SendConfigError");
			}
			return text;
		}

		public PeripheralResponse Process(PinPadConfig config, string logName, TenderTypes tenderType, TransactionTypes transactionType, double purchaseAmount, double cashBackAmount)
		{
			PeripheralResponse peripheralResponse = new PeripheralResponse();
			IPeripheral peripheral = null;
			if (config != null)
			{
				peripheral = PeripheralProcessing.CreatePeripheral(config.PinPadType);
			}
			if (peripheral == null || !peripheral.SupportsUserSelectedTender)
			{
				peripheralResponse.ReturnCode = PeripheralReturnCode.Ok;
			}
			else if (tenderType == TenderTypes.EBT && config.EBTManual)
			{
				peripheralResponse.ReturnCode = PeripheralReturnCode.Ok;
			}
			else if (transactionType == TransactionTypes.Voucher)
			{
				peripheralResponse.TenderType = TenderTypes.EBT;
				peripheralResponse.ReturnCode = PeripheralReturnCode.Ok;
			}
			else
			{
				if (tenderType == TenderTypes.Debit && transactionType == TransactionTypes.Return)
				{
					config.DebitMaxCashBack = 0;
				}
				if (tenderType == TenderTypes.EBT && transactionType != TransactionTypes.CashSale)
				{
					config.EBTMaxCashBack = 0;
				}
				if (!peripheral.Initialize(config, logName))
				{
					peripheralResponse.ReturnCode = peripheral.ReturnCode;
				}
				else if (!peripheral.SendConfig())
				{
					peripheralResponse.ReturnCode = peripheral.ReturnCode;
				}
				else if (!peripheral.GetData(tenderType, transactionType, purchaseAmount, cashBackAmount))
				{
					peripheralResponse.ReturnCode = peripheral.ReturnCode;
				}
				else
				{
					peripheral.SetData(peripheralResponse);
				}
			}
			return peripheralResponse;
		}
	}
}