using System;
using System.ComponentModel;
using System.Windows.Forms;
using VER1000XLib;

namespace AxVER1000XLib
{
	[Clsid("{cd6193ce-c543-4329-bab1-c39e5f76cf86}")]
	[DesignTimeVisible(true)]
	public class AxVer1000X : AxHost
	{
		private _DVer1000X ocx;

		private AxVer1000XEventMulticaster eventMulticaster;

		private AxHost.ConnectionPointCookie cookie;

		public AxVer1000X() : base("cd6193ce-c543-4329-bab1-c39e5f76cf86")
		{
		}

		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (_DVer1000X)base.GetOcx();
			}
			catch (Exception exception)
			{
			}
		}

		public virtual void CancelRequest()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CancelRequest", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CancelRequest();
		}

		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxVer1000XEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(_DVer1000XEvents));
			}
			catch (Exception exception)
			{
			}
		}

		protected override void DetachSink()
		{
			try
			{
				this.cookie.Disconnect();
			}
			catch (Exception exception)
			{
			}
		}

		public virtual string ProcessRequest(string xMLRequest, short processControl)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("ProcessRequest", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.ProcessRequest(xMLRequest, processControl);
		}
	}
}