using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_1_5
{
    public interface IAds
    {
        void ShowAds(List<User> users);
    }

    internal class Greetings : IAds
    {
        public void ShowAds(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"\nЗдравствуйте, {user.Name}!");
                if (user.IsPremium == false)
                {
                    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                    // Остановка на 1 с
                    Thread.Sleep(1000);

                    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                    // Остановка на 2 с
                    Thread.Sleep(2000);

                    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                    // Остановка на 3 с
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
