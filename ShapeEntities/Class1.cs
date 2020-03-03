using System;

namespace ShapeEntities
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        protected Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public virtual int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public virtual double CalculateArea()
        {
            return 0;
        }
        public virtual double CalculateCircumference()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Position: ({x}, {y})";
        }
    }
    public class Circle: Shape
    {
        private double radius;

        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public virtual double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateRadius(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(validationResult.errorMessage);
                }
                if(value != radius)
                {
                    radius = value;
                }
            }
        }
        public (bool, string) ValidateRadius(double radius)
        {
            if(radius < 0.0)
            {
                return (false, "Radius må ikke være på under 0.0!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * (radius * radius);
        }
        public override double CalculateCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public override string ToString()
        {
            return $"Position: ({x},{y}) Radius: {radius}";
        }
    }
    public class Rectangle: Shape
    {
        protected double length;
        protected double width;

        public Rectangle(int x, int y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }

        public virtual double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public virtual double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public override double CalculateArea()
        {
            return length * width;
        }
        public override double CalculateCircumference()
        {
            return 2 * (length + width);
        }
        public static (bool, string) ValidateLength(double length)
        {

        }
    }
}
