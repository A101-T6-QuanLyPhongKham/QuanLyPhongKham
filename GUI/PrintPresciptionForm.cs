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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace GUI
{
    public partial class PrintPresciptionForm : Form
    {
        public PrintPresciptionForm(int madon)
        {
            InitializeComponent();
            DonThuoc rpt = new DonThuoc();
            rpt.SetDatabaseLogon("sa", "1", "LAPTOP-K10406A5\\SQLEXPRESS", "QLPK");

            /////add parameters
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            



            crParameterDiscreteValue.Value = madon; // Giá trị tham số
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["MaDonThuoc"]; // Tên tham số trong report
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);






            crystalReportViewer1.ReportSource = rpt;
            
            crystalReportViewer1.Refresh();
        }

        private void PrintPresciptionForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
