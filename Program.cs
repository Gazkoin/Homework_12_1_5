using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User{Login="A", Name = "Andrey", IsPremium = true},
                new User{Login="B", Name = "Boris", IsPremium = true},
                new User{Login="C", Name = "Charly", IsPremium = false}
            };
            while (true) {
                Console.WriteLine("\nВведите ваше имя: ");
                string MyName = Console.ReadLine()?.Trim() ?? "";

                if(string.IsNullOrEmpty(MyName))
                {
                    break;                    
                }

                Greetings greetings = new Greetings();
                greetings.ShowAds(users, MyName);
            }

            
        }
    }
}