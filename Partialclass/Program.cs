using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cal c1 = new Cal();
            int c =c1.Addition(2,1);
            Console.WriteLine(c);

            Cal c2 = new Cal();
            int b=c2.Multiply(9, 3);
            Console.WriteLine(b);



        }
    }
}
