﻿using System;
////using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RegisteringAndLogginIn
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void Register()
        {
            Console.Write("Please enter your username: ");
            username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("----------------------");

        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if( username == Console.ReadLine())
            {
                Console.WriteLine("Hello {0}, please enter your Password: ", username);
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful!");
                }else
                {
                    Console.WriteLine("Login faile, wrong password. Restart Program!");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }
        }
    }
}