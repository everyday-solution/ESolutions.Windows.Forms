using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ESolutions.Windows.Forms
{
	public partial class ExceptionDialog : Form
	{
		#region shownException
		/// <summary>
		/// The exception shown by the form
		/// </summary>
		private Exception shownException;
		#endregion

		#region ExceptionForm
		/// <summary>
		/// Standardconstructor.
		/// </summary>
		public ExceptionDialog()
		{
			InitializeComponent();
		}
		#endregion

		#region ShowDetailsSelfExplainingButton_Click
		/// <summary>
		/// Enlarges the form so that the details label becomes visible.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShowDetailsSelfExplainingButton_Click(object sender, EventArgs e)
		{
			this.Height += 150;
			this.showDetailsSelfExplainingButton.Enabled = false;
		}
		#endregion

		#region AcknowledgeSelfExplainingButton_Click
		/// <summary>
		/// Closes the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AcknowledgeSelfExplainingButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Show
		/// <summary>
		/// Shows the form displaying the passed exception
		/// </summary>
		/// <param name="ex"></param>
		public static void Show(Exception ex)
		{
			ExceptionDialog exForm = new ExceptionDialog();
			exForm.shownException = ex;
			exForm.ShowDialog();
		}
		#endregion

		#region ExceptionForm_Load
		/// <summary>
		/// The form is loaded and the exception is shown.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExceptionForm_Load(object sender, EventArgs e)
		{
			this.exceptionLabel.Text = this.shownException.Message;

			this.detailsTextBox.Text = this.DeepParseException(this.shownException);
			this.detailsTextBox.Text += Environment.NewLine;
			this.detailsTextBox.Text += Environment.NewLine;
			this.detailsTextBox.Text += this.shownException.StackTrace;
		}
		#endregion

		#region DeepParseException
		private String DeepParseException(Exception ex)
		{
			String result = ex.Message + Environment.NewLine + Environment.NewLine;

			if (ex.InnerException != null)
			{
				result += this.DeepParseException(ex.InnerException);
			}

			return result;
		}
		#endregion
	}
}