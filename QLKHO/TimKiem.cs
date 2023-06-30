using QLKHO.DAO;
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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            string query= "select *from Hang";
            dtgrvtimkiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string timkiem = txtmahang.Text;
            string query = "select*from Hang WHERE MaHang like '%" + timkiem + "%'";
            dtgrvtimkiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
