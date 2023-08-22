using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap3
{
    class QuanLy
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public void themSinhVien()
        {
            SinhVien sv = new SinhVien();

            Console.WriteLine("Nhập ID của sinh viên: ");
            sv.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên của sinh viên: ");
            sv.ten = Console.ReadLine();
            Console.WriteLine("Nhập giới tính của sinh viên (Nam/Nữ): ");
            sv.gioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập tuổi của sinh viên: ");
            sv.tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm toán của sinh viên: ");
            sv.diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm lý của sinh viên: ");
            sv.diemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm hóa của sinh viên: ");
            sv.diemHoa = double.Parse(Console.ReadLine());

            danhSachSinhVien.Add(sv);

            Console.WriteLine("Đã thêm sinh viên thành công!");
        }

        public void capNhatSinhVien()
        {
            Console.WriteLine("Nhập ID của sinh viên cần cập nhật: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sv = danhSachSinhVien.Find(x => x.id == id);

            if (sv == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID này!");
                return;
            }
            Console.WriteLine("Nhập tên mới của sinh viên: ");
            sv.ten = Console.ReadLine();
            Console.WriteLine("Nhập giới tính mới của sinh viên (Nam/Nữ): ");
            sv.gioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập tuổi mới của sinh viên: ");
            sv.tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm toán mới của sinh viên: ");
            sv.diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm lý mới của sinh viên: ");
            sv.diemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm hóa mới của sinh viên: ");
            sv.diemHoa = double.Parse(Console.ReadLine());

            Console.WriteLine("Đã cập nhật thông tin sinh viên thành công!");
        }
        public void xoaSinhVien()
        {
            Console.WriteLine("Nhập ID của sinh viên cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sv = danhSachSinhVien.Find(x => x.id == id);

            Console.WriteLine("Không tìm thấy sinh viên có ID này!");

            if (sv != null)
            {
                danhSachSinhVien.Remove(sv);

                Console.WriteLine("Đã xóa sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID này!");
            }
        }
        public void timKiemSinhVien()
        {
            Console.WriteLine("Nhập tên của sinh viên cần tìm kiếm: ");
            string ten = Console.ReadLine();

            List<SinhVien> ketQua = danhSachSinhVien.FindAll(x => x.ten.Contains(ten));

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không có kết quả nào phù hợp!");
                return;
            }

            Console.WriteLine("Có {0} kết quả phù hợp:", ketQua.Count);
            foreach (SinhVien sv in ketQua)
            {
                sv.hienThiThongTin();
                Console.WriteLine("--------------------");
            }
        }
        public void sapXepTheoDiemTrungBinh()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(x => x.tinhDiemTrungBinh()).ToList();

            Console.WriteLine("Đã sắp xếp sinh viên theo điểm trung bình từ thấp đến cao!");
        }

        public void sapXepTheoTen()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(x => x.ten).ToList();

            Console.WriteLine("Đã sắp xếp sinh viên theo tên từ A đến Z!");
        }
        public void sapXepTheoID()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(x => x.id).ToList();

            Console.WriteLine("Đã sắp xếp sinh viên theo ID từ nhỏ đến lớn!");
        }
        public void hienThiDanhSach()
        {
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu nào!");
                return;
            }
            Console.WriteLine("Danh sách sinh viên:");
            foreach (SinhVien sv in danhSachSinhVien)
            {
                sv.hienThiThongTin();
                Console.WriteLine("--------------------");
            }
        }
    }
}
