﻿namespace PayRollPro
{
    partial class ManagerForm
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
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.numUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.txtBoxNN = new System.Windows.Forms.TextBox();
            this.labelNewN = new System.Windows.Forms.Label();
            this.labelNewR = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbNR = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.numUpDownNRa = new System.Windows.Forms.NumericUpDown();
            this.labelNRa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNRa)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 29;
            this.listBoxEmployees.Location = new System.Drawing.Point(729, 46);
            this.listBoxEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(458, 236);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(226, 252);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(376, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(208, 511);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(184, 51);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "Hire Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(18, 260);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(144, 46);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(277, 39);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Manager\'s Page";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(992, 352);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(196, 45);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Salary";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(226, 418);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(376, 33);
            this.cmbRole.TabIndex = 13;
            // 
            // numUpDownRate
            // 
            this.numUpDownRate.DecimalPlaces = 2;
            this.numUpDownRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownRate.Location = new System.Drawing.Point(226, 332);
            this.numUpDownRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDownRate.Name = "numUpDownRate";
            this.numUpDownRate.Size = new System.Drawing.Size(378, 30);
            this.numUpDownRate.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 30);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "This is Auto-generated";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(729, 352);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(196, 45);
            this.buttonInfo.TabIndex = 18;
            this.buttonInfo.Text = "Employee Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(850, 406);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(230, 48);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edit Employee Info";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // txtBoxNN
            // 
            this.txtBoxNN.Location = new System.Drawing.Point(831, 479);
            this.txtBoxNN.Name = "txtBoxNN";
            this.txtBoxNN.Size = new System.Drawing.Size(176, 26);
            this.txtBoxNN.TabIndex = 20;
            this.txtBoxNN.Visible = false;
            // 
            // labelNewN
            // 
            this.labelNewN.AutoSize = true;
            this.labelNewN.Location = new System.Drawing.Point(729, 482);
            this.labelNewN.Name = "labelNewN";
            this.labelNewN.Size = new System.Drawing.Size(86, 20);
            this.labelNewN.TabIndex = 21;
            this.labelNewN.Text = "New Name";
            this.labelNewN.Visible = false;
            // 
            // labelNewR
            // 
            this.labelNewR.AutoSize = true;
            this.labelNewR.Location = new System.Drawing.Point(729, 525);
            this.labelNewR.Name = "labelNewR";
            this.labelNewR.Size = new System.Drawing.Size(77, 20);
            this.labelNewR.TabIndex = 22;
            this.labelNewR.Text = "New Role";
            this.labelNewR.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(1101, 552);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(86, 37);
            this.btnDone.TabIndex = 24;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbNR
            // 
            this.cmbNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNR.FormattingEnabled = true;
            this.cmbNR.Location = new System.Drawing.Point(831, 517);
            this.cmbNR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNR.Name = "cmbNR";
            this.cmbNR.Size = new System.Drawing.Size(176, 28);
            this.cmbNR.TabIndex = 25;
            this.cmbNR.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(850, 294);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(230, 48);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numUpDownNRa
            // 
            this.numUpDownNRa.DecimalPlaces = 2;
            this.numUpDownNRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownNRa.Location = new System.Drawing.Point(831, 563);
            this.numUpDownNRa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDownNRa.Name = "numUpDownNRa";
            this.numUpDownNRa.Size = new System.Drawing.Size(176, 26);
            this.numUpDownNRa.TabIndex = 28;
            this.numUpDownNRa.Visible = false;
            // 
            // labelNRa
            // 
            this.labelNRa.AutoSize = true;
            this.labelNRa.Location = new System.Drawing.Point(729, 569);
            this.labelNRa.Name = "labelNRa";
            this.labelNRa.Size = new System.Drawing.Size(79, 20);
            this.labelNRa.TabIndex = 29;
            this.labelNRa.Text = "New Rate";
            this.labelNRa.Visible = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelNRa);
            this.Controls.Add(this.numUpDownNRa);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cmbNR);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.labelNewR);
            this.Controls.Add(this.labelNewN);
            this.Controls.Add(this.txtBoxNN);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numUpDownRate);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerForm";
            this.Text = "Manager Page";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNRa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.NumericUpDown numUpDownRate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox txtBoxNN;
        private System.Windows.Forms.Label labelNewN;
        private System.Windows.Forms.Label labelNewR;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cmbNR;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown numUpDownNRa;
        private System.Windows.Forms.Label labelNRa;
    }
}