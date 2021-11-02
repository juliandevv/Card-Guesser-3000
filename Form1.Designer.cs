namespace Card_Guesser_3000
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultDialog = new System.Windows.Forms.GroupBox();
            this.quit = new System.Windows.Forms.Label();
            this.lblNoMoney = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.betDialog = new System.Windows.Forms.GroupBox();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.inputBet = new System.Windows.Forms.TextBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.lblWager = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPickPrompt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.resultDialog.SuspendLayout();
            this.betDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultDialog);
            this.panel1.Controls.Add(this.betDialog);
            this.panel1.Controls.Add(this.card3);
            this.panel1.Controls.Add(this.card2);
            this.panel1.Controls.Add(this.card1);
            this.panel1.Location = new System.Drawing.Point(37, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 320);
            this.panel1.TabIndex = 1;
            // 
            // resultDialog
            // 
            this.resultDialog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultDialog.BackColor = System.Drawing.Color.MistyRose;
            this.resultDialog.Controls.Add(this.quit);
            this.resultDialog.Controls.Add(this.lblNoMoney);
            this.resultDialog.Controls.Add(this.btnPlayAgain);
            this.resultDialog.Controls.Add(this.lblResult);
            this.resultDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDialog.Location = new System.Drawing.Point(217, 31);
            this.resultDialog.Name = "resultDialog";
            this.resultDialog.Size = new System.Drawing.Size(290, 236);
            this.resultDialog.TabIndex = 4;
            this.resultDialog.TabStop = false;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(103, 125);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(57, 29);
            this.quit.TabIndex = 11;
            this.quit.Text = "Quit";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // lblNoMoney
            // 
            this.lblNoMoney.AutoSize = true;
            this.lblNoMoney.Location = new System.Drawing.Point(20, 84);
            this.lblNoMoney.Name = "lblNoMoney";
            this.lblNoMoney.Size = new System.Drawing.Size(245, 29);
            this.lblNoMoney.TabIndex = 10;
            this.lblNoMoney.Text = "You ran out of money!";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AutoSize = true;
            this.btnPlayAgain.Location = new System.Drawing.Point(73, 125);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(132, 29);
            this.btnPlayAgain.TabIndex = 9;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(25, 31);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(232, 57);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "You Lost!";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // betDialog
            // 
            this.betDialog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.betDialog.Controls.Add(this.lblBalance1);
            this.betDialog.Controls.Add(this.lblBet);
            this.betDialog.Controls.Add(this.btnBet);
            this.betDialog.Controls.Add(this.inputBet);
            this.betDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betDialog.Location = new System.Drawing.Point(217, 25);
            this.betDialog.Name = "betDialog";
            this.betDialog.Size = new System.Drawing.Size(290, 236);
            this.betDialog.TabIndex = 3;
            this.betDialog.TabStop = false;
            this.betDialog.Text = "Place a bet";
            // 
            // lblBalance1
            // 
            this.lblBalance1.AutoSize = true;
            this.lblBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance1.Location = new System.Drawing.Point(6, 41);
            this.lblBalance1.Name = "lblBalance1";
            this.lblBalance1.Size = new System.Drawing.Size(255, 29);
            this.lblBalance1.TabIndex = 3;
            this.lblBalance1.Text = "Current Balance: 0.00$";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(117, 83);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(87, 32);
            this.lblBet.TabIndex = 2;
            this.lblBet.Text = "0.00$";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.SeaShell;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBet.Location = new System.Drawing.Point(65, 150);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(139, 57);
            this.btnBet.TabIndex = 1;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            this.btnBet.MouseEnter += new System.EventHandler(this.btnBet_MouseEnter);
            this.btnBet.MouseLeave += new System.EventHandler(this.btnBet_MouseLeave);
            // 
            // inputBet
            // 
            this.inputBet.Location = new System.Drawing.Point(6, 83);
            this.inputBet.Name = "inputBet";
            this.inputBet.Size = new System.Drawing.Size(100, 35);
            this.inputBet.TabIndex = 0;
            this.inputBet.TextChanged += new System.EventHandler(this.inputBet_TextChanged);
            // 
            // card3
            // 
            this.card3.Image = global::Card_Guesser_3000.Properties.Resources._1200px_Playing_card_spade_3_svg;
            this.card3.Location = new System.Drawing.Point(481, 3);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(233, 314);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card3_Click);
            // 
            // card2
            // 
            this.card2.Image = global::Card_Guesser_3000.Properties.Resources._1200px_Playing_card_heart_A_svg;
            this.card2.Location = new System.Drawing.Point(242, 3);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(233, 314);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card2_Click);
            // 
            // card1
            // 
            this.card1.Image = global::Card_Guesser_3000.Properties.Resources._1200px_Playing_card_spade_2_svg;
            this.card1.Location = new System.Drawing.Point(3, 3);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(233, 314);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.SeaShell;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(247, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 37);
            this.title.TabIndex = 2;
            this.title.Text = "Card Guesser 3000";
            // 
            // lblBalance2
            // 
            this.lblBalance2.AutoSize = true;
            this.lblBalance2.BackColor = System.Drawing.Color.SeaShell;
            this.lblBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance2.Location = new System.Drawing.Point(96, 57);
            this.lblBalance2.Name = "lblBalance2";
            this.lblBalance2.Size = new System.Drawing.Size(170, 29);
            this.lblBalance2.TabIndex = 3;
            this.lblBalance2.Text = "Balance: 0.00$";
            // 
            // lblWager
            // 
            this.lblWager.AutoSize = true;
            this.lblWager.BackColor = System.Drawing.Color.SeaShell;
            this.lblWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWager.Location = new System.Drawing.Point(498, 57);
            this.lblWager.Name = "lblWager";
            this.lblWager.Size = new System.Drawing.Size(154, 29);
            this.lblWager.TabIndex = 4;
            this.lblWager.Text = "Wager: 0.00$";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Salmon;
            this.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(351, 76);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(63, 28);
            this.lblPlay.TabIndex = 6;
            this.lblPlay.Text = "Play!";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // error1
            // 
            this.error1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error1.ContainerControl = this;
            // 
            // lblPickPrompt
            // 
            this.lblPickPrompt.AutoSize = true;
            this.lblPickPrompt.BackColor = System.Drawing.Color.Salmon;
            this.lblPickPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickPrompt.Location = new System.Drawing.Point(303, 53);
            this.lblPickPrompt.Name = "lblPickPrompt";
            this.lblPickPrompt.Size = new System.Drawing.Size(176, 36);
            this.lblPickPrompt.TabIndex = 7;
            this.lblPickPrompt.Text = "Pick a Card!";
            this.lblPickPrompt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPickPrompt);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblWager);
            this.Controls.Add(this.lblBalance2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Guesser 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.resultDialog.ResumeLayout(false);
            this.resultDialog.PerformLayout();
            this.betDialog.ResumeLayout(false);
            this.betDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox betDialog;
        private System.Windows.Forms.Label lblBalance1;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox inputBet;
        private System.Windows.Forms.Label lblBalance2;
        private System.Windows.Forms.Label lblWager;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPickPrompt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox resultDialog;
        private System.Windows.Forms.Label btnPlayAgain;
        private System.Windows.Forms.Label lblNoMoney;
        private System.Windows.Forms.Label quit;
    }
}

