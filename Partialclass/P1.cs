using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{

    public partial class Cal
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        partial void Sub(int a, int b);
    }
}
