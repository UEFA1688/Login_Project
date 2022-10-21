using System;
public class User{
    protected string FristName;
    protected string LastName;
    protected string PhoneNumber;
    protected string Email;
    protected string Citizen_ID ;
    protected string UserName ;
    protected string Password ;


    public User (string FristName,
    string LastName,
    string PhoneNumber,
    string Citizen_ID,
    string Email,
    string UserName,
    string Password){
        this.FristName = GetFristName = FristName;
        this.LastName = GetLastName = LastName;
        this.PhoneNumber = GetPhoneNumber = PhoneNumber;
        this.Email = GetEmail = Email;
        this.Citizen_ID = GetCitizen_ID = Citizen_ID;
        this.UserName = GetUserName = UserName;
        this.Password = GetPassword = Password;
    }
    public string GetFristName {get;}
    public string GetLastName {get;}
    public string GetPhoneNumber {get;}
    public string GetEmail {get;}
    public string GetCitizen_ID {get;}
    public string GetUserName {get;}
    public string GetPassword {get;}
}