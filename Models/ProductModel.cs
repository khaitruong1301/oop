public class ProductModel { //lớp đối tượng 
     string? id;
     string? name;
     double price;
    public void InputProductInfo () {
        Console.Write("Nhập id: ");
        this.id = Console.ReadLine();
        Console.Write("Nhập name: ");
        this.name = Console.ReadLine();
        Console.Write("Nhập price: ");
        this.price = Convert.ToDouble(Console.ReadLine());
    }
    public void DisplayInfo () {
        Console.WriteLine($"Thông tin sản phẩm \nMã sản phẩm:{id} \nTên sản phẩm: {name}\nGía: {price}");
    }
}

