using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeterX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Opacity = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 frm = new Form3();
            frm.Opacity =(0);
            Form1 frmm = new Form1();
            frmm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Opacity = 0;
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
