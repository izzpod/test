using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.EntitiesLibrary
{
    abstract class Way
    {
        public int distance;
        public PointWay A { get; set; }
        public PointWay B { get; set; }
    }
}
