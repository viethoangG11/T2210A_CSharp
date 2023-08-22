using System;
using System.Collections.Generic;

// lớp trừu tượng KhachHang
abstract class KhachHang
{
    // các thuộc tính chung
    public string maKH;
    protected string hoTen;
    protected DateTime ngayRaHoaDon;
    protected int soLuong;
    protected int donGia;

    // phương thức khởi tạo
    public KhachHang(string maKH, string hoTen, DateTime ngayRaHoaDon, int soLuong, int donGia)
    {
        this.maKH = maKH;
        this.hoTen = hoTen;
        this.ngayRaHoaDon = ngayRaHoaDon;
        this.soLuong = soLuong;
        this.donGia = donGia;
    }

    // phương thức trừu tượng tính thành tiền
    public abstract int TinhThanhTien();

    // phương thức hiển thị thông tin khách hàng
    public virtual void HienThi()
    {
        Console.WriteLine("Ma KH: " + maKH);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Ngay ra hoa don: " + ngayRaHoaDon.ToString("dd/MM/yyyy"));
        Console.WriteLine("So luong: " + soLuong);
        Console.WriteLine("Don gia: " + donGia);
    }
}
