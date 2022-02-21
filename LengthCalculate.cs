using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProb
{
    public class LengthCalculate
    {
        public static void CartLengthCalculate()
        {
            Console.WriteLine("x1 and y1");

            var x1=Convert.ToInt32(Console.ReadLine());
            var y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x2 and y2");

            var x2=Convert.ToInt32(Console.ReadLine());
            var y2=Convert.ToInt32(Console.ReadLine());

            var L=((x2-x1)^2+(y2-y1)^2);
            Console.WriteLine("length of the line is :=" + L);
        }
    }
}
