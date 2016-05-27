// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MenYappu
{
	[Register ("LetterTypeFinderDetailViewController")]
	partial class LetterTypeFinderDetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CheckAnswerButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ClearButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView ResultTableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SampleButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextWord { get; set; }

		[Action ("UIButton610_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton610_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CheckAnswerButton != null) {
				CheckAnswerButton.Dispose ();
				CheckAnswerButton = null;
			}
			if (ClearButton != null) {
				ClearButton.Dispose ();
				ClearButton = null;
			}
			if (ResultTableView != null) {
				ResultTableView.Dispose ();
				ResultTableView = null;
			}
			if (SampleButton != null) {
				SampleButton.Dispose ();
				SampleButton = null;
			}
			if (TextWord != null) {
				TextWord.Dispose ();
				TextWord = null;
			}
		}
	}
}
