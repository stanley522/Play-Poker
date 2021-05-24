using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Game
    {
        public string Name { get; private set; }
        int Money { get; set; }
        public int MoneyOnTable { get; private set; }
        int TotalMoney { get => Money+MoneyOnTable; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Bid { get; set; }
        public void BuyIn(int buyIn)
        {
            Money -= buyIn;
            MoneyOnTable += buyIn;
        }
    }
}
