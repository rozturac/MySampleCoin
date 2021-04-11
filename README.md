# MySampleCoin
 .NetCore/C# - Blockchain algorithm example using merkle tree


Sample command line output:
```cmd
=========================
1. Add a transaction
2. Display Blockchain
3. Get Balance
4. Exit
=========================
Action Number (1, 2, 3, 4): 1
Receiver name: Muhammed
Amount: 0.1
Success
Action Number (1, 2, 3, 4): 1
Receiver name: Talat
Amount: 0.1
Success
Action Number (1, 2, 3, 4): 3
Address: Rıdvan
Rıdvan total balance: 0,8689655172413793103448275862
Action Number (1, 2, 3, 4): 1
Receiver name: Muhammed
Amount: 9
Insufficient balance !
Action Number (1, 2, 3, 4): 2
Blockchain
[
  {
    "Index": 0,
    "TimeStamp": "2021-04-11T19:03:17.5181085+03:00",
    "MerkleRoot": "kvEz0o33A12WFofdD6926penZB98lkkRhSaGqDFqVgg=",
    "PreviousBlockHash": "00000000000000000000000000000000",
    "Hash": "000RfTqV3j7UBULAgFwXztWbkIb8GmKzFbcrbCN6cGU=",
    "Nonce": 105424,
    "Transactions": [
      {
        "Hash": "kvEz0o33A12WFofdD6926penZB98lkkRhSaGqDFqVgg=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 1.0
      }
    ]
  },
  {
    "Index": 1,
    "TimeStamp": "2021-04-11T19:03:26.882776+03:00",
    "MerkleRoot": "0Brcz4tcJzBj5JZ7AP5k44ldRJeN1zzPV9m47G8Mys8=",
    "PreviousBlockHash": "000RfTqV3j7UBULAgFwXztWbkIb8GmKzFbcrbCN6cGU=",
    "Hash": "000ktEBcHsFnGVFvwG+WVGFhJLLK8cJmfCowXbjAYVY=",
    "Nonce": 207352,
    "Transactions": [
      {
        "Hash": "iVK4tCNpFB2W3fDaZbxQ+7052d3Btn/TUn3f2AiP+go=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 0.0344827586206896551724137931
      },
      {
        "Hash": "IOcTeZAww0t7UjgEFwqXNyPn/8dkbk75WWr0hlRnopk=",
        "From": "Rıdvan",
        "To": "Muhammed",
        "Amount": 0.1
      }
    ]
  },
  {
    "Index": 2,
    "TimeStamp": "2021-04-11T19:03:36.4814975+03:00",
    "MerkleRoot": "3WkCfBuaLvWEPQ0R5wxIRpKWlnZohornYSSwXprrEEQ=",
    "PreviousBlockHash": "000ktEBcHsFnGVFvwG+WVGFhJLLK8cJmfCowXbjAYVY=",
    "Hash": "00043wu3i4vLXdoFSBV89o1wYUqtL/qEle5GkF91xCQ=",
    "Nonce": 327852,
    "Transactions": [
      {
        "Hash": "iVK4tCNpFB2W3fDaZbxQ+7052d3Btn/TUn3f2AiP+go=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 0.0344827586206896551724137931
      },
      {
        "Hash": "E6wI8AsKVboxsJM12E8+Y8S8tOtO4ceBDsOs2HucPMg=",
        "From": "Rıdvan",
        "To": "Talat",
        "Amount": 0.1
      }
    ]
  }
]
Action Number (1, 2, 3, 4):
```
