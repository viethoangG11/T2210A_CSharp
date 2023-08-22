using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.BaiTap3
{

    class SinhVien
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string gioiTinh { get; set; }
        public int tuoi { get; set; }
        public double diemToan { get; set; }
        public double diemLy { get; set; }
        public double diemHoa { get; set; }

        public double tinhDiemTrungBinh()
        {
            return (diemToan + diemLy + diemHoa) / 3;
        }

        public string xacDinhHocLuc()
        {
            double diemTrungBinh = tinhDiemTrungBinh();
            if (diemTrungBinh >= 8)
            {
                return "Giỏi";
            }
            else if (diemTrungBinh >= 6.5)
            {
                return "Khá";
            }
            else if (diemTrungBinh >= 5)
            {
                return "Trung Bình";
            }
            else
            {
                return "Yếu";
            }
        }
        public void hienThiThongTin()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Tên: " + ten);
            Console.WriteLine("Giới tính: " + gioiTinh);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Điểm toán: " + diemToan);
            Console.WriteLine("Điểm lý: " + diemLy);
            Console.WriteLine("Điểm hóa: " + diemHoa);
            Console.WriteLine("Điểm trung bình: " + tinhDiemTrungBinh());
            Console.WriteLine("Học lực: " + xacDinhHocLuc());
        }
    }
}