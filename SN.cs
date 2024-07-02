using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MBTI
{
    public partial class SN : Form
    {
        public SN()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                Form1.S += 1;
            else
                Form1.S -= 1;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
                Form1.N += 1;
            else
                Form1.N -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EI newEI = new EI();
            newEI.Show();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TF newTF = new TF();
            this.Opacity = 0;

            newTF.ShowDialog();

        }
    }
}
