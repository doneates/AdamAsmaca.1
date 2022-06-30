using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdamAsmaca._1
{
    public partial class FrmMain : Form
    {
        string target;
        char guess;
        int tries;
        bool hit = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void randomWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKelimeler w1 = new FrmKelimeler();
            if (w1.ShowDialog() == DialogResult.OK)
            {
                target = FrmKelimeler.path;
            }
            MessageBox.Show(target);
            Setting();
        }

        private void Setting()
        {
            label3.Text = "";
            for (int i = 0; i < target.Length; i++)
            {
                label3.Text = label3.Text.Insert(i, "*");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guess = textBox1.Text[0];
            for (int i = 0; i < target.Length; i++)
            {
                if (Char.ToUpper(target[i]) == Char.ToUpper(guess))
                {
                    hit = true;
                    label3.Text = label3.Text.Remove(i, 1);
                    label3.Text = label3.Text.Insert(i, guess.ToString());
                }
            }

            if (label3.Text.ToUpper() == target.ToUpper())
            {
                WonGame();
            }

            if (!hit)
            {
                tries++;
                switch (tries)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/2.png");
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/3.png");
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/4.png");
                        break;
                    case 4:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/5.png");
                        break;
                    case 5:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/6.png");
                        break;
                    case 6:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/7.png");
                        break;
                    case 7:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/8.png");
                        break;
                    case 8:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/9.png");
                        break;
                    case 9:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/10.png");
                        break;
                    case 10:
                        pictureBox1.Image = Image.FromFile("C:/Users/FDEIT008/Desktop/AdamAsmaca.1/Images/11.png");
                        LostGame();
                        break;

                }
            }
            hit = false;
            textBox1.Focus();
            textBox1.SelectAll();
        }
        private void LostGame()
        {
            MessageBox.Show("You Lost! Secret word was " + target);
            ResetGame();
        }
        private void WonGame()
        {
            MessageBox.Show("You Won! Secret word was " + target);
            ResetGame();
        }
        private void ResetGame()
        {
            textBox1.Text = "";
            label3.Text = "Secret Word";
            target = "";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
