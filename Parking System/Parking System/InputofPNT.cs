using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    internal class InputofPNT
    {
        static int limiter = 20;
        static int lim = 0;
        public static void InputData(int price)
        {

            //The user will input its info before entering the parking area to know the plate num and the time

            //the limit are indicating how many available slot are available 
            if (lim < limiter)
            {
                Console.WriteLine($"Parking slot available!");
                Console.WriteLine("");
                Console.Write("Input Plate Number: ");
                string plateNum = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Time in (HH:MM format): ");
                DateTime timein = DateTime.Parse(Console.ReadLine());

                numofVehicle.plateofcarsadder(plateNum, timein, price);
            }
            else//if the limit reach its limits, the code will print thats is full
            {
                Console.WriteLine("Parking is full right now!");
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }

        }
    }
}
