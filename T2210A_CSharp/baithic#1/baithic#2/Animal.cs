using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.baithic_1.baithic_2
{
    internal class Animal
    {
        protected int weight;
        protected string name;

        public void Show()
        {
            Console.WriteLine("Name: {0}, Weight: {1}", name, weight);
        }

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }

    class Lion : Animal
    {
        public Lion(int weight, string name)
        {
            SetMe(weight, name);
        }
    }

    class Tiger : Animal
    {
        public Tiger(int weight, string name)
        {
            SetMe(weight, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             Tiger t = new Tiger(100, "Tiger");
             Lion l = new Lion(200, "Lion");

            t.Show();
            l.Show();
        }
    }
}