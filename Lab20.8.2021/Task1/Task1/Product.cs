using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Product
    {
        private string _name;
        private int _price;
        private int _count;
        private int _TotalIncome = 0;

        public string name
        {
            get => this._name;
            set
            {
                if(name!= String.Empty)
                {
                    this._name = value;
                }
                else
                {
                    this._name = "";

                }
            }
        }

        public int price
        {
            get => this._price;
            set
            {
                this._price = value;
            }
        }

        public int count
        {
            get => this._count;
            set => this._count = value;
        }

        public int TotalIncome
        {
            get => this._TotalIncome;
            set => this._TotalIncome = value;
        }


        public void Sell()
        {
            if(name != "")
            {

                if (count > 0)
                {

                    this._count--;
                    this._TotalIncome += this._price;
                    Console.WriteLine($"Sold 1 {this._name} Total Income: {this._TotalIncome}");
                }
                else
                {
                    Console.WriteLine("Not Enough Product to sell..");
                }
            }
            else
            {

                Console.WriteLine("Please Specify Product name..");
                if (count > 0)
                {
                    this._count--;
                    this._TotalIncome += this._price;
                    Console.WriteLine($"Sold 1 {this._name} Total Income: {this._TotalIncome}");
                }
                else
                {
                   
                    Console.WriteLine("Not Enough Product to sell..");
                }
            }
      
        }
    }
}
