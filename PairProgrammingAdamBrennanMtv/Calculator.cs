using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingAdamBrennanMtv
{
    class Calculator
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public char Operator { get; set; }

        // Methods
        public void ParseInput(string input)
        {
            string[] splitInput = input.Split(' ');
            PopulateCalcValues(splitInput);
        }

        private void PopulateCalcValues(string[] splitInput)
        {
            Input1 = int.Parse(splitInput[0]);
            Input2 = int.Parse(splitInput[2]);
            Operator = char.Parse(splitInput[1]);
            
        }

        public int Calculate()
        {
            switch(Operator)
            {
                case ('+'):
                    return (Input1 + Input2);

                case ('-'):
                    return (Input1 - Input2);

                case ('*'):
                    return (Input1 * Input2);

                case ('/'):
                    return (Input1 / Input2);

                case ('%'):
                    return (Input1 % Input2);

                // exceptions are errors
                // will be handled in the Main method
                // are classes that travel through different modules
                default:
                    throw new ArgumentOutOfRangeException("Operator", Operator, "Not a valid operation");
            }
        }
    }
}
