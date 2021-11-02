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
using System.Timers;

namespace Card_Guesser_3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Visible = false;
            lblPickPrompt.Visible = false;
            resultDialog.Visible = false;
            lblNoMoney.Visible = false;
            quit.Visible = false;

        }

        //declare variables
        int bet, balance, answer;
        bool guess = false;
        

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

            else if (bet > balance)
            {
                error1.SetError(inputBet, "You don't have enough money for that!");
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
            //timer1.Start();
            //flip cards over
            card1.Image = Properties.Resources.Card_Back;
            card2.Image = Properties.Resources.Card_Back;
            card3.Image = Properties.Resources.Card_Back;

            lblPickPrompt.Visible = true;
            lblPlay.Visible = false;
            guess = true;
        }

        private void card1_Click(object sender, EventArgs e)
        {
            if (guess == true)
            {
                Random generator = new Random();
                int randNum = generator.Next(1, 4);
                if (randNum == 1)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    answer = 1;
                    guess = false;
                }
                else if (randNum == 2)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    answer = 2;
                    guess = false;
                }
                else if (randNum == 3)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    answer = 3;
                    guess = false;
                }

                lblResult.Visible = true;
                lblPickPrompt.Visible = false;
                if (answer == 1)
                {
                    lblResult.Text = "You Won!";
                    balance += bet;
                }
                else
                {
                    lblResult.Text = "You Lose!";
                    balance -= bet;
                }
                lblBalance2.Text = "Balance: " + balance.ToString("c");
                lblBalance1.Text = "Balance: " + balance.ToString("c");
                resultDialog.Visible = true;
                lblPlay.Visible = true;
            }

            

        }

        private void card2_Click(object sender, EventArgs e)
        {
            if (guess == true)
            {
                Random generator = new Random();
                int randNum = generator.Next(1, 4);
                if (randNum == 1)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    answer = 1;
                    guess = false;
                }
                else if (randNum == 2)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    answer = 2;
                    guess = false;
                }
                else if (randNum == 3)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    answer = 3;
                    guess = false;
                }

                lblResult.Visible = true;
                lblPickPrompt.Visible = false;
                if (answer == 2)
                {
                    lblResult.Text = "You Won!";
                    balance += bet;
                }
                else
                {
                    lblResult.Text = "You Lose!";
                    balance -= bet;
                }
                lblBalance2.Text = "Balance: " + balance.ToString("c");
                lblBalance1.Text = "Balance: " + balance.ToString("c");
                resultDialog.Visible = true;
                lblPlay.Visible = true;
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            

            //out of money
            if (balance == 0)
            {
                quit.Visible = true;
                btnPlayAgain.Visible = false;
                lblNoMoney.Visible = true;
                
            }

            else
            {
                quit.Visible = false;
                btnPlayAgain.Visible = true;
                btnPlayAgain.Text = "Play again";
                betDialog.Visible = true;
                resultDialog.Visible = false;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBet_MouseEnter(object sender, EventArgs e)
        {
            btnBet.BackColor = Color.Salmon;
        }

        private void btnBet_MouseLeave(object sender, EventArgs e)
        {
            btnBet.BackColor = Color.SeaShell;
        }

        private void card3_Click(object sender, EventArgs e)
        {
            if (guess == true)
            {
                Random generator = new Random();
                int randNum = generator.Next(1, 4);
                if (randNum == 1)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    answer = 1;
                    guess = false;
                }
                else if (randNum == 2)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    answer = 2;
                    guess = false;
                }
                else if (randNum == 3)
                {
                    card1.Image = Properties.Resources._1200px_Playing_card_spade_2_svg;
                    card2.Image = Properties.Resources._1200px_Playing_card_spade_3_svg;
                    card3.Image = Properties.Resources._1200px_Playing_card_heart_A_svg;
                    answer = 3;
                    guess = false;
                }

                lblResult.Visible = true;
                lblPickPrompt.Visible = false;
                if (answer == 3)
                {
                    lblResult.Text = "You Won!";
                    balance += bet;
                }
                else
                {
                    lblResult.Text = "You Lose!";
                    balance -= bet;
                }
                lblBalance2.Text = "Balance: " + balance.ToString("c");
                lblBalance1.Text = "Balance: " + balance.ToString("c");
                resultDialog.Visible = true;
                lblPlay.Visible = true;
            }
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
            //bet dialog location
            betDialog.Location = new Point(217, 42);
            resultDialog.Location = new Point(217, 42);
            //hide labels
            //lblResult.Visible = false;
            //lblPickPrompt.Visible = false;
        }
    }
}
