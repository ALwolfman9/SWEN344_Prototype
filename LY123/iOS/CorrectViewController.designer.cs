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
    [Register ("CorrectViewController")]
    partial class CorrectViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton next { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel pointsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton quit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel right_lable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (next != null) {
                next.Dispose ();
                next = null;
            }

            if (pointsLabel != null) {
                pointsLabel.Dispose ();
                pointsLabel = null;
            }

            if (quit != null) {
                quit.Dispose ();
                quit = null;
            }

            if (right_lable != null) {
                right_lable.Dispose ();
                right_lable = null;
            }
        }
    }
}