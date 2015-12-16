﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x =" + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x =" + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x =" + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            Reset(p2);
            Console.WriteLine("Call Move. p2.x = " + p2.x + ", p1.y = " + p2.y);





            Console.ReadLine();

        }

        public static void Func1(int value)
        {

        }

        public static void Func2(int value)
        {
            value = value + 1;

        }

        public static void Func3(int x)
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Reset(Point p)
        {
            p = new Point();
            
        }


    }
}
