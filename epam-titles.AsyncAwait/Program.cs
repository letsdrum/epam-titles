using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersForEachAsync("1");
            NumbersForEachAsync("2");
            Console.ReadLine();
        }

        static void NumbersForEach(string ThreadName)
        {
            for(int i = 0; i < int.MaxValue; i++)
                if (i % 100000 == 0)
                    Console.WriteLine($"Поток {ThreadName}");
        }

        static async void NumbersForEachAsync(string ThreadName)
        {
            Console.WriteLine($"Начало потока {ThreadName}");
            await Task.Run(() => NumbersForEach(ThreadName));
            Console.WriteLine($"Конец потока {ThreadName}");
        }
    }
}
