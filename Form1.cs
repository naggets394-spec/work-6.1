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
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Материнская плата дома! Но по дороге в комнату вы уронили ее на пол. Потрясти, чтобы смахнуть пыль?";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
