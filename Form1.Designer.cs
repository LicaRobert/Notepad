namespace OpenSaveTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upperCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboardHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumberRichText = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lineLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.myListBox = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.clipboardListBox = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Context.SuspendLayout();
            this.openMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.ContextMenuStrip = this.Context;
            this.txtArea.Location = new System.Drawing.Point(20, 0);
            this.txtArea.Name = "txtArea";
            this.txtArea.ShortcutsEnabled = false;
            this.txtArea.Size = new System.Drawing.Size(505, 211);
            this.txtArea.TabIndex = 0;
            this.txtArea.Text = "";
            this.txtArea.SelectionChanged += new System.EventHandler(this.TxtArea_SelectionChanged);
            this.txtArea.VScroll += new System.EventHandler(this.TxtArea_VScroll);
            this.txtArea.FontChanged += new System.EventHandler(this.TxtArea_FontChanged);
            this.txtArea.TextChanged += new System.EventHandler(this.TxtArea_TextChanged_1);
            this.txtArea.DoubleClick += new System.EventHandler(this.TxtArea_DoubleClick);
            // 
            // Context
            // 
            this.Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem1,
            this.upperCaseToolStripMenuItem,
            this.lowerCaseToolStripMenuItem,
            this.clearClipboardHistoryToolStripMenuItem});
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(165, 180);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.SelectAllToolStripMenuItem1_Click);
            // 
            // upperCaseToolStripMenuItem
            // 
            this.upperCaseToolStripMenuItem.Name = "upperCaseToolStripMenuItem";
            this.upperCaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.upperCaseToolStripMenuItem.Text = "Upper Case";
            this.upperCaseToolStripMenuItem.Click += new System.EventHandler(this.UpperCaseToolStripMenuItem_Click);
            // 
            // lowerCaseToolStripMenuItem
            // 
            this.lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem";
            this.lowerCaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.lowerCaseToolStripMenuItem.Text = "Lower Case";
            this.lowerCaseToolStripMenuItem.Click += new System.EventHandler(this.LowerCaseToolStripMenuItem_Click);
            // 
            // clearClipboardHistoryToolStripMenuItem
            // 
            this.clearClipboardHistoryToolStripMenuItem.Name = "clearClipboardHistoryToolStripMenuItem";
            this.clearClipboardHistoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearClipboardHistoryToolStripMenuItem.Text = "Clear Clipboard";
            this.clearClipboardHistoryToolStripMenuItem.Click += new System.EventHandler(this.ClearClipboardHistoryToolStripMenuItem_Click);
            // 
            // openMenu
            // 
            this.openMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.openMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.openMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editMenu,
            this.fontToolStripMenuItem,
            this.searchFileMenu,
            this.searchInFolderToolStripMenuItem,
            this.timeDateMenu,
            this.helpToolStripMenuItem});
            this.openMenu.Location = new System.Drawing.Point(0, 0);
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(417, 24);
            this.openMenu.TabIndex = 8;
            this.openMenu.Text = "Open File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileMenu,
            this.saveFileMenu,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(167, 22);
            this.openFileMenu.Text = "Open File";
            this.openFileMenu.Click += new System.EventHandler(this.OpenFileMenu_Click_1);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(167, 22);
            this.saveFileMenu.Text = "Save File ";
            this.saveFileMenu.Click += new System.EventHandler(this.SaveFileMenu_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.columnEditor,
            this.clipboardHistoryToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.goToToolStripMenuItem.Text = "Go to...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.GoToToolStripMenuItem_Click);
            // 
            // columnEditor
            // 
            this.columnEditor.Name = "columnEditor";
            this.columnEditor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.columnEditor.Size = new System.Drawing.Size(210, 22);
            this.columnEditor.Text = "Column Editor";
            this.columnEditor.Click += new System.EventHandler(this.ColumnEditor_Click);
            // 
            // clipboardHistoryToolStripMenuItem
            // 
            this.clipboardHistoryToolStripMenuItem.Name = "clipboardHistoryToolStripMenuItem";
            this.clipboardHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.clipboardHistoryToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.clipboardHistoryToolStripMenuItem.Text = "Clipboard History";
            this.clipboardHistoryToolStripMenuItem.Click += new System.EventHandler(this.ClipboardHistoryToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem1,
            this.fontColorToolStripMenuItem1});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fontToolStripMenuItem.Text = "Format";
            // 
            // fontSizeToolStripMenuItem1
            // 
            this.fontSizeToolStripMenuItem1.Name = "fontSizeToolStripMenuItem1";
            this.fontSizeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontSizeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.fontSizeToolStripMenuItem1.Text = "Font Size";
            this.fontSizeToolStripMenuItem1.Click += new System.EventHandler(this.FontSizeToolStripMenuItem1_Click);
            // 
            // fontColorToolStripMenuItem1
            // 
            this.fontColorToolStripMenuItem1.Name = "fontColorToolStripMenuItem1";
            this.fontColorToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.fontColorToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.fontColorToolStripMenuItem1.Text = "Font Color";
            this.fontColorToolStripMenuItem1.Click += new System.EventHandler(this.FontColorToolStripMenuItem1_Click);
            // 
            // searchFileMenu
            // 
            this.searchFileMenu.Name = "searchFileMenu";
            this.searchFileMenu.Size = new System.Drawing.Size(54, 20);
            this.searchFileMenu.Text = "Search";
            this.searchFileMenu.Click += new System.EventHandler(this.SearchFileMenu_Click);
            // 
            // searchInFolderToolStripMenuItem
            // 
            this.searchInFolderToolStripMenuItem.Name = "searchInFolderToolStripMenuItem";
            this.searchInFolderToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.searchInFolderToolStripMenuItem.Text = "Search In Folder";
            this.searchInFolderToolStripMenuItem.Click += new System.EventHandler(this.SearchInFolderToolStripMenuItem_Click);
            // 
            // timeDateMenu
            // 
            this.timeDateMenu.Name = "timeDateMenu";
            this.timeDateMenu.Size = new System.Drawing.Size(75, 20);
            this.timeDateMenu.Text = "Time/Date";
            this.timeDateMenu.Click += new System.EventHandler(this.TimeDateMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // lineNumberRichText
            // 
            this.lineNumberRichText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineNumberRichText.BackColor = System.Drawing.Color.White;
            this.lineNumberRichText.Location = new System.Drawing.Point(-4, 1);
            this.lineNumberRichText.Name = "lineNumberRichText";
            this.lineNumberRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberRichText.Size = new System.Drawing.Size(63, 210);
            this.lineNumberRichText.TabIndex = 11;
            this.lineNumberRichText.Text = "";
            this.lineNumberRichText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberRichText_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.SystemColors.Control;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineLabel.Location = new System.Drawing.Point(0, 21);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(606, 2);
            this.lineLabel.TabIndex = 14;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(309, 317);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 13);
            this.countLabel.TabIndex = 9;
            // 
            // myListBox
            // 
            this.myListBox.FormattingEnabled = true;
            this.myListBox.Location = new System.Drawing.Point(0, 274);
            this.myListBox.MultiColumn = true;
            this.myListBox.Name = "myListBox";
            this.myListBox.Size = new System.Drawing.Size(575, 56);
            this.myListBox.TabIndex = 15;
            this.myListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyListBox_MouseDoubleClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.txt*";
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.Path = "C:\\Users\\spr_a_000\\source\\repos\\OpenSaveTextBox";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Changed);
            // 
            // clipboardListBox
            // 
            this.clipboardListBox.FormattingEnabled = true;
            this.clipboardListBox.Location = new System.Drawing.Point(530, 50);
            this.clipboardListBox.Name = "clipboardListBox";
            this.clipboardListBox.Size = new System.Drawing.Size(43, 212);
            this.clipboardListBox.TabIndex = 16;
            this.clipboardListBox.DoubleClick += new System.EventHandler(this.ClipboardListBox_DoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(530, 231);
            this.tabControl.TabIndex = 17;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.lineNumberRichText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.clipboardListBox);
            this.Controls.Add(this.myListBox);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.openMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Context.ResumeLayout(false);
            this.openMenu.ResumeLayout(false);
            this.openMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip openMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchFileMenu;
        public System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Context;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label countLabel;
        public System.Windows.Forms.RichTextBox lineNumberRichText;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.ListBox myListBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem upperCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchInFolderToolStripMenuItem;
        private System.Windows.Forms.ListBox clipboardListBox;
        private System.Windows.Forms.ToolStripMenuItem columnEditor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

