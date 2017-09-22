using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.Windows.Forms
{
	public class UserControl : System.Windows.Forms.UserControl
	{
		public new bool DesignMode
		{
			get
			{
				return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
			}
		}
	}
}
