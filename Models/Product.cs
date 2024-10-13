public class Product
{
    // Các thuộc tính
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    // Phương thức để nhập thông tin sản phẩm
    public void InputValue()
    {
        Console.Write("Input id:");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Name:");
        Name = Console.ReadLine();
        Console.Write("Input Price:");
        Price = Convert.ToInt32(Console.ReadLine());
    }
    // Phương thức để hiển thị thông tin sản phẩm
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price}");
    }
}


