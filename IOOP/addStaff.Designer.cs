namespace IOOP_Assignment
{
    partial class addStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSubject = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.Label();
            this.cmbBxLevel = new System.Windows.Forms.ComboBox();
            this.cmbBxSubject = new System.Windows.Forms.ComboBox();
            this.cmbBxRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBxStaffID = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.cmbBxLevel);
            this.groupBox1.Controls.Add(this.cmbBxSubject);
            this.groupBox1.Controls.Add(this.cmbBxRole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txtBxStaffID);
            this.groupBox1.Controls.Add(this.txtBxName);
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Staff";
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSize = true;
            this.txtSubject.Location = new System.Drawing.Point(17, 208);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(58, 20);
            this.txtSubject.TabIndex = 26;
            this.txtSubject.Text = "Subject";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Location = new System.Drawing.Point(17, 161);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(43, 20);
            this.txtLevel.TabIndex = 25;
            this.txtLevel.Text = "Level";
            // 
            // cmbBxLevel
            // 
            this.cmbBxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLevel.FormattingEnabled = true;
            this.cmbBxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbBxLevel.Location = new System.Drawing.Point(90, 158);
            this.cmbBxLevel.Name = "cmbBxLevel";
            this.cmbBxLevel.Size = new System.Drawing.Size(99, 28);
            this.cmbBxLevel.TabIndex = 24;
            // 
            // cmbBxSubject
            // 
            this.cmbBxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSubject.FormattingEnabled = true;
            this.cmbBxSubject.Items.AddRange(new object[] {
            "English",
            "History",
            "Maths",
            "Science"});
            this.cmbBxSubject.Location = new System.Drawing.Point(90, 205);
            this.cmbBxSubject.Name = "cmbBxSubject";
            this.cmbBxSubject.Size = new System.Drawing.Size(99, 28);
            this.cmbBxSubject.TabIndex = 23;
            // 
            // cmbBxRole
            // 
            this.cmbBxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxRole.FormattingEnabled = true;
            this.cmbBxRole.Items.AddRange(new object[] {
            "tutor",
            "reception"});
            this.cmbBxRole.Location = new System.Drawing.Point(90, 112);
            this.cmbBxRole.Name = "cmbBxRole";
            this.cmbBxRole.Size = new System.Drawing.Size(99, 28);
            this.cmbBxRole.TabIndex = 22;
            this.cmbBxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBxRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Role";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(178, 254);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 30);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBxStaffID
            // 
            this.txtBxStaffID.Enabled = false;
            this.txtBxStaffID.Location = new System.Drawing.Point(90, 66);
            this.txtBxStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxStaffID.Name = "txtBxStaffID";
            this.txtBxStaffID.PlaceholderText = "ID";
            this.txtBxStaffID.Size = new System.Drawing.Size(135, 27);
            this.txtBxStaffID.TabIndex = 17;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(90, 23);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.PlaceholderText = "Name";
            this.txtBxName.Size = new System.Drawing.Size(135, 27);
            this.txtBxName.TabIndex = 16;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(17, 72);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(27, 20);
            this.lblStaffID.TabIndex = 13;
            this.lblStaffID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // addStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "addStaff";
            this.Text = "addTutor";
            this.Load += new System.EventHandler(this.addStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBxStaffID;
        private TextBox txtBxName;
        private Label lblStaffID;
        private Label lblName;
        private Button btnConfirm;
        private ComboBox cmbBxRole;
        private Label label1;
        private Label txtSubject;
        private Label txtLevel;
        private ComboBox cmbBxLevel;
        private ComboBox cmbBxSubject;
    }
}