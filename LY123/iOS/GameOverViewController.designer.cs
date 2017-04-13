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
    [Register ("GameOverViewController")]
    partial class GameOverViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton quit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel rewardscount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel scoreLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (quit != null) {
                quit.Dispose ();
                quit = null;
            }

            if (rewardscount != null) {
                rewardscount.Dispose ();
                rewardscount = null;
            }

            if (scoreLabel != null) {
                scoreLabel.Dispose ();
                scoreLabel = null;
            }
        }
    }
}