namespace Zaverecny_projekt_Greplova
{
    partial class AdminEmployeeForm
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
            this.lwAdmEmployeeEdit = new System.Windows.Forms.ListView();
            this.chEmployeeFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwAdmEmployeeEdit
            // 
            this.lwAdmEmployeeEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeFirstName,
            this.chEmployeeLastName,
            this.chId,
            this.chEmployeeBirthDate,
            this.chEmployeeEmail,
            this.chEmployeePhone});
            this.lwAdmEmployeeEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lwAdmEmployeeEdit.FullRowSelect = true;
            this.lwAdmEmployeeEdit.GridLines = true;
            this.lwAdmEmployeeEdit.HideSelection = false;
            this.lwAdmEmployeeEdit.Location = new System.Drawing.Point(0, 0);
            this.lwAdmEmployeeEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwAdmEmployeeEdit.MinimumSize = new System.Drawing.Size(745, 450);
            this.lwAdmEmployeeEdit.Name = "lwAdmEmployeeEdit";
            this.lwAdmEmployeeEdit.Size = new System.Drawing.Size(745, 450);
            this.lwAdmEmployeeEdit.TabIndex = 5;
            this.lwAdmEmployeeEdit.UseCompatibleStateImageBehavior = false;
            this.lwAdmEmployeeEdit.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeFirstName
            // 
            this.chEmployeeFirstName.DisplayIndex = 1;
            this.chEmployeeFirstName.Text = "Employee Firstname";
            this.chEmployeeFirstName.Width = 130;
            // 
            // chEmployeeLastName
            // 
            this.chEmployeeLastName.DisplayIndex = 2;
            this.chEmployeeLastName.Text = "Employee Lastname";
            this.chEmployeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeLastName.Width = 130;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 50;
            // 
            // chEmployeeBirthDate
            // 
            this.chEmployeeBirthDate.Text = "BirthDate";
            this.chEmployeeBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeBirthDate.Width = 100;
            // 
            // chEmployeeEmail
            // 
            this.chEmployeeEmail.Text = "E-mail";
            this.chEmployeeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeEmail.Width = 100;
            // 
            // chEmployeePhone
            // 
            this.chEmployeePhone.Text = "Phone";
            this.chEmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeePhone.Width = 100;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(765, 124);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEmployee.Location = new System.Drawing.Point(765, 68);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(89, 36);
            this.btnAddEmployee.TabIndex = 7;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditEmployee.Location = new System.Drawing.Point(765, 12);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(89, 36);
            this.btnEditEmployee.TabIndex = 6;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // AdminEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.lwAdmEmployeeEdit);
            this.Name = "AdminEmployeeForm";
            this.Text = "Employees management";
            this.Load += new System.EventHandler(this.AdminEmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwAdmEmployeeEdit;
        private System.Windows.Forms.ColumnHeader chEmployeeFirstName;
        private System.Windows.Forms.ColumnHeader chEmployeeLastName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chEmployeeBirthDate;
        private System.Windows.Forms.ColumnHeader chEmployeeEmail;
        private System.Windows.Forms.ColumnHeader chEmployeePhone;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
    }
}