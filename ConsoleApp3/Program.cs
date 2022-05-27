using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static void MyMethod()
        {
            Double percentage = Convert.ToDouble(Console.ReadLine());

            if (percentage >= 80) Console.Write("A+ G2rade");

            else if (percentage >= 70 && percentage < 80) Console.Write("\n A Grade");

            else if (percentage >= 60 && percentage < 70) Console.Write("\n B Grade");

            else if (percentage >= 50 && percentage < 60) Console.Write("\n C Grade");

            else Console.Write("\n Fail");
        }

        static void Main(string[] args)
        {

            Char b = 'y';
            Int32 i = 0;

            if (b != 'y') return;


            while(b == 'y')
            {

                if(i != 0)
                {
                Console.WriteLine("\n Would you Continue! Type Y for Yes and N for No \n");

                b = Convert.ToChar(Console.ReadLine());
                }

                if (b != 'n') MyMethod();
                
                i++;
            }

        }
    }
}
