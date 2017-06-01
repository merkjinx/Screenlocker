using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowslocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

           // if (this.WindowState == FormWindowState.Normal)
            //{
             //   this.WindowState = FormWindowState.Maximized;
            //}

            //this.Activate();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private bool _altF4Pressed;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
    }
}
