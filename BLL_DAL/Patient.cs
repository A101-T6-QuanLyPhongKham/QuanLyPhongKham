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
        public string Generate_Code_Patient()
        {
            var patientCode = qlpk.BENH_NHANs.OrderByDescending(a => a.BN_ID).Select(a => a.BN_ID).FirstOrDefault().ToString();

            if (patientCode == string.Empty)
                return "BN1";
            return patientCode;
        }   
        public DataTable Find_Info_Patient_By_Name(string name)
        {
            var tb = qlpk.BENH_NHANs.Where(a => a.BN_ID == name).Select(a => a);
            
        }

        }

    }
}
