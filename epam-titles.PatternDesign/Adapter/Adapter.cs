using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Adapter
{
    class Adapter : IDoSomething
    {
        private SomeExistingClass someClass = new SomeExistingClass();
        /// <summary>
        /// Реализует интерфейс IDoSomething, при этом реализация этого интерфейса
        /// использует реализацию из другого класса
        /// </summary>
        public void DoWork()
        {
            someClass.DoSomething();
        }
    }
}
