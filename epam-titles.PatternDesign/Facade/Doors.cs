using System;

namespace epam_titles.PatternDesign.Facade
{
    public class Doors
    {
        public void Open()
        {
            Console.WriteLine("Двери открыты!");
        }

        public void Close()
        {
            Console.WriteLine("Двери закрыты");
        }
    }
}