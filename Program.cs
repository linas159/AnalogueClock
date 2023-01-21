using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogueClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hours: ");
            int hours = int.Parse(Console.ReadLine()); // Input hours 0-12

            Console.WriteLine("Enter the minutes: ");
            int minutes = int.Parse(Console.ReadLine()); // Input minutes 0-60

            double hourAngle = (hours * 30) + (minutes * 0.5); // Hour plus minutes that effect hour angle
            double minuteAngle = minutes * 6; // Minute angle

            double angle = Math.Abs(hourAngle - minuteAngle);
            angle = Math.Min(360 - angle, angle); // Lesser angle

            Console.WriteLine("The lesser angle between the hours and minutes arrows is: " + angle + " degrees."); // Output
            Console.ReadKey();
        }
    }
}
