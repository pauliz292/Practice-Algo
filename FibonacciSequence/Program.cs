using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        public static int i;

       public static void Main()
        {
            int n;
            int a = 0;
            int b = 1;

            Console.Write("Enter the limit: ");
            n = int.Parse(Console.ReadLine());

            for ( a = 0; i < n; i++ )
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.Read();
        }
    }
}
