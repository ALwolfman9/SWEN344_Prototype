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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton enter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField enter_password { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField enter_username { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Password { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signup { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel username { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (enter != null) {
                enter.Dispose ();
                enter = null;
            }

            if (enter_password != null) {
                enter_password.Dispose ();
                enter_password = null;
            }

            if (enter_username != null) {
                enter_username.Dispose ();
                enter_username = null;
            }

            if (Password != null) {
                Password.Dispose ();
                Password = null;
            }

            if (signup != null) {
                signup.Dispose ();
                signup = null;
            }

            if (username != null) {
                username.Dispose ();
                username = null;
            }
        }
    }
}