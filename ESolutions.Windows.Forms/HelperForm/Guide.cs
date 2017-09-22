using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// This class represents an arrow that moves along a line of points.
	/// </summary>
	public class Guide
	{
		#region currentPoint
		/// <summary>
		/// The index of the point at which the arrow currently is shown.
		/// </summary>
		private Int32 currentPoint;
		#endregion

		#region allPoints
		/// <summary>
		/// A list of point the arrow will follow.
		/// </summary>
		private List<Point> allPoints = new List<Point> ();
		#endregion

		#region Guide
		/// <summary>
		/// Constructor calculating routes between the given waypoints
		/// </summary>
		/// <param name="wayPoints">A list pf at least two waypoint between which the arrow moves.</param>
		public Guide (List<Point> wayPoints)
		{
			if (wayPoints.Count < 2)
			{
				throw new Exception ("There must be at least two points to start up the arrow");
			}

			this.currentPoint = 0;

			for (int index = 0; index < wayPoints.Count - 1; index++)
			{
				List<Point> pointsOnRoute = CalculateRouteBetweenPoints (
					wayPoints[index],
					wayPoints[index + 1]);

				this.allPoints.AddRange (pointsOnRoute);
			}
		}
		#endregion

		#region CalculateRouteBetweenPoints
		/// <summary>
		/// Calculates a list of points that lie on the route between the two points.
		/// </summary>
		/// <param name="start">Startpoint of the route</param>
		/// <param name="end">Endpoint of the route</param>
		private List<Point> CalculateRouteBetweenPoints (
			Point start,
			Point end)
		{
			List<Point> result = new List<Point> ();

			double xDistance = Math.Abs (start.X - end.X);
			double yDistance = Math.Abs (start.Y - end.Y);
			double distance = Math.Sqrt (Math.Pow (xDistance, 2.0) + Math.Pow (yDistance, 2.0));

			double steps = distance / 20;
			double xStepWidth = xDistance / steps;
			double yStepWidth = yDistance / steps;
			double stepDistance = Math.Sqrt (Math.Pow (xStepWidth, 2.0) + Math.Pow (yStepWidth, 2.0));

			double walkedDistance = 0.0;
			double walkedXDistance = 0.0;
			double walkedYDistance = 0.0;

			result.Add (start);

			while (walkedDistance < distance)
			{
				walkedXDistance += xStepWidth;
				walkedYDistance += yStepWidth;

				Point newPoint;

				if (start.X > end.X)
				{
					//To the left
					if (start.Y > end.Y)
					{
						//Up
						newPoint = new Point (
							Convert.ToInt32 (start.X - walkedXDistance),
							Convert.ToInt32 (start.Y - walkedYDistance));
					}
					else
					{
						//Down
						newPoint = new Point (
							Convert.ToInt32 (start.X - walkedXDistance),
							Convert.ToInt32 (start.Y + walkedYDistance));
					}
				}
				else
				{
					//To the right
					if (start.Y > end.Y)
					{
						//Up
						newPoint = new Point (
							Convert.ToInt32 (start.X + walkedXDistance),
							Convert.ToInt32 (start.Y - walkedYDistance));
					}
					else
					{
						//Down
						newPoint = new Point (
							Convert.ToInt32 (start.X + walkedXDistance),
							Convert.ToInt32 (start.Y + walkedYDistance));
					}
				}

				result.Add (newPoint);

				walkedDistance += stepDistance;
			}

			return result;
		}
		#endregion

		#region GotoNextPoint
		/// <summary>
		/// Sets the position of the arrow to the next position on the way to the next waypoint.
		/// </summary>
		public void GotoNextPoint ()
		{
			if (currentPoint < this.allPoints.Count - 1)
			{
				this.currentPoint += 1;
			}
			else
			{
				this.currentPoint = 0;
			}
		}
		#endregion

		#region Draw
		/// <summary>
		/// Draw the arrow at the current position on the passed graphic. It alsos adds the drawn path
		/// to the passed path.
		/// </summary>
		/// <param name="g">Graphics that is used for drawing.</param>
		/// <param name="path">Path to which the painted area is added.</param>
		public void Draw (
			Graphics g,
			ref GraphicsPath path)
		{
			Rectangle r = new Rectangle (
				this.allPoints[currentPoint].X,
				this.allPoints[currentPoint].Y,
				10,
				10);

			g.FillEllipse (
				new SolidBrush (Color.Black),
				r);

			path.AddEllipse (
				r);
		}
		#endregion
	}
}
