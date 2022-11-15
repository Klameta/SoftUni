using System;
using System.Collections.Generic;

namespace _06.MoneyTransactions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, double> bankAccs = new Dictionary<int, double>();
            string[] allInfo = Console.ReadLine().Split(",");

            foreach (var info in allInfo)
            {
                string[] currInfo = info.Split("-");
                bankAccs.Add(int.Parse(currInfo[0]), double.Parse(currInfo[1]));
            }

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "End")
            {
                try
                {

                    switch (cmdArgs[0])
                    {
                        case "Deposit":
                            int id = int.Parse(cmdArgs[1]);
                            double sum = double.Parse(cmdArgs[2]);
                            bankAccs[id] += sum;
                            Console.WriteLine($"Account {id} has new balance: {bankAccs[id]:F2}");

                            break;
                        case "Withdraw":
                            id = int.Parse(cmdArgs[1]);
                            sum = double.Parse(cmdArgs[2]);

                            if (sum > bankAccs[id])
                            {
                                throw new ArgumentException("Insufficient balance!");
                            }
                            bankAccs[id] -= sum;
                            Console.WriteLine($"Account {id} has new balance: {bankAccs[id]:F2}");

                            break;
                        default:
                            throw new ArgumentException("Invalid command!");

                    }

                }
                catch (Exception ex)
                {
                    if (ex.GetType().Name == "KeyNotFoundException")
                    {
                        Console.WriteLine("Invalid account!");
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
