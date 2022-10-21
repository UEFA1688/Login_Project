using System;
using System.Collections.Generic;



class UserMenu {

    private Register register;

    private Login login;
    private List<User> users;

    public void ShowMainMenuScreen() {
        PrepareListUsersWhenMainScreenIsLoaded();
        Console.Clear();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }

    private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.users = new List<User>();
    }

    public AuthenMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");

        return (AuthenMenu)(int.Parse)(Console.ReadLine());        
    }

    private void RouteToMenu(AuthenMenu menu) {

        if (menu == AuthenMenu.Register) {
            ShowRegisterScreen();
             this.users.Add(this.register.InputNewUserFromKeyboard());
            Console.Clear();
            ShowMenuScreenInformation();
        }


        else if (menu == AuthenMenu.Login) {
            ShowLoginScreen();
            bool status = this.login.InputLoginFromKeyboard(this.users);
            Console.Clear();
            ShowMenuScreenWhenAuthenInCorrect(status);
        }  
      ShowMainMenuScreen();
    }
    

    private void ShowMenuScreenWhenAuthenInCorrect(bool authenStatus) {
        if (!authenStatus) {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("===========================================================");
        Console.WriteLine("||                                                       ||");
        Console.WriteLine("||     Incorrect email or password. Please try again.    ||");
        Console.WriteLine("||                                                       ||");
        Console.WriteLine("===========================================================");
        Console.WriteLine("--------------------------");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

            ShowMenuScreenInformation();
        }
    }

    private void ShowRegisterScreen() {
        this.register = new Register();
        this.register.ShowRegisterScreen();
    }

    private void ShowLoginScreen() {
        this.login = new Login();
        this.login.ShowLoginScreen();
    }

    private void PrintHeaderMenuScreen() {
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("1. Register User");
        Console.WriteLine("2. Login");

    }

}