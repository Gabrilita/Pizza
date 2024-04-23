using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_11a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.Enabled = true;
            if (comboBox1.Text == "Вегетариана")
                pictureBox1.Image = Image.FromFile("vegetariana.jpg");
            if (comboBox1.Text == "Маргарита")
                pictureBox1.Image = Image.FromFile("margarita.jpg");
            if (comboBox1.Text == "Калцоне")
                pictureBox1.Image = Image.FromFile("kalcone.jpg");
            if (comboBox1.Text == "Капричоза")
                pictureBox1.Image = Image.FromFile("kaprichoza.jpg");
            if (comboBox1.Text == "Тоскана")
                pictureBox1.Image = Image.FromFile("toskana.jpg");
            if (comboBox1.Text == "Прошуто")
                pictureBox1.Image = Image.FromFile("proshuto.jpg");
            if (comboBox1.Text == "Хаваи") pictureBox1.Image = Image.FromFile("havai.jpg");
        }

        private void order_Click(object sender, EventArgs e)
        {
            FormThankYou f2 = new FormThankYou();
            f2.Show();
        }
    }
}
