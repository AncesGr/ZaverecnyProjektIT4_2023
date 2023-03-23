namespace Zaverecny_projekt_Greplova
{
    partial class AddUserForm
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
            this.lblAddUserName = new System.Windows.Forms.Label();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.lblAddRole = new System.Windows.Forms.Label();
            this.cmbAddEmployee = new System.Windows.Forms.ComboBox();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.btnAddUserForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUserName
            // 
            this.lblAddUserName.AutoSize = true;
            this.lblAddUserName.Location = new System.Drawing.Point(52, 40);
            this.lblAddUserName.Name = "lblAddUserName";
            this.lblAddUserName.Size = new System.Drawing.Size(70, 16);
            this.lblAddUserName.TabIndex = 0;
            this.lblAddUserName.Text = "Username";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Location = new System.Drawing.Point(52, 119);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(69, 16);
            this.lblAddEmployee.TabIndex = 1;
            this.lblAddEmployee.Text = "Employee";
            // 
            // lblAddRole
            // 
            this.lblAddRole.AutoSize = true;
            this.lblAddRole.Location = new System.Drawing.Point(52, 195);
            this.lblAddRole.Name = "lblAddRole";
            this.lblAddRole.Size = new System.Drawing.Size(36, 16);
            this.lblAddRole.TabIndex = 2;
            this.lblAddRole.Text = "Role";
            // 
            // cmbAddEmployee
            // 
            this.cmbAddEmployee.FormattingEnabled = true;
            this.cmbAddEmployee.Location = new System.Drawing.Point(55, 149);
            this.cmbAddEmployee.Name = "cmbAddEmployee";
            this.cmbAddEmployee.Size = new System.Drawing.Size(121, 24);
            this.cmbAddEmployee.TabIndex = 3;
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(55, 237);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(121, 24);
            this.cmbAddRole.TabIndex = 4;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(55, 80);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(100, 22);
            this.txtAddUserName.TabIndex = 5;
            // 
            // btnAddUserForm
            // 
            this.btnAddUserForm.Location = new System.Drawing.Point(55, 329);
            this.btnAddUserForm.Name = "btnAddUserForm";
            this.btnAddUserForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddUserForm.TabIndex = 6;
            this.btnAddUserForm.Text = "OK";
            this.btnAddUserForm.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.btnAddUserForm);
            this.Controls.Add(this.txtAddUserName);
            this.Controls.Add(this.cmbAddRole);
            this.Controls.Add(this.cmbAddEmployee);
            this.Controls.Add(this.lblAddRole);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.lblAddUserName);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUserName;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblAddRole;
        private System.Windows.Forms.ComboBox cmbAddEmployee;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.Button btnAddUserForm;
    }
}