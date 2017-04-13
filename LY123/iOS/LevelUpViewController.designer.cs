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
    [Register ("LevelUpViewController")]
    partial class LevelUpViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel level_up_text { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton next { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton quit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel rewardLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (level_up_text != null) {
                level_up_text.Dispose ();
                level_up_text = null;
            }

            if (next != null) {
                next.Dispose ();
                next = null;
            }

            if (quit != null) {
                quit.Dispose ();
                quit = null;
            }

            if (rewardLabel != null) {
                rewardLabel.Dispose ();
                rewardLabel = null;
            }
        }
    }
}