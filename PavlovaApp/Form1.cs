using System;

namespace PavlovaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            int a_1 = Convert.ToInt32(a);
            int b_1 = Convert.ToInt32(b);
            int ab = a_1 + b_1;
            textBox3.Text = ab.ToString();
        }
    }
}