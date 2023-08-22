using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap
{
    using System;
    using System.Collections.Generic;

    // lớp QuanLyHoaDon
    class QuanLyHoaDon
    {
        // thuộc tính là một danh sách các đối tượng KhachHang
        private List<KhachHang> danhSach;

        // phương thức khởi tạo
        public QuanLyHoaDon()
        {
            danhSach = new List<KhachHang>();
        }

        // phương thức thêm hoá đơn vào danh sách
        public void themHoaDon(KhachHang kh)
        {
            danhSach.Add(kh);
        }

        // phương thức xóa hoá đơn khỏi danh sách theo mã khách hàng
        public void xoaHoaDon(string maKH)
        {
            for (int i = 0; i < danhSach.Count; i++)
            {
                if (danhSach[i].maKH == maKH)
                {
                    danhSach.RemoveAt(i);
                    break;
                }
            }
        }

        // phương thức tìm hoá đơn trong danh sách theo mã khách hàng
        public KhachHang timHoaDon(string maKH)
        {
            foreach (KhachHang kh in danhSach)
            {
                if (kh.maKH == maKH)
                {
                    return kh;
                }
            }
            return null;
        }

        // phương thức hiển thị toàn bộ hoá đơn trong danh sách
        public void hienThiHoaDon()
        {
            foreach (KhachHang kh in danhSach)
            {
                kh.HienThi();
                Console.WriteLine("--------------------");
            }
        }
    }
}