using System.Collections.Generic;
using System;

class Login{

    public void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
    }

    public bool InputLoginFromKeyboard(List<User> listUsers) {
        string UserName = InputUserNameFromKeyboard();
        string Password = InputPasswordFromKeyboard();

        foreach (User user in listUsers) {
            Console.WriteLine(user.GetUserName);
            if (user.GetUserName == UserName && user.GetPassword == Password) {
                ShowMenu(user);
                return true;
            }
            else{
                return false;
            }

        }
        return false;
    }

    private void ShowMenu(User user) {
        MainMenu controller = new MainMenu();
        controller.Prayut(user);
    }


    public string InputUserNameFromKeyboard() {
        Console.Write("Input UserName: ");

        return Console.ReadLine();
    }

    public string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("");
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||           Login Screen            ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
    }

}