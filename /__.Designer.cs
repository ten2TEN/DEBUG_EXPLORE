using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// 
namespace u0099u0008
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	// 
	internal class u001cu0002
	{
		// 
		private static System.Resources.ResourceManager u0001;

		// 
		private static CultureInfo u0002;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return u001cu0002.u0002;
			}
			set
			{
				u001cu0002.u0002 = value;
			}
		}

		internal static string InitError
		{
			get
			{
				return u001cu0002.ResourceManager.GetString("InitError", u001cu0002.u0002);
			}
		}

		internal static string PeripheralInitNotSupported
		{
			get
			{
				return u001cu0002.ResourceManager.GetString("PeripheralInitNotSupported", u001cu0002.u0002);
			}
		}

		internal static string PeripheralNotFoundError
		{
			get
			{
				return u001cu0002.ResourceManager.GetString("PeripheralNotFoundError", u001cu0002.u0002);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(u001cu0002.u0001, null))
				{
					u001cu0002.u0001 = new System.Resources.ResourceManager("\u0099\b.\u001c\u0002", typeof(u001cu0002).Assembly);
				}
				return u001cu0002.u0001;
			}
		}

		internal static string SendConfigError
		{
			get
			{
				return u001cu0002.ResourceManager.GetString("SendConfigError", u001cu0002.u0002);
			}
		}

		internal u001cu0002()
		{
		}
	}
}