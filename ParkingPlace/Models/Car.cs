using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Car : PersonnelVehicle
    {
        public Car(string id, string color, int seats) : base(id, color, seats, 1) 
        {
        }

        public override float CalculatePrice(int HoursSpent)
        {
            return 15 * HoursSpent;
        }

        public override string ToString()
        {
            return "Car " + base.ToString();
        }
    }
}
