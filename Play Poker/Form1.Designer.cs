using System.Windows.Forms;

namespace Play_Poker
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerOneLable = new System.Windows.Forms.Label();
            this.PlayerOneCardsLable = new System.Windows.Forms.Label();
            this.DealPlayerOneButton = new System.Windows.Forms.Button();
            this.DealFivePlayerOneButton = new System.Windows.Forms.Button();
            this.PlayerOneCardsTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneHandBox = new System.Windows.Forms.TextBox();
            this.PlayerOneMoneyTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneMoneyLable = new System.Windows.Forms.Label();
            this.ClearPlayerOneHandButton = new System.Windows.Forms.Button();
            this.NewDeckButton = new System.Windows.Forms.Button();
            this.ClearPlayerTwoHandButton = new System.Windows.Forms.Button();
            this.PlayerTwoMoneyLable = new System.Windows.Forms.Label();
            this.PlayerTwoMoneyTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoHandBox = new System.Windows.Forms.TextBox();
            this.DealFivePlayerTwoButton = new System.Windows.Forms.Button();
            this.DealPlayerTwoButton = new System.Windows.Forms.Button();
            this.PlayerTwoCardsTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoCardsLable = new System.Windows.Forms.Label();
            this.PlayerTwoLable = new System.Windows.Forms.Label();
            this.CommonCardsTextBox = new System.Windows.Forms.TextBox();
            this.CommonCardsLable = new System.Windows.Forms.Label();
            this.WinnerTextBox = new System.Windows.Forms.TextBox();
            this.DealCommonButton = new System.Windows.Forms.Button();
            this.CompareButton = new System.Windows.Forms.Button();
            this.ClearCommonCardsButton = new System.Windows.Forms.Button();
            this.PotTextBox = new System.Windows.Forms.TextBox();
            this.PotLable = new System.Windows.Forms.Label();
            this.PlayerOneRaiseTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneRaiseLable = new System.Windows.Forms.Label();
            this.PlayerOneCallButton = new System.Windows.Forms.Button();
            this.PlayerOneFoldButton = new System.Windows.Forms.Button();
            this.BidLable = new System.Windows.Forms.Label();
            this.BidTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneBidLable = new System.Windows.Forms.Label();
            this.PlayerOneBidTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoBidLable = new System.Windows.Forms.Label();
            this.PlayerTwoBidTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoFoldButton = new System.Windows.Forms.Button();
            this.PlayerTwoCallButton = new System.Windows.Forms.Button();
            this.PlayerTwoRaiseLable = new System.Windows.Forms.Label();
            this.PlayerTwoRaiseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayerOneLable
            // 
            this.PlayerOneLable.AutoSize = true;
            this.PlayerOneLable.Location = new System.Drawing.Point(12, 9);
            this.PlayerOneLable.Name = "PlayerOneLable";
            this.PlayerOneLable.Size = new System.Drawing.Size(66, 15);
            this.PlayerOneLable.TabIndex = 0;
            this.PlayerOneLable.Text = "PlayerOne";
            // 
            // PlayerOneCardsLable
            // 
            this.PlayerOneCardsLable.AutoSize = true;
            this.PlayerOneCardsLable.Location = new System.Drawing.Point(12, 36);
            this.PlayerOneCardsLable.Name = "PlayerOneCardsLable";
            this.PlayerOneCardsLable.Size = new System.Drawing.Size(98, 15);
            this.PlayerOneCardsLable.TabIndex = 2;
            this.PlayerOneCardsLable.Text = "PlayerOneCards";
            // 
            // DealPlayerOneButton
            // 
            this.DealPlayerOneButton.Location = new System.Drawing.Point(114, 5);
            this.DealPlayerOneButton.Name = "DealPlayerOneButton";
            this.DealPlayerOneButton.Size = new System.Drawing.Size(110, 23);
            this.DealPlayerOneButton.TabIndex = 4;
            this.DealPlayerOneButton.Text = "DealPlayerOne";
            this.DealPlayerOneButton.UseVisualStyleBackColor = true;
            this.DealPlayerOneButton.Click += new System.EventHandler(this.DealPlayerOneButton_Click);
            // 
            // DealFivePlayerOneButton
            // 
            this.DealFivePlayerOneButton.Location = new System.Drawing.Point(114, 28);
            this.DealFivePlayerOneButton.Name = "DealFivePlayerOneButton";
            this.DealFivePlayerOneButton.Size = new System.Drawing.Size(140, 23);
            this.DealFivePlayerOneButton.TabIndex = 5;
            this.DealFivePlayerOneButton.Text = "DealFivePlayerOne";
            this.DealFivePlayerOneButton.UseVisualStyleBackColor = true;
            this.DealFivePlayerOneButton.Click += new System.EventHandler(this.DealFivePlayerOne_Click);
            // 
            // PlayerOneCardsTextBox
            // 
            this.PlayerOneCardsTextBox.Location = new System.Drawing.Point(13, 55);
            this.PlayerOneCardsTextBox.Multiline = true;
            this.PlayerOneCardsTextBox.Name = "PlayerOneCardsTextBox";
            this.PlayerOneCardsTextBox.ReadOnly = true;
            this.PlayerOneCardsTextBox.Size = new System.Drawing.Size(189, 104);
            this.PlayerOneCardsTextBox.TabIndex = 3;
            // 
            // PlayerOneHandBox
            // 
            this.PlayerOneHandBox.Location = new System.Drawing.Point(13, 178);
            this.PlayerOneHandBox.Multiline = true;
            this.PlayerOneHandBox.Name = "PlayerOneHandBox";
            this.PlayerOneHandBox.ReadOnly = true;
            this.PlayerOneHandBox.Size = new System.Drawing.Size(189, 34);
            this.PlayerOneHandBox.TabIndex = 6;
            // 
            // PlayerOneMoneyTextBox
            // 
            this.PlayerOneMoneyTextBox.Location = new System.Drawing.Point(12, 271);
            this.PlayerOneMoneyTextBox.Multiline = true;
            this.PlayerOneMoneyTextBox.Name = "PlayerOneMoneyTextBox";
            this.PlayerOneMoneyTextBox.ReadOnly = true;
            this.PlayerOneMoneyTextBox.Size = new System.Drawing.Size(95, 25);
            this.PlayerOneMoneyTextBox.TabIndex = 7;
            // 
            // PlayerOneMoneyLable
            // 
            this.PlayerOneMoneyLable.AutoSize = true;
            this.PlayerOneMoneyLable.Location = new System.Drawing.Point(12, 252);
            this.PlayerOneMoneyLable.Name = "PlayerOneMoneyLable";
            this.PlayerOneMoneyLable.Size = new System.Drawing.Size(106, 15);
            this.PlayerOneMoneyLable.TabIndex = 8;
            this.PlayerOneMoneyLable.Text = "PlayerOneMoney";
            // 
            // ClearPlayerOneHandButton
            // 
            this.ClearPlayerOneHandButton.Location = new System.Drawing.Point(12, 218);
            this.ClearPlayerOneHandButton.Name = "ClearPlayerOneHandButton";
            this.ClearPlayerOneHandButton.Size = new System.Drawing.Size(160, 23);
            this.ClearPlayerOneHandButton.TabIndex = 9;
            this.ClearPlayerOneHandButton.Text = "ClearPlayerOneHand";
            this.ClearPlayerOneHandButton.UseVisualStyleBackColor = true;
            this.ClearPlayerOneHandButton.Click += new System.EventHandler(this.ClearPlayerOneHandButton_Click);
            // 
            // NewDeckButton
            // 
            this.NewDeckButton.Location = new System.Drawing.Point(300, 5);
            this.NewDeckButton.Name = "NewDeckButton";
            this.NewDeckButton.Size = new System.Drawing.Size(140, 23);
            this.NewDeckButton.TabIndex = 10;
            this.NewDeckButton.Text = "NewDeck";
            this.NewDeckButton.UseVisualStyleBackColor = true;
            this.NewDeckButton.Click += new System.EventHandler(this.NewDeckButton_Click);
            // 
            // ClearPlayerTwoHandButton
            // 
            this.ClearPlayerTwoHandButton.Location = new System.Drawing.Point(493, 218);
            this.ClearPlayerTwoHandButton.Name = "ClearPlayerTwoHandButton";
            this.ClearPlayerTwoHandButton.Size = new System.Drawing.Size(160, 23);
            this.ClearPlayerTwoHandButton.TabIndex = 19;
            this.ClearPlayerTwoHandButton.Text = "ClearPlayerTwoHand";
            this.ClearPlayerTwoHandButton.UseVisualStyleBackColor = true;
            this.ClearPlayerTwoHandButton.Click += new System.EventHandler(this.ClearPlayerTwoHandButton_Click);
            // 
            // PlayerTwoMoneyLable
            // 
            this.PlayerTwoMoneyLable.AutoSize = true;
            this.PlayerTwoMoneyLable.Location = new System.Drawing.Point(491, 252);
            this.PlayerTwoMoneyLable.Name = "PlayerTwoMoneyLable";
            this.PlayerTwoMoneyLable.Size = new System.Drawing.Size(109, 15);
            this.PlayerTwoMoneyLable.TabIndex = 18;
            this.PlayerTwoMoneyLable.Text = "PlayerTwoMoney";
            // 
            // PlayerTwoMoneyTextBox
            // 
            this.PlayerTwoMoneyTextBox.Location = new System.Drawing.Point(496, 270);
            this.PlayerTwoMoneyTextBox.Multiline = true;
            this.PlayerTwoMoneyTextBox.Name = "PlayerTwoMoneyTextBox";
            this.PlayerTwoMoneyTextBox.ReadOnly = true;
            this.PlayerTwoMoneyTextBox.Size = new System.Drawing.Size(95, 25);
            this.PlayerTwoMoneyTextBox.TabIndex = 17;
            // 
            // PlayerTwoHandBox
            // 
            this.PlayerTwoHandBox.Location = new System.Drawing.Point(494, 178);
            this.PlayerTwoHandBox.Multiline = true;
            this.PlayerTwoHandBox.Name = "PlayerTwoHandBox";
            this.PlayerTwoHandBox.ReadOnly = true;
            this.PlayerTwoHandBox.Size = new System.Drawing.Size(189, 34);
            this.PlayerTwoHandBox.TabIndex = 16;
            // 
            // DealFivePlayerTwoButton
            // 
            this.DealFivePlayerTwoButton.Location = new System.Drawing.Point(595, 28);
            this.DealFivePlayerTwoButton.Name = "DealFivePlayerTwoButton";
            this.DealFivePlayerTwoButton.Size = new System.Drawing.Size(140, 23);
            this.DealFivePlayerTwoButton.TabIndex = 15;
            this.DealFivePlayerTwoButton.Text = "DealFivePlayerTwo";
            this.DealFivePlayerTwoButton.UseVisualStyleBackColor = true;
            this.DealFivePlayerTwoButton.Click += new System.EventHandler(this.DealFivePlayerTwoButton_Click);
            // 
            // DealPlayerTwoButton
            // 
            this.DealPlayerTwoButton.Location = new System.Drawing.Point(595, 5);
            this.DealPlayerTwoButton.Name = "DealPlayerTwoButton";
            this.DealPlayerTwoButton.Size = new System.Drawing.Size(110, 23);
            this.DealPlayerTwoButton.TabIndex = 14;
            this.DealPlayerTwoButton.Text = "DealPlayerTwo";
            this.DealPlayerTwoButton.UseVisualStyleBackColor = true;
            this.DealPlayerTwoButton.Click += new System.EventHandler(this.DealPlayerTwoButton_Click);
            // 
            // PlayerTwoCardsTextBox
            // 
            this.PlayerTwoCardsTextBox.Location = new System.Drawing.Point(494, 55);
            this.PlayerTwoCardsTextBox.Multiline = true;
            this.PlayerTwoCardsTextBox.Name = "PlayerTwoCardsTextBox";
            this.PlayerTwoCardsTextBox.ReadOnly = true;
            this.PlayerTwoCardsTextBox.Size = new System.Drawing.Size(189, 104);
            this.PlayerTwoCardsTextBox.TabIndex = 13;
            // 
            // PlayerTwoCardsLable
            // 
            this.PlayerTwoCardsLable.AutoSize = true;
            this.PlayerTwoCardsLable.Location = new System.Drawing.Point(493, 36);
            this.PlayerTwoCardsLable.Name = "PlayerTwoCardsLable";
            this.PlayerTwoCardsLable.Size = new System.Drawing.Size(101, 15);
            this.PlayerTwoCardsLable.TabIndex = 12;
            this.PlayerTwoCardsLable.Text = "PlayerTwoCards";
            // 
            // PlayerTwoLable
            // 
            this.PlayerTwoLable.AutoSize = true;
            this.PlayerTwoLable.Location = new System.Drawing.Point(493, 9);
            this.PlayerTwoLable.Name = "PlayerTwoLable";
            this.PlayerTwoLable.Size = new System.Drawing.Size(69, 15);
            this.PlayerTwoLable.TabIndex = 11;
            this.PlayerTwoLable.Text = "PlayerTwo";
            // 
            // CommonCardsTextBox
            // 
            this.CommonCardsTextBox.Location = new System.Drawing.Point(261, 77);
            this.CommonCardsTextBox.Multiline = true;
            this.CommonCardsTextBox.Name = "CommonCardsTextBox";
            this.CommonCardsTextBox.ReadOnly = true;
            this.CommonCardsTextBox.Size = new System.Drawing.Size(189, 104);
            this.CommonCardsTextBox.TabIndex = 20;
            // 
            // CommonCardsLable
            // 
            this.CommonCardsLable.AutoSize = true;
            this.CommonCardsLable.Location = new System.Drawing.Point(258, 59);
            this.CommonCardsLable.Name = "CommonCardsLable";
            this.CommonCardsLable.Size = new System.Drawing.Size(91, 15);
            this.CommonCardsLable.TabIndex = 21;
            this.CommonCardsLable.Text = "CommonCards";
            // 
            // WinnerTextBox
            // 
            this.WinnerTextBox.Location = new System.Drawing.Point(261, 219);
            this.WinnerTextBox.Multiline = true;
            this.WinnerTextBox.Name = "WinnerTextBox";
            this.WinnerTextBox.ReadOnly = true;
            this.WinnerTextBox.Size = new System.Drawing.Size(189, 22);
            this.WinnerTextBox.TabIndex = 22;
            // 
            // DealCommonButton
            // 
            this.DealCommonButton.Location = new System.Drawing.Point(300, 34);
            this.DealCommonButton.Name = "DealCommonButton";
            this.DealCommonButton.Size = new System.Drawing.Size(110, 23);
            this.DealCommonButton.TabIndex = 23;
            this.DealCommonButton.Text = "DealCommon";
            this.DealCommonButton.UseVisualStyleBackColor = true;
            this.DealCommonButton.Click += new System.EventHandler(this.DealCommonButton_Click);
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(300, 190);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(110, 23);
            this.CompareButton.TabIndex = 24;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // ClearCommonCardsButton
            // 
            this.ClearCommonCardsButton.Location = new System.Drawing.Point(300, 252);
            this.ClearCommonCardsButton.Name = "ClearCommonCardsButton";
            this.ClearCommonCardsButton.Size = new System.Drawing.Size(150, 23);
            this.ClearCommonCardsButton.TabIndex = 25;
            this.ClearCommonCardsButton.Text = "ClearCommonCards";
            this.ClearCommonCardsButton.UseVisualStyleBackColor = true;
            this.ClearCommonCardsButton.Click += new System.EventHandler(this.ClearCommonCardsButton_Click);
            // 
            // PotTextBox
            // 
            this.PotTextBox.Location = new System.Drawing.Point(261, 317);
            this.PotTextBox.Multiline = true;
            this.PotTextBox.Name = "PotTextBox";
            this.PotTextBox.ReadOnly = true;
            this.PotTextBox.Size = new System.Drawing.Size(189, 22);
            this.PotTextBox.TabIndex = 26;
            // 
            // PotLable
            // 
            this.PotLable.AutoSize = true;
            this.PotLable.Location = new System.Drawing.Point(258, 299);
            this.PotLable.Name = "PotLable";
            this.PotLable.Size = new System.Drawing.Size(26, 15);
            this.PotLable.TabIndex = 27;
            this.PotLable.Text = "Pot";
            // 
            // PlayerOneRaiseTextBox
            // 
            this.PlayerOneRaiseTextBox.AcceptsReturn = true;
            this.PlayerOneRaiseTextBox.Location = new System.Drawing.Point(12, 376);
            this.PlayerOneRaiseTextBox.Name = "PlayerOneRaiseTextBox";
            this.PlayerOneRaiseTextBox.Size = new System.Drawing.Size(94, 25);
            this.PlayerOneRaiseTextBox.TabIndex = 28;
            this.PlayerOneRaiseTextBox.KeyDown += new KeyEventHandler(this.PlayerOneRaiseTextBox_KeyDown);
            // 
            // PlayerOneRaiseLable
            // 
            this.PlayerOneRaiseLable.AutoSize = true;
            this.PlayerOneRaiseLable.Location = new System.Drawing.Point(12, 358);
            this.PlayerOneRaiseLable.Name = "PlayerOneRaiseLable";
            this.PlayerOneRaiseLable.Size = new System.Drawing.Size(96, 15);
            this.PlayerOneRaiseLable.TabIndex = 29;
            this.PlayerOneRaiseLable.Text = "PlayerOneRaise";
            // 
            // PlayerOneCallButton
            // 
            this.PlayerOneCallButton.Location = new System.Drawing.Point(12, 302);
            this.PlayerOneCallButton.Name = "PlayerOneCallButton";
            this.PlayerOneCallButton.Size = new System.Drawing.Size(110, 23);
            this.PlayerOneCallButton.TabIndex = 30;
            this.PlayerOneCallButton.Text = "Check/Call";
            this.PlayerOneCallButton.UseVisualStyleBackColor = true;
            this.PlayerOneCallButton.Click += new System.EventHandler(this.PlayerOneCallButton_Click);
            // 
            // PlayerOneFoldButton
            // 
            this.PlayerOneFoldButton.Location = new System.Drawing.Point(12, 331);
            this.PlayerOneFoldButton.Name = "PlayerOneFoldButton";
            this.PlayerOneFoldButton.Size = new System.Drawing.Size(110, 23);
            this.PlayerOneFoldButton.TabIndex = 31;
            this.PlayerOneFoldButton.Text = "Fold";
            this.PlayerOneFoldButton.UseVisualStyleBackColor = true;
            this.PlayerOneFoldButton.Click += new System.EventHandler(this.PlayerOneFoldButton_Click);
            // 
            // BidLable
            // 
            this.BidLable.AutoSize = true;
            this.BidLable.Location = new System.Drawing.Point(258, 340);
            this.BidLable.Name = "BidLable";
            this.BidLable.Size = new System.Drawing.Size(27, 15);
            this.BidLable.TabIndex = 33;
            this.BidLable.Text = "Bid";
            // 
            // BidTextBox
            // 
            this.BidTextBox.Location = new System.Drawing.Point(261, 358);
            this.BidTextBox.Multiline = true;
            this.BidTextBox.Name = "BidTextBox";
            this.BidTextBox.ReadOnly = true;
            this.BidTextBox.Size = new System.Drawing.Size(189, 22);
            this.BidTextBox.TabIndex = 32;
            // 
            // PlayerOneBidLable
            // 
            this.PlayerOneBidLable.AutoSize = true;
            this.PlayerOneBidLable.Location = new System.Drawing.Point(12, 404);
            this.PlayerOneBidLable.Name = "PlayerOneBidLable";
            this.PlayerOneBidLable.Size = new System.Drawing.Size(27, 15);
            this.PlayerOneBidLable.TabIndex = 35;
            this.PlayerOneBidLable.Text = "Bid";
            // 
            // PlayerOneBidTextBox
            // 
            this.PlayerOneBidTextBox.Location = new System.Drawing.Point(15, 422);
            this.PlayerOneBidTextBox.Multiline = true;
            this.PlayerOneBidTextBox.Name = "PlayerOneBidTextBox";
            this.PlayerOneBidTextBox.ReadOnly = true;
            this.PlayerOneBidTextBox.Size = new System.Drawing.Size(92, 22);
            this.PlayerOneBidTextBox.TabIndex = 34;
            // 
            // PlayerTwoBidLable
            // 
            this.PlayerTwoBidLable.AutoSize = true;
            this.PlayerTwoBidLable.Location = new System.Drawing.Point(494, 404);
            this.PlayerTwoBidLable.Name = "PlayerTwoBidLable";
            this.PlayerTwoBidLable.Size = new System.Drawing.Size(27, 15);
            this.PlayerTwoBidLable.TabIndex = 41;
            this.PlayerTwoBidLable.Text = "Bid";
            // 
            // PlayerTwoBidTextBox
            // 
            this.PlayerTwoBidTextBox.Location = new System.Drawing.Point(497, 422);
            this.PlayerTwoBidTextBox.Multiline = true;
            this.PlayerTwoBidTextBox.Name = "PlayerTwoBidTextBox";
            this.PlayerTwoBidTextBox.ReadOnly = true;
            this.PlayerTwoBidTextBox.Size = new System.Drawing.Size(92, 22);
            this.PlayerTwoBidTextBox.TabIndex = 40;
            // 
            // PlayerTwoFoldButton
            // 
            this.PlayerTwoFoldButton.Location = new System.Drawing.Point(494, 331);
            this.PlayerTwoFoldButton.Name = "PlayerTwoFoldButton";
            this.PlayerTwoFoldButton.Size = new System.Drawing.Size(110, 23);
            this.PlayerTwoFoldButton.TabIndex = 39;
            this.PlayerTwoFoldButton.Text = "Fold";
            this.PlayerTwoFoldButton.UseVisualStyleBackColor = true;
            this.PlayerTwoFoldButton.Click += new System.EventHandler(this.PlayerTwoFoldButton_Click);
            // 
            // PlayerTwoCallButton
            // 
            this.PlayerTwoCallButton.Location = new System.Drawing.Point(494, 302);
            this.PlayerTwoCallButton.Name = "PlayerTwoCallButton";
            this.PlayerTwoCallButton.Size = new System.Drawing.Size(110, 23);
            this.PlayerTwoCallButton.TabIndex = 38;
            this.PlayerTwoCallButton.Text = "Check/Call";
            this.PlayerTwoCallButton.UseVisualStyleBackColor = true;
            this.PlayerTwoCallButton.Click += new System.EventHandler(this.PlayerTwoCallButton_Click);
            // 
            // PlayerTwoRaiseLable
            // 
            this.PlayerTwoRaiseLable.AutoSize = true;
            this.PlayerTwoRaiseLable.Location = new System.Drawing.Point(494, 358);
            this.PlayerTwoRaiseLable.Name = "PlayerTwoRaiseLable";
            this.PlayerTwoRaiseLable.Size = new System.Drawing.Size(99, 15);
            this.PlayerTwoRaiseLable.TabIndex = 37;
            this.PlayerTwoRaiseLable.Text = "PlayerTwoRaise";
            // 
            // PlayerTwoRaiseTextBox
            // 
            this.PlayerTwoRaiseTextBox.AcceptsReturn = true;
            this.PlayerTwoRaiseTextBox.Location = new System.Drawing.Point(494, 376);
            this.PlayerTwoRaiseTextBox.Name = "PlayerTwoRaiseTextBox";
            this.PlayerTwoRaiseTextBox.Size = new System.Drawing.Size(94, 25);
            this.PlayerTwoRaiseTextBox.TabIndex = 36;
            this.PlayerTwoRaiseTextBox.KeyDown += new KeyEventHandler(this.PlayerTwoRaiseTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerTwoBidLable);
            this.Controls.Add(this.PlayerTwoBidTextBox);
            this.Controls.Add(this.PlayerTwoFoldButton);
            this.Controls.Add(this.PlayerTwoCallButton);
            this.Controls.Add(this.PlayerTwoRaiseLable);
            this.Controls.Add(this.PlayerTwoRaiseTextBox);
            this.Controls.Add(this.PlayerOneBidLable);
            this.Controls.Add(this.PlayerOneBidTextBox);
            this.Controls.Add(this.BidLable);
            this.Controls.Add(this.BidTextBox);
            this.Controls.Add(this.PlayerOneFoldButton);
            this.Controls.Add(this.PlayerOneCallButton);
            this.Controls.Add(this.PlayerOneRaiseLable);
            this.Controls.Add(this.PlayerOneRaiseTextBox);
            this.Controls.Add(this.PotLable);
            this.Controls.Add(this.PotTextBox);
            this.Controls.Add(this.ClearCommonCardsButton);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.DealCommonButton);
            this.Controls.Add(this.WinnerTextBox);
            this.Controls.Add(this.CommonCardsLable);
            this.Controls.Add(this.CommonCardsTextBox);
            this.Controls.Add(this.ClearPlayerTwoHandButton);
            this.Controls.Add(this.PlayerTwoMoneyLable);
            this.Controls.Add(this.PlayerTwoMoneyTextBox);
            this.Controls.Add(this.PlayerTwoHandBox);
            this.Controls.Add(this.DealFivePlayerTwoButton);
            this.Controls.Add(this.DealPlayerTwoButton);
            this.Controls.Add(this.PlayerTwoCardsTextBox);
            this.Controls.Add(this.PlayerTwoCardsLable);
            this.Controls.Add(this.PlayerTwoLable);
            this.Controls.Add(this.NewDeckButton);
            this.Controls.Add(this.ClearPlayerOneHandButton);
            this.Controls.Add(this.PlayerOneMoneyLable);
            this.Controls.Add(this.PlayerOneMoneyTextBox);
            this.Controls.Add(this.PlayerOneHandBox);
            this.Controls.Add(this.DealFivePlayerOneButton);
            this.Controls.Add(this.DealPlayerOneButton);
            this.Controls.Add(this.PlayerOneCardsTextBox);
            this.Controls.Add(this.PlayerOneCardsLable);
            this.Controls.Add(this.PlayerOneLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerOneLable;
        private System.Windows.Forms.Label PlayerOneCardsLable;
        private System.Windows.Forms.Button DealPlayerOneButton;
        private System.Windows.Forms.Button DealFivePlayerOneButton;
        private System.Windows.Forms.TextBox PlayerOneCardsTextBox;
        private System.Windows.Forms.TextBox PlayerOneHandBox;
        private System.Windows.Forms.TextBox PlayerOneMoneyTextBox;
        private System.Windows.Forms.Label PlayerOneMoneyLable;
        private System.Windows.Forms.Button ClearPlayerOneHandButton;
        private System.Windows.Forms.Button NewDeckButton;
        private System.Windows.Forms.Button ClearPlayerTwoHandButton;
        private System.Windows.Forms.Label PlayerTwoMoneyLable;
        private System.Windows.Forms.TextBox PlayerTwoMoneyTextBox;
        private System.Windows.Forms.TextBox PlayerTwoHandBox;
        private System.Windows.Forms.Button DealFivePlayerTwoButton;
        private System.Windows.Forms.Button DealPlayerTwoButton;
        private System.Windows.Forms.TextBox PlayerTwoCardsTextBox;
        private System.Windows.Forms.Label PlayerTwoCardsLable;
        private System.Windows.Forms.Label PlayerTwoLable;
        private System.Windows.Forms.TextBox CommonCardsTextBox;
        private System.Windows.Forms.Label CommonCardsLable;
        private System.Windows.Forms.TextBox WinnerTextBox;
        private System.Windows.Forms.Button DealCommonButton;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button ClearCommonCardsButton;
        private System.Windows.Forms.TextBox PotTextBox;
        private System.Windows.Forms.Label PotLable;
        private System.Windows.Forms.TextBox PlayerOneRaiseTextBox;
        private System.Windows.Forms.Label PlayerOneRaiseLable;
        private System.Windows.Forms.Button PlayerOneCallButton;
        private System.Windows.Forms.Button PlayerOneFoldButton;
        private System.Windows.Forms.Label BidLable;
        private System.Windows.Forms.TextBox BidTextBox;
        private System.Windows.Forms.Label PlayerOneBidLable;
        private System.Windows.Forms.TextBox PlayerOneBidTextBox;
        private System.Windows.Forms.Label PlayerTwoBidLable;
        private System.Windows.Forms.TextBox PlayerTwoBidTextBox;
        private System.Windows.Forms.Button PlayerTwoFoldButton;
        private System.Windows.Forms.Button PlayerTwoCallButton;
        private System.Windows.Forms.Label PlayerTwoRaiseLable;
        private System.Windows.Forms.TextBox PlayerTwoRaiseTextBox;
    }
}

