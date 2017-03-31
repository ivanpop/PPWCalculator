namespace PPWCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.evn = new System.Windows.Forms.CheckBox();
            this.cez = new System.Windows.Forms.CheckBox();
            this.epro = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nightPriceBox = new System.Windows.Forms.TextBox();
            this.dayPriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceMonth = new System.Windows.Forms.Label();
            this.priceWeek = new System.Windows.Forms.Label();
            this.priceDay = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.oneScale = new System.Windows.Forms.CheckBox();
            this.nightHoursBox = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.EVNpricesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EnergoProPricesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CEZpricesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Мощност:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "W";
            // 
            // evn
            // 
            this.evn.AutoSize = true;
            this.evn.Checked = true;
            this.evn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.evn.Location = new System.Drawing.Point(72, 53);
            this.evn.Name = "evn";
            this.evn.Size = new System.Drawing.Size(15, 14);
            this.evn.TabIndex = 6;
            this.evn.UseVisualStyleBackColor = true;
            this.evn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.evn_MouseClick);
            // 
            // cez
            // 
            this.cez.AutoSize = true;
            this.cez.Location = new System.Drawing.Point(156, 53);
            this.cez.Name = "cez";
            this.cez.Size = new System.Drawing.Size(15, 14);
            this.cez.TabIndex = 7;
            this.cez.UseVisualStyleBackColor = true;
            this.cez.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cez_MouseClick);
            // 
            // epro
            // 
            this.epro.AutoSize = true;
            this.epro.Location = new System.Drawing.Point(239, 53);
            this.epro.Name = "epro";
            this.epro.Size = new System.Drawing.Size(15, 14);
            this.epro.TabIndex = 8;
            this.epro.UseVisualStyleBackColor = true;
            this.epro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.epro_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Нощни часове:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "дневна:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "нощна:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nightPriceBox);
            this.groupBox1.Controls.Add(this.dayPriceBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(156, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "цена лв./kWh - две скали";
            // 
            // nightPriceBox
            // 
            this.nightPriceBox.Location = new System.Drawing.Point(84, 66);
            this.nightPriceBox.Name = "nightPriceBox";
            this.nightPriceBox.Size = new System.Drawing.Size(57, 20);
            this.nightPriceBox.TabIndex = 17;
            this.nightPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nightPriceBox.TextChanged += new System.EventHandler(this.nightPriceBox_TextChanged);
            // 
            // dayPriceBox
            // 
            this.dayPriceBox.Location = new System.Drawing.Point(84, 32);
            this.dayPriceBox.Name = "dayPriceBox";
            this.dayPriceBox.Size = new System.Drawing.Size(57, 20);
            this.dayPriceBox.TabIndex = 16;
            this.dayPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dayPriceBox.TextChanged += new System.EventHandler(this.dayPriceBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Само една скала:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "За 1 ден:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "За 7 дена:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(21, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "За 30 дена:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceMonth);
            this.groupBox2.Controls.Add(this.priceWeek);
            this.groupBox2.Controls.Add(this.priceDay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 107);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Крайна цена в лв: ";
            // 
            // priceMonth
            // 
            this.priceMonth.AutoSize = true;
            this.priceMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMonth.Location = new System.Drawing.Point(198, 80);
            this.priceMonth.Name = "priceMonth";
            this.priceMonth.Size = new System.Drawing.Size(44, 20);
            this.priceMonth.TabIndex = 26;
            this.priceMonth.Text = "0.00";
            this.priceMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceWeek
            // 
            this.priceWeek.AutoSize = true;
            this.priceWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceWeek.Location = new System.Drawing.Point(198, 50);
            this.priceWeek.Name = "priceWeek";
            this.priceWeek.Size = new System.Drawing.Size(44, 20);
            this.priceWeek.TabIndex = 24;
            this.priceWeek.Text = "0.00";
            // 
            // priceDay
            // 
            this.priceDay.AutoSize = true;
            this.priceDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceDay.Location = new System.Drawing.Point(198, 21);
            this.priceDay.Name = "priceDay";
            this.priceDay.Size = new System.Drawing.Size(44, 20);
            this.priceDay.TabIndex = 22;
            this.priceDay.Text = "0.00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(207, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 76);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 76);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // powerBox
            // 
            this.powerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerBox.Location = new System.Drawing.Point(151, 13);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(67, 26);
            this.powerBox.TabIndex = 0;
            this.powerBox.Text = "0";
            this.powerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.powerBox.TextChanged += new System.EventHandler(this.powerBox_TextChanged);
            // 
            // oneScale
            // 
            this.oneScale.AutoSize = true;
            this.oneScale.Location = new System.Drawing.Point(112, 212);
            this.oneScale.Name = "oneScale";
            this.oneScale.Size = new System.Drawing.Size(15, 14);
            this.oneScale.TabIndex = 18;
            this.oneScale.UseVisualStyleBackColor = true;
            this.oneScale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oneScale_MouseClick);
            // 
            // nightHoursBox
            // 
            this.nightHoursBox.Location = new System.Drawing.Point(112, 173);
            this.nightHoursBox.Name = "nightHoursBox";
            this.nightHoursBox.Size = new System.Drawing.Size(25, 20);
            this.nightHoursBox.TabIndex = 12;
            this.nightHoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nightHoursBox.TextChanged += new System.EventHandler(this.nightHoursBox_TextChanged);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Location = new System.Drawing.Point(14, 287);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 13);
            this.equation.TabIndex = 23;
            // 
            // EVNpricesLinkLabel
            // 
            this.EVNpricesLinkLabel.AutoSize = true;
            this.EVNpricesLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EVNpricesLinkLabel.Location = new System.Drawing.Point(20, 25);
            this.EVNpricesLinkLabel.Name = "EVNpricesLinkLabel";
            this.EVNpricesLinkLabel.Size = new System.Drawing.Size(38, 16);
            this.EVNpricesLinkLabel.TabIndex = 24;
            this.EVNpricesLinkLabel.TabStop = true;
            this.EVNpricesLinkLabel.Text = "ЕВН";
            this.EVNpricesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EVNLinkLabel_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EnergoProPricesLinkLabel);
            this.groupBox3.Controls.Add(this.CEZpricesLinkLabel);
            this.groupBox3.Controls.Add(this.EVNpricesLinkLabel);
            this.groupBox3.Location = new System.Drawing.Point(14, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 54);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цените са взети от следните източници:";
            // 
            // EnergoProPricesLinkLabel
            // 
            this.EnergoProPricesLinkLabel.AutoSize = true;
            this.EnergoProPricesLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergoProPricesLinkLabel.Location = new System.Drawing.Point(192, 25);
            this.EnergoProPricesLinkLabel.Name = "EnergoProPricesLinkLabel";
            this.EnergoProPricesLinkLabel.Size = new System.Drawing.Size(99, 16);
            this.EnergoProPricesLinkLabel.TabIndex = 26;
            this.EnergoProPricesLinkLabel.TabStop = true;
            this.EnergoProPricesLinkLabel.Text = "ЕНЕРГО-ПРО";
            this.EnergoProPricesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnergoProPricesLinkLabel_LinkClicked);
            // 
            // CEZpricesLinkLabel
            // 
            this.CEZpricesLinkLabel.AutoSize = true;
            this.CEZpricesLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEZpricesLinkLabel.Location = new System.Drawing.Point(109, 25);
            this.CEZpricesLinkLabel.Name = "CEZpricesLinkLabel";
            this.CEZpricesLinkLabel.Size = new System.Drawing.Size(37, 16);
            this.CEZpricesLinkLabel.TabIndex = 25;
            this.CEZpricesLinkLabel.TabStop = true;
            this.CEZpricesLinkLabel.Text = "ЧЕЗ";
            this.CEZpricesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CEZpricesLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.oneScale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nightHoursBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epro);
            this.Controls.Add(this.cez);
            this.Controls.Add(this.evn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.powerBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Price per Watt Calculator 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox evn;
        private System.Windows.Forms.CheckBox cez;
        private System.Windows.Forms.CheckBox epro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label priceMonth;
        private System.Windows.Forms.Label priceWeek;
        private System.Windows.Forms.Label priceDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox nightHoursBox;
        private System.Windows.Forms.CheckBox oneScale;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.TextBox dayPriceBox;
        private System.Windows.Forms.TextBox nightPriceBox;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.LinkLabel EVNpricesLinkLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel CEZpricesLinkLabel;
        public System.Windows.Forms.LinkLabel EnergoProPricesLinkLabel;
    }
}

