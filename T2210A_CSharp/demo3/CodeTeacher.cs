using System;
namespace T2210A_CSharp.demo3
{
    public class CodeTeacher : Teacher, ITeacher
    {
        private int age;
        public CodeTeacher()
        {
        }

        public CodeTeacher(string name, int age) : base(name)
        {
            this.age = age;
        }


        public override void Teach()
        {
            base.Lunch();
        }

        public new void Lunch()
        {

        }

        public void Eat()
        {

        }
    }
}