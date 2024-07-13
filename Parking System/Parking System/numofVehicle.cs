using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System;

    internal class numofVehicle
    {//stores the data of vehicle part 
   static  Dictionary<string, DateTime> plateofCars = new Dictionary<string, DateTime>();

    public static void plateofcarsadder(string plateNum, DateTime timein, int price)//methods that puts user input in the list and calls the receipts.
    {
        plateofCars.Add(plateNum, timein);
        Final_Receipt.FinalReceipt(plateNum, timein, price);//this are the final receipts
    }
    public static void Listofvehicleparked()//methods of the vehicle that are currently on the slot
    {
        if (plateofCars.Count != 0)
        {
            //tells the list of all of the data that are currently put in the list
            Console.WriteLine("List of vehicle parked: ");
            int counter = 1;
            int indexnum = 0;
            foreach (var item in plateofCars)
            {
                Console.WriteLine($"A{counter}. {item}");
                counter++;
            }
            //when you want to remove a specific vehicle in the list
            Console.Write("Clear a parking slot? (y/n): ");
            string choice = Console.ReadLine();
            
            if (choice != "n")
            {
                //entering the data of a vehicle you want to removed on the list
                Console.Write("Type the plate number of the vehicle that exited: ");
                string platenum = (Console.ReadLine());
                Console.Write("\nTimein of the vehicle: ");
                DateTime timein = Convert.ToDateTime(Console.ReadLine());
                plateofCars.Remove(platenum, out timein);

                Console.WriteLine("Selected Vehicle has been cleared in th parking slot successfully!");
                Task.Delay(1000).Wait();

                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("\nNo vehicle parked at the moment");
        }

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    

    }
        


    
 


