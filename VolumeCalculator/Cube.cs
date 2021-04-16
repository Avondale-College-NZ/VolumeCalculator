using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public class Cube : Shape
    {
        public Cube(float length)
        {
            base.length = length;
        }

        public override float SufaceAreaCalc
        {
            get
            {
                return(float)(6 * Math.Pow(length, 2));
            }
        }

        public override float VolumeCalc
        {
            get
            {
                return (float)(Math.Pow(length, 3));
            }
        }
    }
}
