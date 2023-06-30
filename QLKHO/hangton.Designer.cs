namespace QLKHO
{
    partial class hangton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgrvhangton = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qUANLYKHODataSet = new QLKHO.QUANLYKHODataSet();
            this.qUANLYKHODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvhangton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgrvhangton);
            this.panel1.Location = new System.Drawing.Point(3, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 318);
            this.panel1.TabIndex = 1;
            // 
            // dtgrvhangton
            // 
            this.dtgrvhangton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvhangton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvhangton.Location = new System.Drawing.Point(0, 0);
            this.dtgrvhangton.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvhangton.Name = "dtgrvhangton";
            this.dtgrvhangton.RowHeadersWidth = 51;
            this.dtgrvhangton.Size = new System.Drawing.Size(1019, 318);
            this.dtgrvhangton.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Indigo;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(882, 105);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(136, 44);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 89);
            this.label1.TabIndex = 55;
            this.label1.Text = "QUẢN LÍ HÀNG TỒN";
            // 
            // qUANLYKHODataSet
            // 
            this.qUANLYKHODataSet.DataSetName = "QUANLYKHODataSet";
            this.qUANLYKHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYKHODataSetBindingSource
            // 
            this.qUANLYKHODataSetBindingSource.DataSource = this.qUANLYKHODataSet;
            this.qUANLYKHODataSetBindingSource.Position = 0;
            // 
            // hangton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1023, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hangton";
            this.Text = "Hàng Tồn";
            this.Load += new System.EventHandler(this.hangton_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvhangton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrvhangton;
        private System.Windows.Forms.BindingSource qUANLYKHODataSetBindingSource;
        private QUANLYKHODataSet qUANLYKHODataSet;
    }
}