//* Write a program that converts a number in the 
//range [0...999] to a text corresponding to its 
//English pronunciation. Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"

using System;

class ConvertNumberToCorrespondingText
{
    static void Main()
    {
        Console.WriteLine("For exit enter something which is not integer.\n");
        while (true)
        {
            Console.Write("Enter integer number and see its corresponding text: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 0 && number <= 9)
                {
                    switch (number)
                    {
                        case 0: Console.WriteLine("Zero");
                            break;
                        case 1: Console.WriteLine("One");
                            break;
                        case 2: Console.WriteLine("Two");
                            break;
                        case 3: Console.WriteLine("Three");
                            break;
                        case 4: Console.WriteLine("Four");
                            break;
                        case 5: Console.WriteLine("Five");
                            break;
                        case 6: Console.WriteLine("Six");
                            break;
                        case 7: Console.WriteLine("Seven");
                            break;
                        case 8: Console.WriteLine("Eight");
                            break;
                        case 9: Console.WriteLine("Nine");
                            break;
                    }
                }
                else if (number >= 10 && number <= 99)
                {
                    int tensTwoDigits = number / 10;
                    switch (tensTwoDigits)
                    {
                        case 1: goto Teens;
                        case 2: Console.Write("Twenty ");
                            break;
                        case 3: Console.Write("Thirty ");
                            break;
                        case 4: Console.Write("Fourty ");
                            break;
                        case 5: Console.Write("Fifty ");
                            break;
                        case 6: Console.Write("Sixty ");
                            break;
                        case 7: Console.Write("Seventy ");
                            break;
                        case 8: Console.Write("Eighty ");
                            break;
                        case 9: Console.Write("Ninety ");
                            break;
                    }
                    int unitsTwoDigits = number - (tensTwoDigits * 10);
                    switch (unitsTwoDigits)
                    {
                        case 0: Console.WriteLine("");
                            break;
                        case 1: Console.WriteLine("One");
                            break;
                        case 2: Console.WriteLine("Two");
                            break;
                        case 3: Console.WriteLine("Three");
                            break;
                        case 4: Console.WriteLine("Four");
                            break;
                        case 5: Console.WriteLine("Five");
                            break;
                        case 6: Console.WriteLine("Six");
                            break;
                        case 7: Console.WriteLine("Seven");
                            break;
                        case 8: Console.WriteLine("Eight");
                            break;
                        case 9: Console.WriteLine("Nine");
                            break;
                    }
                    goto End;

                Teens:
                    int TeensDigits = number - (tensTwoDigits * 10);
                    switch (TeensDigits)
                    {
                        case 0: Console.WriteLine("Ten");
                            break;
                        case 1: Console.WriteLine("Eleven");
                            break;
                        case 2: Console.WriteLine("Twelve");
                            break;
                        case 3: Console.WriteLine("Thirteen");
                            break;
                        case 4: Console.WriteLine("Fourteen");
                            break;
                        case 5: Console.WriteLine("Fifteen");
                            break;
                        case 6: Console.WriteLine("Sixteen");
                            break;
                        case 7: Console.WriteLine("Seventeen");
                            break;
                        case 8: Console.WriteLine("Eighteen");
                            break;
                        case 9: Console.WriteLine("Nineteen");
                            break;
                    }
                    goto End;
                }
                else if (number >= 100 && number <= 999)
                {
                    int hundredsThreeDigits = number / 100;
                    switch (hundredsThreeDigits)
                    {
                        case 1: Console.Write("One Hundred ");
                            break;
                        case 2: Console.Write("Two Hundred ");
                            break;
                        case 3: Console.Write("Three Hundred ");
                            break;
                        case 4: Console.Write("Four Hundred ");
                            break;
                        case 5: Console.Write("Five Hundred ");
                            break;
                        case 6: Console.Write("Six Hundred ");
                            break;
                        case 7: Console.Write("Seven Hundred ");
                            break;
                        case 8: Console.Write("Eight Hundred ");
                            break;
                        case 9: Console.Write("Nine Hundred ");
                            break;
                    }
                    int tensThreeDigits = (number - (hundredsThreeDigits * 100)) / 10;
                    switch (tensThreeDigits)
                    {
                        case 0:
                            if (number == 100)
                            {
                                Console.Write("");
                            }
                            else
                            {
                                Console.Write("and ");
                            }
                            break;
                        case 1: goto HundredAndTeens;
                        case 2:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Twenty ");
                            }
                            else
                            {
                                Console.Write("Twenty ");
                            }
                            break;
                        case 3:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Thirty ");
                            }
                            else
                            {
                                Console.Write("Thirty ");
                            }
                            break;
                        case 4:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Fourty ");
                            }
                            else
                            {
                                Console.Write("Fourty ");
                            }
                            break;
                        case 5:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Fifty ");
                            }
                            else
                            {
                                Console.Write("Fifty ");
                            }
                            break;
                        case 6:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Sixty ");
                            }
                            else
                            {
                                Console.Write("Sixty ");
                            }
                            break;
                        case 7:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Seventy ");
                            }
                            else
                            {
                                Console.Write("Seventy ");
                            }
                            break;
                        case 8:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Eighty ");
                            }
                            else
                            {
                                Console.Write("Eighty ");
                            }
                            break;
                        case 9:
                            if (number % 10 == 0)
                            {
                                Console.Write("and Ninety ");
                            }
                            else
                            {
                                Console.Write("Ninety ");
                            }
                            break;
                    }
                    int unitsThreeDigits = number - (hundredsThreeDigits * 100) - (tensThreeDigits * 10);
                    switch (unitsThreeDigits)
                    {
                        case 0: Console.WriteLine("");
                            break;
                        case 1: Console.WriteLine("One");
                            break;
                        case 2: Console.WriteLine("Two");
                            break;
                        case 3: Console.WriteLine("Three");
                            break;
                        case 4: Console.WriteLine("Four");
                            break;
                        case 5: Console.WriteLine("Five");
                            break;
                        case 6: Console.WriteLine("Six");
                            break;
                        case 7: Console.WriteLine("Seven");
                            break;
                        case 8: Console.WriteLine("Eight");
                            break;
                        case 9: Console.WriteLine("Nine");
                            break;
                    }
                    goto End;
                HundredAndTeens:
                    int HundredsTeensDigits = number - (hundredsThreeDigits * 100) - (tensThreeDigits * 10);
                    switch (HundredsTeensDigits)
                    {
                        case 0: Console.WriteLine("and Ten");
                            break;
                        case 1: Console.WriteLine("and Eleven");
                            break;
                        case 2: Console.WriteLine("and Twelve");
                            break;
                        case 3: Console.WriteLine("and Thirteen");
                            break;
                        case 4: Console.WriteLine("and Fourteen");
                            break;
                        case 5: Console.WriteLine("and Fifteen");
                            break;
                        case 6: Console.WriteLine("and Sixteen");
                            break;
                        case 7: Console.WriteLine("and Seventeen");
                            break;
                        case 8: Console.WriteLine("and Eighteen");
                            break;
                        case 9: Console.WriteLine("and Nineteen");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The entered number is out of the required range [0...999].");
                }
            End: ;
            }
            else
            {
                Console.WriteLine("Input is not integer, the program will exit.");
                break;
            }
        }
    }
}