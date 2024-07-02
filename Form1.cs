using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTI
{

    public partial class Form1 : Form
    {
        public static int E = 0;
        public static int I = 0;
        public static int S = 0;
        public static int N = 0;
        public static int T = 0;
        public static int F = 0;
        public static int J = 0;
        public static int P = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EI newEI = new EI();
            this.Opacity = 0;
            newEI.ShowDialog();
        }
    }
}
