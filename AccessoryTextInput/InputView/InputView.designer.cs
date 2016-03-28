// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AccessoryTextInput
{
	[Register ("InputView")]
	partial class InputView
	{
		[Outlet]
		UIKit.UIButton DoneButton { get; set; }

		[Outlet]
		UIKit.UITextField TextField { get; set; }

		[Outlet]
		UIKit.UITextView TextView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}

			if (TextView != null) {
				TextView.Dispose ();
				TextView = null;
			}

			if (DoneButton != null) {
				DoneButton.Dispose ();
				DoneButton = null;
			}
		}
	}
}
