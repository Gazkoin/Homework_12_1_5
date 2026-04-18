using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_1_5
{
    public interface IAds
    {
        void ShowAds(List<User> users, string MyName);
    }

    internal class Greetings : IAds
    {
        public void ShowAds(List<User> users, string MyName)
        {
            User foundUser = null;
            foreach (User user in users)
            {
                if (user.Name == MyName)
                {
                    foundUser = user;
                    break;                   
                }
            }

            // Основная логика
            if (foundUser != null && foundUser.IsPremium)
            {
                Console.WriteLine($"\nЗдравствуйте, {foundUser.Name}. Спасибо что оформили премиум подписку!");
            }
            else
            {
                Console.WriteLine($"\nЗдравствуйте, {MyName}!");
                ShowAds();                   
            }
        }
                
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }    
}
