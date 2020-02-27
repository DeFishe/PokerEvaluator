using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerEvaluator
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void dealButton_Click(object sender, EventArgs e)
        {
            Dealer dealer = new Dealer();
            p1Hand.Text = "";
            foreach (Card item in dealer.P1Hand.cards)
            {
                p1Hand.Text += item.Unicode;
            }
            p2Label.Text = "";
            foreach (Card item in dealer.P2Hand.cards)
            {
                p2Label.Text += item.Unicode;
            }
            if (dealer.Evaluate())
            {
                winnerLabel.Text = "Winner: Player 1";
            }
            else
                winnerLabel.Text = "Winner: Player 2";
        }
    }
}
