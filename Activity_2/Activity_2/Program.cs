namespace Activity2
{
    public class Car
    {

        public string Brand { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
    }
    class Program
    {

        static void Main(String[] args)
        {

            List<Car> list = new List<Car>();
                
                while(true)
            {

                Console.WriteLine("Enter new data?");
                Console.WriteLine("[Y] Yes / [N] No");

                if(Console.ReadLine() == "N")
                {

                    break;
                }

                Car car = new Car();

                Console.WriteLine("Enter Car Brand: ");
                car.Brand = Console.ReadLine();
                Console.WriteLine("Enter Car Color: ");
                car.Color = Console.ReadLine();
                Console.WriteLine("Enter Car Price: ");
                car.Price = Console.ReadLine();

                list.Add(car);

                list.ForEach(x =>
                    {

                        Console.WriteLine(x.Brand);
                        Console.WriteLine(x.Color);
                        Console.WriteLine(x.Price);
                        Console.WriteLine("===================");
                    });

            }


        }
    }
}