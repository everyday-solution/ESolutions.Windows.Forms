using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using EverydaySolutions.Windows.Forms;

namespace ESolutions.Windows.Forms
{
	public partial class HelperUserControl : UserControl
	{
		#region HelpText
		/// <summary>
		/// The help text that is displayed when hovering the helper.
		/// </summary>
		[Browsable (true)]
		public String helpText
		{
			get
			{
				return this.toolTip.GetToolTip (this);
			}
			set
			{
				this.toolTip.SetToolTip (this, value);
			}
		}
		#endregion

		#region boundControl
		/// <summary>
		/// Backing field of BoundControl. The boundControlFieldInfo the helper is associated to..
		private Control boundControl;
		#endregion

		#region number
		/// <summary>
		/// Backing field of Number. Number of the helper.
		private Int32 number = 1;
		#endregion

		#region helpedForm
		/// <summary>
		/// The form to which the help applies.
		/// </summary>
		private System.Windows.Forms.Form helpedForm;
		#endregion

		#region OnPaint
		protected override void OnPaint (PaintEventArgs e)
		{
			base.OnPaint (e);

			GraphicsPath path = new GraphicsPath ();
			path.AddEllipse (0, 0, this.Width, this.Height);
			path.CloseFigure ();

			e.Graphics.DrawImage (
				Properties.Resources.Number,
				0,
				0,
				this.Width,
				this.Height);

			Font numberFont = new Font ("Arial", 26, FontStyle.Bold);
			SolidBrush numberBrush = new SolidBrush (Color.White);
			SizeF size = e.Graphics.MeasureString (
				this.number.ToString (),
				numberFont);

			//The -2 thing is because the graphic is no exact circle.
			Point numberLeftTopPoint = new Point (
				Convert.ToInt32 (((Width / 2) - (size.Width / 2) - 2)),
				Convert.ToInt32 (((Height / 2) - (size.Height / 2) - 2)));

			e.Graphics.DrawString (
				this.number.ToString (),
				numberFont,
				numberBrush,
				numberLeftTopPoint);

			this.Region = new Region (path);
		}
		#endregion

		#region SetLocation
		/// <summary>
		/// Centers the helper on the boundControlFieldInfo.
		/// </summary>
		private void SetLocation ()
		{
			try
			{
				Point center = this.boundControl.Parent.PointToScreen (boundControl.Location);

				center.X += this.boundControl.Width / 2;
				center.Y += this.boundControl.Height / 2;

				center.X -= this.Width / 2;
				center.Y -= this.Height / 2;

				this.Location = this.Parent.PointToClient (center);
			}
			catch
			{
			}
		}
		#endregion

		#region HelperUserControl
		public HelperUserControl (
			HelpItem item,
			System.Windows.Forms.Form helpedForm)
		{
			InitializeComponent ();

			this.SetStyle (ControlStyles.ResizeRedraw, true);
			this.SetStyle (ControlStyles.UserPaint, true);
			this.SetStyle (ControlStyles.AllPaintingInWmPaint, true);

			this.helpedForm = helpedForm;
			this.boundControl = this.GetControlByName (item.ControlName);
			this.boundControl.LocationChanged += new EventHandler (BoundControl_LocationChanged);
			this.boundControl.SizeChanged += new EventHandler (BoundControl_SizeChanged);
			this.number = item.Number;
			this.helpText = item.HelpText;
			this.SetLocation ();
		}
		#endregion

		#region GetControlByName
		/// <summary>
		/// Returns a control on the helped form that can be identified by the passed name.
		/// </summary>
		/// <param name="controlName">The name of the control that shall be returned.</param>
		/// <exception cref="HelperFormException">
		/// Is thrown when no control with the passed name exists on the helpedForm.
		/// </exception>
		private Control GetControlByName (String controlName)
		{
			FieldInfo boundControlFieldInfo = this.helpedForm.GetType ().GetField (
				controlName,
				BindingFlags.NonPublic | BindingFlags.Instance);

			if (boundControlFieldInfo == null)
			{
				String message = String.Format (
					HelperFormExceptions.ControlNotFound,
					controlName);

				throw new HelperFormException (message);
			}

			return (Control)boundControlFieldInfo.GetValue (this.helpedForm);
		}
		#endregion

		#region BoundControl_SizeChanged
		void BoundControl_SizeChanged (object sender, EventArgs e)
		{
			SetLocation ();
		}
		#endregion

		#region BoundControl_LocationChanged
		void BoundControl_LocationChanged (object sender, EventArgs e)
		{
			SetLocation ();
		}
		#endregion

		#region HelperUserControl_ParentChanged
		private void HelperUserControl_ParentChanged (object sender, EventArgs e)
		{
			this.SetLocation ();
		}
		#endregion
	}
}
