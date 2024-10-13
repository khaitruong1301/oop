// // Lớp cơ sở NguoiDung (User)
// public class NguoiDung
// {
//     // Thuộc tính chung
//     public string TenDangNhap { get; set; }
//     public string MatKhau { get; set; }
//     public string Email { get; set; }
//     public string HoTen { get; set; }

//     // Constructor
//     public NguoiDung(string tenDangNhap, string matKhau, string email, string hoTen)
//     {
//         TenDangNhap = tenDangNhap;
//         MatKhau = matKhau;
//         Email = email;
//         HoTen = hoTen;
//     }

//     // Phương thức chung
//     public void DangNhap() => Console.WriteLine($"{HoTen} đã đăng nhập.");
//     public void DangXuat() => Console.WriteLine($"{HoTen} đã đăng xuất.");
//     public void CapNhatThongTinCaNhan() => Console.WriteLine($"{HoTen} đã cập nhật thông tin cá nhân.");
// }








using System;

// Lớp cơ sở NguoiDung (User)
public class NguoiDung
{
    // Thuộc tính protected có thể truy cập bởi lớp con
    protected string TenDangNhap { get; set; }
    protected string MatKhau { get; set; }
    protected string Email { get; set; }
    // Thuộc tính public để thể hiện tên đầy đủ
    public string HoTen { get; set; }
    // Constructor
    public NguoiDung(string tenDangNhap, string matKhau, string email, string hoTen)
    {
        TenDangNhap = tenDangNhap;
        MatKhau = matKhau;
        Email = email;
        HoTen = hoTen;
    }
    // Phương thức chung, có thể bị ghi đè
    public virtual void CapNhatThongTinCaNhan()
    {
        Console.WriteLine($"{HoTen} đã cập nhật thông tin cá nhân.");
    }
    // Phương thức chung để đăng nhập và đăng xuất
    public void DangNhap() => Console.WriteLine($"{HoTen} đã đăng nhập.");
    public void DangXuat() => Console.WriteLine($"{HoTen} đã đăng xuất.");
}













