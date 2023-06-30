namespace QLKHO
{
    partial class DangNhap
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.TEN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dn = new System.Windows.Forms.Button();
            this.thoát = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Purple;
            this.lb1.Location = new System.Drawing.Point(59, 11);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.MaximumSize = new System.Drawing.Size(667, 615);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(391, 60);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "ĐĂNG NHẬP";
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(167, 15);
            this.txtusename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusename.Name = "txtusename";
            this.txtusename.Size = new System.Drawing.Size(235, 22);
            this.txtusename.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(167, 59);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(235, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Purple;
            this.pass.Location = new System.Drawing.Point(20, 55);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(118, 25);
            this.pass.TabIndex = 2;
            this.pass.Text = "Mật Khẩu :";
            // 
            // TEN
            // 
            this.TEN.AutoSize = true;
            this.TEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEN.ForeColor = System.Drawing.Color.Purple;
            this.TEN.Location = new System.Drawing.Point(13, 15);
            this.TEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TEN.Name = "TEN";
            this.TEN.Size = new System.Drawing.Size(125, 25);
            this.TEN.TabIndex = 1;
            this.TEN.Text = "Tài Khoản :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtusename);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.TEN);
            this.panel1.Location = new System.Drawing.Point(8, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 103);
            this.panel1.TabIndex = 11;
            // 
            // dn
            // 
            this.dn.BackColor = System.Drawing.Color.Indigo;
            this.dn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dn.Location = new System.Drawing.Point(85, 196);
            this.dn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(99, 42);
            this.dn.TabIndex = 10;
            this.dn.Text = "Đăng nhập";
            this.dn.UseVisualStyleBackColor = false;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // thoát
            // 
            this.thoát.BackColor = System.Drawing.Color.Indigo;
            this.thoát.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.thoát.Location = new System.Drawing.Point(303, 196);
            this.thoát.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoát.Name = "thoát";
            this.thoát.Size = new System.Drawing.Size(107, 42);
            this.thoát.TabIndex = 9;
            this.thoát.Text = "Thoát";
            this.thoát.UseVisualStyleBackColor = false;
            this.thoát.Click += new System.EventHandler(this.thoát_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 251);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.thoát);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label TEN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.Button thoát;
    }
}