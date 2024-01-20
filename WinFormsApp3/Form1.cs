namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += b_c;
            button2.Click += b_c2;
            button3.Click += b_c3;
            button4.Click += b_c4;
        }

        private void b_c(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string a = monthCalendar1.TodayDate.ToString() + textBox1.Text;
                listBox1.Items.Add(a);
            }
        }
        private void b_c2(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }
        private void b_c3(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Clear();
            }
        }
        private void b_c4(object sender, EventArgs e)
        {
            string a = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                a += listBox1.Items[i].ToString();
                a += "\n";
            }
            MessageBox.Show(a);
            b_c3(sender, e);
        }
    }
}
