using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6._1
{
    public partial class Form1 : Form
    {
        void Drop()
        {
            SingletonMB.instance = null;
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SingletonMB.GetInstance(comboBox1.SelectedIndex+1, textBox1, button1, button2);
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonMB.instance.MBLife(textBox1, 1, button1, button2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingletonMB.instance.MBLife(textBox1, 2, button1, button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drop();
        }

        private void выкинутьМатеринскуюПлатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drop();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
