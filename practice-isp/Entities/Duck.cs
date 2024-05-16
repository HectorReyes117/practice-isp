using practice_isp.Interfaces;

namespace practice_isp.Entities;

public class Duck : IBird, IBirdSwim
{
    public void Fly()
    {
        Console.WriteLine("Flying");
    }

    public void Sing()
    {
        Console.WriteLine("Singing");
    }

    public void LayEggs()
    {
        Console.WriteLine("Laying Eggs");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming");
    }
}