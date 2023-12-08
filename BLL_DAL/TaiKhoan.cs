using System;
using System.Collections.Generic;
using System.Data;
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
        public bool check_account_is_Exits(string tendn)
        {
            QL_NGUOIDUNG taikhoan = qlPK.QL_NGUOIDUNGs.Where(a => a.TENDANGNHAP == tendn).Select(a=> a).FirstOrDefault();
            if (taikhoan == null)
                return true;
            return false;
        }
        public bool check_Staff_have_account(int id_nv){
            QL_NGUOIDUNG user = qlPK.QL_NGUOIDUNGs.Where(a=> a.NV_ID == id_nv).Select(b=> b).FirstOrDefault();
            if(user == null)
                return true;
            return false;
        }
        public List<QL_NGUOIDUNG> get_list_account()
        {
            return qlPK.QL_NGUOIDUNGs.Select(a => a).ToList();
        }
        public bool insert_data(string tendn, string matkhau, bool hoatdong, int nv_id)
        {
            try
            {
                QL_NGUOIDUNG _dt = new QL_NGUOIDUNG();
                _dt.TENDANGNHAP = tendn;
                _dt.MATKHAU = matkhau;
                _dt.HOATDONG = hoatdong;
                _dt.NV_ID = nv_id;

                qlPK.QL_NGUOIDUNGs.InsertOnSubmit(_dt);
                qlPK.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool remove_data(string tendn)
        {
            try
            {
                QL_NGUOIDUNG _user = qlPK.QL_NGUOIDUNGs.Where(kh => kh.TENDANGNHAP == tendn).FirstOrDefault();
                if (_user != null)
                {
                    qlPK.QL_NGUOIDUNGs.DeleteOnSubmit(_user);
                    qlPK.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;


        }
        public List<QL_NGUOIDUNG> get_list_account_in_group(int manhom)
        {
            var query = from nguoidung in qlPK.QL_NGUOIDUNGs
                        join nguoiDungNhom in qlPK.QL_NGUOIDUNGNHOMNGUOIDUNGs
                        on nguoidung.TENDANGNHAP equals nguoiDungNhom.TENDANGNHAP
                        where nguoiDungNhom.MANHOMNGUOIDUNG == manhom
                        select nguoidung;

            return query.ToList();
        }
        public bool update_data(string tendn,  string new_matkhau, bool new_trangthai, int new_nv)
        {
            try
            {
                QL_NGUOIDUNG _user = qlPK.QL_NGUOIDUNGs.Where(kh => kh.TENDANGNHAP == tendn).FirstOrDefault();
                if (_user != null)
                {
                    
                    _user.MATKHAU = new_matkhau;
                    _user.HOATDONG = new_trangthai;
                    _user.NV_ID = new_nv;
                    qlPK.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
       
    }
}
