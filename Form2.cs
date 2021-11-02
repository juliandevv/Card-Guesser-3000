using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Guesser_3000
{
    public partial class frmtutorial : Form
    {
        public frmtutorial()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.SeaShell;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Salmon;
        }
    }
}
