namespace Assignment5
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeigh = new System.Windows.Forms.TextBox();
            this.btnImperial = new System.Windows.Forms.RadioButton();
            this.btnMetric = new System.Windows.Forms.RadioButton();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtCalculate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.67354F));
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHeigh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnImperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMetric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCalculate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 4);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleDescription = "";
            this.btnCalculate.AccessibleName = "";
            this.btnCalculate.BackColor = System.Drawing.Color.Black;
            this.btnCalculate.Font = new System.Drawing.Font("Miramonte", 20F);
            this.btnCalculate.Location = new System.Drawing.Point(8, 173);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 75);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Miramonte", 20F);
            this.txtWeight.Location = new System.Drawing.Point(169, 123);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(113, 40);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextChanged += new System.EventHandler(this.MyWeight_TextBox_TextChanged);
            // 
            // txtHeigh
            // 
            this.txtHeigh.Font = new System.Drawing.Font("Miramonte", 20F);
            this.txtHeigh.Location = new System.Drawing.Point(169, 66);
            this.txtHeigh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtHeigh.Name = "txtHeigh";
            this.txtHeigh.Size = new System.Drawing.Size(113, 40);
            this.txtHeigh.TabIndex = 3;
            this.txtHeigh.TextChanged += new System.EventHandler(this.MyHeight_TextBox_TextChanged);
            // 
            // btnImperial
            // 
            this.btnImperial.AutoSize = true;
            this.btnImperial.BackColor = System.Drawing.Color.Gray;
            this.btnImperial.Font = new System.Drawing.Font("Miramonte", 20F);
            this.btnImperial.ForeColor = System.Drawing.Color.White;
            this.btnImperial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImperial.Location = new System.Drawing.Point(8, 7);
            this.btnImperial.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnImperial.Name = "btnImperial";
            this.btnImperial.Size = new System.Drawing.Size(129, 37);
            this.btnImperial.TabIndex = 0;
            this.btnImperial.TabStop = true;
            this.btnImperial.Text = "Imperial";
            this.btnImperial.UseVisualStyleBackColor = false;
            this.btnImperial.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // btnMetric
            // 
            this.btnMetric.AutoSize = true;
            this.btnMetric.Font = new System.Drawing.Font("Miramonte", 20F);
            this.btnMetric.ForeColor = System.Drawing.Color.White;
            this.btnMetric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetric.Location = new System.Drawing.Point(169, 7);
            this.btnMetric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMetric.Name = "btnMetric";
            this.btnMetric.Size = new System.Drawing.Size(109, 37);
            this.btnMetric.TabIndex = 7;
            this.btnMetric.TabStop = true;
            this.btnMetric.Text = "Metric";
            this.btnMetric.UseVisualStyleBackColor = true;
            this.btnMetric.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Miramonte", 20F);
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(8, 59);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(136, 33);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "My Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCalculate
            // 
            this.txtCalculate.Font = new System.Drawing.Font("Miramonte", 20F);
            this.txtCalculate.Location = new System.Drawing.Point(169, 173);
            this.txtCalculate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(113, 40);
            this.txtCalculate.TabIndex = 9;
            this.txtCalculate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Miramonte", 20F);
            this.btnClose.Location = new System.Drawing.Point(164, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Miramonte", 20F);
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(8, 116);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(142, 33);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "My Weight";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeight.Click += new System.EventHandler(this.MyWeightLabel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Font = new System.Drawing.Font("Miramonte", 20F);
            this.btnReset.Location = new System.Drawing.Point(3, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 50);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblBMI.Font = new System.Drawing.Font("Miramonte", 20F);
            this.lblBMI.Location = new System.Drawing.Point(12, 12);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(289, 40);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "BMI Calculator";
            this.lblBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblBMI.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton btnMetric;
        private System.Windows.Forms.RadioButton btnImperial;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeigh;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCalculate;
        private System.Windows.Forms.TextBox lblBMI;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

