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
            this.lblAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddUserName.Location = new System.Drawing.Point(28, 30);
            this.lblAddUserName.Name = "lblAddUserName";
            this.lblAddUserName.Size = new System.Drawing.Size(102, 25);
            this.lblAddUserName.TabIndex = 0;
            this.lblAddUserName.Text = "Username";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddEmployee.Location = new System.Drawing.Point(31, 107);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(99, 25);
            this.lblAddEmployee.TabIndex = 1;
            this.lblAddEmployee.Text = "Employee";
            // 
            // lblAddRole
            // 
            this.lblAddRole.AutoSize = true;
            this.lblAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddRole.Location = new System.Drawing.Point(31, 184);
            this.lblAddRole.Name = "lblAddRole";
            this.lblAddRole.Size = new System.Drawing.Size(51, 25);
            this.lblAddRole.TabIndex = 2;
            this.lblAddRole.Text = "Role";
            // 
            // cmbAddEmployee
            // 
            this.cmbAddEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbAddEmployee.FormattingEnabled = true;
            this.cmbAddEmployee.Location = new System.Drawing.Point(36, 135);
            this.cmbAddEmployee.Name = "cmbAddEmployee";
            this.cmbAddEmployee.Size = new System.Drawing.Size(193, 33);
            this.cmbAddEmployee.TabIndex = 3;
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(36, 212);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(193, 33);
            this.cmbAddRole.TabIndex = 4;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddUserName.Location = new System.Drawing.Point(33, 58);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(196, 30);
            this.txtAddUserName.TabIndex = 5;
            // 
            // btnAddUserForm
            // 
            this.btnAddUserForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddUserForm.Location = new System.Drawing.Point(36, 267);
            this.btnAddUserForm.Name = "btnAddUserForm";
            this.btnAddUserForm.Size = new System.Drawing.Size(110, 45);
            this.btnAddUserForm.TabIndex = 6;
            this.btnAddUserForm.Text = "OK";
            this.btnAddUserForm.UseVisualStyleBackColor = false;
            this.btnAddUserForm.Click += new System.EventHandler(this.btnAddUserForm_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 345);
            this.Controls.Add(this.btnAddUserForm);
            this.Controls.Add(this.txtAddUserName);
            this.Controls.Add(this.cmbAddRole);
            this.Controls.Add(this.cmbAddEmployee);
            this.Controls.Add(this.lblAddRole);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.lblAddUserName);
            this.Name = "AddUserForm";
            this.Text = "Add User";
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