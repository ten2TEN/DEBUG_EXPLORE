using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SqlLibrary.My
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance;

		public static MySettings Default
		{
			get
			{
				return MySettings.defaultInstance;
			}
		}

		static MySettings()
		{
			SettingsBase settingsBase = SettingsBase.Synchronized(new MySettings());
			MySettings.defaultInstance = (MySettings)settingsBase;
		}

		public MySettings()
		{
		}
	}
}