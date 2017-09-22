namespace ESolutions.Windows.Forms
{
	partial class HelperForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent ()
		{
			this.SuspendLayout ();
			// 
			// HelperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size (292, 266);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HelperForm";
			this.Opacity = 0.9;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "HelperForm";
			this.TopMost = true;
			this.ResumeLayout (false);

		}

		#endregion

	}
}