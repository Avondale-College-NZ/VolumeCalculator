using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public class Cone : Shape
    {
        public Cone(float radius, float height)
        {
            base.height = height;
            base.radius = radius;
        }

        public override float SufaceAreaCalc
        {
            get
            {
                return (float)(Math.PI * radius * (radius * Math.Sqrt(Math.Pow(height, 2) +  Math.Pow(radius, 2)))); //Area = Pir(r + sqrt(r^2 + h^2))
            }
        }

        public override float VolumeCalc
        {
            get
            {
                return (float)(Math.PI * Math.Pow(radius, 2) * height/3);
            }
        }
    }
}
