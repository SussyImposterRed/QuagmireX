using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using System.Threading;
using System.IO;

namespace PeterX
{
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        public SxLibWinForms sxlib;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.sxlib = SxLib.InitializeWinForms(this, Program.syndir[0]);
            sxlib.AttachEvent += Sxlib_AttachEvent;
            sxlib.LoadEvent += Sxlib_LoadEvent;
            sxlib.Load();
           
        }
        private void Sxlib_LoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            statusLabel.Text = " " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
            if (Event == SxLibBase.SynLoadEvents.READY)
            {
                sxlib.ScriptHub();
            }
        }

        private void Sxlib_AttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            statusLabel.Text = "Injection: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
        }


        private void buttonattach_Click(object sender, EventArgs e)
        {
            sxlib.Attach();
        }

        private void buttonex_Click(object sender, EventArgs e)
        {
            sxlib.Execute(fastColoredTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
