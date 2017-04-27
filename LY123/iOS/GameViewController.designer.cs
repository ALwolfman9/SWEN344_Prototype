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

namespace SWEN344_Prototype.iOS
{
    [Register ("GameViewController")]
    partial class GameViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton answer1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton answer2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton answer3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton answer4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel levelField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel livesView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel question { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel scoreLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (answer1 != null) {
                answer1.Dispose ();
                answer1 = null;
            }

            if (answer2 != null) {
                answer2.Dispose ();
                answer2 = null;
            }

            if (answer3 != null) {
                answer3.Dispose ();
                answer3 = null;
            }

            if (answer4 != null) {
                answer4.Dispose ();
                answer4 = null;
            }

            if (levelField != null) {
                levelField.Dispose ();
                levelField = null;
            }

            if (livesView != null) {
                livesView.Dispose ();
                livesView = null;
            }

            if (question != null) {
                question.Dispose ();
                question = null;
            }

            if (scoreLabel != null) {
                scoreLabel.Dispose ();
                scoreLabel = null;
            }
        }
    }
}