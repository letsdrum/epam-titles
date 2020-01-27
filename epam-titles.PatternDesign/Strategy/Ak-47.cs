using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Strategy
{
    class Ak_47 : IHandWeapon
    {
        public void Reload()
        {
            Console.WriteLine("Перезарядка AK-47");
        }

        public void Shoot()
        {
            Console.WriteLine("Открыть огонь с АК-47");
        }
    }
}
