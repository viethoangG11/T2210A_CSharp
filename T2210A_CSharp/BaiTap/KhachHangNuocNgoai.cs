using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap
{
    class KhachHangNuocNgoai : KhachHang
    {
        // thuộc tính riêng
        private string quocTich;

        // phương thức khởi tạo
        public KhachHangNuocNgoai(string maKH, string hoTen, DateTime ngayRaHoaDon, int soLuong, int donGia, string quocTich) : base(maKH, hoTen, ngayRaHoaDon, soLuong, donGia)
        {
            this.quocTich = quocTich;
        }

        // ghi đè phương thức tính thành tiền theo công thức cho trước
        public override int TinhThanhTien()
        {
            return soLuong * donGia;
        }

        // ghi đè phương thức hiển thị thông tin khách hàng
        public override void HienThi()
        {
            base.HienThi(); // gọi phương thức của lớp cha
            Console.WriteLine("Quoc tich: " + quocTich);
            Console.WriteLine("Thanh tien: " + TinhThanhTien());
        }
    }
}