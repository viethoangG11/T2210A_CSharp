using System;
namespace T2210A_CSharp.demo4
{
    public delegate void ActionDelegate(string msg);
    public class Button
    {
        public event ActionDelegate Click;

        public Button(ActionDelegate onAction)
        {
            Click += onAction;
        }
    }
}