namespace Task5;

public class BigDog : Dog
{
    public BigDog(string name):base(name) {}
    public void Greets()
    {
        System.Console.WriteLine($"{Name} Wooooooow");
    }
    public override void Greets2()
    {
        System.Console.WriteLine($"{Name} Woooooooow");
    }

}
