

using System.Numerics;

namespace hw2
{
    
    public class MovableAdapter
    {
        MovableAdapter(UObject o)
        { 
            UObject = o;
        }

        UObject UObject { get; set; }

        public Vector Position()
        {
           return (Vector)UObject.GetProperty("Position");
        }
        public void SetPosition(Vector newV)
        {
            UObject.SetProperty("Position", newV);
        }
        public Vector Velocity()
        {
            int d = (int)UObject.GetProperty("Direction");
            int n = (int)UObject.GetProperty("DirectionsNumber");
            int v = (int)UObject.GetProperty("Velocity");
            return new Vector(
            v * Math.Cos(d / 360 * n),
            v * Math.Sin(d / 360 * n)    
            );
        }
    }

    
}
