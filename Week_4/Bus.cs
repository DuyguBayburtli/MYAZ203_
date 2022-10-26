using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    public class Bus : Vehicle
    {
        public Bus() { }
        public Bus(double engine, string model, int numberOfWheel, int price,
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
