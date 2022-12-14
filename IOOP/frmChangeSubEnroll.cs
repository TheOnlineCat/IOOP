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

    public partial class frmChangeSubEnrol : Form
    {
        Student student;
        string subToChange;
        string subToChoose;
        string reason;
        
        public frmChangeSubEnrol()
        {

        }
        public frmChangeSubEnrol(Student student)
        {
            InitializeComponent();
            this.student = student;
            if (student.GetSubjects() != null)
            {
                foreach (string sub in student.GetSubjects())
                {
                    if (sub != null) cmbSubToChange.Items.Add(sub);
                }
            }
            foreach (string subs in Subject.GetExistingSubjects())
                cmbSubToChoose.Items.Add(subs);

            lblName_StuID.Text = student.Name + "|" + student.StudentID;

        }

        private void frmChangeSubEnrol_Load(object sender, EventArgs e)
        {

        }

        private void frmChangeSubEnrol_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbSubToChange.Text !=null && cmbSubToChoose.Text !=null)
            {
                Requests subject=new Requests(student.StudentID);
                subToChange=cmbSubToChange.Text;
                subToChoose=cmbSubToChoose.Text;
                reason=txtReason.Text;
                if (subToChoose == cmbSubToChange.Items[0].ToString() || subToChoose == cmbSubToChange.Items[1].ToString() || subToChoose == cmbSubToChange.Items[2].ToString() || subToChoose == null || subToChange==null || subToChange ==null && subToChoose==null )
                {
                    MessageBox.Show("Please choose the subjects accordingly.");
                }
                else
                {
                    subject.GetSubToChange(subToChange, subToChoose, reason);
                    MessageBox.Show("Subject change request sent.");
                    Close();
                }
            }

           
        }

        private void lblName_StuID_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubToChange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
