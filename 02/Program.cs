using System;


namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double currentBalance = balance;

            while (true)
            {
                string userChoice = Console.ReadLine();
                double outF = 39.99;
                double csOG = 15.99;
                double zZell = 19.99;
                double honored = 59.99;
                double rWatch = 29.99;
                double rWatchOE = 39.99;

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                if (userChoice == "Game Time")
                {
                    break;
                }

                if (userChoice == "OutFall 4")
                {
                    if (currentBalance < outF)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (userChoice == "CS: OG")
                {
                    if (currentBalance < csOG)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (userChoice == "Zplinter Zell")
                {
                    if (currentBalance < zZell)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (userChoice == "Honored 2")
                {
                    if (currentBalance < honored)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (userChoice == "RoverWatch")
                {
                    if (currentBalance < rWatch)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (userChoice == "RoverWatch Origins Edition")
                {
                    if (currentBalance < rWatchOE)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

            }

            double totalSpent = Math.Abs(balance - currentBalance);
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}",totalSpent,currentBalance);

        }
    }
}
