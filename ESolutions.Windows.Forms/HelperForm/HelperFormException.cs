using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.Windows.Forms
{

	[global::System.Serializable]
	public class HelperFormException : Exception
	{
		//
		// For guidelines regarding the creation of new exception types, see
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
		// and
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
		//

		public HelperFormException ()
		{
		}
		public HelperFormException (string message) : base (message)
		{
		}
		public HelperFormException (string message, Exception inner) : base (message, inner)
		{
		}
		protected HelperFormException (
		 System.Runtime.Serialization.SerializationInfo info,
		 System.Runtime.Serialization.StreamingContext context)
			: base (info, context)
		{
		}
	}
}
