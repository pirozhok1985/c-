using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        GuessNum number;
        int value;

        public Form1()
        {
            InitializeComponent();
            tbNumber.TextChanged += tb1_TextChanged;
            if (number == null) 
            { 
                tbNumber.Enabled = false;
                btnOK.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbNumber.Text, out value);
        }

        private void tsmNewGame_Click(object sender, EventArgs e)
        {
            number = new GuessNum();
            tbNumber.Enabled = true;
            btnOK.Enabled = true;
            btnReset.Enabled = true;
            lblTries.Text = number.Tries.ToString();
            tbNumber.Text = null;
            lblResult.Text = null;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            number.Compare(value);
            lblResult.Text = number.Result;
            StatusUpdate();
            if (lblTries.Text == 0.ToString()) 
            {
                tbNumber.Enabled = false;
                btnOK.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbNumber.Enabled = true;
            tbNumber.Text = null;
            btnOK.Enabled = true;
            number = new GuessNum();
            StatusUpdate();
        }
        void StatusUpdate()
        {
            lblResult.Text = number.Result;
            lblTries.Text = number.Tries.ToString();
        }
    }
}
