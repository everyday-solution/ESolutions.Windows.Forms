using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// This class represents a whole help topic.
	/// </summary>
	public class HelpTopic
	{
		#region name
		/// <summary>
		/// Backing field of Name. The name and identifier of the topic.
		private String name;
		#endregion

		#region Name
		/// <summary>
		/// The name and identifier of the topic.
		/// </summary>
		public String Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		#endregion

		#region title
		/// <summary>
		/// Backing field of Title. Title of the helper window.
		private String title;
		#endregion

		#region Title
		/// <summary>
		/// Title of the helper window.
		/// </summary>
		public String Title
		{
			get
			{
				return this.title;
			}
			set
			{
				this.title = value;
			}
		}
		#endregion

		#region description
		/// <summary>
		/// Backing field of Description. Description for the help topic.
		private String description;
		#endregion

		#region Description
		/// <summary>
		/// Description for the help topic.
		/// </summary>
		public String Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}
		#endregion

		#region helpItems
		/// <summary>
		/// Backing field of HelpItems. Help items of the help topic.
		private HelpItemCollection helpItems;
		#endregion

		#region HelpItems
		/// <summary>
		/// Help items of the help topic.
		/// </summary>
		public HelpItemCollection HelpItems
		{
			get
			{
				return this.helpItems;
			}
			set
			{
				this.helpItems = value;
			}
		}
		#endregion

		#region HelpTopic
		/// <summary>
		/// Constructs a help topic object from a xml node.
		/// </summary>
		public HelpTopic (System.Xml.XmlNode node)
		{
			this.name = node.Attributes[0].InnerText;
			this.title = node.ChildNodes[0].InnerText;
			this.description = node.ChildNodes[1].InnerText;
			this.helpItems = new HelpItemCollection (node.ChildNodes[2]);
		}
		#endregion
	}
}
