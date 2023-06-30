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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }






        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
                
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            TimKiem tim = new TimKiem();
            tim.ShowDialog();
        }

        private void btnhang_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.ShowDialog();
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.ShowDialog();
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            NhaCC nhacc = new NhaCC();
            nhacc.ShowDialog();
        }

        private void btncuahang_Click(object sender, EventArgs e)
        {
            CuaHang cuahang = new CuaHang();
            cuahang.ShowDialog();

        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            Phieuxuat phieuxuat = new Phieuxuat();
            phieuxuat.ShowDialog();
        }

        private void btnhangton_Click(object sender, EventArgs e)
        {
             hangton hangton  = new hangton();
            hangton.ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {
            reportcs baocao = new reportcs();
            baocao.ShowDialog();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }
    }
}
