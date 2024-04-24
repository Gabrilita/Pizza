using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pizza_11a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Items items = new Items();
        DialogResult result;
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
            items.Pica = comboBox1.Text;
            if (string.IsNullOrEmpty(items.Pica))
            {
                result = MessageBox.Show("Ne si izbral pica!", "ERROR",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button3);
                comboBox1.Focus();
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Ti izbra DA");
                    return;
                }
                else
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Ti izbra NO");
                    return;
                }
                else
                {
                    MessageBox.Show("Ti izbra OTKAZ");
                    return;
                }
            }

            if (radioButton1.Checked)
            {
                items.Variant = radioButton1.Text;
            }
            else
            if (radioButton2.Checked)
            {
                items.Variant = radioButton2.Text;
            }
            else
            if (radioButton3.Checked)
            {
                items.Variant = radioButton3.Text;
            }
            else
            {
                result = MessageBox.Show("Ne si izbral variant!", "ERROR",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                    return;

                }
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                    return;
                }
            }

            if (radioButton6.Checked)
            {
                items.Plashtane = radioButton6.Text;
            }
            else
            if (radioButton5.Checked)
            {
                items.Plashtane = radioButton5.Text;
            }
            else
            {
                result = MessageBox.Show("Ne si izbral kak da platish!", "ERROR",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                    return;

                }
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                    return;
                }
            }

            FormThankYou f2 = new FormThankYou();
            f2.Show();
        }
    }
}
