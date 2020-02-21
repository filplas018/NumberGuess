using System;
using System.Diagnostics;

namespace NumberGuess
{
    class Program
    {
        private static Random _rand;
        static void Main(string[] args)
        {
            _rand = new Random();
            Game g = new Game(_rand, 100);
            string x = Console.ReadLine();
            int b = Int32.Parse(x);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ///
            sw.Stop();
            TimeSpan t = sw.Elapsed;
            t += sw.Elapsed;
            var a = t.TotalSeconds;

            var result = g.Guess(b);
            switch (result)
            {
                case GuessResult.IsLower: 
                    {
                        Console.WriteLine("Hádej větší"); break; 
                    }
                case GuessResult.IsGreater:
                    {                           
                        Console.WriteLine("Hádej menší"); break;
                    }
                case GuessResult.Succes: 
                    { 
                        Console.WriteLine("Gewonnen!!!"); break; 
                    }
                default: Console.WriteLine("Nevím"); break;
            }
        }
    }
}
