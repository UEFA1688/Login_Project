using System.Collections.Generic;
using System;

class Student: User {
    private string Student_ID;
   public Student(string FristName,
    string LastName,
    string PhoneNumber,
    string Citizen_ID,
    string Student_ID,
    string Email,
    string UserName,
    string Password)
     :base(FristName, LastName, PhoneNumber, Citizen_ID, Email, UserName, Password){
         this.Student_ID = GetStudent_ID= Student_ID;
         this.UserName  = UserName;
         this.Password  = Password;
     }


     public string GetStudent_ID {get;}

}
