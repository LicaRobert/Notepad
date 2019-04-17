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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumberRichText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lineLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myListBox = new System.Windows.Forms.ListBox();
            this.Context.SuspendLayout();
            this.openMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.ContextMenuStrip = this.Context;
            this.txtArea.Location = new System.Drawing.Point(30, 27);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(572, 268);
            this.txtArea.TabIndex = 0;
            this.txtArea.Text = "";
            this.txtArea.SelectionChanged += new System.EventHandler(this.TxtArea_SelectionChanged);
            this.txtArea.VScroll += new System.EventHandler(this.TxtArea_VScroll);
            this.txtArea.FontChanged += new System.EventHandler(this.TxtArea_FontChanged);
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged_1);
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
            this.refreshToolStripMenuItem,
            this.closeListBoxToolStripMenuItem});
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(165, 158);
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
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // closeListBoxToolStripMenuItem
            // 
            this.closeListBoxToolStripMenuItem.Name = "closeListBoxToolStripMenuItem";
            this.closeListBoxToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeListBoxToolStripMenuItem.Text = "Close ListBox";
            this.closeListBoxToolStripMenuItem.Click += new System.EventHandler(this.CloseListBoxToolStripMenuItem_Click);
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
            this.undo,
            this.redo,
            this.timeDateMenu,
            this.helpToolStripMenuItem});
            this.openMenu.Location = new System.Drawing.Point(0, 0);
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(528, 24);
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
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(180, 22);
            this.openFileMenu.Text = "Open File";
            this.openFileMenu.Click += new System.EventHandler(this.OpenFileMenu_Click_1);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenu.Text = "Save File ";
            this.saveFileMenu.Click += new System.EventHandler(this.SaveFileMenu_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.goToToolStripMenuItem.Text = "Go to...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.GoToToolStripMenuItem_Click);
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
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(48, 20);
            this.undo.Text = "Undo";
            this.undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // redo
            // 
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(46, 20);
            this.redo.Text = "Redo";
            this.redo.Click += new System.EventHandler(this.Redo_Click);
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
            this.lineNumberRichText.Location = new System.Drawing.Point(0, 27);
            this.lineNumberRichText.Name = "lineNumberRichText";
            this.lineNumberRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberRichText.Size = new System.Drawing.Size(25, 268);
            this.lineNumberRichText.TabIndex = 11;
            this.lineNumberRichText.Text = "";
            this.lineNumberRichText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberRichText_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(0, 295);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(603, 17);
            this.progressBar.TabIndex = 13;
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
            this.myListBox.Location = new System.Drawing.Point(31, 200);
            this.myListBox.MultiColumn = true;
            this.myListBox.Name = "myListBox";
            this.myListBox.Size = new System.Drawing.Size(545, 95);
            this.myListBox.TabIndex = 15;
            this.myListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyListBox_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(577, 328);
            this.Controls.Add(this.myListBox);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lineNumberRichText);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.openMenu);
            this.Controls.Add(this.txtArea);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Notepad";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Context.ResumeLayout(false);
            this.openMenu.ResumeLayout(false);
            this.openMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ContextMenuStrip Context;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label countLabel;
        public System.Windows.Forms.RichTextBox lineNumberRichText;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.ListBox myListBox;
        private System.Windows.Forms.ToolStripMenuItem closeListBoxToolStripMenuItem;
    }
}

