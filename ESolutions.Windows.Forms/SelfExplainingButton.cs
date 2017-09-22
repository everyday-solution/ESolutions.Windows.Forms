using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ESolutions.Windows.Forms
{
	[DefaultEvent ("Click")]
	public partial class SelfExplainingButton : UserControl
	{
		//Constructors
		#region SelfExplainingButton
		/// <summary>
		/// Constructor
		/// </summary>
		public SelfExplainingButton ()
		{
			InitializeComponent ();
			this.level = HelpTextLevel.Long;
			this.helpTextLong = String.Empty;
			this.helpTextMedium = String.Empty;
			this.helpTextShort = String.Empty;
		} 
		#endregion

		//Fields
		#region level
		/// <summary>
		/// Backing field indicating the shown level of help texts. The level indicates wether a long, short or medium sized help string is shown.
		/// </summary>
		private HelpTextLevel level;
		#endregion

		#region helptTextLong
		/// <summary>
		/// Backing field for a long help text describing the command in a wider context.
		/// </summary>
		private String helpTextLong;
		#endregion

		#region helpTextMedium
		/// <summary>
		/// Backing field for a medium sized text describing the command in a short but precise way.
		/// </summary>
		private String helpTextMedium;
		#endregion

		#region helpTextShort
		/// <summary>
		/// Backing field for a short and precise help text.
		/// </summary>
		private String helpTextShort;
		#endregion

		//Properties
		#region Level
		/// <summary>
		/// Indicates the shown level of help texts. The level indicates wether a long, short or medium sized help string is shown.
		/// </summary>
		public HelpTextLevel Level
		{
			get
			{
				return level;
			}
			set
			{
				level = value;
				ShowHelpText ();
			}
		}
		#endregion

		#region CommandText
		/// <summary>
		/// Represents the text of the link label that is used as a button.
		/// </summary>
		[Browsable (true)]
		[Localizable (true)]
		public String CommandText
		{
			get
			{
				return this.commandLinkLabel.Text;
			}
			set
			{
				this.commandLinkLabel.Text = value;
			}
		} 
		#endregion

		#region CommandColor
		[Browsable(true)]
		public Color CommandColor
		{
			get
			{
				return this.commandLinkLabel.LinkColor;
			}
			set
			{
				this.commandLinkLabel.LinkColor = value;
			}
		}
		#endregion

		#region CommandImage
		/// <summary>
		/// An image that can be associated with the purpose of the command
		/// </summary>
		[Browsable (true)]
		public Image CommandImage
		{
			get
			{
				return this.commandPictureBox.Image;
			}
			set
			{
				this.commandPictureBox.Image = value;
			}
		}
		#endregion

		#region HelpTextLong
		/// <summary>
		/// A long help text describing the command in a wider context.
		/// </summary>
		[Browsable (true)]
		[Localizable (true)]
		public String HelpTextLong
		{
			get
			{
				return this.helpTextLong;
			}
			set
			{
				this.helpTextLong = value;
				this.ShowHelpText ();
			}
		}
		#endregion

		#region HelpTextMedium
		/// <summary>
		/// Medium sized text describing the command in a short but precise way.
		/// </summary>
		[Browsable (true)]
		[Localizable (true)]
		public String HelpTextMedium
		{
			get
			{
				return this.helpTextMedium;
			}
			set
			{
				this.helpTextMedium = value;
				this.ShowHelpText ();
			}
		}
		#endregion

		#region HelpTextShort
		/// <summary>
		/// Short and precise help text
		/// </summary>
		[Browsable (true)]
		[Localizable (true)]
		public String HelpTextShort
		{
			get
			{
				return this.helpTextShort;
			}
			set
			{
				this.helpTextShort = value;
				this.ShowHelpText ();
			}
		}
		#endregion

		//Events
		#region Click
		/// <summary>
		/// The event is fired whenever the link label or the picture box within the button is hit.
		/// </summary>
		public new event EventHandler Click;
		#endregion

		//Methods
		#region CommandLinkLabel_LinkClicked
		/// <summary>
		/// Passes the click event of the link label to the general click event of the self explaining button.
		/// </summary>
		/// <param name="sender">Sender shall always be the link lable of this button.</param>
		/// <param name="e">Arguments concerning the click event of the link label.</param>
		private void CommandLinkLabel_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
		{
			OnClick ();
		}
		#endregion

		#region CommandPictureBox_Click
		/// <summary>
		/// Passes the click event of the picture box to the general click event of the self explaining button
		/// </summary>
		/// <param name="sender">Sender shall always be the picture box of this button</param>
		/// <param name="e">Unimportant</param>
		private void CommandPictureBox_Click (object sender, EventArgs e)
		{
			OnClick ();
		}
		#endregion

		#region OnClick
		/// <summary>
		/// Fires the click event.
		/// </summary>
		protected void OnClick ()
		{
			if (this.Click != null)
			{
				Click (this, new EventArgs ());
			}
		}
		#endregion

		#region OnLoad
		/// <summary>
		/// Overrides the load
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			ShowHelpText ();
		}
		#endregion

		#region ShowHelpText
		/// <summary>
		/// Displays the helptext matching the current level.
		/// </summary>
		private void ShowHelpText ()
		{
			switch (this.level)
			{
				case HelpTextLevel.Long:
				{
					this.helpTextLabel.Text = this.HelpTextLong;
					break;
				}

				case HelpTextLevel.Medium:
				{
					this.helpTextLabel.Text = this.HelpTextMedium;
					break;
				}

				case HelpTextLevel.Short:
				{
					this.helpTextLabel.Text = this.HelpTextShort;
					break;
				}
			}
		}
		#endregion

		//Enums
		#region HelptTextLevel
		public enum HelpTextLevel : int
		{
			Long,
			Medium,
			Short
		}
		#endregion
	}
}
