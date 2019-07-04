using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;

namespace OpenSaveTextBox
{
    public partial class Form1 : Form
    {
        RichTextBox richtextbox;
        RichTextBox linetextbox;
        public RichTextBox rtbTab;

        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);

        Image CloseImage;

        OpenFileDialog ofd = new OpenFileDialog();
        string fullPath;
        double clicked = 0;

        Dictionary<String, TabPage> files;
        Dictionary<RichTextBox, UndoRedoStack> undoRedo;

        public string GetOpenFile()
        {
            return fullPath = Path.GetFullPath(ofd.FileName);
        }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            InitializeComponent();
            txtArea.Font = new Font("Courier new", 10);
            myListBox.Visible = true;
            clipboardListBox.Visible = false;
            files = new Dictionary<string, TabPage>();
            undoRedo = new Dictionary<RichTextBox, UndoRedoStack>();
            undoRedo.Add(txtArea, new UndoRedoStack(txtArea));
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
            // txtArea.Text = "";

            int index = 3;
            List<string> keys = new List<string>();
            foreach (string key in files.Keys)
            {
                if (key.StartsWith("New"))
                {
                    keys.Add(key);
                }
            }
            if (keys.Count == 0)
            {
                index = 2;
            }
            else if (keys.Count == 1)
            {
                index = 3;
            }
            else
            {
                keys.Sort();
                index = 3;
                foreach (string s in keys)
                {
                    string resultString = Regex.Match(s, @"\d+").Value;
                    if (resultString.Length == 0)
                        continue;
                    int val = Int32.Parse(resultString);
                    if (val > index)
                    {
                        break;
                    }
                    else if (val == index)
                    {
                        index++;
                    }
                }
            }

            TabPage first = tabControl.TabPages[0];
            RichTextBox txt = first.Controls[0] as RichTextBox;
            RichTextBox txt2 = first.Controls[1] as RichTextBox;
            TabPage page = new TabPage();
            RichTextBox rtb = new RichTextBox();
            RichTextBox rtb2 = new RichTextBox();
           
         
            page.Bounds = first.Bounds;
            rtb.Bounds = txt.Bounds;
            rtb2.Bounds = txt2.Bounds;
            richtextbox = rtb;
            linetextbox = rtb2;
            rtb2.ScrollBars = 0;
            rtb.ShortcutsEnabled = false;
            
           
            rtb.FontChanged += TxtArea_FontChangedTabs;
            rtb.SelectionChanged += TxtArea_SelectionChangedTabs;
            rtb.TextChanged += TxtArea_TextChanged_1;
            rtb.MouseUp += ContextTabs;
            rtb.VScroll += TxtArea_VScrollTabs;

            page.Controls.Add(rtb);
            page.Controls.Add(rtb2);
            UndoRedoStack undoer = new UndoRedoStack(rtb);
            undoRedo[rtb] = undoer;
            string title = index == 0 ? "New" + index : ("New " + index);

            page.Text = title;
            rtb.Text = "";
            files[title] = page;
            tabControl.TabPages.Add(page);
            tabControl.SelectedTab = page;

