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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            string query = "select * from PhieuNhap";
            dtgrvpn.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        public bool kiemtra(string mapn)
        {
            string query = "select* from PhieuNhap where MaPN='" + mapn + "'";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txmapn.Text = " ";
            txgianhap.Text = " ";
            txsln.Text = " ";
            cbmahang.Text = " ";
            cbmancc.Text = " ";
            cbmanv.Text = " ";
            cbnakho.Text = " ";
            


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mapn = txmapn.Text;
            string mahang = cbmahang.Text;
            string mancc = cbmancc.Text;
            string makho = cbnakho.Text;
            string manv = cbmanv.Text;
            string ngaynhap = dtnn.Text;
            string gianhap = txgianhap.Text;
            string soluongnhap = txsln.Text;
            if (kiemtra(mapn) == true || mapn == "")
            {
                MessageBox.Show("mã phiếu nhập sai");
            }
            else
            {
                string query = "INSERT INTO PhieuNhap(MaPN,MaHang,MaNCC,MaKho,MaNV,NgayNhap,GiaNhap,SoLuongNhap) VALUES ('" + mapn + "','" + mahang + "','" + mancc + "','" + makho + "','" + manv + "','" + ngaynhap + "','" + gianhap + "','" + soluongnhap + "')";
                dtgrvpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mapn = txmapn.Text;
            string mahang = cbmahang.Text;
            string mancc = cbmancc.Text;
            string makho = cbnakho.Text;
            string manv = cbmanv.Text;
            string ngaynhap = dtnn.Text;
            string gianhap = txgianhap.Text;
            string soluongnhap = txsln.Text;
            if (kiemtra(mapn) == false)
            {
                MessageBox.Show("mã phiếu nhập không tồn tại");
            }
            else
            {
                string query = "UPDATE PhieuNhap SET MaHang='" + mahang + "',MaNCC= '" + mancc + "',MaKho='" + makho + "',MaNV='" + manv + "',NgayNhap='" + ngaynhap + "',GiaNhap='" + gianhap + "',SoLuongNhap = '" + soluongnhap + "' where MaPN='" + mapn + "'";
                dtgrvpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mapn = txmapn.Text;
            string mahang = cbmahang.Text;
            string mancc = cbmancc.Text;
            string makho = cbnakho.Text;
            string manv = cbmanv.Text;
            string ngaynhap = dtnn.Text;
            string gianhap = txgianhap.Text;
            string soluongnhap = txsln.Text;
            if (kiemtra(mapn) == false)
            {
                MessageBox.Show("mã phiếu nhập không tồn tại");
            }
            else
            {
                string query = "DELETE FROM PhieuNhap WHERE MaPN ='" + mapn + "'";
                dtgrvpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbnakho_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaKho FROM Kho");
            cbnakho.DataSource = data;
            cbnakho.DisplayMember = "MaKho";
        }

        private void cbmanv_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaNV FROM NhanVien");
            cbmanv.DataSource = data;
            cbmanv.DisplayMember = "MaNV";
        }

        private void cbmahang_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaHang FROM Hang");
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "MaHang";
        }

        private void cbmancc_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"SELECT MaNCC FROM NHACC");
             cbmancc.DataSource = data;
            cbmancc.DisplayMember = "MaNCC";

        }

        private void dtgrvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txmapn.Text = dtgrvpn.Rows[idx].Cells["MaPN"].Value.ToString();
                txgianhap.Text = dtgrvpn.Rows[idx].Cells["GiaNhap"].Value.ToString();
                txsln.Text = dtgrvpn.Rows[idx].Cells["SoLuongNhap"].Value.ToString();
                cbmahang.Text =  dtgrvpn.Rows[idx].Cells["MaHang"].Value.ToString();
                cbmancc.Text= dtgrvpn.Rows[idx].Cells["MaNCC"].Value.ToString();
                cbnakho.Text =dtgrvpn.Rows[idx].Cells["MaKho"].Value.ToString();
                cbmanv.Text = dtgrvpn.Rows[idx].Cells["MaNV"].Value.ToString();
                dtnn.Text =dtgrvpn.Rows[idx].Cells["NgayNhap"].Value.ToString();
            }
        }

        private void dtnn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
