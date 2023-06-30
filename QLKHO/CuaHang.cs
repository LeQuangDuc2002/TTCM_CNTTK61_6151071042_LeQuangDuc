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
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
        }

        public void load()
        {
            string query = "select * from CuaHang";
            dtgrvcuahang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public bool check(string mach)
        {
            string query = "select * from CuaHang where MaCH='" + mach + "'";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txttench.Text = " ";
            txtmach.Text = " ";
            txtdiahci.Text = " ";
            

        }
        private void CuaHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mach = txtmach.Text;
            string tench = txttench.Text;
            string diachi = txtdiahci.Text;
            if (check(mach) == true||mach=="")
                MessageBox.Show("Mã hàng trùng hoặc sai!", "Thông báo");
            else
            {
                string query = "INSERT INTO CuaHang(MaCH,TenCH,DiaChi) VALUES('" + mach + "',N'" + tench + "',N'" + diachi + "' ) ";
                dtgrvcuahang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mach = txtmach.Text;
            string tench = txttench.Text;
            string diachi = txtdiahci.Text;
            if (check(mach) == false )
                MessageBox.Show("Không tồn tại mã cửa hàng này", "Thông báo");
            else
            {
                string query = "update CuaHang SET TenCH= N'" + tench + "', DiaChi=  N'" + diachi + "' where MaCH = '"+mach+"' ";
                dtgrvcuahang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mach = txtmach.Text;
            string tench = txttench.Text;
            string diachi = txtdiahci.Text;
            if (check(mach) == false)
                MessageBox.Show("Không tồn tại mã cửa hàng này", "Thông báo");
            else
            {
                string query = "delete from CuaHang where MaCH = '" + mach + "' ";
                dtgrvcuahang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void dtgrvcuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if(idx>=0)
            {
                txtmach.Text = dtgrvcuahang.Rows[idx].Cells["MaCH"].Value.ToString();
                txttench.Text = dtgrvcuahang.Rows[idx].Cells["TenCH"].Value.ToString();
                txtdiahci.Text = dtgrvcuahang.Rows[idx].Cells["DiaChi"].Value.ToString();
            }
            
        }
    }
}
