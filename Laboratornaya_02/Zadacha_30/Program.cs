﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);
            string b;
            b = Console.ReadLine();
            double B;
            B = double.Parse(b);
            double R;
            R = Math.Sin(A * Math.PI / 180) * Math.Cos(B * Math.PI / 180) + Math.Sin(B * Math.PI / 180) * Math.Cos(A * Math.PI / 180);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
