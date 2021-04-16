using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public abstract class Shape
    {
        protected float length { get; set; }
        protected float width { get; set; }
        protected float height { get; set; }

        protected float radius { get; set; } 

        public abstract float VolumeCalc { get; }
        public abstract float SufaceAreaCalc { get; }

    }
}
