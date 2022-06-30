using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca._1
{
    public partial class FrmKelimeler : Form
    {
        Random r = new Random();
        public static string path;
        string word;
        int sayi;
        public FrmKelimeler()
        {

            InitializeComponent();
            sayi = r.Next(5, 20);
            numericUpDown1.Value = sayi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                if (numericUpDown1.Value != textBox2.Text.Length)
                {
                    MessageBox.Show("Geçerli harf sayısı kadar harf giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    path = string.Empty;

                }
                else
                {
                    path = textBox2.Text;
                }
                this.Close();
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
