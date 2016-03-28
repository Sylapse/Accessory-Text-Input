using System;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace AccessoryTextInput
{
	public partial class ViewController : UIViewController
	{
		private UITextField _dummyView;
		private UIView _inputView;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Button.TouchUpInside += Button_TouchUpInside;

			_dummyView = new UITextField ();
			View.AddSubview (_dummyView);

			var arr = NSBundle.MainBundle.LoadNib ("InputView", null, null);
			_inputView = Runtime.GetNSObject<InputView> (arr.ValueAt(0));
			_inputView.TranslatesAutoresizingMaskIntoConstraints = false;

			_inputView.AddConstraint (NSLayoutConstraint.Create (_inputView,
				NSLayoutAttribute.Height,
				NSLayoutRelation.GreaterThanOrEqual,
				null,
				NSLayoutAttribute.NoAttribute,
				0, 44));

			_inputView.AddConstraint (NSLayoutConstraint.Create (_inputView,
				NSLayoutAttribute.Height,
				NSLayoutRelation.LessThanOrEqual,
				null,
				NSLayoutAttribute.NoAttribute,
				0, 128));


			_dummyView.InputAccessoryView = _inputView;
		}

		void Button_TouchUpInside (object sender, EventArgs e)
		{
			_dummyView.BecomeFirstResponder ();
			_inputView.BecomeFirstResponder ();


			var cons = _inputView.InputAccessoryView.Superview.Constraints;
			_dummyView.InputAccessoryView.Superview.RemoveConstraint (cons [0]);
		}
	}
}

