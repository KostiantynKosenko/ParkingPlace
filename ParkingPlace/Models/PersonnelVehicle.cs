using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal abstract class PersonnelVehicle : Vehicle, IParkable
    {
        public PersonnelVehicle(string id, string color, int seats, int size) :base(id,color)  
        {
            Size = size;
            Seats = seats;
        }


        public int Size { get; set; }

        public int Seats { get; set; }

        public virtual float CalculatePrice(int HoursSpent) 
        {
            return HoursSpent * Size * Seats;
        }
    }
}
