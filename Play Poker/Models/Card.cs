using Play_Poker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Poker.Models
{
    public class Card
    {
        Card(int suit, int rank)
        {
            Suit = (Suits)suit;
            Rank = (Rank)rank;
        }
        public Suits Suit { get; }
        public Rank Rank { get; }
        static public HashSet<Card> NewDeck()
        {
            var cardList = new HashSet<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    cardList.Add(new Card(i, j));
                }
            }

            return cardList;
        }
        public override string ToString()
        {
            var str = $"{Rank} of {Suit}";
            
            return str;
        }
    }
    public class Hand : IComparable<Hand>
    {
        HandTypes HandType { get; set; }
        List<Rank> Ranks { get; set; }
        HashSet<Card> SelectedCards { get; set; }
        public Hand(HandTypes handType, List<Rank> ranks)
        {
            HandType = handType;
            Ranks = ranks;
        }
        public override string ToString()
        {
            var str = $"{HandType}";
            foreach (var rank in Ranks)
            {
                str += $"_{ rank}";
            }
            return str;
        }
        public int CompareTo(Hand hand)
        {
            if (HandType > hand.HandType)
            {
                return 1;
            }
            else if (HandType < hand.HandType)
            {
                return -1;
            }
            if (Ranks != null && Ranks.Count > 0
             && hand.Ranks != null && hand.Ranks.Count > 0)
            {
                for (int i = 0; i < Ranks.Count; i++)
                {
                    if (Ranks[i] > hand.Ranks[i])
                    {
                        return 1;
                    }
                    else if (Ranks[i] < hand.Ranks[i])
                    {
                        return -1;
                    }
                }
                return 0;
            }
            else
            {
                throw new Exception("Hand is wrong");
            }

        }
    }
    static public class CardExtension
    {
        #region -- GetHand --

        public static Hand GetHandSeven(List<Card> cards)
        {
            if (cards.Count != 7)
            {
                throw new Exception("Hand not seven cards.");
            }
            return GetHand(cards);

        }
        public static Hand GetHand(List<Card> cards)
        {
            if (cards.Count < 5)
            {
                return new Hand(HandTypes.NoHand,new List<Rank>());
            }
            List<Rank> ranks;
            if (CheckRoyalFlush(cards, out ranks))
                return new Hand(HandTypes.RoyalFlush, ranks);
            if (CheckStraightFlush(cards, out ranks))
                return new Hand(HandTypes.StraightFlush, ranks);
            if (CheckFourOfAKind(cards, out ranks))
                return new Hand(HandTypes.FourOfAKind, ranks);
            if (CheckFullHouse(cards, out ranks))
                return new Hand(HandTypes.FullHouse, ranks);
            if (CheckFlush(cards, out ranks))
                return new Hand(HandTypes.Flush, ranks);
            if (CheckStraight(cards, out ranks))
                return new Hand(HandTypes.Straight, ranks);
            if (CheckThreeOfAKind(cards, out ranks))
                return new Hand(HandTypes.ThreeOfAKind, ranks);
            if (CheckTwoPairs(cards, out ranks))
                return new Hand(HandTypes.TwoPairs, ranks);
            if (CheckPair(cards, out ranks))
                return new Hand(HandTypes.Pair, ranks);
            if (CheckHighCard(cards, out ranks))
                return new Hand(HandTypes.HighCard, ranks);
            throw new Exception("Incorrect hand");

        }
        static bool CheckRoyalFlush(List<Card> cards, out List<Rank> ranks)
        {
            var suits = cards.GroupBy(c => c.Suit);
            if (suits.Any(g => g.Count() >= 5))
            {
                foreach (var suit in suits.Where(g => g.Count() >= 5))
                {
                    var suitRanks = suit.Select(c => c.Rank);
                    if (suitRanks.Contains(Rank.Ace)
                     && suitRanks.Contains(Rank.King)
                     && suitRanks.Contains(Rank.Queen)
                     && suitRanks.Contains(Rank.Jack)
                     && suitRanks.Contains(Rank.Ten))
                    {
                        ranks = new List<Rank> { Rank.Ace };
                        return true;
                    }
                }
            }
            ranks = null;
            return false;
        }

        static bool CheckStraightFlush(List<Card> cards, out List<Rank> ranks)
        {
            var suits = cards.GroupBy(c => c.Suit);
            if (suits.Any(g => g.Count() >= 5))
            {
                foreach (var suit in suits.Where(g => g.Count() >= 5))
                {
                    if (CheckStraight(suit.ToList(), out ranks))
                        return true;
                }
            }
            ranks = null;
            return false;
        }
        static bool CheckFourOfAKind(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            if (rank.Any(g => g.Count() >= 4))
            {
                var high = rank.Where(g => g.Count() >= 4).Max(r => r.Key);
                var kicker = rank.Where(g => g.Key != high).Max(r => r.Key);
                ranks = new List<Rank> { high, kicker };
                return true;
            }
            else
            {
                ranks = null;
                return false;
            }
        }
        static bool CheckFullHouse(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            if (rank.Any(g => g.Count() >= 3))
            {
                var high = rank.Where(g => g.Count() >= 3).Max(r => r.Key);
                if (rank.Any(g => g.Count() >= 2 && g.Key != high))
                {
                    var kicker = rank.Where(g => g.Count() >= 2 && g.Key != high).Max(r => r.Key);
                    ranks = new List<Rank> { high, kicker };
                    return true;
                }
                else
                {
                    ranks = null;
                    return false;
                }
            }
            else
            {
                ranks = null;
                return false;
            }
        }
        static bool CheckFlush(List<Card> cards, out List<Rank> ranks)
        {
            var suits = cards.GroupBy(c => c.Suit);
            List<Rank> suitRank = null;
            if (suits.Any(g => g.Count() >= 5))
            {
                foreach (var suit in suits.Where(g => g.Count() >= 5))
                {
                    var currSuitRank = suit.Select(c => c.Rank)
                        .OrderByDescending(r => r).Take(5).ToList();
                    if ((suitRank == null)
                     || (currSuitRank[0] > suitRank[0])
                     || (currSuitRank[0] == suitRank[0] && currSuitRank[1] > suitRank[1])
                     || (currSuitRank[0] == suitRank[0] && currSuitRank[1] == suitRank[1] && currSuitRank[2] > suitRank[2])
                     || (currSuitRank[0] == suitRank[0] && currSuitRank[1] == suitRank[1] && currSuitRank[2] == suitRank[2] && currSuitRank[3] > suitRank[3])
                     || (currSuitRank[0] == suitRank[0] && currSuitRank[1] == suitRank[1] && currSuitRank[2] == suitRank[2] && currSuitRank[3] == suitRank[3] && currSuitRank[4] > suitRank[4]))
                    {
                        suitRank = currSuitRank;
                    }
                }
            }
            if (suitRank != null)
            {
                ranks = suitRank;
                return true;
            }
            ranks = null;
            return false;
        }
        static bool CheckStraight(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.Select(c => c.Rank).ToHashSet();
            var length = 0;
            for (int i = 14; i > 6; i--)
            {
                if (rank.Contains((Rank)i))
                    length++;
                else
                    length = 0;

                if (length == 5)
                {
                    ranks = new List<Rank> { (Rank)i + 4 };
                    return true;
                }
            }
            if (rank.Contains(Rank.Ace)
             && rank.Contains(Rank.Two)
             && rank.Contains(Rank.Three)
             && rank.Contains(Rank.Four)
             && rank.Contains(Rank.Five))
            {
                ranks = new List<Rank> { Rank.Five };
                return true;
            }
            ranks = null;
            return false;
        }
        static bool CheckThreeOfAKind(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            if (rank.Any(g => g.Count() >= 3))
            {
                var high = rank.Where(g => g.Count() >= 3).Max(r => r.Key);
                var kicker = rank.Where(g => g.Key != high).Max(r => r.Key);
                var kicker2 = rank.Where(g => g.Key != high && g.Key != kicker).Max(r => r.Key);
                ranks = new List<Rank> { high, kicker, kicker2 };
                return true;
            }
            else
            {
                ranks = null;
                return false;
            }
        }
        static bool CheckTwoPairs(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            if (rank.Any(g => g.Count() >= 4))
            {
                var high = rank.Where(g => g.Count() >= 2).Max(r => r.Key);
                var kicker = rank.Where(g => g.Count() >= 2 && g.Key != high).Max(r => r.Key);
                var kicker2 = rank.Where(g => g.Key != high && g.Key != kicker).Max(r => r.Key);
                ranks = new List<Rank> { high, kicker };
                return true;
            }
            else
            {
                ranks = null;
                return false;
            }
        }
        static bool CheckPair(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            if (rank.Any(g => g.Count() >= 2))
            {
                var high = rank.Where(g => g.Count() >= 2).Max(r => r.Key);
                var kicker = rank.Where(g => g.Key != high).Max(r => r.Key);
                var kicker2 = rank.Where(g => g.Key != high && g.Key != kicker).Max(r => r.Key);
                var kicker3 = rank.Where(g => g.Key != high && g.Key != kicker && g.Key != kicker2).Max(r => r.Key);
                ranks = new List<Rank> { high, kicker, kicker2, kicker3 };
                return true;
            }
            else
            {
                ranks = null;
                return false;
            }
        }
        static bool CheckHighCard(List<Card> cards, out List<Rank> ranks)
        {
            var rank = cards.GroupBy(c => c.Rank);
            var high = rank.Max(r => r.Key);
            var kicker = rank.Where(g => g.Key != high).Max(r => r.Key);
            var kicker2 = rank.Where(g => g.Key != high && g.Key != kicker).Max(r => r.Key);
            var kicker3 = rank.Where(g => g.Key != high && g.Key != kicker && g.Key != kicker2).Max(r => r.Key);
            var kicker4 = rank.Where(g => g.Key != high && g.Key != kicker && g.Key != kicker2 && g.Key != kicker3).Max(r => r.Key);
            ranks = new List<Rank> { high, kicker, kicker2, kicker3, kicker4 };
            return true;
        }
        static Hand GetHandFive(List<Card> cards)
        {
            if (cards.Count != 5)
            {
                throw new Exception("Hand not seven cards.");
            }
            return GetHand(cards);
        }

        #endregion

        public static void Deal(this HashSet<Card> cards, List<Card> hand)
        {
            var random = new Random();
            var num = random.Next() % cards.Count();
            var card = cards.ToList()[num];
            cards.Remove(card);
            hand.Add(card);
        }
        public static void DealFive(this HashSet<Card> cards, List<Card> hand)
        {
            for (int i = 0; i < 5; i++)
            {
                var random = new Random();
                var num = random.Next()% cards.Count();
                var card = cards.ToList()[num];
                cards.Remove(card);
                hand.Add(card);
            }
        }
    }
}
