using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Horse : IParkable
    {
        public string Id { get; set; }

        public int Size { get; set; }

        public Horse(string id) 
        {
            Id = id;
            Size = 1;
        }

        public float CalculatePrice(int HoursSpent)
        {
            return 1 * HoursSpent;
        }

        public override string ToString() 
        {
            return "Horse " + Id;
        }
    }
}
