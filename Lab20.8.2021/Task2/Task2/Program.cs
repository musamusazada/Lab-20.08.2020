using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus("niva", "niva", "black", 200, 5);

            Car car1 = new Car("niva1", "niva1", "black", 200);

            Console.WriteLine(bus1.Info());
            Console.WriteLine(car1.Info());
        }
    }
}
