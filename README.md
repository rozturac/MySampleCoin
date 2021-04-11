# MySampleCoin
 .NetCore/C# - Blockchain algorithm example using merkle tree


Sample command line output:

=========================
1. Add a transaction
2. Display Blockchain
3. Get Balance
4. Exit
=========================
Action Number (1, 2, 3, 4): 1
Receiver name: Kadir
Amount: 0.1
Success
Action Number (1, 2, 3, 4): 1
Receiver name: Safa
Amount: 0.1
Success
Action Number (1, 2, 3, 4): 1
Receiver name: Cabadak
Amount: 0.1
Success
Action Number (1, 2, 3, 4): 3
Address: Safa
Safa total balance: 0,1
Action Number (1, 2, 3, 4): 3
Address: Kadir
Kadir total balance: 0,1
Action Number (1, 2, 3, 4): 3
Address: Cabadak
Cabadak total balance: 0,1
Action Number (1, 2, 3, 4): 3
Address: Rıdvan
Rıdvan total balance: 0,8034482758620689655172413793
Action Number (1, 2, 3, 4): 2
Blockchain
[
  {
    "Index": 0,
    "TimeStamp": "2021-04-11T18:40:12.1907798+03:00",
    "MerkleRoot": "kvEz0o33A12WFofdD6926penZB98lkkRhSaGqDFqVgg=",
    "PreviousBlockHash": "00000000000000000000000000000000",
    "Hash": "000ir0GZuZTBphpTuNyKMzV1Q752BC1W2gSxvbHdl54=",
    "Nonce": 31259,
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
    "TimeStamp": "2021-04-11T18:40:19.7965184+03:00",
    "MerkleRoot": "FoIyVw1X4wkxEP7ZwOS6SLWyCgocNFbHrrPFot4UVwA=",
    "PreviousBlockHash": "000ir0GZuZTBphpTuNyKMzV1Q752BC1W2gSxvbHdl54=",
    "Hash": "000eVcrKE1A7rzXo8UysjT1zD+EXPDfsmSNHj6UXsfw=",
    "Nonce": 263092,
    "Transactions": [
      {
        "Hash": "iVK4tCNpFB2W3fDaZbxQ+7052d3Btn/TUn3f2AiP+go=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 0.0344827586206896551724137931
      },
      {
        "Hash": "rZhC/KkC6KocvEdLdrlWhH5apKjdNdjNbxbG/gk1hoc=",
        "From": "Rıdvan",
        "To": "Kadir",
        "Amount": 0.1
      }
    ]
  },
  {
    "Index": 2,
    "TimeStamp": "2021-04-11T18:40:25.8663338+03:00",
    "MerkleRoot": "pJcf/2Ybr7IcVy/YFtcQJ70b7SgfTZrd62nf+XaRxQk=",
    "PreviousBlockHash": "000eVcrKE1A7rzXo8UysjT1zD+EXPDfsmSNHj6UXsfw=",
    "Hash": "000RkNQRAJZ+CiSsNCfZ4vbbytlw6yJPYcDwwiGV4Yw=",
    "Nonce": 92062,
    "Transactions": [
      {
        "Hash": "iVK4tCNpFB2W3fDaZbxQ+7052d3Btn/TUn3f2AiP+go=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 0.0344827586206896551724137931
      },
      {
        "Hash": "uvVG8x6/aIo+Z1tRzeDoK0iEuiVG8q2UszEFuL638Iw=",
        "From": "Rıdvan",
        "To": "Safa",
        "Amount": 0.1
      }
    ]
  },
  {
    "Index": 3,
    "TimeStamp": "2021-04-11T18:40:33.3549831+03:00",
    "MerkleRoot": "yYaS+qCVqYKx0jGgDhCpdkEIMwuTAgVKWbLHRVV6zAk=",
    "PreviousBlockHash": "000RkNQRAJZ+CiSsNCfZ4vbbytlw6yJPYcDwwiGV4Yw=",
    "Hash": "000ZaAHKiZvkxCn8/ehJXLAGCW3igWq7Uez3j8N4Mr4=",
    "Nonce": 86886,
    "Transactions": [
      {
        "Hash": "iVK4tCNpFB2W3fDaZbxQ+7052d3Btn/TUn3f2AiP+go=",
        "From": "",
        "To": "Rıdvan",
        "Amount": 0.0344827586206896551724137931
      },
      {
        "Hash": "KMaOm2TWJzefOcWXiRoqpPGXWrrjaGbxo3ToPhnmY/M=",
        "From": "Rıdvan",
        "To": "Cabadak",
        "Amount": 0.1
      }
    ]
  }
]
Action Number (1, 2, 3, 4): 1
Receiver name: Kadir
Amount: 1
Insufficient balance !
Action Number (1, 2, 3, 4):
