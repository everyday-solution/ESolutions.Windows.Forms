using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// This class represents a single help item that is part of a help topic.
	/// </summary>
	public class HelpItem
	{
		#region controlName
		/// <summary>
		/// Backing field of ControlName. The name of the control the help is bound to.
		private String controlName;
		#endregion

		#region ControlName
		/// <summary>
		/// The name of the control the help is bound to.
		/// </summary>
		public String ControlName
		{
			get
			{
				return this.controlName;
			}
			set
			{
				this.controlName = value;
			}
		}
		#endregion

		#region number
		/// <summary>
		/// Backing field of Number. The number the help item displays.
		private Int32 number;
		#endregion

		#region Number
		/// <summary>
		/// The number the help item displays.
		/// </summary>
		public Int32 Number
		{
			get
			{
				return this.number;
			}
			set
			{
				this.number = value;
			}
		}
		#endregion

		#region helpText
		/// <summary>
		/// Backing field of HelpText. The help text the help item displays.
		private String helpText;
		#endregion

		#region HelpText
		/// <summary>
		/// The help text the help item displays.
		/// </summary>
		public String HelpText
		{
			get
			{
				return this.helpText;
			}
			set
			{
				this.helpText = value;
			}
		}
		#endregion

		#region HelpItem
		/// <summary>
		/// Constructs a help items from a xml node.
		/// </summary>
		public HelpItem (System.Xml.XmlNode node)
		{
			this.controlName = node.ChildNodes[0].InnerText;
			this.number = Convert.ToInt32 (node.ChildNodes[1].InnerText);
			this.helpText = node.ChildNodes[2].InnerText;
		}
		#endregion
	}
}
