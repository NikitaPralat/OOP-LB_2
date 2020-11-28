using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        public double PerimeterCalculator()
        {
            return (this.side1 + this.side2) * 2;
        }

        public double Area {
            get {
                    return AreaCalculator();
                } 
            set {}
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
            set { }
        }
    }
}
