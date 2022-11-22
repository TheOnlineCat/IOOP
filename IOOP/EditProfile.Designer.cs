namespace IOOP_Assignment
{
    partial class EditProfile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtCurrPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPass = new System.Windows.Forms.GroupBox();
            this.grpClass.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(166, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 46);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Editing Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(433, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "$Name$";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(569, 12);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(90, 46);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Role";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(7, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(78, 46);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "ETC";
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnEdit);
            this.grpClass.Controls.Add(this.txtUsername);
            this.grpClass.Controls.Add(this.txtName);
            this.grpClass.Controls.Add(this.lblUsername);
            this.grpClass.Controls.Add(this.lblTName);
            this.grpClass.Location = new System.Drawing.Point(87, 100);
            this.grpClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpClass.Name = "grpClass";
            this.grpClass.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpClass.Size = new System.Drawing.Size(408, 195);
            this.grpClass.TabIndex = 25;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "User Profile";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(151, 149);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 29);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit Password";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(112, 103);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(255, 27);
            this.txtUsername.TabIndex = 31;
            this.txtUsername.Text = "$USERNAME$";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(112, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 27);
            this.txtName.TabIndex = 30;
            this.txtName.Text = "$NAME$";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 27;
            this.lblUsername.Text = "Username:";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(57, 45);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(52, 20);
            this.lblTName.TabIndex = 26;
            this.lblTName.Text = "Name:";
            // 
            // txtCPassword
            // 
            this.txtCPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCPassword.Location = new System.Drawing.Point(112, 99);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.PlaceholderText = "Confirm Password";
            this.txtCPassword.Size = new System.Drawing.Size(255, 27);
            this.txtCPassword.TabIndex = 33;
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Location = new System.Drawing.Point(24, 96);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(73, 40);
            this.lblCPassword.TabIndex = 29;
            this.lblCPassword.Text = "Confirm\r\nPassword:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(112, 35);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter New Password";
            this.txtPassword.Size = new System.Drawing.Size(255, 27);
            this.txtPassword.TabIndex = 32;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 32);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 40);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "New\r\nPassword:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(144, 157);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(122, 20);
            this.lblCurrent.TabIndex = 30;
            this.lblCurrent.Text = "Current Password";
            // 
            // txtCurrPassword
            // 
            this.txtCurrPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCurrPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCurrPassword.Location = new System.Drawing.Point(81, 183);
            this.txtCurrPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrPassword.Name = "txtCurrPassword";
            this.txtCurrPassword.PasswordChar = '*';
            this.txtCurrPassword.PlaceholderText = "Enter Current password to save changes";
            this.txtCurrPassword.Size = new System.Drawing.Size(255, 27);
            this.txtCurrPassword.TabIndex = 34;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(433, 592);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 40);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(26, 592);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 40);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpPass
            // 
            this.grpPass.Controls.Add(this.lblPassword);
            this.grpPass.Controls.Add(this.txtCPassword);
            this.grpPass.Controls.Add(this.txtPassword);
            this.grpPass.Controls.Add(this.txtCurrPassword);
            this.grpPass.Controls.Add(this.lblCPassword);
            this.grpPass.Controls.Add(this.lblCurrent);
            this.grpPass.Location = new System.Drawing.Point(87, 315);
            this.grpPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPass.Name = "grpPass";
            this.grpPass.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPass.Size = new System.Drawing.Size(408, 257);
            this.grpPass.TabIndex = 37;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Password";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 647);
            this.Controls.Add(this.grpPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditProfile";
            this.Text = "Form4";
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.grpPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Label lblName;
        private Label lblRole;
        private Label lblLogo;
        private GroupBox grpClass;
        private TextBox txtCPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtName;
        private Label lblCPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblTName;
        private Label lblCurrent;
        private TextBox txtCurrPassword;
        private Button btnConfirm;
        private Button btnEdit;
        private Button btnCancel;
        private GroupBox grpPass;
    }
}