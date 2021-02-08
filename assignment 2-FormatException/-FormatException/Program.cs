using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FormatException
{
    //declaring class
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonsUsed = 0;
            //using try and catch
            try
            {
                Console.WriteLine("Please enter miles driven");
                milesDriven = Convert.ToDouble(Console.ReadLine());

               
                Console.WriteLine("Please enter gallons used");
                gallonsUsed = Convert.ToDouble(Console.ReadLine());

                double milesPerGallon = milesDriven / gallonsUsed;
                Console.WriteLine("Mileage is {0} miles per gallon", milesPerGallon);
            }
            catch (FormatException e)
            {
                Console.WriteLine("I'm sorry ,wrong entry ,try again!\n{0}", e.Message);
            }
          

            Console.ReadLine();
        }
    }
}
