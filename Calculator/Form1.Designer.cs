namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChia = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txtNo1
            // 
            this.txtNo1.Location = new System.Drawing.Point(237, 61);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(149, 30);
            this.txtNo1.TabIndex = 3;
            // 
            // txtNo2
            // 
            this.txtNo2.Location = new System.Drawing.Point(237, 118);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(149, 30);
            this.txtNo2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(237, 174);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(149, 30);
            this.txtResult.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChia);
            this.groupBox1.Controls.Add(this.btNhan);
            this.groupBox1.Controls.Add(this.btTru);
            this.groupBox1.Controls.Add(this.btCong);
            this.groupBox1.Location = new System.Drawing.Point(115, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // btChia
            // 
            this.btChia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btChia.Location = new System.Drawing.Point(452, 43);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(50, 50);
            this.btChia.TabIndex = 3;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = false;
            this.btChia.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btNhan.Location = new System.Drawing.Point(313, 43);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(50, 50);
            this.btNhan.TabIndex = 2;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = false;
            this.btNhan.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btTru.Location = new System.Drawing.Point(178, 43);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(50, 50);
            this.btTru.TabIndex = 1;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = false;
            this.btTru.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btCong
            // 
            this.btCong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCong.Location = new System.Drawing.Point(50, 43);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(50, 50);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = false;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btCong;
    }
}

