using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play_Poker.Models;

namespace Play_Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Table Table { get; set; } = new Table();
        Game Game { get; set; }
        HashSet<Card> Deck { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Table.BuyIn = 1000;
            var playerOne = new Player("Stanley",Table.BuyIn*2);
            Table.JoinTable(playerOne);
            var playerTwo = new Player("Com", Table.BuyIn * 2);
            Table.JoinTable(playerTwo);
            PlayerOneMoneyTextBox.Text = playerOne.MoneyOnTable.ToString();
            PlayerTwoMoneyTextBox.Text = playerTwo.MoneyOnTable.ToString();
        }

        private void DealPlayerOneButton_Click(object sender, EventArgs e)
        {
            var player = Game.Players.FirstOrDefault();
            Deck.Deal(player.Hand);
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }

        private void DealFivePlayerOne_Click(object sender, EventArgs e)
        {
            var player = Game.Players.FirstOrDefault();
            Deck.DealFive(player.Hand);
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }

        private void ClearPlayerOneHandButton_Click(object sender, EventArgs e)
        {
            var player = Game.Players.FirstOrDefault();
            player.Hand = new List<Card>();
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }



        private void DealPlayerTwoButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Game.Players.LastOrDefault();
            Deck.Deal(playerTwo.Hand);
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }

        private void DealFivePlayerTwoButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Game.Players.LastOrDefault();
            Deck.DealFive(playerTwo.Hand);
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }

        private void ClearPlayerTwoHandButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Game.Players.LastOrDefault();
            playerTwo.Hand = new List<Card>();
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Game.CommonCards).ToList()).ToString();
        }

        private void DealCommonButton_Click(object sender, EventArgs e)
        {
            var player = Game.Players.FirstOrDefault();
            var playerTwo = Game.Players.LastOrDefault();
            Deck.Deal(Game.CommonCards);
            var text = string.Empty;
            Game.CommonCards.ForEach(c => text += $"{c.ToString()} \r\n");
            CommonCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Game.CommonCards).ToList()).ToString();
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Game.CommonCards).ToList()).ToString();

        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var playerOne = Game.Players.FirstOrDefault();
            var playerTwo = Game.Players.LastOrDefault();
            var compare = CardExtension.GetHand(playerOne.Hand.Concat(Game.CommonCards).ToList())
                .CompareTo(CardExtension.GetHand(playerTwo.Hand.Concat(Game.CommonCards).ToList()));

            WinnerTextBox.Text = compare == 1 ? $"{playerOne.Name} wins." :
                compare == -1 ? $"{playerTwo.Name} wins." :
                "It's a draw.";
            if (compare == 1)
            {
                playerOne.WinPot(Game.Pot);
            }
            if (compare == -1)
            {
                playerTwo.WinPot(Game.Pot);
            }
            if (compare == 0)
            { 
            playerOne.WinPot(Game.Pot/2);
            playerTwo.WinPot(Game.Pot/2);
        }
            Game.Pot = 0;
            ShowTableMoney();
            ShowPlayerMoney();

        }

        private void ClearCommonCardsButton_Click(object sender, EventArgs e)
        {
            Game.CommonCards = new List<Card>();
            var text = string.Empty;
            Game.CommonCards.ForEach(c => text += $"{c.ToString()} \r\n");
            CommonCardsTextBox.Text = text;
        }
        private void NewDeckButton_Click(object sender, EventArgs e)
        {
            Deck = Card.NewDeck();
        }

        private void PlayerOneFoldButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Game.Players.LastOrDefault();
            playerTwo.WinPot(Game.Pot);
            Game.ClearPot();
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerTwoFoldButton_Click(object sender, EventArgs e)
        {
            var playerOne = Game.Players.FirstOrDefault();
            playerOne.WinPot(Game.Pot);
            Game.ClearPot();
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerOneCallButton_Click(object sender, EventArgs e)
        {
            var playerOne = Game.Players.FirstOrDefault();
            var amount = Game.CurrentBid - playerOne.Bid;
            playerOne.BidMoney(amount);
            Game.Pot += amount;
            if (Game.Players.All(p => p.Bid == Game.CurrentBid))
            {
                Game.Players.ForEach(p => p.Bid = 0);
                Game.CurrentBid = 0;
            }
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerTwoCallButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Game.Players.LastOrDefault();
            var amount = Game.CurrentBid - playerTwo.Bid;
            playerTwo.BidMoney(amount);
            Game.Pot += amount;
            if (Game.Players.All(p=>p.Bid == Game.CurrentBid))
            {
                Game.Players.ForEach(p => p.Bid = 0);
                Game.CurrentBid = 0;
            }
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerOneRaiseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var playerOne = Game.Players.FirstOrDefault();
                var amount = Game.CurrentBid + int.Parse(PlayerOneRaiseTextBox.Text) - playerOne.Bid;
                playerOne.BidMoney(amount);
                Game.CurrentBid = playerOne.Bid;
                Game.Pot += amount;
                ShowTableMoney();
                ShowPlayerMoney();
            }
        }

        private void PlayerTwoRaiseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var playerTwo = Game.Players.LastOrDefault();
                var amount = Game.CurrentBid + int.Parse(PlayerTwoRaiseTextBox.Text) - playerTwo.Bid;
                playerTwo.BidMoney(amount);
                Game.CurrentBid = playerTwo.Bid;
                Game.Pot += amount;
                ShowTableMoney();
                ShowPlayerMoney();
            }
        }

        private void ShowTableMoney()
        {
            ShowBid();
            ShowPot();
        }
        private void ShowBid()
        {
            BidTextBox.Text = Game.CurrentBid.ToString();
        }
        private void ShowPot()
        {
            PotTextBox.Text = Game.Pot.ToString();
        }
        private void ShowPlayerMoney()
        {
                var playerOne = Game.Players.FirstOrDefault();
            var playerTwo = Game.Players.LastOrDefault();
            PlayerOneMoneyTextBox.Text = playerOne.MoneyOnTable.ToString();
            PlayerTwoMoneyTextBox.Text = playerTwo.MoneyOnTable.ToString();
            PlayerOneBidTextBox.Text = playerOne.Bid.ToString();
            PlayerTwoBidTextBox.Text = playerTwo.Bid.ToString();

        }
    }
}
