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
    public partial class Hang : Form
    {
        public Hang()
        {
            InitializeComponent();
            
        }

        public bool kiemtra(string mahang)
        {
            string query = "select * from Hang where MaHang = ('" + mahang + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmahang.Text = " ";
            txttenhang.Text = " ";
            txtsoluong.Text = " ";
            txtloai.Text = " ";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string mahang = txtmahang.Text;
            string tenhang = txttenhang.Text;
            string loai = txtloai.Text;
            string soluong = txtsoluong.Text;
            if(kiemtra(mahang)== true || mahang == "" )
            {
                MessageBox.Show("ma hang sai","Thông báo");
            }
            else
            {
                string query = "INSERT INTO Hang(MaHang,TenHang,Loai,SoLuong) VALUES ('" + mahang + "',N'" + tenhang + "',N'" + loai + "',N'" + soluong + "')";
                int result = DataProvider.Instance.ExecutenonQuery(query);
            }
            load();
            clear();
        }

       
        

        private void Hang_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            string query = "select * from Hang ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }
       

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mahang = txtmahang.Text;
            string tenhang = txttenhang.Text;
            string loai = txtloai.Text;
            string soluong = txtsoluong.Text;
            if(kiemtra(mahang)==true)
            {
                string query = " UPDATE Hang SET TenHang = N'" + tenhang + "', Loai = N'" + loai + "',SoLuong = '" + soluong + "' Where MaHang = '" + mahang + "' ";

                dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Mã Hàng không tồn tại");
            }
           
           
            
           
            load();
            clear();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahang = txtmahang.Text;
            string tenhang = txttenhang.Text;
            string loai = txtloai.Text;
            string soluong = txtsoluong.Text;
            if (kiemtra(mahang) == true)
            {
                string query = "DELETE from Hang where MaHang ='" + mahang + "' ";
                dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Mã Hàng không tồn tại");
            }
          
            load();
            clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))   //char.isdigit(e.keychar : kiem tra xem phim vua nhap co phai ky tu so ko va kha ve bool, && kiem tra xem co phai cac ky tu dieu khien
                e.Handled = true;// bat chan cac phim tren ham if
        }

        private void dtgrvhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if(idx>=0)
            {
                txtmahang.Text = dtgrvhang.Rows[idx].Cells["MaHang"].Value.ToString();
                txttenhang.Text = dtgrvhang.Rows[idx].Cells["TenHang"].Value.ToString();
                txtloai.Text= dtgrvhang.Rows[idx].Cells["Loai"].Value.ToString();
                txtsoluong.Text= dtgrvhang.Rows[idx].Cells["SoLuong"].Value.ToString();

            }
        }







        //singleton la lam sao tai 1 thoi diem chi duy nhat 1 connection lien ket voi csdl
        //instace the hien
        /*static khoi tao 1 lan duy nhat chay ca chuong trinh, chi goi thong qua ten ham
         muc dich muon 1 thuoc tinh nao do su dung chung cho moi doi tuong
         */
    }
}
