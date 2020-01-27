using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Strategy
{
    class Pistol : IHandWeapon
    {
        public void Reload()
        {
            Console.WriteLine("Перезарядка пистолета");
        }

        public void Shoot()
        {
            Console.WriteLine("Открыть огонь с пистолета");
        }
    }
}
