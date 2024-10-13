// // Lớp QuanTriVien (Admin) kế thừa từ NguoiDung
// public class QuanTriVien : NguoiDung
// {
//     // Thuộc tính riêng
//     public string MucDoQuanTri { get; set; }

//     // Constructor
//     public QuanTriVien(string tenDangNhap, string matKhau, string email, string hoTen, string mucDoQuanTri)
//         : base(tenDangNhap, matKhau, email, hoTen)
//     {
//         MucDoQuanTri = mucDoQuanTri;
//     }

//     // Phương thức riêng
//     public void QuanLyNguoiDung() => Console.WriteLine($"{HoTen} đang quản lý người dùng.");
//     public void PheDuyetKhoaHoc(string khoaHoc) => Console.WriteLine($"{HoTen} đã phê duyệt khóa học {khoaHoc}.");
//     public void QuanLyHeThong() => Console.WriteLine($"{HoTen} đang quản lý hệ thống.");


// }




// Lớp QuanTriVien (Admin) kế thừa từ NguoiDung
public class QuanTriVien : NguoiDung
{
    // Thuộc tính protected riêng của Quản trị viên
    protected string MucDoQuanTri { get; set; }

    // Constructor
    public QuanTriVien(string tenDangNhap, string matKhau, string email, string hoTen, string mucDoQuanTri)
        : base(tenDangNhap, matKhau, email, hoTen)
    {
        MucDoQuanTri = mucDoQuanTri;
    }

    // Ghi đè phương thức CapNhatThongTinCaNhan() cho quản trị viên
    public override void CapNhatThongTinCaNhan()
    {
        Console.WriteLine($"Quản trị viên {HoTen} (cấp độ: {MucDoQuanTri}) đã cập nhật thông tin quản trị.");
    }

    // Phương thức riêng của Quản trị viên
    public void QuanLyHeThong()
    {
        Console.WriteLine($"Quản trị viên {HoTen} đang quản lý hệ thống.");
    }
}


