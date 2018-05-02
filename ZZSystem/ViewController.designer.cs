// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ZZSystem
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField PasswordText { get; set; }

        [Outlet]
        AppKit.NSTextField UserText { get; set; }

        [Action ("LoginButton:")]
        partial void LoginButton (Foundation.NSObject sender);

        [Action ("RegistrarButton:")]
        partial void RegistrarButton (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (UserText != null) {
                UserText.Dispose ();
                UserText = null;
            }

            if (PasswordText != null) {
                PasswordText.Dispose ();
                PasswordText = null;
            }
        }
    }
}
