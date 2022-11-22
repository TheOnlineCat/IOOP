namespace IOOP_Assignment
{
    partial class viewReport
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbBxView = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 96);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Income:";
            // 
            // cmbBxView
            // 
            this.cmbBxView.FormattingEnabled = true;
            this.cmbBxView.Location = new System.Drawing.Point(110, 24);
            this.cmbBxView.Name = "cmbBxView";
            this.cmbBxView.Size = new System.Drawing.Size(99, 28);
            this.cmbBxView.TabIndex = 1;
            this.cmbBxView.SelectedIndexChanged += new System.EventHandler(this.cmbBxView_SelectedIndexChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblView.Location = new System.Drawing.Point(12, 27);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(74, 25);
            this.lblView.TabIndex = 2;
            this.lblView.Text = "View by";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(133, 96);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(58, 20);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Student:";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(133, 136);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(60, 20);
            this.lblStudentNum.TabIndex = 5;
            this.lblStudentNum.Text = "number";
            // 
            // viewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(232, 200);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cmbBxView);
            this.Controls.Add(this.lblTotal);
            this.Name = "viewReport";
            this.Text = "viewReport";
            this.Load += new System.EventHandler(this.viewReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotal;
        private ComboBox cmbBxView;
        private Label lblView;
        private Label lblIncome;
        private Label label1;
        private Label lblStudentNum;
    }
}