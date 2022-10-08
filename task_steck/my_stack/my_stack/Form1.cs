using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_stack
{
    public partial class Form1 : Form
    {
        MyStack<string> mas;
        public Form1()
        {
            InitializeComponent();
            mas = new MyStack<string>(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mas.Push(textBox1.Text);
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
                textBox1.Text = mas.Pop();
                UpdateText();
            }
            catch
            {
                textBox1.Text = "erorr";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        void UpdateText()
        {
            listBox1.Items.Clear();
            foreach (string s in mas.ToArray())
            {
                listBox1.Items.Add(s);

            }
            listBox1.Text = listBox1.Text.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = mas.Top();
                UpdateText();
            }
            catch
            {
                textBox1.Text = "erorr";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p = mas.Capacity();
            textBox1.Text = p.ToString();
        }
    }



}
