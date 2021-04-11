using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MySampleCoin.BlockChain
{
    public class Block
    {
        public Block(uint index, DateTime timeStamp, string previousBlockHash, ICollection<Transaction> transactions)
        {
            Index = index;
            TimeStamp = timeStamp;
            PreviousBlockHash = previousBlockHash;
            Transactions = transactions;
            MerkleRoot = ComputeMerkleRoot(transactions?.Select(x => x.Hash).ToList());
        }

        public uint Index { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public string MerkleRoot { get; private set; }
        public string PreviousBlockHash { get; private set; }
        public string Hash { get; private set; }
        public long Nonce { get; private set; }
        public ICollection<Transaction> Transactions { get; private set; }

        public string ComputeHash()
        {
            using SHA256 sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes($"{TimeStamp}-{PreviousBlockHash}-{MerkleRoot}-{Nonce}")));
        }

        public string ComputeMerkleRoot(List<string> leafNodes)
        {
            using SHA256 sha256 = SHA256.Create();

            if (leafNodes == null || leafNodes.Count == 0)
                return new string('0', 32);

            if (leafNodes.Count == 1)
                return leafNodes.First();

            if (leafNodes.Count % 2 == 1)
                leafNodes.Add(leafNodes.Last());

            var hashedNodeResult = Enumerable.Range(0, leafNodes.Count / 2).Select(i => Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes($"{leafNodes[i]}{leafNodes[i + 1]}")))).ToList();

            return ComputeMerkleRoot(hashedNodeResult);
        }

        public void Mine(int difficulty)
        {
            var prefixZeros = new string('0', difficulty);

            do
            {
                Nonce++;
                Hash = ComputeHash();
            } while (!Hash.StartsWith(prefixZeros));
        }
    }
}