            rtbTab = rtb;
            rtb.Font  = new Font("Courier new", 10);
        }

        private void TxtArea_TextChanged_1(object sender, EventArgs e)
        {
            if (txtArea.Text == "")
            {
                AddLineNumbers();
            }
            UndoRedoStack u = null;
            foreach (var x in undoRedo)
            {
                if (x.Key.Equals(tabControl.SelectedTab.Controls[0]))
                {
                    u = x.Value;
                }
            }
            var tab = tabControl.SelectedTab.Controls[0] as RichTextBox;
            int y = tab.SelectionStart;
            u.InsertText(tab.Text, y);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                CopyToolStripMenuItem1_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.V))
            {
                PasteToolStripMenuItem1_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.U))
            {
                CutToolStripMenuItem1_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.D))
            {
                DeleteToolStripMenuItem_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.A))
            {
                SelectAllToolStripMenuItem1_Click(null, null);
            }
            else if (e.KeyData == (Keys.Control | Keys.Z))
            {
                UndoRedoStack u = null;
                foreach (var x in undoRedo)
                {
                    if (x.Key.Equals(tabControl.SelectedTab.Controls[0]))
                    {
                        u = x.Value;
                    }
                }
                u.Undo();
            }

            else if (e.KeyData == (Keys.Control | Keys.Y))
            {
                UndoRedoStack u = null;
                foreach (var x in undoRedo)
                {
                    if (x.Key.Equals(tabControl.SelectedTab.Controls[0]))
                    {
                        u = x.Value;
                    }
                }
                u.Redo();
            }



            if (txtArea.Focused)
            {
                int index = txtArea.SelectionStart;
                int line = txtArea.GetLineFromCharIndex(index);

                int firstChar = txtArea.GetFirstCharIndexFromLine(line);
                int column = index - firstChar;

                if (txtArea.Focused == true)
                {
                    label2.Visible = false;
                }

                label1.Text = "Line : " + line + " Column : " + column;
            }
            else if (rtbTab.Focused)
            {
                int index2 = rtbTab.SelectionStart;
                int line2 = rtbTab.GetLineFromCharIndex(index2);

                int firstChar2 = rtbTab.GetFirstCharIndexFromLine(line2);
                int column2 = index2 - firstChar2;

                if (rtbTab.Focused == true)
                {
                    label1.Visible = false;
                    label2.Visible = true;
                }

                label2.Text = "Line : " + line2 + " Column : " + column2;
            }
        }

        private void OpenFileMenu_Click_1(object sender, EventArgs e)
        {
            /*  OpenFileDialog open = new OpenFileDialog();
              open.Title = "Open File";
              if (open.ShowDialog() == DialogResult.OK)
              {
                  StreamReader read = new StreamReader(File.OpenRead(GetOpenFile()));
                  txtArea.Text = read.ReadToEnd();
                  read.Dispose();
              }*/

            ofd.Filter = "(*.txt)|*.txt";

            DialogResult res = ofd.ShowDialog(this);

            if (res == DialogResult.OK && ofd.FileName.Length > 0)
            {
                string file = ofd.FileName;

                if (files.ContainsKey(file))
                {
                    TabPage page = files[file];
                    RichTextBox rtb = page.Controls[0] as RichTextBox;
                    rtb.Text = File.ReadAllText(file);
                    tabControl.SelectedTab = page;
                }
                else
                {
                    TabPage first = tabControl.TabPages[0];
                    RichTextBox txt = first.Controls[0] as RichTextBox;
                    RichTextBox txt2 = first.Controls[1] as RichTextBox;
                    if (txt.TextLength == 0 && first.Text == "New")
                    {
                        FileInfo info = new FileInfo(file);
                        first.Text = info.Name;
                        txt.Text = File.ReadAllText(file);
                        files.Remove("New");
                        files[file] = first;
                        tabControl.SelectedTab = first;
                    }
                    else
                    {
                        TabPage page = new TabPage();
                        RichTextBox rtb = new RichTextBox();
                        RichTextBox rtb2 = new RichTextBox();
                        page.Bounds = first.Bounds;
                        rtb.Bounds = txt.Bounds;
                        rtb2.Bounds = txt2.Bounds;
                        rtb2.ScrollBars = 0;
                        richtextbox = rtb;
                        linetextbox = rtb2;
                        rtb.SelectionChanged += TxtArea_SelectionChangedTabs;
                        rtb.TextChanged += TxtArea_TextChanged_1;
                        rtb.VScroll += TxtArea_VScrollTabs;
                        rtb.FontChanged += TxtArea_FontChangedTabs;

                        page.Controls.Add(rtb);
                        page.Controls.Add(rtb2);
                        FileInfo info = new FileInfo(file);
                        page.Text = info.Name;
                        rtb.Text = File.ReadAllText(file);
                        files[file] = page;
                        tabControl.TabPages.Add(page);
                        tabControl.SelectedTab = page;
                    }
                    txtArea.Font = new Font("Microsoft Sans Serif", 10);
                }
            }
        }

        private void SaveFileMenu_Click_1(object sender, EventArgs e)
        {
            /* SaveFileDialog save = new SaveFileDialog();
             save.Title = "Save File";

             if (save.ShowDialog() == DialogResult.OK)
             {
                 StreamWriter write = new StreamWriter(File.Create(save.FileName));
                 write.Write(txtArea.Text);
                 write.Dispose();
             }*/

            TabPage crt = tabControl.SelectedTab;
            RichTextBox rtb = crt.Controls[0] as RichTextBox;
            string key = crt.Text;
            foreach (string s in files.Keys)
            {
                if (files[s] == crt)
                {
                    key = s;
                    break;
                }
            }
            if (key.StartsWith("New") && !key.EndsWith(".txt"))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "(*.txt)|*.txt";
                saveFileDialog1.Title = "Save a Text File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    if (files.ContainsKey(saveFileDialog1.FileName))
                    {
                        MessageBox.Show("This file already is open");
                        return;
                    }
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    byte[] bytes = Encoding.ASCII.GetBytes(rtb.Text);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                    FileInfo info = new FileInfo(saveFileDialog1.FileName);
                    crt.Text = info.Name;
                    files.Remove(key);
                    files[saveFileDialog1.FileName] = crt;
                }
            }
            else
            {
                File.WriteAllText(key, rtb.Text);
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
        
        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex > 0)
                {
                   Clipboard.SetText(rtbTab.SelectedText);
                   rtbTab.SelectedText = string.Empty;
                }
                else if (txtArea.SelectedText != null)
                {
                   Clipboard.SetText(txtArea.SelectedText);
                   txtArea.SelectedText = string.Empty;
                }
            }
            catch(Exception)
            {

            }
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                clipboardListBox.Visible = true;

                if (tabControl.SelectedIndex > 0 && !clipboardListBox.Items.Contains(rtbTab.SelectedText))
                {
                    Clipboard.SetText(rtbTab.SelectedText);

                    clipboardListBox.Items.Add(rtbTab.SelectedText);
                }
                else if (!clipboardListBox.Items.Contains(txtArea.SelectedText))
                {
                    Clipboard.SetText(txtArea.SelectedText);

                    if (txtArea.SelectedText != "")
                    {
                        clipboardListBox.Items.Add(txtArea.SelectedText);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtArea.SelectedText = "";

            string paste = Clipboard.GetText();

            try
            {
                if (clipboardListBox.SelectedItem != null && txtArea.Focused)
                {
                    int i = txtArea.SelectionStart;
                    txtArea.Text = txtArea.Text.Insert(txtArea.SelectionStart, clipboardListBox.SelectedItem.ToString());
                    txtArea.SelectionStart = i + clipboardListBox.SelectedItem.ToString().Length;
                }
                else if (clipboardListBox.SelectedItem == null && txtArea.Focused)
                {
                    int i = txtArea.SelectionStart;
                    txtArea.Text = txtArea.Text.Insert(txtArea.SelectionStart, paste);
                    txtArea.SelectionStart = i + Clipboard.GetText().Length;
                }

                if (clipboardListBox.SelectedItem != null && rtbTab.Focused)
                {
                    int i = rtbTab.SelectionStart;
                    rtbTab.Text = txtArea.Text.Insert(rtbTab.SelectionStart, clipboardListBox.SelectedItem.ToString());
                    rtbTab.SelectionStart = i + clipboardListBox.SelectedItem.ToString().Length;
                }
                else if (clipboardListBox.SelectedItem == null && rtbTab.Focused)
                {
                    int i = txtArea.SelectionStart;
                    rtbTab.Text = txtArea.Text.Insert(rtbTab.SelectionStart, paste);
                    rtbTab.SelectionStart = i + Clipboard.GetText().Length;
                }
            }
            catch(Exception)
            {

            }
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

        public int GetWidthTabs()
        {
            int w = 15;
            int line = richtextbox.Lines.Length;

            if (line <= 99)
            {
                w = 15 + (int)richtextbox.Font.Size;
            }
            else if (line <= 999)
            {
                w = 25 + (int)richtextbox.Font.Size;
            }
            else
            {
                w = 50 + (int)richtextbox.Font.Size;
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

        public void AddLineNumbersTabs()
        {
            Point pt = new Point(0, 0);
            int First_Index = richtextbox.GetCharIndexFromPosition(pt);
            int First_Line = richtextbox.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = richtextbox.GetCharIndexFromPosition(pt);
            int Last_Line = richtextbox.GetLineFromCharIndex(Last_Index);
            linetextbox.Font = richtextbox.Font;

            linetextbox.ReadOnly = true;
            linetextbox.SelectionAlignment = HorizontalAlignment.Center;
            linetextbox.Text = "";
            linetextbox.Width = GetWidthTabs();
            for (int i = First_Line; i <= Last_Line; i++)
            {
                linetextbox.Text += i + 1 + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lineNumberRichText.Font = txtArea.Font;
            txtArea.Select();
            AddLineNumbers();


            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;
            CloseImage = Properties.Resources.download1;
            tabControl.Padding = new Point(10, 3);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tabControl.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.tabControl.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

                if (tabControl.SelectedIndex >= 1)
                {
                    e.Graphics.DrawImage(img, new Point(r.X +
                    (this.tabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }
            }
            catch (Exception)
            {

            }
        }

        private void TxtArea_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = txtArea.GetPositionFromCharIndex(txtArea.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }
        private void TxtArea_SelectionChangedTabs(object sender, EventArgs e)
        {
            Point pt = richtextbox.GetPositionFromCharIndex(richtextbox.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbersTabs();
            }
        }
        private void TxtArea_VScrollTabs(object sender, EventArgs e)
        {
            linetextbox.Text = "";
            AddLineNumbersTabs();
            linetextbox.Invalidate();
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

        private void TxtArea_FontChangedTabs(object sender, EventArgs e)
        {
            linetextbox.Font = richtextbox.Font;
            richtextbox.Select();
            AddLineNumbersTabs();
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
            try
            {
                txtArea.Text = DateTime.Now.ToString();
                rtbTab.Text = DateTime.Now.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtArea.SelectedText != null)
            {
                txtArea.SelectAll();
            }
            else if (tabControl.SelectedIndex > 0)
            {
                rtbTab.SelectAll();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int index = txtArea.SelectionStart;

            if (txtArea.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {       
              txtArea.SelectedText = "";
              rtbTab.SelectedText = "";    
            }
            catch(Exception)
            {

            }
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

        private void TxtArea_DoubleClickTabs(object sender, EventArgs e)
        {
            if (myListBox.Visible == true)
            {
                return;
            }
            else
            {
                string word = richtextbox.SelectedText;
                SelectAll(richtextbox, word, Color.DarkSeaGreen, Font.Bold);
            }
        }

        public void MyListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabPage selectedTab1 = tabControl.SelectedTab;
            RichTextBox selectedRichTextBox1 = selectedTab1.Controls[0] as RichTextBox;
            selectedRichTextBox1.SelectionFont = selectedRichTextBox1.Font;
            SearchedItems lineList = myListBox.SelectedItem as SearchedItems;
            if (lineList != null)
            {
                string file = lineList.filePath;

                if (files.ContainsKey(file))
                {
                    TabPage page = files[file];
                    RichTextBox rtb = page.Controls[0] as RichTextBox;
                    rtb.Text = File.ReadAllText(file);
                    tabControl.SelectedTab = page;
                }
                else
                {
                    TabPage first = tabControl.TabPages[0];
                    RichTextBox txt = first.Controls[0] as RichTextBox;
                    RichTextBox txt2 = first.Controls[1] as RichTextBox;
                    if (txt.TextLength == 0 && first.Text == "New")
                    {
                        FileInfo info = new FileInfo(file);
                        first.Text = info.Name;
                        txt.Text = File.ReadAllText(file);
                        files.Remove("New");
                        files[file] = first;
                        tabControl.SelectedTab = first;
                    }
                    else
                    {
                        TabPage page = new TabPage();
                        RichTextBox rtb = new RichTextBox();
                        RichTextBox rtb2 = new RichTextBox();
                        page.Bounds = first.Bounds;
                        rtb.Bounds = txt.Bounds;
                        rtb2.Bounds = txt2.Bounds;
                        rtb2.ScrollBars = 0;
                        richtextbox = rtb;
                        linetextbox = rtb2;
                        rtb.SelectionChanged += TxtArea_SelectionChangedTabs;
                        rtb.TextChanged += TxtArea_TextChanged_1;
                        rtb.VScroll += TxtArea_VScrollTabs;
                        rtb.FontChanged += TxtArea_FontChangedTabs;

                        page.Controls.Add(rtb);
                        page.Controls.Add(rtb2);
                        FileInfo info = new FileInfo(file);
                        page.Text = info.Name;
                        rtb.Text = File.ReadAllText(file);
                        files[file] = page;
                        tabControl.TabPages.Add(page);
                        tabControl.SelectedTab = page;
                    }
                }

                AddLineNumbersTabs();
                int lineNumber = lineList.LineNumber;
                TabPage selectedTab = tabControl.SelectedTab;
                RichTextBox selectedRichTextBox = selectedTab.Controls[0] as RichTextBox;
                int index = selectedRichTextBox.GetFirstCharIndexFromLine(lineNumber - 1);
                selectedRichTextBox.SelectionStart = selectedRichTextBox.GetFirstCharIndexFromLine(lineNumber - 1);
                selectedRichTextBox.SelectionLength = lineList.LineText.Count();
                selectedRichTextBox.ScrollToCaret();
                selectedRichTextBox.Focus();
            }
        }

        private void CloseListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myListBox.Visible = false;
            myListBox.Items.Clear();
            string text = txtArea.Text;
            string lineNumber = lineNumberRichText.Text;
            txtArea.Clear();
            lineNumberRichText.Clear();
            txtArea.Text = text;
            lineNumberRichText.Text = lineNumber;
        }

        private void FileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            string path = GetOpenFile();

            DateTime getLastWrite = File.GetLastWriteTime(path);

            if (clicked < getLastWrite.TimeOfDay.TotalMilliseconds)
            {
                clicked = getLastWrite.Ticks;

                fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
                fileSystemWatcher1.Filter = "*.txt";
                fileSystemWatcher1.IncludeSubdirectories = true;
                fileSystemWatcher1.EnableRaisingEvents = true;
                RichTextChanged rich = new RichTextChanged(this);
                rich.Show();
            }
        }

        private void UpperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArea.SelectedText = txtArea.SelectedText.ToUpper();
        }

        private void LowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArea.SelectedText = txtArea.SelectedText.ToLower();
        }

        private void SearchInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(myListBox);
        }

        private void CloseClipboard_Click(object sender, EventArgs e)
        {
            clipboardListBox.Visible = false;
            clipboardListBox.Items.Clear();
        }

        private void ClipboardListBox_DoubleClick(object sender, EventArgs e)
        {

             if (tabControl.SelectedIndex > 0)
              {
                 int j = rtbTab.SelectionStart;

                 rtbTab.Text = rtbTab.Text.Insert(rtbTab.SelectionStart, clipboardListBox.SelectedItem.ToString());
                 rtbTab.SelectionStart = j + clipboardListBox.SelectedItem.ToString().Length;
                 rtbTab.Focus();
              }
             else
              {
                 int i = txtArea.SelectionStart;

                 txtArea.Text = txtArea.Text.Insert(txtArea.SelectionStart, clipboardListBox.SelectedItem.ToString());
                 txtArea.SelectionStart = i + clipboardListBox.SelectedItem.ToString().Length;
                 txtArea.Focus();
              }
        }

        private void ContextTabs(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Context.Show(tabControl, e.Location);
            }
        }

        private void ColumnEditor_Click(object sender, EventArgs e)
        {
            ColumnEditor column = new ColumnEditor(this);
            column.Show();
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControl.SelectedIndex >= 1)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);
                }
            }
        }

        private void ClearClipboardHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clipboardListBox.Items != null)
            {
                clipboardListBox.Items.Clear();
            }
        }

        private void ClipboardHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clipboardListBox.Visible == false)
            {
                clipboardListBox.Visible = true;
            }
            else
            {
                clipboardListBox.Visible = false;
            }
        }
    }
}