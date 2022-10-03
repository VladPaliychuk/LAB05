using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main()
        {
            float l = 0, w = 0, h = 0;

            Console.WriteLine("Length = ");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Width = ");
            w = float.Parse(Console.ReadLine());
            Console.WriteLine("Height = ");
            h = float.Parse(Console.ReadLine());

            Box box = new Box(l, w, h);

            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();
        }
    }

    class Box
    {
        float l = 0, w = 0, h = 0;
        public Box(float l, float w, float h)
        {
            if (l <= 0) { Console.WriteLine("Length cannot be zero or negative"); }
            else { this.l = l; }
            if (w <= 0) { Console.WriteLine("Width cannot be zero or negative"); }
            else { this.w = w; }
            if (h <= 0) { Console.WriteLine("Height cannot be zero or negative"); }
            else { this.h = h; }
        }
        public float L
        {
            get { return this.l; }
            set { this.l = value; }
        }
        public float W
        {
            get { return this.w; }
            set { this.w = value; }
        }
        public float H
        {
            get { return this.h; }
            set { this.h = value; }
        }
        public void SurfaceArea()
        {
            float n;
            n = (2 * l * h) + (2 * l * w) + (2 * w * h);

            Console.WriteLine($"Surface Area = {n}");
        }
        public void LateralSurfaceArea()
        {
            float n;
            n = (2 * l * h) + (2 * w * h);

            Console.WriteLine($"Lateral Surface Area = {n}");
        }
        public void Volume()
        {
            float n;
            n = l * w * h;

            Console.WriteLine($"Volume = {n}");
        }
    }
}
