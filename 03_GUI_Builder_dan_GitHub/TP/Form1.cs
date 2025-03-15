using System;
using System.Drawing;
using System.Windows.Forms;

namespace tpmodul_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(nama) && nama != "Masukkan Nama Kamu")
            {
                label2.Text = "Halo " + nama;
                label2.Visible = true;  // Tampilkan output setelah input diberikan
            }
            else
            {
                MessageBox.Show("Silakan masukkan nama terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
