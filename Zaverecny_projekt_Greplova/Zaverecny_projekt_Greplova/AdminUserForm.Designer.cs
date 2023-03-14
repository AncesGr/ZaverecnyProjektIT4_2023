namespace Zaverecny_projekt_Greplova
{
    partial class AdminUserForm
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
            this.lwAdmUserEdit = new System.Windows.Forms.ListView();
            this.chEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwAdmUserEdit
            // 
            this.lwAdmUserEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeName,
            this.chUserName,
            this.chID,
            this.chRole});
            this.lwAdmUserEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lwAdmUserEdit.FullRowSelect = true;
            this.lwAdmUserEdit.GridLines = true;
            this.lwAdmUserEdit.HideSelection = false;
            this.lwAdmUserEdit.Location = new System.Drawing.Point(0, 0);
            this.lwAdmUserEdit.Name = "lwAdmUserEdit";
            this.lwAdmUserEdit.Size = new System.Drawing.Size(424, 450);
            this.lwAdmUserEdit.TabIndex = 0;
            this.lwAdmUserEdit.UseCompatibleStateImageBehavior = false;
            this.lwAdmUserEdit.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.DisplayIndex = 1;
            this.chEmployeeName.Text = "Employee name";
            this.chEmployeeName.Width = 140;
            // 
            // chUserName
            // 
            this.chUserName.DisplayIndex = 2;
            this.chUserName.Text = "User name";
            this.chUserName.Width = 140;
            // 
            // chID
            // 
            this.chID.DisplayIndex = 0;
            this.chID.Text = "ID";
            this.chID.Width = 50;
            // 
            // chRole
            // 
            this.chRole.Text = "Role";
            this.chRole.Width = 80;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditUser.Location = new System.Drawing.Point(446, 12);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 36);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddUser.Location = new System.Drawing.Point(446, 64);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 36);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.lwAdmUserEdit);
            this.MinimumSize = new System.Drawing.Size(561, 497);
            this.Name = "AdminUserForm";
            this.Text = "Edit users";
            this.Load += new System.EventHandler(this.AdminUserEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwAdmUserEdit;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chUserName;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chRole;
        private System.Windows.Forms.Button btnAddUser;
    }
}