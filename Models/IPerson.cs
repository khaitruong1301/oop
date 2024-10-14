public interface IHinh
{
    double tinhChuVi();
    double tinhDienTich();
}

public interface IMoTa {

    void MoTa();
}

public class HinhTron : IHinh,IMoTa
{
    public double banKinh {get;set;}

    public void MoTa()
    {
        Console.WriteLine($@"
            Hình tròn là hình có bán kính bằng nửa đường kính.
            Bán kính hình tròn này là ${banKinh}
        ");
    }

    public double tinhChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    public double tinhDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }
}


public class HinhChuNhat : IHinh,IMoTa
{
    public double chieuDai {get;set;}
    public double chieuRong {get;set;}

    public void MoTa()
    {
        Console.WriteLine($@"
            Hình chữ nhật là hình tứ giác có chiều dài lớn hơn chiều rộng
            Hình chữ nhật hiện có: Chiều dài: ${chieuDai} - Chiều rộng: {chieuRong}
        ");
    }

    public double tinhChuVi()
    {
        return (chieuDai + chieuRong) * 2;
    }

    public double tinhDienTich()
    {
        return chieuDai * chieuRong;
    }
}




