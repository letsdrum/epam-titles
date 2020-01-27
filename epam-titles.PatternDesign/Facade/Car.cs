using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Facade
{
    class Car
    {
        public Wheels Wheels { get; set; }
        public Engine Engine { get; set; }
        public Doors Doors { get; set; }

        public Car(Wheels Wheels, Engine Engine, Doors Doors)
        {
            this.Wheels = Wheels;
            this.Engine = Engine;
            this.Doors = Doors;
        }

        public void Start()
        {
            Doors.Close();
            Engine.Start();
            Wheels.Rotate();
        }
        public void Stop()
        {
            Console.WriteLine("Машина остановилась!");
        }

        public void OpenTheDoor()
        {
            Doors.Open();
        }

        public void CloseTheDoor()
        {
            Doors.Close();
        }
    }
}
