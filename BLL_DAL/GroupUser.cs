using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class GroupUser
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public int Generate_Code()
        {
            var patientCode = qlpk.QL_NHOMNGUOIDUNGs.OrderByDescending(a => a.MANHOM).Select(a => a.MANHOM).FirstOrDefault().ToString();

            if (patientCode == "")
                return 1;

            int Code = Convert.ToInt32(patientCode);
            return Code + 1;
        }
        public List<QL_NGUOIDUNGNHOMNGUOIDUNG> get_group_by_username(string username)
        {
            return qlpk.QL_NGUOIDUNGNHOMNGUOIDUNGs.Where(a => a.TENDANGNHAP == username).Select(a => a).ToList();
            
        }
        public List<QL_NHOMNGUOIDUNG> get_list_group_user()
        {
            return qlpk.QL_NHOMNGUOIDUNGs.Select(a=> a).ToList();
        }
        
        public bool check_Name_Exist(string tennhom)
        {
            QL_NHOMNGUOIDUNG gr = qlpk.QL_NHOMNGUOIDUNGs.Where(a => a.TENNHOM == tennhom).Select(a => a).FirstOrDefault();
            if (gr == null)
                return true;
            return false;
        }

        public bool remove_data(int manhom)
        {
            try
            {
                QL_NHOMNGUOIDUNG _user = qlpk.QL_NHOMNGUOIDUNGs.Where(kh => kh.MANHOM == manhom).FirstOrDefault();
                if (_user != null)
                {
                    qlpk.QL_NHOMNGUOIDUNGs.DeleteOnSubmit(_user);
                    qlpk.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;


        }
        
        public bool insert_data(int ma, string ten, string ghichu)
        {
            try
            {
                QL_NHOMNGUOIDUNG _dt = new QL_NHOMNGUOIDUNG();
                _dt.MANHOM = ma;
                _dt.TENNHOM = ten;
                _dt.GHICHU = ghichu;
                qlpk.QL_NHOMNGUOIDUNGs.InsertOnSubmit(_dt);
                qlpk.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
