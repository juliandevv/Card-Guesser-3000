using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Card_Guesser_3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare variables
        int bet, balance;

        private void inputBet_TextChanged(object sender, EventArgs e)
        {
            //display bet, catch format exceptions
            error1.Clear();
            try
            {
                bet = Convert.ToInt32(inputBet.Text);
                lblBet.Text = bet.ToString("c");
            }

            catch
            {
                bet = 0;
                lblBet.Text = bet.ToString("c");
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //finish bet
            if (bet <= 0)
            {
                error1.SetError(inputBet, "That is not a valid bet!");
            }

            else
            {
                lblWager.Text = "Wager: " + bet.ToString("c");
                betDialog.Visible = false;
            }
        }
        
        private void lblPlay_Click(object sender, EventArgs e)
        {
            //start timer
            timer1.Start();
            //flip cards over
            card1.Image = Properties.Resources.Card_Back;
            card2.Image = Properties.Resources.Card_Back;
            card3.Image = Properties.Resources.Card_Back;

            //work on animation here 
            //int startTime = Convert.ToInt32(DateTime.Now);
            ///Debug.WriteLine(startTime);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //show tutorial
            frmtutorial frmtutorial = new frmtutorial();
            frmtutorial.ShowDialog();
            //set initial balance
            balance = 100;
            lblBalance2.Text = "Balance: " + balance.ToString("c");
            lblBalance1.Text = "Balance: " + balance.ToString("c");
        }
    }
}
