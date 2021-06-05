using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityMedicalSolutionsProgramAssignment.Functionality
{
    internal class TestCaseBasicFunctionality
    {       
        /// <summary>
        /// Takes an int, maxNum, as a parameter and will print all the numbers from 1 to maxNum to the console. However,
        /// if the number is divisble by 3 it will print 'Test', if divisible by 5 it will print 'Case' and if divisible 
        /// by both 3 and 5 it will print 'TestCase'.
        /// </summary>
        /// <param name="maxNum">A int.</param>
        internal void Run(int maxNum)
        {
            StringBuilder currentMessage = new StringBuilder();

            for (int i = 1; i < maxNum; i++)
            {
                currentMessage.Clear();
                
                CheckIfDivisble(i, 3, "Test", currentMessage);              
                CheckIfDivisble(i, 5, "Case", currentMessage);

                if (currentMessage.Length == 0)
                {
                    currentMessage.Append(i);
                }

                Console.WriteLine(currentMessage.ToString());             
            }
        }

        /// <summary>
        /// Takes two ints - num & divisor, a string - messageToPrint & a StringBuilder - currentMessage as parameters.
        /// If num is divisible by divisor then appends messageToPrint to currentMessage.
        /// </summary>
        /// <param name="maxNum">A int.</param>
        /// <param name="divisor">A int.</param>
        /// <param name="messageToPrint">A string.</param>
        /// <param name="maxNum">A StringBuilder.</param>
        private void CheckIfDivisble(int num, int divisor, string messageToPrint, StringBuilder currentMessage)
        {
            if(num % divisor == 0)
            {
                currentMessage.Append(messageToPrint);
            }
        }
    }
}
