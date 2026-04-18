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
                new User{Login="B", Name = "Boris", IsPremium = false},
                new User{Login="C", Name = "Charly", IsPremium = false}
            };
            Greetings greetings = new Greetings();
            greetings.ShowAds(users);
        }
    }
}