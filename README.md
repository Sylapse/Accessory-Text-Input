# AccessoryTextInput
A text input attached to the keyboard for Xamarin.iOS
https://www.youtube.com/watch?v=YTmWS8eVHOo


Create a TextInputObject and add it to the view. Don't give it any size or constraints, it's just a dummy view that can become the responder.

    var textInputObject = new TextInputObject ();
    View.AddSubview (textInputObject);

Use GetInput to show the keyboard. Pass in placeholder text, any pre fill text and a callback that uses the input text.

    textInputObject.GetInput ("Hint", "Current Text", text => Label.Text = text);

Invoke the callback and hide the keyboard programmatically with Finish. Just hide the keyboard with Cancel

    textInputObject.Finish ();
    textInputObject.Cancel ();
