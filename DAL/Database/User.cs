using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GUI;
namespace DAL.Database
{
    public static class User
    {
        string cnn = QL_NguoiDung.GetConnectString();
        SqlDataAdapter da;
        DataSet dsUser = new DataSet();
        DataColumn[] key = new DataColumn[1];


        public User()
        {

        }
        public void loadUserList()
        {
            string query = "select * from QL_NguoiDung";
            da = new SqlDataAdapter(query, cnn);
            da.Fill(dsUser, "User");
            key[0] = dsUser.Tables["User"].Columns[0];
            dsUser.Tables["User"].PrimaryKey = key;

        }
    }
}
