using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrudnikovForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label11.Text = "Введите данные для расчета.";
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                double h, angle;
                if (!double.TryParse(textBox1.Text, out h) || !double.TryParse(textBox2.Text, out angle))
                {
                    MessageBox.Show("Неверный формат ввода. Пожалуйста, введите числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (angle > 60)
                {
                    MessageBox.Show("Угол должен быть не больше 60 градусов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result1 = Math.Abs(h / (2 * Math.Sin(angle * Math.PI / 180)));
                double result2 = Math.Abs(1.5 * result1);

                textBox3.Text = result1.ToString();
                textBox4.Text = result2.ToString();                
            }

            if(radioButton2.Checked)
            {
                double H, eValue, Gx;
                if (!double.TryParse(textBox10.Text, out H) || !double.TryParse(textBox9.Text, out eValue) || !double.TryParse(textBox8.Text, out Gx))
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

                textBox7.Text = L1.ToString();
                textBox5.Text = L0.ToString();
                textBox6.Text = L2.ToString();                
            }
        }
    }
}
