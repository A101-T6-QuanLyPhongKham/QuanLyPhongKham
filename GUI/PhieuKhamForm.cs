using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace GUI
{
    public partial class PhieuKhamForm : Form
    {
        
        public PhieuKhamForm(string tenBN, string namSinh, string SoPhongKham)
        {
            InitializeComponent();
            PhieuKham cryRpt = new PhieuKham();
            PhongKham pk = new PhongKham();
           


            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = tenBN; // Giá trị tham số
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Name"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

           
            crParameterDiscreteValue.Value = namSinh; // Giá trị tham số
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Birth"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);




            
            crParameterDiscreteValue.Value = SoPhongKham; // Giá trị tham số
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Room"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);



            int Number_Now = pk.get_Order_Now_Patient_Now(Convert.ToInt32(SoPhongKham));

            crParameterDiscreteValue.Value = Number_Now;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Number"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            crParameterDiscreteValue.Value = DateTime.Now;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["currentDay"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            viewrpt.ReportSource = cryRpt;
            viewrpt.Refresh();




            
            

        }
    }
}
