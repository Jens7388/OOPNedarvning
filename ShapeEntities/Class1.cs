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

        public abstract double CalculateArea();

        public abstract double CalculateCircumference();

        public override string ToString()
        {
            return $"Position: ({x},{y})\n";
        }
    }

    public class Circle: Shape
    {
        protected double radius;

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
            return base.ToString() +  $"Du har opretten en circle med følgende data: Radius: {radius}\nArea: {CalculateArea()}\nCircumference: {CalculateCircumference()}";
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

        protected Rectangle(int x, int y, double length) :base(x, y)
        {
            Length = length;
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
            if(length < 0.0)
            {
                return (false, "Length må ikke være under 0.0!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateWidth(double width)
        {
            if(width < 0.0)
            {
                return (false, "Width må ikke være under 0.0!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Du har opretten en rectangle med følgende data: Length: {length}\n Width: {width}\nArea: {CalculateArea()}\nCircumference: {CalculateCircumference()}";
        }
    }

    public class Square: Rectangle
    {
        public Square(int x, int y, double length) : base(x, y, length)
        {

        }

        public override double CalculateArea()
        {
            return length * length;
        }

        public override double CalculateCircumference()
        {
            return 2*(length + length);
        }

        public override string ToString()
        {
            return base.ToString() + $"Du har opretten en square med følgende data:\n Length: {length}\nArea: {CalculateArea()}\nCircumference: {CalculateCircumference()}";
        }
    }
}