namespace WF_HW1
{
    partial class Form9
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
            this.gasStation = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.summGastextBox11 = new System.Windows.Forms.TextBox();
            this.volumeGasTextBox10 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceGasText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paidGasStation = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GasPricelabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.miniCafe = new System.Windows.Forms.GroupBox();
            this.numberAdd3textBox6 = new System.Windows.Forms.TextBox();
            this.numberAdd2textBox7 = new System.Windows.Forms.TextBox();
            this.numberAdd1textBox8 = new System.Windows.Forms.TextBox();
            this.numberAdd0textBox9 = new System.Windows.Forms.TextBox();
            this.priceAdd3textBox5 = new System.Windows.Forms.TextBox();
            this.priceAdd2textBox4 = new System.Windows.Forms.TextBox();
            this.priceAdd1textBox3 = new System.Windows.Forms.TextBox();
            this.priceAdd0textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add3checkBox4 = new System.Windows.Forms.CheckBox();
            this.Add2checkBox3 = new System.Windows.Forms.CheckBox();
            this.Add1checkBox2 = new System.Windows.Forms.CheckBox();
            this.Add0checkBox1 = new System.Windows.Forms.CheckBox();
            this.paidMiniCafe = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddPriselabel2 = new System.Windows.Forms.Label();
            this.totalPaid = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalLabel10 = new System.Windows.Forms.Label();
            this.toPay = new System.Windows.Forms.Button();
            this.gasStation.SuspendLayout();
            this.paidGasStation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.miniCafe.SuspendLayout();
            this.paidMiniCafe.SuspendLayout();
            this.totalPaid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gasStation
            // 
            this.gasStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gasStation.Controls.Add(this.label9);
            this.gasStation.Controls.Add(this.label8);
            this.gasStation.Controls.Add(this.summGastextBox11);
            this.gasStation.Controls.Add(this.volumeGasTextBox10);
            this.gasStation.Controls.Add(this.comboBox1);
            this.gasStation.Controls.Add(this.label5);
            this.gasStation.Controls.Add(this.priceGasText);
            this.gasStation.Controls.Add(this.label4);
            this.gasStation.Controls.Add(this.label3);
            this.gasStation.Controls.Add(this.paidGasStation);
            this.gasStation.Controls.Add(this.groupBox1);
            this.gasStation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gasStation.Location = new System.Drawing.Point(12, 22);
            this.gasStation.Name = "gasStation";
            this.gasStation.Size = new System.Drawing.Size(217, 230);
            this.gasStation.TabIndex = 0;
            this.gasStation.TabStop = false;
            this.gasStation.Text = "Автозаправка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(178, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "л.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(178, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "руб.";
            // 
            // summGastextBox11
            // 
            this.summGastextBox11.Enabled = false;
            this.summGastextBox11.Location = new System.Drawing.Point(126, 120);
            this.summGastextBox11.Name = "summGastextBox11";
            this.summGastextBox11.Size = new System.Drawing.Size(47, 20);
            this.summGastextBox11.TabIndex = 17;
            this.summGastextBox11.TextChanged += new System.EventHandler(this.summGastextBox11_TextChanged);
            // 
            // volumeGasTextBox10
            // 
            this.volumeGasTextBox10.Location = new System.Drawing.Point(126, 97);
            this.volumeGasTextBox10.Name = "volumeGasTextBox10";
            this.volumeGasTextBox10.Size = new System.Drawing.Size(47, 20);
            this.volumeGasTextBox10.TabIndex = 16;
            this.volumeGasTextBox10.TextChanged += new System.EventHandler(this.volumeGasTextBox10_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Аи-98",
            "Аи-95",
            "Аи-92"});
            this.comboBox1.Location = new System.Drawing.Point(77, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(178, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "руб.";
            // 
            // priceGasText
            // 
            this.priceGasText.Enabled = false;
            this.priceGasText.Location = new System.Drawing.Point(77, 59);
            this.priceGasText.Name = "priceGasText";
            this.priceGasText.Size = new System.Drawing.Size(96, 20);
            this.priceGasText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бензин";
            // 
            // paidGasStation
            // 
            this.paidGasStation.Controls.Add(this.label11);
            this.paidGasStation.Controls.Add(this.GasPricelabel1);
            this.paidGasStation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paidGasStation.Location = new System.Drawing.Point(6, 156);
            this.paidGasStation.Name = "paidGasStation";
            this.paidGasStation.Size = new System.Drawing.Size(205, 68);
            this.paidGasStation.TabIndex = 1;
            this.paidGasStation.TabStop = false;
            this.paidGasStation.Text = "К оплате";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(172, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "руб.";
            // 
            // GasPricelabel1
            // 
            this.GasPricelabel1.AutoSize = true;
            this.GasPricelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasPricelabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GasPricelabel1.Location = new System.Drawing.Point(73, 27);
            this.GasPricelabel1.Name = "GasPricelabel1";
            this.GasPricelabel1.Size = new System.Drawing.Size(29, 31);
            this.GasPricelabel1.TabIndex = 0;
            this.GasPricelabel1.Text = "0";
            this.GasPricelabel1.TextChanged += new System.EventHandler(this.GasPricelabel1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(6, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Сумма";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(7, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Объём";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // miniCafe
            // 
            this.miniCafe.Controls.Add(this.numberAdd3textBox6);
            this.miniCafe.Controls.Add(this.numberAdd2textBox7);
            this.miniCafe.Controls.Add(this.numberAdd1textBox8);
            this.miniCafe.Controls.Add(this.numberAdd0textBox9);
            this.miniCafe.Controls.Add(this.priceAdd3textBox5);
            this.miniCafe.Controls.Add(this.priceAdd2textBox4);
            this.miniCafe.Controls.Add(this.priceAdd1textBox3);
            this.miniCafe.Controls.Add(this.priceAdd0textBox2);
            this.miniCafe.Controls.Add(this.label7);
            this.miniCafe.Controls.Add(this.label6);
            this.miniCafe.Controls.Add(this.Add3checkBox4);
            this.miniCafe.Controls.Add(this.Add2checkBox3);
            this.miniCafe.Controls.Add(this.Add1checkBox2);
            this.miniCafe.Controls.Add(this.Add0checkBox1);
            this.miniCafe.Controls.Add(this.paidMiniCafe);
            this.miniCafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.miniCafe.Location = new System.Drawing.Point(239, 22);
            this.miniCafe.Name = "miniCafe";
            this.miniCafe.Size = new System.Drawing.Size(217, 230);
            this.miniCafe.TabIndex = 1;
            this.miniCafe.TabStop = false;
            this.miniCafe.Text = "Мини-Кафе";
            // 
            // numberAdd3textBox6
            // 
            this.numberAdd3textBox6.Enabled = false;
            this.numberAdd3textBox6.Location = new System.Drawing.Point(164, 95);
            this.numberAdd3textBox6.Name = "numberAdd3textBox6";
            this.numberAdd3textBox6.Size = new System.Drawing.Size(47, 20);
            this.numberAdd3textBox6.TabIndex = 15;
            this.numberAdd3textBox6.TextChanged += new System.EventHandler(this.numberAdd3textBox6_TextChanged);
            // 
            // numberAdd2textBox7
            // 
            this.numberAdd2textBox7.Enabled = false;
            this.numberAdd2textBox7.Location = new System.Drawing.Point(164, 72);
            this.numberAdd2textBox7.Name = "numberAdd2textBox7";
            this.numberAdd2textBox7.Size = new System.Drawing.Size(47, 20);
            this.numberAdd2textBox7.TabIndex = 14;
            this.numberAdd2textBox7.TextChanged += new System.EventHandler(this.numberAdd2textBox7_TextChanged);
            // 
            // numberAdd1textBox8
            // 
            this.numberAdd1textBox8.Enabled = false;
            this.numberAdd1textBox8.Location = new System.Drawing.Point(164, 49);
            this.numberAdd1textBox8.Name = "numberAdd1textBox8";
            this.numberAdd1textBox8.Size = new System.Drawing.Size(47, 20);
            this.numberAdd1textBox8.TabIndex = 13;
            this.numberAdd1textBox8.TextChanged += new System.EventHandler(this.numberAdd1textBox8_TextChanged);
            // 
            // numberAdd0textBox9
            // 
            this.numberAdd0textBox9.Enabled = false;
            this.numberAdd0textBox9.Location = new System.Drawing.Point(164, 26);
            this.numberAdd0textBox9.Name = "numberAdd0textBox9";
            this.numberAdd0textBox9.Size = new System.Drawing.Size(47, 20);
            this.numberAdd0textBox9.TabIndex = 12;
            this.numberAdd0textBox9.TextChanged += new System.EventHandler(this.numberAdd0textBox9_TextChanged);
            // 
            // priceAdd3textBox5
            // 
            this.priceAdd3textBox5.Enabled = false;
            this.priceAdd3textBox5.Location = new System.Drawing.Point(102, 95);
            this.priceAdd3textBox5.Name = "priceAdd3textBox5";
            this.priceAdd3textBox5.Size = new System.Drawing.Size(47, 20);
            this.priceAdd3textBox5.TabIndex = 11;
            // 
            // priceAdd2textBox4
            // 
            this.priceAdd2textBox4.Enabled = false;
            this.priceAdd2textBox4.Location = new System.Drawing.Point(102, 72);
            this.priceAdd2textBox4.Name = "priceAdd2textBox4";
            this.priceAdd2textBox4.Size = new System.Drawing.Size(47, 20);
            this.priceAdd2textBox4.TabIndex = 10;
            // 
            // priceAdd1textBox3
            // 
            this.priceAdd1textBox3.Enabled = false;
            this.priceAdd1textBox3.Location = new System.Drawing.Point(102, 49);
            this.priceAdd1textBox3.Name = "priceAdd1textBox3";
            this.priceAdd1textBox3.Size = new System.Drawing.Size(47, 20);
            this.priceAdd1textBox3.TabIndex = 9;
            // 
            // priceAdd0textBox2
            // 
            this.priceAdd0textBox2.Enabled = false;
            this.priceAdd0textBox2.Location = new System.Drawing.Point(102, 26);
            this.priceAdd0textBox2.Name = "priceAdd0textBox2";
            this.priceAdd0textBox2.Size = new System.Drawing.Size(47, 20);
            this.priceAdd0textBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(167, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(110, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена";
            // 
            // Add3checkBox4
            // 
            this.Add3checkBox4.AutoSize = true;
            this.Add3checkBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add3checkBox4.Location = new System.Drawing.Point(16, 98);
            this.Add3checkBox4.Name = "Add3checkBox4";
            this.Add3checkBox4.Size = new System.Drawing.Size(53, 17);
            this.Add3checkBox4.TabIndex = 6;
            this.Add3checkBox4.Text = "Кофе";
            this.Add3checkBox4.UseVisualStyleBackColor = true;
            this.Add3checkBox4.CheckedChanged += new System.EventHandler(this.Add3checkBox4_CheckedChanged);
            // 
            // Add2checkBox3
            // 
            this.Add2checkBox3.AutoSize = true;
            this.Add2checkBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add2checkBox3.Location = new System.Drawing.Point(16, 75);
            this.Add2checkBox3.Name = "Add2checkBox3";
            this.Add2checkBox3.Size = new System.Drawing.Size(49, 17);
            this.Add2checkBox3.TabIndex = 5;
            this.Add2checkBox3.Text = "Фри";
            this.Add2checkBox3.UseVisualStyleBackColor = true;
            this.Add2checkBox3.CheckedChanged += new System.EventHandler(this.Add2checkBox3_CheckedChanged);
            // 
            // Add1checkBox2
            // 
            this.Add1checkBox2.AutoSize = true;
            this.Add1checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add1checkBox2.Location = new System.Drawing.Point(16, 52);
            this.Add1checkBox2.Name = "Add1checkBox2";
            this.Add1checkBox2.Size = new System.Drawing.Size(80, 17);
            this.Add1checkBox2.TabIndex = 4;
            this.Add1checkBox2.Text = "Гамбургер";
            this.Add1checkBox2.UseVisualStyleBackColor = true;
            this.Add1checkBox2.CheckedChanged += new System.EventHandler(this.Add1checkBox2_CheckedChanged);
            // 
            // Add0checkBox1
            // 
            this.Add0checkBox1.AutoSize = true;
            this.Add0checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add0checkBox1.Location = new System.Drawing.Point(16, 29);
            this.Add0checkBox1.Name = "Add0checkBox1";
            this.Add0checkBox1.Size = new System.Drawing.Size(64, 17);
            this.Add0checkBox1.TabIndex = 3;
            this.Add0checkBox1.Text = "Хот-дог";
            this.Add0checkBox1.UseVisualStyleBackColor = true;
            this.Add0checkBox1.CheckedChanged += new System.EventHandler(this.Add0checkBox1_CheckedChanged);
            // 
            // paidMiniCafe
            // 
            this.paidMiniCafe.Controls.Add(this.label12);
            this.paidMiniCafe.Controls.Add(this.AddPriselabel2);
            this.paidMiniCafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paidMiniCafe.Location = new System.Drawing.Point(6, 156);
            this.paidMiniCafe.Name = "paidMiniCafe";
            this.paidMiniCafe.Size = new System.Drawing.Size(205, 68);
            this.paidMiniCafe.TabIndex = 2;
            this.paidMiniCafe.TabStop = false;
            this.paidMiniCafe.Text = "К оплате";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(175, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "руб.";
            // 
            // AddPriselabel2
            // 
            this.AddPriselabel2.AutoSize = true;
            this.AddPriselabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPriselabel2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddPriselabel2.Location = new System.Drawing.Point(69, 27);
            this.AddPriselabel2.Name = "AddPriselabel2";
            this.AddPriselabel2.Size = new System.Drawing.Size(29, 31);
            this.AddPriselabel2.TabIndex = 1;
            this.AddPriselabel2.Text = "0";
            this.AddPriselabel2.TextChanged += new System.EventHandler(this.AddPriselabel2_Click);
            this.AddPriselabel2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // totalPaid
            // 
            this.totalPaid.Controls.Add(this.label13);
            this.totalPaid.Controls.Add(this.totalLabel10);
            this.totalPaid.Controls.Add(this.toPay);
            this.totalPaid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalPaid.Location = new System.Drawing.Point(12, 259);
            this.totalPaid.Name = "totalPaid";
            this.totalPaid.Size = new System.Drawing.Size(444, 100);
            this.totalPaid.TabIndex = 2;
            this.totalPaid.TabStop = false;
            this.totalPaid.Text = "ВСЕГО к оплате";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(408, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "руб.";
            // 
            // totalLabel10
            // 
            this.totalLabel10.AutoSize = true;
            this.totalLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalLabel10.Location = new System.Drawing.Point(302, 40);
            this.totalLabel10.Name = "totalLabel10";
            this.totalLabel10.Size = new System.Drawing.Size(29, 31);
            this.totalLabel10.TabIndex = 1;
            this.totalLabel10.Text = "0";
            // 
            // toPay
            // 
            this.toPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toPay.Location = new System.Drawing.Point(63, 23);
            this.toPay.Name = "toPay";
            this.toPay.Size = new System.Drawing.Size(148, 63);
            this.toPay.TabIndex = 0;
            this.toPay.Text = "Оплатить";
            this.toPay.UseVisualStyleBackColor = true;
            this.toPay.Click += new System.EventHandler(this.toPay_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 442);
            this.Controls.Add(this.totalPaid);
            this.Controls.Add(this.miniCafe);
            this.Controls.Add(this.gasStation);
            this.Name = "Form9";
            this.Text = "BestOil";
            this.gasStation.ResumeLayout(false);
            this.gasStation.PerformLayout();
            this.paidGasStation.ResumeLayout(false);
            this.paidGasStation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.miniCafe.ResumeLayout(false);
            this.miniCafe.PerformLayout();
            this.paidMiniCafe.ResumeLayout(false);
            this.paidMiniCafe.PerformLayout();
            this.totalPaid.ResumeLayout(false);
            this.totalPaid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gasStation;
        private System.Windows.Forms.GroupBox paidGasStation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox miniCafe;
        private System.Windows.Forms.GroupBox paidMiniCafe;
        private System.Windows.Forms.GroupBox totalPaid;
        private System.Windows.Forms.Label GasPricelabel1;
        private System.Windows.Forms.Label AddPriselabel2;
        private System.Windows.Forms.Button toPay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceGasText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox summGastextBox11;
        private System.Windows.Forms.TextBox volumeGasTextBox10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox numberAdd3textBox6;
        private System.Windows.Forms.TextBox numberAdd2textBox7;
        private System.Windows.Forms.TextBox numberAdd1textBox8;
        private System.Windows.Forms.TextBox numberAdd0textBox9;
        private System.Windows.Forms.TextBox priceAdd3textBox5;
        private System.Windows.Forms.TextBox priceAdd2textBox4;
        private System.Windows.Forms.TextBox priceAdd1textBox3;
        private System.Windows.Forms.TextBox priceAdd0textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Add3checkBox4;
        private System.Windows.Forms.CheckBox Add2checkBox3;
        private System.Windows.Forms.CheckBox Add1checkBox2;
        private System.Windows.Forms.CheckBox Add0checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalLabel10;
    }
}