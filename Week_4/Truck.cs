using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    public class Truck : Vehicle
    {
        private int _numberOfWheel;
        public override int NumberOfWheel
        {
            get => _numberOfWheel;
            set
            {
                if (value <= 12)
                    _numberOfWheel = value;
                else
                    throw new Exception("Invalid Value");
            }
        }
        public Truck() { }
        public Truck(double engine, string model, int numberOfWheel, int price,
       string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}
