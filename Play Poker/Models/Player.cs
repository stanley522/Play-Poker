using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Player
    {
        public Player(string name, int money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; private set; }
        int Money { get; set; }
        public int MoneyOnTable { get; private set; }
        int TotalMoney { get => Money+MoneyOnTable; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Bid { get; set; }
        public Table Table { get; set; }
        public void BuyIn(int buyIn)
        {
            Money -= buyIn;
            MoneyOnTable += buyIn;
        }
        public void BidMoney(int amount)
        {
            if (amount > MoneyOnTable)
            {
                throw new Exception($"{amount} is more than current money {MoneyOnTable}");
            }
            MoneyOnTable -= amount;
            Bid += amount;
        }
        public void WinPot(int amount)
        {
            MoneyOnTable += amount;
        }
        public void GainWinnings(int amount)
        {
            Money += MoneyOnTable;
            MoneyOnTable = 0;
        }
    }
}
