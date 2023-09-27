using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GUI
{
    public partial class configForm : Form
    {
        public configForm()
        {
            InitializeComponent();
        }

        private void cbbServername_DropDown(object sender, EventArgs e)
        {
            cbbServername.DataSource = GetServerName();
            cbbServername.DisplayMember = "ServerName";
        }
        private DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ServerName");

            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();

            foreach (DataRow row in table.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string instanceName = row["InstanceName"].ToString();

                if (!string.IsNullOrEmpty(instanceName))
                {
                    serverName += "\\" + instanceName;
                }

                dt.Rows.Add(serverName);
            }

            return dt;
        }

        private void cbbDatabase_DropDown(object sender, EventArgs e)
        {
            
            cbbDatabase.DataSource = GetDBName(cbbServername.Text, txtUsername.Text, txtPassword.Text);
            cbbDatabase.DisplayMember = "name";
        }

        private DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            string queryselect = "select name from sys.Databases";
            string queryArgument = "Data Source="+ pServer +";Initial Catalog= master;User ID =" +pUser +";Password = "+pPass;
            SqlDataAdapter da = new SqlDataAdapter(queryselect, queryArgument);
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch
            {
                MessageBox.Show("Cấu hình không hợp lệ");
                return null;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfig(cbbServername.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            this.Close();
            
        }
        private void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            Properties.Settings.Default.cnnStringFail = "Data Source = " + pServer + ";Initial Catalog=" + pDBName + ";User ID = " + pUser + ";Password=" + pPass;
            Properties.Settings.Default.Save();
        }

        private void cbbServername_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }

        private void KiemTraNhapLieu()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                cbbDatabase.Enabled = true;
            }
            else
            {
                cbbDatabase.Enabled = false;
                cbbDatabase.Text = ""; 
            }
        }
    }
}
