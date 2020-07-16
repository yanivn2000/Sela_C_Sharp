using System;

namespace ClassOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create points
            Point Point1 = new Point(5, 10);//5,10
            Point Point2 = new Point(2, 7);//2,7
            Point Point11 = new Point(2, 7);//2,7
            //Point + integer (+=)
            Point11 += 4;//6,11

            //Point + Point
            Point Point3 = Point1 + Point2;//7,11
            //Point + Integer
            Point Point4 = Point2 + 3;//5,10

            //Point != Point
            if (Point1 != Point2)//not eq
                Console.WriteLine("Point1 != Point2");
            else
                Console.WriteLine("Point1 == Point2 - YOU HAVE A BUG");

            //Point != Point
            if (Point1 == Point4)//eq
                Console.WriteLine("Point1 == Point4");
            else
                Console.WriteLine("Point1 != Point4");

            string str = "Price is " + 4;

            //Point * Point
            Point Point5 = new Point(3, 4);
            Point5 = Point1 + Point2;

            if (Point1.Equals(Point3))
                Console.WriteLine("Point1 Equals Point3");

            if (Point1 == Point2)
                Console.WriteLine("Point1 Equals Point2");


            Distance distance1 = new Distance(90);
            //Point + Distance
            Point Point6 = Point1 + distance1;//95,100
            //Distance + Point
            Point Point7 = distance1 + Point1;//95,100

            Console.WriteLine($"Point1: {Point1}");
            Console.WriteLine($"Point2: {Point2}");
            Console.WriteLine($"Point3: {Point3}");
            Console.WriteLine($"Point4: {Point4}");
            Console.WriteLine($"Point5: {Point5}");
            Console.WriteLine($"Point6: {Point7}");
            Console.WriteLine($"Point6: {Point7}");
            Console.WriteLine($"Point11: {Point11}");
            /*
             * Expected output:
                Point1 != Point2
                Point1 == Point4
                Point1: x:5, y:10
                Point2: x:2, y:7
                Point3: x:7, y:17
                Point4: x:5, y:10
                Point5: x:10, y:70
                Point6: x:95, y:100
                Point6: x:95, y:100
                Point11: x:6, y:11
                */
        }


        private class Point
        {
            public int x { get; set; }
            public int y { get; set; }

            public Point(int x1, int y1)
            {
                x = x1;
                y = y1;
            }

            public override string ToString()
            {
                return $"x:{x}, y:{y}";
            }

            public override bool Equals(object obj)
            {
                return obj is Point point &&
                       x == point.x &&
                       y == point.y;
            }

            public static Point operator +(Point lvalue, int rvalue)
            {
                return new Point(lvalue.x + rvalue, lvalue.y + rvalue);
            }
            public static Point operator +(Point lvalue, Distance rvalue)
            {
                return new Point(lvalue.x + rvalue.d, lvalue.y + rvalue.d);
            }
            public static Point operator +(Distance rvalue, Point lvalue)
            {
                return new Point(lvalue.x + rvalue.d, lvalue.y + rvalue.d);
            }
            public static Point operator +(Point lvalue, Point rvalue)
            {
                return new Point(lvalue.x + rvalue.x, lvalue.y + rvalue.y);
            }
            public static Point operator -(Point lvalue, Point rvalue)
            {
                return new Point(lvalue.x - rvalue.x, lvalue.y - rvalue.y);
            }
            public static Point operator *(Point lvalue, Point rvalue)
            {
                return new Point(lvalue.x * rvalue.x, lvalue.y * rvalue.y);
            }
            public static bool operator ==(Point lvalue, Point rvalue)
            {
                if (lvalue.x == rvalue.x && lvalue.y == rvalue.y)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(Point lvalue, Point rvalue)
            {
                if (lvalue.x != rvalue.x || lvalue.y != rvalue.y)
                    return true;
                else
                    return false;
            }
        }
    }
    class Distance
    {
        public int d { get; set; }
        public Distance(int d1)
        {
            d = d1;
        }
        public override string ToString()
        {
            return $"d:{d}";
        }
    }
}
