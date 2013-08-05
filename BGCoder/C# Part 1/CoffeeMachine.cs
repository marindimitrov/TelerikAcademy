using System;

class CoffeeMachine
{
    static void Main()
    {
        decimal n1 = decimal.Parse(Console.ReadLine());
        decimal n2 = decimal.Parse(Console.ReadLine());
        decimal n3 = decimal.Parse(Console.ReadLine());
        decimal n4 = decimal.Parse(Console.ReadLine());
        decimal n5 = decimal.Parse(Console.ReadLine());

        decimal a = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal moneyInMachine = 0;
        moneyInMachine = (n1 * 0.05m) + (n2 * 0.10m) + (n3 * 0.20m) + (n4 * 0.50m) + (n5 * 1.00m);

        decimal change = a - p;

        if (p > a)
        {
            Console.WriteLine("More {0}", p - a);
        }
        else if (moneyInMachine >= change && p <= a)
        {
            Console.WriteLine("Yes {0}", (moneyInMachine - change));
        }
        else if (moneyInMachine < change && p <= a)
        {
            Console.WriteLine("No {0}", change - moneyInMachine);
        }
    }
}