using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class viewReport : Form
    {
        public viewReport()
        {
            InitializeComponent();
        }

        private void cmbBxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject sub = new Subject(cmbBxView.SelectedItem.ToString());
            decimal total = sub.ChargeRate * sub.StudentNum;
            int num = sub.StudentNum;
            lblIncome.Text = total.ToString();
            lblStudentNum.Text = num.ToString();
        }

        private void viewReport_Load(object sender, EventArgs e)
        {
            List<string> sublist = Subject.GetExistingSubjects();
            foreach (string sub in sublist)
            {
                cmbBxView.Items.Add(sub);
            }
        }
    }
}
