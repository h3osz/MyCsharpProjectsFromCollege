using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПроектПерсонаж {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

           
        }

        int totalpoints = 10; 

        int power = 5, dexterity = 5, endurance = 5, magic = 5; 

        void refreshStatus() {
            labelSila.Text = $"Сила: {power}";
            labelLovkost.Text = $"Ловкость: {dexterity}";
            labelVinoslivost.Text = $"Выносливость: {endurance}";
            labelMagiya.Text = $"Магия: {magic}";
            labelPoints.Text = $"Общее количество очков: {totalpoints}";

            if (textBox1.Text.Length != 0 && totalpoints == 0)
            {
                resume.Enabled = true;
            }
            else
            {
                resume.Enabled = false;
            }



        }

        private void lovkostMinus_Click(object sender, EventArgs e) {
            if (dexterity != 0) {
                dexterity--;
                totalpoints++;
            }
            refreshStatus();
        }

        private void lovkostPlus_Click(object sender, EventArgs e) {
            if (totalpoints == 0) {
                MessageBox.Show("Недостаточно очков");
            }
            else {
                totalpoints--;
                dexterity++;
            }
            refreshStatus();
        }

        private void vinoslivostMinus_Click(object sender, EventArgs e) {
            if (endurance != 0) {
                endurance--;
                totalpoints++;
            }
            refreshStatus();
        }

        private void vinoslivostPlus_Click(object sender, EventArgs e) {
            if (totalpoints == 0) {
                MessageBox.Show("Недостаточно очков");
            }
            else {
                totalpoints--;
                endurance++;
            }
            refreshStatus();
        }

        private void magiyMinus_Click(object sender, EventArgs e) {
            if (magic != 0) {
                magic--;
                totalpoints++;
            }
            refreshStatus();
        }

        private void magiyPlus_Click(object sender, EventArgs e) {
            if (totalpoints == 0) {
                MessageBox.Show("Недостаточно очков");
            }
            else {
                totalpoints--;
                magic++;
            }
            refreshStatus();
        }
        int count = -1;
        private void previous_Click(object sender, EventArgs e)
        {

            if (count > 0)
            {
                count--;
            }

            if (count < 0)
            {
                count++;
            }

            pictureBox1.Image = imageList1.Images[count];
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (count < 10)
            {
                count++;
            }

            pictureBox1.Image = imageList1.Images[count];
        }

         

private void resume_Click(object sender, EventArgs e)
        {
          

        }

        private void resume_TextChanged(object sender, EventArgs e)
        {

           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void silaPlus_Click(object sender, EventArgs e) {
            if (totalpoints == 0) {
                MessageBox.Show("Недостаточно очков");
            }
            else {
                totalpoints--;
                power++;
            }
            refreshStatus();
        }

        private void silaMinus_Click(object sender, EventArgs e) {
            if (power != 0) {
                power--;
                totalpoints++;
            }
            refreshStatus();

        }

        private void MainForm_Load(object sender, EventArgs e) {
            refreshStatus();
        }
    }
}
