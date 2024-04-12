using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal abstract class Vehicle
    {

        public string Id { get; set; }

        public string Color { get; set; }

        public Vehicle(string id, string color) 
        {
            Id = id;
            Color = color;
        }

        public override string ToString() 
        {
            return "Color:" + Color + " " + "Id:" + Id;
        }



    }
}
