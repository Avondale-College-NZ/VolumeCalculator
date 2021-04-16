using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeCalculator
{
    public class Box : Shape
    {
        public Box(float length, float width, float height)
        {
            base.length = length;
            base.width = width;
            base.height = height;
        }

        public override float SufaceAreaCalc
        {
            get
            {
                return (2 * length * width + 2 * length * height + 2 * width * height); //Area = 2lw + 2lh + 2wh
            }
        }

        public override float VolumeCalc
        {
            get
            {
                return (float)(length * width * height);
            }
        }
    }
}
