using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.GC
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new Connection())
            {
                Console.WriteLine("До создания объекта " + Convert.ToInt32(System.GC.GetTotalMemory(false)));
                var obj = new Entity();
                Console.WriteLine("После создания объекта " + Convert.ToInt32(System.GC.GetTotalMemory(false)));
                Console.WriteLine("До сборки мусора (ссылка есть) " + System.GC.GetGeneration(obj)); 
                System.GC.Collect();
                Console.WriteLine("После сборки мусора (ссылка есть) " + System.GC.GetGeneration(obj));
                obj = null;
                Console.WriteLine("Пока открыт поток " + Convert.ToInt32(System.GC.GetTotalMemory(false)));
            }

            Console.WriteLine("После работы финализатора " + Convert.ToInt32(System.GC.GetTotalMemory(false)));
        }
    }
}
