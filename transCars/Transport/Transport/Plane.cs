using System;

namespace transCars
{
   public class Plane : Transport
    {
        public Plane(int speed, string name) : base(speed, name) { speedMeasurement = SpeedMeasurement.KMH; }
        public override void Move()
        {
            Console.WriteLine("самолет летит");
        }
    }
}
