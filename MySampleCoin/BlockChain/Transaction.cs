using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MySampleCoin.BlockChain
{
    public class Transaction
    {
        public Transaction(string from, string to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
            Hash = ComputeHash();
        }
        public string Hash { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }
        public decimal Amount { get; private set; }

        public string ComputeHash()
        {
            using SHA256 sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes($"{JsonConvert.SerializeObject(this)}")));
        }

        public static Transaction GetCoinBaseTransaction(string address, decimal reword) => new Transaction(string.Empty, address, reword);
    }
}