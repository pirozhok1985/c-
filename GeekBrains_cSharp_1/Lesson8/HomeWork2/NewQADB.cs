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
    public partial class NewQADB : Form
    {
        string text;
        bool answer;
        TrueFalse obj;
        public NewQADB()
        {
            InitializeComponent();
            //tbQuestion.TextChanged += tbQuestion_TextChanged;
            //bAdd.Click += bAdd_Click;
            saveFileDialog1.Filter = "xml file (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) this.Close();
            Form1.fileName = saveFileDialog1.FileName;
            obj = new TrueFalse(Form1.fileName);
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            text = tbQuestion.Text;
        }

        private void bTrue_Click(object sender, EventArgs e)
        {
            bTrue.Enabled = false;
            bFalse.Enabled = true;
            answer = true;
        }

        private void bFalse_Click(object sender, EventArgs e)
        {
            bTrue.Enabled = true;
            bFalse.Enabled = false;
            answer = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            obj.Add(text,answer);
            tbQuestion.Text = null;
            bTrue.Enabled = true;
            bFalse.Enabled = true;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            obj.Save();
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
