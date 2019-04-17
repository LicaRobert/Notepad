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
    public partial class Search : Form
    {

        Form1 parent;

        int t = 0;
        int result = 0;

        public Search(Form1 p)
        {

            parent = p;
            InitializeComponent();

            replace.Visible = false;
            replaceOne.Visible = false;
            replaceTextBox.Visible = false;
            replace.Visible = false;
            label2.Visible = false;
            fontFindChange.Visible = false;
            ColorFindChange.Visible = false;
            this.Text = "Search";

        }

        private void FontFindChange()
        {
            FontDialog fontSize = new FontDialog();
            if (fontSize.ShowDialog() == DialogResult.OK)
            {
                parent.txtArea.SelectionFont = fontSize.Font;
            }
        }
        private void FontFindChange_Click(object sender, EventArgs e)
        {
            FontFindChange();
        }
        private void ColorFindChange_Click(object sender, EventArgs e)
        {
            ColorDialog fontColor = new ColorDialog();
            fontColor.ShowDialog();
            parent.txtArea.SelectionColor = fontColor.Color;
        }

        private void FindNext()
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word to be searched.");
                find.Text = "Find";
                return;
            }

            find.Text = "Find Next";
            fontFindChange.Visible = true;
            ColorFindChange.Visible = true;

            string x = "";

            for (int i = t; i < parent.txtArea.TextLength - findTextBox.TextLength; i++)
            {
                for (int j = 0; j < findTextBox.TextLength; j++)
                {

                    if (findTextBox.Text[j] == parent.txtArea.Text[i + j])
                    {
                        x = x + parent.txtArea.Text[i + j] + "";
                    }
                    else
                    {
                        x = "";
                    }
                }
                if (x == findTextBox.Text)
                {
                    t = i + 1;
                    parent.txtArea.SelectAll();
                    parent.txtArea.SelectionBackColor = Color.White;
                    parent.txtArea.Select(i, findTextBox.TextLength);
                    parent.txtArea.SelectionBackColor = Color.LightSkyBlue;
                    result++;
                    break;
                }
                if (i == parent.txtArea.TextLength - findTextBox.TextLength - 1)
                {
                    if (result > 0)
                    {
                        MessageBox.Show("The search was completed");
                        replace.Visible = false;
                        replaceOne.Visible = false;
                        replaceTextBox.Visible = false;
                        replace.Visible = false;
                        label2.Visible = false;
                        checkBox1.Checked = false;
                        fontFindChange.Visible = false;
                        ColorFindChange.Visible = false;
                        findTextBox.Text = "";
                        break;
                    }
                    else
                    {
                        fontFindChange.Visible = false;
                        ColorFindChange.Visible = false;
                        find.Text = "Find";
                        MessageBox.Show("No results");
                        break;
                    }
                }
            }
        }

        private static void FindAll(RichTextBox richTextBox, String word, Color color, bool Bold)
        {
            int s_start = richTextBox.SelectionStart, startIndex = 0, index;

            while ((index = richTextBox.Text.IndexOf(word, startIndex)) != -1)
            {
                richTextBox.Select(index, word.Length);
                richTextBox.SelectionColor = color;
                richTextBox.SelectionBackColor = Color.DeepSkyBlue;
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                startIndex = index + word.Length;
            }
        }

        private void FindAll_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word to be searched.");
                return;
            }
            else
            {
                FindAll(parent.txtArea, findTextBox.Text, Color.Yellow, Font.Bold);
                parent.txtArea.DeselectAll();
            }
        }

        private void FindAllDoc_Click(object sender, EventArgs e)
         {

            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word to be searched.");
                return;
            }

            parent.myListBox.Visible = true;

            int count = 0;

            List<string> items = new List<string>();

            var lineNumber = parent.txtArea.Lines;

            foreach (var lineText in lineNumber)
            {
                count++;

                  if (lineText.Contains(findTextBox.Text))
                  {
                    GoToLineListBox lineList = new GoToLineListBox();
                    lineList.countLineNumber = count;
                    lineList.countLineText = lineText;
                    parent.myListBox.Items.Add(lineList);
                    items.Add(lineText);
                }
            }

            FindAll(parent.txtArea, findTextBox.Text, Color.Yellow, Font.Bold);
            parent.txtArea.DeselectAll();

            Close();
        }

        private void find_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void ReplaceOne_Click(object sender, EventArgs e)
        {

            if (replaceTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word to be replaced.");
                find.Text = "Find";
                return;
            }
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word in the find search.");
                return;
            }
            if (findTextBox.Text == parent.txtArea.SelectedText)
            {
                findTextBox.Text = parent.txtArea.SelectedText;
                parent.txtArea.SelectedText = replaceTextBox.Text;
                parent.txtArea.Font = new Font("Microsoft Sans Serif", 10);
                parent.txtArea.SelectionColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Please find a word to be replace.");
                return;
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            if (replaceTextBox.Text == "")
            {
                MessageBox.Show("Please insert a word to be replace.");
                return;
            }

            parent.txtArea.Text = parent.txtArea.Text.Replace(findTextBox.Text, replaceTextBox.Text);
            findTextBox.Text = replaceTextBox.Text;
            parent.txtArea.Font = new Font("Microsoft Sans Serif", 10);
            parent.txtArea.SelectionColor = Color.Black;
            replaceTextBox.Text = "";

        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            parent.txtArea.SelectAll();
            parent.txtArea.SelectionBackColor = Color.White;
            result = 0;
            t = 0;
            this.findTextBox.Text = findTextBox.Text;
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                replace.Visible = true;
                replaceOne.Visible = true;
                replaceTextBox.Visible = true;
                replace.Visible = true;
                label2.Visible = true;
                this.Text = "Search And Replace";
            }
            else
            {
                replace.Visible = false;
                replaceOne.Visible = false;
                replaceTextBox.Visible = false;
                replace.Visible = false;
                label2.Visible = false;
                replaceTextBox.Text = "";
                this.Text = "Search";
            }
        }

    }
}
