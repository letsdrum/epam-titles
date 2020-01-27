using epam_titles.PatternDesign.Singleton;
using epam_titles.PatternDesign.Strategy;
using epam_titles.PatternDesign.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epam_titles.PatternDesign.Facade;

namespace epam_titles.PatternDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            OperatingSystemSingleton.Alert();
            var OS = new OperatingSystemSingleton();
            Console.WriteLine("----------------------------------------------------");

            //Strategy
            Console.WriteLine("Killer with AK-47");
            var Killer = new Killer(new Ak_47());
            Killer.TryToKill();
            Killer.Reload();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Killer with Pistol");
            var AnotherKiller = new Killer(new Pistol());
            AnotherKiller.TryToKill();
            AnotherKiller.Reload();
            Console.WriteLine("----------------------------------------------------");

            //Facade
            Car car = new Car(new Wheels(), new Engine(), new Doors());
            car.Start();
            car.Stop();

            car.OpenTheDoor();
            car.CloseTheDoor();
            Console.WriteLine("----------------------------------------------------");

            //Adapter
            var adapter = new Adapter.Adapter();
            adapter.DoWork();
            Console.WriteLine("----------------------------------------------------");
            
            Console.ReadLine();
        }
    }
}
