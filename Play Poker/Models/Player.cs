using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    class Player
    {
        int Money { get; set; }
        List<Card> Hand { get; set; } = new List<Card>();
        int Bet { get; set; }
    }
}
