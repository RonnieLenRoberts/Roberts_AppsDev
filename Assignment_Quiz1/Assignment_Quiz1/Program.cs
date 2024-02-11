using System;
using System.IO;

namespace Assignment_Quiz1
{

    public class Person
    {

        public string? Name { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {

        static void Main(String[] args)
        {

            List<Person> list = new List<Person>();

            while(true)
            {

                Console.WriteLine(" ");
                Console.WriteLine("Enter Data:");
                Console.WriteLine("Press [Y] to Continue or [N] to Quit.");

                if(Console.ReadLine() == "N")
                {

                    break;
                }

                Person person = new Person();

                Console.WriteLine(" ");
                Console.WriteLine("Enter Name:");
                person.Name = Console.ReadLine();
                Console.WriteLine("Enter their Weight:");
                person.Weight = int.Parse(Console.ReadLine());

                list.Add(person);
            }

            int Sum = 0;

            Console.WriteLine(" ");
            list.ForEach(x => Console.WriteLine(x.Name));
            list.ForEach(x => 
            {

                Sum += x.Weight;    
            });
            Console.WriteLine("Total Weight:" + Sum);
        }
    }
}
