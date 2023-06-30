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
using System.Threading;
namespace QLKHO
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

      

        private void dn_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;//ten se lay gia tri tu o ten minh nhap tu ban phim
            string password = txtpassword.Text;

            if ( Login(usename,password)==true)
            {
                
                Trangchu trangchu = new Trangchu();
                trangchu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai ten tai khoan");
            }
        }

         bool Login (string usename, string password)
        {
            return Account.Instance.Login(usename, password);

        }





        private void thoát_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
