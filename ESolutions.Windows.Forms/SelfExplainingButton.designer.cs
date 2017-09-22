namespace ESolutions.Windows.Forms
{
	partial class SelfExplainingButton
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel ();
			this.commandLinkLabel = new System.Windows.Forms.LinkLabel ();
			this.helpTextLabel = new System.Windows.Forms.Label ();
			this.commandPictureBox = new System.Windows.Forms.PictureBox ();
			this.flowLayoutPanel1.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize)(this.commandPictureBox)).BeginInit ();
			this.SuspendLayout ();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add (this.helpTextLabel);
			this.flowLayoutPanel1.Location = new System.Drawing.Point (35, 18);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding (2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding (2);
			this.flowLayoutPanel1.Size = new System.Drawing.Size (300, 36);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// commandLinkLabel
			// 
			this.commandLinkLabel.AutoSize = true;
			this.commandLinkLabel.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.commandLinkLabel.Location = new System.Drawing.Point (40, 0);
			this.commandLinkLabel.Name = "commandLinkLabel";
			this.commandLinkLabel.Size = new System.Drawing.Size (79, 16);
			this.commandLinkLabel.TabIndex = 1;
			this.commandLinkLabel.TabStop = true;
			this.commandLinkLabel.Text = "linkLabel1";
			this.commandLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.CommandLinkLabel_LinkClicked);
			// 
			// helpTextLabel
			// 
			this.helpTextLabel.AutoSize = true;
			this.helpTextLabel.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpTextLabel.Location = new System.Drawing.Point (5, 2);
			this.helpTextLabel.Name = "helpTextLabel";
			this.helpTextLabel.Size = new System.Drawing.Size (270, 26);
			this.helpTextLabel.TabIndex = 2;
			this.helpTextLabel.Text = "Dies ist ein sehr langer Hilfetext, der keinerlei Sinn dient aber dennoch immer u" +
				 "nd immer länger das Label füllt";
			// 
			// commandPictureBox
			// 
			this.commandPictureBox.Location = new System.Drawing.Point (0, 0);
			this.commandPictureBox.Name = "commandPictureBox";
			this.commandPictureBox.Size = new System.Drawing.Size (32, 32);
			this.commandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.commandPictureBox.TabIndex = 0;
			this.commandPictureBox.TabStop = false;
			this.commandPictureBox.Click += new System.EventHandler (this.CommandPictureBox_Click);
			// 
			// SelfExplainingButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add (this.commandLinkLabel);
			this.Controls.Add (this.commandPictureBox);
			this.Controls.Add (this.flowLayoutPanel1);
			this.Name = "SelfExplainingButton";
			this.Size = new System.Drawing.Size (335, 54);
			this.flowLayoutPanel1.ResumeLayout (false);
			this.flowLayoutPanel1.PerformLayout ();
			((System.ComponentModel.ISupportInitialize)(this.commandPictureBox)).EndInit ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox commandPictureBox;
		private System.Windows.Forms.Label helpTextLabel;
		private System.Windows.Forms.LinkLabel commandLinkLabel;
	}
}
