using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cMath t = new cMath();
            t.x = int.Parse(textBox1.Text);
            t.y = int.Parse(textBox2.Text);
            t.swap();
            textBox1.Text = t.x.ToString();
            textBox2.Text = t.y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char c = char.Parse(textBox3.Text);
            cMath t = new cMath();
            t.x = int.Parse(textBox1.Text);
            t.y = int.Parse(textBox2.Text);

            label2.Text = t.cal(c).ToString();
        }
    }
}
