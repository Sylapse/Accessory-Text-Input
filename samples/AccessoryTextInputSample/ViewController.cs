using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using Sylapse.AccessoryTextInput;

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
			Button.TouchUpInside += GetInput;
			HideButton.TouchUpInside += Cancel;
			FinishButton.TouchUpInside += Finish;

			_textInputObject = new TextInputObject ();
			View.AddSubview (_textInputObject);
		}

		void GetInput (object sender, EventArgs e)
		{
			_textInputObject.GetInput ("Name", null, text => Label.Text = text);
		}

		void Cancel (object sender, EventArgs e)
		{
			_textInputObject.Cancel ();
		}

		void Finish (object sender, EventArgs e)
		{
			_textInputObject.Finish ();
		}
	}
}

