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

namespace MenYappu_V1
{
	[Register ("VenpaaDetailViewController")]
	partial class VenpaaDetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ClearButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton HomeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel MenYappuLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView PaaText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ParseButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ClearButton != null) {
				ClearButton.Dispose ();
				ClearButton = null;
			}
			if (HomeButton != null) {
				HomeButton.Dispose ();
				HomeButton = null;
			}
			if (MenYappuLabel != null) {
				MenYappuLabel.Dispose ();
				MenYappuLabel = null;
			}
			if (PaaText != null) {
				PaaText.Dispose ();
				PaaText = null;
			}
			if (ParseButton != null) {
				ParseButton.Dispose ();
				ParseButton = null;
			}
		}
	}
}
