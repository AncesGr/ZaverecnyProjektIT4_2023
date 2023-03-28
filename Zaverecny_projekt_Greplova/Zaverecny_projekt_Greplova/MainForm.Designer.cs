namespace Zaverecny_projekt_Greplova
{
    partial class MainForm
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnAdmUsers = new System.Windows.Forms.Button();
            this.btnAdmRole = new System.Windows.Forms.Button();
            this.btnAdmEmployee = new System.Windows.Forms.Button();
            this.btnAdmContract = new System.Windows.Forms.Button();
            this.btnAdmWorkType = new System.Windows.Forms.Button();
            this.btnAdmWorkHours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmin.Location = new System.Drawing.Point(160, 29);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(122, 25);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin menu";
            // 
            // btnAdmUsers
            // 
            this.btnAdmUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmUsers.Location = new System.Drawing.Point(44, 76);
            this.btnAdmUsers.Name = "btnAdmUsers";
            this.btnAdmUsers.Size = new System.Drawing.Size(131, 42);
            this.btnAdmUsers.TabIndex = 2;
            this.btnAdmUsers.Text = "Users";
            this.btnAdmUsers.UseVisualStyleBackColor = false;
            this.btnAdmUsers.Click += new System.EventHandler(this.btnAdmUser_Click);
            // 
            // btnAdmRole
            // 
            this.btnAdmRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmRole.Location = new System.Drawing.Point(44, 156);
            this.btnAdmRole.Name = "btnAdmRole";
            this.btnAdmRole.Size = new System.Drawing.Size(131, 42);
            this.btnAdmRole.TabIndex = 3;
            this.btnAdmRole.Text = "Role";
            this.btnAdmRole.UseVisualStyleBackColor = false;
            this.btnAdmRole.Click += new System.EventHandler(this.btnAdmRole_Click);
            // 
            // btnAdmEmployee
            // 
            this.btnAdmEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmEmployee.Location = new System.Drawing.Point(44, 237);
            this.btnAdmEmployee.Name = "btnAdmEmployee";
            this.btnAdmEmployee.Size = new System.Drawing.Size(131, 42);
            this.btnAdmEmployee.TabIndex = 4;
            this.btnAdmEmployee.Text = "Employee";
            this.btnAdmEmployee.UseVisualStyleBackColor = false;
            this.btnAdmEmployee.Click += new System.EventHandler(this.btnAdmEmployee_Click);
            // 
            // btnAdmContract
            // 
            this.btnAdmContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmContract.Location = new System.Drawing.Point(252, 76);
            this.btnAdmContract.Name = "btnAdmContract";
            this.btnAdmContract.Size = new System.Drawing.Size(131, 42);
            this.btnAdmContract.TabIndex = 5;
            this.btnAdmContract.Text = "Contract";
            this.btnAdmContract.UseVisualStyleBackColor = false;
            // 
            // btnAdmWorkType
            // 
            this.btnAdmWorkType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmWorkType.Location = new System.Drawing.Point(252, 156);
            this.btnAdmWorkType.Name = "btnAdmWorkType";
            this.btnAdmWorkType.Size = new System.Drawing.Size(131, 42);
            this.btnAdmWorkType.TabIndex = 6;
            this.btnAdmWorkType.Text = "WorkType";
            this.btnAdmWorkType.UseVisualStyleBackColor = false;
            // 
            // btnAdmWorkHours
            // 
            this.btnAdmWorkHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmWorkHours.Location = new System.Drawing.Point(252, 237);
            this.btnAdmWorkHours.Name = "btnAdmWorkHours";
            this.btnAdmWorkHours.Size = new System.Drawing.Size(131, 42);
            this.btnAdmWorkHours.TabIndex = 7;
            this.btnAdmWorkHours.Text = "WorkHours";
            this.btnAdmWorkHours.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 331);
            this.Controls.Add(this.btnAdmWorkHours);
            this.Controls.Add(this.btnAdmWorkType);
            this.Controls.Add(this.btnAdmContract);
            this.Controls.Add(this.btnAdmEmployee);
            this.Controls.Add(this.btnAdmRole);
            this.Controls.Add(this.btnAdmUsers);
            this.Controls.Add(this.lblAdmin);
            this.Name = "MainForm";
            this.Text = "Admin menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnAdmUsers;
        private System.Windows.Forms.Button btnAdmRole;
        private System.Windows.Forms.Button btnAdmEmployee;
        private System.Windows.Forms.Button btnAdmContract;
        private System.Windows.Forms.Button btnAdmWorkType;
        private System.Windows.Forms.Button btnAdmWorkHours;
    }
}