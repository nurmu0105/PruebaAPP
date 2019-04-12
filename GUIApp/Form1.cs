using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Acept_Click(object sender, EventArgs e)
        {
            string text = input.Text;
            if (text.CompareTo("") == 0)
            {
                solution.Text = "Introduce algún texto";
            }
            else
            {
                solution.Text = text;
                text = "";
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            
        }
    }
}
