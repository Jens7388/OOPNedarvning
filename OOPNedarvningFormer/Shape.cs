using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvningFormer
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
}
