class User
{
    public string UserName ;
    public string Password ;
    public string FullName ;

    // Constructor mặc định
    public User()
    {
        UserName = "username default";
        Password = "password default";
        FullName = "fullname default";
    }
    //Parameterized Constructor (Phương thức khởi tạo có tham số)

    public User(string usName,string pass, string fName){
        UserName = usName;
        Password = pass;
        FullName = fName;
    }
    

}
