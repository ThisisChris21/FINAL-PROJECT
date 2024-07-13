using System.Collections;

namespace Parking_System
{
    
    //Clarence Christopher Lauron
    //BSCPE 1-1
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beginning Visual...
            Console.WriteLine("Good Day, WELCOME !!!");


            while (true) 
            {
                Console.Write("1. Add Parking" +
                "\n2. Exit Parking" +
                "\n3. Exit Program" +
                "\nChoose Option (1-3): ");

                //choose what type of vehicle
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Select Type of Vehicle: ");
                    Console.WriteLine("1. CAR    : 50 PHP ");
                    Console.WriteLine("2. MOTOR  : 30 PHP ");
                    Console.WriteLine("  ________________ ");
                    Console.WriteLine("");
                    Console.Write("Input Here: ");
                    //tells the type of vehicle and the amount of fee indicated
                    string Typeofvehicle = Console.ReadLine();
                    vehicleSorter(Typeofvehicle);

                }
                else if (choice == "2")
                {
                    Console.Clear();
                    numofVehicle.Listofvehicleparked();
                }
                else if (choice == "3") 
                 {
                    Console.Clear();
                    Console.WriteLine("Exiting....");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
            
 


        }
        //method of vehicle type will be choosing and the amount
        public static int vehicleSorter(string TypeofVehicle)
        {
            int price = 0;
            if (TypeofVehicle == "1") 
            {
                Console.Clear();
                Console.WriteLine("Car is selected! Please fill up the information needed below:");
                price = 50;
                InputofPNT.InputData(price);
                
            }
            else if (TypeofVehicle == "2")
            {
                Console.Clear();
                Console.WriteLine("Motor is selected! Please fill up the information needed below:");
                price = 30;
                InputofPNT.InputData(price);
            }

            return price;
        }
    }
}
