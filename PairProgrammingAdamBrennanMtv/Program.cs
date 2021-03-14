using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingAdamBrennanMtv
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while(true)
            {
                Console.WriteLine("Enter your problem below with spaces as shown: 2 + 3");
                string input = Console.ReadLine();

                if(input.Equals("quit"))
                {
                    break;
                }

                int result = 0;
                try
                {
                    calculator.ParseInput(input);
                    result = calculator.Calculate();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
