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
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(653, 604);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(153, 80);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // player1HandLabel
            // 
            this.player1HandLabel.AutoSize = true;
            this.player1HandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1HandLabel.Location = new System.Drawing.Point(51, 55);
            this.player1HandLabel.Name = "player1HandLabel";
            this.player1HandLabel.Size = new System.Drawing.Size(420, 63);
            this.player1HandLabel.TabIndex = 1;
            this.player1HandLabel.Text = "Player 1\'s Hand:";
            // 
            // player2HandLabel
            // 
            this.player2HandLabel.AutoSize = true;
            this.player2HandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2HandLabel.Location = new System.Drawing.Point(51, 267);
            this.player2HandLabel.Name = "player2HandLabel";
            this.player2HandLabel.Size = new System.Drawing.Size(420, 63);
            this.player2HandLabel.TabIndex = 2;
            this.player2HandLabel.Text = "Player 2\'s Hand:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 753);
            this.Controls.Add(this.player2HandLabel);
            this.Controls.Add(this.player1HandLabel);
            this.Controls.Add(this.dealButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label player1HandLabel;
        private System.Windows.Forms.Label player2HandLabel;
    }
}

