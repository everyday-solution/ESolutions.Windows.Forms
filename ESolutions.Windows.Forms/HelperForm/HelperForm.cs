using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Reflection;
using EverydaySolutions.Windows.Forms;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// A container for helper controls and helperconnectors. The form is transparent and lies itself over
	/// an application form to add helping topics to it.
	/// </summary>
	public partial class HelperForm : Form
	{
		#region helpedForm
		/// <summary>
		/// Backing field of HelpedForm. The form for which the user needs a helper window.
		private Form helpedForm;
		#endregion

		#region guide
		/// <summary>
		/// A guide running around between the helper items.
		/// </summary>
		private Guide guide = null;
		#endregion

		#region guideTimer
		/// <summary>
		/// A timer that is used to let the guide run around between the help items.
		/// </summary>
		Timer guideTimer = new Timer ();
		#endregion

		#region HelpedForm_LocationChanged
		/// <summary>
		/// Changes the position of the helper window according to the new position of the helpd form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HelpedForm_LocationChanged (object sender, EventArgs e)
		{
			LieOverHelpedForm ();
		}
		#endregion

		#region HelpedForm_SizeChanged
		/// <summary>
		/// Changes the position of the helper window according to the new position of the helpd form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HelpedForm_SizeChanged (object sender, EventArgs e)
		{
			this.Location = this.helpedForm.Location;
			this.Size = this.helpedForm.Size;
		}
		#endregion

		#region LieOverHelpedForm
		/// <summary>
		/// Lies the helper window over the client rectangle of the helpd form.
		/// </summary>
		private void LieOverHelpedForm ()
		{
			this.Bounds = this.helpedForm.RectangleToScreen (this.helpedForm.ClientRectangle);
		}
		#endregion

		#region HelperForm
		/// <summary>
		/// Standardconstructor.
		/// </summary>
		public HelperForm (
			String filename,
			Form helpedForm)
		{
			InitializeComponent ();
			this.SetStyle (ControlStyles.ResizeRedraw, true);
			this.SetStyle (ControlStyles.UserPaint, true);
			this.SetStyle (ControlStyles.AllPaintingInWmPaint, true);

			this.helpTopics = new HelpTopicCollection (filename);
			this.helpedForm = helpedForm;

			if (this.helpedForm != null)
			{
				LieOverHelpedForm ();
				this.helpedForm.SizeChanged += new EventHandler (HelpedForm_SizeChanged);
				this.helpedForm.LocationChanged += new EventHandler (HelpedForm_LocationChanged);
			}
		}
		#endregion

		#region helpTopics
		/// <summary>
		/// All help topics.
		/// </summary>
		private HelpTopicCollection helpTopics = null;
		#endregion

		#region HelpTopics
		/// <summary>
		/// All help topics.
		/// </summary>
		public HelpTopicCollection HelpTopics
		{
			get
			{
				return  this.helpTopics;
			}
		}
		#endregion

		#region ShowHelpTopic
		/// <summary>
		/// Initializes the helper form with all data from the names help topic. Before calling this method you should
		/// call the Load Help method.
		/// </summary>
		/// <param name="name">The name of the help topic. This name should be the same that is used in the helper.xml</param>
		public void ShowHelpTopic (String name)
		{
			if (this.helpTopics.Keys.Contains (name) == false)
			{
				throw new HelperFormException (
					HelperFormExceptions.NameNotFound);
			}

			HelpTopic topic = this.helpTopics[name];

			this.Text = topic.Title;

			foreach (HelpItem current in topic.HelpItems)
			{
				HelperUserControl h  = new HelperUserControl (
					current, 
					this.helpedForm);

				this.Controls.Add (h);
			}
			
			this.Show ();
		}
		#endregion

		#region OnVisibleChanged
		/// <summary>
		/// When the form is hidden all controls are cleared.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnVisibleChanged (EventArgs e)
		{
			base.OnVisibleChanged (e);

			if (this.Visible == false)
			{
				this.guideTimer.Stop ();
				this.Controls.Clear ();
			}
			else
			{
#if NOGUIDE
				List<Point> points = new List<Point> ();
				points.Add (
					new Point (
						this.Controls[0].Location.X + this.Controls[0].Width / 2,
						this.Controls[0].Location.Y + this.Controls[0].Height / 2));
				points.Add (this.Controls[1].Location);
				points.Add (this.Controls[2].Location);
				points.Add (this.Controls[3].Location);

				this.guide = new Guide (points);

				this.guideTimer.Tick += new EventHandler (t_Tick);
				this.guideTimer.Interval = 50;
				this.guideTimer.Start ();
#endif
			}
		}
		#endregion

		#region GuideTimer_Tick
		void GuideTimer_Tick (object sender, EventArgs e)
		{
			this.guide.GotoNextPoint ();
			this.Invalidate ();
		}
		#endregion

		#region OnPaint
		/// <summary>
		/// Overrides the OnPaint method of the Form-class and adds a region to it. The
		/// region equals the union of the regions of all helper windows.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint (PaintEventArgs e)
		{
			GraphicsPath regionPath = new GraphicsPath ();

#if NOGUIDE 
			this.guide.Draw (e.Graphics, ref regionPath);			
#endif
			
			foreach (Control current in this.Controls)
			{
				if (current is HelperUserControl)
				{
					regionPath.AddEllipse (current.Bounds);
				}
			}

			regionPath.CloseFigure ();
			
			this.Region = new Region (regionPath);

			base.OnPaint (e); 
		}
		#endregion
	}
}