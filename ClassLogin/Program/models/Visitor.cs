using System.Collections.Generic;
using System;

class Visitor: User {
   public Visitor(string FristName,
    string LastName,
    string PhoneNumber,
    string Citizen_ID,
    string Email,
    string UserName,
    string Password)
     :base(FristName, LastName, PhoneNumber, Citizen_ID, Email, UserName, Password){
     }

}
