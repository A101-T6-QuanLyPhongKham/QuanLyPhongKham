using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    public static class QL_NguoiDung
    {
        public static string GetConnectString()
        {
            return Properties.Settings.Default.connectString;
        }
        public enum LoginRusult
        {
            //Wrong Username or password
            Invalid,
            //User has been disable
            Disabled,
            //Login Success
            Success
        }
        public static int Check_Config()
        {
            if (Properties.Settings.Default.cnnStringFail == string.Empty)
            {
                return 1; //chuỗi cấu hình không tồn tại
            }

            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.cnnStringFail);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                {
                    _Sqlconn.Open();
                }
                return 0; // kết nối thành công, chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;//chuỗi cấu hình không phù hợp
            }

        }
        public static LoginRusult Check_User(string pUser, string pPass)
        {
            string query = "select * from QL_NguoiDung where TenDangNhap ='" + pUser + "' and MatKhau='" + pPass + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Properties.Settings.Default.cnnStringFail);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 0)
            {
                return LoginRusult.Invalid;
            }
            else if(dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginRusult.Disabled; //Tài khoản hiện đang bị khóa
            }
            return LoginRusult.Success;

        }
        
    }
}
