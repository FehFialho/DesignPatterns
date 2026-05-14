using System.Runtime.ExceptionServices;

public class Robot (string name)
{
    public string Name { get; set; } = name;
    private IStrategy Strategy { get; set; }

    public void SetStrategy(IStrategy strategy)
    {
        this.Strategy = strategy;
    }


    private int getSize(int num)
    {
        int m = num;
        int q =0;
        while(m >= 1)
        {
            m/=10;
            q++;
        }
        return q;
    }
    public void Act(int i, int max)
    {


        if (Strategy == null)
            SetStrategy(new Default());

        Console.Write($"[ {Name} - ");
        
        int sM = getSize(max);
        int sC = getSize(i);
        for(int j=0; j<sM-sC; j++)
            Console.Write("0");
        Console.Write(i);

        Console.WriteLine($" ] - {Strategy.Message}");

        Strategy.Execute(this);
    }
}