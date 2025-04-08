using System;
using System.Windows.Forms;
using System.Data;

namespace KalkulatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string ekspresi = textBox1.Text
                    .Replace("x", "*")
                    .Replace(",", ".")
                    .Replace("%", "*0.01");

                var result = new DataTable().Compute(ekspresi, null);
                
                // Tambah riwayat ke listBox
                listBoxHistory.Items.Add(textBox1.Text);
                listBoxHistory.Items.Add("= " + result.ToString());
                listBoxHistory.Items.Add(""); // Spasi biar rapih
                
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void buttonFunc_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                double nilai = Convert.ToDouble(textBox1.Text);
                double hasil = 0;

                switch (btn.Text)
                {
                    case "sin":
                        hasil = Math.Sin(nilai * Math.PI / 180);
                        break;
                    case "cos":
                        hasil = Math.Cos(nilai * Math.PI / 180);
                        break;
                    case "tan":
                        hasil = Math.Tan(nilai * Math.PI / 180);
                        break;
                }

                textBox1.Text = hasil.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }
    }
}
