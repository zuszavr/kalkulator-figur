namespace kalkulator_figur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bpole = new Button();
            comboBox1 = new ComboBox();
            x1l = new Label();
            bobwód = new Button();
            x2l = new Label();
            rodzajfig = new Label();
            wyniknap = new Label();
            wynik = new Label();
            x1 = new TextBox();
            x2 = new TextBox();
            SuspendLayout();
            // 
            // bpole
            // 
            bpole.BackColor = SystemColors.ActiveBorder;
            bpole.Font = new Font("SimSun-ExtG", 9F);
            bpole.Location = new Point(317, 218);
            bpole.Name = "bpole";
            bpole.Size = new Size(75, 23);
            bpole.TabIndex = 0;
            bpole.Text = "Pole";
            bpole.UseVisualStyleBackColor = false;
            bpole.Click += bpole_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.Font = new Font("SimSun-ExtG", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(317, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 20);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // x1l
            // 
            x1l.AutoSize = true;
            x1l.Font = new Font("SimSun-ExtG", 9F);
            x1l.Location = new Point(113, 96);
            x1l.Name = "x1l";
            x1l.Size = new Size(35, 12);
            x1l.TabIndex = 2;
            x1l.Text = "bok 1";
            // 
            // bobwód
            // 
            bobwód.BackColor = SystemColors.ActiveBorder;
            bobwód.Font = new Font("SimSun-ExtG", 9F);
            bobwód.Location = new Point(317, 270);
            bobwód.Name = "bobwód";
            bobwód.Size = new Size(75, 23);
            bobwód.TabIndex = 3;
            bobwód.Text = "Obwód";
            bobwód.UseVisualStyleBackColor = false;
            bobwód.Click += bobwód_Click;
            // 
            // x2l
            // 
            x2l.AutoSize = true;
            x2l.Font = new Font("SimSun-ExtG", 9F);
            x2l.Location = new Point(113, 182);
            x2l.Name = "x2l";
            x2l.Size = new Size(35, 12);
            x2l.TabIndex = 4;
            x2l.Text = "bok 2";
            // 
            // rodzajfig
            // 
            rodzajfig.AutoSize = true;
            rodzajfig.Font = new Font("SimSun-ExtG", 9F);
            rodzajfig.Location = new Point(317, 96);
            rodzajfig.Name = "rodzajfig";
            rodzajfig.Size = new Size(89, 12);
            rodzajfig.TabIndex = 5;
            rodzajfig.Text = "Rodzaj figury:";
            // 
            // wyniknap
            // 
            wyniknap.AutoSize = true;
            wyniknap.Font = new Font("SimSun-ExtG", 9F);
            wyniknap.Location = new Point(113, 274);
            wyniknap.Name = "wyniknap";
            wyniknap.Size = new Size(47, 12);
            wyniknap.TabIndex = 6;
            wyniknap.Text = "wynik: ";
            // 
            // wynik
            // 
            wynik.AutoSize = true;
            wynik.Font = new Font("SimSun-ExtG", 9F);
            wynik.Location = new Point(175, 274);
            wynik.Name = "wynik";
            wynik.Size = new Size(11, 12);
            wynik.TabIndex = 7;
            wynik.Text = "0";
            // 
            // x1
            // 
            x1.Font = new Font("SimSun-ExtG", 9F);
            x1.Location = new Point(113, 135);
            x1.Name = "x1";
            x1.Size = new Size(100, 19);
            x1.TabIndex = 8;
            // 
            // x2
            // 
            x2.Font = new Font("SimSun-ExtG", 9F);
            x2.Location = new Point(113, 218);
            x2.Name = "x2";
            x2.Size = new Size(100, 19);
            x2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(514, 382);
            Controls.Add(x2);
            Controls.Add(x1);
            Controls.Add(wynik);
            Controls.Add(wyniknap);
            Controls.Add(rodzajfig);
            Controls.Add(x2l);
            Controls.Add(bobwód);
            Controls.Add(x1l);
            Controls.Add(comboBox1);
            Controls.Add(bpole);
            Name = "Form1";
            Text = "kalkulator figur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bpole;
        private ComboBox comboBox1;
        private Label x1l;
        private Button bobwód;
        private Label x2l;
        private Label rodzajfig;
        private Label wyniknap;
        private Label wynik;
        private TextBox x1;
        private TextBox x2;
    }
}
