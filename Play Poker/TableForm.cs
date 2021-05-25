using Play_Poker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_Poker
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        Table Table { get; set; }
        List<PlayerItems> PlayerItemsList { get; set; } = new List<PlayerItems>();
        class PlayerItems
        {
            public string Name { get; set; }
            public Label Label { get; set; }
            public Button LeaveButton { get; set; }
        }
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            NewPlayer();
        }
        private void NewPlayer()
        {
            var playername = AddPlayerTextBox.Text;
            var playerItems = new PlayerItems { Name = playername };
            NewPlayerLable(playerItems);
            NewPlayerLeaveButton(playerItems);
            PlayerItemsList.Add(playerItems);
        }
        private void NewPlayerLable(PlayerItems player)
        {
            var label = new Label();
            label.Text = player.Name;
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(13, 100);
            label.Size = new System.Drawing.Size(100, 25);
            label.TabIndex = 1;
            player.Label = label;
            this.Controls.Add(label);
        }
        private void NewPlayerMoney()
        {

        }
        private void NewPlayerCards()
        {

        }
        private void NewPlayerBid()
        {

        }
        private void NewPlayerLeaveButton(PlayerItems player)
        {
            var button = new Button();
            button.Text = $"{player.Name} Leave";
            button.Name = $"{player.Name}_leaveButton";
            button.AutoSize = true;
            button.Location = new System.Drawing.Point(50, 100);
            button.Size = new System.Drawing.Size(100, 25);
            button.TabIndex = 1;
            button.TabIndex = 1;
            button.Click += new System.EventHandler(this.PlayerLeaveButton_Click);
            player.LeaveButton = button;
            this.Controls.Add(button);
        }
        private void PlayerLeaveButton_Click(object sender, EventArgs e)
        {
            var player = PlayerItemsList.FirstOrDefault(p => p.LeaveButton == (Button)sender);
            this.Controls.Remove(player.LeaveButton);
            this.Controls.Remove(player.Label);
            PlayerItemsList.Remove(player);
        }
    }
}
