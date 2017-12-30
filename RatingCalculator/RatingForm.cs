using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AoM.ESO
{
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            InitializeComponent();  
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tbWinner.Text == "" || tbLoser.Text == "")
                return;
            var winner = new Rating(double.Parse(tbWinner.Text));
            var loser = new Rating(double.Parse(tbLoser.Text));
            var result = Rating.Match(winner, loser);
            tbWinnerNew.Text = "" + result.Winner.Rate;
            tbLoserNew.Text = "" + result.Loser.Rate;
        }

        private void tbRate_Validating(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            double value;
            var success = double.TryParse(textBox.Text, out value);
            if(!success)
            {
                MessageBox.Show("Enter a correct numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
