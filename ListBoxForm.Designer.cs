namespace OpenSaveTextBox
{
    partial class ListBoxForm
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
            this.myListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // myListBox
            // 
            this.myListBox.FormattingEnabled = true;
            this.myListBox.HorizontalScrollbar = true;
            this.myListBox.Location = new System.Drawing.Point(2, 1);
            this.myListBox.MultiColumn = true;
            this.myListBox.Name = "myListBox";
            this.myListBox.Size = new System.Drawing.Size(482, 95);
            this.myListBox.TabIndex = 0;
            this.myListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myListBox_MouseDoubleClick);
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 97);
            this.Controls.Add(this.myListBox);
            this.Name = "ListBoxForm";
            this.Text = "List Box";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox myListBox;
    }
}