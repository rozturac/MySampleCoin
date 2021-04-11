using MySampleCoin.BlockChain;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace MySampleCoin
{
    class Program
    {
        private static string _name = "Rıdvan";

        static void Main(string[] args)
        {
            BlockChain.BlockChain blockChain = new BlockChain.BlockChain();

            Console.WriteLine("=========================");
            Console.WriteLine("1. Add a transaction");
            Console.WriteLine("2. Display Blockchain");
            Console.WriteLine("3. Get Balance");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=========================");

            int selection = 0;
            while (true)
            {
                switch (selection)
                {
                    case 1:
                        Console.Write("Receiver name: ");
                        string receiverName = Console.ReadLine();
                        Console.Write("Amount: ");
                        string amount = Console.ReadLine();
                        var result = blockChain.AddTransaction(new Transaction(_name, receiverName, decimal.Parse(amount, CultureInfo.InvariantCulture)));
                        if (result)
                        {
                            blockChain.ProcessPendingTransactions(_name);
                            Console.WriteLine("Success");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance !");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Blockchain");
                        Console.WriteLine(JsonConvert.SerializeObject(blockChain.Chain, Formatting.Indented));
                        break;
                    case 3:
                        Console.Write("Address: ");
                        var address = Console.ReadLine();
                        var balance = blockChain.GetBalance(address);
                        Console.WriteLine($"{address} total balance: {balance}");
                        break;
                    case 4:
                        return;
                }

                Console.Write("Action Number (1, 2, 3, 4): ");
                string action = Console.ReadLine();
                selection = int.Parse(action);
            }
        }
    }
}