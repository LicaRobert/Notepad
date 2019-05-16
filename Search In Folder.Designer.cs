namespace OpenSaveTextBox
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.openFileDialogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search In Folder";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(137, 94);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(137, 157);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(237, 20);
            this.folderTextBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(69, 94);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 18);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folder";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(195, 211);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 24);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // openFileDialogBtn
            // 
            this.openFileDialogBtn.Location = new System.Drawing.Point(391, 158);
            this.openFileDialogBtn.Name = "openFileDialogBtn";
            this.openFileDialogBtn.Size = new System.Drawing.Size(33, 23);
            this.openFileDialogBtn.TabIndex = 6;
            this.openFileDialogBtn.Text = "...";
            this.openFileDialogBtn.UseVisualStyleBackColor = true;
            this.openFileDialogBtn.Click += new System.EventHandler(this.openFileDialogBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.openFileDialogBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Search In Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button openFileDialogBtn;
    }
}