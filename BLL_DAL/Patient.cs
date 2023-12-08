using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL_DAL
{
    public class Patient
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        
        public string Trim_String_Date(string input)
        {
         
            int Index = input.IndexOf(' ');
            return input.Substring(0, Index);
            
        }
        public BENH_NHAN get_Info_Patient_By_Code(int Code)
        {
            return qlpk.BENH_NHANs.Where(a => a.BN_ID == Code).Select(a => a).FirstOrDefault();
        }
        public DataTable Find_Info_Patient_By_Name(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BN_ID");
            dt.Columns.Add("BN_TEN");
            dt.Columns.Add("BN_NGAYSINH");
            dt.Columns.Add("BN_SDT");
            dt.Columns.Add("BN_GIOITINH");
            dt.Columns.Add("BN_DIACHI");
            name.Trim().ToLower();
            var list_BN = qlpk.BENH_NHANs.Where(a => a.BN_TEN.Contains(name)).Select(a => a).ToList();

            if(list_BN.Count == 0)
                return null;
            foreach (BENH_NHAN a in list_BN)
            {
                DataRow row = dt.NewRow();
                row["BN_ID"] = a.BN_ID;
                row["BN_TEN"] = a.BN_TEN;
                row["BN_NGAYSINH"] = Trim_String_Date(a.BN_NGAYSINH.ToString());
                row["BN_SDT"] = a.BN_SDT;
                row["BN_GIOITINH"] = a.BN_GIOITINH;
                row["BN_DIACHI"] = a.BN_DIACHI;
                dt.Rows.Add(row);
            }
            return dt;
            
        }
        public bool Add_New_Patient(BENH_NHAN bn)
        {
            try 
            {
                qlpk.BENH_NHANs.InsertOnSubmit(bn);
                qlpk.SubmitChanges();
                return true;
            }
            catch{
                return false;
            }
            
        }
        public bool Delete_Patient(string Code)
        {
            BENH_NHAN bn = qlpk.BENH_NHANs.Where(a => a.BN_ID == Convert.ToInt32(Code)).FirstOrDefault();

            try
            {
                qlpk.BENH_NHANs.DeleteOnSubmit(bn);
                qlpk.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
                
        }
        public void update_info_Health(int id, int chieucao, int cannang, int huyetap, int nhiptim, int nhietdo)
        {
            BENH_NHAN _khoaSua = qlpk.BENH_NHANs.Where(kh => kh.BN_ID == id).FirstOrDefault();
            if (_khoaSua != null)
            {
                _khoaSua.BN_CHIEUCAO = chieucao;
                _khoaSua.BN_CANNANG = cannang;
                _khoaSua.BN_HUYETAP = huyetap;
                _khoaSua.BN_NHIPTIM = nhiptim;
                _khoaSua.BN_NHIETDO = nhietdo;
                qlpk.SubmitChanges();

            }


        }
        public List<BENH_NHAN> get_all()
        {
            return qlpk.BENH_NHANs.Select(a => a).ToList();
        }
        

    }
}
