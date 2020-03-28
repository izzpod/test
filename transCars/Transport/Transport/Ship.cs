using System;

namespace transCars
{
    public class Ship : Transport
    {
        public Ship(int speed, string name) : base(speed, name) { speedMeasurement = SpeedMeasurement.KN; }
        public override void Move()
        {
            Console.WriteLine("корабль плывет");
        }
    }
}
