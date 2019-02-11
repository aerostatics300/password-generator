using System;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        private Random rand = new Random();
        private string outputList = "";

        private string passList = "abcdefghijklmnopqrstuvwxyz";
        private string strAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string strNum = "1234567890";
        private string strChars = "@#$%^&*(){}";

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = outputList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputList = "";
            passList = "abcdefghijklmnopqrstuvwxyz";
            int length = Convert.ToInt32(textBox1.Text);

            if(checkBox1.Checked == true)
            {
                passList += strAlphabet;
            }

            if(checkBox2.Checked == true)
            {
                passList += strNum;
            }

            if(checkBox3.Checked == true)
            {
                passList += strChars;
            }

            RandomString(passList, length);

            textBox2.Text = outputList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Password Copied to Clipboard!");
        }

        private void RandomString(string list, int length)
        {
            int pos;

            for(int i = 0; i < length; i++)
            {
                pos = rand.Next(0, list.Length - 1);
                outputList += list[pos];
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
