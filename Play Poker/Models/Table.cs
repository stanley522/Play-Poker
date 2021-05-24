using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Table
    {
        public int Pot { get; set; }
        int SmallBlind { get; set; }
        public int BuyIn { get; set; }
        int PreFlopBet { get; set; }
        int FlopBet { get; set; }
        int RiverBet { get; set; }
        int TurnBet { get; set; }
        public int CurrentBid { get; set; }
        public List<Card> CommonCards { get; set; } = new List<Card>();
        public List<Player> Players { get; set; } = new List<Player>();
        public void JoinGame(Player player)
        {
            Players.Add(player);
            player.BuyIn(BuyIn);
        }
        public void ClearPot()
        {
            Pot = 0;
            CurrentBid = 0;
        }
    }
}
