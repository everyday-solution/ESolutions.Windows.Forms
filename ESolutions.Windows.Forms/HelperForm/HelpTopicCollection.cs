using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// A collection of help topics.
	/// </summary>
	public class HelpTopicCollection : SortedList<String, HelpTopic>
	{
		#region HelpTopicCollection
		/// <summary>
		/// Constructs a set of help topic from a XmlDocument.
		/// </summary>
		public HelpTopicCollection (String filename)
		{
			XmlDocument document = new XmlDocument ();
			document.Load (filename);

			foreach (XmlElement current in document.ChildNodes[1].ChildNodes)
			{
				HelpTopic topic = new HelpTopic (current);
				this.Add (topic.Name, topic);
			}
		}
		#endregion
	}
}
