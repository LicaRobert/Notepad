namespace OpenSaveTextBox
{
    partial class Search
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
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.findAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.replaceOne = new System.Windows.Forms.Button();
            this.fontFindChange = new System.Windows.Forms.Button();
            this.ColorFindChange = new System.Windows.Forms.Button();
            this.findAllDoc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find : ";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(65, 63);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(138, 20);
            this.findTextBox.TabIndex = 1;
            this.findTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(274, 56);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(73, 23);
            this.find.TabIndex = 2;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findAll
            // 
            this.findAll.Location = new System.Drawing.Point(272, 103);
            this.findAll.Name = "findAll";
            this.findAll.Size = new System.Drawing.Size(75, 23);
            this.findAll.TabIndex = 3;
            this.findAll.Text = "Find All";
            this.findAll.UseVisualStyleBackColor = true;
            this.findAll.Click += new System.EventHandler(this.FindAll_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(49, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Replace";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace : ";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(65, 238);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(138, 20);
            this.replaceTextBox.TabIndex = 6;
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(128, 273);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(75, 23);
            this.replace.TabIndex = 7;
            this.replace.Text = "Replace All";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(274, 317);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // replaceOne
            // 
            this.replaceOne.Location = new System.Drawing.Point(47, 273);
            this.replaceOne.Name = "replaceOne";
            this.replaceOne.Size = new System.Drawing.Size(75, 23);
            this.replaceOne.TabIndex = 9;
            this.replaceOne.Text = "Replace";
            this.replaceOne.UseVisualStyleBackColor = true;
            this.replaceOne.Click += new System.EventHandler(this.ReplaceOne_Click);
            // 
            // fontFindChange
            // 
            this.fontFindChange.Location = new System.Drawing.Point(138, 131);
            this.fontFindChange.Name = "fontFindChange";
            this.fontFindChange.Size = new System.Drawing.Size(75, 23);
            this.fontFindChange.TabIndex = 10;
            this.fontFindChange.Text = "Word Font";
            this.fontFindChange.UseVisualStyleBackColor = true;
            this.fontFindChange.Click += new System.EventHandler(this.FontFindChange_Click);
            // 
            // ColorFindChange
            // 
            this.ColorFindChange.Location = new System.Drawing.Point(47, 131);
            this.ColorFindChange.Name = "ColorFindChange";
            this.ColorFindChange.Size = new System.Drawing.Size(75, 23);
            this.ColorFindChange.TabIndex = 11;
            this.ColorFindChange.Text = "Word Color";
            this.ColorFindChange.UseVisualStyleBackColor = true;
            this.ColorFindChange.Click += new System.EventHandler(this.ColorFindChange_Click);
            // 
            // findAllDoc
            // 
            this.findAllDoc.Location = new System.Drawing.Point(251, 151);
            this.findAllDoc.Name = "findAllDoc";
            this.findAllDoc.Size = new System.Drawing.Size(112, 37);
            this.findAllDoc.TabIndex = 12;
            this.findAllDoc.Text = "Find all in the curent document";
            this.findAllDoc.UseVisualStyleBackColor = true;
            this.findAllDoc.Click += new System.EventHandler(this.FindAllDoc_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.findAllDoc);
            this.Controls.Add(this.ColorFindChange);
            this.Controls.Add(this.fontFindChange);
            this.Controls.Add(this.replaceOne);
            this.Controls.Add(this.close);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.findAll);
            this.Controls.Add(this.find);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button findAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button replaceOne;
        private System.Windows.Forms.Button fontFindChange;
        private System.Windows.Forms.Button ColorFindChange;
        private System.Windows.Forms.Button findAllDoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public  System.Windows.Forms.TextBox findTextBox;
    }
}