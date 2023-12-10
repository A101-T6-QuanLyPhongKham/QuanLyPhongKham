using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PHIEUKHAMBENH
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<PHIEU_KHAM> get_List_PhieuKham(int maPhong, string ngay, int BS)
        {
            return qlpk.PHIEU_KHAMs.Where(a => a.PHIEUKHAM_PK == maPhong && a.PHIEUKHAM_NGAY.ToString() == ngay && a.PHIEUKHAM_BS == BS && a.PHIEUKHAM_TRANGTHAI == true).ToList();
        }
        public void update_state(int id)
        {
            PHIEU_KHAM _khoaSua = qlpk.PHIEU_KHAMs.Where(kh => kh.PHIEUKHAM_ID == id).FirstOrDefault();
            if (_khoaSua != null)
            {
                _khoaSua.PHIEUKHAM_TRANGTHAI = false;
                qlpk.SubmitChanges();

            }
        }
        private string get_id_Pk()
        {
            return qlpk.PHIEU_KHAMs.OrderByDescending(a => a.PHIEUKHAM_ID).Select(a => a.PHIEUKHAM_ID).FirstOrDefault().ToString();
        }
        public PHIEU_KHAM get_PhieuKham_By_Id(int id)
        {
            return qlpk.PHIEU_KHAMs.Where(a => a.PHIEUKHAM_ID == id).Select(a => a).FirstOrDefault();

        }
        public void init_PK(int bn, int pk, int bs)
        {
 
                PHIEU_KHAM phieu = new PHIEU_KHAM();

                string now_Number = get_id_Pk();
                int new_Number = Convert.ToInt32(now_Number) + 1;
                phieu.PHIEUKHAM_ID = new_Number;
                phieu.PHIEUKHAM_BN = bn;
                phieu.PHIEUKHAM_PK = pk;
                phieu.PHIEUKHAM_BS = bs;
                phieu.PHIEUKHAM_NGAY = DateTime.Now;
               
                

                phieu.PHIEUKHAM_TRANGTHAI = true;
                qlpk.PHIEU_KHAMs.InsertOnSubmit(phieu);
                qlpk.SubmitChanges();
                
            
            

        }
        public PHIEU_KHAM check_phieukham_isExist(int maBN, DateTime ngay)
        {
            List<PHIEU_KHAM> list = qlpk.PHIEU_KHAMs.Where(a => a.PHIEUKHAM_NGAY == ngay && a.PHIEUKHAM_BN == maBN).ToList();
            if(list.Count != 0)
            {
                foreach (PHIEU_KHAM item in list)
                {
                    if (item.PHIEUKHAM_TRANGTHAI == true)
                    {
                        return item;
                    }
                }
                return null;
            }
            
            return null;
        }
        public bool delete_phieukham_By_id(int id)
        {
            try
            {
                PHIEU_KHAM _pk = get_PhieuKham_By_Id(id);
                if(_pk != null)
                {
                    qlpk.PHIEU_KHAMs.DeleteOnSubmit(_pk);
                    qlpk.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
    }
}
