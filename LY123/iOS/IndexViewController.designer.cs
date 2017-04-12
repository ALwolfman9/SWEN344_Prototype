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
    [Register ("IndexViewController")]
    partial class IndexViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton hello { get; set; }

        [Action ("Hello_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Hello_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (hello != null) {
                hello.Dispose ();
                hello = null;
            }
        }
    }
}