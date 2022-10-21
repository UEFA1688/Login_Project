using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Threading;
using System;

class Register{

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
    }


    public User InputNewUserFromKeyboard() {

        UserType userType = InputUserTypeFromKeyboard();
        string FristName = InputFristNameFromKeyboard();
        string LastName = InputLastNameFromKeyboard();
        string PhoneNumber = InputPhoneNumberFromKeyboard();
        string Citizen_ID = InputCitizen_IDFromKeyboard();
        string Email = InputEmailFromKeyboard();
        string UserName = InputUserNameFromKeyboard();
        string Password = InputPasswordFromKeyboard();


        if (userType == UserType.Student){ 
            string Student_ID = InputStudentIDFromKeyboard();
            return new Student(FristName, LastName, PhoneNumber, Citizen_ID, Student_ID, Email, UserName, Password);
        }

        else if (userType == UserType.Visitor){
            return new Visitor(FristName, LastName, PhoneNumber, Citizen_ID, Email, UserName, Password);
        }
        return new User (FristName, LastName, PhoneNumber, Citizen_ID, Email, UserName, Password);
    }

    private UserType InputUserTypeFromKeyboard() {
        Console.WriteLine("Input User Type 1 = Student:");
        Console.WriteLine("Input User Type 2 = Visitor: ");

        int typeNumber = int.Parse(Console.ReadLine());

        UserType userType = (UserType)(typeNumber);

        return userType;
    }




    private string InputFristNameFromKeyboard() {
        Console.Write("Input FristName: ");

        return Console.ReadLine();
    }

    private string InputLastNameFromKeyboard() {
        Console.Write("Input LastName: ");

        return Console.ReadLine();
    }
    private string InputPhoneNumberFromKeyboard() {
        Console.Write("Phone Number: ");

        return Console.ReadLine();
    }
    private string InputStudentIDFromKeyboard() {
        Console.Write("Student ID: ");

        return Console.ReadLine();
    }
    private string InputCitizen_IDFromKeyboard() {
        Console.Write("Citizen_ID: ");

        return Console.ReadLine();
    }

    private string InputEmailFromKeyboard() {
        Console.Write("Email : ");

        return Console.ReadLine();
    }
    private string InputUserNameFromKeyboard() {
        Console.Write("UserName : ");

        return Console.ReadLine();
    }
    private string InputPasswordFromKeyboard() {
        Console.Write("Password : ");

        return Console.ReadLine();
    }


    private void PrintHeaderRegisterScreen() {
        Console.WriteLine("Register for the event");
        Console.WriteLine("-------------------");
    }




}