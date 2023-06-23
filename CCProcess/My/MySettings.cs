using A;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CCProcess.My
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance;

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://w1.mercurypay.com/ws/ws.asmx")]
		[SpecialSetting(SpecialSetting.WebServiceUrl)]
		public string CCProcess_com_mercurypay_w1_ws
		{
			get
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1702);
				object item = this[str];
				return Conversions.ToString(item);
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://w1.mercurydev.net/ws/ws.asmx")]
		[SpecialSetting(SpecialSetting.WebServiceUrl)]
		public string CCProcess_net_mercurydev_w1_ws
		{
			get
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x16c5);
				object item = this[str];
				string str1 = Conversions.ToString(item);
				return str1;
			}
		}

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