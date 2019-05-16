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
    public partial class ColumnEditor : Form
    {
        Form1 parent;

        public ColumnEditor(Form1 p)
        {
            parent = p;
            InitializeComponent();

            textInsertBox.Enabled = true;
            numberInsertRadio.Checked = false;
            initialNumberTextBox.Enabled = false;
            increaseByTextBox.Enabled = false;
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RadioText_CheckedChanged(object sender, EventArgs e)
        {
            textInsertBox.Enabled = true;
            numberInsertRadio.Checked = false;
            initialNumberTextBox.Enabled = false;
            increaseByTextBox.Enabled = false;
        }

        private void NumberInsertRadio_CheckedChanged(object sender, EventArgs e)
        {
            radioText.Checked = false;
            textInsertBox.Enabled = false;
            initialNumberTextBox.Enabled = true;
            increaseByTextBox.Enabled = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

         if (radioText.Checked)
          {
            int index = parent.txtArea.SelectionStart;
            int line = parent.txtArea.GetLineFromCharIndex(index);
            int column = parent.txtArea.SelectionStart - parent.txtArea.GetFirstCharIndexFromLine(line);

            for (int i = line + 1; i <= parent.txtArea.Lines.Count(); i++)
            {
             parent.txtArea.Text = parent.txtArea.Text.Insert(index, textInsertBox.Text);
             index = parent.txtArea.GetFirstCharIndexFromLine(i) + column;
             }
          }

         if (numberInsertRadio.Checked)
          {
           int initial = Convert.ToInt32(initialNumberTextBox.Text);
           int increase = Convert.ToInt32(increaseByTextBox.Text);
           int index = parent.txtArea.SelectionStart;
           int line = parent.txtArea.GetLineFromCharIndex(index);
           int column = parent.txtArea.SelectionStart - parent.txtArea.GetFirstCharIndexFromLine(line);

           for (int i = line + 1; i <= parent.txtArea.Lines.Count(); i++)
           {
            parent.txtArea.Text = parent.txtArea.Text.Insert(index, initial.ToString());
            index = parent.txtArea.GetFirstCharIndexFromLine(i) + column;
            initial = initial + increase;
            }
          }    
            Close();
        }

        private void InitialNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void IncreaseByTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}