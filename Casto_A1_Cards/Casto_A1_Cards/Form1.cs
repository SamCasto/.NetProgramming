using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_A1_Cards
{
    public partial class cardIdentifier : Form
    {
        public cardIdentifier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void diamondKing_Click(object sender, EventArgs e)
        {
            //changing the label to the name of the card
            cardNameLabel.Text = "The King of Diamonds";
        }

        private void spadeAce_Click(object sender, EventArgs e)
        {
            //changing the label to the name of the card
            cardNameLabel.Text = "The Ace of Spades";
        }

        private void clubThree_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "The Three of Clubs";
        }

        private void diamondSeven_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "The Seven of Diamonds";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void heartNine_Click(object sender, EventArgs e)
        {
            //this is at the bottom because I ran into an issue of the updated
            //picture control name not updating in the code and causing errors
            cardNameLabel.Text = "The Nine of Hearts";
        }
    }
}
