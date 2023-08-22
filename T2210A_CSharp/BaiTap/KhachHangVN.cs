using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap
{
    class KhachHangVN : KhachHang
    {
        private string doiTuongKH;
        private int dinhMuc;

        // phương thức khởi tạo
        public KhachHangVN(string maKH, string hoTen, DateTime ngayRaHoaDon, int soLuong, int donGia, string doiTuongKH, int dinhMuc) : base(maKH, hoTen, ngayRaHoaDon, soLuong, donGia)
        {
            this.doiTuongKH = doiTuongKH;
            this.dinhMuc = dinhMuc;
        }

        // ghi đè phương thức tính thành tiền theo công thức cho trước
        public override int TinhThanhTien()
        {
            if (soLuong <= dinhMuc)
            {
                return soLuong * donGia;
            }
            else
            {
                // tính đơn giá mới theo bảng giá cho trước
                int donGiaMoi = 0;
                if (soLuong <= 50)
                {
                    donGiaMoi = 1000;
                }
                else if (soLuong <= 100)
                {
                    donGiaMoi = 1200;
                }
                else if (soLuong <= 200)
                {
                    donGiaMoi = 1500;
                }
                else
                {
                    donGiaMoi = 2000;
                }
                return donGia * dinhMuc + (soLuong - dinhMuc) * donGiaMoi;
            }
        }

        // ghi đè phương thức hiển thị thông tin khách hàng
        public override void HienThi()
        {
            base.HienThi(); // gọi phương thức của lớp cha
            Console.WriteLine("Doi tuong KH: " + doiTuongKH);
            Console.WriteLine("Dinh muc: " + dinhMuc);
            Console.WriteLine("Thanh tien: " + TinhThanhTien());
        }
    }
}