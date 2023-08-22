using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap
{
    class Test
    {
        static void Main7(string[] args)
        {
            // tạo một đối tượng QuanLyHoaDon
            QuanLyHoaDon qlhd = new QuanLyHoaDon();

            // tạo một số đối tượng KhachHangVietNam và KhachHangNuocNgoai và thêm vào qlhd
            KhachHangVN khvn1 = new KhachHangVN("VN03", "Pham Van C", new DateTime(2021, 10, 5), 80, 1000, "sinh hoat", 50);
            KhachHangVN khvn2 = new KhachHangVN("VN04", "Le Thi D", new DateTime(2021, 10, 6), 120, 1000, "kinh doanh", 100);
            KhachHangNuocNgoai khnn1 = new KhachHangNuocNgoai("NN03", "David Jones", new DateTime(2021, 10, 7), 250, 2000, "UK");
            KhachHangNuocNgoai khnn2 = new KhachHangNuocNgoai("NN04", "Kim Soo Hyun", new DateTime(2021, 10, 8), 350, 2000, "Korea");

            qlhd.themHoaDon(khvn1);
            qlhd.themHoaDon(khvn2);
            qlhd.themHoaDon(khnn1);
            qlhd.themHoaDon(khnn2);

            // hiển thị toàn bộ hoá đơn trong qlhd
            qlhd.hienThiHoaDon();

            // tìm một hoá đơn theo mã khách hàng
            KhachHang kh = qlhd.timHoaDon("NN03");
            if (kh != null)
            {
                Console.WriteLine("Tim thay hoa don:");
                kh.HienThi();
            }
            else
            {
                Console.WriteLine("Khong tim thay hoa don");
            }
        }
    }
}
