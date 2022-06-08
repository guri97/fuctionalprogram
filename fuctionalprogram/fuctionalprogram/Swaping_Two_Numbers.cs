using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuctionalprogram
{
    internal class Swaping_Two_Numbers
    {
        public void SwapTwoNumber()
        {
            int num1, num2, temp;
            Console.WriteLine("Give the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
            Console.ReadLine();
        }
    }
}
