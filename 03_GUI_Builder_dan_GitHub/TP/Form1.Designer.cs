namespace tpmodul_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form1 (Background warna kuning pucat)
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "Form1";

            // textBox1 (Input Nama)
            this.textBox1.Location = new System.Drawing.Point(250, 100); // Posisi sesuai gambar
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25); // Lebar sesuai gambar
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Text = "Masukkan Nama Kamu"; // Placeholder

            // button1 (Submit)
            this.button1.Location = new System.Drawing.Point(440, 100); // Posisi sesuai gambar
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Text = "Submit";
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // label2 (Output)
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 150); // Posisi sesuai gambar
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Text = "Output";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false; // Sembunyikan dulu, muncul setelah klik Submit

            // Tambahkan semua komponen ke Form
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
