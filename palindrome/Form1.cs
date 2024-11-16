using System;
using System.Linq;
using System.Windows.Forms;

namespace palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tex1 = textBox1.Text.Trim(), concat = "";
            char tex2;
            int num = tex1.Length;
         
            while (num > 0)
            {
                num--;
                tex2 = tex1[num];
                concat = concat + tex2.ToString();
            }

            if (concat.Equals(tex1, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("this is a palindrome");
            }
            else
            {
                MessageBox.Show("this is not a palindrome");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
