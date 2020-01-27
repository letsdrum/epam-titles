using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Strategy
{
    public interface IHandWeapon
    {
        void Shoot();
        void Reload();
    }
}
