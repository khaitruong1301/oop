// Lớp GiangVien (Instructor) kế thừa từ NguoiDung
public class GiangVien : NguoiDung
{
    // Thuộc tính riêng
    public string Khoa { get; set; }
    public int SoNamKinhNghiem { get; set; }
    public List<string> CacKhoaHocDaDay { get; set; }

    // Constructor
    public GiangVien(string tenDangNhap, string matKhau, string email, string hoTen, string khoa, int soNamKinhNghiem)
        : base(tenDangNhap, matKhau, email, hoTen)
    {
        Khoa = khoa;
        SoNamKinhNghiem = soNamKinhNghiem;
        CacKhoaHocDaDay = new List<string>();
    }

    // Phương thức riêng
    public void TaoKhoaHoc(string khoaHoc)
    {
        CacKhoaHocDaDay.Add(khoaHoc);
        Console.WriteLine($"Khóa học {khoaHoc} đã được tạo.");
    }

    public void ChamBai(string hocVien, string baiTap) => Console.WriteLine($"Giảng viên {HoTen} đã chấm bài {baiTap} của học viên {hocVien}.");
}