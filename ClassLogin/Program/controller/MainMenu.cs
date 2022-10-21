class MainMenu
{
    private User user;
    private List<User> users;

    public void Prayut(User user) {
        SetupUser(user);
        Prayut2();
    }
    public void Prayut2 ()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||         LOGIN SUCCESSFUL!!!       ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine($"UserName: {user.GetUserName}");
        Console.WriteLine("=======================================");
    }
        private void SetupUser(User user) {
        this.user = (User)user;
    }       
}
