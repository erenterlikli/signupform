using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtDefteri
{
    public partial class KayıtDefteri : Form
    {
        public KayıtDefteri()
        {
            InitializeComponent();
        }

        private void KayıtDefteri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label17.Text = textBox1.Text;
            label18.Text = textBox2.Text;
            label19.Text = textBox3.Text;
            label20.Text = textBox4.Text;
            label21.Text = comboBox1.Text;
        }
    }
}

