using System;

namespace Transaction
{
	internal interface IMercuryControl
	{
		void FillTransaction(CreditSaleTransaction credit);
	}
}