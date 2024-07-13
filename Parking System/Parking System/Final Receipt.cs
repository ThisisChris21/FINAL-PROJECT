using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    internal class Final_Receipt
    {
        static int counter = 0;
        
       public static void FinalReceipt(string plateNum, DateTime Timein, int price)
        {
            Console.Clear();
            Console.WriteLine("Creating Receipt...");
            Task.Delay(1000).Wait();
            Console.Clear();
            Console.WriteLine(" |  ****                  Lauron park | ");
            Console.WriteLine(" | *    *                    21 Ave   | ");
            Console.WriteLine(" |  ****                              | ");
            Console.WriteLine(" | *                                  | ");
            Console.WriteLine(" | *                                  | ");
            Console.WriteLine(" |   ______________________________   | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine(" |            PAID PARKING            | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine($" |              {plateNum}               | ");
            Console.WriteLine($" |     Date:{Timein}    | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine($" |               {price}php                | ");
            Console.WriteLine(" |   ______________________________   | ");
            Console.WriteLine(" |                                    | ");
            Console.WriteLine(" |       THANK YOU AND COME AGAIN     | ");
            counter++;
            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
            Console.Clear();

        }

        
       


    }
}
