namespace ESolutions.Windows.Forms
{
	partial class ExceptionDialog
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
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
			System.Windows.Forms.PictureBox pictureBox1;
			this.exceptionLabel = new System.Windows.Forms.Label ();
			this.detailsTextBox = new System.Windows.Forms.TextBox ();
			this.showDetailsSelfExplainingButton = new ESolutions.Windows.Forms.SelfExplainingButton ();
			this.acknowledgeSelfExplainingButton = new ESolutions.Windows.Forms.SelfExplainingButton ();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel ();
			pictureBox1 = new System.Windows.Forms.PictureBox ();
			flowLayoutPanel1.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit ();
			this.SuspendLayout ();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			flowLayoutPanel1.Controls.Add (this.exceptionLabel);
			flowLayoutPanel1.Location = new System.Drawing.Point (82, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new System.Drawing.Size (445, 100);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// exceptionLabel
			// 
			this.exceptionLabel.AutoSize = true;
			this.exceptionLabel.Font = new System.Drawing.Font ("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exceptionLabel.Location = new System.Drawing.Point (3, 0);
			this.exceptionLabel.Name = "exceptionLabel";
			this.exceptionLabel.Size = new System.Drawing.Size (70, 25);
			this.exceptionLabel.TabIndex = 2;
			this.exceptionLabel.Text = "label1";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.Image = global::ESolutions.Windows.Forms.Properties.Resources.Shit_64x64;
			pictureBox1.Location = new System.Drawing.Point (12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size (64, 64);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// detailsTextBox
			// 
			this.detailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.detailsTextBox.Location = new System.Drawing.Point (82, 118);
			this.detailsTextBox.Multiline = true;
			this.detailsTextBox.Name = "detailsTextBox";
			this.detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.detailsTextBox.Size = new System.Drawing.Size (445, 0);
			this.detailsTextBox.TabIndex = 0;
			// 
			// showDetailsSelfExplainingButton
			// 
			this.showDetailsSelfExplainingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.showDetailsSelfExplainingButton.BackColor = System.Drawing.Color.Transparent;
			this.showDetailsSelfExplainingButton.CommandImage = global::ESolutions.Windows.Forms.Properties.Resources.ShowDetails_32x32;
			this.showDetailsSelfExplainingButton.CommandText = "Show Details";
			this.showDetailsSelfExplainingButton.HelpTextLong = "Please click here to gain further details about the error.";
			this.showDetailsSelfExplainingButton.HelpTextMedium = "";
			this.showDetailsSelfExplainingButton.HelpTextShort = "";
			this.showDetailsSelfExplainingButton.Level = ESolutions.Windows.Forms.SelfExplainingButton.HelpTextLevel.Long;
			this.showDetailsSelfExplainingButton.Location = new System.Drawing.Point (89, 120);
			this.showDetailsSelfExplainingButton.Name = "showDetailsSelfExplainingButton";
			this.showDetailsSelfExplainingButton.Size = new System.Drawing.Size (215, 57);
			this.showDetailsSelfExplainingButton.TabIndex = 5;
			this.showDetailsSelfExplainingButton.Click += new System.EventHandler (this.ShowDetailsSelfExplainingButton_Click);
			// 
			// acknowledgeSelfExplainingButton
			// 
			this.acknowledgeSelfExplainingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.acknowledgeSelfExplainingButton.BackColor = System.Drawing.Color.Transparent;
			this.acknowledgeSelfExplainingButton.CommandImage = global::ESolutions.Windows.Forms.Properties.Resources.Ok_32x32;
			this.acknowledgeSelfExplainingButton.CommandText = "Acknowledged";
			this.acknowledgeSelfExplainingButton.HelpTextLong = "Please click here to acknowledge the error and close this window.";
			this.acknowledgeSelfExplainingButton.HelpTextMedium = "";
			this.acknowledgeSelfExplainingButton.HelpTextShort = "";
			this.acknowledgeSelfExplainingButton.Level = ESolutions.Windows.Forms.SelfExplainingButton.HelpTextLevel.Long;
			this.acknowledgeSelfExplainingButton.Location = new System.Drawing.Point (312, 120);
			this.acknowledgeSelfExplainingButton.Name = "acknowledgeSelfExplainingButton";
			this.acknowledgeSelfExplainingButton.Size = new System.Drawing.Size (215, 57);
			this.acknowledgeSelfExplainingButton.TabIndex = 0;
			this.acknowledgeSelfExplainingButton.Click += new System.EventHandler (this.AcknowledgeSelfExplainingButton_Click);
			// 
			// ExceptionDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::ESolutions.Windows.Forms.Properties.Resources.Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size (537, 182);
			this.Controls.Add (this.detailsTextBox);
			this.Controls.Add (this.showDetailsSelfExplainingButton);
			this.Controls.Add (flowLayoutPanel1);
			this.Controls.Add (pictureBox1);
			this.Controls.Add (this.acknowledgeSelfExplainingButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExceptionDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ExceptionForm";
			this.Load += new System.EventHandler (this.ExceptionForm_Load);
			flowLayoutPanel1.ResumeLayout (false);
			flowLayoutPanel1.PerformLayout ();
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private SelfExplainingButton acknowledgeSelfExplainingButton;
		private System.Windows.Forms.Label exceptionLabel;
		private SelfExplainingButton showDetailsSelfExplainingButton;
		private System.Windows.Forms.TextBox detailsTextBox;
	}
}