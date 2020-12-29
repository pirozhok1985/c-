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
        public static string fileName;
        TrueFalse game;
        int index;
        int Count = 0;
        Random rand = new Random();
        public event Action Handler;
        public Form1()
        {
            InitializeComponent();
            bTrue.Enabled = false;
            bFalse.Enabled = false;
            tsbNext.Enabled = false;
            tsbPrev.Enabled = false;
            openFileDialog1.Filter = "Xml files (*.xml)|*.xml";
            Handler += displayQuestion;
        }
        private void endGame()
        {
            MessageBox.Show(String.Format("Игра окончена, колечество првельных ответов {0}", Count));
            this.Close();
        }
        private void displayQuestion()
        {
            if (game.Count > 0)
            {
                index = rand.Next(0, game.Count - 1);
                lQuestion.Text = game[index].Text;
            }
            else
            {
                endGame();
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            game = new TrueFalse(openFileDialog1.FileName);
            game.Load();
            bTrue.Enabled = true;
            bFalse.Enabled = true;
            tsbNext.Enabled = true;
            tsbPrev.Enabled = true;
            Handler?.Invoke();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            NewQADB form = new NewQADB();
            try
            {
                form.ShowDialog();
                game = new TrueFalse(fileName);
                game.Load();
                bTrue.Enabled = true;
                bFalse.Enabled = true;
                tsbNext.Enabled = true;
                tsbPrev.Enabled = true;
                Handler?.Invoke();
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }

        private void tsbNewGame_Click(object sender, EventArgs e)
        {
            tsmiNewGame_Click(sender, e);
        }

        private void tsmbExit_Click(object sender, EventArgs e)
        {
            tsmiExit_Click(sender, e);
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            tsmiOpen_Click(sender, e);
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if ((index + 1) < game.Count) index += 1;
            lQuestion.Text = game[index].Text;
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            if ((index - 1) > 0) index -= 1;
            lQuestion.Text = game[index].Text;
        }

        private void bTrue_Click(object sender, EventArgs e)
        {
            if (game[index].TrueFalse == true) Count++;
            game.Remove(index);
            Handler?.Invoke();
        }

        private void bFalse_Click(object sender, EventArgs e)
        {
            if (game[index].TrueFalse == false) Count++;
            game.Remove(index);
            Handler?.Invoke();
        }
    }
}
