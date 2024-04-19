using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Shop.Items.Add("Apple");
            Shop.Items.Add("Banana");
            Shop.Items.Add("Grape");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                Shop.Items.Add(newItem);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart.Items.Add(Shop.SelectedItem);
            Shop.Items.Remove(Shop.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop.Items.Add(Cart.SelectedItem);
            Cart.Items.Remove(Cart.SelectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int shopCount = Shop.Items.Count;
            int cartCount = Cart.Items.Count;
            int total = shopCount + cartCount;
            MessageBox.Show("Total shop and cart: " + total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cartCount = Cart.Items.Count;
            for (int i = 0; i < cartCount; i++)
            {
                Shop.Items.Add(Cart.Items[i]);
            }
            Cart.Items.Clear();
        }
    }
}
