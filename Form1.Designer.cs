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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.betDialog = new System.Windows.Forms.GroupBox();
            this.inputBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.lblWager = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.betDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.betDialog);
            this.panel1.Controls.Add(this.card3);
            this.panel1.Controls.Add(this.card2);
            this.panel1.Controls.Add(this.card1);
            this.panel1.Location = new System.Drawing.Point(37, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 320);
            this.panel1.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(247, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 37);
            this.title.TabIndex = 2;
            this.title.Text = "Card Guesser 3000";
            // 
            // betDialog
            // 
            this.betDialog.Controls.Add(this.lblBalance1);
            this.betDialog.Controls.Add(this.lblBet);
            this.betDialog.Controls.Add(this.btnBet);
            this.betDialog.Controls.Add(this.inputBet);
            this.betDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betDialog.Location = new System.Drawing.Point(217, 42);
            this.betDialog.Name = "betDialog";
            this.betDialog.Size = new System.Drawing.Size(290, 236);
            this.betDialog.TabIndex = 3;
            this.betDialog.TabStop = false;
            this.betDialog.Text = "Place a bet";
            // 
            // inputBet
            // 
            this.inputBet.Location = new System.Drawing.Point(6, 83);
            this.inputBet.Name = "inputBet";
            this.inputBet.Size = new System.Drawing.Size(100, 35);
            this.inputBet.TabIndex = 0;
            this.inputBet.TextChanged += new System.EventHandler(this.inputBet_TextChanged);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(65, 150);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(139, 57);
            this.btnBet.TabIndex = 1;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
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
            // lblBalance2
            // 
            this.lblBalance2.AutoSize = true;
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
            this.lblWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWager.Location = new System.Drawing.Point(498, 57);
            this.lblWager.Name = "lblWager";
            this.lblWager.Size = new System.Drawing.Size(154, 29);
            this.lblWager.TabIndex = 4;
            this.lblWager.Text = "Wager: 0.00$";
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
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.White;
            this.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(351, 76);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(63, 28);
            this.lblPlay.TabIndex = 6;
            this.lblPlay.Text = "Play!";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblWager);
            this.Controls.Add(this.lblBalance2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Card Guesser 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.betDialog.ResumeLayout(false);
            this.betDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
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
    }
}

