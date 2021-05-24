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
        HashSet<Card> Deck { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Table.BuyIn = 1000;
            var playerOne = new Player("Stanley",Table.BuyIn*2);
            Table.JoinGame(playerOne);
            var playerTwo = new Player("Com", Table.BuyIn * 2);
            Table.JoinGame(playerTwo);
            Deck = Card.NewDeck();
            PlayerOneMoneyTextBox.Text = playerOne.MoneyOnTable.ToString();
            PlayerTwoMoneyTextBox.Text = playerTwo.MoneyOnTable.ToString();
        }

        private void DealPlayerOneButton_Click(object sender, EventArgs e)
        {
            var player = Table.Players.FirstOrDefault();
            Deck.Deal(player.Hand);
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }

        private void DealFivePlayerOne_Click(object sender, EventArgs e)
        {
            var player = Table.Players.FirstOrDefault();
            Deck.DealFive(player.Hand);
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }

        private void ClearPlayerOneHandButton_Click(object sender, EventArgs e)
        {
            var player = Table.Players.FirstOrDefault();
            player.Hand = new List<Card>();
            var text = string.Empty;
            player.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerOneCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }



        private void DealPlayerTwoButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Table.Players.LastOrDefault();
            Deck.Deal(playerTwo.Hand);
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }

        private void DealFivePlayerTwoButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Table.Players.LastOrDefault();
            Deck.DealFive(playerTwo.Hand);
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }

        private void ClearPlayerTwoHandButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Table.Players.LastOrDefault();
            playerTwo.Hand = new List<Card>();
            var text = string.Empty;
            playerTwo.Hand.ForEach(c => text += $"{c.ToString()} \r\n");
            PlayerTwoCardsTextBox.Text = text;
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Table.CommonCards).ToList()).ToString();
        }

        private void DealCommonButton_Click(object sender, EventArgs e)
        {
            var player = Table.Players.FirstOrDefault();
            var playerTwo = Table.Players.LastOrDefault();
            Deck.Deal(Table.CommonCards);
            var text = string.Empty;
            Table.CommonCards.ForEach(c => text += $"{c.ToString()} \r\n");
            CommonCardsTextBox.Text = text;
            PlayerOneHandBox.Text = CardExtension.GetHand(player.Hand.Concat(Table.CommonCards).ToList()).ToString();
            PlayerTwoHandBox.Text = CardExtension.GetHand(playerTwo.Hand.Concat(Table.CommonCards).ToList()).ToString();

        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var playerOne = Table.Players.FirstOrDefault();
            var playerTwo = Table.Players.LastOrDefault();
            var compare = CardExtension.GetHand(playerOne.Hand.Concat(Table.CommonCards).ToList())
                .CompareTo(CardExtension.GetHand(playerTwo.Hand.Concat(Table.CommonCards).ToList()));

            WinnerTextBox.Text = compare == 1 ? $"{playerOne.Name} wins." :
                compare == -1 ? $"{playerTwo.Name} wins." :
                "It's a draw.";
            if (compare == 1)
            {
                playerOne.WinPot(Table.Pot);
            }
            if (compare == -1)
            {
                playerTwo.WinPot(Table.Pot);
            }
            if (compare == 0)
            { 
            playerOne.WinPot(Table.Pot/2);
            playerTwo.WinPot(Table.Pot/2);
        }
            Table.Pot = 0;
            ShowTableMoney();
            ShowPlayerMoney();

        }

        private void ClearCommonCardsButton_Click(object sender, EventArgs e)
        {
            Table.CommonCards = new List<Card>();
            var text = string.Empty;
            Table.CommonCards.ForEach(c => text += $"{c.ToString()} \r\n");
            CommonCardsTextBox.Text = text;
        }
        private void NewDeckButton_Click(object sender, EventArgs e)
        {
            Deck = Card.NewDeck();
        }

        private void PlayerOneFoldButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Table.Players.LastOrDefault();
            playerTwo.WinPot(Table.Pot);
            Table.ClearPot();
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerTwoFoldButton_Click(object sender, EventArgs e)
        {
            var playerOne = Table.Players.FirstOrDefault();
            playerOne.WinPot(Table.Pot);
            Table.ClearPot();
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerOneCallButton_Click(object sender, EventArgs e)
        {
            var playerOne = Table.Players.FirstOrDefault();
            var amount = Table.CurrentBid - playerOne.Bid;
            playerOne.BidMoney(amount);
            Table.Pot += amount;
            if (Table.Players.All(p => p.Bid == Table.CurrentBid))
            {
                Table.Players.ForEach(p => p.Bid = 0);
                Table.CurrentBid = 0;
            }
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerTwoCallButton_Click(object sender, EventArgs e)
        {
            var playerTwo = Table.Players.LastOrDefault();
            var amount = Table.CurrentBid - playerTwo.Bid;
            playerTwo.BidMoney(amount);
            Table.Pot += amount;
            if (Table.Players.All(p=>p.Bid == Table.CurrentBid))
            {
                Table.Players.ForEach(p => p.Bid = 0);
                Table.CurrentBid = 0;
            }
            ShowTableMoney();
            ShowPlayerMoney();
        }

        private void PlayerOneRaiseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var playerOne = Table.Players.FirstOrDefault();
                var amount = Table.CurrentBid + int.Parse(PlayerOneRaiseTextBox.Text) - playerOne.Bid;
                playerOne.BidMoney(amount);
                Table.CurrentBid = playerOne.Bid;
                Table.Pot += amount;
                ShowTableMoney();
                ShowPlayerMoney();
            }
        }

        private void PlayerTwoRaiseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var playerTwo = Table.Players.LastOrDefault();
                var amount = Table.CurrentBid + int.Parse(PlayerTwoRaiseTextBox.Text) - playerTwo.Bid;
                playerTwo.BidMoney(amount);
                Table.CurrentBid = playerTwo.Bid;
                Table.Pot += amount;
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
            BidTextBox.Text = Table.CurrentBid.ToString();
        }
        private void ShowPot()
        {
            PotTextBox.Text = Table.Pot.ToString();
        }
        private void ShowPlayerMoney()
        {
                var playerOne = Table.Players.FirstOrDefault();
            var playerTwo = Table.Players.LastOrDefault();
            PlayerOneMoneyTextBox.Text = playerOne.MoneyOnTable.ToString();
            PlayerTwoMoneyTextBox.Text = playerTwo.MoneyOnTable.ToString();
            PlayerOneBidTextBox.Text = playerOne.Bid.ToString();
            PlayerTwoBidTextBox.Text = playerTwo.Bid.ToString();

        }
    }
}
