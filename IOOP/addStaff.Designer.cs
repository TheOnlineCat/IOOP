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
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbBxLevel = new System.Windows.Forms.ComboBox();
            this.cmbBxSubject = new System.Windows.Forms.ComboBox();
            this.cmbBxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBxStaffID = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(32, 217);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 26;
            this.lblSubject.Text = "Subject";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(32, 170);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(43, 20);
            this.lblLevel.TabIndex = 25;
            this.lblLevel.Text = "Level";
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
            this.cmbBxLevel.Location = new System.Drawing.Point(105, 167);
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
            this.cmbBxSubject.Location = new System.Drawing.Point(105, 214);
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
            this.cmbBxRole.Location = new System.Drawing.Point(105, 121);
            this.cmbBxRole.Name = "cmbBxRole";
            this.cmbBxRole.Size = new System.Drawing.Size(99, 28);
            this.cmbBxRole.TabIndex = 22;
            this.cmbBxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBxRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(32, 124);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 21;
            this.lblRole.Text = "Role";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(193, 263);
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
            this.txtBxStaffID.Location = new System.Drawing.Point(105, 75);
            this.txtBxStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxStaffID.Name = "txtBxStaffID";
            this.txtBxStaffID.PlaceholderText = "ID";
            this.txtBxStaffID.Size = new System.Drawing.Size(135, 27);
            this.txtBxStaffID.TabIndex = 17;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(105, 32);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.PlaceholderText = "Name";
            this.txtBxName.Size = new System.Drawing.Size(135, 27);
            this.txtBxName.TabIndex = 16;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(32, 81);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(27, 20);
            this.lblStaffID.TabIndex = 13;
            this.lblStaffID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 39);
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
            this.ClientSize = new System.Drawing.Size(307, 324);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbBxLevel);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.cmbBxSubject);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.cmbBxRole);
            this.Controls.Add(this.txtBxStaffID);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnConfirm);
            this.Name = "addStaff";
            this.Text = "addTutor";
            this.Load += new System.EventHandler(this.addStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBxStaffID;
        private TextBox txtBxName;
        private Label lblStaffID;
        private Label lblName;
        private Button btnConfirm;
        private ComboBox cmbBxRole;
        private Label lblRole;
        private Label lblSubject;
        private Label lblLevel;
        private ComboBox cmbBxLevel;
        private ComboBox cmbBxSubject;
    }
}