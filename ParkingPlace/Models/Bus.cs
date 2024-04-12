using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Bus: PersonnelVehicle
    {
        public Bus(string id, string color, int seats) : base(id, color, seats, 5) 
        {
        }

        public override float CalculatePrice(int HoursSpent)
        {
            return 200 + base.CalculatePrice(HoursSpent);
        }

        public override string ToString()
        {
            return "Bus " + base.ToString()+ " " + "with:" + Seats;
        }
    }
}
