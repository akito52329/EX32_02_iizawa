using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    class Circle : Surface
    {
        readonly public float radius;
        /// <summary>
        /// 円
        /// </summary>
        /// <param name="radius">半径</param>
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }

        public override float GetSurface()
        {
            return (float)(radius * radius * Math.PI);
        }
        public override float GetCircumference()
        {
            return (float)(radius * 2 * Math.PI);
        }

        public override float GetBounds(out float height)
        {
            height = this.radius * 2;
            return height;
        }
    }
}
