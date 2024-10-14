// namespace OOP_Basic.Models;
public class NhanVien{
    private string? maNhanVien;
    string? hoTen; 
    double soGioLam;
    double luong1h;

    


    public void NhapThongTin(){
        Console.Write("Nhập vào mã nhân viên: ");
        maNhanVien = Console.ReadLine();
        Console.Write("Nhập vào họ tên: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhập vào số giờ làm:");
        soGioLam =Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập lương 1h:");
        luong1h = Convert.ToDouble(Console.ReadLine());
    }
    
    public void XuatThongTin(){
        Console.Write($"Mã nhân viên: {maNhanVien} ");
        Console.Write($"Tên nhân viên: {hoTen} ");
        Console.Write($"Số giờ làm: {soGioLam} ");
        Console.Write($"Lương 1 giờ: {luong1h} ");
        Console.Write($"Lương nhân viên: {TinhLuong()} ");
    }
    private double TinhLuong() {
        double output = 0;
        output = soGioLam * luong1h;
        return output;
    }

}