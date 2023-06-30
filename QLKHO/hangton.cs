using QLKHO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKHO
{
    public partial class hangton : Form
    {
        private List<TT_Hang> ds = new List<TT_Hang>();
        
        public hangton()
        {
            InitializeComponent();
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
                        

        }
        
        private void hangton_Load(object sender, EventArgs e)
        {
            
            string query = "select MaHang,TenHang,Loai,SoLuong from Hang";
          
              DataTable data = DataProvider.Instance.ExecuteQuery(query);



            foreach (DataRow row in data.Rows)
            {
                string m = row[0].ToString();
                string t = row[1].ToString();
                string l = row[2].ToString();
                var sl = int.TryParse(row[3].ToString(), out int outNumber);
                ds.Add(new TT_Hang(m, t, l, outNumber));
                //TTHangList.Add(new TT_Hang(m, t, l, outNumber));
            }
            //Hàm quicksort khử đệ quy

            int left = 0;
            int right = ds.Count - 1;

            Stack<int> Sl = new Stack<int>();       // Stack left
            Stack<int> Sr = new Stack<int>();       // Stack right

            Sl.Push(left);         // dua phan tu dau tien l vao Sl
            Sr.Push(right);         // dua phan tu dau tien r vao Sl

            while (Sl.Count != 0)  // trong khi stack khong rong
            {

                //int l1 = Convert.ToInt32(Sl.Pop());
                int l1 = Sl.Pop(); // lay phan tu dau tien trong Sl l ra
                                   //int r1 = Convert.ToInt32(Sr.Pop()); 
                int r1 = Sr.Pop();     // lay phan tu dau tien trong Sr r ra
                Random rd = new Random();
                int numrd = rd.Next(1, 10);
                TT_Hang key = ds[left + numrd % (right - left + 1)];
                int i = l1;
                int j = r1;
                while (i <= j)       // phan hoach thanh 2 day con
                {
                    while (ds[i].Sl > key.Sl) i++;
                    while (ds[j].Sl < key.Sl) j--;

                    if (i <= j)
                    {
                        if (i < j)
                        {

                            TT_Hang tg = ds[i];
                            ds[i] = ds[j];
                            ds[j] = tg;
                        }
                        i++;
                        j--;
                    }
                }
                if (l1 < j) { Sl.Push(l1); Sr.Push(j); }   // dua 2 dau mut l va j vao Sl va Sr
                if (i < r1) { Sl.Push(i); Sr.Push(r1); }   // dua 2 dau mut i va r vao Sl va Sr
            }
            //

            dtgrvhangton.DataSource = ds;
        
            dtgrvhangton.Columns[0].HeaderText = "Mã Hàng";
             dtgrvhangton.Columns[0].Width = 100;
            dtgrvhangton.Columns[1].HeaderText = "Tên Hàng";
            dtgrvhangton.Columns[1].Width = 250;
            dtgrvhangton.Columns[2].HeaderText = "Loại Hàng";
           dtgrvhangton.Columns[2].Width = 200;
            dtgrvhangton.Columns[3].HeaderText = "hàng tồn";
            dtgrvhangton.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
    } }
            
            
