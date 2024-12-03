namespace bt_b4
{
    partial class Form2
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
            this.txtMsnv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtLuongcb = new System.Windows.Forms.TextBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TEN NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LUONG CB";
            // 
            // txtMsnv
            // 
            this.txtMsnv.Location = new System.Drawing.Point(108, 72);
            this.txtMsnv.Name = "txtMsnv";
            this.txtMsnv.Size = new System.Drawing.Size(286, 20);
            this.txtMsnv.TabIndex = 1;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(108, 143);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(286, 20);
            this.txtTennv.TabIndex = 1;
            // 
            // txtLuongcb
            // 
            this.txtLuongcb.Location = new System.Drawing.Point(108, 212);
            this.txtLuongcb.Name = "txtLuongcb";
            this.txtLuongcb.Size = new System.Drawing.Size(286, 20);
            this.txtLuongcb.TabIndex = 1;
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(108, 259);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 2;
            this.btnDongy.Text = "Dong Y";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(275, 259);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 2;
            this.btnBoqua.Text = "Bo qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 308);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.txtLuongcb);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtMsnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsnv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtLuongcb;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
    }
}