public class WindowsFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Created Windows Button");
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("Created Windows CheckBox");
        return new WindowsCheckBox();
    }
}