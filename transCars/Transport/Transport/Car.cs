using System;

namespace transCars
{
    class Car : Transport
    {
        public Car(int speed, string name) : base(speed, name) { speedMeasurement = SpeedMeasurement.KMH; }

        public override void Move()
        {
            Console.WriteLine("машина едет");
        }
    }
}
