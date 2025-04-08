namespace KalkulatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxHistory;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 50);
            this.textBox1.TabIndex = 0;

            // listBoxHistory
            this.listBoxHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 17;
            this.listBoxHistory.Location = new System.Drawing.Point(12, 440);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(360, 106);
            this.listBoxHistory.TabIndex = 1;

            // Buttons
            string[] buttons = {
                "sin", "cos", "tan", "CE",
                "(", ")", "%", "/",
                "7", "8", "9", "x",
                "4", "5", "6", "-",
                "1", "2", "3", "+",
                "00", "0", ",", "="
            };

            int posX = 12;
            int posY = 80;
            int btnWidth = 80;
            int btnHeight = 50;
            int btnMargin = 5;
            int col = 0;

            for (int i = 0; i < buttons.Length; i++)
            {
                var btn = new System.Windows.Forms.Button();
                btn.Text = buttons[i];
                btn.Font = new System.Drawing.Font("Segoe UI", 14F);
                btn.Size = new System.Drawing.Size(btnWidth, btnHeight);
                btn.Location = new System.Drawing.Point(posX + (col * (btnWidth + btnMargin)), posY);

                if (buttons[i] == "=")
                    btn.Click += new System.EventHandler(this.buttonEqual_Click);
                else if (buttons[i] == "CE")
                    btn.Click += new System.EventHandler(this.buttonCE_Click);
                else if (buttons[i] == "sin" || buttons[i] == "cos" || buttons[i] == "tan")
                    btn.Click += new System.EventHandler(this.buttonFunc_Click);
                else
                    btn.Click += new System.EventHandler(this.button_Click);

                this.Controls.Add(btn);

                col++;
                if (col == 4)
                {
                    col = 0;
                    posY += btnHeight + btnMargin;
                }
            }

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxHistory);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
