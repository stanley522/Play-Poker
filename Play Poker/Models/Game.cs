using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Game
    {
        public Game(Table table)
        {
            Deck = Card.NewDeck();
            SmallBlind = table.SmallBlind;
            BigBlind = table.BigBlind;
        }
        public int Pot { get; set; }
        int SmallBlind { get; set; }
        int BigBlind { get; set; }
        public int BuyIn { get; set; }
        int PreFlopBet { get; set; }
        int FlopBet { get; set; }
        int RiverBet { get; set; }
        int TurnBet { get; set; }
        public int CurrentBid { get; set; }
        public int Dealer { get; set; }
        public HashSet<Card> Deck { get; set; }
        public List<Card> CommonCards { get; set; } = new List<Card>();
        public List<Player> Players { get; set; } = new List<Player>();
        public void JoinGame(Player player)
        {
            Players.Add(player);
            player.BuyIn(BuyIn);
        }
        public bool StartGame()
        {
            if (Players.Count < 2)
            {
                return false;
            }
            foreach(var player in Players)
            {
                Deck.Deal(player.Hand, 2);
            }
            Players[Dealer + 1 % Players.Count].BidMoney(SmallBlind);
            Players[Dealer + 1 % Players.Count].BidMoney(BigBlind);
            return true;
        }
        public void ClearPot()
        {
            Pot = 0;
            CurrentBid = 0;
        }
    }
}
