using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSaveTextBox
{
    public partial class RichTextChanged : Form
    {
        Form1 parent;
        public RichTextChanged(Form1 p)
        {
            parent = p;

            InitializeComponent();
            labelPath.Text = @"""C\Users\spr_a_000\source\repos\OpenSaveTextBox\fisier.txt""";
            labelText.Text = " This file has been modified by another program ." + "\n" + " Do you want to reload it ? ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\spr_a_000\source\repos\OpenSaveTextBox\fisier.txt";
            parent.txtArea.Text = "";
            parent.txtArea.Text =  System.IO.File.ReadAllText(path);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
