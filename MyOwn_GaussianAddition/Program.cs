using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn_GaussianAddition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetAddition(0, 100));
            Console.ReadKey();
        }

        // This is the "small Gauss", only param "end" can be set, the rest needs to start from 1
        public static double GetAddition(int start, int end)
        {
            double sum = 0;
            while (start < end)
            {
                sum += ++start;
            }
            return sum;
        }
    }
}