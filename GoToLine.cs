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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoToBtn_Click(object sender, EventArgs e)
        {
            int i;

            if (!int.TryParse(lineNumberTextBox.Text, out i))
            {
                MessageBox.Show("You did not entered the line.");
                return;
            }
            if (int.TryParse(lineNumberTextBox.Text, out i))
            {
                int value = int.Parse(lineNumberTextBox.Text);
                int index = parent.txtArea.GetFirstCharIndexFromLine(value - 1);
                parent.txtArea.Select(index, 0);
                parent.txtArea.ScrollToCaret();
                Close();
            }
        }
    }
}
