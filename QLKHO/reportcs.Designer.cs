namespace QLKHO
{
    partial class reportcs
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetHang = new QLKHO.DataSetHang();
            this.reporthang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HangTableAdapter = new QLKHO.DataSetHangTableAdapters.HangTableAdapter();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HangBindingSource
            // 
            this.HangBindingSource.DataMember = "Hang";
            this.HangBindingSource.DataSource = this.DataSetHang;
            // 
            // DataSetHang
            // 
            this.DataSetHang.DataSetName = "DataSetHang";
            this.DataSetHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporthang
            // 
            this.reporthang.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HangBindingSource;
            this.reporthang.LocalReport.DataSources.Add(reportDataSource1);
            this.reporthang.LocalReport.ReportEmbeddedResource = "QLKHO.Report1.rdlc";
            this.reporthang.Location = new System.Drawing.Point(4, 19);
            this.reporthang.Margin = new System.Windows.Forms.Padding(4);
            this.reporthang.Name = "reporthang";
            this.reporthang.ServerReport.BearerToken = null;
            this.reporthang.Size = new System.Drawing.Size(1051, 469);
            this.reporthang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reporthang);
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1059, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả báo cáo";
            // 
            // HangTableAdapter
            // 
            this.HangTableAdapter.ClearBeforeFill = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Indigo;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(925, 26);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 46);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(211, -9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 80);
            this.label1.TabIndex = 56;
            this.label1.Text = "Báo Cáo Thống Kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reportcs";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.reportcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporthang;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetHang DataSetHang;
        private DataSetHangTableAdapters.HangTableAdapter HangTableAdapter;
        private System.Windows.Forms.BindingSource HangBindingSource;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
    }
}