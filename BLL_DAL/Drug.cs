using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Drug
    {
        QLPK_DataContext qlpk = new QLPK_DataContext();
        public List<THUOC> get_Drug_By_Category(int id)
        {
            return qlpk.THUOCs.Where(a => a.DANHMUC_ID == id).ToList();
        }
        public THUOC get_Drug_By_Name(string name)
        {
            return qlpk.THUOCs.Where(a => a.THUOC_TENTHUOC == name).FirstOrDefault();
        }
        public int get_Id_By_Name(string name)
        {
            return qlpk.THUOCs.Where(a => a.THUOC_TENTHUOC == name).Select(a => a.THUOC_ID).FirstOrDefault();
        }
        public DataTable Find_List_Drug_By_Name(string name)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TenThuoc");
            table.Columns.Add("DonViTinh");
            table.Columns.Add("ChiDinh");
            name.Trim().ToLower();
            var list = qlpk.THUOCs.Where(a => a.THUOC_TENTHUOC.Contains(name)).Select(a => a).ToList();

            if (list.Count == 0)
                return null;
            foreach (THUOC item in list)
            {
                DataRow row = table.NewRow();
                row["TenThuoc"] = item.THUOC_TENTHUOC;
                row["DonViTinh"] = item.THUOC_DVT;
                row["ChiDinh"] = item.THUOC_CHIDINH;
                
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
