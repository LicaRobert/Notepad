using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenSaveTextBox
{
    public partial class Form1 : Form
    {
        public const int MAXCHARACTERS = 750;

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            InitializeComponent();
            txtArea.Font = new Font("Microsoft Sans Serif", 10);
            myListBox.Visible = false;
            closeListBoxToolStripMenuItem.Visible = false;
        }

        private void FontSizeMenu_Click(object sender, EventArgs e)
        {
            FontDialog fontSize = new FontDialog();

            if (fontSize.ShowDialog() == DialogResult.OK)
            {
                txtArea.Font = fontSize.Font;
            }
        }

        private void FontColorMenu_Click(object sender, EventArgs e)
        {
            ColorDialog fontColor = new ColorDialog();

            fontColor.ShowDialog();
            //txtArea.SelectionColor = fontColor.Color;
            txtArea.ForeColor = fontColor.Color;
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArea.Text = "";
        }

        private void OpenFileMenu_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetFullPath(open.FileName);
                StreamReader read = new StreamReader(File.OpenRead(fullPath));
                txtArea.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void SaveFileMenu_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(txtArea.Text);
                write.Dispose();
            }
        }

        private void FontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontSize = new FontDialog();

            if (fontSize.ShowDialog() == DialogResult.OK)
            {
                txtArea.Font = fontSize.Font;
            }
        }

        private void FontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog fontColor = new ColorDialog();

            fontColor.ShowDialog();
            //txtArea.SelectionColor = fontColor.Color;
            txtArea.ForeColor = fontColor.Color;
        }

        private void SearchFileMenu_Click(object sender, EventArgs e)
        {
            Search form2 = new Search(this);
            form2.Show();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            txtArea.Redo();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            txtArea.Undo();
        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtArea.SelectedText);
            txtArea.SelectedText = string.Empty;
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtArea.SelectedText);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string paste = Clipboard.GetText();
            txtArea.Text = txtArea.Text.Insert(txtArea.SelectionStart, paste);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int GetWidth()
        {
            int w = 15;

            int line = txtArea.Lines.Length;

            if (line <= 99)
            {
                w = 15 + (int)txtArea.Font.Size;
            }
            else if (line <= 999)
            {
                w = 25 + (int)txtArea.Font.Size;
            }
            else
            {
                w = 50 + (int)txtArea.Font.Size;
            }
            return w;
        }

        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);
            int First_Index = txtArea.GetCharIndexFromPosition(pt);
            int First_Line = txtArea.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = txtArea.GetCharIndexFromPosition(pt);
            int Last_Line = txtArea.GetLineFromCharIndex(Last_Index);
            lineNumberRichText.Font = txtArea.Font;
            //lineNumberRichText.Font = new Font("Comic Sans MS", 7);
            //lineNumberRichText.ForeColor = Color.Black;
            lineNumberRichText.ReadOnly = true;
            lineNumberRichText.SelectionAlignment = HorizontalAlignment.Center;
            lineNumberRichText.Text = "";
            lineNumberRichText.Width = GetWidth();
            for (int i = First_Line; i <= Last_Line; i++)
            {
                lineNumberRichText.Text += i + 1 + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lineNumberRichText.Font = txtArea.Font;
            txtArea.Select();
            AddLineNumbers();
        }

        private void txtArea_TextChanged_1(object sender, EventArgs e)
        {
            if (txtArea.Text == "")
            {
                AddLineNumbers();
            }
            if (txtArea.Text.Length > MAXCHARACTERS - 1)
            {
                txtArea.ReadOnly = true;
                MessageBox.Show("You can not enter any more characters.");
            }

            progressBar.Maximum = MAXCHARACTERS;
            progressBar.Step = 1;
            progressBar.Value = txtArea.TextLength;
            progressBar.PerformStep();
        }

        private void TxtArea_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = txtArea.GetPositionFromCharIndex(txtArea.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void TxtArea_VScroll(object sender, EventArgs e)
        {
            lineNumberRichText.Text = "";
            AddLineNumbers();
            lineNumberRichText.Invalidate();
        }

        private void TxtArea_FontChanged(object sender, EventArgs e)
        {
            lineNumberRichText.Font = txtArea.Font;
            txtArea.Select();
            AddLineNumbers();
        }

        private void LineNumberRichText_MouseDown(object sender, MouseEventArgs e)
        {
            txtArea.Select();
            lineNumberRichText.DeselectAll();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void TimeDateMenu_Click(object sender, EventArgs e)
        {
            txtArea.Text = DateTime.Now.ToString();
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtArea.SelectAll();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int charLeft = MAXCHARACTERS - txtArea.Text.Length;
            int index = txtArea.SelectionStart;

            countLabel.Text = "Characters count :" + new string(' ', 2) + txtArea.Text.Length.ToString();

            toolStripStatusLabel1.Text = countLabel.Text.PadLeft(10, ' ');
            toolStripStatusLabel2.Text = "Characters left : ".PadLeft(130, ' ') + charLeft;
            if (txtArea.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArea.SelectedText = "";
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://notepad-plus-plus.org/resources.html");
        }

        public void SelectAll(RichTextBox richTextBox, string word, Color green, bool Bold)
        {
            richTextBox.Select(0, richTextBox.TextLength);
            richTextBox.SelectionBackColor = richTextBox.BackColor;
            richTextBox.SelectionFont = richTextBox.Font;

            if (word == "")
            {
                return;
            }

            int s_start = richTextBox.SelectionStart, startIndex = 0, index;

            while ((index = richTextBox.Text.IndexOf(word, startIndex)) != -1)
            {
                richTextBox.Select(index, word.Length);
                richTextBox.SelectionBackColor = green;
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                startIndex = index + word.Length;
            }

            richTextBox.SelectionStart = s_start;
            richTextBox.SelectionLength = 0;
        }

        private void TxtArea_DoubleClick(object sender, EventArgs e)
        {
            if (myListBox.Visible == true)
            {
                return;
            }
            else
            {
                string word = txtArea.SelectedText;
                SelectAll(txtArea, word, Color.DarkSeaGreen, Font.Bold);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = txtArea.Text;
            string lineNumber = lineNumberRichText.Text;
            txtArea.Clear();
            lineNumberRichText.Clear();
            txtArea.Text = text;
            lineNumberRichText.Text = lineNumber;
        }

        public void MyListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GoToLineListBox lineList = myListBox.SelectedItem as GoToLineListBox;

            int lineNumber = lineList.countLineNumber;
            int index = txtArea.GetFirstCharIndexFromLine(lineNumber - 1);
            txtArea.Select(index, 0);
            txtArea.ScrollToCaret();
            txtArea.Focus();
            closeListBoxToolStripMenuItem.Visible = true;
        }

        private void CloseListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myListBox.Visible = false;
            myListBox.Items.Clear();
            closeListBoxToolStripMenuItem.Visible = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            string path = @"C:\Users\spr_a_000\source\repos\OpenSaveTextBox\fisier.txt";
            if (File.GetLastWriteTime(path) > DateTime.Now.AddSeconds(-2))
            {
                RichTextChanged rich = new RichTextChanged(this);
                rich.Show();
            }
        }
    }
}