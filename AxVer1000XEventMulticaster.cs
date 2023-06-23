using System;
using System.Runtime.InteropServices;
using VER1000XLib;

namespace AxVER1000XLib
{
	[ClassInterface(ClassInterfaceType.None)]
	public class AxVer1000XEventMulticaster : _DVer1000XEvents
	{
		private AxVer1000X parent;

		public AxVer1000XEventMulticaster(AxVer1000X parent)
		{
			this.parent = parent;
		}
	}
}