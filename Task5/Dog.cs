namespace Task5;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }
        public void Greets()
    {
        System.Console.WriteLine($"{Name} Woof");
    }
    public virtual void Greets2()
    {
        System.Console.WriteLine("");
    }
}
