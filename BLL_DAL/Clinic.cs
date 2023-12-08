using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Clinic
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public int Generate_Code()
        {
            var patientCode = qlpk.PHONG_KHAMs.OrderByDescending(a => a.PHONGKHAM_ID).Select(a => a.PHONGKHAM_ID).FirstOrDefault().ToString();

            if (patientCode == "")
                return 1;

            int Code = Convert.ToInt32(patientCode);
            return Code + 1;
        }
        public List<PHONG_KHAM> get_list()
        {
            return qlpk.PHONG_KHAMs.Select(a => a).ToList();
        }
        public bool insert_data(string chuyenkhoa, bool trangthai)
        {
            try
            {
                PHONG_KHAM _dt = new PHONG_KHAM();
                _dt.PHONGKHAM_ID = Generate_Code();
                _dt.PHONGKHAM_CHUYENKHOA = chuyenkhoa;
                _dt.HOATDONG = trangthai;
                _dt.SOLUONGBENHNHAN = 0;
                _dt.SOTHUTU = 0;
                qlpk.PHONG_KHAMs.InsertOnSubmit(_dt);
                qlpk.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool remove_data(int id)
        {
            try
            {
                PHONG_KHAM _user = qlpk.PHONG_KHAMs.Where(kh => kh.PHONGKHAM_ID == id).FirstOrDefault();
                if (_user != null)
                {
                    qlpk.PHONG_KHAMs.DeleteOnSubmit(_user);
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
        
        public bool update_data(int id,string chuyenkhoa, bool hoatdong)
        {
            try
            {
                PHONG_KHAM _user = qlpk.PHONG_KHAMs.Where(kh => kh.PHONGKHAM_ID == id).FirstOrDefault();
                if (_user != null)
                {

                    _user.PHONGKHAM_CHUYENKHOA = chuyenkhoa;
                    _user.HOATDONG = hoatdong;
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
    }
}
