using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private double angka1 = 0;
        private string operasi = "";
        private bool mulaiBaru = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void AngkaDitekan(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (mulaiBaru)
                labelHasil.Text = btn.Text;
            else
                labelHasil.Text += btn.Text;

            mulaiBaru = false;
        }

        private void OperasiDitekan(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(labelHasil.Text))
            {
                angka1 = double.Parse(labelHasil.Text);
                operasi = btn.Text;
                labelHasil.Text += " " + operasi + " ";
                mulaiBaru = false;
            }
        }

        private void SamaDenganDitekan(object sender, EventArgs e)
        {
            try
            {
                string[] bagian = labelHasil.Text.Split(' ');
                if (bagian.Length < 3) return;

                double angka2 = double.Parse(bagian[2]);
                double hasil = 0;

                switch (operasi)
                {
                    case "+": hasil = angka1 + angka2; break;
                    case "-": hasil = angka1 - angka2; break;
                    case "*": hasil = angka1 * angka2; break;
                    case "/": hasil = angka2 != 0 ? angka1 / angka2 : throw new DivideByZeroException(); break;
                    default: return;
                }

                labelHasil.Text = $"{angka1} {operasi} {angka2} = {hasil}";
                mulaiBaru = true;
            }
            catch (DivideByZeroException)
            {
                labelHasil.Text = "Error: ÷0";
            }
            catch (Exception)
            {
                labelHasil.Text = "Error";
            }
        }

        private void Hapus(object sender, EventArgs e)
        {
            labelHasil.Text = "0";
            angka1 = 0;
            operasi = "";
            mulaiBaru = true;
        }
    }
}
