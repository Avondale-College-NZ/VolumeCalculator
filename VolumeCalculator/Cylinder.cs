using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public class Cylinder : Shape
    {
        public Cylinder(float radius, float height)
        {
            base.height = height;
            base.radius = radius;
        }

        public override float SufaceAreaCalc
        {
            get
            {
                return (float)(2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2)); //Area = 2Pirh + 2Pir^2
            }
        }

        public override float VolumeCalc
        {
            get
            {
                return (float)(Math.PI * Math.Pow(radius, 2) * height);
            }
        }
    }
}
