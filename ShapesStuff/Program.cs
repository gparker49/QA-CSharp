using System;

namespace ShapesStuff
{
    class Shape
    {
        private int width;
        private int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    // DERIVED CLASS
    class Rectangle : Shape {
        public int getArea()
        {
            return (width * height);
        }
    }
    sealed class Triangle : Shape
    {
        public int getArea()
        {
            return (width * height) / 2;
        }
    }
}
