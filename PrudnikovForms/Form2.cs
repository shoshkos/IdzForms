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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
