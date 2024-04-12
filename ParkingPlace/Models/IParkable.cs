using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingPlace.Models
{
    public interface IParkable
    {
        public string Id { get; set; }
        public int Size { get; set; }

        float CalculatePrice(int HoursSpent);
    }
}
