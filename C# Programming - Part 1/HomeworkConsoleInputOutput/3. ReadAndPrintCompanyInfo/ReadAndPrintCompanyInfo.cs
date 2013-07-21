//A company has name, address, phone number, fax 
//number, web site and manager. The manager has 
//first name, last name, age and a phone number. 
//Write a program that reads the information about a 
//company and its manager and prints them on the 
//console.

using System;

class ReadAndPrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company's telephone's number: ");
        string companyPhoneNum = Console.ReadLine();
        Console.Write("Enter company's fax number: ");
        string companyFaxNum = Console.ReadLine();
        Console.Write("Enter company's web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter manager's fist name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number: ");
        string managerPhoneNum = Console.ReadLine();
        Console.WriteLine("\nInformation about the company:\nCompany Name: {0}\nCompany Address: {1}\nCompany's Telephone is: {2}\nCompany's Fax is: {3}\nCompany's website: {4}",
            companyName, companyAddress, companyPhoneNum, companyFaxNum, companyWebSite);
        Console.WriteLine("\nInformation about the company's manager:\nManager's first name: {0}\nManager's last name: {1}\nManager's age: {2}\nManager's Phone: {3}\n",
            managerFirstName, managerLastName, managerAge, managerPhoneNum);
    }
}
