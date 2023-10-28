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
        QLPKDataContext qlPK = new QLPKDataContext();
        public LoginResult KiemTraDangNhap(string tdn, string mk)
        {
            var TaiKhoans = from tk in qlPK.QL_NGUOIDUNGs
                            where
                                tk.TENDANGNHAP == tdn && tk.MATKHAU == mk
                            select tk;

            var TaiKhoan = TaiKhoans.FirstOrDefault();

            if (TaiKhoan != null)
            {
                if (TaiKhoan.HOATDONG == "False")
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
    }
}
