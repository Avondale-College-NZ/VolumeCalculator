using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public class Sphere : Shape
    {
        public Sphere(float radius)
        {
            this.radius = radius;
        }

        public override float SufaceAreaCalc
        {
            get
            {
                return (float)(4 * Math.PI *  Math.Pow(radius, 2)); //Area = 4Pir^2
            }
        }

        public override float VolumeCalc
        {
            get
            {
                return (float)(4 * Math.PI * Math.Pow(radius, 3) / 3); //Volume = 4Pir^3/3
            }
        }
    }
}
