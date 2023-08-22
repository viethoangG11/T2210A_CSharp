using System;
namespace T2210A_CSharp.demo4
{
    public delegate void UpdateQtyHandler(int n);
    public class Product
    {
        private int qty;

        public event UpdateQtyHandler QtyChanged;

        public Product()
        {
            QtyChanged += NotifyChangeQty;
            QtyChanged += SendEmailToAdmin;
            QtyChanged += SendSMSToStoreManager;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public void NotifyChangeQty(int n)
        {
            Console.WriteLine("Qty of product was changed:" + n);
        }

        public void SendEmailToAdmin(int n)
        {
            // send email
        }

        public void SendSMSToStoreManager(int n)
        {
            // send SMS
        }

        public void IncrementQty(int q)
        {
            if (q > 0)
            {
                qty += q;
                QtyChanged(q);
            }
        }
    }
}