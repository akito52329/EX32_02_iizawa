using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    class Rectangle : Surface
    {
        readonly public float width;
        readonly public float height;
        public Rectangle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public override float GetSurface()
        {
            return width * height;
        }
        public override float GetCircumference()
        {
            return (width + height) * 2;
        }

        public override float GetBounds(out float height)
        {
            height = this.height;
            return width;
        }
    }
}
