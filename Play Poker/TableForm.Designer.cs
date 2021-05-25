
namespace Play_Poker
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(12, 39);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 0;
            this.AddPlayerButton.Text = "AddPlayer";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // AddPlayerTextBox
            // 
            this.AddPlayerTextBox.Location = new System.Drawing.Point(13, 13);
            this.AddPlayerTextBox.Name = "AddPlayerTextBox";
            this.AddPlayerTextBox.Size = new System.Drawing.Size(100, 25);
            this.AddPlayerTextBox.TabIndex = 1;
            this.AddPlayerTextBox.Text = "Name";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPlayerTextBox);
            this.Controls.Add(this.AddPlayerButton);
            this.Name = "TableForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.TextBox AddPlayerTextBox;
    }
}