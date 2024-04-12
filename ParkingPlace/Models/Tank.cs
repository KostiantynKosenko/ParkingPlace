using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Tank : Vehicle
    {

        public int Size { get; set; }

        public Tank(string id, string color, int size = 2) : base(id, color)
        {
            Size = size;
        }

        public float CalculatePrice(int HoursSpent) 
        {
            return 10000;
        }

        public override string ToString()
        {
            return "Tank " + base.ToString();
        }
    }
}
