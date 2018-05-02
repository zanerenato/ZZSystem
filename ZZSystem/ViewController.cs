using System;
using System.Collections.Generic;
using ZZSystem.Database.Connections;
using ZZSystem.Database.Entities;
using AppKit;
using Foundation;

namespace ZZSystem
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void LoginButton(Foundation.NSObject sender)
        {
            var usr = new User();
            usr.Login = UserText.AccessibilityValue.ToString();
            usr.Password = PasswordText.AccessibilityValue.ToString();

            DbAccess dbAccess = new DbAccess();

            //var userList = dbAccess.Users.Get();

            //if (userList != null)
            //{
            //    foreach (var user in userList)
            //    {
            //        Console.WriteLine(user.Login + "  |  " + user.Password);
            //    }
            //}

            var user = dbAccess.Users.GetById(1L);
            if (user != null)
            {
                Console.WriteLine(user.Login + "  |  " + user.Password);
            }
        }

        partial void RegistrarButton(Foundation.NSObject sender)
        {
            var usr = new User();
            usr.Login = UserText.AccessibilityValue.ToString();
            usr.Password = PasswordText.AccessibilityValue.ToString();

            DbAccess dbAccess = new DbAccess();

            dbAccess.Users.Insert(usr);

            dbAccess.Save();

        }
    }
}
