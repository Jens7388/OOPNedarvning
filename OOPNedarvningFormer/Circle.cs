using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvningFormer
{
    class Circle: Shape
    {
        private double radius;

        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public double Radius
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
}
