namespace kalkulator_figur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] figury = { "kwadrat", "prostok¹t", "trójk¹t", "ko³o" };
            comboBox1.Items.AddRange(figury);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "kwadrat":
                    x2.Hide();
                    x2l.Hide();

                    x1l.Text = "bok";
                    return;

                case "prostok¹t":
                    x2.Show();
                    x2l.Show();

                    x1l.Text = "bok 1";
                    x2l.Text = "bok 2";
                    return;

                case "trójk¹t":
                    x2.Show();
                    x2l.Show();

                    x1l.Text = "bok";
                    x2l.Text = "wysokoœæ";
                    return;

                case "ko³o":
                    x2.Hide();
                    x2l.Hide();

                    x1l.Text = "œrednica";
                    return;
            }
        }

        private void bpole_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;

            switch (comboBox1.SelectedItem)
            {
                case "kwadrat":
                    if (double.TryParse(x1.Text, out x))
                    {
                        wynik.Text = (x * x).ToString();
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku!");
                    }
                    return;

                case "prostok¹t":
                    if (double.TryParse(x1.Text, out x))
                    {
                        if (double.TryParse(x2.Text, out y))
                        {
                            wynik.Text = (x * y).ToString();
                        }
                        else
                        {
                            MessageBox.Show("B³¹d boku 2!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku 1!");
                    }
                    return;

                case "trójk¹t":
                    if (double.TryParse(x1.Text, out x))
                    {
                        if (double.TryParse(x2.Text, out y))
                        {
                            wynik.Text = ((x * y) / 2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("B³¹d wysokoœci!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku!");
                    }
                    return;

                case "ko³o":
                    if (double.TryParse(x1.Text, out x))
                    {
                        x = x / 2;
                        x = x * x;
                        wynik.Text = (x * 3.14).ToString();
                    }
                    else
                    {
                        MessageBox.Show("B³¹d œrednicy!");
                    }
                    return;

                default:
                    MessageBox.Show("Wybierz figurê!");
                    return;
            }
            }

        private void bobwód_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;

            switch (comboBox1.SelectedItem)
            {
                case "kwadrat":
                    if (double.TryParse(x1.Text, out x))
                    {
                        wynik.Text = (x * 4).ToString();
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku!");
                    }
                    return;

                case "prostok¹t":
                    if (double.TryParse(x1.Text, out x))
                    {
                        if (double.TryParse(x2.Text, out y))
                        {
                            wynik.Text = ((x * 2) + (y * 2)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("B³¹d boku 2!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku 1!");
                    }
                    return;

                case "trójk¹t":
                    if (double.TryParse(x1.Text, out x))
                    {
                        wynik.Text = (x * 3).ToString();
                    }
                    else
                    {
                        MessageBox.Show("B³¹d boku!");
                    }
                    return;

                case "ko³o":
                    if (double.TryParse(x1.Text, out x))
                    {
                        wynik.Text = (x * 3.14).ToString();
                    }
                    else
                    {
                        MessageBox.Show("B³¹d œrednicy!");
                    }
                    return;

                default:
                    MessageBox.Show("Wybierz figurê!");
                    return;
            }
        }
    }
}
