namespace Card_Guesser_3000
{
    partial class frmtutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtutorial));
            this.tutTitle = new System.Windows.Forms.Label();
            this.tutDialog = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tutTitle
            // 
            this.tutTitle.AutoSize = true;
            this.tutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutTitle.Location = new System.Drawing.Point(89, 9);
            this.tutTitle.Name = "tutTitle";
            this.tutTitle.Size = new System.Drawing.Size(403, 37);
            this.tutTitle.TabIndex = 0;
            this.tutTitle.Text = "Welcome to Card Guesser!";
            // 
            // tutDialog
            // 
            this.tutDialog.AutoSize = true;
            this.tutDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutDialog.Location = new System.Drawing.Point(60, 75);
            this.tutDialog.Name = "tutDialog";
            this.tutDialog.Size = new System.Drawing.Size(465, 120);
            this.tutDialog.TabIndex = 1;
            this.tutDialog.Text = resources.GetString("tutDialog.Text");
            this.tutDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(165, 217);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Let\'s get started!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmtutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 373);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tutDialog);
            this.Controls.Add(this.tutTitle);
            this.Name = "frmtutorial";
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutTitle;
        private System.Windows.Forms.Label tutDialog;
        private System.Windows.Forms.Button btnStart;
    }
}