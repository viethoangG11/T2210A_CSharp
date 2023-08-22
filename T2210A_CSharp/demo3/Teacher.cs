using System;
namespace T2210A_CSharp.demo3
{
    public class Teacher : AbstractTeacher
    {
        private List<string> tels;
        private string name;

        public Teacher()
        {
            tels = new List<string>();
        }

        public Teacher(string name)
        {
            this.name = name;
        }

        public List<string> Tels
        {
            get => tels;
            set => tels = value;
        }

        // indexer
        public string this[int index]
        {
            get => Tels[index];
            set => Tels[index] = value;
        }

        public virtual void Teach()
        {
            Console.WriteLine("Teach....");
        }

        public void Lunch()
        {

        }

        public override void Run()
        {

        }
    }
}