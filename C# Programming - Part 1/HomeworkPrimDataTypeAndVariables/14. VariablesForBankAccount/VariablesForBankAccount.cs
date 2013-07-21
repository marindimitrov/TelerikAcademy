using System;

class VariablesForBankAccount
{
    static void Main()
    {
        Console.Write("Input account holder's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input account holder's middle name: ");
        string middleName = Console.ReadLine();
        Console.Write("Input account holder's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Input account holder's available amount of money(BGN): ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Input bank name: ");
        string bankName = Console.ReadLine();
        Console.Write("Input IBAN: ");
        string iban = Console.ReadLine();
        Console.Write("Input BIC code: ");
        string bicCode = Console.ReadLine();
        Console.Write("Input first credit card number: ");
        long firstCardNum = long.Parse(Console.ReadLine());
        Console.Write("Input second credit card number: ");
        long secondCardNum = long.Parse(Console.ReadLine());
        Console.Write("Input third credit card number: ");
        long thirdCardNum = long.Parse(Console.ReadLine());

        Console.WriteLine(@"Account's info: 
        Name: {0} {1} {2}
        Balance: {3} BGN
        Bank name: {4}
        IBAN: {5} 
        BIC Code: {6}
        Number of 1st credit card: {7}
        Number of 2nd credit card: {8}
        Number of 3rd credit card: {9}"
            , firstName, middleName, lastName, balance, bankName,
            iban, bicCode, firstCardNum, secondCardNum, thirdCardNum);
    }
}

