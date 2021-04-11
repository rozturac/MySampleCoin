using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySampleCoin.BlockChain
{
    public class BlockChain
    {
        public List<Block> Chain { get; private set; }
        public List<Transaction> PendingTransactions { get; private set; }

        private int _difficulty = 3;
        private decimal _reward = 1;

        public BlockChain()
        {
            Chain = new List<Block>();
            PendingTransactions = new List<Transaction>();
            AddGenecisBlock();
        }

        private Block CreateGenesisBlock()
        {
            var block = new Block(0, DateTime.Now, new string('0', 32), new List<Transaction>() { Transaction.GetCoinBaseTransaction("Rıdvan", _reward) });
            block.Mine(_difficulty);
            return block;
        }

        private void AddGenecisBlock() => Chain.Add(CreateGenesisBlock());

        public bool AddTransaction(Transaction transaction)
        {
            if (GetBalance(transaction.From) < transaction.Amount)
                return false;

            PendingTransactions.Add(transaction);
            return true;
        }

        public void AddTransactions(IEnumerable<Transaction> transactions) => PendingTransactions.AddRange(transactions);

        private Block GetLastBlock() => Chain.LastOrDefault();

        private Block CreateBlock()
        {
            var lastBlock = GetLastBlock();
            var block = new Block(lastBlock.Index + 1, DateTime.Now, lastBlock.Hash, PendingTransactions);
            block.Mine(_difficulty);
            PendingTransactions = new List<Transaction>();
            return block;
        }

        public void ProcessPendingTransactions(string minerAddress)
        {
            PendingTransactions.Insert(0, Transaction.GetCoinBaseTransaction(minerAddress, (_reward * PendingTransactions.Count) / (32 - _difficulty)));
            var createdBlock = CreateBlock();
            Chain.Add(createdBlock);
        }

        public bool IsValid()
        {
            for (int i = Chain.Count - 1; i > 0; i--)
            {
                var previousBlock = Chain[i - 1];
                var currentBlock = Chain[i];

                if (currentBlock.Hash != currentBlock.ComputeHash() || currentBlock.PreviousBlockHash != previousBlock.Hash)
                    return false;
            }

            return true;
        }

        public decimal GetBalance(string address)
        {
            return Chain.SelectMany(x => x.Transactions).Sum(x => x.From.Equals(address) ? x.Amount * -1 : x.To.Equals(address) ? x.Amount : 0);
        }
    }
}
