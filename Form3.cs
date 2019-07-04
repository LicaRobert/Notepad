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
    public partial class Form3 : Form
    {
        Form1 parent;
        public Form3(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void goToBtn_Click(object sender, EventArgs e)
        {
              int value = int.Parse(lineNumberTextBox.Text);
              int index = parent.txtArea.GetFirstCharIndexFromLine(value -1);
              parent.txtArea.Select(index, 0);
              parent.txtArea.ScrollToCaret(); 
              Close();
        }
    }
}
