namespace WF_HW1
{
    partial class Form8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inYear = new System.Windows.Forms.RadioButton();
            this.inMonth = new System.Windows.Forms.RadioButton();
            this.inHours = new System.Windows.Forms.RadioButton();
            this.inMinute = new System.Windows.Forms.RadioButton();
            this.inSecunde = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "11.12.2023";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inYear
            // 
            this.inYear.AutoSize = true;
            this.inYear.Checked = true;
            this.inYear.Location = new System.Drawing.Point(11, 17);
            this.inYear.Name = "inYear";
            this.inYear.Size = new System.Drawing.Size(62, 17);
            this.inYear.TabIndex = 3;
            this.inYear.TabStop = true;
            this.inYear.Text = "в годах";
            this.inYear.UseVisualStyleBackColor = true;
            // 
            // inMonth
            // 
            this.inMonth.AutoSize = true;
            this.inMonth.Location = new System.Drawing.Point(11, 40);
            this.inMonth.Name = "inMonth";
            this.inMonth.Size = new System.Drawing.Size(77, 17);
            this.inMonth.TabIndex = 4;
            this.inMonth.TabStop = true;
            this.inMonth.Text = "в месяцах";
            this.inMonth.UseVisualStyleBackColor = true;
            // 
            // inHours
            // 
            this.inHours.AutoSize = true;
            this.inHours.Location = new System.Drawing.Point(11, 63);
            this.inHours.Name = "inHours";
            this.inHours.Size = new System.Drawing.Size(62, 17);
            this.inHours.TabIndex = 5;
            this.inHours.TabStop = true;
            this.inHours.Text = "в часах";
            this.inHours.UseVisualStyleBackColor = true;
            // 
            // inMinute
            // 
            this.inMinute.AutoSize = true;
            this.inMinute.Location = new System.Drawing.Point(11, 86);
            this.inMinute.Name = "inMinute";
            this.inMinute.Size = new System.Drawing.Size(75, 17);
            this.inMinute.TabIndex = 6;
            this.inMinute.TabStop = true;
            this.inMinute.Text = "в минутах";
            this.inMinute.UseVisualStyleBackColor = true;
            // 
            // inSecunde
            // 
            this.inSecunde.AutoSize = true;
            this.inSecunde.Location = new System.Drawing.Point(11, 109);
            this.inSecunde.Name = "inSecunde";
            this.inSecunde.Size = new System.Drawing.Size(80, 17);
            this.inSecunde.TabIndex = 7;
            this.inSecunde.TabStop = true;
            this.inSecunde.Text = "в секундах";
            this.inSecunde.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inSecunde);
            this.groupBox1.Controls.Add(this.inHours);
            this.groupBox1.Controls.Add(this.inMinute);
            this.groupBox1.Controls.Add(this.inYear);
            this.groupBox1.Controls.Add(this.inMonth);
            this.groupBox1.Location = new System.Drawing.Point(215, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton inYear;
        private System.Windows.Forms.RadioButton inMonth;
        private System.Windows.Forms.RadioButton inHours;
        private System.Windows.Forms.RadioButton inMinute;
        private System.Windows.Forms.RadioButton inSecunde;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}