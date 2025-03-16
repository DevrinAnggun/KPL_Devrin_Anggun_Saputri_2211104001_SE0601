namespace Kalkulator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Button[] tombolAngka;
        private System.Windows.Forms.Button tombolTambah, tombolSamaDengan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelHasil = new System.Windows.Forms.Label();
            this.tombolAngka = new System.Windows.Forms.Button[10];

            for (int i = 0; i < 10; i++)
            {
                this.tombolAngka[i] = new System.Windows.Forms.Button();
                this.tombolAngka[i].Text = i.ToString();
                this.tombolAngka[i].Size = new System.Drawing.Size(50, 30); // Ukuran tombol lebih kecil
                this.tombolAngka[i].Click += new System.EventHandler(this.AngkaDitekan);
            }

            this.tombolTambah = new System.Windows.Forms.Button();
            this.tombolSamaDengan = new System.Windows.Forms.Button();

            this.tombolTambah.Text = "+";
            this.tombolSamaDengan.Text = "=";
            this.tombolTambah.Size = new System.Drawing.Size(50, 30);
            this.tombolSamaDengan.Size = new System.Drawing.Size(50, 30);

            this.tombolTambah.Click += new System.EventHandler(this.OperasiDitekan);
            this.tombolSamaDengan.Click += new System.EventHandler(this.SamaDenganDitekan);

            // Label Output
            this.labelHasil.Text = "Label output";
            this.labelHasil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.labelHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHasil.Location = new System.Drawing.Point(150, 50); // Posisi lebih ke tengah
            this.labelHasil.Size = new System.Drawing.Size(120, 30);

            // Posisi Tombol
            int startX = 150, startY = 100, padding = 5;
            for (int i = 1; i <= 9; i++)
            {
                int row = (i - 1) / 3;
                int col = (i - 1) % 3;
                this.tombolAngka[i].Location = new System.Drawing.Point(startX + (col * (50 + padding)), startY + (row * (30 + padding)));
            }

            // Tombol 0, +, dan =
            this.tombolTambah.Location = new System.Drawing.Point(startX, startY + (3 * (30 + padding)));
            this.tombolAngka[0].Location = new System.Drawing.Point(startX + (1 * (50 + padding)), startY + (3 * (30 + padding)));
            this.tombolSamaDengan.Location = new System.Drawing.Point(startX + (2 * (50 + padding)), startY + (3 * (30 + padding)));

            // Tambahkan kontrol ke form
            this.Controls.Add(this.labelHasil);
            for (int i = 0; i < 10; i++)
                this.Controls.Add(this.tombolAngka[i]);

            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.tombolSamaDengan);

            // Properti utama form
            this.Text = "Form1";
            this.Size = new System.Drawing.Size(500, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
    }
}
