namespace ESolutions.Windows.Forms
{
	partial class HelperUserControl
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

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container ();
			this.toolTip = new System.Windows.Forms.ToolTip (this.components);
			this.SuspendLayout ();
			// 
			// toolTip
			// 
			this.toolTip.IsBalloon = true;
			// 
			// HelperUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "HelperUserControl";
			this.Size = new System.Drawing.Size (100, 100);
			this.ParentChanged += new System.EventHandler (this.HelperUserControl_ParentChanged);
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
	}
}
