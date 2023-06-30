using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHO.DAO
{
    class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) ; instance = new Account(); return Account.instance; }

            private set { Account.instance = value; }
        }

        public bool Login(string usename,string password)
        {
            string query = "select * from DangNhap where usename =('"+usename+"') and password = ('"+password+"')"; //truy van tu du lieu minh nhap o 2 o textbox
            DataTable result = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van va tra duy lieu ve table

            return result.Rows.Count > 0;  //tra ve gia tri >0 
        }
    }
}
