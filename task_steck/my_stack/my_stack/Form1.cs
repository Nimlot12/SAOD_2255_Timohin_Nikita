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



        void UpdateText()
        {
            listBox2.Items.Clear();
            foreach (string s in mas.ToArray())
            {
                listBox2.Items.Add(s);

            }
            listBox2.Text = listBox2.Text.Trim();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                mas.Push(textBox2.Text);
                UpdateText();
            }
            catch
            {
                textBox2.Text = "erorrrrrrrrrrrrrr";
                MessageBox.Show("Программа сломалась, ваша логика неверна. Чтобы продолжить работу с программой необходимо занести 2 банки сгущенки разработчикам. Вы согласны продолжить работу? (По факту согласия отправляется email-уведомление в IT-отдел и в бухгалтерию)", "",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = mas.Pop();
                UpdateText();
            }
            catch
            {
                textBox2.Text = "erorrrrrrrrrrrrrr";
                MessageBox.Show("Программа сломалась, ваша логика неверна. Чтобы продолжить работу с программой необходимо занести 2 банки сгущенки разработчикам. Вы согласны продолжить работу? (По факту согласия отправляется email-уведомление в IT-отдел и в бухгалтерию)", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = mas.Top();
                UpdateText();
            }
            catch
            {
                textBox2.Text = "erorrrrrrrrrrrrrr";
                MessageBox.Show("Программа сломалась, ваша логика неверна. Чтобы продолжить работу с программой необходимо занести 2 банки сгущенки разработчикам. Вы согласны продолжить работу? (По факту согласия отправляется email-уведомление в IT-отдел и в бухгалтерию)", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int p = mas.Capacity();
            textBox2.Text = p.ToString();
        }
    }



}
