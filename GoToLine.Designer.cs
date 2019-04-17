namespace OpenSaveTextBox
{
    partial class Form3
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
            this.lineNumberLabel = new System.Windows.Forms.Label();
            this.lineNumberTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.goToBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineNumberLabel
            // 
            this.lineNumberLabel.AutoSize = true;
            this.lineNumberLabel.Location = new System.Drawing.Point(12, 22);
            this.lineNumberLabel.Name = "lineNumberLabel";
            this.lineNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.lineNumberLabel.TabIndex = 0;
            this.lineNumberLabel.Text = "Line number :";
            // 
            // lineNumberTextBox
            // 
            this.lineNumberTextBox.Location = new System.Drawing.Point(15, 38);
            this.lineNumberTextBox.Name = "lineNumberTextBox";
            this.lineNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.lineNumberTextBox.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(197, 76);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // goToBtn
            // 
            this.goToBtn.Location = new System.Drawing.Point(116, 76);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(75, 23);
            this.goToBtn.TabIndex = 3;
            this.goToBtn.Text = "Go To";
            this.goToBtn.UseVisualStyleBackColor = true;
            this.goToBtn.Click += new System.EventHandler(this.GoToBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.goToBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.lineNumberTextBox);
            this.Controls.Add(this.lineNumberLabel);
            this.Name = "Form3";
            this.Text = "Go To Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineNumberLabel;
        private System.Windows.Forms.TextBox lineNumberTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button goToBtn;
    }
}