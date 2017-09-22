using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.Windows.Forms
{
	public class DateTimePicker : System.Windows.Forms.DateTimePicker
	{
		#region Value
		/// <summary>
		/// Sets the date of the control.
		/// </summary>
		public DateTime? ValueNullable
		{
			get
			{
				return this.Checked ? (DateTime?)base.Value : (DateTime?)null;
			}
			set
			{
				if (value == null)
				{
					this.Checked = false;
					this.Value = DateTime.Now;
				}
				else
				{
					this.Checked = true;
					this.Value = value.Value;
				}
			}
		}
		#endregion
	}
}
