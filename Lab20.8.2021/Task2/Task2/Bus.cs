using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Bus : Car
    {
        private byte _PassengerCount;

        public Bus(string Brand, string Model, string Color, int MaxSpeed, byte PassengerCount) :base(Brand, Model,Color,MaxSpeed)
        {
            this._PassengerCount = PassengerCount;
        }

        public byte PassengerCount
        {
            get => this._PassengerCount;
        }
        public override string Info()
        {
            return  $"Brand: {Brand} | Model: {Model} | Color: {Color} | Max Speed: {MaxSpeed} | Passenger Count: {this._PassengerCount}";
        }
    }
}
