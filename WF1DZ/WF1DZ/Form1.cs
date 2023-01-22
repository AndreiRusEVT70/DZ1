using System;
using System.Windows.Forms;

namespace WF1DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int result = 0;
            for (int i = 0; i < n; i++)
                result += (int)Math.Sqrt(i);
            label3.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClick2(object sender, EventArgs e)
        {
            double n = double.Parse(textBox2.Text);
            double result = 0;
            for (int i = 1; i <= n; i++)
                result += Math.Sqrt(i);
            result = (double)(int)result;
            label4.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
