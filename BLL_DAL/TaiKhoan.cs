using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TaiKhoan
    {
        public enum LoginResult
        {
            //Wrong Username or password
            Invalid,
            //User has been disable
            Disabled,
            //Login Success
            Success
        }
        QLPK_DataContext qlPK = new QLPK_DataContext();
        public LoginResult KiemTraDangNhap(string tdn, string mk)
        {
            var TaiKhoans = from tk in qlPK.QL_NGUOIDUNGs
                            where
                                tk.TENDANGNHAP == tdn && tk.MATKHAU == mk
                            select tk;

            var TaiKhoan = TaiKhoans.FirstOrDefault();

            if (TaiKhoan != null)
            {
                if (TaiKhoan.HOATDONG == false)
                {
                    return LoginResult.Disabled;
                }

                if (TaiKhoan.MATKHAU == mk)
                {
                    return LoginResult.Success;
                }
            }

            return LoginResult.Invalid;

        }
        public string get_NV_id_By_UserName(string userName)
        {
            return qlPK.QL_NGUOIDUNGs.Where(a => a.TENDANGNHAP == userName).Select(b => b.NV_ID).FirstOrDefault().ToString();
        }
        public bool block_Account(string username)
        {
            QL_NGUOIDUNG user = qlPK.QL_NGUOIDUNGs.Where(a => a.TENDANGNHAP == username).FirstOrDefault();
            if (user != null)
            {
                user.HOATDONG = false;
                qlPK.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
