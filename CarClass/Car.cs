using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00m;

        }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }
        public override string ToString()
        {
            return "Make: " + Make +" Model: " + Model + " Price: $ " + Price;
        }
    }
}
