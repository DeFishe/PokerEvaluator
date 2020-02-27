using System;
using System.Windows.Forms;

namespace PokerEvaluator
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void dealButton_Click(object sender, EventArgs e)
        {
            Dealer dealer = new Dealer(); //sets up a new dealer
            p1Hand.Text = ""; //resets hand
            foreach (Card item in dealer.P1Hand.cards) //displays hand
            {
                p1Hand.Text += item.Unicode;
            }
            p2Label.Text = ""; //resets hand
            foreach (Card item in dealer.P2Hand.cards) //displays hand
            {
                p2Label.Text += item.Unicode;
            }
            if (dealer.Evaluate()) //checks winner and displays
            {
                winnerLabel.Text = "Winner: Player 1";
            }
            else
                winnerLabel.Text = "Winner: Player 2";
        }
    }
}
