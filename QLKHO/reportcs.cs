using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHO
{
    public partial class reportcs : Form
    {
        public reportcs()
        {
            InitializeComponent();
        }

        private void reportcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHang.Hang' table. You can move, or remove it, as needed.
            this.HangTableAdapter.Fill(this.DataSetHang.Hang);
            

            this.reporthang.RefreshReport();
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
