namespace Account_Payable
{
    partial class Account_Payable_Main
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
            this.DeliveryDocGdview = new System.Windows.Forms.DataGridView();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btndiplayDdoc = new System.Windows.Forms.Button();
            this.btnUpdateAccPayable = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDocGdview)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(20, 19);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(0, 28);
            this.label_SubName.Text = "";
            // 
            // DeliveryDocGdview
            // 
            this.DeliveryDocGdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDocGdview.Location = new System.Drawing.Point(231, 307);
            this.DeliveryDocGdview.Name = "DeliveryDocGdview";
            this.DeliveryDocGdview.Size = new System.Drawing.Size(890, 263);
            this.DeliveryDocGdview.TabIndex = 7;
            this.DeliveryDocGdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryDocGdview_CellContentClick);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.Location = new System.Drawing.Point(450, 169);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(123, 64);
            this.btnMakePayment.TabIndex = 6;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btndiplayDdoc
            // 
            this.btndiplayDdoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btndiplayDdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btndiplayDdoc.Location = new System.Drawing.Point(265, 167);
            this.btndiplayDdoc.Name = "btndiplayDdoc";
            this.btndiplayDdoc.Size = new System.Drawing.Size(123, 64);
            this.btndiplayDdoc.TabIndex = 5;
            this.btndiplayDdoc.Text = "Display Delivery Document";
            this.btndiplayDdoc.UseVisualStyleBackColor = false;
            this.btndiplayDdoc.Click += new System.EventHandler(this.btndiplayDdoc_Click);
            // 
            // btnUpdateAccPayable
            // 
            this.btnUpdateAccPayable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnUpdateAccPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAccPayable.Location = new System.Drawing.Point(668, 169);
            this.btnUpdateAccPayable.Name = "btnUpdateAccPayable";
            this.btnUpdateAccPayable.Size = new System.Drawing.Size(123, 64);
            this.btnUpdateAccPayable.TabIndex = 8;
            this.btnUpdateAccPayable.Text = "Update Account Payable";
            this.btnUpdateAccPayable.UseVisualStyleBackColor = false;
            this.btnUpdateAccPayable.Click += new System.EventHandler(this.btnUpdateButton_Click);
            // 
            // Account_Payable_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.btnUpdateAccPayable);
            this.Controls.Add(this.DeliveryDocGdview);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btndiplayDdoc);
            this.Name = "Account_Payable_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btndiplayDdoc, 0);
            this.Controls.SetChildIndex(this.btnMakePayment, 0);
            this.Controls.SetChildIndex(this.DeliveryDocGdview, 0);
            this.Controls.SetChildIndex(this.btnUpdateAccPayable, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDocGdview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryDocGdview;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btndiplayDdoc;
        private System.Windows.Forms.Button btnUpdateAccPayable;
    }
}
