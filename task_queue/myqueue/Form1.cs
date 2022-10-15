using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myqueue
{
    public partial class Form1 : Form
    {
        Queue<int> queue;

        public Form1()
        {
            InitializeComponent();
            queue = new Queue<int>(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                queue.Enqueue(a);
                UpdateText();
            }
            catch
            {
                textBox1.Text = "erorr";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Dequeue();
                UpdateText();
            }
            catch
            {
                textBox1.Text = "erorr";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(queue.Peek());
                UpdateText();
            }
            catch
            {
                textBox1.Text = "erorr";
            }
        }
        void UpdateText()
        {
            listBox1.Items.Clear();
            foreach (int s in queue.ToArray())
            {
                listBox1.Items.Add(s);

            }
            listBox1.Text = listBox1.Text.Trim();
        }
    }
}
