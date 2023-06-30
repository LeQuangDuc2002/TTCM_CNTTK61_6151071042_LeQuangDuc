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
    public partial class Phieuxuat : Form
    {
        public Phieuxuat()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool kiemtra(string mapx)
        {
            string query = "select * from PhieuXuat where MaPX = '" + mapx + "' ";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
       }
        public void clear()
        {
            txtmapx.Text = " ";
            txtslx.Text = " ";
            cbcuahang.Text = " ";
            cbkho.Text = " ";
            cbmahang.Text = " ";
            cbnv.Text = " ";
            



        }
        public void load()
        {
            string query = "select * from PhieuXuat";
            dtgrvpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void Phieuxuat_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            string mapx = txtmapx.Text;
            string mahang = cbmahang.Text;
            string mach = cbcuahang.Text;
            string ngayxuat = dtnx.Text;
            string soluongxuat = txtslx.Text;
            string makho = cbkho.Text;
            string manv = cbnv.Text;
            if(kiemtra(mapx)==true || mapx =="")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO PhieuXuat (MaPX,MaHang,MaCH,NgayXuat,SoluongXuat,MaKho,MaNV)VALUES ('" + mapx + "','" + mahang + "','" + mach + "','" + ngayxuat + "', '" + soluongxuat + "','" + makho + "','" + manv + "') ";
                dtgrvpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }     
            load();
            clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mapx = txtmapx.Text;
            string mahang = cbmahang.Text;
            string mach = cbcuahang.Text;
            string ngayxuat = dtnx.Text;
            string soluongxuat = txtslx.Text;
            string makho = cbkho.Text;
            string manv = cbnv.Text;
            if (kiemtra(mapx) == false )
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " UPDATE PhieuXuat SET  MaHang='" + mahang + "',MaCH= '" + mach + "',NgayXuat='" + ngayxuat + "',SoluongXuat = '" + soluongxuat + "',MaKho='" + makho + "',MaNV='" + manv + "' where MaPX = '"+mapx+"' ";
                dtgrvpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mapx = txtmapx.Text;
            string mahang = cbmahang.Text;
            string mach = cbcuahang.Text;
            string ngayxuat = dtnx.Text;
            string soluongxuat = txtslx.Text;
            string makho = cbkho.Text;
            string manv = cbnv.Text;
            if (kiemtra(mapx) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM PhieuXuat WHERE MaPX = '" + mapx + "' ";
                dtgrvpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void txtslx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbmahang_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaHang FROM Hang");
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "MaHang";
        }

        private void cbcuahang_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select MaCH from CuaHang");
            cbcuahang.DataSource = data;
            cbcuahang.DisplayMember = "MaCH";
        }

        private void cbkho_MouseClick(object sender, MouseEventArgs e)
        {
            // DataTable data = DataProvider.Instance.ExecuteQuery(@"select MaKho from Kho");
            //cbkho.DataSource = data;
            //cbkho.DisplayMember = "MaKho";
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaKho FROM Kho");
            cbkho.DataSource = data;
            cbkho.DisplayMember = "MaKho";
        }

        private void cbnv_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaNV FROM NhanVien");
            cbnv.DataSource = data;
            cbnv.DisplayMember = "MaNV";

        }

        private void dtgrvpx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmapx.Text = dtgrvpx.Rows[idx].Cells["MaPX"].Value.ToString();
                txtslx.Text = dtgrvpx.Rows[idx].Cells["SoLuongXuat"].Value.ToString();
                cbkho.Text = dtgrvpx.Rows[idx].Cells["MaKho"].Value.ToString();
                cbcuahang.Text = dtgrvpx.Rows[idx].Cells["MaCH"].Value.ToString();
                cbmahang.Text = dtgrvpx.Rows[idx].Cells["MaHang"].Value.ToString();
                cbnv.Text = dtgrvpx.Rows[idx].Cells["MaNV"].Value.ToString();
                dtnx.Text = dtgrvpx.Rows[idx].Cells["NgayXuat"].Value.ToString();
            }
        }
    }
}
