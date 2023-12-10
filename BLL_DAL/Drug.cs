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
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<THUOC> get_All()
        {
            return qlpk.THUOCs.Select(a => a).OrderByDescending(a=> a.THUOC_ID).ToList();
        }
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
        public Decimal? get_Price_By_Id(int id)
        {
            return qlpk.THUOCs.Where(a => a.THUOC_ID == id).Select(a => a.THUOC_DONGIA).FirstOrDefault();
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


        public bool insert_data(string ma, string tenthuoc, int danhmuc, string dvt,  string dongia, int hsd, int ncc, string chidinh)
        {
            try
            {
                THUOC _dt = new THUOC();
                _dt.MATHUOC = ma;
                _dt.THUOC_TENTHUOC = tenthuoc;
                _dt.DANHMUC_ID = danhmuc;
                _dt.THUOC_DVT = dvt;
                _dt.THUOC_SOLUONG = 0;
                if(dongia.ToString() != string.Empty)
                    _dt.THUOC_DONGIA = Convert.ToDecimal(dongia);
                _dt.THUOC_HANSUDUNG = hsd;
                _dt.THUOC_NHACUNGCAP = ncc;
                _dt.THUOC_CHIDINH = chidinh;
                
                qlpk.THUOCs.InsertOnSubmit(_dt);
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
                THUOC  _user = qlpk.THUOCs.Where(kh => kh.THUOC_ID == id).FirstOrDefault();
                if (_user != null)
                {
                    qlpk.THUOCs.DeleteOnSubmit(_user);
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

        public bool update_data(int id, string ma,  string tenthuoc, int danhmuc, string dvt, string dongia, int hsd, int ncc, string chidinh)
        {
            try
            {
                THUOC _dt = qlpk.THUOCs.Where(kh => kh.THUOC_ID == id).FirstOrDefault();
                if (_dt != null)
                {
                    _dt.MATHUOC = ma;
                    _dt.THUOC_TENTHUOC = tenthuoc;
                    _dt.DANHMUC_ID = danhmuc;
                    _dt.THUOC_DVT = dvt;

                   
                    _dt.THUOC_DONGIA = Convert.ToDecimal(dongia);
                    _dt.THUOC_HANSUDUNG = hsd;
                    _dt.THUOC_NHACUNGCAP = ncc;
                    _dt.THUOC_CHIDINH = chidinh;
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
