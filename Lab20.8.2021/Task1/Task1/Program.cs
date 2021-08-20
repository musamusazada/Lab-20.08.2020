
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            pr1.name = "";
            pr1.count = 5;
            pr1.price = 10;

            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
        }
    }
}
