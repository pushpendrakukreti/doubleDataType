using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDataTypeDecimalValueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Hey! ";

            int a;
            double b;
            string c;

            Console.Write("Enter An Integer = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("\nEnter A Decimal Number = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("\nEnter A String = ");
            c = Console.ReadLine();

            int sum1 =i+a;
            double sum2 =d+b;
            string sum3 =string.Concat(s,c);
            Console.WriteLine("\n\n");
            Console.WriteLine("                      ------------------------------------------------------------");
            Console.WriteLine("                      ---------------------------RESULT---------------------------");
            Console.WriteLine("                      ------------------------------------------------------------");

            Console.WriteLine("\nSum of "+i+" and "+a+" = "+sum1);
            
            //{0:F1} will get only one decimal value after point
            Console.WriteLine("\nSum of " + d + " and " +b+" = " +"{0:F1}", sum2);
            Console.WriteLine("\n"+sum3);

            Console.ReadLine();
        }
    }
}
