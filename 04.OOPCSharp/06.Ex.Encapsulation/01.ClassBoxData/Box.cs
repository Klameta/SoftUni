using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        private double SurfaceArea()
        {
            return 2 * (length * width + length * height + width * height);
        }
        private double LateralSurfaceArea()
        {
            return 2 * height * (length + width);
        }
        private double Volume()
        {
            return length * width * height;
        }

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():F2}\n" +
                $"Lateral Surface Area - {LateralSurfaceArea():F2}\n" +
                $"Volume - {Volume():F2}";
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0) throw new ArgumentException($"Length cannot be zero or negative.");
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0) throw new ArgumentException($"Width cannot be zero or negative.");
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0) throw new ArgumentException($"Height cannot be zero or negative.");
                height = value;
            }
        }


    }
}
