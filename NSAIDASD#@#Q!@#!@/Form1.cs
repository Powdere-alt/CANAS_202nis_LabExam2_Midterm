using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NSAIDASD___Q_____
{
    public partial class Form1 : Form
    {
        List<string> Added = new List<string>();
        List<int> Addes = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6pc Burger Steak";
            textBox2.Text = "300";
            textBox3.Text = "1";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yum Burger";
            textBox2.Text = "49";
            textBox3.Text = "1";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jolly Spaghetti";
            textBox2.Text = "79";
            textBox3.Text = "1";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Coke Float";
            textBox2.Text = "59";
            textBox3.Text = "1";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Chicken Bucket";
            textBox2.Text = "499";
            textBox3.Text = "1";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Tunapie";
            textBox2.Text = "149";
            textBox3.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Added.Add(textBox1.Text);
            int news = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            Addes.Add(news);
            MessageBox.Show("Item Added Succesfullt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox4.Text == " ") { MessageBox.Show("No money?"); }
            else
            {
                string BANANA = Convert.ToString(Addes.Sum());
                int tender = Convert.ToInt32(textBox4.Text);
                string change = Convert.ToString(tender - Addes.Sum());
                textBox5.Text = change;
                MessageBox.Show($"Total is {BANANA}\nYou Paid {tender} pesos and have a change of {change}");
            }
            ;

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            Added.Clear();
            Addes.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
