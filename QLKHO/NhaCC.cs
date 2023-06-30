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
    public partial class NhaCC : Form
    {
        public NhaCC()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            txttenncc.Text = " ";
            txtmancc.Text = " ";
            txtdiachi.Text = " ";
            txtdienthoai.Text = " ";
            
        }
         
        private void NhaCC_Load(object sender, EventArgs e)
        {
            hamload();
        }
        public void hamload()
        {
            string query = "select * from NhaCC";
            dtgrvnhacc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public bool kiemtra(string mancc)
        {
            string query = "SELECT * from NHACC WHERE MaNCC = '" + mancc + "' ";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count>0;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            if (kiemtra(mancc) == true|| mancc =="")
            {
                MessageBox.Show(" mã nhà cung cấp trùng hoặc lỗi");
            }
            else
            {
                string query = "INSERT INTO NHACC(MaNCC,TenNCC,DiaChi,Đthoai) VALUES(N'" + mancc + "',N'" + tenncc + "',N'" + diachi + "','" + dienthoai + "')";
                dtgrvnhacc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            hamload();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            if (kiemtra(mancc) == false)
                MessageBox.Show("Mã nhà cung cấp không có", "thông báo");
            else
            {
                string query = "UPDATE  NHACC SET TenNCC ='" + tenncc + "',DiaChi ='" + diachi + "',Đthoai ='"+dienthoai+"'where MaNCC='"+mancc+"'";
                dtgrvnhacc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            hamload();
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            if (kiemtra(mancc) == false)
                MessageBox.Show("Mã Nhà cung cấp không tồn tại!", "Thông báo");
            else
            {
                string query = "DELETE FROM NHACC WHERE MaNCC ='" + mancc + "'";
                dtgrvnhacc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            hamload();
            clear();

        }

        private void txtdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgrvnhacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if(idx>=0)
            {
                txtmancc.Text = dtgrvnhacc.Rows[idx].Cells["MaNCC"].Value.ToString();
                txttenncc.Text = dtgrvnhacc.Rows[idx].Cells["TenNCC"].Value.ToString();
                txtdiachi.Text = dtgrvnhacc.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtdienthoai.Text = dtgrvnhacc.Rows[idx].Cells["Đthoai"].Value.ToString();

                    
            }
        }
    }
}
