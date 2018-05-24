using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZSystem.Database.Connections;
using ZZSystem.Database.Entities;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("It's ALIVE");
            LoadUser();
            CreateUser();
            LoadUser();
            Console.ReadKey();
        }

        public static void LoadUser()
        {
            var usr = new User();
            usr.Login = "Login";//UserText.AccessibilityValue.ToString();
            usr.Password = "Password";//PasswordText.AccessibilityValue.ToString();

            DbAccess dbAccess = new DbAccess();

            //var userList = dbAccess.Users.Get();

            //if (userList != null)
            //{
            //    foreach (var user in userList)
            //    {
            //        Console.WriteLine(user.Login + "  |  " + user.Password);
            //    }
            //}

            Console.WriteLine("Recuperando o caboclo");
            try
            {
                var user = dbAccess.Users.GetById(1L);
                if (user != null)
                {
                    Console.WriteLine(user.Login + "  |  " + user.Password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("XDB" + ex.Message);
            }
        }
    
        public static void CreateUser()
        {
            var usr = new User();
            usr.Login = "Login";//UserText.AccessibilityValue.ToString();
            usr.Password = "Password";//PasswordText.AccessibilityValue.ToString();

            DbAccess dbAccess = new DbAccess();
            Console.WriteLine("Vai tentar inserir o caboclo");
            try
            {
                dbAccess.Users.Insert(usr);
                dbAccess.Save();
                Console.WriteLine("XUXEXO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FAIL - " + ex.Message);
            }
        }
    }
}
