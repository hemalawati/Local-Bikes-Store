﻿namespace Utilities.Documents
{
    partial class ListObjects
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_DocType = new System.Windows.Forms.ComboBox();
            this.textBox_DocType = new System.Windows.Forms.TextBox();
            this.textBox_CMD = new System.Windows.Forms.TextBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.comboBox_TableName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Document Type";
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.FormattingEnabled = true;
            this.comboBox_DocType.Location = new System.Drawing.Point(290, 193);
            this.comboBox_DocType.Name = "comboBox_DocType";
            this.comboBox_DocType.Size = new System.Drawing.Size(246, 21);
            this.comboBox_DocType.TabIndex = 3;
            this.comboBox_DocType.SelectedIndexChanged += new System.EventHandler(this.comboBox_DocType_SelectedIndexChanged);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(566, 195);
            this.textBox_DocType.Name = "textBox_DocType";
            this.textBox_DocType.Size = new System.Drawing.Size(67, 20);
            this.textBox_DocType.TabIndex = 4;
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(652, 143);
            this.textBox_CMD.Multiline = true;
            this.textBox_CMD.Name = "textBox_CMD";
            this.textBox_CMD.Size = new System.Drawing.Size(504, 45);
            this.textBox_CMD.TabIndex = 5;
            this.textBox_CMD.Text = "select * from GenDocs";
            // 
            // button_Display
            // 
            this.button_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(679, 194);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(138, 43);
            this.button_Display.TabIndex = 6;
            this.button_Display.Text = "display results";
            this.button_Display.UseVisualStyleBackColor = false;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 278);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(566, 160);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.Size = new System.Drawing.Size(69, 20);
            this.textBox_TableName.TabIndex = 10;
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.FormattingEnabled = true;
            this.comboBox_TableName.Items.AddRange(new object[] {
            "Acc_payable",
            "GenDocs",
            "PayableDocs"});
            this.comboBox_TableName.Location = new System.Drawing.Point(292, 157);
            this.comboBox_TableName.Name = "comboBox_TableName";
            this.comboBox_TableName.Size = new System.Drawing.Size(244, 21);
            this.comboBox_TableName.TabIndex = 9;
            this.comboBox_TableName.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table Name";
            // 
            // ListObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.textBox_TableName);
            this.Controls.Add(this.comboBox_TableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_CMD);
            this.Controls.Add(this.textBox_DocType);
            this.Controls.Add(this.comboBox_DocType);
            this.Controls.Add(this.label2);
            this.Name = "ListObjects";
            this.Text = "List of Transactions";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_DocType;
        private System.Windows.Forms.TextBox textBox_DocType;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox_CMD;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TextBox textBox_TableName;
        protected System.Windows.Forms.ComboBox comboBox_TableName;
    }
}

