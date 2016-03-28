// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace AccessoryTextInput
{
	[Register ("InputView")]
	public class InputView : UIView
	{
		public InputView (IntPtr handle) : base (handle)
		{
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			TextField.Frame = TextView.Frame;
		}

		[Outlet]
		public UIButton DoneButton { get; set; }

		[Outlet]
		public UITextView TextView { get; set; }

		[Outlet]
		private UITextField TextField { get; set; }

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