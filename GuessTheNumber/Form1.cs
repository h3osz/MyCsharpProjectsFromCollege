using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УгадайЧисло
{
    public partial class Form1 : Form
    {
        static public int p = 10;
        static public Random r = new Random();
        public int rnd = r.Next(1, 101);
        public bool win = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите число от 1 до 100");
            }
            else 
            {
                int c = Convert.ToInt32(textBox1.Text);
                if (c > rnd)
                {
                    label3.Text = "Мое число меньше ";
                    p--;
                }
                else if (c < rnd)
                {
                    label3.Text = "Мое число больше";
                    p--;
                }
                else if (c == rnd)
                {
                    label3.Text = "Ты выйграл. У тебя осталось попыток: " + p.ToString();
                    button2.Visible = true;
                    win = true;
                }
                if (p == 0 && win == false)
                {
                    label3.Text = "Ты проиграл. Не осталось попыток.";
                    button2.Visible = true;
                    button1.Visible = false;
                }

                label2.Text = "Попыток осталось: " + p .ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = rnd.ToString();
            label2.Text = "Попыток осталось: " + p.ToString();
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            p = 10;
            rnd = r.Next(1, 101);
            label2.Text = "Попыток осталось: " + p.ToString();
            button2.Visible = false;
            button1.Visible = true;
            label3.Text = "";
            win = false;
        }
    }
}
