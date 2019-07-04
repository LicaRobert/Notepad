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
            repeatTextBox.Enabled = false;
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
            repeatTextBox.Enabled = false;
        }

        private void NumberInsertRadio_CheckedChanged(object sender, EventArgs e)
        {
            radioText.Checked = false;
            textInsertBox.Enabled = false;
            initialNumberTextBox.Enabled = true;
            increaseByTextBox.Enabled = true;
            repeatTextBox.Enabled = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
    
             if (radioText.Checked && parent.txtArea.Focus())
             {
                int index = parent.txtArea.SelectionStart;
                int line = parent.txtArea.GetLineFromCharIndex(index);
                int column = parent.txtArea.SelectionStart - parent.txtArea.GetFirstCharIndexFromLine(line);

                for (int i = line; i < parent.txtArea.Lines.Count(); i++)
                {
                   int charColumn = parent.txtArea.GetFirstCharIndexFromLine(i) + column;
                   int lines = parent.txtArea.Lines[i].Length - charColumn;
                   if (lines < 0)
                   {
                      string pad = "".PadRight(-lines);
                      parent.txtArea.Text = parent.txtArea.Text.Insert(
                      parent.txtArea.GetFirstCharIndexFromLine(i) + parent.txtArea.Lines[i].Length, pad);
                   }

                   parent.txtArea.Text = parent.txtArea.Text.Insert(charColumn, textInsertBox.Text);

                   if (parent.txtArea.TextLength > charColumn)
                   {
                      parent.txtArea.SelectionStart = charColumn;
                   }
                }
             }


            else if (radioText.Checked && parent.rtbTab.Focus())
            {
                int index = parent.rtbTab.SelectionStart;
                int line = parent.rtbTab.GetLineFromCharIndex(index);
                int column = parent.rtbTab.SelectionStart - parent.rtbTab.GetFirstCharIndexFromLine(line);

                for (int i = line; i < parent.rtbTab.Lines.Count(); i++)
                {
                    int charColumn = parent.rtbTab.GetFirstCharIndexFromLine(i) + column;
                    int lines = parent.rtbTab.Lines[i].Length - charColumn;
                    if (lines < 0)
                    {
                        string pad = "".PadRight(-lines);
                        parent.rtbTab.Text = parent.rtbTab.Text.Insert(
                        parent.rtbTab.GetFirstCharIndexFromLine(i) + parent.rtbTab.Lines[i].Length, pad);
                    }

                    parent.rtbTab.Text = parent.rtbTab.Text.Insert(charColumn, textInsertBox.Text);

                    if (parent.rtbTab.TextLength > charColumn)
                    {
                        parent.rtbTab.SelectionStart = charColumn;
                    }
                }
            }

            if (numberInsertRadio.Checked && parent.txtArea.Focus())
              {
                  int count = 0;

                  int initial = Convert.ToInt32(initialNumberTextBox.Text);
                  int increase = Convert.ToInt32(increaseByTextBox.Text);
                  int repeat = Convert.ToInt32(repeatTextBox.Text);

                  int index = parent.txtArea.SelectionStart;
                  int line = parent.txtArea.GetLineFromCharIndex(index);
                  int column = parent.txtArea.SelectionStart - parent.txtArea.GetFirstCharIndexFromLine(line);

                  for (int i = line; i < parent.txtArea.Lines.Count(); i++)
                  {

                      int charColumn = parent.txtArea.GetFirstCharIndexFromLine(i) + column;
                      int lines = parent.txtArea.Lines[i].Length - charColumn;

                     if (lines < 0)
                     {
                         string pad = "".PadRight(-lines);
                         parent.txtArea.Text = parent.txtArea.Text.Insert(
                         parent.txtArea.GetFirstCharIndexFromLine(i) + parent.txtArea.Lines[i].Length, pad);
                         index = parent.txtArea.GetFirstCharIndexFromLine(i) + column;
                         count++;
                     }

                     parent.txtArea.Text = parent.txtArea.Text.Insert(charColumn, initial.ToString());

                     if (parent.txtArea.TextLength > charColumn)
                     {
                         parent.txtArea.SelectionStart = charColumn;
                     }

                     if (count % Convert.ToInt32(repeatTextBox.Text) == 0)
                      {
                          initial = initial + Convert.ToInt32(increaseByTextBox.Text);
                          count = 0;
                      }
                  }
              }


            else if (numberInsertRadio.Checked && parent.rtbTab.Focus())
            {
                int count = 0;

                int initial = Convert.ToInt32(initialNumberTextBox.Text);
                int increase = Convert.ToInt32(increaseByTextBox.Text);
                int repeat = Convert.ToInt32(repeatTextBox.Text);

                int index = parent.rtbTab.SelectionStart;
                int line = parent.rtbTab.GetLineFromCharIndex(index);
                int column = parent.rtbTab.SelectionStart - parent.rtbTab.GetFirstCharIndexFromLine(line);

                for (int i = line; i < parent.rtbTab.Lines.Count(); i++)
                {

                    int charColumn = parent.rtbTab.GetFirstCharIndexFromLine(i) + column;
                    int lines = parent.rtbTab.Lines[i].Length - charColumn;

                    if (lines < 0)
                    {
                        string pad = "".PadRight(-lines);
                        parent.rtbTab.Text = parent.rtbTab.Text.Insert(
                        parent.rtbTab.GetFirstCharIndexFromLine(i) + parent.rtbTab.Lines[i].Length, pad);
                        index = parent.rtbTab.GetFirstCharIndexFromLine(i) + column;
                        count++;
                    }

                    parent.rtbTab.Text = parent.rtbTab.Text.Insert(charColumn, initial.ToString());

                    if (parent.rtbTab.TextLength > charColumn)
                    {
                        parent.rtbTab.SelectionStart = charColumn;
                    }

                    if (count % Convert.ToInt32(repeatTextBox.Text) == 0)
                    {
                        initial = initial + Convert.ToInt32(increaseByTextBox.Text);
                        count = 0;
                    }
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

        private void RepeatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}