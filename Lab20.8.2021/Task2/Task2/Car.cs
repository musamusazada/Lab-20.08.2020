using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Car
    {
        private string _brand="N/A";
        private string _model = "N/A";
        private string _color = "N/A";
        private int _MaxSpeed = 0;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string Brand, string Model)
        {
            this._brand = Brand;
            this._model = Model;
        }
        public Car(string Brand, string Model, string Color, int MaxSpeed) : this(Brand, Model)
        {
            this._color = Color;
            this._MaxSpeed = MaxSpeed;

        }

        public string Brand
        {
            get => this._brand;
        }
        public string Model
        {
            get => this._model;
        }
        public string Color
        {
            get => this._color;
        }
        public int MaxSpeed
        {
            get => this._MaxSpeed;
        }
        public virtual string Info()
        {
            return $"Brand: {this._brand} | Model: {this._model} | Color: {this._color} | Max Speed: {this._MaxSpeed}";
        }
    }
}
