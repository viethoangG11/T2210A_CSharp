using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.baithic_
{
    internal class GeometryExample
    {
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        public void Process(double radius, double height)
        {
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base: {0} | Lateral: {1} | Total: {2} | Volume: {3}", BaseArea, LateralArea, TotalArea, Volume);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the GeometryExample");
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            GeometryExample c = new GeometryExample();
            c.Process(radius, height);
            c.Result();
        }
    }
}