using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form1 : Form
    {
        Tree sum;
        Tree min;
        Tree max;
        static int Sum(int a, int b){return a + b;}
        static int Min(int a, int b) { return (a < b ? a : b); }
        static int Max(int a, int b) { return (a > b ? a : b); }


        public Form1()
        {
            InitializeComponent();
            sum = null;
            min = null;
            max = null;
        }

        void Chek2()
        {
            int n;
            if (!int.TryParse(textBox_value.Text,out n) || !int.TryParse(textBox_nomber.Text,out n) || n < 1 || n > (sum == null ? 1 : (sum.Count+1)))
                button_add.Enabled = false;
            else
                button_add.Enabled = true;
            if (!int.TryParse(textBox_value.Text, out n) || !int.TryParse(textBox_nomber.Text, out n) || sum==null|| n < 1 || n >sum.Count)
            {
                button_del.Enabled = false;
                button_repl.Enabled = false;
            }
            else
            {
                button_del.Enabled = true;
                button_repl.Enabled = true;
            }
        }

        private void textBox_nomber_TextChanged(object sender, EventArgs e)
        {
            Chek2();
        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {
            Chek2();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (sum == null)
            {
                sum = new Tree(new int[] { int.Parse(textBox_value.Text) }, Sum);
                min = new Tree(new int[] { int.Parse(textBox_value.Text) }, Min);
                max = new Tree(new int[] { int.Parse(textBox_value.Text) }, Max);
                button1.Enabled = true;
                button_del.Enabled = true;
                button_repl.Enabled = true;
            }
            else
            {
                sum.Add(int.Parse(textBox_value.Text), int.Parse(textBox_nomber.Text)-1);
                min.Add(int.Parse(textBox_value.Text), int.Parse(textBox_nomber.Text)-1);
                max.Add(int.Parse(textBox_value.Text), int.Parse(textBox_nomber.Text)-1);
            }
            Print();
            textBox_nomber.Text = (sum.Count + 1).ToString();
            textBox_value.Focus();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (sum.Count == 1)
            {
                sum = null;
                min = null;
                max = null;
                button1.Enabled = false;
                textBox1.Text = "";
                button_del.Enabled = false;
                button_repl.Enabled = false;
            }
            else
            {
                sum.Delete(int.Parse(textBox_nomber.Text) - 1);
                min.Delete(int.Parse(textBox_nomber.Text) - 1);
                max.Delete(int.Parse(textBox_nomber.Text) - 1);
                Print();
            }
            Chek2();
        }
        void Print()
        {
            string s = "";
            for (int i = 0; i < sum.Count; i++)
            {
                s += (i + 1) + ") " + sum[i] + "     ";
            }
            textBox1.Text = s;
            label_result.Text = "";
        }

        private void button_repl_Click(object sender, EventArgs e)
        {
            sum[int.Parse(textBox_nomber.Text) - 1] = int.Parse(textBox_value.Text);
            max[int.Parse(textBox_nomber.Text) - 1] = int.Parse(textBox_value.Text);
            min[int.Parse(textBox_nomber.Text) - 1] = int.Parse(textBox_value.Text);
            Print();
            Chek2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sum != null)
            {
                string s = (sum.Get_value_on_segment(int.Parse(textBox_left.Text) - 1, int.Parse(textBox_right.Text) - 1)).ToString() + "\n";
                s += (min.Get_value_on_segment(int.Parse(textBox_left.Text) - 1, int.Parse(textBox_right.Text) - 1)).ToString() + "\n";
                s += (max.Get_value_on_segment(int.Parse(textBox_left.Text) - 1, int.Parse(textBox_right.Text) - 1)).ToString();
                label_result.Text = s;
            }
            else
            {
                label_result.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2("About", "В програмі реалізовано структуру дерева відрізків.\nГоловним завданням програми є пошук значення функції на\nпевному відрізку з множини.\nДаний пошук реалізується не за допомогою простого підрахунку,\nа засобами описаного класу для дерева відрізків.").Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2("Help", "Натисніть кнопку Add для додавання елементу.\nНатисніть кнопку Repl для заміни значення елементу.\nНатисніть кнопку Del для видалення елементу з множини.\nТекстові поля «№» і «value» призначені для роботи кнопок Add,\nRepl, Del.\nНатисніть кнопку Result для визначення трьох функцій з \nвідрізка вказаного в текстові поля «left» і «right». \nВ текстовому полі зверху виводиться введена множина значень.\nНатисніть кнопку About для того, щоб дізнатися інформацію \nпро програму.\nНатисніть кнопку Help для того, щоб дізнатися \nяк користуватися програмою.\nНатисніть Exit для закінчення роботи.").Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
