public class BankAccount
{
    // Static field để lưu tổng số tài khoản đã được tạo
    public static int AccountCounter { get; private set; } = 0;

    // Số tài khoản ngân hàng, được tạo tự động và duy nhất
    public string AccountNumber { get; }

    // Số dư của tài khoản có thể đọc từ bên ngoài, nhưng chỉ thay đổi từ bên trong
    public decimal Balance { get; private set; }

    // Tên khách hàng có thể đọc và thay đổi từ bên ngoài
    public string CustomerName { get; set; }

    // Mã PIN chỉ có thể thay đổi từ bên ngoài nhưng không thể đọc (bảo mật)
    public string PIN { private get; set; }

    // Constructor
    public BankAccount(string customerName, string pin, decimal initialDeposit)
    {
        CustomerName = customerName;
        AccountNumber = GenerateAccountNumber();  // Sinh số tài khoản tự động
        PIN = pin;
        Balance = initialDeposit;
        AccountCounter++;  // Tăng số tài khoản đã tạo
    }
    // Phương thức sinh số tài khoản ngẫu nhiên, đảm bảo duy nhất
    private string GenerateAccountNumber()
    {
        Random random = new Random();
        string accountNumber = string.Empty;
        // Sinh số tài khoản gồm 10 chữ số ngẫu nhiên
        for (int i = 0; i < 10; i++)
        {
            accountNumber += random.Next(0, 10);
        }
        return accountNumber;
    }
    // Phương thức gửi tiền
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful! New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Phương thức rút tiền, yêu cầu mã PIN
    public bool Withdraw(decimal amount, string pin)
    {
        if (PIN != pin)
        {
            Console.WriteLine("Invalid PIN. Withdrawal failed.");
            return false;
        }
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: {Balance}");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            return false;
        }
    }

    // Phương thức hiển thị thông tin tài khoản
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Customer Name: {CustomerName}, Balance: {Balance}");
    }
}
