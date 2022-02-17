using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    class Triangle : Surface
    {
        readonly public float lineA;
        readonly public float lineB;
        readonly public float lineC;
        public float triangleSurface;

        public Triangle(float a = 0, float b = 0 , float c = 0)
        {
            this.lineA = a;
            this.lineB = b;
            this.lineC = c;
        }

        public override float GetSurface()
        {
            float smallS = (lineA + lineB + lineC) / 2;
            return triangleSurface = MathF.Sqrt(smallS * (smallS - lineA) * (smallS - lineB) * (smallS - lineC));
        }
        public override float GetCircumference()
        {
            return lineA + lineB + lineC;
        }

        public override float GetBounds(out float height)
        {
            float bigMath = Math.Max(lineA, lineB);
            bigMath = Math.Max(bigMath, lineC);
            height = triangleSurface / bigMath * 2;
            return bigMath;
        }
    }
}
