public class LinuxFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Created Linux Button");
        return new LinuxButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("Created Linux CheckBox");
        return new LinuxCheckBox();
    }
}