
// Lớp HocVien (Student) kế thừa từ NguoiDung
public class HocVien : NguoiDung
{
    // Thuộc tính riêng
    public int CapLop { get; set; }
    public List<string> CacKhoaHocDaDangKy { get; set; }

    // Constructor
    public HocVien(string tenDangNhap, string matKhau, string email, string hoTen, int capLop)
        : base(tenDangNhap, matKhau, email, hoTen)
    {
        CapLop = capLop;
        CacKhoaHocDaDangKy = new List<string>();
    }

    // Phương thức riêng
    public void DangKyKhoaHoc(string khoaHoc)
    {
        CacKhoaHocDaDangKy.Add(khoaHoc);
        Console.WriteLine($"{HoTen} đã đăng ký khóa học {khoaHoc}.");
    }

    public void NopBai(string baiTap) => Console.WriteLine($"{HoTen} đã nộp bài tập {baiTap}.");
    public void XemDiem() => Console.WriteLine($"{HoTen} đang xem điểm.");
}



