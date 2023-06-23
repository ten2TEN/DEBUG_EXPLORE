using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class UpdateProfileColorsOptions : OptionalProperties
	{
		public Color BackgroundColor
		{
			get;
			set;
		}

		public Color LinkColor
		{
			get;
			set;
		}

		public Color SidebarBorderColor
		{
			get;
			set;
		}

		public Color SidebarFillColor
		{
			get;
			set;
		}

		public Color TextColor
		{
			get;
			set;
		}

		public UpdateProfileColorsOptions()
		{
			this.BackgroundColor = Color.Empty;
			this.TextColor = Color.Empty;
			this.LinkColor = Color.Empty;
			this.SidebarFillColor = Color.Empty;
			this.SidebarBorderColor = Color.Empty;
		}
	}
}