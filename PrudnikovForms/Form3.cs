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

namespace PrudnikovForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double H, eValue, Gx;
            if (!double.TryParse(textBox1.Text, out H) || !double.TryParse(textBox2.Text, out eValue) || !double.TryParse(textBox3.Text, out Gx))
            {
                MessageBox.Show("Неверный формат ввода. Пожалуйста, введите числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double L1, L0, L2;

            if (eValue == 0)
            {
                L1 = H / 2;
                L0 = Gx - L1;
                L2 = L0 - L1;
            }
            else if (eValue > 0)
            {
                L1 = H / 2;
                L0 = Math.Sqrt(Math.Pow(Gx - L1, 2) + Math.Pow(eValue, 2));
                L2 = L0 - L1;
            }
            else
            {
                L1 = H / 2;
                L0 = Math.Sqrt(Math.Pow(Gx - L1, 2) + Math.Pow(eValue, 2));
                L2 = L0 - L1;
            }

            textBox4.Text = L1.ToString();
            textBox5.Text = L0.ToString();
            textBox6.Text = L2.ToString();

            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
