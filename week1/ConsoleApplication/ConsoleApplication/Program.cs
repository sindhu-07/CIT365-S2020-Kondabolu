using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Name variable
            string Name = "Kosta";
            //Location variable
            string Location = "USA";
            // Display the variable using Console.WriteLine method
            // With string interpolation
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My Location is " + Location);

            //Current Date
            Console.WriteLine("Current Date :"+DateTime.Now.Date);

            //the number of days until Christmas this year 
            int NumberOfDaysForChritmas = (Convert.ToDateTime("12/25/2020").Date - DateTime.Now.Date).Days;
            Console.WriteLine("the number of days until Christmas this year is " + NumberOfDaysForChritmas);

            //C# Programming Yellow Book by Rob Miles
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Enter Width of wood/glass :");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Enter Height of wood/glass :");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
