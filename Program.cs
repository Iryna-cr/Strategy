using System;

class Discount
{
    public Func<double, double> strategy;

    public void SetStrategy(Func<double, double> s) => strategy = s;
    public void Apply(double price)
    {
        Console.WriteLine("Ціна після знижки: " + strategy(price) + " грн");
    }
}

class Program
{
    static void Main()
    {
        var d = new Discount();

        d.SetStrategy(p => p * 0.9); // 10% знижка
        d.Apply(100);

        d.SetStrategy(p => p * 0.8); // 20% знижка
        d.Apply(100);
    }
}













