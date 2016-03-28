using System;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace AccessoryTextInput
{
	public partial class ViewController : UIViewController
	{
		private TextInputObject _textInputObject;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Button.TouchUpInside += Button_TouchUpInside;
			HideButton.TouchUpInside += HideButton_TouchUpInside;

			_textInputObject = new TextInputObject ();
			View.AddSubview (_textInputObject);


		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate (fromInterfaceOrientation);
			_textInputObject.DidRotate ();
		}

		void Button_TouchUpInside (object sender, EventArgs e)
		{
			_textInputObject.GetInput ("Name", null, text => Label.Text = text);
		}

		void HideButton_TouchUpInside (object sender, EventArgs e)
		{
			_textInputObject.Cancel ();
		}
	}
}

