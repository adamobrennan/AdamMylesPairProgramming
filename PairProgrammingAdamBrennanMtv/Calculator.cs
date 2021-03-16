using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingAdamBrennanMtv
{
    class Calculator
    {
        // set properties of the Calculator class
        // get; means property is readable by other classes
        // set; means other classes can change the value of the property
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public char Operator { get; set; }

        // Methods

        // takes in input from user and turns it into a string array
        public void ParseInput(string input)
        {
            string[] splitInput = input.Split(' ');
            PopulateCalcValues(splitInput);
        }

        // assigns the values in the array to the properties of this class
        private void PopulateCalcValues(string[] splitInput)
        {
            Input1 = int.Parse(splitInput[0]);
            Input2 = int.Parse(splitInput[2]);
            Operator = char.Parse(splitInput[1]);
            
        }

        // calculate and return the result as int
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
