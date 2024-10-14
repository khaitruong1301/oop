class User
{
    string UserName;
    string Password;
    string FullName;
    public User()
    {
        UserName = "username default";
        Password = "password default";
        FullName = "fullname default";
    }
    public void DisplayInfo(){
        Console.WriteLine(@$"
            Username: {UserName}
            Password: {Password}
            FullName: {FullName}
        ");
    }
}









