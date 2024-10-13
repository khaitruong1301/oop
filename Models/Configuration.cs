using System;
public class Configuration
{
    // Static field để lưu cấu hình của ứng dụng
    public static string AppName;
    public static string Version;
    public static string ApiUrl;
    // Static constructor: Tự động gọi một lần khi lần đầu tiên truy cập thành viên static
    static Configuration()
    {
        // Các giá trị cấu hình sẽ được khởi tạo một lần
        AppName = "Banking System";
        Version = "2.1.0";
        ApiUrl = "https://api.bankingsystem.com";
        Console.WriteLine("Static constructor called: Configuration initialized.");
    }
    // Static method để hiển thị cấu hình hiện tại
    public static void DisplayConfiguration()
    {
        Console.WriteLine($"Application Name: {AppName}");
        Console.WriteLine($"Version: {Version}");
        Console.WriteLine($"API URL: {ApiUrl}");
    }
}