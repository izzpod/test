using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.EntitiesLibrary
{
    abstract class PointWay
    {
        public List<Way> list { get; set; } = new List<Way>();

    }
}
