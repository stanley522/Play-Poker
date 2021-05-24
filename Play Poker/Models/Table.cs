using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Table
    {
        int Pot { get; set; }
        int SmallBlind { get; set; }
        int PreFlop { get; set; }
        int Flop { get; set; }
        int River { get; set; }
        int Turn { get; set; }
        List<Player> Players { get; set; }
        void JoinGame(Player player)
        {
            Players.Add(player);
        }
    }
}
