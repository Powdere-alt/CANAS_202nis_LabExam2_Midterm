using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NSAIDASD___Q_____
{
    public partial class Form1 : Form
    {
        List<string> Added = new List<string>();
        List<int> Addes = new List<int>();

        public Form1() => InitializeComponent();

        private void SetItem(string name, string price)
        {
            textBox1.Text = name;
            textBox2.Text = price;
            textBox3.Text = "1";
        }

        private void pictureBox6_Click(object sender, EventArgs e) => SetItem("6pc Burger Steak", "300");
        private void pictureBox4_Click(object sender, EventArgs e) => SetItem("Yum Burger", "49");
        private void pictureBox5_Click(object sender, EventArgs e) => SetItem("Jolly Spaghetti", "79");
        private void pictureBox9_Click(object sender, EventArgs e) => SetItem("Coke Float", "59");
        private void pictureBox8_Click(object sender, EventArgs e) => SetItem("Chicken Bucket", "499");
        private void pictureBox7_Click(object sender, EventArgs e) => SetItem("Tunapie", "149");

        private void button4_Click(object sender, EventArgs e)
        {
            Added.Add(textBox1.Text);
            Addes.Add(Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text));
            MessageBox.Show("Item Added Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text)) { MessageBox.Show("No money?"); return; }

            int total = Addes.Sum();
            int discountPercent = string.IsNullOrWhiteSpace(textBox6.Text) ? 0 : Convert.ToInt32(textBox6.Text);
            int discountAmount = total * discountPercent / 100;
            int discountedTotal = total - discountAmount;
            int tender = Convert.ToInt32(textBox4.Text);
            int change = tender - discountedTotal;

            textBox5.Text = change.ToString();
            textBox7.Text = discountAmount.ToString();

            MessageBox.Show($"Total is {total}\nDiscount ({discountPercent}%) is {discountAmount}\nDiscounted Total is {discountedTotal}\nYou Paid {tender} pesos and have a change of {change}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var tb in new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 })
                tb.Clear();
            Added.Clear();
            Addes.Clear();
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        public void textBox5_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}