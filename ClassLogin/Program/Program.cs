class Program {

     static UserMenu userMenu;

    static void Main(string[] args)
    {

            PreMainMenu();
            ShowMainMenuScreen();
        }

        static void PreMainMenu() {
            Program.userMenu = new UserMenu();
        }

        static void ShowMainMenuScreen() {
            Program.userMenu.ShowMainMenuScreen();
        }
}