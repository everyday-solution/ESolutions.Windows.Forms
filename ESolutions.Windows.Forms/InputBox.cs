using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESolutions.Windows.Forms
{
	public partial class InputBox : Form
	{
		#region InputBox
		/// <summary>
		/// Standardconstructor.
		/// </summary>
		public InputBox ()
		{
			InitializeComponent ();
			this.textBox1.Focus ();
		}
		#endregion

		#region InputValue
		/// <summary>
		/// The text that has been typed into the input box.
		/// </summary>
		public String InputValue
		{
			get
			{
				return this.textBox1.Text;
			}
			set
			{
				this.textBox1.Text = value;
			}
		}
		#endregion

		#region ShowDialog
		/// <summary>
		/// Shows a modal inputbox and sets the description.
		/// </summary>
		/// <param name="description"></param>
		/// <returns></returns>
		public DialogResult ShowDialog (String description)
		{
			this.textBox1.Text = String.Empty;
			this.descriptionLabel.Text = description;
			return base.ShowDialog ();
		}
		#endregion

		#region ShowDialog
		/// <summary>
		/// Shows a modal inputbox and sets the description.
		/// </summary>
		/// <param name="description"></param>
		/// <returns></returns>
		public DialogResult ShowDialog (String description, String initialValue)
		{
			this.textBox1.Text = initialValue;
			this.descriptionLabel.Text = description;
			return base.ShowDialog ();
		}
		#endregion

		#region OkButton_Click
		/// <summary>
		/// Set DialogResult to Ok and close form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OkButton_Click (object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close ();
		}
		#endregion

		#region CancelButton_Click
		/// <summary>
		/// Set DialogResult to Cancel and close form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButton_Click (object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close ();
		}
		#endregion
	}
}