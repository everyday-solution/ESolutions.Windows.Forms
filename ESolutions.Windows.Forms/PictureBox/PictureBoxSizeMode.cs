using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.Windows.Forms
{
	/// <summary>
	/// Indicates how the image is fitted into the picture box boundControl.
	/// </summary>
	public enum PictureBoxSizeMode
	{
		/// <summary>
		/// Stretches the image to the current size of the picture box. Therey by the
		/// aspect ratio is not maintained.
		/// </summary>
		StretchImage,

		/// <summary>
		/// The pciture box fits the image to its current size and thereby maintaince 
		/// aspect ratio.
		/// </summary>
		MaintainAspectRatio,
		
		/// <summary>
		/// Centers the image in its orignial size to the picture box. In this mode 
		/// it is possible that only the center part of the image is visible.
		/// </summary>
		CenterImage,

		/// <summary>
		/// Draw the image in its oroginal size starting at the top left corner of the 
		/// picture box. In this mode it is possible that only the top left part of the image
		/// is visible.
		/// </summary>
		Normal
	}
}
