namespace PokerEvaluator
{
    partial class MainForm
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
            this.dealButton = new System.Windows.Forms.Button();
            this.player1HandLabel = new System.Windows.Forms.Label();
            this.player2HandLabel = new System.Windows.Forms.Label();
            this.hand1Label = new System.Windows.Forms.Label();
            this.p1Hand = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(230, 201);
            this.dealButton.Margin = new System.Windows.Forms.Padding(2);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(65, 30);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // player1HandLabel
            // 
            this.player1HandLabel.AutoSize = true;
            this.player1HandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1HandLabel.Location = new System.Drawing.Point(8, 7);
            this.player1HandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1HandLabel.Name = "player1HandLabel";
            this.player1HandLabel.Size = new System.Drawing.Size(212, 31);
            this.player1HandLabel.TabIndex = 1;
            this.player1HandLabel.Text = "Player 1\'s Hand:";
            // 
            // player2HandLabel
            // 
            this.player2HandLabel.AutoSize = true;
            this.player2HandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2HandLabel.Location = new System.Drawing.Point(8, 199);
            this.player2HandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2HandLabel.Name = "player2HandLabel";
            this.player2HandLabel.Size = new System.Drawing.Size(212, 31);
            this.player2HandLabel.TabIndex = 2;
            this.player2HandLabel.Text = "Player 2\'s Hand:";
            // 
            // hand1Label
            // 
            this.hand1Label.AutoSize = true;
            this.hand1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hand1Label.Location = new System.Drawing.Point(132, 88);
            this.hand1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hand1Label.Name = "hand1Label";
            this.hand1Label.Size = new System.Drawing.Size(0, 302);
            this.hand1Label.TabIndex = 3;
            // 
            // p1Hand
            // 
            this.p1Hand.AutoSize = true;
            this.p1Hand.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Hand.Location = new System.Drawing.Point(9, 39);
            this.p1Hand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1Hand.Name = "p1Hand";
            this.p1Hand.Size = new System.Drawing.Size(0, 153);
            this.p1Hand.TabIndex = 5;
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Label.Location = new System.Drawing.Point(9, 241);
            this.p2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(0, 153);
            this.p2Label.TabIndex = 6;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(210, 7);
            this.winnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(114, 31);
            this.winnerLabel.TabIndex = 7;
            this.winnerLabel.Text = "Winner:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 392);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1Hand);
            this.Controls.Add(this.hand1Label);
            this.Controls.Add(this.player2HandLabel);
            this.Controls.Add(this.player1HandLabel);
            this.Controls.Add(this.dealButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label player1HandLabel;
        private System.Windows.Forms.Label player2HandLabel;
        private System.Windows.Forms.Label hand1Label;
        private System.Windows.Forms.Label p1Hand;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label winnerLabel;
    }
}

