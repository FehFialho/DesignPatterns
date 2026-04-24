public class MacFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Created Mac Button");
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("Created Mac CheckBox");
        return new MacCheckBox();
    }
}