public class Email
{
    private string email;
    private string password;
    public Email(string email,string password)
    {
        this.email = email;
        this.password = password;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string Getpassword()
    {
        return this.password;
    }
}