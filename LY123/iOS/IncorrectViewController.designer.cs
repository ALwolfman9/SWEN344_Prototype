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
    [Register ("IncorrectViewController")]
    partial class IncorrectViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lifeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton next { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton quit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel wrong_label { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lifeLabel != null) {
                lifeLabel.Dispose ();
                lifeLabel = null;
            }

            if (next != null) {
                next.Dispose ();
                next = null;
            }

            if (quit != null) {
                quit.Dispose ();
                quit = null;
            }

            if (wrong_label != null) {
                wrong_label.Dispose ();
                wrong_label = null;
            }
        }
    }
}