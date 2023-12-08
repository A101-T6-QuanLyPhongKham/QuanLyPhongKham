using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   
    public class DetailPrescription
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        
        public bool insert_data(int donthuoc, int thuoc, int sang, int trua, int toi, string loidan, string chandoan, string ngaytaikham, int soluong)
        {
            try
            {
                CHI_TIET_DON_THUOC _dt = new CHI_TIET_DON_THUOC();
                
                _dt.DONTHUOC_ID = donthuoc;
                _dt.THUOC_ID = thuoc;
                _dt.LIEUSANG = sang;
                _dt.LIEUTRUA = trua;
                _dt.LIEUTOI = toi;
                _dt.LOIDAN = loidan;
                _dt.CHANDOAN = chandoan;
                _dt.NGAYTAIKHAM = Convert.ToDateTime(ngaytaikham);
                _dt.SOLUONG = soluong;

                qlpk.CHI_TIET_DON_THUOCs.InsertOnSubmit(_dt);
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
