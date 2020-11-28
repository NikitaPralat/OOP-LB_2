using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Point
    {
        int point1;
        int point2;
        string pointName;

        public Point(int point1, int point2, string pointName)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.pointName = pointName;
        }
        public int Point1
        {
            get
            {
                return this.point1;
            }
            set { }
        }
        public int Point2
        {
            get
            {
                return this.point2;
            }
            set { }
        }
        public string PointName
        {
            get
            {
                return this.pointName;
            }
            set { }
        }
    }
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public string Name { get; set; }
        
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            Name = "треугольник";
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            Name = "четырехугольник";
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            Name = "пятиугольник";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.Point1 - A.Point1) * (B.Point1 - A.Point1) + (B.Point2 - A.Point2) * (B.Point2 - A.Point2));
        }
        public void PerimeterCalculator()
        {
            double perimeter;
            if (E != null)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            }
            else if (D != null)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E); 
            }
            else 
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A); 
            }

            Console.WriteLine($"Периметр {Name}a: {perimeter}");
        }
    }
}
