using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Prescription
    {
        QLPKDataContext _qlpk = new QLPKDataContext();
        public int Generate_Code()
        {
            var patientCode = _qlpk.DON_THUOC_DICHVUs.OrderByDescending(a => a.DONTHUOC_ID).Select(a => a.DONTHUOC_ID).FirstOrDefault().ToString();

            if (patientCode == "")
                return 1;

            int Code = Convert.ToInt32(patientCode);
            return Code + 1;
        }
        public int get_current_Prescription()
        {
            return Convert.ToInt32(_qlpk.DON_THUOC_DICHVUs.OrderByDescending(a => a.DONTHUOC_ID).Select(a => a.DONTHUOC_ID).FirstOrDefault().ToString());
        }
        public bool insert_data(string date, int nv, int bn, int pk, float TongTien)
        {
            try
            {
                DON_THUOC_DICHVU _dt = new DON_THUOC_DICHVU();
                _dt.DONTHUOC_ID = Generate_Code();
                _dt.NGAYLAP = Convert.ToDateTime(date);
                _dt.NV_ID = nv;
                _dt.BN_ID = bn;
                _dt.PK_ID = pk;
                _dt.TONGTIEN = Convert.ToDecimal(TongTien);

                _qlpk.DON_THUOC_DICHVUs.InsertOnSubmit(_dt);
                _qlpk.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void update_Price(int id, double tongTien)
        {
            DON_THUOC_DICHVU _khoaSua = _qlpk.DON_THUOC_DICHVUs.Where(kh => kh.DONTHUOC_ID == id).FirstOrDefault();
            if (_khoaSua != null)
            {
                _khoaSua.TONGTIEN = Convert.ToDecimal(tongTien);
                _qlpk.SubmitChanges();

            }


        }
    }
}
