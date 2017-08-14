﻿namespace Assignment5
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
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.MyWeight_TextBox = new System.Windows.Forms.TextBox();
            this.MyHeight_TextBox = new System.Windows.Forms.TextBox();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMI_TextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.BMICalculator_Text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3299F));
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMI, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MyWeight_TextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MyHeight_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMI_TextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.AccessibleDescription = "";
            this.CalculateBMI.AccessibleName = "";
            this.CalculateBMI.BackColor = System.Drawing.Color.Black;
            this.CalculateBMI.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.Location = new System.Drawing.Point(8, 193);
            this.CalculateBMI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(139, 89);
            this.CalculateBMI.TabIndex = 6;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = false;
            this.CalculateBMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyWeight_TextBox
            // 
            this.MyWeight_TextBox.Location = new System.Drawing.Point(169, 137);
            this.MyWeight_TextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MyWeight_TextBox.Name = "MyWeight_TextBox";
            this.MyWeight_TextBox.Size = new System.Drawing.Size(113, 38);
            this.MyWeight_TextBox.TabIndex = 4;
            // 
            // MyHeight_TextBox
            // 
            this.MyHeight_TextBox.Location = new System.Drawing.Point(169, 72);
            this.MyHeight_TextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MyHeight_TextBox.Name = "MyHeight_TextBox";
            this.MyHeight_TextBox.Size = new System.Drawing.Size(113, 38);
            this.MyHeight_TextBox.TabIndex = 3;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.BackColor = System.Drawing.Color.Gray;
            this.ImperialButton.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.ForeColor = System.Drawing.Color.White;
            this.ImperialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImperialButton.Location = new System.Drawing.Point(8, 7);
            this.ImperialButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(129, 37);
            this.ImperialButton.TabIndex = 0;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = false;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.ForeColor = System.Drawing.Color.White;
            this.MetricButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MetricButton.Location = new System.Drawing.Point(169, 7);
            this.MetricButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(109, 37);
            this.MetricButton.TabIndex = 7;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.ForeColor = System.Drawing.Color.White;
            this.MyHeightLabel.Location = new System.Drawing.Point(8, 65);
            this.MyHeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(136, 33);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyHeightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalculateBMI_TextBox
            // 
            this.CalculateBMI_TextBox.Location = new System.Drawing.Point(169, 193);
            this.CalculateBMI_TextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CalculateBMI_TextBox.Name = "CalculateBMI_TextBox";
            this.CalculateBMI_TextBox.Size = new System.Drawing.Size(113, 38);
            this.CalculateBMI_TextBox.TabIndex = 9;
            this.CalculateBMI_TextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ForeColor = System.Drawing.Color.White;
            this.MyWeightLabel.Location = new System.Drawing.Point(8, 130);
            this.MyWeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(142, 33);
            this.MyWeightLabel.TabIndex = 1;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyWeightLabel.Click += new System.EventHandler(this.MyWeightLabel_Click);
            // 
            // BMICalculator_Text
            // 
            this.BMICalculator_Text.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BMICalculator_Text.Font = new System.Drawing.Font("Miramonte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculator_Text.Location = new System.Drawing.Point(12, 12);
            this.BMICalculator_Text.Name = "BMICalculator_Text";
            this.BMICalculator_Text.Size = new System.Drawing.Size(289, 41);
            this.BMICalculator_Text.TabIndex = 2;
            this.BMICalculator_Text.Text = "BMI Calculator";
            this.BMICalculator_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMICalculator_Text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.BMICalculator_Text);
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
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyHeight_TextBox;
        private System.Windows.Forms.TextBox MyWeight_TextBox;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.TextBox CalculateBMI_TextBox;
        private System.Windows.Forms.TextBox BMICalculator_Text;
    }
}
