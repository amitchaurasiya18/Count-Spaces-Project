using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpacesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string inputString = Console.ReadLine();
            
            Console.WriteLine("Number of Spaces in '{0}' is {1}",inputString, CountNumberOfSpaces(inputString));
        }

        static int CountNumberOfSpaces(string inputString)
        {
            int counterVariable = 0;
            //counterVariable = inputString.Split(' ').Length;
            //return counterVariable-1;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    counterVariable++;
                }
            }
            return counterVariable;
        }
    }
}
