using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    public partial class Cal
    {
        public int Multiply(int a, int b)
        {
            Sub(a, b);
            return a * b;
        }
        partial void Sub(int a, int b)
        {
            Console.WriteLine("sub ="+(a - b));
        }
        // helper method to give a call to sub
        public void Display(int a,int b)
        {
            Sub(a,b);
        }
    }
}