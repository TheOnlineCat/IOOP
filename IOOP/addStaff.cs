using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class addStaff : Form
    {
        public addStaff()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    if (String.IsNullOrWhiteSpace(txtBxName.Text.ToString()))
                    { 
                        MessageBox.Show("Invalid Name");
                        return;
                    }

                    if (String.IsNullOrWhiteSpace(cmbBxRole.Text.ToString()))
                    {
                        MessageBox.Show("Invalid Role");
                        return;
                    }
                    if (cmbBxRole.SelectedItem.ToString() == "tutor")
                    {

                        if (String.IsNullOrWhiteSpace(cmbBxLevel.Text.ToString()))
                        {
                            MessageBox.Show("Invalid Level");
                            return;
                        }
                        if (String.IsNullOrWhiteSpace(cmbBxSubject.Text.ToString()))
                        {
                            MessageBox.Show("Invalid Subject");
                            return;
                        }
                    }
                    
                    cmd.CommandText = "INSERT INTO [User](Username, Name, Role, Password) values('" +
                    txtBxStaffID.Text.ToString() + "','" +
                    txtBxName.Text.ToString() + "','" +
                    cmbBxRole.Text.ToString() + "','" +
                    txtBxStaffID.Text.ToString() + "')";
                    cmd.ExecuteNonQuery();

                    if (cmbBxRole.SelectedItem.ToString() == "tutor")
                    {
                        cmd.CommandText = "INSERT INTO [Tutors](Username, Level, Subject) values ('" +
                        txtBxStaffID.Text.ToString() + "','" +
                        cmbBxLevel.Text.ToString() + "','" +
                        cmbBxSubject.Text.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            Close();
        }

        private void cmbBxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBxRole.SelectedItem.ToString() == "tutor")
            {
                cmbBxLevel.Enabled= true;
                cmbBxSubject.Enabled= true; 
            }

            else
            {
                cmbBxLevel.Enabled= false;
                cmbBxSubject.Enabled= false;
            }
            

        }

        private void addStaff_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Username from [User] order by Username desc";
                    int Highest = Convert.ToInt32(cmd.ExecuteScalar().ToString().Remove(0, 2));
                    string ID = (Highest + 1).ToString().PadLeft(3, '0');
                    string NewID = "ET" + ID;
                    txtBxStaffID.Text = NewID;
                }
            }
        }
    }
}
