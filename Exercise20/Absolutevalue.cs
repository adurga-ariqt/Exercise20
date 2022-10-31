using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    internal class Absolutevalue
    {
        

        public static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return b - a;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter values:");
           int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(a,b));
            //Console.ReadLine();
            //Console.WriteLine(result(50, 21));
           // Console.WriteLine(result(0, 23));
        }
    }
}
