using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Printing;
using ESolutions.Win32;
using EverydaySolutions.Windows.Forms;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// Summary description for MyPictureBox.
	/// </summary>
	public class PictureBox : System.Windows.Forms.PictureBox
	{
		#region uncorrectedImage
		/// <summary>
		/// The original color uncorrected image.
		/// </summary>
		private Image originalImage;
		#endregion

		#region correctedImage
		/// <summary>
		/// The color corrected image when ebaleICM is true.
		/// </summary>
		private Image correctedImage;
		#endregion

		#region enableICM
		/// <summary>
		/// Bacling field of EnableICM property.
		/// </summary>
		private bool enableICM = false;
		#endregion

		#region EnableICM
		/// <summary>
		/// Get or sets a value indicating wether the picture box uses color correction mode or not.
		/// </summary>
		/// <remarks>Set the SourceICMProfiles and TargetICMProfiles before you set this property to true.</remarks>
		/// <exception cref="Exception">If the SourceICMProfile or the TargetICMProfiles (or both) are not set. You can not enable ICM</exception>
		[Browsable (true)]
		[Category ("ColorCorrection")]
		[Description ("Enables or Disables ICM mode")]
		public bool EnableICM
		{
			get
			{
				return this.enableICM;
			}
			set
			{
				if (value == true)
				{
					if (
						this.sourceICMProfile == null ||
						this.targetICMProfile == null ||
						this.sourceICMProfile.Exists == false ||
						this.targetICMProfile.Exists == false)
					{
						throw new Exception (PictureBoxExceptions.CantEnableICM);
					}

					this.enableICM = true;
					this.OnEnableICMChanged ();
					SetImage ();
				}
				else
				{
					this.enableICM = false;
					this.OnEnableICMChanged ();
					SetImage ();
				}
			}
		}
		#endregion

		#region sourceICMProfile
		/// <summary>
		/// Backing field of SourceICMProfile property.
		/// </summary>
		private FileInfo sourceICMProfile;
		#endregion

		#region SourceICMProfile
		/// <summary>
		/// The ICM Profle of the displaying device
		/// </summary>
		[Browsable (true)]
		[Category ("ColorCorrection")]
		[Description ("Gets or sets the SourceICMProfile")]
		public String SourceICMProfile
		{
			get
			{
				String result = String.Empty;

				if (this.sourceICMProfile != null)
				{
					result = this.sourceICMProfile.FullName;
				}

				return result;
			}
			set
			{
				if (value == null || value == String.Empty)
				{
					this.sourceICMProfile = null;
				}
				else
				{
					this.sourceICMProfile = new FileInfo (value);
				}

				if (this.sourceICMProfile == null || this.sourceICMProfile.Exists == false)
				{
					this.enableICM = false;
					this.OnEnableICMChanged ();
				}

				SetImage ();
			}
		}
		#endregion

		#region EnableICMChanged
		/// <summary>
		/// Occurs when the EnableICM property changes
		/// </summary>
		public event EventHandler EnableICMChanged;
		#endregion

		#region OnEnableICMChanged
		/// <summary>
		/// Fires the EnableICMChanged event.
		/// </summary>
		protected void OnEnableICMChanged ()
		{
			if (EnableICMChanged != null)
			{
				this.EnableICMChanged (
					this,
					new EventArgs ());
			}
		}
		#endregion

		#region targetICMProfile
		/// <summary>
		/// Backing field of the TargetICMProfile property.
		/// </summary>
		private FileInfo targetICMProfile;
		#endregion
		
		#region TargetICMProfile
		/// <summary>
		/// The ICM Profile of the target device. For example your printer.
		/// </summary>
		[Browsable (true)]
		[Category ("ColorCorrection")]
		[Description ("Gets or sets the TargetICMProfile")]
		public String TargetICMProfile
		{
			get
			{
				String result = String.Empty;

				if (this.targetICMProfile != null)
				{
					result = this.targetICMProfile.FullName; ;
				}

				return result;
			}
			set
			{
				if (value == null || value == String.Empty)
				{
					this.targetICMProfile = null;
				}
				else
				{
					this.targetICMProfile = new FileInfo (value);
				}

				if (this.targetICMProfile == null || this.targetICMProfile.Exists == false)
				{
					this.enableICM = false;
					this.OnEnableICMChanged ();
				}

				SetImage ();
			}
		}
		#endregion
		
		#region Image
		/// <summary>
		/// The image that shall be displayed be the picture box.
		/// </summary>
		[Browsable (true)]
		[Description ("Gets or sets the displayed image")]
		public new System.Drawing.Image Image
		{
			get
			{
				return base.Image;
			}
			set
			{
				this.originalImage = value;
				SetImage ();
			}
		}
		#endregion

		#region SetImage
		/// <summary>
		/// If enableICM is true the corrected image is shown. Otherwise the original uncorrected.
		/// </summary>
		private void SetImage ()
		{
			if (this.originalImage == null)
			{
				this.correctedImage = null;
			}
			else
			{
				if (enableICM)
				{
					this.correctedImage = Gdi32.PerformColorMatching (
						this.originalImage,
						sourceICMProfile,
						targetICMProfile);
					
					base.Image = this.correctedImage;
				}
				else
				{
					base.Image = this.originalImage;
				}
			}
		}
		#endregion
	}
}
