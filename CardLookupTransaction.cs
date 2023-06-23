using DSITransaction;
using MSEnum;
using System;

namespace Transaction
{
	public class CardLookupTransaction : CardTransaction
	{
		private TokenFrequencies _tokenFrequency;

		public TokenFrequencies TokenFrequency
		{
			get
			{
				return this._tokenFrequency;
			}
			set
			{
				this._tokenFrequency = value;
			}
		}

		public CardLookupTransaction()
		{
		}

		public override void SetInternalMemberVariables(Request request)
		{
			base.Servers = request.CreditServers;
			this.TokenFrequency = request.TokenFrequency;
			base.SetInternalMemberVariables(request);
		}

		protected override void SetValues()
		{
			base.dsiTransaction.TranType = "CardLookup";
			base.dsiTransaction.TranCode = string.Empty;
			base.dsiTransaction.RequestToken = true;
			if (this.TokenFrequency == TokenFrequencies.OneTime)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.OneTime;
			}
			else if (this.TokenFrequency == TokenFrequencies.Recurring)
			{
				base.dsiTransaction.TokenType = netTransaction.eTokenType.Recurring;
			}
			base.SetAccountInfo();
		}

		protected override void ValidateTransactionSpecificParameters()
		{
			if (this.TokenFrequency != TokenFrequencies.OneTime && this.TokenFrequency != TokenFrequencies.Recurring)
			{
				throw new Exception("Unknown value for Token Frequency");
			}
			base.ValidateAccountInformation();
		}
	}
}