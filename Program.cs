// Tạo Giảng viên
GiangVien giangVien = new GiangVien("giangvien123", "123456", "gv@example.com", "Nguyen Van A", "CNTT", 10);
giangVien.DangNhap();
giangVien.TaoKhoaHoc("Lập trình C#");
giangVien.ChamBai("HocVien1", "BaiTap1");
giangVien.DangXuat();

Console.WriteLine();

// Tạo Học viên
HocVien hocVien = new HocVien("hocvien123", "654321", "hv@example.com", "Le Thi B", 3);
hocVien.DangNhap();
hocVien.DangKyKhoaHoc("Lập trình C#");
hocVien.NopBai("BaiTap1");
hocVien.XemDiem();
hocVien.DangXuat();

Console.WriteLine();

// Tạo Quản trị viên
QuanTriVien admin = new QuanTriVien("admin123", "adminpass", "admin@example.com", "Tran Van C", "Super Admin");
admin.DangNhap();
admin.QuanLyNguoiDung();
admin.PheDuyetKhoaHoc("Lập trình C#");
admin.QuanLyHeThong();
admin.DangXuat();