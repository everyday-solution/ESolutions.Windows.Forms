using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// Collection of help items.
	/// </summary>
	public class HelpItemCollection : List<HelpItem>
	{
		#region HelpItemCollection
		/// <summary>
		/// Constructs a set of help items from a xmlnode
		/// </summary>
		public HelpItemCollection (XmlNode node)
		{
			foreach (XmlElement current in node.ChildNodes)
			{
				HelpItem item = new HelpItem (current);
				this.Add (item);
			}
		}
		#endregion
	}
}
