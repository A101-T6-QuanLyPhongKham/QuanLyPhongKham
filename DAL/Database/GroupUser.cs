using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
namespace DAL.Database
{
    public class GroupUser
    {
        string cnn = @"Data Source=LAPTOP-K10406A5\SQLEXPRESS;Initial Catalog=QLPK;User ID=sa;Password=1";
        SqlDataAdapter da;
        DataSet dsGroupUser = new DataSet();
        DataColumn[] key = new DataColumn[1];
        public DataSet loadGroupUserList()
        {
            string query = "select * from QL_Nhomnguoidung";
            da = new SqlDataAdapter(query, cnn);
            da.Fill(dsGroupUser, "GroupUser");
            return dsGroupUser;

        }
    }
}
