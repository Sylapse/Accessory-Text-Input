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

		void Button_TouchUpInside (object sender, EventArgs e)
		{
			_textInputObject.GetInput ("some text", text => Label.Text = text);
		}

		void HideButton_TouchUpInside (object sender, EventArgs e)
		{
			_textInputObject.Cancel ();
		}
	}
}

