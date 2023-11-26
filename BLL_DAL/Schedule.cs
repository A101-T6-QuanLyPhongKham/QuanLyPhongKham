using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Schedule
    {
        QLPK_DataContext qlpk = new QLPK_DataContext();
        public List<NHAN_VIEN> get_List_Doctor_In_Clinic(int maPhong, string Date_Now)
        {
            return qlpk.LICH_LAM_VIECs.Where(a => a.PK_ID == maPhong && a.NGAYLAMVIEC.ToString() == Date_Now).Join(qlpk.NHAN_VIENs, a => a.NV_ID, b => b.NV_ID, (a, b) => b).Where(c => c.NV_CHUCVU == "Bác Sĩ").ToList();
        }
     
    }
}
