namespace OpenSaveTextBox
{
    partial class ColumnEditor
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
            this.radioText = new System.Windows.Forms.RadioButton();
            this.numberInsertRadio = new System.Windows.Forms.RadioButton();
            this.textInsertBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.initialNumberTextBox = new System.Windows.Forms.TextBox();
            this.increaseByTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Checked = true;
            this.radioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioText.Location = new System.Drawing.Point(12, 12);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(101, 20);
            this.radioText.TabIndex = 0;
            this.radioText.TabStop = true;
            this.radioText.Text = "Text to Insert";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.CheckedChanged += new System.EventHandler(this.RadioText_CheckedChanged);
            // 
            // numberInsertRadio
            // 
            this.numberInsertRadio.AutoSize = true;
            this.numberInsertRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInsertRadio.Location = new System.Drawing.Point(15, 102);
            this.numberInsertRadio.Name = "numberInsertRadio";
            this.numberInsertRadio.Size = new System.Drawing.Size(123, 20);
            this.numberInsertRadio.TabIndex = 1;
            this.numberInsertRadio.Text = "Number to Insert";
            this.numberInsertRadio.UseVisualStyleBackColor = true;
            this.numberInsertRadio.CheckedChanged += new System.EventHandler(this.NumberInsertRadio_CheckedChanged);
            // 
            // textInsertBox
            // 
            this.textInsertBox.Location = new System.Drawing.Point(19, 40);
            this.textInsertBox.Name = "textInsertBox";
            this.textInsertBox.Size = new System.Drawing.Size(125, 20);
            this.textInsertBox.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(176, 67);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(176, 22);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(96, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // initialNumberTextBox
            // 
            this.initialNumberTextBox.Location = new System.Drawing.Point(109, 142);
            this.initialNumberTextBox.Name = "initialNumberTextBox";
            this.initialNumberTextBox.Size = new System.Drawing.Size(67, 20);
            this.initialNumberTextBox.TabIndex = 6;
            this.initialNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InitialNumberTextBox_KeyPress);
            // 
            // increaseByTextBox
            // 
            this.increaseByTextBox.Location = new System.Drawing.Point(109, 171);
            this.increaseByTextBox.Name = "increaseByTextBox";
            this.increaseByTextBox.Size = new System.Drawing.Size(67, 20);
            this.increaseByTextBox.TabIndex = 7;
            this.increaseByTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncreaseByTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Initial number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Increase by : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Repeat : ";
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.Location = new System.Drawing.Point(109, 205);
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.Size = new System.Drawing.Size(67, 20);
            this.repeatTextBox.TabIndex = 12;
            this.repeatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatTextBox_KeyPress);
            // 
            // ColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.repeatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.increaseByTextBox);
            this.Controls.Add(this.initialNumberTextBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.textInsertBox);
            this.Controls.Add(this.numberInsertRadio);
            this.Controls.Add(this.radioText);
            this.Name = "ColumnEditor";
            this.Text = "Column Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.RadioButton numberInsertRadio;
        private System.Windows.Forms.TextBox textInsertBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox initialNumberTextBox;
        private System.Windows.Forms.TextBox increaseByTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repeatTextBox;
    }
}