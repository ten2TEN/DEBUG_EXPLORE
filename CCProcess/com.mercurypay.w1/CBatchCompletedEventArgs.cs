using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CCProcess.com.mercurypay.w1
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.34209")]
	public class CBatchCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] c978b0f32824be332ca1b3dc4c2f69d84;

		public DataSet Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (DataSet)this.c978b0f32824be332ca1b3dc4c2f69d84[0];
			}
		}

		internal CBatchCompletedEventArgs(object[] c978b0f32824be332ca1b3dc4c2f69d84, Exception cc2ee9c753c7384c6c0e89422623276b6, bool c445ddcb8a47e0e4b54cce4362a877103, object c0a336d6fd94ead32c5b1a0945a7e9fe6) : base(cc2ee9c753c7384c6c0e89422623276b6, c445ddcb8a47e0e4b54cce4362a877103, dummyVar0 = RuntimeHelpers.GetObjectValue(c0a336d6fd94ead32c5b1a0945a7e9fe6))
		{
			this.c978b0f32824be332ca1b3dc4c2f69d84 = c978b0f32824be332ca1b3dc4c2f69d84;
		}
	}
}