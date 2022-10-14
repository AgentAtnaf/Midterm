using System.Collections.Generic;
using System;

public class Emaillist
{
    private List<Email>emaillist;

    public Emaillist()
    {
        this.emaillist = new List<Email>();
    }
    public void AddNewEmail(Email emails)
    {
        this.emaillist.Add(emails);
    } 
    public string checkmail(string email)
    {
        string ticket = "passed";
        string Emails = email;
        foreach (Email emails in this.emaillist) 
        {
            if (Emails == emails.GetEmail()) 
            {
                return ticket = "Alreadytanken";
            }
            if (Emails == "exit")
            {
                return ticket = "e";
            }
        }
        return ticket;
    }
    public string login(string email,string password)
    {
        string key = "e";
        string emaillogin = email;
        string passwordlogin = password;
        foreach (Email emails in this.emaillist)
        {
            if( emaillogin == emails.GetEmail() && passwordlogin == emails.Getpassword())
            {
                return key = "Passed";
            }
            if( emaillogin == "exit"|| passwordlogin == "exit")
            {
                return key = "e";
            }
        }
        return key;
    }
}