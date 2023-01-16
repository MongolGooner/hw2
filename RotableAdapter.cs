using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class RotableAdapter
    {
        RotableAdapter(UObject o)
        {
            UObject = o;
        }

        UObject UObject { get; set; }

        public int GetDirection()
        {
            return (int)UObject.GetProperty("Direction");
        }

        public int GetDirectionsNumber()
        {
            return (int)UObject.GetProperty("DirectionsNumber");
        }

        public void SetDirection(int direction)
        {
            UObject.SetProperty("Direction", direction);
        }

        public int CountDirection(int toAdd)
        {
            var currentDirection = GetDirection();
            var directionsNumber = GetDirectionsNumber();
            var newDirection = (currentDirection + toAdd)% directionsNumber;
            return newDirection; 
        }
    }
}
