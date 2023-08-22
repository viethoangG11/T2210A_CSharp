
using System;
using System.Collections.Generic;
using System.Linq;

abstract class Phone
{
    public abstract void InsertPhone(string name, string phone);
    public abstract void RemovePhone(string name);
    public abstract void UpdatePhone(string name, string newphone);
    public abstract void SearchPhone(string name);
    public abstract void Sort();
}
class PhoneBook : Phone
{
    private List<(string name, string phone)> PhoneList;

    public PhoneBook()
    {
        PhoneList = new List<(string name, string phone)>();
    }
    public override void InsertPhone(string name, string phone)
    {
        var index = PhoneList.FindIndex(x => x.name == name);
        if (index == -1)
        {
            PhoneList.Add((name, phone));
            Console.WriteLine("Thêm thành công!");
        }
        else
        {
            var phones = PhoneList[index].phone.Split(",");
            if (!phones.Contains(phone))
            {
                PhoneList[index] = (name, PhoneList[index].phone + "," + phone);
                Console.WriteLine("Thêm thành công!");
            }
            else
            {
                Console.WriteLine("Số điện thoại đã tồn tại!");
            }
        }
    }
    public override void RemovePhone(string name)
    {
        var index = PhoneList.FindIndex(x => x.name == name);
        if (index == -1)
        {
            Console.WriteLine("Không tìm thấy người dùng!");
        }
        else
        {
            PhoneList.RemoveAt(index);
            Console.WriteLine("Xóa thành công!");
        }
    }
    public override void UpdatePhone(string name, string newphone)
    {
        var index = PhoneList.FindIndex(x => x.name == name);
        if (index == -1)
        {
            Console.WriteLine("Không tìm thấy người dùng!");
        }
        else
        {
            PhoneList[index] = (name, newphone);
            Console.WriteLine("Cập nhật thành công!");
        }
    }
    public override void SearchPhone(string name)
    {
        var index = PhoneList.FindIndex(x => x.name == name);
        if (index == -1)
        {
            Console.WriteLine("Không tìm thấy người dùng!");
        }
        else
        {
            Console.WriteLine("Tên: {0}", PhoneList[index].name);
            Console.WriteLine("Số điện thoại: {0}", PhoneList[index].phone);
        }
    }
    public override void Sort()
    {
        PhoneList.Sort((x, y) => x.name.CompareTo(y.name));
        Console.WriteLine("Sắp xếp thành công!");
    }
}
