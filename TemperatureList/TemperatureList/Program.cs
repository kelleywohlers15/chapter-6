using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int average;
            int total = 0;
            int distanceFromAvg;
            int[] temps = new int[7];

            for (int i = 0; i < temps.Length; ++i)
            {
                Console.WriteLine("Please enter temps");
                temps[i] = Convert.ToInt32(Console.ReadLine());
                total = temps[i] + total;
                count++;
            }
            average = total / count;
            Console.WriteLine("---------------------------------");
            Console.WriteLine(average);
        }  
    }
}
