namespace transCars
{
    abstract class Transport
    {
        protected int speed;
        protected string name;
        protected SpeedMeasurement speedMeasurement;

        public Transport(int speed, string name)
        {
            this.speed = speed;
            this.name = name;
        }

        public abstract void Move(); 
    }
}
