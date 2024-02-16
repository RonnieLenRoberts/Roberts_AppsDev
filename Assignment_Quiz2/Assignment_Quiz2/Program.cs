using System;
using System.IO;

namespace Assignment_Quiz2
{

    class Program
    {

        public static List<string> listOfStrings = new();
        public static List<int> listOfIntegers = new();

        public static void AddOrder()
        {

            Console.WriteLine(" ");
            Console.WriteLine("Enter Item: ");
            string Item = Console.ReadLine();
            listOfStrings.Add(Item);
            Console.WriteLine(" ");
            Console.WriteLine("Enter Item Price: ");
            int Price = int.Parse(Console.ReadLine());
            listOfIntegers.Add(Price);   
        }

        public static void SummarizeOrder()
        {

            Console.WriteLine(" ");
            Console.WriteLine("Current Order:");

            int Counter = 1;

            foreach(string x in listOfStrings)
                {

                Console.WriteLine($"{Counter}: {x}");

                Counter++;
            }
        }

        public static void PlaceOrder()
        {

            Console.WriteLine(" ");
            Console.WriteLine("Order Placed.");

            listOfStrings.RemoveRange(0, listOfStrings.Count());
            listOfIntegers.RemoveRange(0, listOfIntegers.Count());
        }

        public static void TotalPrice()
        {

            int Sum = 0;

            foreach (int x in listOfIntegers)
            {

                Sum += x;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Total Price:");
            Console.WriteLine(Sum);
        }

        static void Main(String[] args)
        {

            while (true)
            {

                Console.WriteLine(" ");
                Console.WriteLine("Ordering Application:");
                Console.WriteLine("1. Add Item to Order");
                Console.WriteLine("2. View Order Summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. View Total Price");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your Choice:");

                string Option = Console.ReadLine();

                if(Option == "5")
                {

                    Console.WriteLine(" ");
                    Console.WriteLine("Program Terminated.");

                    break;
                }

                switch (Option)
                {

                    case "1":

                        AddOrder();

                        break;
                    case "2":

                        SummarizeOrder();

                        break;
                    case "3":

                        PlaceOrder();

                        break;
                    case "4":

                        TotalPrice();

                        break;

                    
                    default:

                        Console.WriteLine(" ");
                        Console.WriteLine("[ERROR] Invalid Input.");

                        break;
                }

            }

        }
    }
}