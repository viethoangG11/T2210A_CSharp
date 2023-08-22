using System;
namespace T2210A_CSharp.demo5
{
    public class DemoNumber
    {
        public int X { get; set; }// abstract property
        public int Y { get; set; }

        public void ChangeData()
        {
            X++;
            Y++;
        }

        public void PrintData()
        {
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
        }
    }
}