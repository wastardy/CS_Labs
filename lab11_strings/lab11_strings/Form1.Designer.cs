﻿namespace lab11_strings
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.cmbxAction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowLength = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First num";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNum.Location = new System.Drawing.Point(29, 164);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(117, 29);
            this.txtFirstNum.TabIndex = 1;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNum.Location = new System.Drawing.Point(321, 165);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(117, 29);
            this.txtSecondNum.TabIndex = 2;
            // 
            // cmbxAction
            // 
            this.cmbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAction.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAction.FormattingEnabled = true;
            this.cmbxAction.Location = new System.Drawing.Point(172, 164);
            this.cmbxAction.Name = "cmbxAction";
            this.cmbxAction.Size = new System.Drawing.Size(121, 30);
            this.cmbxAction.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(514, 164);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(117, 29);
            this.txtResult.TabIndex = 8;
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.BackColor = System.Drawing.Color.MistyRose;
            this.btnCheckResult.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckResult.Location = new System.Drawing.Point(370, 257);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(210, 62);
            this.btnCheckResult.TabIndex = 9;
            this.btnCheckResult.Text = "Check result";
            this.btnCheckResult.UseVisualStyleBackColor = false;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kinda Calculator Stuff";
            // 
            // btnShowLength
            // 
            this.btnShowLength.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnShowLength.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLength.Location = new System.Drawing.Point(80, 257);
            this.btnShowLength.Name = "btnShowLength";
            this.btnShowLength.Size = new System.Drawing.Size(210, 62);
            this.btnShowLength.TabIndex = 11;
            this.btnShowLength.Text = "Check size*";
            this.btnShowLength.UseVisualStyleBackColor = false;
            this.btnShowLength.Click += new System.EventHandler(this.btnShowLength_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(665, 361);
            this.Controls.Add(this.btnShowLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxAction);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiNdA CaLcULatOr sTuFf";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.ComboBox cmbxAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowLength;
    }
}

