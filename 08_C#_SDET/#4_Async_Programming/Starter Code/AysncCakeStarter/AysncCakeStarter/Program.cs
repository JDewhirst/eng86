using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            HaveAParty();
            Console.ReadLine();
            Console.WriteLine("Thanks for a lovely party");

        }

        private static void HaveAParty()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            var cake = cakeTask.Result;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
            var candlesTask = cake.CandlesMelt();
            SingHappyBirthday();
            candlesTask.Wait();
            Console.WriteLine($"Make a wish!");
        }

        private static async void SingHappyBirthday()
        {
            var happyBirthday = new List<string> { "Happy Birthday to you,", "you live in a zoo.", "You look like a monkey,", "and you smell like one too!", "Hip hip!", "Hurrah", "Hip hip!", "Hurrah", "Hip hip!", "Hurrah"};
            foreach(string line in happyBirthday)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.7));
                Console.WriteLine(line);
            }
        }

        private static async Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }

        public async Task<bool> CandlesMelt()
        {
            Console.WriteLine("The candles will burn down in 10 seconds");
            for (int i = 9; i > 0; i--)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine($"{i}");
            }

            return true;
        }
    }
}
