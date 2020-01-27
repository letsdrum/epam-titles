using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.GC
{
    class Connection : IDisposable
    {
        public void Dispose()
        {
            System.GC.Collect();
        }
    }
}
