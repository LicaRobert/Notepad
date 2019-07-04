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
    public partial class ListBoxForm : Form
    {

        Form1 parent;
        Search parent2;

        public ListBoxForm(Form1 p, Search p2)
        {
            parent = p;
            parent2 = p2;

            InitializeComponent();
        }

        private void myListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = parent.txtArea.GetFirstCharIndexOfCurrentLine();
            int lineNumber = parent.txtArea.GetLineFromCharIndex(index);
            parent.txtArea.SelectionLength = 0;
            parent.txtArea.SelectionStart = parent.txtArea.GetFirstCharIndexFromLine(lineNumber);
            parent.txtArea.ScrollToCaret();
        }
    }
}
