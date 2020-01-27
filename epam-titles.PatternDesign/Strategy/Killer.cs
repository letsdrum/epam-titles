using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Strategy
{
    class Killer
    {
        IHandWeapon weapon { get; set; }
        public Killer(IHandWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void TryToKill()
        {
            weapon.Shoot();
        }
        public void Reload()
        {
            weapon.Reload();
        }
    }
}
