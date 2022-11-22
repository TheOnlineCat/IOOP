using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class adminHome : Form

    {
        private string username;
        private string name;
        public adminHome()
        {
            Refresh();
            InitializeComponent();
            
        }

        public adminHome(string Name, string Username)
        {
            InitializeComponent();
            lblName.Text = Name;
            name= Name;
            username= Username;
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            adminLoadlist();
        }
        private void adminLoadlist()
        {
            ArrayList name = new ArrayList();
            listBoxStaff.Items.Clear();
            name = User.ViewAllUser();
            foreach (var item in name)
            {
                listBoxStaff.Items.Add(item);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string selectedId = listBoxStaff.SelectedItem.ToString().Split(":")[0];
            User.DeleteUser(selectedId);
            listBoxStaff.Items.Remove(listBoxStaff.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f1 = new addStaff();
            f1.FormClosed += childForm_Closed;
            f1.Show();
        }
        private void childForm_Closed(object? sender, FormClosedEventArgs e)
        {
            adminLoadlist();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            Form f2 = new viewReport(); 
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile formEditProfile = new EditProfile(name, username);
            formEditProfile.ShowDialog();
        }

    }
}
