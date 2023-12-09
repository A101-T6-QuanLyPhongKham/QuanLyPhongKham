using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CategoryDrug
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<DANHMUC_THUOC> get_List_Category()
        {
            return qlpk.DANHMUC_THUOCs.Select(a => a).ToList();
        }
        public string get_Name_By_Id(int id)
        {
            return qlpk.DANHMUC_THUOCs.Where(a => a.DANHMUC_ID == id).Select(a => a.DANHMUC_TEN).FirstOrDefault();
        }
    }
}
