using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        char[] suits = { '\u2660', '\u2665', '\u2663', '\u2666' };
        string[] num = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Random rnd = new Random();
        int[,] cards1 = new int[18, 2];
        int[,] cards2 = new int[18, 2];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] mas = new int[9];
            string[] str = new string[9];
            string player1 = "";
            string player2 = "";
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
                str[i] = "";
            }
            int k = 0;
            int h = 0;
            for (int i = 0; i < 36; i++)
            {
                int a = rnd.Next(0, 9);
                do
                {
                    a = rnd.Next(0, 9);
                }
                while (mas[a] == 4);
                mas[a]++;
                int b = rnd.Next(0, 4);
                do
                {
                    b = rnd.Next(0, 4);
                }
                while (str[a].Contains(b.ToString()));
                str[a] += b.ToString();
                if (i % 2 == 0)
                {
                    cards2[k, 0] = a;
                    cards2[k, 1] = b;
                    k++;
                    player2 += num[a] + suits[b] + " | ";
                }
                else
                {
                    cards1[h, 0] = a;
                    cards1[h, 1] = b;
                    h++;
                    player1 += num[a] + suits[b] + " | ";
                }
            }
            label1.Text = player1;
            label2.Text = player2;
            button2.Visible = true;
            stats.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = 0;
            int n = 0;
            for (int i = 0; i < 18; i++)
            {
                if (cards1[i, 0] > cards2[i, 0])
                {
                    if (cards1[i, 1] != cards2[i, 1])
                    {
                        m++;
                    }
                }
                else if (cards1[i, 0] < cards2[i, 0])
                {
                    if (cards1[i, 1] != cards2[i, 1])
                    {
                        n++;
                    }
                }
            }
            if (m > n)
            {
                stats.Text = "Выиграл Первый игрок, у него: " + m + " очков";
            }
            else if (n > m)
            {
                stats.Text = "Выиграл Второй игрок, у него: " + n + " очков";
            }
            else
            {
                stats.Text = "Ничья со счетом: " + m + " : " + n;
            }
        }
    }
}
