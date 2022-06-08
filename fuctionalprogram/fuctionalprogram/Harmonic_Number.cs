using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuctionalprogram
{
    internal class Harmonic_Number
    {
        public void Harmonic()
        {
            float Harmonic_result = 0;
            Console.WriteLine("enter the value of N for Nth harmonic;");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Harmonic_result += 1 / i;


            }
            Console.WriteLine("The Nth harmonic is given by {0}", Harmonic_result);
        }
    }
}
