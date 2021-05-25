using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Table
    {
        public Game CurrentGame { get; set; }
        public List<Game> PastGames { get; set; }
        public int BuyIn { get; set; }
        public int SmallBlind { get; set; }
        public int BigBlind { get; set; }
        public int MaxPlayers { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public bool JoinTable(Player player)
        {
            if (Players.Count >= MaxPlayers)
            {
                return false;
            }
            Players.Add(player);
            player.BuyIn(BuyIn);
            return true;
        }
        public bool NewGame()
        {
            if (Players.Count < 2)
            {
                return false;
            }
            var currentGame = CurrentGame;
            PastGames.Add(currentGame);
            CurrentGame = new Game(this);
            return true;
        }

    }
}
