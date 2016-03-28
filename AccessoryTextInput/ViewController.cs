using System;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace AccessoryTextInput
{
	public partial class ViewController : UIViewController
	{
		private TextInputObject _dummyView;
		private UIView _inputView;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Button.TouchUpInside += Button_TouchUpInside;
			HideButton.TouchUpInside += HideButton_TouchUpInside;

			_dummyView = new TextInputObject ();
			View.AddSubview (_dummyView);


		}

		void HideButton_TouchUpInside (object sender, EventArgs e)
		{
			_dummyView.ResignFirstResponder ();

//			_inputView.ResignFirstResponder ();
//
//			_dummyView.ResignFirstResponder ();
		}

		void Button_TouchUpInside (object sender, EventArgs e)
		{
			_dummyView.BecomeFirstResponder ();

//			_dummyView.BecomeFirstResponder ();
//			_inputView.BecomeFirstResponder ();
		}
	}
}

