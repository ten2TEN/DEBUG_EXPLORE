using Microsoft.VisualBasic.CompilerServices;
using System;

namespace CCProcess
{
	public class CCResponse
	{
		private string c13397f4d40216275ebc7ec2c31bfb0ee;

		private string cb91acb2c22b2a111874d225f2ad8a215;

		public string REQUEST
		{
			get
			{
				return this.cb91acb2c22b2a111874d225f2ad8a215;
			}
			set
			{
				this.c13397f4d40216275ebc7ec2c31bfb0ee = this.cb91acb2c22b2a111874d225f2ad8a215;
			}
		}

		public string RESPONSE
		{
			get
			{
				return this.c13397f4d40216275ebc7ec2c31bfb0ee;
			}
			set
			{
				this.c13397f4d40216275ebc7ec2c31bfb0ee = value;
			}
		}

		public CCResponse()
		{
			char[] charArrayRankOne = Conversions.ToCharArrayRankOne("");
			this.c13397f4d40216275ebc7ec2c31bfb0ee = new string(charArrayRankOne);
			char[] chrArray = Conversions.ToCharArrayRankOne("");
			this.cb91acb2c22b2a111874d225f2ad8a215 = new string(chrArray);
		}
	}
}